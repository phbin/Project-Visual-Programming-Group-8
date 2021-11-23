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
using System.Threading;
using System.IO;

namespace QuanLiRapChieuPhim.ChildForms
{
    public partial class FormAddEditFD : Form
    {
        public FormAddEditFD()
        {
            InitializeComponent();
        }

        string PicturePath = "";

        private Image ConvertBytetoImage(byte[] data )
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }    
        }

        public FormAddEditFD(string ID, string IDCategory, string NameFD, int Price, byte[] Path)
        {
            InitializeComponent();
            IDTextbox.Text = ID;
            IDCategoryTextbox.Text = IDCategory;
            NameFDTextbox.Text = NameFD;
            PriceTextbox.Text = Price.ToString();
            pictureBox1.BackgroundImage = ConvertBytetoImage((byte[])Path);
            IDTextbox.ForeColor = Color.White;
            IDCategoryTextbox.ForeColor = Color.White;
            PriceTextbox.ForeColor = Color.White;
            NameFDTextbox.ForeColor = Color.White;
            //pictureBox1.Image = Image.FromFile(ImagePath);
            EditButton.BringToFront();
        }

        DataGridView DataGridView1 = new DataGridView();

        public FormAddEditFD(DataGridView data)
        {
            InitializeComponent();
            DataGridView1 = data;
            IDTextbox.Text = ""+(int.Parse(DataGridView1.Rows[DataGridView1.Rows.Count - 1 ].Cells["ID"].Value.ToString()) + 1);
            AddButton.BringToFront();
        }

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
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < DataGridView1.Rows.Count; i++)
            {
                if (IDTextbox.Text == DataGridView1.Rows[i].Cells["ID"].Value.ToString())
                {
                    MessageBox.Show("This Food/Drink already exist", "Notification", MessageBoxButtons.OK);
                    IDTextbox.Text = "";
                    IDCategoryTextbox.Text = "";
                    NameFDTextbox.Text = "";
                    PriceTextbox.Text = "";
                    IDTextbox.Focus();
                    return;
                }
            }

            if (IDTextbox.Text != "" && IDCategoryTextbox.Text != "" && NameFDTextbox.Text != "" && PriceTextbox.Text !="")
            {
                string query = "INSERT dbo.FoodDrink (NameFD, IDCategory, Price, Picture) VALUES(N'" + NameFDTextbox.Text + "', '" + IDCategoryTextbox.Text + "', '" + PriceTextbox.Text + "', '" + PicturePath + "')";
                DataProvider.Instance.ExecuteQuery(query);
                IDTextbox.Text = "";
                IDCategoryTextbox.Text = "";
                NameFDTextbox.Text = "";
                PriceTextbox.Text = "";
                pictureBox1.Image = null;
                MessageBox.Show("Added!");
            }
            else
                MessageBox.Show("Please enter full of infomation!", "Notification", MessageBoxButtons.OK);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (IDTextbox.Text != "" && IDCategoryTextbox.Text != "" && NameFDTextbox.Text != "" && PriceTextbox.Text != "")
            {
                PicturePath = pictureBox1.Image.ToString();
                if (MessageBox.Show("Do you really want to change this information?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string query = "UPDATE dbo.FoodDrink SET ID=N'" + IDTextbox.Text + "', IDCategory='" + IDCategoryTextbox.Text + "', NameFD='" + NameFDTextbox.Text + "', Price='" + PriceTextbox.Text + "', Picture='" + convertImagetoByte() + "' WHERE ID='" + IDTextbox.Text + "'";
                    DataProvider.Instance.ExecuteQuery(query);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter full of infomation!", "Notificaiton", MessageBoxButtons.OK);
            }    
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IDTextbox_Enter(object sender, EventArgs e)
        {
            if (IDTextbox.Text == "ID")
            {
                IDTextbox.Text = "";
                IDTextbox.ForeColor = Color.White;
            }
        }

        private void IDTextbox_Leave(object sender, EventArgs e)
        {
            if (IDTextbox.Text == "")
            {
                IDTextbox.Text = "ID";
                IDTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void IDCategoryTextbox_Enter(object sender, EventArgs e)
        {
            if (IDCategoryTextbox.Text == "Category ID")
            {
                IDCategoryTextbox.Text = "";
                IDCategoryTextbox.ForeColor = Color.White;
            }
        }

        private void IDCategoryTextbox_Leave(object sender, EventArgs e)
        {
            if (IDCategoryTextbox.Text == "")
            {
                IDCategoryTextbox.Text = "Category ID";
                IDCategoryTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void NameFDTextbox_Enter(object sender, EventArgs e)
        {
            if (NameFDTextbox.Text == "Name")
            {
                NameFDTextbox.Text = "";
                NameFDTextbox.ForeColor = Color.White;
            }
        }

        private void NameFDTextbox_Leave(object sender, EventArgs e)
        {
            if (NameFDTextbox.Text == "")
            {
                NameFDTextbox.Text = "Name";
                NameFDTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void PriceTextbox_Enter(object sender, EventArgs e)
        {
            if (PriceTextbox.Text == "Price")
            {
                PriceTextbox.Text = "";
                PriceTextbox.ForeColor = Color.White;
            }
        }

        private void PriceTextbox_Leave(object sender, EventArgs e)
        {
            if (PriceTextbox.Text == "")
            {
                PriceTextbox.Text = "Price";
                PriceTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private byte[] convertImagetoByte()
        {
            FileStream fs;
            fs = new FileStream(PicturePath, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
    }
}
