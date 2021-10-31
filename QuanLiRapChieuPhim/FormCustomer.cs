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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
            LoadCustomer();
        }

        void LoadCustomer()
        {
            string query = "SELECT * FROM dbo.InfoCustomer";
           
            CustomerGridView.DataSource = DataProvider.Instance.ExcuteQuery(query );
        }

        int numrows = -1;
        private void Searchtxt_Enter(object sender, EventArgs e)
        {
            if (Searchtxt.Text == "Search")
            {
                Searchtxt.ForeColor = Color.White;
                Searchtxt.Text = "";
            }
        }

        private void Searchtxt_Leave(object sender, EventArgs e)
        {
            if (Searchtxt.Text == "")
            {
                Searchtxt.Text = "Search";
                Searchtxt.ForeColor = Color.Silver;
            }
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
