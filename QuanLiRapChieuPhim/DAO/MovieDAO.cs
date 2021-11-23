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
        public void InsertMovie(string id, string name, string desc, int timelimit, DateTime startDate, DateTime endDate, string country, string director, int year, byte[] image)
        {
            //int result = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_InsertMovie @id , @name , @des , @time, @dpublic , @dout , @country , @dir , @year , @poster ", new object[] { id, name, desc, timelimit, startDate, endDate, country, director, year, image });
            string query = "INSERT dbo.Movie ([id], [NameFilm], [Descript], [TimeLimit], [DatePublic], [DateOut], [Country], [Director], [YearFilm],[Poster]) VALUES ('" + id + "','" + name + "','" + desc + "','" + timelimit + "','" + startDate + "','" + endDate + "','" + country + "','" + director + "','" + year + "','" + image + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void UpdateMovie(string id, string name, string desc, int timelimit, DateTime startDate, DateTime endDate, string country, string director, int year, byte[] image)
        {
            //int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateMovie @id , @name , @des , @time, @dpublic , @dout , @country , @dir , @year , @poster ", new object[] { id, name, desc, timelimit, startDate, endDate, country, director, year, image });
            string query = "UPDATE dbo.Movie SET NameFilm='" + name + "', Descript='" + desc + "', TimeLimit='" + timelimit + "', DatePublic='" + startDate + "', DateOut='" + endDate + "', Country='" + country+ "', Director='" + director + "', YearFilm='" + year + "', Poster='" + image+"'WHERE ID='" + id + "'";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void DeleteMovie(string id)
        {
            DataProvider.Instance.ExecuteNonQuery("DELETE dbo.Classify WHERE idmovie = '" + id + "'");
            MovieByGenreDAO.DeleteMovie_GenreByMovieID(id);
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.Movie WHERE id = '" + id + "'");
        }
        public DataTable SearchMovie(string name)
        {
            string query = "SELECT ID, NameFilm, DatePublic, DateOut, TimeLimit, Director, Country FROM dbo.Movie WHERE NameFilm LIKE '%" + name + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        // image -> byte, insert image into database
        public static byte[] imageToByteArray(Image img)
        {
            //FileStream fs;
            //BinaryReader br;
            //byte[] imgbyte;

            //if (!File.Exists(path)) { return null; }
            //fs = new FileStream(path, FileMode.Open);
            //br = new BinaryReader(fs);
            //imgbyte = new byte[fs.Length];
            //imgbyte = br.ReadBytes(Convert.ToInt32((fs.Length)));
            //br.Close(); fs.Close(); return imgbyte;
            using (MemoryStream ms=new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }    
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
