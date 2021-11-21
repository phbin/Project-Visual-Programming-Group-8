using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim.DTO
{
    public class Genre
    {
        private string iD;
        private string name;
        private string desc;

        public Genre(string iD, string name, string desc = null)
        {
            this.iD = iD;
            this.name = name;
            this.desc = desc;
        }

        public Genre(DataRow row)
        {
            this.iD = row["id"].ToString();
            this.name = row["TypeName"].ToString();
            if (row["Descript"].ToString() != "")
                this.desc = row["Descript"].ToString();
            else
                this.desc = "";
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

        public string Des
        {
            get { return desc; }
            set { desc = value; }
        }
    }
}
