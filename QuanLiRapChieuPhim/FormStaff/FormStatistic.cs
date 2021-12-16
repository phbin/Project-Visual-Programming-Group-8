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
            DayStatisticLoad();
        }

        void DayStatisticLoad()
        {
            dtg.DataSource = null;
            string query = "SELECT Day(DateBooking) AS 'Day', Month(DateBooking) AS 'Month', Year(DateBooking) AS 'Year', SUM(Total) AS 'Total' FROM dbo.Bill GROUP BY Day(DateBooking), Month(DateBooking), Year(DateBooking) ORDER BY Year(Datebooking) DESC, Month(Datebooking) DESC, Day(DateBooking) DESC";
            dtg.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void MonthButton_Click(object sender, EventArgs e)
        {
            dtg.DataSource = null;
            string query = "SELECT Month(DateBooking) AS N'Month', Year(DateBooking) AS N'Year', SUM(Total) AS N'Total' FROM dbo.Bill GROUP BY Month(DateBooking), Year(DateBooking) ORDER BY Year(Datebooking) DESC, Month(Datebooking) DESC";
            dtg.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void YearButton_Click(object sender, EventArgs e)
        {
            dtg.DataSource = null;
            string query = "SELECT Year(DateBooking) AS N'Year', SUM(Total) AS N'Total' FROM dbo.Bill GROUP BY Year(DateBooking) ORDER BY Year(Datebooking) DESC";
            dtg.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void AllButton_Click(object sender, EventArgs e)
        {
            DayStatisticLoad();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string selectedPath = "";
            var t = new Thread((ThreadStart)(() => {
                SaveFileDialog saveDlg = new SaveFileDialog();
                saveDlg.Title = "Export Excel";
                saveDlg.Filter = "Excel (*.xlsx)|*.xlsx|Excel 97 - 2003 (*.xls)|*.xls";
                if (saveDlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ExportExcel(saveDlg.FileName);
                        MessageBox.Show("Successful!");
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
            if (dtg.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 0; i < dtg.Columns.Count; i++)
                    xcelApp.Cells[1, i + 1] = dtg.Columns[i].HeaderText;

                for (int i = 0; i < dtg.Rows.Count; i++)
                    for (int j = 0; j < dtg.Columns.Count; j++)
                        xcelApp.Cells[i + 2, j + 1] = dtg.Rows[i].Cells[j].Value.ToString();

                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
                xcelApp.ActiveWorkbook.SaveCopyAs(path);
                xcelApp.ActiveWorkbook.Saved = true;
            }
        }
    }
}
