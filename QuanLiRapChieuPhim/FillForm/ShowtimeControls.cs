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
        }
        DataGridView showtimedtg = new DataGridView();
        string IDST = "";
        string CreateID()
        {
            string query = "select * from Showtime";
            DataTable table= DataProvider.Instance.ExecuteQuery(query);

            for (int i = 0; i <= table.Rows.Count+1; i++)
            {
                if (i < 10) IDST = "ST0" + i;
                else IDST = "ST" + i;
                foreach (DataRow rows in table.Rows)
                {
                    if (rows["ID"].ToString() != IDST) break;
                }
            }
            return IDST;
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
        }
        void LoadMovieIntoComboBox(ComboBox cbb)
        {
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat= "yyyy/MM/dd hh:mm tt";
            DataTable tb =DataProvider.Instance.ExecuteQuery("Select * from dbo.Movie where DateOut>getdate()");
            cbb.DataSource = tb;
            cbb.DisplayMember = "NameFilm";
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
                //if (dtpTime.Value < DateTime.Now) MessageBox.Show("Showtime must not greater than now!");
                //else if (dtpTime.Value > GetDate(cbIDMovie.Text)) MessageBox.Show("Showtime must not greater than Expiry Date");
                //else
                //{
                    ShowtimeDAO.Instance.UpdateShowtime(txtID.Text, GetIDMovie(cbIDMovie.Text), dtpTime.Text, cbIDRoom.Text);
                   // MessageBox.Show("" + GetIDMovie(cbIDMovie.Text));

                    MessageBox.Show("Showtime updated!");
                //}
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
                //else if (dtpTime.Value > GetDate(cbIDMovie.Text)) MessageBox.Show("Showtime must not greater than Expiry Date");
                else
                {
                    ShowtimeDAO.Instance.InsertShowtime(txtID.Text, GetIDMovie(cbIDMovie.Text), dtpTime.Text, cbIDRoom.Text, Convert.ToInt32(txtPrice.Text));
                    //MessageBox.Show("" + GetIDMovie(cbIDMovie.Text));

                    MessageBox.Show("Showtime added!");
                    txtID.Text = "ID";
                    txtPrice.Text = "110000";
                    txtID.ForeColor = Color.FromArgb(190, 62, 66);
                    txtPrice.ForeColor = Color.White;
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
                txtPrice.Text = "Price";
                txtPrice.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            ShowtimeControls.ActiveForm.Activate();
        }
    }
}
