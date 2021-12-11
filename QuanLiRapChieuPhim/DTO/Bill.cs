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
            this.iD = (int)row[0];
            this.staff = row[1].ToString();
            this.date = row[2].ToString();
            this.status = (int)row[3];
            this.total = float.Parse(row[4].ToString());
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
