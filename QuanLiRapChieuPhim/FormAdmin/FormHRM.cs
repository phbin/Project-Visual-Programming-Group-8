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
            string query = "SELECT * FROM InfoStaff";
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

                string ID, FullName, DoB, Sex, Address, PhoneNum, Email, IDPersonal;
                ID = row.Cells["ID"].Value.ToString();
                FullName = row.Cells["FUllName"].Value.ToString();
                DoB = row.Cells["DoB"].Value.ToString();
                Sex = row.Cells["Sexx"].Value.ToString();
                Address = row.Cells["Address"].Value.ToString();
                PhoneNum = row.Cells["Phone"].Value.ToString();
                Email = row.Cells["Email"].Value.ToString();
                IDPersonal = row.Cells["IDPersonal"].Value.ToString();

                if (InfoStaffGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    FormAddInfoStaff frm = new FormAddInfoStaff(ID, FullName, DoB, Sex, Address, PhoneNum, Email, IDPersonal);
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

        private void AddButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddButton.BackColor = Color.FromArgb(199, 80, 87);
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.BackColor = Color.FromArgb(190, 62, 66);
        }
    }
}
