using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public int Login(string Username, string Password)
        {
            string query = "SELECT * FROM dbo.Account WHERE Username='"+Username+"' AND Pass='"+Password+"'AND AccType='"+ 1 +"'";
            DataTable result1 = DataProvider.Instance.ExcuteQuery(query);
            if (result1.Rows.Count > 0)
                return 1;
            query = "SELECT * FROM dbo.Account WHERE Username='" + Username + "' AND Pass='" + Password + "'AND AccType='" + 0 + "'";
            DataTable result0 = DataProvider.Instance.ExcuteQuery(query);
            if (result0.Rows.Count > 0)
                return 0;
            return -1;
        }
    }
}
