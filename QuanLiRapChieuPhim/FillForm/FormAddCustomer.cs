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

namespace QuanLiRapChieuPhim.ChildForms
{
    public partial class FormAddCustomer : Form
    {
        public FormAddCustomer()
        {
            InitializeComponent();
        }
        DataGridView ListCustomerGrid = new DataGridView();

        public FormAddCustomer(DataGridView data)
        {
            InitializeComponent();
            ListCustomerGrid = data;
            AddButton.BringToFront();
            IDTextbox.ReadOnly = false;
        }

        public FormAddCustomer(string ID, string FullName, string DoB, string Address, string Phone, string IDPersonal, string Points)
        {
            InitializeComponent();
            IDTextbox.Text = ID;
            FullNameTextbox.Text = FullName;
            DoBTextbox.Text = DoB;
            AddressTextbox.Text = Address;
            PhoneTextbox.Text = Phone;
            IDPersonalTextbox.Text = IDPersonal;
            PointTextbox.Text = Points;

            IDTextbox.ForeColor = Color.White;
            FullNameTextbox.ForeColor = Color.White;
            DoBTextbox.ForeColor = Color.White;
            AddressTextbox.ForeColor = Color.White;
            PhoneTextbox.ForeColor = Color.White;
            IDPersonalTextbox.ForeColor = Color.White;
            PointTextbox.ForeColor = Color.White;

            EditButton.BringToFront();
            IDTextbox.ReadOnly = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListCustomerGrid.Rows.Count; i++)
            {
                if (IDTextbox.Text == ListCustomerGrid.Rows[i].Cells["ID"].Value.ToString())
                {
                    MessageBox.Show("This customer's infomation already exist", "Notification", MessageBoxButtons.OK);
                    IDTextbox.Text = "";
                    FullNameTextbox.Text = "";
                    DoBTextbox.Text = "";
                    AddressTextbox.Text = "";
                    PhoneTextbox.Text = "";
                    IDPersonalTextbox.Text = "";
                    PointTextbox.Text = "";
                    IDTextbox.Focus();
                    return;
                }
            }

            if (IDTextbox.Text != "" && FullNameTextbox.Text != "" && DoBTextbox.Text != "" && AddressTextbox.Text != "" && PhoneTextbox.Text != "" && IDPersonalTextbox.Text != "")
            {
                DateTime DayofBirth = Convert.ToDateTime(DoBTextbox.Text);
                string sqlFormattedDate = DayofBirth.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string query = "INSERT dbo.InfoCustomer ([id], [FullName], [DoB], [Addr], [Phone], [IDPersonal], [Points]) VALUES ('" + IDTextbox.Text + "',N'" + FullNameTextbox.Text + "','" + sqlFormattedDate + "',N'" + AddressTextbox.Text + "','" + PhoneTextbox.Text + "'," + int.Parse(IDPersonalTextbox.Text) + "," + int.Parse(PointTextbox.Text) +")";
                DataProvider.Instance.ExecuteQuery(query);
                IDTextbox.Text = "";
                FullNameTextbox.Text = "";
                DoBTextbox.Text = "";
                AddressTextbox.Text = "";
                PhoneTextbox.Text = "";
                IDPersonalTextbox.Text = "";
                PointTextbox.Text = "";
                MessageBox.Show("Customer's infomation added!");
                FormCustomer.ActiveForm.Activate();
            }
            else
                MessageBox.Show("Please enter full of infomation!", "Notification", MessageBoxButtons.OK);
           
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void IDPersonalTextbox_Enter(object sender, EventArgs e)
        {
            if (IDPersonalTextbox.Text == "ID Personal")
            {
                IDPersonalTextbox.Text = "";
                IDPersonalTextbox.ForeColor = Color.White;
            }
        }

        private void PointTextbox_Enter(object sender, EventArgs e)
        {
            if (PointTextbox.Text == "Points")
            {
                PointTextbox.Text = "";
                PointTextbox.ForeColor = Color.White;
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

        private void IDPersonalTextbox_Leave(object sender, EventArgs e)
        {
            if (IDPersonalTextbox.Text == "")
            {
                IDPersonalTextbox.Text = "ID Personal";
                IDPersonalTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void PointTextbox_Leave(object sender, EventArgs e)
        {
            if (PointTextbox.Text == "")
            {
                PointTextbox.Text = "Points";
                PointTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (PointTextbox.Text == "Points")
            {
                PointTextbox.Text = "0";
                PointTextbox.ForeColor = Color.White;
            }
            if (IDTextbox.Text != "" && FullNameTextbox.Text != "" && DoBTextbox.Text != "" && AddressTextbox.Text != "" && PhoneTextbox.Text != "" && IDPersonalTextbox.Text != "")
            {
                if (MessageBox.Show("Do you really want to change this information??", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DateTime DayofBirth = Convert.ToDateTime(DoBTextbox.Text);
                    string sqlFormattedDate = DayofBirth.ToString("yyyy-MM-dd HH:mm:ss.fff");
                    string query = "UPDATE dbo.InfoCustomer SET FullName=N'" + FullNameTextbox.Text + "', DoB='" + sqlFormattedDate + "', Addr='" + AddressTextbox.Text + "', Phone='" + PhoneTextbox.Text + "', IDPersonal='" + IDPersonalTextbox.Text + "', Points=" + int.Parse(PointTextbox.Text) + " WHERE ID='" + IDTextbox.Text + "'";
                    DataProvider.Instance.ExecuteQuery(query);
                    this.Close();
                }
            }
        }

        private void buttonClose_MouseMove(object sender, MouseEventArgs e)
        {
            buttonClose.BackColor = Color.FromArgb(199, 80, 87);
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.FromArgb(190, 62, 66);
        }

        private void EditButton_MouseMove(object sender, MouseEventArgs e)
        {
            EditButton.BackColor = Color.FromArgb(199, 80, 87);
        }

        private void EditButton_MouseLeave(object sender, EventArgs e)
        {
            EditButton.BackColor = Color.FromArgb(190, 62, 66);
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
