using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim.DTO
{
    public class Showtime
    {
        private string iD;
        public string iDMovie;
        public DateTime time;
        private string idRoom;
        public float ticketPrice;

        public Showtime(string id, string idmovie, DateTime time, string idroom, float ticketprice)
        {
            this.iD = id;
            this.iDMovie = idmovie;
            this.time = time;
            this.idRoom = idroom;
            this.ticketPrice = ticketprice;
        }

        public Showtime(DataRow row)
        {
            this.iD = row["ID"].ToString();
            this.iDMovie = row["IDMovie"].ToString();
            this.time = (DateTime)row["shTime"];
            this.idRoom = row["IDRoom"].ToString();
            this.TicketPrice = (float)row["TicketPrice"];
        }

        public string ID 
        {
            get { return iDMovie; }
            set { iDMovie = value; }
        }

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        public string IDMovie 
        {
            get { return iDMovie; }
            set { iDMovie = value; }
        }

        public string IDRoom
        {
            get { return idRoom; }
            set { idRoom = value; }
        }

        public float TicketPrice 
        {
            get { return ticketPrice; }
            set { ticketPrice = value; }
        }

    }
}
