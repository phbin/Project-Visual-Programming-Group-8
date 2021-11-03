using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim.DTO
{
    class FDCategory
    {
        private int iD;
        private string name;

        public FDCategory(int id, string name)
        {
            this.iD = id;
            this.name = name;
        }

        public FDCategory(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.name = row["NameCategory"].ToString();
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
