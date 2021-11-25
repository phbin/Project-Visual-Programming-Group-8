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
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetShowtime");
            foreach (DataRow row in data.Rows)
            {
                Showtime showTimes = new Showtime(row);
                listShowTimes.Add(showTimes);
            }
            return listShowTimes;
        }
       

        public void InsertShowtime(string id,  string idmovie, string time, string idroom, int ticketPrice)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("INSERT into dbo.ShowTime([id], [shTime], [IDMovie], [IDRoom], [TicketPrice]) VALUES (N'"+id+"','" + time + "',N'" + idmovie + "',N'" + idroom + "'," + ticketPrice + ")");
        }

        public void UpdateShowtime(string id, string cinemaID, string formatMovieID, DateTime time, int ticketPrice)
        {
            string command = string.Format("USP_UpdateShowtime @id , @idPhong , @idDinhDang , @thoiGianChieu , @giaVe ");
            int result = DataProvider.Instance.ExecuteNonQuery(command, new object[] { id, cinemaID, formatMovieID, time, ticketPrice });
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
