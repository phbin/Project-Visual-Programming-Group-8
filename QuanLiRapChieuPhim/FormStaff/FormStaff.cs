using QuanLiRapChieuPhim.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
<<<<<<< Updated upstream
=======
using System.IO;
>>>>>>> Stashed changes
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim
{
    public partial class FormStaff : Form
    {
<<<<<<< Updated upstream
=======
        string str;

>>>>>>> Stashed changes
        public FormStaff()
        {
            InitializeComponent();
            LayDSNS();
        }
        private void LayDSNS()
        {
            string query = "SELECT * FROM InfoStaff WHERE id ='" + FormLogin.ID_USER + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow rows in table.Rows)
            {
                labelName.Text = rows[1].ToString();
                lbID.Text = rows[0].ToString();
                txtPID.Text = rows[7].ToString();
                txtDOB.Text = rows[2].ToString();
                txtSex.Text = rows[3].ToString();
                txtEmail.Text = rows[6].ToString();
                txtPhoneNum.Text = rows[5].ToString();
                txtAddr.Text = rows[4].ToString();
<<<<<<< Updated upstream
            }
        }

=======
                MemoryStream ms = new MemoryStream((byte[])rows[8]);
                pictureBoxAvatar.Image = new Bitmap(ms);
            }
        }

        private void pictureBoxAvatar_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Pictures files|*.jpg; *.jpeg; *.png|All files|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                str = dlg.FileName;
                pictureBoxAvatar.Image = Image.FromFile(str);
                string query = "UPDATE dbo.InfoStaff SET Avatar='" + ConvertImgToByte() + "'";
                DataProvider.Instance.ExecuteQuery(query);
            }
        }

        private byte[] ConvertImgToByte()
        {
            FileStream fs;
            fs = new FileStream(str, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
>>>>>>> Stashed changes
    }
}
