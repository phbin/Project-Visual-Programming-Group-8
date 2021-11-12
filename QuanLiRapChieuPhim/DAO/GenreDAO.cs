using QuanLiRapChieuPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim.DAO
{
    public class GenreDAO
    {
        private static GenreDAO instance;

        public static GenreDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new GenreDAO();
                return instance;
            }

            private set { instance = value; }
        }

        private GenreDAO() { }
        public static List<Genre> GetListGenre()
        {
            List<Genre> genreList = new List<Genre>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.MovieKind");
            foreach (DataRow item in data.Rows)
            {
                Genre genre = new Genre(item);
                genreList.Add(genre);
            }
            return genreList;
        }

        public static DataTable GetGenre()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT id AS [Mã thể loại], TypeName AS [Tên thể loại], Descript AS [Mô tả] FROM dbo.MovieKind");
        }

    }
}
