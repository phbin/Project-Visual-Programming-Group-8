using QuanLiRapChieuPhim.DAO;
using QuanLiRapChieuPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim
{
    public partial class MovieControls : Form
    {
        public MovieControls()
        {
            InitializeComponent();
            LoadGenreIntoCheckListBox(clGenre);
            txtID.Text = CreateID();
            txtID.ReadOnly = true;
            buttonOK.BringToFront();
        }
        string CreateID()
        {
            string id = "";
            string query = "select * from Movie";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            for (int i = 0; i <= table.Rows.Count + 1; i++)
            {
                if (i < 10) id = "MV0" + i;
                else id = "MV" + i;
                foreach (DataRow rows in table.Rows)
                {
                    if (rows["ID"].ToString() != id) break;
                }
            }
            return id;
        }
        public MovieControls(string id, string name, DateTime dpublic, DateTime dout, int timelimit, string director, string country)
        {
            InitializeComponent();
            txtID.Text = id;
            txtID.ReadOnly = true;
            txtName.Text = name;
            dtpRelease.Value = dpublic;
            dtpExpiry.Value = dout;
            txtTime.Text = timelimit.ToString();
            txtDir.Text = director;
            cbCountry.Text = country;
            //load year of film
            string query = "SELECT YearFilm FROM dbo.Movie where id ='" + id + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow rows in table.Rows)
            {
                txtYear.Text = rows["YearFilm"].ToString();
            }
            //load poster
            query = "SELECT Poster FROM dbo.Movie where id ='" + id + "'";
            table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow rows in table.Rows)
            {
                pic = (byte[])rows["Poster"];

            }
            picPoster.BackgroundImage = MovieDAO.byteArrayToImage(pic);
            //load genre
            LoadGenreIntoCheckListBox(clGenre);
        }
        private byte[] pic;
        private void buttonCancel_Click(object sender, EventArgs e)
        {
          
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

            if (txtName.Text == "Name" || txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Please enter Name!");
                count++;
            }
            else
            {
                errorProvider1.SetError(txtName, null);
            }

            if (txtDir.Text == "Director" || txtDir.Text == "")
            {
                errorProvider1.SetError(txtDir, "Please enter Director!");
                count++;
            }
            else
            {
                errorProvider1.SetError(txtDir, null);
            }

            if (txtYear.Text == "Year" || txtYear.Text == "")
            {
                errorProvider1.SetError(txtYear, "Please enter Year!");
                count++;
            }
            else
            {
                errorProvider1.SetError(txtYear, null);
            }

            if (cbCountry.Text == "Country" || cbCountry.Text == "")
            {
                errorProvider1.SetError(cbCountry, "Please enter Country!");
                count++;
            }
            else
            {
                errorProvider1.SetError(cbCountry, null);
            }

            if (clGenre == null)
            {
                errorProvider1.SetError(clGenre, "Please enter Genre!");
                count++;
            }
            else
            {
                errorProvider1.SetError(clGenre, null);
            }
            //insert movie
            if (count == 0)
            {
                if (dtpRelease.Value > dtpExpiry.Value) MessageBox.Show("Release date must not greater than expiry date!");
                else if (dtpExpiry.Value < DateTime.Now) MessageBox.Show("Expiry date must not lesser than now");
                else if (picPoster.Image == null)
                {
                    MessageBox.Show("Please upload a image");
                    return;
                }
                else
                {
                    MovieDAO.Instance.InsertMovie(txtID.Text, txtName.Text, txtDesc.Text, Int32.Parse(txtTime.Text), dtpRelease.Value, dtpExpiry.Value, cbCountry.Text, txtDir.Text, Convert.ToInt32(txtYear.Text));
                    MovieDAO.Instance.imageToByteArray(filePathImage, txtID.Text);
                    //insert genre of movie
                    List<Genre> checkedGenreList = new List<Genre>();
                    foreach (Genre checkedItem in clGenre.CheckedItems)
                    {
                        checkedGenreList.Add(checkedItem);
                    }
                    MovieByGenreDAO.InsertMovie_Genre(txtID.Text, checkedGenreList);
                    MessageBox.Show("Movie added!");
                    txtName.Text = "Name";
                    txtTime.Text = "Running Time";
                    txtDir.Text = "Director";
                    txtYear.Text = "Year";
                    txtDesc.Text = "Description";
                    txtID.Text = "ID";

                    txtName.ForeColor = Color.FromArgb(190, 62, 66);
                    txtTime.ForeColor = Color.FromArgb(190, 62, 66);
                    txtDir.ForeColor = Color.FromArgb(190, 62, 66);
                    txtYear.ForeColor = Color.FromArgb(190, 62, 66);
                    txtDesc.ForeColor = Color.FromArgb(190, 62, 66);
                    txtID.ForeColor = Color.FromArgb(190, 62, 66);
                }
            }
        }

        void LoadGenreIntoCheckListBox(CheckedListBox clb)
        {
            List<Genre> genreList = GenreDAO.GetListGenre();
            clb.DataSource = genreList;
            clb.DisplayMember = "Name";
            List<Genre> listGenre = MovieByGenreDAO.GetGenre(txtID.Text);
            foreach (Genre item in listGenre)
            {
                for (int i = 0; i < genreList.Count; i++)
                {
                    if (item.Name == genreList[i].Name)
                        clb.SetItemChecked(i, true);
                }
            }
        }

        string filePathImage = "";

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

            if (txtName.Text == "Name" || txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Please enter Name!");
                count++;
            }
            else
            {
                errorProvider1.SetError(txtName, null);
            }

            if (txtDir.Text == "Director" || txtDir.Text == "")
            {
                errorProvider1.SetError(txtDir, "Please enter Director!");
                count++;
            }
            else
            {
                errorProvider1.SetError(txtDir, null);
            }

            if (txtYear.Text == "Year" || txtYear.Text == "")
            {
                errorProvider1.SetError(txtYear, "Please enter Year!");
                count++;
            }
            else
            {
                errorProvider1.SetError(txtYear, null);
            }

            if (cbCountry.Text == "Country" || cbCountry.Text == "")
            {
                errorProvider1.SetError(cbCountry, "Please enter Country!");
                count++;
            }
            else
            {
                errorProvider1.SetError(cbCountry, null);
            }

            if (clGenre == null)
            {
                errorProvider1.SetError(clGenre, "Please enter Genre!");
                count++;
            }
            else
            {
                errorProvider1.SetError(clGenre, null);
            }
            //update movie
            if (count == 0)
            {
                if (dtpRelease.Value > dtpExpiry.Value) MessageBox.Show("Release date must not greater than expiry date!");
                else if (dtpExpiry.Value < DateTime.Now) MessageBox.Show("Expiry date must not lesser than now");
                else if (picPoster.Image == null)
                {
                    MessageBox.Show("Please upload a image");
                    return;
                }
                else
                {
                    MovieDAO.Instance.UpdateMovie(txtID.Text, txtName.Text, txtDesc.Text, Int32.Parse(txtTime.Text), dtpRelease.Value, dtpExpiry.Value, cbCountry.Text, txtDir.Text, Convert.ToInt32(txtYear.Text));
                    if (filePathImage != "")
                    {
                        MovieDAO.Instance.imageToByteArray(filePathImage, txtID.Text);
                    }
                    //update genre of movie
                    List<Genre> checkedGenreList = new List<Genre>();
                    foreach (Genre checkedItem in clGenre.CheckedItems)
                    {
                        checkedGenreList.Add(checkedItem);
                    }
                    MovieByGenreDAO.UpdateMovie_Genre(txtID.Text, checkedGenreList);
                    //MessageBox.Show("Movie updated!");
                    this.Close();
                }
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.White;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Name";
                txtName.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void txtTime_Enter(object sender, EventArgs e)
        {
            if (txtTime.Text == "Running Time")
            {
                txtTime.Text = "";
                txtTime.ForeColor = Color.White;
            }
        }

        private void txtTime_Leave(object sender, EventArgs e)
        {
            if (txtTime.Text == "")
            {
                txtTime.Text = "Running Time";
                txtTime.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void txtDir_Enter(object sender, EventArgs e)
        {
            if (txtDir.Text == "Director")
            {
                txtDir.Text = "";
                txtDir.ForeColor = Color.White;
            }
        }

        private void txtDir_Leave(object sender, EventArgs e)
        {
            if (txtDir.Text == "")
            {
                txtDir.Text = "Director";
                txtDir.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void txtYear_Enter(object sender, EventArgs e)
        {
            if (txtYear.Text == "Year")
            {
                txtYear.Text = "";
                txtYear.ForeColor = Color.White;
            }
        }

        private void txtYear_Leave(object sender, EventArgs e)
        {
            if (txtYear.Text == "")
            {
                txtYear.Text = "Year";
                txtYear.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void txtDesc_Enter(object sender, EventArgs e)
        {
            if (txtDesc.Text == "Description")
            {
                txtDesc.Text = "";
                txtDesc.ForeColor = Color.White;
            }
        }

        private void txtDesc_Leave(object sender, EventArgs e)
        {
            if (txtDesc.Text == "")
            {
                txtDesc.Text = "Description";
                txtDesc.ForeColor = Color.FromArgb(190, 62, 66);
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMovieManage.ActiveForm.Activate();
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            Thread t = new Thread((ThreadStart)(() =>
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                openFile.FilterIndex = 1;
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    filePathImage = openFile.FileName;
                    //picPoster.BackgroundImage = openFile.FileName;
                    picPoster.Image = Image.FromFile(filePathImage.ToString());
                }
            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }

        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
