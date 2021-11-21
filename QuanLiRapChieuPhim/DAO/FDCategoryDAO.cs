using QuanLiRapChieuPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiRapChieuPhim.DAO
{
    class FDCategoryDAO
    {
        private static FDCategoryDAO instance;

        public static FDCategoryDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new FDCategoryDAO();
                return instance;
            }

            private set { instance = value; }
        }

        private FDCategoryDAO() { }

        public List<FDCategory> GetFDCategory()
        {
            List<FDCategory> fDList = new List<FDCategory>();

            string query = "SELECT * FROM FDCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                FDCategory category = new FDCategory(item);
                fDList.Add(category);
            }

            return fDList;
        }
    }
}
