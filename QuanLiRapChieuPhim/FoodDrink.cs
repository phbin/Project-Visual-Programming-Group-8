using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim
{
    class FoodDrink
    {
        private string iDFD;
        private string nameFD;
        private string typeFD;
        private int price;
        public FoodDrink(string id = "", string name = "", string type = "", int price = 0)
        {
            this.iDFD = id;
            this.nameFD = name;
            this.typeFD = type;
            this.price = price;
        }
        public string IDFoodDrink
        {
            get { return iDFD; }
            set { iDFD = value; }
        }
        public string NameFD
        {
            get { return nameFD; }
            set { nameFD = value; }
        }

        public string TypeFD
        {
            get { return typeFD; }
            set { typeFD = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
