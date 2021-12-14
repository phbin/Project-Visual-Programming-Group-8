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
            int data = (int)DataProvider.Instance.ExecuteScalar(query);
            return data;
        }

        public void UpdateDateBill(int iDBill)
        {
            string query = "UPDATE Bill SET DateBooking = GETDATE() WHERE ID = " + iDBill;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int GetLastIDBill()
        {
            try
            {
                string query = "SELECT * FROM Bill WHERE ID = (SELECT max(ID) FROM Bill)";
                int data = (int)DataProvider.Instance.ExecuteScalar(query);
                return data;
            }
            catch   //No bill exists in database
            {
                return 0;
            }
        }

        public Bill GetBillByID(int id)
        {
            try
            {
                string query = "SELECT * FROM Bill WHERE ID = " + id;
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                Bill b = new Bill(data.Rows[0]);

                return b;   
            }
            catch   //No bill exists in database
            {
                return null;
            }
        }

        public void InsertBill(int iDBill)
        {
            string query = "INSERT	dbo.Bill (IDStaff, DateBooking , stt, Total) VALUES  ('" + FormLogin.ID_USER + "', GETDATE(), 0, 0)";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void CheckOut(int iDBill)
        {
            string query = "UPDATE Bill SET stt = 1 WHERE ID = " + iDBill;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
