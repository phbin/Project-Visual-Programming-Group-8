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
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from ShowTime");
            foreach (DataRow row in data.Rows)
            {
                Showtime showTimes = new Showtime(row);
                listShowTimes.Add(showTimes);
            }
            return listShowTimes;
        }
       

        public void InsertShowtime(string id,  string idmovie, DateTime time, string idroom, double ticketPrice)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_InsertShowtime @id, @idmovie, @thoiGianChieu, @idPhong, @giaVe", new object[] { id,idmovie,time,idroom,ticketPrice }); 
        }

        public void UpdateShowtime(string id, string cinemaID, string formatMovieID, DateTime time, double ticketPrice)
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
