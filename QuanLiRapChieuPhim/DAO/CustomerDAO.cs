using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim.DAO
{
    public class CustomerDAO
    {
        public static bool UpdatePointCustomer(string id, int point)
        {
            string command = string.Format("UPDATE dbo.InfoCustomer SET  Points = {0} WHERE ID = '{1}'", point, id);
            int result = DataProvider.Instance.ExecuteNonQuery(command);
            return result > 0;
        }
    }
}