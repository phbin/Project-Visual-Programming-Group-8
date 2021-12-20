using QuanLiRapChieuPhim.AddForms;
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
    public partial class FormHRM : Form
    {
        public FormHRM()
        {
            InitializeComponent();
            LoadInfoStaff();
        }

        void LoadInfoStaff()
        {
            string query = "SELECT ID, FullName, format(DoB,'dd/MM/yyyy') as DoB , Sex, Addr, Phone, Email, IDPersonal FROM InfoStaff";
            InfoStaffGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void SearchTextbox_Enter_1(object sender, EventArgs e)
        {
            if (SearchTextbox.Text == "Search")
            {
                SearchTextbox.Text = "";
                SearchTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void SearchTextbox_Leave_1(object sender, EventArgs e)
        {
            if (SearchTextbox.Text == "")
            {
                SearchTextbox.Text = "Search";
                SearchTextbox.ForeColor = Color.Gray;
                LoadInfoStaff();
            }
        }

        private void SearchTextbox_TextChanged_1(object sender, EventArgs e)
        {
            DataTable filtertable = new DataTable();
            filtertable = AccountDAO.Instance.SearchInfoStaff(SearchTextbox.Text);
            InfoStaffGridView.DataSource = filtertable;
        }

        private void InfoStaffGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = InfoStaffGridView.Rows[e.RowIndex];

                if (InfoStaffGridView.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    if (MessageBox.Show("Do you really want to delete this staff infomation?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        AccountDAO.Instance.DeleteInfoStaff(row.Cells["ID"].Value.ToString());
                        LoadInfoStaff();
                    }
                }

                if (InfoStaffGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    FormAddInfoStaff frm = new FormAddInfoStaff(row.Cells["ID"].Value.ToString(), row.Cells["FUllName"].Value.ToString(), row.Cells["DoB"].Value.ToString(), row.Cells["Sexx"].Value.ToString(), row.Cells["Address"].Value.ToString(), row.Cells["Phone"].Value.ToString(), row.Cells["Email"].Value.ToString(), row.Cells["IDPersonal"].Value.ToString());
                    frm.Owner = this;
                    frm.ShowDialog();
                    LoadInfoStaff();
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            FormAddInfoStaff frm = new FormAddInfoStaff(InfoStaffGridView);
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
