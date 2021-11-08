using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim
{
    public class Bill
    {
        private int iDBill;
        private string date;
        private int value;
        public Bill(int id = 0, string date = "", int value = 0)
        {
            this.iDBill = id;
            this.date = date;
            this.value = value;
        }
        public int IDBill
        {
            get{ return iDBill; }
            set { iDBill = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }
    }
}
