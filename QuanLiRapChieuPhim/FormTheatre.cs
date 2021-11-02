using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiRapChieuPhim.DTO;
using QuanLiRapChieuPhim.DAO;
using System.Globalization;//Thư viện thay đổi vùng/quốc gia

namespace QuanLiRapChieuPhim
{
    public partial class FormTheatre : Form
    {
        int size = 30; //Size của ghế
        int gap = 7; //Khoảng cách giữa các ghế

        List<Ticket> listSeat = new List<Ticket>();

        //Danh sách các ghế đang chọn
        List<Button> listSeatSelected = new List<Button>();

        float displayPrice = 0; //Hiện thị giá vé
        float ticketPrice = 0; //Lưu giá vé gốc
        float total = 0; //Tổng giá tiền
        float discount = 0; //Tiền được giảm
        float payment = 0; //Tiền phải trả
        int plusPoint = 0; //Số điểm tích lũy khi mua vé

        Customer customer;//Lưu khách hàng thành viên

        ShowTime time;
        Movie movie;

        public FormTheatre(ShowTime showTime, Movie movie)
        {
            InitializeComponent();

            time = showTime;
            this.movie = movie;
        }

        private void frmTheatre_Load(object sender, EventArgs e)
        {
            ticketPrice = time.TicketPrice;

            //lblInformation.Text = time.IDRoom + " | ";// + time.NameFilm;
            lblTime.Text = time.shTime.ToShortDateString() + " | "
                + time.shTime.ToShortTimeString() + " - "
                + time.shTime.AddMinutes(movie.TimeLimit).ToShortTimeString();
            if (movie.Poster != null)
            {
                picFilm.Image = MovieDAO.byteArrayToImage(movie.Poster);
            }

            rdoAdult.Checked = true;
            chkCustomer.Enabled = false;
            grpLoaiVe.Enabled = false;

            LoadDataCinema(time.IDRoom);

            ShowOrHideLablePoint();

            listSeat = TicketDAO.GetListTicketsByShowTimes(time.ID);

            LoadSeats(listSeat);
        }

        private void LoadDataCinema(string name)
        {
            Room room = RoomDAO.GetCinemaByName(name);
            if (room != null)
            {
                int Row = room.RowOfSeat;
                int Column = room.SeatOfRow;
                flpSeat.Size = new Size((size + 20 + gap) * Column, (size + gap) * Row);
            }
        }

        private void LoadBill()
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            //Đổi culture vùng quốc gia để đổi đơn vị tiền tệ 

            //Thread.CurrentThread.CurrentCulture = culture;
            //dùng thread để chuyển cả luồng đang chạy về vùng quốc gia đó

            lblTicketPrice.Text = displayPrice.ToString("c", culture);
            lblTotal.Text = total.ToString("c", culture);
            lblDiscount.Text = discount.ToString("c", culture);
            lblPayment.Text = payment.ToString("c", culture);

            //Đổi đơn vị tiền tệ
            //gán culture chỗ này thì chỉ có chỗ này sd culture này còn
            //lại sài mặc định
        }

