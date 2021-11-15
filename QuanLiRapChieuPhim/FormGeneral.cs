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
    public partial class FormGeneral : Form
    {
        private Button curBtn,preBtn;
        public FormGeneral()
        {
            InitializeComponent();
        }
        int count = 0;
        private void timerImage_Tick(object sender, EventArgs e)
        {
            if (count < 5)
            {
                pictureBoxPoster.Image = imageListPoster.Images[count];
                switch(count)
                {
                    case 0:
                        curBtn = btn1;
                        preBtn = btn5;
                        preBtn.Image= Properties.Resources.circle;
                        curBtn.BackColor = Color.FromArgb(33, 34, 46);
                        break;
                    case 1:
                        curBtn = btn2;
                        preBtn = btn1;
                        preBtn.Image = Properties.Resources.circle;
                        break;
                    case 2:
                        curBtn = btn3;
                        preBtn = btn2;
                        preBtn.Image = Properties.Resources.circle;
                        break;
                    case 3:
                        curBtn = btn4;
                        preBtn = btn3;
                        preBtn.Image = Properties.Resources.circle;
                        break;
                    case 4:
                        curBtn = btn5;
                        preBtn = btn4;
                        preBtn.Image = Properties.Resources.circle;
                        break;
                }    
                count++;
                EnableButton(curBtn, Color.FromArgb(17, 17, 17));
            }
            else
            {
                count = 0;
            }
        }
        private void EnableButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();
                //convert object to same type of button
                curBtn = (Button)sender;
                curBtn.ForeColor = Color.White;
                curBtn.Image = Properties.Resources.new_moon;

            }
        }

        private void DisableButton()
        {
            if (curBtn != null)
            {
                curBtn.BackColor = Color.Transparent;
                curBtn.ForeColor = Color.White;
                curBtn.Image = Properties.Resources.circle;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            EnableButton(sender, Color.FromArgb(17, 17, 17));
            pictureBoxPoster.Image = Properties.Resources.Poster1;
            count = 0;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            EnableButton(sender, Color.FromArgb(17, 17, 17));
            pictureBoxPoster.Image = Properties.Resources.Poster2;
            count = 1;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            EnableButton(sender, Color.FromArgb(17, 17, 17));
            pictureBoxPoster.Image = Properties.Resources.Poster3;
            count = 2;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            EnableButton(sender, Color.FromArgb(17, 17, 17));
            pictureBoxPoster.Image = Properties.Resources.Poster4;
            count = 3;
        }

        private void btn1_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(17, 17, 17);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            EnableButton(sender, Color.FromArgb(17, 17, 17));
            pictureBoxPoster.Image = Properties.Resources.Poster5;
            count = 4;
        }
    }
}
