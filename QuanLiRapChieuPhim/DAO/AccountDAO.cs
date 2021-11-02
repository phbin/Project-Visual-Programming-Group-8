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
        
        public void AddAcount(string Username, string Password, string ID, int Acctype)
        {
            string query = "INSERT dbo.Account([UserName], [Pass], [id], [AccType]) VALUES ('" + Username + "','" + Password + "','" + ID + "','" + Acctype + "')";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
        }

        public void DeleteAccont(string Username)
        {
            string query = "DELETE FROM dbo.Account WHERE Username='" + Username + "'";
            DataProvider.Instance.ExcuteQuery(query);
        }

        public void EditAccount(string Username, string Password, string ID, int Acctype)
        {
            string query = "UPDATE dbo.Account SET Username='" + Username + "', Pass='" + Password + "', ID='" + ID + "', Acctype='" + Acctype + "'WHERE Username='" + Username + "'";
            DataProvider.Instance.ExcuteQuery(query);
        }

        public DataTable SearchAccount(string Username)
        {
            string query = "SELECT * FROM dbo.Account WHERE Username LIKE '%"+Username+"%'";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public DataTable SearchInfoStaff(string Fullname)
        {
            string query = "SELECT * FROM dbo.InfoStaff WHERE FullName LIKE '%" + Fullname + "%'";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public void AddInfoStaff(string ID, string Fullname, string DoB, string Adress, string PhoneNum, string IDPersonal)
        {
            string query = "INSERT dbo.InfoStaff ([id], [FullName], [DoB], [Addr], [Phone], [IDPersonal]) VALUES ('" + ID + "',N'" + Fullname + "', CAST('" + DoB + "' AS Date),N'" + Adress + "','" + PhoneNum + "','" + IDPersonal + "')";
            DataProvider.Instance.ExcuteQuery(query);        
        }

        public void DeleteInfoStaff(string ID)
        {
            string query0 = "DELETE FROM dbo.Account WHERE ID='" + ID + "'";
            DataProvider.Instance.ExcuteQuery(query0);

            string query = "DELETE FROM dbo.InfoStaff WHERE ID='" + ID + "'";
            DataProvider.Instance.ExcuteQuery(query);
        }

        public void EditInfoStaff(string ID, string Fullname, string DoB, string Address, string PhoneNum, string IDPersonal)
        {
            string query = "UPDATE dbo.InfoStaff SET FullName=N'" + Fullname + "', DoB='" + DoB + "', Addr='" + Address + "', Phone='" + PhoneNum + "', IDPersonal='" + IDPersonal + "' WHERE ID='" + ID + "'";
            DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
