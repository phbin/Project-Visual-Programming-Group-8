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
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BillInfo billInfo = new BillInfo(item);
                billInfoList.Add(billInfo);
            }

            return billInfoList;
        }

        public void InserttBillInfo(int iDBill, int iDFD, int count)
        {
            string query = "EXEC USP_InsertBillInfo @idBill , @idFD , @count";
            DataProvider.Instance.ExcuteNonQuery(query, new object[] { iDBill, iDFD, count });
        }

        public void RemoveAllBillInfoByBillID(int iDBill)
        {
            string query = "DELETE FROM BillInfo WHERE IDBill = " + iDBill;
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
