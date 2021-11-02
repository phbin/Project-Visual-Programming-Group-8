using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiRapChieuPhim.DTO
{
    public class Movie
    {
        public string ID { get; set; }

        public string NameFilm { get; set; }

        public string Descript { get; set; }

        public float TimeLimit { get; set; }

        public DateTime DatePublic { get; set; }

        public DateTime DateOut { get; set; }

        public string Country { get; set; }

        public string Director { get; set; }

        public int YearFilm { get; set; }

        public byte[] Poster { get; set; }

        public Movie() { }
        public Movie(string id, string name, string desc, float time, DateTime start, DateTime end, string country, string director, int yearProduction, byte[] poster)
        {
            ID = id;
            NameFilm = name;
            Descript = desc;
            TimeLimit = time;
            DatePublic = start;
            DateOut = end;
            Country = country;
            Director = director;
            YearFilm = yearProduction;
            Poster = poster;
        }

        public Movie(DataRow row)
        {
            ID = row["ID"].ToString();
            NameFilm = row["NameFilm"].ToString();
            Descript = row[" Descript"].ToString();
            TimeLimit = float.Parse(row["TimeLimit"].ToString());
            DatePublic = (DateTime)row[" DatePubli"];
            DateOut = (DateTime)row["DateOut"];
            Country = row["Country"].ToString();
            Director = row["Direcctor"].ToString();
            YearFilm = (int)row["YearFilm"];
            if (row["Poster"].ToString() == "")
            {
                Poster = null;
            }
            else
            {
                Poster = (byte[])row["Poster"];
            }
        }
    }
}
