﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim.DAO
{
    class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return instance;
            }

            private set { instance = value; }
        }

        private BillDAO() { }

        public void InsertBill(int iD)
        {
            string query = "EXEC USP_InsertBill @idBill";
            DataProvider.Instance.ExcuteNonQuery(query, new object[] { iD });
        }

        public int GetStatusBill(int iDBill)
        {
            string query = "SELECT stt FROM Bill WHERE ID = " + iDBill;
            int data = (int)DataProvider.Instance.ExcuteScalar(query);
            return data;
        }

        public int GetLastIDBill()
        {
            try
            {
                string query = "SELECT max(ID) FROM Bill";
                int data = (int)DataProvider.Instance.ExcuteScalar(query);
                return data;
            }
            catch
            {
                return 1;
            }
        }

        public void CheckOut(int iDBill)
        {
            string query = "UPDATE Bill SET stt = 1 WHERE ID = " + iDBill;
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
