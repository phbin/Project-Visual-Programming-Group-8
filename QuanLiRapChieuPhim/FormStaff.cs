using QuanLiRapChieuPhim.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim
{
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
            LayDSNS();
        }
        private void LayDSNS()
        {
            string query = "SELECT * FROM InfoStaff WHERE id ='" + FormLogin.ID_USER + "'";
            DataTable table = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow rows in table.Rows)
            {
                labelName.Text = rows[1].ToString();
                ID.Text = rows[0].ToString();
                PID.Text = rows[7].ToString();
                Birthday.Text = rows[2].ToString();
                Sex.Text = rows[3].ToString();
                Email.Text = rows[6].ToString();
                Phone.Text = rows[5].ToString();
                Address.Text = rows[4].ToString();
            }
        }
    }
}
