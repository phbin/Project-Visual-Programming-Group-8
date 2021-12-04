using QuanLiRapChieuPhim.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim
{
    public partial class FormStatistic : Form
    {
        public FormStatistic()
        {
            InitializeComponent();
            StatisticLoad();
            DayDatagrid.BringToFront();
            
        }

        void StatisticLoad()
        {
            string query = "SELECT Day(DateBooking) AS 'Day', Month(DateBooking) AS 'Month', Year(DateBooking) AS 'Year', SUM(Total) AS 'Total' FROM dbo.Bill GROUP BY Day(DateBooking), Month(DateBooking), Year(DateBooking) ORDER BY Year(Datebooking) DESC, Month(Datebooking) DESC, Day(DateBooking) DESC";
            DayDatagrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void MonthButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT Month(DateBooking) AS N'Month', Year(DateBooking) AS N'Year', SUM(Total) AS N'Total' FROM dbo.Bill GROUP BY Month(DateBooking), Year(DateBooking) ORDER BY Year(Datebooking) DESC, Month(Datebooking) DESC";
            MonthDatagrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
            MonthDatagrid.BringToFront();
        }

        private void YearButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT Year(DateBooking) AS N'Year', SUM(Total) AS N'Total' FROM dbo.Bill GROUP BY Year(DateBooking) ORDER BY Year(Datebooking) DESC";
            YearDatagrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
            YearDatagrid.BringToFront();
        }

        private void AllButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT Day(DateBooking) AS 'Day', Month(DateBooking) AS 'Month', Year(DateBooking) AS 'Year', SUM(Total) AS 'Total' FROM dbo.Bill GROUP BY Day(DateBooking), Month(DateBooking), Year(DateBooking) ORDER BY Year(Datebooking) DESC, Month(Datebooking) DESC, Day(DateBooking) DESC";
            DayDatagrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
            DayDatagrid.BringToFront();
        }
    }
}
