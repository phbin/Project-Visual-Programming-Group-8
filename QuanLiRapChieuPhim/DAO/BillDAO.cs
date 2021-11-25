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

        public void InsertBill(int iD)
        {
            string query = "EXEC USP_InsertBill @idBill";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { iD });
        }

        //public int GetStatusBill(int iDBill)
        //{
        //    string query = "SELECT stt FROM Bill WHERE ID = " + iDBill;
        //    int data = (int)DataProvider.Instance.ExecuteScalar(query);
        //    return data;
        //}

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

        public void CheckOut(int iDBill)
        {
            string query = "UPDATE Bill SET stt = 1 WHERE ID = " + iDBill;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public Bill GetLastBill()
        {
            try
            {
                string query = "SELECT * FROM Bill WHERE ID = (SELECT max(ID) FROM Bill)";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                Bill b = new Bill(data.Rows[0]);

                return b;
            }
            catch   //No bill exists in database
            {
                return null;
            }
        }
    }
}
