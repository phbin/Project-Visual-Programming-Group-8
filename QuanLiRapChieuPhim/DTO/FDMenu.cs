using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim.DTO
{
    public class FDMenu
    {
        private string name;
        private int quantity;
        private float price;
        private float totalPrice;

        public FDMenu(string name, int quantity, float price, float totalPrice)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.totalPrice = totalPrice;
        }

        public FDMenu(DataRow row)
        {
            this.name = row["NameFD"].ToString();
            this.quantity = (int)row["Num"];
            this.price = float.Parse(row["Price"].ToString());
            this.TotalPrice = float.Parse(row["TotalPrice"].ToString());
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
    }
}
