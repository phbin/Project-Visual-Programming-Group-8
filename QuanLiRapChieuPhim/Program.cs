using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLiRapChieuPhim.DTO;

namespace QuanLiRapChieuPhim
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ShowTime showTime = new ShowTime();
            //Movie movie = new Movie();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormLogin());
            Application.Run(new FormMain());
            //Application.Run(new FormSeat(showTime, movie));
        }
    }
}
