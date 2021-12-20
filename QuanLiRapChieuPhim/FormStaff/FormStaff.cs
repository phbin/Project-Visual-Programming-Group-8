using QuanLiRapChieuPhim.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim
{
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
            LoadInfo();
        }
        // image -> byte, insert image into database
        public void imageToByteArray(string path, string id)
        {
            string query = "update InfoStaff set Avatar = (select * from openrowset(bulk N'" + path + "', single_blob) as img) where ID = '" + id + "'";
            DataProvider.Instance.ExecuteQuery(query);
        }
        // byte[] -> image, get image from database
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void LoadInfo()
        {
            string query = "SELECT * FROM InfoStaff WHERE id ='" + FormLogin.ID_USER + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow rows in table.Rows)
            {
                labelName.Text = rows[1].ToString();
                lbID.Text = rows[0].ToString();
                txtPID.Text = rows["IDPersonal"].ToString();
                txtSex.Text = rows[3].ToString();
                txtEmail.Text = rows[6].ToString();
                txtPhone.Text = rows[5].ToString();
                txtAddr.Text = rows[4].ToString();
                byte[]pic = (byte[])rows["Avatar"];
                pictureBox1.BackgroundImage = byteArrayToImage(pic);
            }
            query = "SELECT format(DoB,'dd/MM/yyyy') as DOB FROM InfoStaff WHERE id ='" + FormLogin.ID_USER + "'";
            table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow rows in table.Rows)
            {
                txtDOB.Text = rows["DOB"].ToString();
            }
        }
        string PicturePath = "";
        private void UploadButton_Click(object sender, EventArgs e)
        {
            Thread t = new Thread((ThreadStart)(() => {
                OpenFileDialog openfiledialog = new OpenFileDialog();

                openfiledialog.Filter = "Image files | *.png; *.jpg";
                openfiledialog.FilterIndex = 1;
                openfiledialog.RestoreDirectory = true;

                if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    PicturePath = openfiledialog.FileName;
                    pictureBox1.BackgroundImage = Image.FromFile(PicturePath);
                }
            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            imageToByteArray(PicturePath, lbID.Text);
        }
    }
}
