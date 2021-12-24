using QuanLiRapChieuPhim.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim.AddForms
{
    public partial class FormAddAccount : Form
    {
        public FormAddAccount()
        {
            InitializeComponent();
        }

        DataGridView ListAccountGrid = new DataGridView();

        public FormAddAccount(DataGridView data)
        {
            InitializeComponent();
            ListAccountGrid = data;
            AddButton.BringToFront();
            LoadNameIntoComboBox(cbName);
        }

        void LoadNameIntoComboBox(ComboBox cbb)
        {
            DataTable tb = DataProvider.Instance.ExecuteQuery("Select * from dbo.InfoStaff where stt=1");
            cbb.DataSource = tb;
            cbb.DisplayMember = "FullName";
        }
        public FormAddAccount(string Username/*, string Password*/, string ID, int AccType)
        {
            InitializeComponent();
            UsernameTextbox.Text = Username;
            UsernameTextbox.ForeColor = Color.White;
            LoadNameIntoComboBox(cbName);
            string query = "select * from InfoStaff where id='" + ID + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow rows in table.Rows)
            {
                cbName.Text = rows["FullName"].ToString();
            }
            //PasswordTextbox.Text = Password;
            //PasswordTextbox.ForeColor = Color.White;
            if (AccType == 1)
            {
                AdminCheckbox.Checked = true;
            }
            else
            {
                AdminCheckbox.Checked = false;
            }
            EditButton.BringToFront();
        }

        private void UsernameTextbox_Enter(object sender, EventArgs e)
        {
            if (UsernameTextbox.Text == "Username")
            {
                UsernameTextbox.Text = "";
                UsernameTextbox.ForeColor = Color.White;
            }
        }

        private void UsernameTextbox_Leave(object sender, EventArgs e)
        {
            if (UsernameTextbox.Text == "")
            {
                UsernameTextbox.Text = "Username";
                UsernameTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void PasswordTextbox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text == "Password")
            {
                PasswordTextbox.Text = "";
                PasswordTextbox.ForeColor = Color.White;
            }
        }

        private void PasswordTextbox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text == "")
            {
                PasswordTextbox.Text = "Password";
                PasswordTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }
        string idstaff;
        private string GetID(string name)
        {
            string query = "SELECT ID FROM dbo.InfoStaff where FullName = N'" + name + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow rows in table.Rows)
            {
                idstaff = rows["ID"].ToString();
            }
            return idstaff;
        }
        private void AddButton_Click_1(object sender, EventArgs e)
        {
            int admin = 0;
            if (AdminCheckbox.Checked)
                admin = 1;

            for (int i = 0; i < ListAccountGrid.Rows.Count; i++)
            {
                if (GetID(cbName.Text) == ListAccountGrid.Rows[i].Cells["ID"].Value.ToString())
                {
                    MessageBox.Show("This staff account has already existed", "Notification", MessageBoxButtons.OK);
                    UsernameTextbox.Text = "Username";
                    PasswordTextbox.Text = "Password";

                    UsernameTextbox.ForeColor = Color.FromArgb(190, 62, 66);
                    PasswordTextbox.ForeColor = Color.FromArgb(190, 62, 66);
                    AdminCheckbox.Checked = false;
                    return;
                }

                if (UsernameTextbox.Text == ListAccountGrid.Rows[i].Cells["Username"].Value.ToString())
                {
                    MessageBox.Show("This account already has already existed", "Notification", MessageBoxButtons.OK);
                    UsernameTextbox.Text = "Username"; 
                    PasswordTextbox.Text = "Password";

                    UsernameTextbox.ForeColor = Color.FromArgb(190, 62, 66);
                    PasswordTextbox.ForeColor = Color.FromArgb(190, 62, 66);
                    UsernameTextbox.Focus();
                    return;
                }
            }
            int count = 0;
            if (UsernameTextbox.Text == "Username" || UsernameTextbox.Text == "")
            {
                errorProvider1.SetError(UsernameTextbox, "Please enter Username!");
                count++;
            }
            else
            {
                errorProvider1.SetError(UsernameTextbox, null);
            }

            if (PasswordTextbox.Text == "Password" || PasswordTextbox.Text == "")
            {
                errorProvider1.SetError(PasswordTextbox, "Please enter Password!");
                count++;
            }
            else
            {
                errorProvider1.SetError(PasswordTextbox, null);
            }

            if (cbName.Text == "ID" || cbName.Text == "")
            {
                errorProvider1.SetError(cbName, "Please enter ID!");
                count++;
            }
            else
            {
                errorProvider1.SetError(cbName, null);
            }
            if (count == 0)
            {
                if (AdminCheckbox.Checked == true)
                {
                    string query = "update InfoStaff set ID='" + CreateID() + "' where FullName=N'" + cbName.Text + "'";
                    DataTable table = DataProvider.Instance.ExecuteQuery(query);
                } 
                   
                AccountDAO.Instance.AddAcount(UsernameTextbox.Text, PasswordTextbox.Text, GetID(cbName.Text), admin);
                AdminCheckbox.Checked = false;
                UsernameTextbox.Text = "Username";
                PasswordTextbox.Text = "Password";
                UsernameTextbox.ForeColor = Color.FromArgb(190, 62, 66);
                PasswordTextbox.ForeColor = Color.FromArgb(190, 62, 66);
                MessageBox.Show("Account added!", "Notification", MessageBoxButtons.OK);
            }
        }
        string CreateID()
        {
            string id = "";
            string query = "select * from InfoStaff where id like 'AD%'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            int j = 0;
            for (int i = 0; i <= table.Rows.Count ; i++)
            {
                if (i < 10) id = "AD0" + i;
                else id = "AD" + i;
                while (j < table.Rows.Count)
                {
                    DataRow rows = table.Rows[j];
                    if (rows["ID"].ToString() != id) return id;
                    else
                    {
                        j++;
                        break;
                    }
                }

            }
            return id;
        }
        private void AddButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddButton.BackColor = Color.FromArgb(199, 80, 87);
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.BackColor = Color.FromArgb(190, 62, 66);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (UsernameTextbox.Text == "Username" || UsernameTextbox.Text == "")
            {
                errorProvider1.SetError(UsernameTextbox, "Please enter Username!");
                count++;
            }
            else
            {
                errorProvider1.SetError(UsernameTextbox, null);
            }

            if (PasswordTextbox.Text == "Password" || PasswordTextbox.Text == "")
            {
                errorProvider1.SetError(PasswordTextbox, "Please enter Password!");
                count++;
            }
            else
            {
                errorProvider1.SetError(PasswordTextbox, null);
            }

            if (cbName.Text == "Movie" || cbName.Text == "")
            {
                errorProvider1.SetError(cbName, "Please enter Movie!");
                count++;
            }
            else
            {
                errorProvider1.SetError(cbName, null);
            }

            if (count == 0)
            {
                if (MessageBox.Show("Do you really want to change this account?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int admin = 0;
                    if (AdminCheckbox.Checked)
                        admin = 1;
                    AccountDAO.Instance.EditAccount(UsernameTextbox.Text, PasswordTextbox.Text, GetID(cbName.Text), admin);
                    FormAccount.ActiveForm.Activate();
                    this.Close();
                }
            }
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FormAccount.ActiveForm.Activate();
        }

        private void buttonClose_MouseMove(object sender, MouseEventArgs e)
        {
            buttonClose.BackColor = Color.FromArgb(199, 80, 87);
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.FromArgb(190, 62, 66);
        }
    }
}
