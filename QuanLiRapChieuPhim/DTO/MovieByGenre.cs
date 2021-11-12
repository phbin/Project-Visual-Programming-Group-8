using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim.DTO
{
    public class MovieByGenre
    {
        private string iDKind;
        private string iDMovie;

        public MovieByGenre(string idmovie, string idkind)
        {
            this.iDMovie = idmovie;
            this.iDKind = idkind;
        }

        public MovieByGenre(DataRow row)
        {
            this.iDMovie = row["IDMovie"].ToString();
            this.iDKind = row["IDKind"].ToString();
        }

        public string IDMovie 
        {
            get { return iDMovie; }
            set { iDMovie = value; }
        }

        public string IDKind 
        {
            get { return iDKind; }
            set { iDKind = value; }
        }
    }
}
