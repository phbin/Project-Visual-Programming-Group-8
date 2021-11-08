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

        void LoadAccountList()
        {
            string query = "SELECT * FROM dbo.Account";

            ListAccountGrid.DataSource = DataProvider.Instance.ExcuteQuery(query);

            //ListAccountGrid.ClearSelection();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int admin = 0;
            if (AdminCheckbox.Checked)
                admin = 1;

            for(int i=0;i<ListAccountGrid.Rows.Count;i++)
            {
                if(UsernameTextbox.Text == ListAccountGrid.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                    UsernameTextbox.Text = "";
                    UsernameTextbox.Focus();
                    return;
                }
            }    
           
            if(UsernameTextbox.Text!="" && PasswordTextbox.Text!="")
            {
                AccountDAO.Instance.AddAcount(UsernameTextbox.Text, PasswordTextbox.Text, IDTextbox.Text, admin);
                UsernameTextbox.Text = "";
                PasswordTextbox.Text = "";
                IDTextbox.Text = "";
                AdminCheckbox.Checked = false;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            }
            LoadAccountList();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn xóa tài khoản này?","Thông báo",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                AccountDAO.Instance.DeleteAccont(UsernameTextbox.Text);
                UsernameTextbox.Text = "";
                PasswordTextbox.Text = "";
                IDTextbox.Text = "";
                AdminCheckbox.Checked = false;
                LoadAccountList();
            }   
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

        private void ListAccountGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.ListAccountGrid.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                UsernameTextbox.Text = row.Cells[0].Value.ToString();
                PasswordTextbox.Text = row.Cells[1].Value.ToString();
                IDTextbox.Text = row.Cells[2].Value.ToString();
                if(row.Cells[3].Value.ToString() == "1")
                {
                    AdminCheckbox.Checked = true;
                }   
                else
                {
                    AdminCheckbox.Checked = false;
                }    
            }
        }

        private void FormAccount_Click(object sender, EventArgs e)
        {
            UsernameTextbox.Text = "";
            PasswordTextbox.Text = "";
            IDTextbox.Text = "";
            AdminCheckbox.Checked = false;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int admin = 0;
            if (AdminCheckbox.Checked)
                admin = 1;
            if (MessageBox.Show("Bạn có thật sự muốn thay đổi thông tin này?","Thông báo",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                AccountDAO.Instance.EditAccount(UsernameTextbox.Text, PasswordTextbox.Text, IDTextbox.Text, admin);
                UsernameTextbox.Text = "";
                PasswordTextbox.Text = "";
                IDTextbox.Text = "";
            }
            LoadAccountList();
        }
    }
}
