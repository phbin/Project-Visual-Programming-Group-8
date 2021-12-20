using QuanLiRapChieuPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim.DAO
{
    public class SeatDAO
    {
        private static SeatDAO instance;

        public static SeatDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SeatDAO();
                return instance;
            }

            private set { instance = value; }
        }

        private SeatDAO() { }
        public static List<Seat> GetSeatBooked(string id)
        {
            List<Seat> listShowTimes = new List<Seat>();
            string query = "SELECT * FROM Seat where stt=2 and idshowtime='"+id+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Seat st = new Seat(item);
                listShowTimes.Add(st);
            }
            return listShowTimes;
        }
        public static List<Seat> GetSeatByID(string id)
        {
            List<Seat> listShowTimes = new List<Seat>();
            string query = "SELECT * FROM Seat where idshowtime = '"+id+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Seat st = new Seat(item);
                listShowTimes.Add(st);
            }
            return listShowTimes;
        }
        
        public void CheckStatus(string idst, string seatname)
        {
            string query = "UPDATE Seat SET stt = 1 WHERE IDShowtime = '" + idst + "' AND SeatName = '" + seatname + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
