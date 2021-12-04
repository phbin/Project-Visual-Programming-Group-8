using QuanLiRapChieuPhim.ChildForms;
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
    public partial class FormCustomer : Form
    {
        internal Customer customer;

        public FormCustomer()
        {
            InitializeComponent();
            LoadInfoCustomer();
        }

        void LoadInfoCustomer()
        {
            string query = "SELECT * FROM dbo.InfoCustomer";
            ListCustomerGrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
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
                LoadInfoCustomer();
            }
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            DataTable filtertable = new DataTable();
            string query = "SELECT * FROM dbo.InfoCustomer WHERE FullName LIKE '%" + SearchTextbox.Text + "%'";
            filtertable = DataProvider.Instance.ExecuteQuery(query);
            ListCustomerGrid.DataSource = filtertable;
        }

        private void ListCustomerGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ListCustomerGrid.Rows[e.RowIndex];

                if (ListCustomerGrid.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    if (MessageBox.Show("Do you really want to delete this account?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        string query = "DELETE FROM dbo.InfoCustomer WHERE ID='" + row.Cells["ID"].Value.ToString() + "'";
                        DataProvider.Instance.ExecuteQuery(query);
                        LoadInfoCustomer();
                    }
                }

                if (ListCustomerGrid.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    FormAddCustomer frm = new FormAddCustomer(row.Cells["ID"].Value.ToString(), row.Cells["FullName"].Value.ToString(), row.Cells["DoB"].Value.ToString(), row.Cells["Address"].Value.ToString(), row.Cells["Phone"].Value.ToString(), row.Cells["IDPersonal"].Value.ToString(), row.Cells["Points"].Value.ToString());
                    frm.Owner = this;
                    frm.ShowDialog();
                    LoadInfoCustomer();
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            FormAddCustomer frm = new FormAddCustomer(ListCustomerGrid);
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
