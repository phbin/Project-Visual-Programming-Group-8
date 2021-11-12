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
    public partial class FormStaffInfo : Form
    {
        public FormStaffInfo()
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
                lbID.Text = rows[0].ToString();
                txtPID.Text = rows[7].ToString();
                txtDOB.Text = rows[2].ToString();
                txtSex.Text = rows[3].ToString();
                txtEmail.Text = rows[6].ToString();
                txtPhoneNum.Text = rows[5].ToString();
                txtAddr.Text = rows[4].ToString();
            }
        }

        private void pictureBoxAddr_Click(object sender, EventArgs e)
        {

        }
    }
}
