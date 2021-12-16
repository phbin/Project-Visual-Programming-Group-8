using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim.DTO
{
    public class TicketBill
    {
        private int iD;
        private string staff;
        private string date;
        private float total;

        public TicketBill(int id, string staff, string date, float total)
        {
            this.iD = id;
            this.staff = staff;
            this.date = date;
            this.total = total;
        }

        public TicketBill(DataRow row)
        {
            this.iD = (int)row[0];
            this.staff = row[1].ToString();
            this.date = row[2].ToString();
            this.total = float.Parse(row[3].ToString());
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

        public float Total
        {
            get { return total; }
            set { total = value; }
        }
    }
}