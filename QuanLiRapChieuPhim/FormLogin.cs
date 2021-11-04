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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.AcceptButton = LoginButton;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClose_MouseMove(object sender, MouseEventArgs e)
        {
            buttonClose.BackColor = Color.FromArgb(190, 62, 66);
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Transparent;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            LoginButton.BackColor = Color.FromArgb(190, 62, 66);
        }

        private void UsernameTextbox_Enter(object sender, EventArgs e)
        {
            if(UsernameTextbox.Text=="Username")
            {
                UsernameTextbox.Text = "";
                UsernameTextbox.ForeColor = Color.White;
            }    
        }

        private void PasswordTextbox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text == "Password")
            {
                PasswordTextbox.Text = "";
                PasswordTextbox.ForeColor = Color.White;
                PasswordTextbox.UseSystemPasswordChar = false;
            }
        }

        private void UsernameTextbox_Leave(object sender, EventArgs e)
        {
            if(UsernameTextbox.Text=="")
            {
                UsernameTextbox.Text = "Username";
                UsernameTextbox.ForeColor = Color.FromArgb(165, 70, 91);
            }   
        }

        private void PasswordTextbox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text == "")
            {
                PasswordTextbox.Text = "Password";
                PasswordTextbox.ForeColor = Color.FromArgb(165, 70, 91);
                PasswordTextbox.UseSystemPasswordChar = true;
            }
        }

        private void LoginButton_MouseMove(object sender, MouseEventArgs e)
        {
            LoginButton.BackColor = Color.FromArgb(155, 39, 43);
        }

        private void LoginButton_MouseLeave(object sender, EventArgs e)
        {
            LoginButton.BackColor = Color.Transparent;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextbox.Text == "admin" && PasswordTextbox.Text == "123456")
            {
                FormMain frmMain = new FormMain();
                frmMain.ShowDialog();
                this.Hide();
            }
            else if(UsernameTextbox.Text=="" || PasswordTextbox.Text=="" || UsernameTextbox.Text=="Username" || PasswordTextbox.Text=="Password")
            {
                UsernameTextbox.Focus();
            }    
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text != "Password")
            {
                ShowButton.BringToFront();
                PasswordTextbox.UseSystemPasswordChar = false;
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            HideButton.BringToFront();
            PasswordTextbox.UseSystemPasswordChar = true;
        }

        private void HideButton_MouseMove(object sender, MouseEventArgs e)
        {
            HideButton.BackColor = Color.FromArgb(155, 39, 43);
        }

        private void HideButton_MouseLeave(object sender, EventArgs e)
        {
            HideButton.BackColor = Color.Transparent;
        }

        private void ShowButton_MouseMove(object sender, MouseEventArgs e)
        {
            ShowButton.BackColor = Color.FromArgb(155, 39, 43);
        }

        private void ShowButton_MouseLeave(object sender, EventArgs e)
        {
            ShowButton.BackColor = Color.Transparent;
        }
    }
    
}
