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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
            LoadInfoCustomer();
        }

        void LoadInfoCustomer()
        {
            string query = "SELECT * FROM dbo.InfoCustomer";
            ListCustomerGrid.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa thông tin khách hàng này?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string query = "DELETE FROM dbo.InfoCustomer WHERE ID='" + IDTextbox.Text + "'";
                DataProvider.Instance.ExcuteQuery(query);
                IDTextbox.Text = "";
                FullNameTextbox.Text = "";
                DoBTextbox.Text = "";
                AddressTextbox.Text = "";
                PhoneNumTextbox.Text = "";
                IDPersonalTextbox.Text = "";
                PointTextbox.Text = "";
                LoadInfoCustomer();
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
            filtertable = DataProvider.Instance.ExcuteQuery(query);
            ListCustomerGrid.DataSource = filtertable;
        }

        private void ListCustomerGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.ListCustomerGrid.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                IDTextbox.Text = row.Cells[0].Value.ToString();
                FullNameTextbox.Text = row.Cells[1].Value.ToString();
                DoBTextbox.Text = row.Cells[2].Value.ToString();
                AddressTextbox.Text = row.Cells[3].Value.ToString();
                PhoneNumTextbox.Text = row.Cells[4].Value.ToString();
                IDPersonalTextbox.Text = row.Cells[5].Value.ToString();
                PointTextbox.Text = row.Cells[6].Value.ToString();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn sửa thông tin này?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DateTime DayofBirth = Convert.ToDateTime(DoBTextbox.Text);
                string sqlFormattedDate = DayofBirth.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string query = "UPDATE dbo.InfoCustomer SET FullName=N'" + FullNameTextbox.Text + "', DoB='" + sqlFormattedDate + "', Addr='" + AddressTextbox.Text + "', Phone='" + PhoneNumTextbox.Text + "', IDPersonal='" + IDPersonalTextbox.Text + "', Points=" + int.Parse(PointTextbox.Text) + " WHERE ID='" + IDTextbox.Text + "'";
                DataProvider.Instance.ExcuteQuery(query);
                IDTextbox.Text = "";
                FullNameTextbox.Text = "";
                DoBTextbox.Text = "";
                AddressTextbox.Text = "";
                PhoneNumTextbox.Text = "";
                IDPersonalTextbox.Text = "";
                PointTextbox.Text = "";
            }
            LoadInfoCustomer();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListCustomerGrid.Rows.Count; i++)
            {
                if (IDTextbox.Text == ListCustomerGrid.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Thông tin khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                    IDTextbox.Text = "";
                    FullNameTextbox.Text = "";
                    DoBTextbox.Text = "";
                    AddressTextbox.Text = "";
                    PhoneNumTextbox.Text = "";
                    IDPersonalTextbox.Text = "";
                    PointTextbox.Text = "";
                    IDTextbox.Focus();
                    return;
                }
            }

            if (IDTextbox.Text != "" && FullNameTextbox.Text != "" && DoBTextbox.Text != "" && AddressTextbox.Text != "" && PhoneNumTextbox.Text != "" && IDPersonalTextbox.Text != "")
            {
                DateTime DayofBirth = Convert.ToDateTime(DoBTextbox.Text);
                string sqlFormattedDate = DayofBirth.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string query = "INSERT dbo.InfoCustomer ([id], [FullName], [DoB], [Addr], [Phone], [IDPersonal], [Points]) VALUES ('" + IDTextbox.Text + ",N'" + FullNameTextbox.Text + ",'" + sqlFormattedDate + ",'" + AddressTextbox.Text + ",'" + PhoneNumTextbox.Text + ",'" + IDPersonalTextbox.Text + ",'" + PointTextbox.Text + "'";
                DataProvider.Instance.ExcuteQuery(query);
                IDTextbox.Text = "";
                FullNameTextbox.Text = "";
                DoBTextbox.Text = "";
                AddressTextbox.Text = "";
                PhoneNumTextbox.Text = "";
                IDPersonalTextbox.Text = "";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            LoadInfoCustomer();
        }

        private void FormCustomer_Click(object sender, EventArgs e)
        {
            IDTextbox.Text = "";
            FullNameTextbox.Text = "";
            DoBTextbox.Text = "";
            AddressTextbox.Text = "";
            PhoneNumTextbox.Text = "";
            IDPersonalTextbox.Text = "";
            PointTextbox.Text = "";
        }
    }

}
