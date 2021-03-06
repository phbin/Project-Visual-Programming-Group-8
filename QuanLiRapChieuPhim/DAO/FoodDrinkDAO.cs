using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            {
                if (instance == null)
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
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                FoodDrink fD = new FoodDrink(item);
                fDList.Add(fD);
            }

            return fDList;
        }

        public int GetIDFoodDrinkByName(string name)
        {
            string query = "SELECT ID FROM FoodDrink WHERE NameFD = N'" + name + "'";
            int data = (int)DataProvider.Instance.ExecuteScalar(query);
            return data;
        }
        // image -> byte, insert image into database
        public void imageToByteArray(string path, int idc,string name,float price)
        {
            string query = "update FoodDrink set Picture = (select * from openrowset(bulk N'" + path + "', single_blob) as img) where IDCategory = '" + idc + "' and NameFD=N'"+name+"' and price='"+price+"'";
            DataProvider.Instance.ExecuteQuery(query);
        }
        // byte[] -> image, get image from database
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
