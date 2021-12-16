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
        public List<Seat> GetSeat()
        {
            List<Seat> listShowTimes = new List<Seat>();
            string query = "SELECT * FROM Seat";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Seat st = new Seat(item);
                listShowTimes.Add(st);
            }
            return listShowTimes;
        }
        public List<Seat> GetSeatByID(string id)
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
        public List<Seat> GetSeat2(string id)
        {
            List<Seat> listShowTimes = new List<Seat>();
            string query = "SELECT * FROM Seat where (SUBSTRING(SeatName, 2, 2) in ('02','03','04','05','06','07','08','09','10','11')) and idshowtime = '" + id + "'";
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
