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

namespace QuanLiRapChieuPhim.AddForms
{
    public partial class FormAddInfoStaff : Form
    {
        public FormAddInfoStaff()
        {
            InitializeComponent();
        }

        public FormAddInfoStaff(DataGridView Grid)
        {
            InitializeComponent();
            InfoStaffGridView = Grid;
            AddButton.BringToFront();
            IDTextbox.ReadOnly = false;
        }

        public FormAddInfoStaff(string ID, string FullName, string DoB, string Sex, string Address, string PhoneNum, string Email, string IDPersonal)
        {
            InitializeComponent();

            IDTextbox.Text = ID;
            FullNameTextbox.Text = FullName;
            DoBTextbox.Text = DoB;
            AddressTextbox.Text = Address;
            PhoneTextbox.Text = PhoneNum;
            EmailTextbox.Text = Email;
            IDPersonalTextbox.Text = IDPersonal;

            IDTextbox.ForeColor = Color.White;
            FullNameTextbox.ForeColor = Color.White;
            DoBTextbox.ForeColor = Color.White;
            AddressTextbox.ForeColor = Color.White;
            PhoneTextbox.ForeColor = Color.White;
            EmailTextbox.ForeColor = Color.White;
            IDPersonalTextbox.ForeColor = Color.White;

            if (Sex == "Nam")
            {
                MaleCheckbox.Checked = true;
            }
            else
            {
                FemaleCheckbox.Checked = true;
            }
            IDTextbox.ReadOnly = true;
            EditButton.BringToFront();
        }

        string Sex;
        DataGridView InfoStaffGridView = new DataGridView();

        void LoadInfoStaff()
        {
            string query = "SELECT * FROM InfoStaff";
            InfoStaffGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void IDTextbox_Enter(object sender, EventArgs e)
        {
            if (IDTextbox.Text == "ID")
            {
                IDTextbox.Text = "";
                IDTextbox.ForeColor = Color.White;
            }
        }

        private void FullNameTextbox_Enter(object sender, EventArgs e)
        {
            if (FullNameTextbox.Text == "Full Name")
            {
                FullNameTextbox.Text = "";
                FullNameTextbox.ForeColor = Color.White;
            }
        }

        private void DoBTextbox_Enter(object sender, EventArgs e)
        {
            if (DoBTextbox.Text == "Birthday")
            {
                DoBTextbox.Text = "";
                DoBTextbox.ForeColor = Color.White;
            }
        }

        private void AddressTextbox_Enter(object sender, EventArgs e)
        {
            if (AddressTextbox.Text == "Address")
            {
                AddressTextbox.Text = "";
                AddressTextbox.ForeColor = Color.White;
            }
        }

        private void PhoneTextbox_Enter(object sender, EventArgs e)
        {
            if (PhoneTextbox.Text == "Phone Number")
            {
                PhoneTextbox.Text = "";
                PhoneTextbox.ForeColor = Color.White;
            }
        }

        private void EmailTextbox_Enter(object sender, EventArgs e)
        {
            if (EmailTextbox.Text == "Email")
            {
                EmailTextbox.Text = "";
                EmailTextbox.ForeColor = Color.White;
            }
        }

        private void IDPersonalTextbox_Enter(object sender, EventArgs e)
        {
            if (IDPersonalTextbox.Text == "ID Personal")
            {
                IDPersonalTextbox.Text = "";
                IDPersonalTextbox.ForeColor = Color.White;
            }
        }

        private void IDTextbox_Leave(object sender, EventArgs e)
        {
            if (IDTextbox.Text == "")
            {
                IDTextbox.Text = "ID";
                IDTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void FullNameTextbox_Leave(object sender, EventArgs e)
        {
            if (FullNameTextbox.Text == "")
            {
                FullNameTextbox.Text = "Full Name";
                FullNameTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void DoBTextbox_Leave(object sender, EventArgs e)
        {
            if (DoBTextbox.Text == "")
            {
                DoBTextbox.Text = "Birthday";
                DoBTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void AddressTextbox_Leave(object sender, EventArgs e)
        {
            if (AddressTextbox.Text == "")
            {
                AddressTextbox.Text = "Address";
                AddressTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void PhoneTextbox_Leave(object sender, EventArgs e)
        {
            if (PhoneTextbox.Text == "")
            {
                PhoneTextbox.Text = "Phone Number";
                PhoneTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void EmailTextbox_Leave(object sender, EventArgs e)
        {
            if (EmailTextbox.Text == "")
            {
                EmailTextbox.Text = "Email";
                EmailTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void IDPersonalTextbox_Leave(object sender, EventArgs e)
        {
            if (IDPersonalTextbox.Text == "")
            {
                IDPersonalTextbox.Text = "ID Personal";
                IDPersonalTextbox.ForeColor = Color.FromArgb(190, 62, 66);
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
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < InfoStaffGridView.Rows.Count; i++)
            {
                if (IDTextbox.Text == InfoStaffGridView.Rows[i].Cells["ID"].Value.ToString())
                {
                    MessageBox.Show("This staff already exist", "Notification", MessageBoxButtons.OK);
                    IDTextbox.Text = "";
                    IDTextbox.Focus();
                    return;
                }
            }


            if (IDTextbox.Text != "" && FullNameTextbox.Text != "" && DoBTextbox.Text != "" && AddressTextbox.Text != "" && PhoneTextbox.Text != "" && IDPersonalTextbox.Text != "")
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
                AccountDAO.Instance.AddInfoStaff(IDTextbox.Text, FullNameTextbox.Text, sqlFormattedDate, AddressTextbox.Text, PhoneTextbox.Text, IDPersonalTextbox.Text, EmailTextbox.Text, Sex);
                IDTextbox.Text = "";
                FullNameTextbox.Text = "";
                DoBTextbox.Text = "";
                AddressTextbox.Text = "";
                PhoneTextbox.Text = "";
                IDPersonalTextbox.Text = "";
                EmailTextbox.Text = "";
                MaleCheckbox.Checked = false;
                FemaleCheckbox.Checked = false;
            }
            else
                MessageBox.Show("Please enter full of infomation!", "Notification", MessageBoxButtons.OK);

            LoadInfoStaff();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (IDTextbox.Text != "" && FullNameTextbox.Text != "" && DoBTextbox.Text != "" && AddressTextbox.Text != "" && PhoneTextbox.Text != "" && IDPersonalTextbox.Text != "")
            {
                if (MessageBox.Show("Do you really want to change this account?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string Sex;

                    DateTime DayofBirth = Convert.ToDateTime(DoBTextbox.Text);
                    string sqlFormattedDate = DayofBirth.ToString("yyyy-MM-dd HH:mm:ss.fff");

                    if (MaleCheckbox.Checked == FemaleCheckbox.Checked)
                    {
                        MessageBox.Show("Wrong Sex", "Notificaiton", MessageBoxButtons.OK);
                        return;
                    }

                    if (MaleCheckbox.Checked == true)
                    {
                        Sex = "Nam";
                    }
                    else
                    {
                        Sex = "Nữ";
                    }

                    AccountDAO.Instance.EditInfoStaff(IDTextbox.Text, FullNameTextbox.Text, sqlFormattedDate, AddressTextbox.Text, PhoneTextbox.Text, IDPersonalTextbox.Text, EmailTextbox.Text, Sex);

                    this.Close();
                }
            }
        }
    }
}
