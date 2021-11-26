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
            IDTextbox.ReadOnly = false;
        }

        public FormAddAccount(string Username, string Password, string ID, int AccType)
        {
            InitializeComponent();
            UsernameTextbox.Text = Username;
            UsernameTextbox.ForeColor = Color.White;
            PasswordTextbox.Text = Password;
            PasswordTextbox.ForeColor = Color.White;
            IDTextbox.Text = ID;
            IDTextbox.ForeColor = Color.White;
            if (AccType == 1)
            {
                AdminCheckbox.Checked = true;
            }
            else
            {
                AdminCheckbox.Checked = false;
            }
            EditButton.BringToFront();
            IDTextbox.ReadOnly = true;
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

        private void IDTextbox_Enter_1(object sender, EventArgs e)
        {
            if (IDTextbox.Text == "ID")
            {
                IDTextbox.Text = "";
                IDTextbox.ForeColor = Color.White;
            }
        }

        private void IDTextbox_Leave_1(object sender, EventArgs e)
        {
            if (IDTextbox.Text == "")
            {
                IDTextbox.Text = "ID";
                IDTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            int admin = 0;
            if (AdminCheckbox.Checked)
                admin = 1;

            for (int i = 0; i < ListAccountGrid.Rows.Count; i++)
            {
                if (IDTextbox.Text == ListAccountGrid.Rows[i].Cells["ID"].Value.ToString())
                {
                    MessageBox.Show("This staff account already exist", "Notification", MessageBoxButtons.OK);
                    IDTextbox.Text = "";
                    UsernameTextbox.Text = "";
                    PasswordTextbox.Text = "";
                    AdminCheckbox.Checked = false;
                    return;
                }

                if (UsernameTextbox.Text == ListAccountGrid.Rows[i].Cells["Username"].Value.ToString())
                {
                    MessageBox.Show("This account already exist", "Notification", MessageBoxButtons.OK);
                    UsernameTextbox.Text = "";
                    UsernameTextbox.Focus();
                    return;
                }
            }

            if (UsernameTextbox.Text != "" && PasswordTextbox.Text != "" && IDTextbox.Text!="")
            {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
                AccountDAO.Instance.AddAcount(UsernameTextbox.Text, PasswordTextbox.Text, IDTextbox.Text, admin);
=======
                string password = Cryptography.Encrypt(PasswordTextbox.Text.ToString());
                AccountDAO.Instance.AddAcount(UsernameTextbox.Text, password, IDTextbox.Text, admin);
>>>>>>> Stashed changes
=======
                string password = Cryptography.Encrypt(PasswordTextbox.Text.ToString());
                AccountDAO.Instance.AddAcount(UsernameTextbox.Text, password, IDTextbox.Text, admin);
>>>>>>> Stashed changes
                UsernameTextbox.Text = "";
                PasswordTextbox.Text = "";
                IDTextbox.Text = "";
                AdminCheckbox.Checked = false;
                MessageBox.Show("Account added!", "Notification", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Please enter full of infomation!", "Notification", MessageBoxButtons.OK);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (UsernameTextbox.Text != "" && PasswordTextbox.Text != "" && IDTextbox.Text != "")
            {
                if (MessageBox.Show("Do you really want to change this account?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int admin = 0;
                    if (AdminCheckbox.Checked)
                        admin = 1;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
                    AccountDAO.Instance.EditAccount(UsernameTextbox.Text, PasswordTextbox.Text, IDTextbox.Text, admin);
=======
                    string password = Cryptography.Encrypt(PasswordTextbox.Text.ToString());
                    AccountDAO.Instance.EditAccount(UsernameTextbox.Text, password, IDTextbox.Text, admin);
>>>>>>> Stashed changes
=======
                    string password = Cryptography.Encrypt(PasswordTextbox.Text.ToString());
                    AccountDAO.Instance.EditAccount(UsernameTextbox.Text, password, IDTextbox.Text, admin);
>>>>>>> Stashed changes
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
