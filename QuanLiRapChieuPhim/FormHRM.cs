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

        string Sex;

        void LoadInfoStaff()
        {
            string query = "SELECT * FROM InfoStaff";
            InfoStaffGridView.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this information?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                AccountDAO.Instance.DeleteInfoStaff(IDTextbox.Text);
                IDTextbox.Text = "";
                FullNameTextbox.Text = "";
                DoBTextbox.Text = "";
                AddressTextbox.Text = "";
                PhoneNumTextbox.Text = "";
                IDPersonalTextbox.Text = "";
                EmailTextbox.Text = "";
                MaleCheckbox.Checked = false;
                FemaleCheckbox.Checked = false;
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
                if (row.Cells[3].Value.ToString() == "Nam")
                {
                    MaleCheckbox.Checked = true;
                    FemaleCheckbox.Checked = false;
                }
                else
                {
                    FemaleCheckbox.Checked = true;
                    MaleCheckbox.Checked = false;
                }
                    AddressTextbox.Text = row.Cells[4].Value.ToString();
                PhoneNumTextbox.Text = row.Cells[5].Value.ToString();
                EmailTextbox.Text = row.Cells[6].Value.ToString();
                IDPersonalTextbox.Text = row.Cells[7].Value.ToString();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if ((MaleCheckbox.Checked == true && FemaleCheckbox.Checked == true) || (MaleCheckbox.Checked == false && FemaleCheckbox.Checked == false))
            {
                MessageBox.Show("Wrong sex!", "Notification", MessageBoxButtons.OK);
                return;
            }
            else if (MaleCheckbox.Checked)
                Sex = "Nam";
            else
                Sex = "Nữ";

            DateTime DayofBirth = Convert.ToDateTime(DoBTextbox.Text);
            string sqlFormattedDate = DayofBirth.ToString("yyyy-MM-dd HH:mm:ss.fff");
            if (MessageBox.Show("Do you really want to change this information?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                AccountDAO.Instance.EditInfoStaff(IDTextbox.Text, FullNameTextbox.Text, sqlFormattedDate, AddressTextbox.Text, PhoneNumTextbox.Text, IDPersonalTextbox.Text, EmailTextbox.Text, Sex);
                IDTextbox.Text = "";
                FullNameTextbox.Text = "";
                DoBTextbox.Text = "";
                AddressTextbox.Text = "";
                PhoneNumTextbox.Text = "";
                IDPersonalTextbox.Text = "";
                EmailTextbox.Text = "";
                MaleCheckbox.Checked = false;
                FemaleCheckbox.Checked = false;
            }
            LoadInfoStaff();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < InfoStaffGridView.Rows.Count; i++)
            {
                if (IDTextbox.Text == InfoStaffGridView.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("This account already exist", "Notification", MessageBoxButtons.OK);
                    IDTextbox.Text = "";
                    IDTextbox.Focus();
                    return;
                }
            }


            if (IDTextbox.Text != "" && FullNameTextbox.Text != "" && DoBTextbox.Text != "" && AddressTextbox.Text != "" && PhoneNumTextbox.Text != "" && IDPersonalTextbox.Text != "")
            {
                if ((MaleCheckbox.Checked == true && FemaleCheckbox.Checked == true) || (MaleCheckbox.Checked == false && FemaleCheckbox.Checked == false))
                {
                    MessageBox.Show("Wrong sex!", "Notification", MessageBoxButtons.OK);
                    return;
                }
                else if (MaleCheckbox.Checked)
                    Sex = "Nam";
                else
                    Sex = "Nữ";

                DateTime DayofBirth = DateTime.Parse(DoBTextbox.Text);
                string sqlFormattedDate = DayofBirth.ToString("yyyy-MM-dd HH:mm:ss.fff");
                AccountDAO.Instance.AddInfoStaff(IDTextbox.Text,FullNameTextbox.Text,sqlFormattedDate,AddressTextbox.Text,PhoneNumTextbox.Text,IDPersonalTextbox.Text, EmailTextbox.Text, Sex);
                IDTextbox.Text = "";
                FullNameTextbox.Text = "";
                DoBTextbox.Text = "";
                AddressTextbox.Text = "";
                PhoneNumTextbox.Text = "";
                IDPersonalTextbox.Text = "";
                EmailTextbox.Text = "";
                MaleCheckbox.Checked = false;
                FemaleCheckbox.Checked = false;
            }
            else
            {
                MessageBox.Show("Please enter full of infomation!", "Notification", MessageBoxButtons.OK);
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
            EmailTextbox.Text = "";
            MaleCheckbox.Checked = false;
            FemaleCheckbox.Checked = false;
        }

        private void DeleteButton_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(33, 34, 46);
        }

        private void AddButton_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(33, 34, 46);
        }

        private void EditButton_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(33, 34, 46);
        }
    }
}
