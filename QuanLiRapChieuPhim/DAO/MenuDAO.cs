using QuanLiRapChieuPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MenuDAO();
                return instance;
            }

            private set { instance = value; }
        }

        private MenuDAO() { }

        public List<FDMenu> GetListMenuByBillID(int iDBill)
        {
            List<FDMenu> menuList = new List<FDMenu>();

            string query = "SELECT FD.NameFD, BI.Num, FD.Price, FD.Price*BI.Num AS TotalPrice FROM Bill B, BillInfo BI, FoodDrink FD WHERE B.ID = BI.IDBill AND BI.IDFoodDrink = FD.ID AND BI.IDBill = " + iDBill;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            
            foreach (DataRow item in data.Rows)
            {
                FDMenu menu = new FDMenu(item);
                menuList.Add(menu);
            }

            return menuList;
        }
    }
}
