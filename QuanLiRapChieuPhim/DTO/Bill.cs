using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim
{
    public class Bill
    {
        private int iD;
        private string date;
        private int status;
        public Bill(int id, string date, int stt)
        {
            this.iD = id;
            this.date = date;
            this.status = stt;
        }

        public Bill(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.date = row["DateBooking"].ToString();
            this.status = (int)row["stt"];
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
