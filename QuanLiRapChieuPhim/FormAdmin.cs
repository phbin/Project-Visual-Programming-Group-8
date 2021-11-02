using QuanLiRapChieuPhim.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim
{
    public partial class FormAdmin : Form
    {
        private Button curBtn;
        private Panel buttonBorder;
        private Form curChildForm;
        public FormAdmin()
        {
            InitializeComponent();
            buttonBorder = new Panel();
            buttonBorder.Size = new Size(10, 80);
            gradientPanelMenu.Controls.Add(buttonBorder);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void OpenChildForm(Form childForm)
        {
            if (curChildForm != null)
            {
                curChildForm.Close();
            }
            curChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            gradientPanelDesktop.Controls.Add(childForm);
            gradientPanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelHome.Text = childForm.Text;
        }

        private void EnableButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();
                //convert object to same type of button
                curBtn = (Button)sender;
                curBtn.BackColor = Color.FromArgb(155, 39, 43);
                curBtn.ForeColor = Color.White;
                curBtn.TextAlign = ContentAlignment.MiddleCenter;
                curBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                curBtn.ImageAlign = ContentAlignment.MiddleRight;
                //border button
                buttonBorder.BackColor = Color.White;
                buttonBorder.Location = new Point(0, curBtn.Location.Y);
                buttonBorder.Visible = true;
                buttonBorder.BringToFront();
                //change icon
            }
        }
        private void DisableButton()
        {
            if (curBtn != null)
            {
                curBtn.BackColor = Color.Transparent;
                curBtn.ForeColor = Color.White;
                curBtn.TextAlign = ContentAlignment.MiddleCenter;
                curBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                curBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void buttonHRM_Click(object sender, EventArgs e)
        {
            EnableButton(sender, Color.FromArgb(17, 17, 17));
            pictureHome.Image = Properties.Resources.hr;
            OpenChildForm(new FormHRM());
            labelHome.Text = "Human Resource Manager";
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            EnableButton(sender, Color.FromArgb(17, 17, 17));
            pictureHome.Image = Properties.Resources.statistic;
            OpenChildForm(new FormStatistic());
            labelHome.Text = "Statistics";
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            EnableButton(sender, Color.FromArgb(17, 17, 17));
            pictureHome.Image = Properties.Resources.customer;
            OpenChildForm(new FormAccount());
            labelHome.Text = "Account Manager";

        }
        private void ShowFormLogin()
        {
            FormLogin frm = new FormLogin();
            frm.ShowDialog();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowFormLogin)); //Create new thread 
            thread.Start(); //Start thread
            this.Close(); //Close current form
            FormLogin frmLogin = new FormLogin();
            frmLogin.Show();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            buttonRestoreDown.BringToFront();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonRestoreDown_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            buttonMaximize.BringToFront();
        }
    }
}
