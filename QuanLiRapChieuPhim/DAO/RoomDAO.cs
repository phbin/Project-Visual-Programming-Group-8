using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiRapChieuPhim.DTO;
using System.Data;

namespace QuanLiRapChieuPhim.DAO
{
    public class RoomDAO
    {
<<<<<<< Updated upstream
        //public static Room GetCinemaByName(string nameRoom)
        //{
        //    //string query = "select * from dbo.Room where NameRoom = '" + nameRoom + "'";
        //    //DataTable data = DataProvider.ExecuteQuery(query);
        //    //if (data.Rows.Count > 0)
        //    //{
        //    //    return new Room(data.Rows[0]);
        //    //}
        //    //else
        //    //{
        //    //    return null;
        //    //}
        //}
=======
        public static Room GetCinemaByName(string nameRoom)
        {
            string query = "select * from dbo.Room where NameRoom = '" + nameRoom + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                return new Room(data.Rows[0]);
            }
            else
            {
                return null;
            }
        }
>>>>>>> Stashed changes
    }
}