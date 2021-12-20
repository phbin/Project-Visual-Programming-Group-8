using QuanLiRapChieuPhim.DAO;
using QuanLiRapChieuPhim.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim
{
    public partial class FormMovie : Form
    {
        Button curBtn = new Button();
        string id;

        public FormMovie()
        {
            InitializeComponent();
            LoadMovie();
        }
        void LoadMovie()
        {
            flpMovie.Controls.Clear();
            List<Movie> movieList = MovieDAO.Instance.GetMovie();
            if (buttonStt1.Text== "NOW SHOWING")
            {
                foreach (Movie item in movieList)
                {
                    if (item.Datepublic > DateTime.Now)
                    {
                        Button booking = new Button();
                        Button img = new Button();
                        Label name = new Label();
                        Label lb = new Label();
                        //Design button, lable
                        //size main lable 
                        lb.Width = 190;
                        lb.Height = 310;
                        lb.Margin = new Padding(20, 20, 20, 20);

                        img.Width = 200;
                        img.Height = 210;
                        img.Image = MovieDAO.byteArrayToImage(item.Poster);
                        img.ImageAlign = ContentAlignment.MiddleCenter;
                        img.FlatStyle = FlatStyle.Flat;
                        img.FlatAppearance.BorderSize = 0;
                        img.Dock = DockStyle.Top;
                        //Add events to button
                        img.MouseMove += Img_MouseMove;
                        img.MouseLeave += Img_MouseLeave;
                        img.Tag = (object)item;
                        img.Click += Img_Click;

                        //button title
                        name.Width = 80;
                        name.Height = 50;
                        name.Text = item.Name;
                        name.TextAlign = ContentAlignment.MiddleCenter;

                        name.Font = new Font("Lato", 10F, FontStyle.Bold);
                        name.ForeColor = Color.White;
                        name.BackColor = Color.Transparent;
                        name.Dock = DockStyle.Bottom;

                        //button booking
                        booking.Width = 80;
                        booking.Height = 40;
                        booking.Text = "Booking";
                        booking.Font = new Font("Lato", 10F, FontStyle.Bold);
                        booking.ForeColor = Color.White;
                        booking.BackColor = Color.FromArgb(190, 62, 66);
                        booking.FlatStyle = FlatStyle.Flat;
                        booking.FlatAppearance.BorderSize = 0;
                        booking.Dock = DockStyle.Bottom;
                        booking.Click += Booking_Click;
                        booking.Tag = (object)item;
                        flpMovie.Controls.Add(lb);
                        lb.Controls.Add(img);
                        lb.Controls.Add(name);
                        lb.Controls.Add(booking);
                        id = item.ID;
                    }
                }
            }    
            else if (buttonStt1.Text == "COMING SOON")
            {
                foreach (Movie item in movieList)
                {
                    if (item.Datepublic <= DateTime.Now)
                    {
                        Button booking = new Button();
                        Button img = new Button();
                        Label name = new Label();
                        Label lb = new Label();
                        //Design button, lable
                        //size main lable 
                        lb.Width = 190;
                        lb.Height = 310;
                        lb.Margin = new Padding(20, 20, 20, 20);

                        img.Width = 200;
                        img.Height = 210;
                        img.Image = MovieDAO.byteArrayToImage(item.Poster);
                        img.ImageAlign = ContentAlignment.MiddleCenter;
                        img.FlatStyle = FlatStyle.Flat;
                        img.FlatAppearance.BorderSize = 0;
                        img.Dock = DockStyle.Top;
                        //Add events to button
                        img.MouseMove += Img_MouseMove;
                        img.MouseLeave += Img_MouseLeave;
                        img.Tag = (object)item;
                        img.Click += Img_Click;

                        //button title
                        name.Width = 80;
                        name.Height = 50;
                        name.Text = item.Name;
                        name.TextAlign = ContentAlignment.MiddleCenter;

                        name.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
                        name.ForeColor = Color.White;
                        name.BackColor = Color.Transparent;
                        name.Dock = DockStyle.Bottom;

                        //button booking
                        booking.Width = 80;
                        booking.Height = 40;
                        booking.Text = "Booking";
                        booking.Font = new Font("Lato", 10F, FontStyle.Bold);
                        booking.ForeColor = Color.White;
                        booking.BackColor = Color.FromArgb(190, 62, 66);
                        booking.FlatStyle = FlatStyle.Flat;
                        booking.FlatAppearance.BorderSize = 0;
                        booking.Dock = DockStyle.Bottom;
                        booking.Click += Booking_Click;
                        booking.Tag = (object)item;
                        flpMovie.Controls.Add(lb);
                        lb.Controls.Add(img);
                        lb.Controls.Add(name);
                        lb.Controls.Add(booking);
                        id = item.ID;
                    }
                }
            }
        }

        private void Booking_Click(object sender, EventArgs e)
        {
            curBtn = (Button)sender;
            ChooseShowtime frm = new ChooseShowtime((curBtn.Tag as Movie).ID);
            frm.Show();
        }

        void LoadMovieDetails()
        {
            flpMovie.Hide();
            panelLine.Hide();
            panel.Hide();
            id = (curBtn.Tag as Movie).ID;
            string name = (curBtn.Tag as Movie).Name;
            lbName.Text = name;
            List<Genre> listGenre = MovieByGenreDAO.GetGenreByMovie(id);
            foreach (Genre item in listGenre)
            {
                lbInfo.Text = "Genre: "+item.Name.Remove(item.Name.Length-2,1)+"\nDirector: "+ (curBtn.Tag as Movie).Director+"\nCountry: " + (curBtn.Tag as Movie).Country + "\nRelease Date: "+ (curBtn.Tag as Movie).Datepublic + "\nRunning Time: "+ (curBtn.Tag as Movie).Timelimit;
            }
            picBoxPoster.BackgroundImage= MovieDAO.byteArrayToImage((curBtn.Tag as Movie).Poster);
            lbDesc.Text ="Description: "+ (curBtn.Tag as Movie).Desc;
        }

        private void Img_Click(object sender, EventArgs e)
        {
            curBtn = (Button)sender;
            LoadMovieDetails();
        }
        private void Img_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).Height = 210;
        }
        private void Img_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).Height = 230;
            (sender as Button).Dock = DockStyle.Top;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panel.Show();
            panelLine.Show();
            flpMovie.Show();
            LoadMovie();
        }

        private void buttonStt1_Click(object sender, EventArgs e)
        {
            if (buttonStt1.Text == "COMING SOON")
            {
                flpMovie.Controls.Clear();
                buttonStt1.Text = "NOW SHOWING";
                labelSTT.Text = "Coming Soon";
                LoadMovie();
            }
            else if (buttonStt1.Text == "NOW SHOWING")
            {
                flpMovie.Controls.Clear();
                buttonStt1.Text = "COMING SOON";
                labelSTT.Text = "Now Showing";
                LoadMovie();
            }
        }

        private void buttonBooking_Click(object sender, EventArgs e)
        {
            ChooseShowtime frm = new ChooseShowtime((curBtn.Tag as Movie).ID);
            frm.Show();
        }
    }
}
