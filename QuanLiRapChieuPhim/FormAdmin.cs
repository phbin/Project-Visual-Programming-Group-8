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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            LoadAccountList();
        }

        void LoadAccountList()
        {
            string query = "SELECT * FROM dbo.Account";

            ListAccountGrid.DataSource = DataProvider.Instance.ExcuteQuery(query,new object[] { "admin" });
        }
    }
}
