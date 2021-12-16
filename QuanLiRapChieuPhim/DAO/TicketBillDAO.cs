using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using QuanLiRapChieuPhim.DTO;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim.DAO
{
    public class TicketBillDAO
    {
        private static TicketBillDAO instance;

        public static TicketBillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TicketBillDAO();
                return instance;
            }

            private set { instance = value; }
        }

        private TicketBillDAO() { }

        public void InsertTicketBill(int price)
        {
            string query = "INSERT dbo.TicketBill (IDStaff, DateBooking, price) VALUES  ('" + FormLogin.ID_USER + "', GETDATE(), " + price + ")";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public TicketBill GetTicketByID(int id)
        {
            try
            {
                string query = "SELECT * FROM TicketBill WHERE ID = " + id;
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                TicketBill t = new TicketBill(data.Rows[0]);

                return t;
            }
            catch (Exception ex)  //No ticket exists in database
            {
                MessageBox.Show(ex.Message);
                return null;

            }
        }

        public int GetLastIDTicket()
        {
            try
            {
                string query = "SELECT * FROM TicketBill WHERE ID = (SELECT max(ID) FROM TicketBill)";
                int data = (int)DataProvider.Instance.ExecuteScalar(query);
                return data;
            }
            catch   //No ticket exists in database
            {
                return 0;
            }
        }
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
    }
}