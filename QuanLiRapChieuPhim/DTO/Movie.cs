using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QuanLiRapChieuPhim.DTO
{
    public class Movie
    {
        private string iD;
        private string name;
        private string desc;
        public float timelimit;
        DateTime datepublic;
        DateTime dateout;
        string country;
        string director;
        int year;
        byte[] poster;

        public Movie(string id, string name, string desc, float timelimit, DateTime datepublic, DateTime dateout, string country, string director, int year, byte[] poster)
        {
            this.iD = id;
            this.name = name;
            this.desc = desc;
            this.timelimit = timelimit;
            this.datepublic = datepublic;
            this.dateout = dateout;
            this.country = country;
            this.director = director;
            this.year = year;
            this.poster = poster;  
        }

        public Movie(DataRow row)
        {
            this.iD = row["ID"].ToString();
            this.name = row["NameFilm"].ToString();
            this.desc = row["Descript"].ToString();
            this.timelimit = float.Parse(row["TimeLimit"].ToString());
            this.datepublic = DateTime.Parse(row["DatePublic"].ToString());
            this.dateout = DateTime.Parse(row["DateOut"].ToString());
            this.country = row["Country"].ToString();
            this.director = row["Director"].ToString();
            this.year = (int)row["YearFilm"];
            if (row["Poster"].ToString() == "")
                this.poster = null;
            else
                this.poster = (byte[])row["Poster"];
        }

        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }
        public float Timelimit
        {
            get { return timelimit; }
            set { timelimit = value; }
        }
        public DateTime Datepublic
        {
            get { return datepublic; }
            set { datepublic = value; }
        }
        public DateTime Dateout
        {
            get { return dateout; }
            set { dateout = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string Director
        {
            get { return director; }
            set { director = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public byte[] Poster
        {
            get { return poster; }
            set { poster = value; }
        }
    }
}
