using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim
{
    class BillInfo
    {
        private int iD;
        private int iDBill;
        private int iDFoodDrink;
        private int quantity;

        public BillInfo(int id, int idBill, int idFD, int qty)
        {
            this.iD = id;
            this.iDBill = idBill;
            this.iDFoodDrink = idFD;
            this.quantity = qty;
        }

        public BillInfo(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.iDBill = (int)row["IDBill"];
            this.iDFoodDrink = (int)row["IDFoodDrink"];
            this.quantity = (int)row["Num"];
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public int IDBill
        {
            get { return iDBill; }
            set { iDBill = value; }
        }

        public int IDFoodDrink
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
