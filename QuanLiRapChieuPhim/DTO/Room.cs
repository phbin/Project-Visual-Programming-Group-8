using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim.DTO
{
    public class Room
    {
        public string ID { get; set; }

        public string NameRoom { get; set; }

        public string IDScreen { get; set; }

        public int NumOfSeat { get; set; }

        public string Stt { get; set; }

        public int RowOfSeat { get; set; }

        public int SeatOfRow { get; set; }

        public Room(string id, string room, string screenType, int seats, string status, int row, int seatsOfRow)
        {
            ID = id;
            NameRoom = room;
            IDScreen = screenType;
            NumOfSeat = seats;
            Stt = status;
            RowOfSeat = row;
            SeatOfRow = seatsOfRow;
        }

        public Room(DataRow row)
        {
            ID = row["ID"].ToString();
            NameRoom = row["NameRoom"].ToString();
            IDScreen = row["IDScreen"].ToString();
            NumOfSeat = (int)row["NumOfSeat"];
            Stt = row["Stt"].ToString();
            RowOfSeat = (int)row["RowOfSeat"];
            SeatOfRow = (int)row["SeatOfRow"];
        }
    }
}