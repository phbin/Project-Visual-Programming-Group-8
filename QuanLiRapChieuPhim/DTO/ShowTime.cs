using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiRapChieuPhim.DTO
{
    public class ShowTime
    {
        public string ID { get; set; }

        public DateTime shTime { get; set; }

        public string IDRoom { get; set; }

        public string IDFormat { get; set; }

        public float TicketPrice { get; set; }

        public int stt { get; set; }

        //public string NameFilm { get; set; }

        public ShowTime() { }
        public ShowTime(string id, DateTime time, string room, string formatMovie, float ticketPrice, int status)//, string movie)
        {
            ID = id;
            shTime = time;
            IDRoom = room;
            IDFormat = formatMovie;
            TicketPrice = ticketPrice;
            stt = status;
            //NameFilm = movie
        }

        public ShowTime(DataRow row)
        {
            ID = row["ID"].ToString();
            shTime = (DateTime)row["shTime"];
            IDRoom = row["IDRoom"].ToString();
            IDFormat = row["IDFormat"].ToString();
            if (row["TicketPrice"].ToString() == "")
            {
                TicketPrice = 0;
            }
            else
            {
                TicketPrice = float.Parse(row["TicketPrice"].ToString());
            }
            stt = (int)row["stt"];
            //NameFilm = row["NameFilm"].ToString();
        }
    }
}
