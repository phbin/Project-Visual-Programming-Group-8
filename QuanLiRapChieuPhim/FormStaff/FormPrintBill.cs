using Microsoft.Reporting.WinForms;
using QuanLiRapChieuPhim.DAO;
using QuanLiRapChieuPhim.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim
{
    public partial class FormPrintBill : Form
    {
        Bill bill;
        public FormPrintBill(int id)
        {
            InitializeComponent();
            bill = BillDAO.Instance.GetBillByID(id);
        }
        #region Method
        private void FormPrintBill_Load(object sender, EventArgs e)
        {
            //DataSource
            string query = "SELECT FD.NameFD AS Name, BI.Num AS Quantity, FD.Price, FD.Price*BI.Num AS TotalPrice FROM BillInfo BI, FoodDrink FD WHERE BI.IDFoodDrink = FD.ID AND BI.IDBill = " + bill.ID;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("dsMenu", data));

            //Parameters
            float subTotal = bill.Total;
            float tax = subTotal * (float)0.1;
            float total = subTotal + tax;

            BillDAO.Instance.UpdateDateBill(bill.ID);

            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("rpID", bill.ID.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("rpDate", bill.Date),
                new Microsoft.Reporting.WinForms.ReportParameter("rpSubTotal", subTotal.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("rpTax", tax.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("rpTotal", total.ToString())
            };

            //Add
            this.reportViewer.LocalReport.SetParameters(para);

            this.reportViewer.RefreshReport();
        }
     
        //public static void PrintToPrinter(LocalReport report)
        //{
        //    PageSettings pageSettings = new PageSettings();
        //    pageSettings.PaperSize = report.GetDefaultPageSettings().PaperSize;
        //    pageSettings.Landscape = report.GetDefaultPageSettings().IsLandscape;
        //    pageSettings.Margins = report.GetDefaultPageSettings().Margins;
        //    Print(report, pageSettings);
        //}

        //public static void Print(LocalReport report, PageSettings pageSettings)
        //{
        //    string deviceInfo =
        //        $@"<DeviceInfo>
        //            <OutputFormat>EMF</OutputFormat>
        //            <PageWidth>{pageSettings.PaperSize.Width * 100}in</PageWidth>
        //            <PageHeight>{pageSettings.PaperSize.Height * 100}in</PageHeight>
        //            <MarginTop>{pageSettings.Margins.Top * 100}in</MarginTop>
        //            <MarginLeft>{pageSettings.Margins.Left * 100}in</MarginLeft>
        //            <MarginRight>{pageSettings.Margins.Right * 100}in</MarginRight>
        //            <MarginBottom>{pageSettings.Margins.Bottom * 100}in</MarginBottom>
        //        </DeviceInfo>";
        //    Warning[] warnings;
        //    var streams = new List<Stream>();
        //    var pageIndex = 0;
        //    report.Render("Image", deviceInfo,
        //        (name, fileNameExtension, encoding, mimeType, willSeek) =>
        //        {
        //            MemoryStream stream = new MemoryStream();
        //            streams.Add(stream);
        //            return stream;
        //        }, out warnings);
        //    foreach (Stream stream in streams)
        //        stream.Position = 0;
        //    if (streams == null || streams.Count == 0)
        //        throw new Exception("No stream to print.");
        //    using (PrintDocument printDocument = new PrintDocument())
        //    {
        //        printDocument.DefaultPageSettings = pageSettings;
        //        if (!printDocument.PrinterSettings.IsValid)
        //            throw new Exception("Can't find the default printer.");
        //        else
        //        {
        //            printDocument.PrintPage += (sender, e) =>
        //            {
        //                Metafile pageImage = new Metafile(streams[pageIndex]);
        //                Rectangle adjustedRect = new Rectangle(e.PageBounds.Left - (int)e.PageSettings.HardMarginX, e.PageBounds.Top - (int)e.PageSettings.HardMarginY, e.PageBounds.Width, e.PageBounds.Height);
        //                e.Graphics.FillRectangle(Brushes.White, adjustedRect);
        //                e.Graphics.DrawImage(pageImage, adjustedRect);
        //                pageIndex++;
        //                e.HasMorePages = (pageIndex < streams.Count);
        //                e.Graphics.DrawRectangle(Pens.Red, adjustedRect);
        //            };
        //            printDocument.EndPrint += (Sender, e) =>
        //            {
        //                if (streams != null)
        //                {
        //                    foreach (Stream stream in streams)
        //                        stream.Close();
        //                    streams = null;
        //                }
        //            };
        //            printDocument.Print();
        //        }
        //    }
        //}
        #endregion

        #region Events
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //PrintDialog printDlg = new PrintDialog();
            //if (printDlg.ShowDialog() == DialogResult.OK)
            //{
            //    LocalReport localReport = new LocalReport();
            //    localReport.ReportPath = Application.StartupPath + "\\Report1.rdlc";
            //    PrintToPrinter(localReport);
            //}

            BillDAO.Instance.CheckOut(bill.ID);
        }
        #endregion
    }
}