using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim.DTO
{
    public class Ticket
    {
        public string ID { get; set; }

        public int TicketType { get; set; }

        public string IDShowTime { get; set; }

        public string SeatCode { get; set; }

        public string IDCustomer { get; set; }
        public int stt { get; set; }

        public float TicketPrice { get; set; }


        public Ticket(string id, int type, string showTime, string seat, string customer, int status, float price)
        {
            ID = id;
            TicketType = type;
            IDShowTime = showTime;
            SeatCode = seat;
            IDCustomer = customer;
            stt = status;
            TicketPrice = price;
        }

        public Ticket(DataRow row)
        {
            ID = row["ID"].ToString();
            TicketType = (int)row["TicketType"];
            IDShowTime = row["IDShowTime"].ToString();
            SeatCode = row["SeatCode"].ToString();
            IDCustomer = row["IDCustomer"].ToString();
            stt = (int)row["stt"];
            if (row["TicketPrice"].ToString() == "")
            {
                TicketPrice = 0;
            }
            else
            {
                TicketPrice = float.Parse(row["TicketPrice"].ToString());
            }
        }
    }
}