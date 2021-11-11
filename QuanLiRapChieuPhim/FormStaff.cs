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
            //MessageBox.Show(FormLogin.ID_USER);
        }
        private void LayDSNS()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLiRapChieuPhim;Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM InfoStaff WHERE id ='" + FormLogin.ID_USER + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow rows in dt.Rows)
                    {
                        labelName.Text = rows["FullName"].ToString();
                        ID.Text = rows["id"].ToString();
                        PID.Text = rows["IDPersonal"].ToString();
                        Birthday.Text = rows["DoB"].ToString();
                        Sex.Text = rows["Sex"].ToString();
                        Email.Text = rows["Email"].ToString();
                        Phone.Text = "0" + rows["Phone"].ToString();
                        Address.Text = rows["Addr"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
