using QuanLiRapChieuPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim.DAO
{
    class MovieByGenreDAO
    {
        private static MovieByGenreDAO instance;

        public static MovieByGenreDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MovieByGenreDAO();
                return instance;
            }

            private set { instance = value; }
        }

        private MovieByGenreDAO() { }
        public static List<Genre> GetGenreByMovie(string id)
        {
            List<Genre> genreList = new List<Genre>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetGenreByMovie @id", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Genre genre = new Genre(item);
                genreList.Add(genre);
            }
            return genreList;
        }
        public static List<Genre> GetGenre(string id)
        {
            List<Genre> genreList = new List<Genre>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetGenre @id", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Genre genre = new Genre(item);
                genreList.Add(genre);
            }
            return genreList;
        }
        public static void InsertMovie_Genre(string movieID, List<Genre> genreList)
        {
            foreach (Genre item in genreList)
            {
                string command = string.Format("INSERT dbo.Classify (IDMovie, IDKind) VALUES  ('{0}','{1}')", movieID, item.ID);
                DataProvider.Instance.ExecuteNonQuery(command);
            }
        }
        public static void UpdateMovie_Genre(string movieID, List<Genre> genreList)
        //Idea : Delete all rows that contain movieID, then re-add all genre that have been chosen from CheckedListBox to 'PhanLoaiPhim' with movieID
        {
            DataProvider.Instance.ExecuteNonQuery("DELETE dbo.Classify WHERE IDMovie = '" + movieID + "'");
            foreach (Genre item in genreList)
            {
                string command = string.Format("INSERT dbo.Classify (IDMovie, IDKind) VALUES  ('{0}','{1}')", movieID, item.ID);
                DataProvider.Instance.ExecuteNonQuery(command);
            }
        }
        public static void DeleteMovie_GenreByMovieID(string movieID)
        {
            DataProvider.Instance.ExecuteNonQuery("DELETE dbo.Classify WHERE IDMovie = '" + movieID + "'");
        }
    }
}
