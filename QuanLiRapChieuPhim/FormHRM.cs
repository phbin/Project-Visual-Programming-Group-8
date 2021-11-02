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
            InfoStaffGridView.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa thông tin này?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                AccountDAO.Instance.DeleteInfoStaff(IDTextbox.Text);
                IDTextbox.Text = "";
                FullNameTextbox.Text = "";
                DoBTextbox.Text = "";
                AddressTextbox.Text = "";
                PhoneNumTextbox.Text = "";
                IDPersonalTextbox.Text = "";
                LoadInfoStaff();
            }
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
                //gets a collection that contains all the rows
                DataGridViewRow row = this.InfoStaffGridView.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                IDTextbox.Text = row.Cells[0].Value.ToString();
                FullNameTextbox.Text = row.Cells[1].Value.ToString();
                DoBTextbox.Text = row.Cells[2].Value.ToString();
                AddressTextbox.Text = row.Cells[3].Value.ToString();
                PhoneNumTextbox.Text = row.Cells[4].Value.ToString();
                IDPersonalTextbox.Text = row.Cells[5].Value.ToString();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            DateTime DayofBirth = Convert.ToDateTime(DoBTextbox.Text);
            string sqlFormattedDate = DayofBirth.ToString("yyyy-MM-dd HH:mm:ss.fff");
            if (MessageBox.Show("Bạn có thật sự muốn thay đổi thông tin này?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                AccountDAO.Instance.EditInfoStaff(IDTextbox.Text, FullNameTextbox.Text, sqlFormattedDate, AddressTextbox.Text, PhoneNumTextbox.Text, IDPersonalTextbox.Text);
                IDTextbox.Text = "";
                FullNameTextbox.Text = "";
                DoBTextbox.Text = "";
                AddressTextbox.Text = "";
                PhoneNumTextbox.Text = "";
                IDPersonalTextbox.Text = "";
            }
            LoadInfoStaff();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < InfoStaffGridView.Rows.Count; i++)
            {
                if (IDTextbox.Text == InfoStaffGridView.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                    IDTextbox.Text = "";
                    IDTextbox.Focus();
                    return;
                }
            }

            if (IDTextbox.Text != "" && FullNameTextbox.Text != "" && DoBTextbox.Text!="" && AddressTextbox.Text!="" && PhoneNumTextbox.Text!="" && IDPersonalTextbox.Text != "") 
            {
                DateTime DayofBirth = DateTime.Parse(DoBTextbox.Text);
                string sqlFormattedDate = DayofBirth.ToString("yyyy-MM-dd HH:mm:ss.fff");
                AccountDAO.Instance.AddInfoStaff(IDTextbox.Text,FullNameTextbox.Text,sqlFormattedDate,AddressTextbox.Text,PhoneNumTextbox.Text,IDPersonalTextbox.Text);
                IDTextbox.Text = "";
                FullNameTextbox.Text = "";
                DoBTextbox.Text = "";
                AddressTextbox.Text = "";
                PhoneNumTextbox.Text = "";
                IDPersonalTextbox.Text = "";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            }
            LoadInfoStaff();
        }

        private void FormHRM_Click_1(object sender, EventArgs e)
        {
            IDTextbox.Text = "";
            FullNameTextbox.Text = "";
            DoBTextbox.Text = "";
            AddressTextbox.Text = "";
            PhoneNumTextbox.Text = "";
            IDPersonalTextbox.Text = "";
        }
    }
}
