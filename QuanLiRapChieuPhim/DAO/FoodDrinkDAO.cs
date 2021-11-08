using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim.DAO
{
    public class FoodDrinkDAO
    {
        private static FoodDrinkDAO instance;

        public static FoodDrinkDAO Instance
        {
            get
            { if (instance == null)
                    instance = new FoodDrinkDAO();
                return instance;
            }
            
            private set { instance = value; }
        }

        private FoodDrinkDAO() { }

        public List<FoodDrink> GetFoodDrinkByCategoryID(int iDCate)
        {
            List<FoodDrink> fDList = new List<FoodDrink>();

            string query = "SELECT * FROM FoodDrink WHERE IDCategory = " + iDCate; 
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                FoodDrink fD = new FoodDrink(item);
                fDList.Add(fD);
            }

            return fDList;
        }
    }
}
