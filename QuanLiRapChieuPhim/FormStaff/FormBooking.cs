using QuanLiRapChieuPhim.DAO;
using QuanLiRapChieuPhim.DTO;
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
    public partial class FormBooking : Form
    {
        public FormBooking(string ids)
        {
            InitializeComponent();
            idshowtime = ids;
            LoadInfo();
            LoadSeat();
        }
        Button curBtn = new Button();
        string idshowtime = "";
        int count = 0;
        int price = 0;
        private void LoadSeat()
        {
            flpSeat.Controls.Clear();
            List<Seat> listSeat = SeatDAO.GetSeatByID(idshowtime);
            foreach (Seat item in listSeat)
            {
                Button seat = new Button();
                seat.Width = 40;
                seat.Height = 40;
                seat.FlatStyle = FlatStyle.Flat;
                seat.Dock = DockStyle.Top;
                seat.ForeColor = Color.White;
                seat.FlatAppearance.BorderSize = 0;
                if (item.stt == 0)
                {
                    seat.BackColor = Color.FromArgb(32, 90, 167);
                }
                else
                {
                    seat.BackColor = Color.FromArgb(227, 53, 57);
                }
                seat.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
                seat.Text = item.SeatName.ToString();
                seat.Click += Seat_Click;
                seat.Tag = (object)item;
                flpSeat.Controls.Add(seat);
            }
        }
        private void LoadInfo()
        {
            string query;
            DataTable table;
            List<Showtime> listST = ShowtimeDAO.ShowtimeByIDST(idshowtime);
            foreach (Showtime item in listST)
            {
                //get name cinema
                query = "SELECT NameRoom FROM dbo.Room where id ='" + item.IDRoom + "'";
                table = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow rows in table.Rows)
                {
                    lbInfo1.Text = item.Time.ToString() + "\n\n" + rows["NameRoom"].ToString();
                }
                //get name movie
                query = "SELECT NameFilm, Poster FROM dbo.Movie where id ='" + item.IDMovie + "'";
                table = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow rows in table.Rows)
                {
                    lbName.Text = rows["NameFilm"].ToString();
                    pbPoster.BackgroundImage = MovieDAO.byteArrayToImage((byte[])rows["Poster"]);
                }
            }
        }
        private void Seat_Click(object sender, EventArgs e)
        {
            curBtn = (Button)(sender);
            btnClick();
        }

        private void btnClick()
        {
            if (curBtn.BackColor == Color.FromArgb(32, 90, 167)) //blue
            {
                curBtn.BackColor = Color.FromArgb(238, 154, 0); //orange
                count++;
                price += 110000;
                lbPriceInfo.Text = count + "\n\n" + price + " VND";
                (curBtn.Tag as Seat).stt = 2;
            }
            else if (curBtn.BackColor == Color.FromArgb(238, 154, 0)) //orange
            {
                curBtn.BackColor = Color.FromArgb(32, 90, 167); //blue
                count--;
                price -= 110000;
                lbPriceInfo.Text = count + "\n\n" + price + " VND";
                (curBtn.Tag as Seat).stt = 0;
            }
            else if (curBtn.BackColor == Color.FromArgb(227, 53, 57)) //red
            {
                MessageBox.Show("This seat has already booked!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
            //TicketBill frm = new TicketBill();
            //frm.Show();
        }
    }
}
