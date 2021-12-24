using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim
{
    public class FoodDrink
    {
        private int iD;
        private string name;
        private int category;
        private float price;
        byte[] picture;

        public FoodDrink(int id, string name, int category, float price,byte[] picture)
        {
            this.iD = id;
            this.name = name;
            this.category = category;
            this.price = price;
            this.picture = picture;
        }

        public FoodDrink(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.name = row["NameFD"].ToString();
            this.category = (int)row["IDCategory"];
            this.price = float.Parse(row["Price"].ToString());
            if (row["Picture"].ToString() == "")
                this.picture = null;
            else
                this.picture = (byte[])row["Picture"];
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

        public int Category
        {
            get { return category; }
            set { category = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        public byte[] Picture
        {
            get { return picture; }
            set { picture = value; }
        }
    }
}
