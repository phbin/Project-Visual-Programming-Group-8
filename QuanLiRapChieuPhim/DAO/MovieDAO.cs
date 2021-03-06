using QuanLiRapChieuPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim.DAO
{
    public class MovieDAO
    {
        private static MovieDAO instance;

        public static MovieDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MovieDAO();
                return instance;
            }

            private set { instance = value; }
        }

        private MovieDAO() { }
        public List<Movie> GetMovie()
        {
            List<Movie> movieList = new List<Movie>();

            string query = "SELECT * FROM Movie";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Movie mv = new Movie(item);
                movieList.Add(mv);
            }

            return movieList;
        }
        public string GetNameMovieByID(string id)
        {
            string query = "SELECT NameFilm FROM Movie WHERE ID = '" + id + "'";
            string data = (string)DataProvider.Instance.ExecuteScalar(query);

            return data;
        }
        public void InsertMovie(string id, string name, string desc, int timelimit, string startDate, string endDate, string country, string director, int year)
        {
            string query = "INSERT dbo.Movie ([id], [NameFilm], [Descript], [TimeLimit], [DatePublic], [DateOut], [Country], [Director], [YearFilm]) VALUES ('" + id + "',N'" + name + "',N'" + desc + "','" + timelimit + "','" + startDate + "','" + endDate + "',N'" + country + "',N'" + director + "','" + year +  "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void UpdateMovie(string id, string name, string desc, int timelimit, string startDate, string endDate, string country, string director, int year)
        {
          
            string query = "update movie set NameFilm =N'"+name+ "', Descript =N'" + desc + "',TimeLimit=" + timelimit + ",DatePublic=N'" + startDate + "',DateOut=N'" + endDate + "',Country=N'" + country + "',Director=N'" + director + "', YearFilm=" + year + " where id = '"+id+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void DeleteMovie(string id)
        {
            DataProvider.Instance.ExecuteNonQuery("DELETE dbo.Classify WHERE idmovie = '" + id + "'");
            DataProvider.Instance.ExecuteNonQuery("delete dbo.Seat where idshowtime in (select id from showtime where idmovie= '" + id + "')");
            DataProvider.Instance.ExecuteNonQuery("delete dbo.ShowTime where idmovie= '" + id + "'");
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.Movie WHERE id = '" + id + "'");
        }
        public DataTable SearchMovie(string name)
        {
            string query = "SELECT ID, NameFilm, DatePublic, DateOut, TimeLimit, Director, Country FROM dbo.Movie WHERE NameFilm LIKE '%" + name + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        // image -> byte, insert image into database
        public void imageToByteArray(string path, string id)
        {
            string query = "update Movie set Poster = (select * from openrowset(bulk N'"+path+"', single_blob) as img) where ID = '"+id+"'"; 
            DataProvider.Instance.ExecuteQuery(query);
        }
        // byte[] -> image, get image from database
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
