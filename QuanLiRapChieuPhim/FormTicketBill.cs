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
    public partial class FormTicketBill : Form
    {
        List<Seat> seatList;
        TicketBill ticketBill;
        Showtime showTime;
        public FormTicketBill(List<Seat> l, string idst)
        {
            InitializeComponent();

            seatList = l;
            showTime = ShowtimeDAO.Instance.GetShowTimeByIDST(idst);
        }

        private void FormTicket_Load(object sender, EventArgs e)
        {
            foreach (Seat item in seatList)
                SeatDAO.Instance.CheckStatus(showTime.ID, item.SeatName);

            TicketBillDAO.Instance.InsertTicketBill(ShowtimeDAO.Instance.GetPriceByID(showTime.ID) * seatList.Count);
            ticketBill = TicketBillDAO.Instance.GetTicketByID(TicketBillDAO.Instance.GetLastIDTicket());

            printPreviewControl.Document = printDocument;
            printDocument.DocumentName = "TicketBill" + ticketBill.ID;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            printDlg.Document = printDocument;
            if (printDlg.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Brush b = Brushes.Black;
            Font f = new Font("Arial", 10F);
            int y = 0;
            for (int i = 0; i < seatList.Count; i++)
            {
                string dateST = ShowtimeDAO.Instance.GetDateByID(showTime.ID);
                string timeST = ShowtimeDAO.Instance.GetTimeByID(showTime.ID);
                string nameM = MovieDAO.Instance.GetNameMovieByID(showTime.IDMovie);
                SizeF s = e.Graphics.MeasureString(nameM, new Font("Arial", 12F, FontStyle.Bold));

                e.Graphics.DrawString("GROUP 8 CINEMA", new Font("Arial", 14F, FontStyle.Bold), b, 20, y);
                e.Graphics.DrawString("Quarter 6, Linh Trung Ward,", f, b, 25, y + 20);
                e.Graphics.DrawString("Thu Duc District, HCMC", f, b, 35, y + 35);
                e.Graphics.DrawString("No. " + ticketBill.ID, f, b, 10, y + 50);
                e.Graphics.DrawString("Date: " + ticketBill.Date, f, b, 10, y + 65);

                e.Graphics.DrawString("===================================", new Font("Arial", 7F), b, 12, y + 85);
                e.Graphics.DrawString("TICKET BILL", new Font("Arial", 10F, FontStyle.Bold), b, 70, y + 100);
                if (s.Width >= 220)
                    e.Graphics.DrawString(nameM, new Font("Arial", 12F, FontStyle.Bold), b, 0, y + 130);
                else
                e.Graphics.DrawString(nameM, new Font("Arial", 12F, FontStyle.Bold), b, 215 - s.Width, y + 130);
                e.Graphics.DrawString(dateST, new Font("Arial", 10F, FontStyle.Bold), b, 10, y + 160);
                e.Graphics.DrawString("Show: " + timeST, new Font("Arial", 10F, FontStyle.Bold), b, 110, y + 160);
                e.Graphics.DrawString("SEAT: " + seatList[i].SeatName, new Font("Arial", 10F, FontStyle.Bold), b, 10, y + 180);
                e.Graphics.DrawString("ROOM: " + showTime.IDRoom, new Font("Arial", 10F, FontStyle.Bold), b, 110, y + 180);

                e.Graphics.DrawString("===================================", new Font("Arial", 7F), b, 12, y + 200);
                e.Graphics.DrawString("**THANKS FOR YOUR PURCHASE**", new Font("Arial", 8F), b, 12, y + 220);
                y += 300;
            }
        }
    }
}
