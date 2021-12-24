using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim.DTO
{
    public class Seat
    {
        public string IDShowtime { get; set; }
        public string SeatName { get; set; }
        public int Stt { get; set; }
        public string IDCustomer { get; set; }


        public Seat(string shtime, string seat, int status, string idcus)
        {
            IDShowtime = shtime;
            SeatName = seat;
            Stt = status;
            IDCustomer = idcus;
        }

        public Seat(DataRow row)
        {
            IDShowtime = row["IDShowtime"].ToString(); 
            SeatName = row["SeatName"].ToString();
            Stt = (int)row["stt"];
            IDCustomer = row["IDCustomer"].ToString();
        }
    }
}
