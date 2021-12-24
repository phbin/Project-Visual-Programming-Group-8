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
    public partial class FormMovieManage : Form
    {
        public FormMovieManage()
        {
            InitializeComponent();
            LoadMovie();
        }
        void LoadMovie()
        {
            string query = "SELECT ID, NameFilm, DatePublic, DateOut, TimeLimit, Director, Country FROM dbo.Movie";
            listMovieGrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void listMovieGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = listMovieGrid.Rows[e.RowIndex];

                if (listMovieGrid.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    if (MessageBox.Show("Do you really want to delete this movie?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        MovieDAO.Instance.DeleteMovie(row.Cells["ID"].Value.ToString());
                        LoadMovie();
                    }
                }

                if (listMovieGrid.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    MovieControls frm = new MovieControls(row.Cells["ID"].Value.ToString(), row.Cells["NameFilm"].Value.ToString(), Convert.ToDateTime(row.Cells["DatePublic"].Value), Convert.ToDateTime(row.Cells["DateOut"].Value), Convert.ToInt32(row.Cells["TimeLimit"].Value), row.Cells["Director"].Value.ToString(), row.Cells["Country"].Value.ToString());
                    frm.Owner = this;
                    frm.ShowDialog();
                    LoadMovie();
                }
            }
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            DataTable filtertable = new DataTable();
            filtertable = MovieDAO.Instance.SearchMovie(SearchTextbox.Text);
            listMovieGrid.DataSource = filtertable;
        }

        private void SearchTextbox_Enter(object sender, EventArgs e)
        {
            if (SearchTextbox.Text == "Search")
            {
                SearchTextbox.Text = "";
                SearchTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void SearchTextbox_Leave(object sender, EventArgs e)
        {
            if (SearchTextbox.Text == "")
            {
                SearchTextbox.Text = "Search";
                SearchTextbox.ForeColor = Color.Gray;
                LoadMovie();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MovieControls frm = new MovieControls();
            frm.ShowDialog();
            LoadMovie();
        }
    }
}
