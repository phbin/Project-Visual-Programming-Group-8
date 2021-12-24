using QuanLiRapChieuPhim.DAO;
using QuanLiRapChieuPhim.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim
{
    public partial class ShowtimeControls : Form
    {
        public ShowtimeControls()
        {
            InitializeComponent();
            LoadMovieIntoComboBox(cbIDMovie);
            buttonOK.BringToFront();
            txtID.Text = CreateID();
            txtID.ReadOnly = true;
            string query = "EXEC USP_GetShowtime";
            showtimedtg.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtg.Hide();
            dtg1.Hide();
        }
        public ShowtimeControls(string id, string name, string showtime, string idroom)
        {
            InitializeComponent();
            LoadMovieIntoComboBox(cbIDMovie);
            txtID.Text = id;
            txtID.ReadOnly = true;
            cbIDMovie.Text = name;
            //cbIDMovie.Enabled = false;
            dtpTime.Text = showtime;
            cbIDRoom.Text = idroom;
            string query = "EXEC USP_GetShowtime";
            showtimedtg.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtg.Hide();
            dtg1.Hide();
            txtID.ForeColor = Color.White;
        }
        void LoadMovieIntoComboBox(ComboBox cbb)
        {
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = "yyyy/MM/dd hh:mm tt";
            DataTable tb = DataProvider.Instance.ExecuteQuery("Select * from dbo.Movie where DateOut>getdate()");
            cbb.DataSource = tb;
            cbb.DisplayMember = "NameFilm";
        }
        private bool isEmpty(string IDRoom, DateTime dt, string NameFilm)
        {
            int Year = dt.Year;
            int Month = dt.Month;
            int Day = dt.Day;

            string query = "SELECT IDRoom as IDRoom, shTime as ShowTime, TimeLimit as TimeLimit, Movie.ID as IDMovie FROM Movie, ShowTime WHERE Movie.ID = ShowTime.IDMovie AND Year(shTime) = " + Year + " AND Month(shTime) = " + Month + " AND Day(shTime) = " + Day + " ORDER BY shTime";
            dtg.DataSource = DataProvider.Instance.ExecuteQuery(query);

            int n = dtg.Rows.Count;

            string query1 = "SELECT TimeLimit FROM Movie WHERE ID = '" + GetIDMovie(NameFilm) + "'";
            dtg1.DataSource = DataProvider.Instance.ExecuteQuery(query1);


            int TimeLimit = int.Parse(dtg1.Rows[0].Cells["TimeLimit"].Value.ToString());
            DateTime thisTime = dt.AddMinutes(TimeLimit);

            if (dtg.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                int i = 0;
                while (i < dtg.Rows.Count)
                {
                    DateTime pre = DateTime.Parse(dtg.Rows[i].Cells["ShowTime"].Value.ToString());
                    DateTime preTime = pre.AddMinutes(int.Parse(dtg.Rows[i].Cells["TimeLimit"].Value.ToString()));
                    
                    if (DateTime.Compare(dt, pre) < 0)
                    {
                        if (DateTime.Compare(thisTime, pre) > 0)
                            return false;
                    }

                    if (DateTime.Compare(dt, pre) == 0)
                        return false;

                    if (DateTime.Compare(dt, pre) > 0)
                    {
                        if (DateTime.Compare(dt, preTime) < 0)
                            return false;
                    }
                    i++;
                }
            }
            return true;
        }

        DataGridView showtimedtg = new DataGridView();
        string IDST = "";
        string CreateID()
        {
            string query = "select * from Showtime";
            DataTable table= DataProvider.Instance.ExecuteQuery(query);
            int j = 0;
            for (int i = 1; i <= table.Rows.Count+1; i++)
            {
                if (i < 10) IDST = "ST0" + i;
                else IDST = "ST" + i;
                while (j < table.Rows.Count)
                {
                    DataRow rows = table.Rows[j];
                    if (rows["ID"].ToString() != IDST) return IDST;
                    else
                    {
                        j++;
                        break;
                    }
                }

            }
            return IDST;
        }
      
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (txtID.Text == "ID" || txtID.Text == "")
            {
                errorProvider1.SetError(txtID, "Please enter ID!");
                count++;
            }
            else
            {
                errorProvider1.SetError(txtID, null);
            }


            if (cbIDMovie.Text == "Movie" || txtID.Text == "")
            {
                errorProvider1.SetError(cbIDMovie, "Please enter Movie!");
                count++;
            }
            else
            {
                errorProvider1.SetError(cbIDMovie, null);
            }

            if (cbIDRoom.Text == "Room" || cbIDRoom.Text == "")
            {
                errorProvider1.SetError(cbIDRoom, "Please enter Room!");
                count++;
            }
            else
            {
                errorProvider1.SetError(cbIDRoom, null);
            }

            if (txtPrice.Text == "Price" || txtPrice.Text == "")
            {
                errorProvider1.SetError(txtPrice, "Please enter Price!");
                count++;
            }
            else
            {
                errorProvider1.SetError(txtPrice, null);
            }
            //update showtime
            if (count == 0)
            {
                for (int i=0;i<showtimedtg.Rows.Count;i++)
                {
                    if(dtpTime.Text == showtimedtg.Rows[i].Cells["shTime"].Value.ToString() && cbIDRoom.Text == showtimedtg.Rows[i].Cells["Room"].Value.ToString())
                    {
                        MessageBox.Show("This time is not empty!");
                        return;
                    }    
                }
                if (dtpTime.Value < DateTime.Now) MessageBox.Show("Showtime must not lesser than now!");

                else if (isEmpty(cbIDRoom.Text, dtpTime.Value, cbIDMovie.Text) == false)
                {
                    MessageBox.Show("This time is not empty!");
                }
                else if (GetReleaseDate(cbIDMovie.Text) > dtpTime.Value)
                {
                    MessageBox.Show("This movie is not ready to public!");
                }
                else if (GetExpiryDate(cbIDMovie.Text) < dtpTime.Value)
                {
                    MessageBox.Show("This movie is end!");
                }
                else
                {
                    ShowtimeDAO.Instance.UpdateShowtime(txtID.Text, GetIDMovie(cbIDMovie.Text), dtpTime.Text, cbIDRoom.Text,110000);
                    this.Close();
                }

            }
        }
        string idmovie;
        private string GetIDMovie(string name)
        {
            string query = "SELECT ID FROM dbo.Movie where namefilm = N'" + name + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow rows in table.Rows)
            {
                idmovie = rows["ID"].ToString();
            }
            return idmovie;
        }

        DateTime GetReleaseDate(string name)
        {
            DateTime rldate = DateTime.Now;
            DataTable tb = DataProvider.Instance.ExecuteQuery("Select * from dbo.Movie where namefilm=N'"+name+"'");
            foreach (DataRow rows in tb.Rows)
            {
                rldate = Convert.ToDateTime( rows["DatePublic"]);
            }
            return rldate;
        }
        DateTime GetExpiryDate(string name)
        {
            DateTime rldate = DateTime.Now;
            DataTable tb = DataProvider.Instance.ExecuteQuery("Select * from dbo.Movie where namefilm=N'" + name + "'");
            foreach (DataRow rows in tb.Rows)
            {
                rldate = Convert.ToDateTime(rows["DateOut"]);
            }
            return rldate;
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (txtID.Text == "ID" || txtID.Text == "")
            {
                errorProvider1.SetError(txtID, "Please enter ID!");
                count++;
            }
            else
            {
                errorProvider1.SetError(txtID, null);
            }


            if (cbIDMovie.Text == "Movie" || txtID.Text == "")
            {
                errorProvider1.SetError(cbIDMovie, "Please enter Movie!");
                count++;
            }
            else
            {
                errorProvider1.SetError(cbIDMovie, null);
            }

            if (cbIDRoom.Text == "Room" || cbIDRoom.Text == "")
            {
                errorProvider1.SetError(cbIDRoom, "Please enter Room!");
                count++;
            }
            else
            {
                errorProvider1.SetError(cbIDRoom, null);
            }

            if (txtPrice.Text == "Price" || txtPrice.Text == "")
            {
                errorProvider1.SetError(txtPrice, "Please enter Price!");
                count++;
            }
            else
            {
                errorProvider1.SetError(txtPrice, null);
            }

            if (count == 0)
            {
                for (int i = 0; i < showtimedtg.Rows.Count; i++)
                {
                    if (dtpTime.Text == showtimedtg.Rows[i].Cells["shTime"].Value.ToString() && cbIDRoom.Text == showtimedtg.Rows[i].Cells["Room"].Value.ToString())
                    {
                        MessageBox.Show("This time is not empty!");
                        break;
                    }
                }
                if (dtpTime.Value < DateTime.Now) MessageBox.Show("Showtime must not lesser than now!");


                else if (isEmpty(cbIDRoom.Text, dtpTime.Value, cbIDMovie.Text) == false)
                {
                    MessageBox.Show("This time is not empty!");
                }
                else if(GetReleaseDate(cbIDMovie.Text)>dtpTime.Value)
                {
                    MessageBox.Show("This movie is not ready to public!");
                }
                else if (GetExpiryDate(cbIDMovie.Text) < dtpTime.Value)
                {
                    MessageBox.Show("This movie is end!");
                }

                //else if (dtpTime.Value > GetDate(cbIDMovie.Text)) MessageBox.Show("Showtime must not greater than Expiry Date");
                else
                {
                    ShowtimeDAO.Instance.InsertShowtime(txtID.Text, GetIDMovie(cbIDMovie.Text), dtpTime.Text, cbIDRoom.Text, Convert.ToInt32(txtPrice.Text));
                    MessageBox.Show("Showtime added!");
                    txtID.Text = "ID";
                    txtPrice.Text = "110000";
                    txtID.ForeColor = Color.FromArgb(190, 62, 66);
                    txtPrice.ForeColor = Color.White;
                    txtID.Text = CreateID();
                }
            }
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "ID")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.White;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtID.Text = "ID";
                txtID.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            if (txtPrice.Text == "110000" || txtPrice.Text == "Price")
            {
                txtPrice.Text = "";
                txtPrice.ForeColor = Color.White;
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (txtPrice.Text == "")
            {
                txtPrice.Text = "110000";
                txtPrice.ForeColor = Color.White;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            ShowtimeControls.ActiveForm.Activate();
        }
    }
}
