using System.Data;

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

        public int GetStatusBill(int iDBill)
        {
            string query = "SELECT stt FROM Bill WHERE ID = " + iDBill;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            
            if (data.Rows.Count > 0)
            {
                int stt = (int)data.Rows[0].ItemArray[0];
                return stt;
            }

            return 0;
        }

        public void UpdateDateBill(int iDBill)
        {
            string query = "UPDATE Bill SET DateBooking = GETDATE() WHERE ID = " + iDBill;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int GetLastIDBill()
        {
            string query = "SELECT ID FROM Bill WHERE ID = (SELECT max(ID) FROM Bill)";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            
            if (data.Rows.Count > 0)
            {
                int id = (int)data.Rows[0].ItemArray[0];
                return id;
            }

            return 0;
        }

        public Bill GetBillByID(int id)
        {
            string query = "SELECT * FROM Bill WHERE ID = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                Bill b = new Bill(data.Rows[0]);
                return b;
            }

            return null;
        }

        public void InsertBill(int iDBill)
        {
            string query = "INSERT	dbo.Bill (ID, IDStaff, DateBooking , stt, Total) VALUES  (" + iDBill + ", '" + FormLogin.ID_USER + "', GETDATE(), 0, 0)";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void CheckOut(int iDBill)
        {
            string query = "UPDATE Bill SET stt = 1 WHERE ID = " + iDBill;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
