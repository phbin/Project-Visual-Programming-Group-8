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
            string query = "EXEC USP_GetShowtimeByRoom '"+id+"'";
            listShowtimeGrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void buttonRoom1_Click(object sender, EventArgs e)
        {
            id = "PC01";
            LoadShowtimeByRoom(id);
            buttonAll.BackColor = Color.Black;
            buttonRoom1.BackColor = Color.Gray;
            buttonRoom2.BackColor = Color.Black;
            buttonRoom3.BackColor = Color.Black;
        }

        private void buttonRoom2_Click(object sender, EventArgs e)
        {
            id = "PC02";
            LoadShowtimeByRoom(id);
            buttonAll.BackColor = Color.Black;
            buttonRoom1.BackColor = Color.Black;
            buttonRoom2.BackColor = Color.Gray;
            buttonRoom3.BackColor = Color.Black;
        }

        private void buttonRoom3_Click(object sender, EventArgs e)
        {
            id = "PC03";
            LoadShowtimeByRoom(id);
            buttonAll.BackColor = Color.Black;
            buttonRoom1.BackColor = Color.Black;
            buttonRoom2.BackColor = Color.Black;
            buttonRoom3.BackColor = Color.Gray;
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            LoadShowtime();
            buttonAll.BackColor = Color.Gray;
            buttonRoom1.BackColor = Color.Black;
            buttonRoom2.BackColor = Color.Black;
            buttonRoom3.BackColor = Color.Black;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowtimeControls frm = new ShowtimeControls();
            frm.Show();
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

                //if (listShowtimeGrid.Columns[e.ColumnIndex].HeaderText == "Edit")
                //{
                //    ShowtimeControls frm = new ShowtimeControls(row.Cells["ID"].Value.ToString(), row.Cells["Movie Name"].Value.ToString(), Convert.ToDateTime(row.Cells["Showtime"].Value), Convert.ToString(row.Cells["IDRoom"].Value), row.Cells["Ticke tPrice"].Value.ToString());
                //    frm.Owner = this;
                //    frm.ShowDialog();
                //    LoadShowtime();
                //}
            }
        }
    }

}
