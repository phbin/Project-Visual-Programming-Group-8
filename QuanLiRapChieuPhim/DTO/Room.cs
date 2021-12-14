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


        public Room(string id, string room, string screenType, int seats, string status, int row, int seatsOfRow)
        {
            ID = id;
            NameRoom = room;
        }

        public Room(DataRow row)
        {
            ID = row["ID"].ToString();
            NameRoom = row["NameRoom"].ToString();
        }
    }
}