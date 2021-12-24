using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim.DAO
{
    class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoDAO();
                return instance;
            }

            private set { instance = value; }
        }

        private BillInfoDAO() { }

        public List<BillInfo> GetListBillInfo(int iDBill)
        {
            List<BillInfo> billInfoList = new List<BillInfo>();
            string query = "SELECT * FROM BillInfo WHERE IDBill = " + iDBill;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BillInfo billInfo = new BillInfo(item);
                billInfoList.Add(billInfo);
            }

            return billInfoList;
        }

        public int CountBillInfoByIDBill(int iDBill)
        {
            string query = "SELECT COUNT(*) FROM BILLINFO WHERE IDBILL = " + iDBill;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                int count = (int)data.Rows[0].ItemArray[0];
                return count;
            }

            return 0;
        }

        public void InserttBillInfo(int iDBill, int iDFD, int count)
        {
            string query = "EXEC USP_InsertBillInfo @idBill , @idFD , @count";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { iDBill, iDFD, count });
        }

        public void RemoveFoodDrinkByIDFoodDrink(int iDBill, int iDFD)
        {
            string query = "EXEC USP_DeleteBillInfo " + iDBill + ", " + iDFD;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
