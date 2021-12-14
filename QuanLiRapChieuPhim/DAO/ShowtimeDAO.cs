using QuanLiRapChieuPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim.DAO
{
    public class ShowtimeDAO
    {
        private static ShowtimeDAO instance;

        public static ShowtimeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ShowtimeDAO();
                return instance;
            }

            private set { instance = value; }
        }

        private ShowtimeDAO() { }
        public static List<Showtime> GetAllListShowTimes()
        {
            List<Showtime> listShowTimes = new List<Showtime>();
            string query = "SELECT * FROM Showtime";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Showtime st = new Showtime(item);
                listShowTimes.Add(st);
            }
            return listShowTimes;
        }
        public static List<Showtime> ShowtimeByID(string id)
        {
            List<Showtime> listShowTimes = new List<Showtime>();
            string query = "SELECT * FROM Showtime where IDMovie = N'" + id + "' order by shtime";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Showtime st = new Showtime(item);
                listShowTimes.Add(st);
            }
            return listShowTimes;
        }
        public static List<Showtime> ShowtimeByIDST(string id)
        {
            List<Showtime> listShowTimes = new List<Showtime>();
            string query = "SELECT * FROM Showtime where ID = N'" + id + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Showtime st = new Showtime(item);
                listShowTimes.Add(st);
            }
            return listShowTimes;
        }
        public static List<Showtime> GetDate()
        {
            List<Showtime> listShowTimes = new List<Showtime>();
            string query = "SELECT format(dd/mm/yyyy,shtime) FROM Showtime";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Showtime st = new Showtime(item, 1);
                listShowTimes.Add(st);
            }
            return listShowTimes;
        }
        public void InsertShowtime(string id, string idmovie, string time, string idroom, int ticketPrice)
        {
            DataProvider.Instance.ExecuteNonQuery("INSERT into dbo.ShowTime([id], [shTime], [IDMovie], [IDRoom], [TicketPrice]) VALUES (N'" + id + "','" + time + "',N'" + idmovie + "',N'" + idroom + "'," + ticketPrice + ")");
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertSeat '"+id+"'");
        }

        public void UpdateShowtime(string id, string idmovie, string time, string idroom)
        {
            //DataProvider.Instance.ExecuteNonQuery("set dateformat dmy");
            //string query = string.Format("EXEC USP_UpdateShowtime ");
            //DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, idmovie, time, idroom });
            DataProvider.Instance.ExecuteNonQuery("delete from seat where id='" + id + "'");
            DataProvider.Instance.ExecuteNonQuery("update dbo.ShowTime set time='" + time + "' and idroom='" + idroom + "' where id='" + id + "'");
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertSeat '" + id + "'");
        }

        public void DeleteShowtime(string id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.ShowTime WHERE id = '" + id + "'");
        }

        public DataTable SearchShowtimeByMovieName(string movieName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SearchShowtimeByMovieName @tenPhim ", new object[] { movieName });
            return data;
        }
    }
}
