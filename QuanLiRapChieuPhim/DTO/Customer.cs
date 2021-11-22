using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiRapChieuPhim.DTO
{
    public class Customer
    {
        public string ID { get; set; }

        public string FullName { get; set; }

        public DateTime DoB { get; set; }

        public string Addr { get; set; }

        public string Phone { get; set; }

        public int IDPersonal { get; set; }

        public int Points { get; set; }

        public Customer(string id, string name, DateTime birth, string address, string phone, int idCard, int points)
        {
            ID = id;
            FullName = name;
            DoB = birth;
            Addr = address;
            Phone = phone;
            IDPersonal = idCard;
            Points = points;
        }

        public Customer(DataRow row)
        {
            ID = row["ID"].ToString();
            FullName = row["FullName"].ToString();
            DoB = DateTime.Parse(row["DoB"].ToString());
            Addr = row["Addr"].ToString();
            Phone = row["Phone"].ToString();
            IDPersonal = (int)row["IDPersonal"];
            Points = (int)row["Points"];
        }
    }
}