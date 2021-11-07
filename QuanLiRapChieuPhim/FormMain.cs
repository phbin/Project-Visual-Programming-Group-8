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
    public partial class FormMain : Form
    {
        private Button curBtn;
        private Panel buttonBorder;
        private Form curChildForm;
        public FormMain()
        {
            InitializeComponent();
            buttonBorder = new Panel();
            buttonBorder.Size = new Size(10, 69);
            gradientPanelMenu.Controls.Add(buttonBorder);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;
        }
        private void EnableButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();
                //convert object to same type of button
                curBtn = (Button)sender;
                curBtn.BackColor = Color.FromArgb(155,39,43);
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
        private void buttonGeneral_Click(object sender, EventArgs e)
        {
            EnableButton(sender, Color.FromArgb(17, 17, 17));
            pictureHome.Image = Properties.Resources.general;
            OpenChildForm(new FormGeneral());
            labelHome.Text = "General";
        }

        private void buttonMovie_Click(object sender, EventArgs e)
        {
            EnableButton(sender, Color.FromArgb(17, 17, 17));
            pictureHome.Image = Properties.Resources.movie;
            OpenChildForm(new FormMovie());
            labelHome.Text = "Movie";
        }

        private void buttonFD_Click(object sender, EventArgs e)
        {
            EnableButton(sender, Color.FromArgb(17, 17, 17));
            pictureHome.Image = Properties.Resources.fd;
            OpenChildForm(new FormFD());
            labelHome.Text = "Food and Drink";
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            EnableButton(sender, Color.FromArgb(17, 17, 17));
            pictureHome.Image = Properties.Resources.customer;
            OpenChildForm(new FormCustomer());
            labelHome.Text = "Customer";
        }

        private void buttonStatistic_Click(object sender, EventArgs e)
        {
            EnableButton(sender, Color.FromArgb(17, 17, 17));
            pictureHome.Image = Properties.Resources.statistic;
            OpenChildForm(new FormStatistic());
            labelHome.Text = "Statistic";
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            EnableButton(sender, Color.FromArgb(17, 17, 17));
            pictureHome.Image = Properties.Resources.setting;
            OpenChildForm(new FormStaff());
            labelHome.Text = "Staff";
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

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            buttonRestoreDown.BringToFront();
        }

        private void buttonRestoreDown_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            buttonMaximize.BringToFront();
        }

        private void buttonMinimize_MouseMove(object sender, MouseEventArgs e)
        {
            buttonMinimize.BackColor = Color.FromArgb(190, 62, 66);

        }

        private void buttonClose_MouseMove(object sender, MouseEventArgs e)
        {
            buttonClose.BackColor = Color.FromArgb(190, 62, 66);
        }

        private void buttonMaximize_MouseMove(object sender, MouseEventArgs e)
        {
            buttonMaximize.BackColor = Color.FromArgb(190, 62, 66);
        }

        private void buttonRestoreDown_MouseMove(object sender, MouseEventArgs e)
        {
            buttonRestoreDown.BackColor = Color.FromArgb(190, 62, 66);
        }

        private void labelHome_Click(object sender, EventArgs e)
        {

        }

        private void pictureHome_Click(object sender, EventArgs e)
        {

        }

        private void panelLine_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
