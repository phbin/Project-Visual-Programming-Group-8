using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim
{
    //1 BillInfo = 1 FD with the iDFD and quantity + idBill
    class BillInfo
    {
        private int iDBill;
        private string iDFoodDrink;
        private int quantity;
        public BillInfo(int id, string idFD, int qty)
        {
            this.iDBill = id;
            this.iDFoodDrink = idFD;
            this.quantity = qty;
        }
        public int IDBill
        {
            get { return iDBill; }
            set { iDBill = value; }
        }
        public string IDFoodDrink
        {
            get { return iDFoodDrink; }
            set { iDFoodDrink = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { this.quantity = value; }
        }
    }
}