        private void LoadSeats(List<Ticket> list)
        {
            flpSeat.Controls.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                Button btnSeat = new Button() { Width = size + 20, Height = size };
                btnSeat.Text = list[i].SeatCode;
                if (list[i].stt == 1)
                {
                    btnSeat.BackColor = Color.Red;
                }
                else
                {
                    btnSeat.BackColor = Color.White;
                }
                btnSeat.Click += BtnSeat_Click;
                flpSeat.Controls.Add(btnSeat);

                btnSeat.Tag = list[i];
            }
        }

        private void BtnSeat_Click(object sender, EventArgs e)
        {
            Button btnSeat = sender as Button;
            if (btnSeat.BackColor == Color.White)
            {
                grpLoaiVe.Enabled = true;
                rdoAdult.Checked = true;

                btnSeat.BackColor = Color.Yellow;
                Ticket ticket = btnSeat.Tag as Ticket;

                ticket.TicketPrice = ticketPrice;
                displayPrice = ticket.TicketPrice;
                total += ticketPrice;
                payment = total - discount;
                ticket.TicketType = 1;

                listSeatSelected.Add(btnSeat);
                plusPoint++;
                lblPlusPoint.Text = plusPoint + "";
            }
            else if (btnSeat.BackColor == Color.Yellow)
            {
                btnSeat.BackColor = Color.White;
                Ticket ticket = btnSeat.Tag as Ticket;

                total -= ticket.TicketPrice;
                payment = total - discount;
                ticket.TicketPrice = 0;
                displayPrice = ticket.TicketPrice;
                ticket.TicketType = 0;

                listSeatSelected.Remove(btnSeat);
                plusPoint--;
                lblPlusPoint.Text = plusPoint + "";
                grpLoaiVe.Enabled = false;
            }
            else if (btnSeat.BackColor == Color.Red)
            {
                MessageBox.Show("Ghế số [" + btnSeat.Text + "] đã có người mua");
            }
            LoadBill();
            if (listSeatSelected.Count > 0)
            {
                chkCustomer.Enabled = true;
            }
            else
            {
                chkCustomer.Enabled = false;
            }
        }

        //dùng để ẩn hiện lable điểm tích lũy của khách hàng thành viên
        private void ShowOrHideLablePoint()
        {
            if (chkCustomer.Checked == true)
            {
                pnCustomer.Visible = true;
            }
            else
            {
                pnCustomer.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn hủy tất cả những vé đã chọn không?",
                "Hủy Mua Vé", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            foreach (Button btn in listSeatSelected)
            {
                btn.BackColor = Color.White;
            }
            RestoreDefault();
            this.OnLoad(new EventArgs());
        }

        private void RestoreDefault()
        {
            listSeatSelected.Clear();

            rdoAdult.Checked = true;
            grpLoaiVe.Enabled = false;
            chkCustomer.Checked = false;
            chkCustomer.Enabled = false;

            ShowOrHideLablePoint();

            total = 0;
            displayPrice = 0;
            discount = 0;
            payment = 0;
            plusPoint = 0;

            LoadBill();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (listSeatSelected.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn vé trước khi thanh toán!");
                return;
            }
            string message = "Bạn có chắc chắn mua những vé: \n";
            foreach (Button btn in listSeatSelected)
            {
                message += "[" + btn.Text + "] ";
            }
            message += "\nKhông?";
            DialogResult result = MessageBox.Show(message, "Hỏi Mua",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                int ret = 0;
                if (chkCustomer.Checked == true)
                {
                    foreach (Button btn in listSeatSelected)
                    {
                        Ticket ticket = btn.Tag as Ticket;

                        ret += TicketDAO.BuyTicket(ticket.ID, ticket.TicketType, customer.ID, ticket.TicketPrice);
                    }
                    customer.Points += plusPoint;
                    CustomerDAO.UpdatePointCustomer(customer.ID, customer.Points);
                }
                else
                {
                    foreach (Button btn in listSeatSelected)
                    {
                        Ticket ticket = btn.Tag as Ticket;

                        ret += TicketDAO.BuyTicket(ticket.ID, ticket.TicketType, ticket.TicketPrice);
                    }
                }
                if (ret == listSeatSelected.Count)
                {
                    MessageBox.Show("Bạn đã mua vé thành công!");
                }
            }
            RestoreDefault();
            this.OnLoad(new EventArgs());
        }

        private void rdoStudent_Click(object sender, EventArgs e)
        {
            if (rdoStudent.Checked == true)
            {
                if (listSeatSelected.Count == 0) return;
                Ticket ticket = listSeatSelected[listSeatSelected.Count - 1].Tag as Ticket;
                ticket.TicketType = 2;

                float oldPrice = ticket.TicketPrice;
                ticket.TicketPrice = 0.8f * ticketPrice;
                displayPrice = ticket.TicketPrice;
                total = total + ticket.TicketPrice - oldPrice;
                payment = total - discount;

                LoadBill();
            }
        }

        private void rdoAdult_Click(object sender, EventArgs e)
        {
            if (rdoAdult.Checked == true)
            {
                if (listSeatSelected.Count == 0) return;
                Ticket ticket = listSeatSelected[listSeatSelected.Count - 1].Tag as Ticket;
                ticket.TicketType = 1;

                float oldPrice = ticket.TicketPrice;
                ticket.TicketPrice = ticketPrice;
                displayPrice = ticket.TicketPrice;
                total = total + ticket.TicketPrice - oldPrice;
                payment = total - discount;

                LoadBill();
            }
        }

        private void rdoChild_Click(object sender, EventArgs e)
        {
            if (rdoChild.Checked == true)
            {
                if (listSeatSelected.Count == 0) return;
                Ticket ticket = listSeatSelected[listSeatSelected.Count - 1].Tag as Ticket;
                ticket.TicketType = 3;

                float oldPrice = ticket.TicketPrice;
                ticket.TicketPrice = 0.7f * ticketPrice;
                displayPrice = ticket.TicketPrice;
                total = total + ticket.TicketPrice - oldPrice;
                payment = total - discount;

                LoadBill();
            }
        }

        private void chkCustomer_Click(object sender, EventArgs e)
        {
            if (chkCustomer.Checked == true)
            {
                FormCustomer frm = new FormCustomer();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    customer = frm.customer;
                    lblCustomerName.Text = customer.FullName;
                    lblPoint.Text = customer.Points + "";
                    ShowOrHideLablePoint();
                }
                else
                {
                    chkCustomer.Checked = false;
                }
            }
            else
            {
                ShowOrHideLablePoint();
                customer = null;
            }
        }

        private void btnFreeTicket_Click(object sender, EventArgs e)
        {
            int freeTickets = (int)numericFreeTickets.Value;
            if (freeTickets <= 0) return;

            if (freeTickets > listSeat.Count)
            {
                MessageBox.Show("BẠN CHỈ ĐỔI ĐƯỢC TỐT ĐA [" + listSeatSelected.Count + "] VÉ", "THÔNG BÁO");
                return;
            }
            int pointFreeTicket = freeTickets * 20;
            if (customer.Points < pointFreeTicket)
            {
                MessageBox.Show("BẠN KHÔNG ĐỦ ĐIỂM TÍCH LŨY ĐỂ ĐỔI [" + freeTickets + "] VÉ", "THÔNG BÁO");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("BẠN CÓ MUỐN DÙNG ĐIỂM TÍCH LŨY ĐỂ ĐỔI [" + freeTickets + "] VÉ MIỄN PHÍ KHÔNG?",
                                        "THÔNG   BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    customer.Points -= pointFreeTicket;
                    plusPoint -= freeTickets;

                    if (CustomerDAO.UpdatePointCustomer(customer.ID, customer.Points))
                    {
                        MessageBox.Show("BẠN ĐÃ DỔI ĐƯỢC [" + freeTickets + "] VÉ MIỄN PHÍ THÀNH CÔNG", "THÔNG BÁO");
                    }
                    lblPoint.Text = "" + customer.Points;
                    lblPlusPoint.Text = "" + plusPoint;

                    for (int i = 0; i < listSeatSelected.Count && freeTickets > 0; i++)
                    {
                        Ticket ticket = listSeatSelected[i].Tag as Ticket;
                        if (ticket.TicketPrice != 0)
                        {
                            discount += ticket.TicketPrice;
                            ticket.TicketPrice = 0;
                            freeTickets--;
                        }
                    }

                    payment = total - discount;
                    LoadBill();
                }
            }
        }
    }
}
