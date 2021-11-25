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
    public partial class FormAccount : Form
    {
        public FormAccount()
        {
            InitializeComponent();
            LoadAccountList();
        }

        public void LoadAccountList()
        {
            string query = "SELECT * FROM dbo.Account";
            ListAccountGrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
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
            if(SearchTextbox.Text=="")
            {
                SearchTextbox.Text = "Search";
                SearchTextbox.ForeColor = Color.Gray;
                LoadAccountList();
            }    
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            DataTable filtertable = new DataTable();
            filtertable = AccountDAO.Instance.SearchAccount(SearchTextbox.Text);
            ListAccountGrid.DataSource = filtertable;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            FormAddAccount frm = new FormAddAccount(ListAccountGrid);
            frm.Owner = this;
            frm.ShowDialog();
            LoadAccountList();
        }

        private void ListAccountGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ListAccountGrid.Rows[e.RowIndex];

                if (ListAccountGrid.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    if (MessageBox.Show("Do you really want to delete this account?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        AccountDAO.Instance.DeleteAccount(row.Cells["Username"].Value.ToString());
                        LoadAccountList();
                    }
                }

                if (ListAccountGrid.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    FormAddAccount frm = new FormAddAccount(row.Cells["Username"].Value.ToString(), row.Cells["Password"].Value.ToString(), row.Cells["ID"].Value.ToString(), Convert.ToInt32(ListAccountGrid.CurrentRow.Cells["AccType"].Value));
                    frm.Owner = this;
                    frm.ShowDialog();
                    LoadAccountList();
                }
            }
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
