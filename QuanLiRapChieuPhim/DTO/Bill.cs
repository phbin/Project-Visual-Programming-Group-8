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
        private string staff;
        private string date;
        private int status;
        private float total;
        public Bill(int id, string staff, string date, int stt, int total)
        {
            this.iD = id;
            this.staff = staff;
            this.date = date;
            this.status = stt;
            this.total = total;
        }

        public Bill(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.staff = row["IDStaff"].ToString();
            this.date = row["DateBooking"].ToString();
            this.status = (int)row["stt"];
            this.total = float.Parse(row["Total"].ToString());
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string Staff
        {
            get { return staff; }
            set { staff = value; }
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

        public float Total
        {
            get { return total; }
            set { total = value; }
        }
    }
}
