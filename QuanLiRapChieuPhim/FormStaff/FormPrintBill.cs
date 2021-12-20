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
using System.Security;
using System.Security.Permissions;
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

        private void FormPrintBill_Load(object sender, EventArgs e)
        {
            BillDAO.Instance.CheckOut(bill.ID);
            BillDAO.Instance.UpdateDateBill(bill.ID);
            printPreviewControl1.Document = printDocument;
            printDocument.DocumentName = "Bill" + bill.ID;
        }


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
            PrintDialog printDlg = new PrintDialog();
            printDlg.Document = printDocument;
            if (printDlg.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float subTotal = bill.Total;
            float tax = subTotal * (float)0.1;
            float total = subTotal + tax;

            Brush b = Brushes.Black;
            Font f = new Font("Arial", 10F);
            int x = 0;
            int y = 120;

            SizeF s1 = e.Graphics.MeasureString(subTotal.ToString() + " VND", f);
            SizeF s2 = e.Graphics.MeasureString(tax.ToString() + " VND", f);
            SizeF s3 = e.Graphics.MeasureString(total.ToString() + " VND", new Font("Arial", 12F, FontStyle.Bold));

            e.Graphics.DrawString("GROUP 8 CINEMA", new Font("Arial", 14F, FontStyle.Bold), b, 20, 0);
            e.Graphics.DrawString("Quarter 6, Linh Trung Ward,", f, b, 25, 20);
            e.Graphics.DrawString("Thu Duc District, HCMC", f, b, 35, 35);
            e.Graphics.DrawString("No. " + bill.ID, f, b, 10, 50);
            e.Graphics.DrawString("Date: " + bill.Date, f, b, 10, 65);
            
            e.Graphics.DrawString("===================================", new Font("Arial", 7F), b, 12, 85);
            e.Graphics.DrawString("FOODDRINK BILL", new Font("Arial", 12F, FontStyle.Bold), b, 35, 100);
            e.Graphics.DrawString("Q.", f, b, 5, 120);
            e.Graphics.DrawString("Name", f, b, 25, 120);
            e.Graphics.DrawString("Total", f, b, 165, 120);
            
            List<FDMenu> menuList = MenuDAO.Instance.GetListMenuByBillID(bill.ID);
            foreach (FDMenu item in menuList) 
            {
                e.Graphics.DrawString(item.Quantity.ToString(), f, b, x + 5, y + 15);
                e.Graphics.DrawString(item.Name, f, b, x + 25, y + 15);
                SizeF s = e.Graphics.MeasureString(item.TotalPrice.ToString(), f);
                e.Graphics.DrawString(item.TotalPrice.ToString(), f, b, 215 - s.Width, y + 15);
                x = 0;
                y = y + 15;
            }
           
            e.Graphics.DrawString("===================================", new Font("Arial", 7F), b, 12, y + 20);
            e.Graphics.DrawString("Sub total:", f, b, 10, y + 35);
            e.Graphics.DrawString(subTotal.ToString() + " VND", f, b, 215 - s1.Width, y + 35);
            e.Graphics.DrawString("Tax:", f, b, 10, y + 50);
            e.Graphics.DrawString(tax.ToString() + " VND", f, b, 215 - s2.Width, y + 50);
            e.Graphics.DrawString("Total:", new Font("Arial", 12F, FontStyle.Bold), b, 10, y + 65);
            e.Graphics.DrawString(total.ToString() + " VND", new Font("Arial", 12F, FontStyle.Bold), b, 215 - (s3.Width + 1), y + 65);
            e.Graphics.DrawString("**THANKS FOR YOUR PURCHASE**", new Font("Arial", 8F), b, 12, y + 85);
        }
    }
}