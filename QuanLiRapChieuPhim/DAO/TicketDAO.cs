using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using QuanLiRapChieuPhim.DTO;

namespace QuanLiRapChieuPhim.DAO
{
    public class TicketDAO
    {
<<<<<<< Updated upstream
        //public static List<Ticket> GetListTicketsByShowTimes(string showTime)
        //{
        //    //List<Ticket> listTicket = new List<Ticket>();
        //    //string query = "select * from Ticket where IDShowTime = '" + showTime + "'";
        //    //DataTable data = DataProvider.ExecuteQuery(query);
        //    //foreach (DataRow row in data.Rows)
        //    //{
        //    //    Ticket ticket = new Ticket(row);
        //    //    listTicket.Add(ticket);
        //    //}
        //    //return listTicket;
        //}

        //public static int BuyTicket(string ticketID, int type, float price)
        //{
        //    string query = "Update dbo.Ticket set stt = 1, TicketType = "
        //        + type + ", TicketPrice =" + price + " where ID = '" + ticketID + "'";
        //    return DataProvider.ExecuteNonQuery(query);
        //}

        //public static int BuyTicket(string ticketID, int type, string customerID, float price)
        //{
        //    string query = "Update dbo.Ticket set stt = 1, LoaiVe = " + type
        //       + ", IDCustomer = '" + customerID + "', TicKetPrice =" + price + " where ID = '" + ticketID + "'";
        //    return DataProvider.ExecuteNonQuery(query);
        //}
=======
        public static List<Ticket> GetListTicketsByShowTimes(string showTime)
        {
            List<Ticket> listTicket = new List<Ticket>();
            string query = "select * from Ticket where IDShowTime = '" + showTime + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Ticket ticket = new Ticket(row);
                listTicket.Add(ticket);
            }
            return listTicket;
        }

        public static int BuyTicket(string ticketID, int type, float price)
        {
            string query = "Update dbo.Ticket set stt = 1, TicketType = "
                + type + ", TicketPrice =" + price + " where ID = '" + ticketID + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static int BuyTicket(string ticketID, int type, string customerID, float price)
        {
            string query = "Update dbo.Ticket set stt = 1, LoaiVe = " + type
               + ", IDCustomer = '" + customerID + "', TicKetPrice =" + price + " where ID = '" + ticketID + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
>>>>>>> Stashed changes
    }
}