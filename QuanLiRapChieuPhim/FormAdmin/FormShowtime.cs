using QuanLiRapChieuPhim.DAO;
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
    public partial class FormShowtime : Form
    {
        public FormShowtime()
        {
            InitializeComponent();
            LoadShowtime();
        }
        string id = "";
        void LoadShowtime()
        {
            string query = "EXEC USP_GetShowtime";
            listShowtimeGrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void LoadShowtimeByRoom(string id)
        {
            string query = "EXEC USP_GetShowtimeByRoom '" + id + "'";
            listShowtimeGrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void listShowtimeGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = listShowtimeGrid.Rows[e.RowIndex];

                if (listShowtimeGrid.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    if (MessageBox.Show("Do you really want to delete this account?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        ShowtimeDAO.Instance.DeleteShowtime(row.Cells["ID"].Value.ToString());
                        LoadShowtime();
                    }
                }

                if (listShowtimeGrid.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    ShowtimeControls frm = new ShowtimeControls(row.Cells["ID"].Value.ToString(), row.Cells["NameFilm"].Value.ToString(), row.Cells["shTime"].Value.ToString(), Convert.ToString(row.Cells["IDRoom"].Value));
                    frm.Owner = this;
                    frm.ShowDialog();
                    LoadShowtime();
                }
            }
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            LoadShowtime();
            buttonAll.BackColor = Color.FromArgb(32, 90, 167);
            buttonRoom1.BackColor = Color.FromArgb(191, 202, 230);
            buttonRoom2.BackColor = Color.FromArgb(191, 202, 230);
            buttonRoom3.BackColor = Color.FromArgb(191, 202, 230);
        }

        private void buttonRoom1_Click(object sender, EventArgs e)
        {
            id = "PC01";
            LoadShowtimeByRoom(id);
            buttonAll.BackColor = Color.FromArgb(191, 202, 230);
            buttonRoom1.BackColor = Color.FromArgb(32, 90, 167);
            buttonRoom2.BackColor = Color.FromArgb(191, 202, 230);
            buttonRoom3.BackColor = Color.FromArgb(191, 202, 230);
        }

        private void buttonRoom2_Click(object sender, EventArgs e)
        {
            id = "PC02";
            LoadShowtimeByRoom(id);
            buttonAll.BackColor = Color.FromArgb(191, 202, 230);
            buttonRoom1.BackColor = Color.FromArgb(191, 202, 230);
            buttonRoom2.BackColor = Color.FromArgb(32, 90, 167);
            buttonRoom3.BackColor = Color.FromArgb(191, 202, 230);
        }

        private void buttonRoom3_Click(object sender, EventArgs e)
        {
            id = "PC03";
            LoadShowtimeByRoom(id);
            buttonAll.BackColor = Color.FromArgb(191, 202, 230);
            buttonRoom1.BackColor = Color.FromArgb(191, 202, 230);
            buttonRoom2.BackColor = Color.FromArgb(191, 202, 230);
            buttonRoom3.BackColor = Color.FromArgb(32, 90, 167);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowtimeControls frm = new ShowtimeControls();
            frm.Show();
        }
    }
}
