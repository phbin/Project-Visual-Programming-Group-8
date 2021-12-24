using QuanLiRapChieuPhim.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim
{
    public partial class FormStatistic : Form
    {
        public FormStatistic()
        {
            InitializeComponent();
            selection = 0;
            StatisticLoad();
            FDButton.BringToFront();
        }

        public FormStatistic(string ID)
        {
            InitializeComponent();
            IDStaff = ID;
            selection = 0; 
            StatisticLoad(ID);
            FDButton.BringToFront();
        }

        string IDStaff = "";
        int selection = 0;

        void StatisticLoad()
        {
            Datagrid.DataSource = null;
            if (selection == 0)
            {
                string query = "SELECT Day(DateBooking) AS 'Day', Month(DateBooking) AS 'Month', Year(DateBooking) AS 'Year', SUM(Price) AS 'Total' FROM dbo.TicketBill GROUP BY Day(DateBooking), Month(DateBooking), Year(DateBooking) ORDER BY Year(Datebooking) DESC, Month(Datebooking) DESC, Day(DateBooking) DESC";
                Datagrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            else
            {
                string query = "SELECT Day(DateBooking) AS 'Day', Month(DateBooking) AS 'Month', Year(DateBooking) AS 'Year', SUM(Total) AS 'Total' FROM dbo.Bill GROUP BY Day(DateBooking), Month(DateBooking), Year(DateBooking) ORDER BY Year(Datebooking) DESC, Month(Datebooking) DESC, Day(DateBooking) DESC";
                Datagrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }    
        }

        private void MonthButton_Click(object sender, EventArgs e)
        {
            YearButton.BackColor = Color.FromArgb(191, 202, 230);
            MonthButton.BackColor = Color.FromArgb(32, 90, 167);
            AllButton.BackColor = Color.FromArgb(191, 202, 230);
            Datagrid.DataSource = null;
            if (IDStaff == "")
            {
                if (selection == 0)
                {
                    string query = "SELECT Month(DateBooking) AS N'Month', Year(DateBooking) AS N'Year', SUM(Price) AS N'Total' FROM dbo.TicketBill GROUP BY Month(DateBooking), Year(DateBooking) ORDER BY Year(Datebooking) DESC, Month(Datebooking) DESC";
                    Datagrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
                    Datagrid.Columns["Total"].DefaultCellStyle.Format = "0,#";
                }
                else
                {
                    string query = "SELECT Month(DateBooking) AS N'Month', Year(DateBooking) AS N'Year', SUM(Total) AS N'Total' FROM dbo.Bill GROUP BY Month(DateBooking), Year(DateBooking) ORDER BY Year(Datebooking) DESC, Month(Datebooking) DESC";
                    Datagrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
                    Datagrid.Columns["Total"].DefaultCellStyle.Format = "0,#";
                }
            }
            else
            {
                if (selection == 0)
                {
                    string query = "SELECT Month(DateBooking) AS N'Month', Year(DateBooking) AS N'Year', SUM(Price) AS N'Total' FROM dbo.TicketBill WHERE IDStaff = '" + IDStaff + "' GROUP BY Month(DateBooking), Year(DateBooking) ORDER BY Year(Datebooking) DESC, Month(Datebooking) DESC";
                    Datagrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
                    Datagrid.Columns["Total"].DefaultCellStyle.Format = "0,#";
                }
                else
                {
                    string query = "SELECT Month(DateBooking) AS N'Month', Year(DateBooking) AS N'Year', SUM(Total) AS N'Total' FROM dbo.Bill WHERE IDStaff = '" + IDStaff + "' GROUP BY Month(DateBooking), Year(DateBooking) ORDER BY Year(Datebooking) DESC, Month(Datebooking) DESC";
                    Datagrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
                    Datagrid.Columns["Total"].DefaultCellStyle.Format = "0,#";
                }
            }    
        }

        private void YearButton_Click(object sender, EventArgs e)
        {
            YearButton.BackColor = Color.FromArgb(32, 90, 167);
            MonthButton.BackColor = Color.FromArgb(191, 202, 230);
            AllButton.BackColor = Color.FromArgb(191, 202, 230);
            Datagrid.DataSource = null;
            if (IDStaff == "")
            {
                if (selection == 0)
                {
                    string query = "SELECT Year(DateBooking) AS N'Year', SUM(Price) AS N'Total' FROM dbo.TicketBill GROUP BY Year(DateBooking) ORDER BY Year(Datebooking) DESC";
                    Datagrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
                    Datagrid.Columns["Total"].DefaultCellStyle.Format = "0,#";
                }
                else
                {
                    string query = "SELECT Year(DateBooking) AS N'Year', SUM(Total) AS N'Total' FROM dbo.Bill GROUP BY Year(DateBooking) ORDER BY Year(Datebooking) DESC";
                    Datagrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
                    Datagrid.Columns["Total"].DefaultCellStyle.Format = "0,#";
                }
            }
            else
            {
                if (selection == 0)
                {
                    string query = "SELECT Year(DateBooking) AS N'Year', SUM(Price) AS N'Total' FROM dbo.TicketBill WHERE IDStaff = '" + IDStaff + "' GROUP BY Year(DateBooking) ORDER BY Year(Datebooking) DESC";
                    Datagrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
                    Datagrid.Columns["Total"].DefaultCellStyle.Format = "0,#";
                }
                else
                {
                    string query = "SELECT Year(DateBooking) AS N'Year', SUM(Total) AS N'Total' FROM dbo.Bill WHERE IDStaff = '" + IDStaff + "' GROUP BY Year(DateBooking) ORDER BY Year(Datebooking) DESC";
                    Datagrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
                    Datagrid.Columns["Total"].DefaultCellStyle.Format = "0,#";
                }
            }    
        }

        private void AllButton_Click(object sender, EventArgs e)
        {
            AllButton.BackColor = Color.FromArgb(32, 90, 167);
            MonthButton.BackColor = Color.FromArgb(191, 202, 230);
            YearButton.BackColor = Color.FromArgb(191, 202, 230);
            Datagrid.DataSource = null;
            if (IDStaff == "")
            {
                if (selection == 0)
                {
                    string query = "SELECT Day(DateBooking) AS 'Day', Month(DateBooking) AS 'Month', Year(DateBooking) AS 'Year', SUM(Price) AS 'Total' FROM dbo.TicketBill GROUP BY Day(DateBooking), Month(DateBooking), Year(DateBooking) ORDER BY Year(Datebooking) DESC, Month(Datebooking) DESC, Day(DateBooking) DESC";
                    Datagrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
                    Datagrid.Columns["Total"].DefaultCellStyle.Format = "0,#";
                }
                else
                {
                    string query = "SELECT Day(DateBooking) AS 'Day', Month(DateBooking) AS 'Month', Year(DateBooking) AS 'Year', SUM(Total) AS 'Total' FROM dbo.Bill GROUP BY Day(DateBooking), Month(DateBooking), Year(DateBooking) ORDER BY Year(Datebooking) DESC, Month(Datebooking) DESC, Day(DateBooking) DESC";
                    Datagrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
                    Datagrid.Columns["Total"].DefaultCellStyle.Format = "0,#";
                }
            }
            else
            {

                if (selection == 0)
                {
                    string query = "SELECT Day(DateBooking) AS 'Day', Month(DateBooking) AS 'Month', Year(DateBooking) AS 'Year', SUM(Price) AS 'Total' FROM dbo.TicketBill WHERE IDStaff = '" + IDStaff + "' GROUP BY Day(DateBooking), Month(DateBooking), Year(DateBooking) ORDER BY Year(Datebooking) DESC, Month(Datebooking) DESC, Day(DateBooking) DESC";
                    Datagrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
                    Datagrid.Columns["Total"].DefaultCellStyle.Format = "0,#";
                }
                else
                {
                    string query = "SELECT Day(DateBooking) AS 'Day', Month(DateBooking) AS 'Month', Year(DateBooking) AS 'Year', SUM(Total) AS 'Total' FROM dbo.Bill WHERE IDStaff = '" + IDStaff + "' GROUP BY Day(DateBooking), Month(DateBooking), Year(DateBooking) ORDER BY Year(Datebooking) DESC, Month(Datebooking) DESC, Day(DateBooking) DESC";
                    Datagrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
                    Datagrid.Columns["Total"].DefaultCellStyle.Format = "0,#";
                }
            }    
        }

        private void TicketButton_Click(object sender, EventArgs e)
        {
            if(IDStaff == "")
            {
                selection = 0;
                StatisticLoad();
                FDButton.BringToFront();
            }  
            else
            {
                selection = 0;
                StatisticLoad(IDStaff);
                FDButton.BringToFront();
            }    
            
        }

        private void FDButton_Click(object sender, EventArgs e)
        {
            if (IDStaff == "")
            {
                selection = 1;
                StatisticLoad();
                TicketButton.BringToFront();
            }
            else
            {
                selection = 1;
                StatisticLoad(IDStaff);
                TicketButton.BringToFront();
            }    
        }

        void StatisticLoad(string Staff_ID)
        {
            Datagrid.DataSource = null;
            if (selection == 0)
            {
                string query = "SELECT Day(DateBooking) AS 'Day', Month(DateBooking) AS 'Month', Year(DateBooking) AS 'Year', SUM(Price) AS 'Total' FROM dbo.TicketBill WHERE IDStaff = '" + Staff_ID + "' GROUP BY Day(DateBooking), Month(DateBooking), Year(DateBooking) ORDER BY Year(Datebooking) DESC, Month(Datebooking) DESC, Day(DateBooking) DESC";
                Datagrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
                Datagrid.Columns["Total"].DefaultCellStyle.Format = "0,#";
            }
            else
            {
                string query = "SELECT Day(DateBooking) AS 'Day', Month(DateBooking) AS 'Month', Year(DateBooking) AS 'Year', SUM(Total) AS 'Total' FROM dbo.Bill WHERE IDStaff = '" + Staff_ID + "' GROUP BY Day(DateBooking), Month(DateBooking), Year(DateBooking) ORDER BY Year(Datebooking) DESC, Month(Datebooking) DESC, Day(DateBooking) DESC";
                Datagrid.DataSource = DataProvider.Instance.ExecuteQuery(query);
                Datagrid.Columns["Total"].DefaultCellStyle.Format = "0,#";
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string selectedPath = "";
            var t = new Thread((ThreadStart)(() =>
            {
                SaveFileDialog saveDlg = new SaveFileDialog();
                saveDlg.Title = "Export Excel";
                saveDlg.Filter = "Excel (*.xlsx)|*.xlsx|Excel 97 - 2003 (*.xls)|*.xls";
                if (saveDlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ExportExcel(saveDlg.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unsuccessful!\n" + ex.Message);
                    }
                }

                selectedPath = saveDlg.FileName;
            }));

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            Console.WriteLine(selectedPath);
        }

        void ExportExcel(string path)
        {
            if (Datagrid.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 0; i < Datagrid.Columns.Count; i++)
                    xcelApp.Cells[1, i + 1] = Datagrid.Columns[i].HeaderText;

                for (int i = 0; i < Datagrid.Rows.Count; i++)
                    for (int j = 0; j < Datagrid.Columns.Count; j++)
                        xcelApp.Cells[i + 2, j + 1] = Datagrid.Rows[i].Cells[j].Value.ToString();

                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
                xcelApp.ActiveWorkbook.SaveCopyAs(path);
                xcelApp.ActiveWorkbook.Saved = true;
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            string selectedPath = "";
            var t = new Thread((ThreadStart)(() =>
            {
                SaveFileDialog saveDlg = new SaveFileDialog();
                saveDlg.Title = "Export Excel";
                saveDlg.Filter = "Excel (*.xlsx)|*.xlsx|Excel 97 - 2003 (*.xls)|*.xls";
                if (saveDlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ExportExcel(saveDlg.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unsuccessful!\n" + ex.Message);
                    }
                }

                selectedPath = saveDlg.FileName;
            }));

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            Console.WriteLine(selectedPath);
        }
    }
}
