﻿using QuanLiRapChieuPhim.DAO;
using QuanLiRapChieuPhim.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim
{
    public partial class MovieControls : Form
    {
        public MovieControls()
        {
            InitializeComponent();
            LoadGenreIntoCheckListBox(clGenre);
            buttonOK.BringToFront();
        }
        public MovieControls(string id, string name, DateTime dpublic, DateTime dout, int timelimit, string director, string country)
        {
            buttonEdit.BringToFront();
            InitializeComponent();
            txtID.Text = id;
            txtID.ReadOnly = true;
            txtName.Text = name;
            dtpRelease.Value = dpublic;
            dtpExpiry.Value = dout;
            txtTime.Text = timelimit.ToString();
            txtDir.Text = director;
            cbCountry.Text = country;
            string query = "SELECT YearFilm FROM dbo.Movie where id ='" + id + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow rows in table.Rows)
            {
                txtYear.Text = rows["YearFilm"].ToString();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormMovieManage.ActiveForm.Activate();
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //insert movie
            if (txtID.Text != "" && txtName.Text != "" && txtDir.Text != "" && txtYear.Text != "" && cbCountry.Text != "" && clGenre.SelectedItem != null)
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
                    MovieDAO.Instance.InsertMovie(txtID.Text, txtName.Text, txtDesc.Text, Int32.Parse(txtTime.Text), dtpRelease.Value, dtpExpiry.Value, cbCountry.Text, txtDir.Text, Convert.ToInt32(txtYear.Text), MovieDAO.imageToByteArray(picPoster.Image));
                    //insert genre of movie
                    List<Genre> checkedGenreList = new List<Genre>();
                    foreach (Genre checkedItem in clGenre.CheckedItems)
                    {
                        checkedGenreList.Add(checkedItem);
                    }
                    MovieByGenreDAO.InsertMovie_Genre(txtID.Text, checkedGenreList);
                    MessageBox.Show("Movie added!");
                    FormMovieManage.ActiveForm.Activate();
                }
            }
            else MessageBox.Show("Please fill the information!");
        }
    
        void LoadGenreIntoCheckListBox(CheckedListBox clb)
        {
            List<Genre> genreList = GenreDAO.GetListGenre();
            clb.DataSource = genreList;
            clb.DisplayMember = "Name";
        }
        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        string filePathImage = null;

        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
         
        private void buttonLoadImg_Click(object sender, EventArgs e)
        {
            Thread t = new Thread((ThreadStart)(() => {
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
        
        private void buttonEdit_Click(object sender, EventArgs e)
        {
        }
    }
}