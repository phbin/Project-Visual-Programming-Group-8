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
    
        string PicturePath = "";

        private byte[] pic;
        int CreateID()
        {
            int idf=0;
            string query = "select * from FoodDrink";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            int j = 0;
            for (int i = 1; i <= table.Rows.Count + 1; i++)
            {
                idf =  i;
                while (j < table.Rows.Count)
                {
                    DataRow rows = table.Rows[j];
                    if ((int)rows["ID"] != idf) return idf;
                    else
                    {
                        j++;
                        break;
                    }
                }

            }
            return idf;
        }
        public FormAddEditFD(string ID, string IDCategory, string NameFD, int Price, byte[] Path)
        {
            InitializeComponent();
            IDTextbox.Text = ID;
            LoadCategoryIntoComboBox(cbCategory);
            string query = "select * from FDCategory where ID='" + ID + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow rows in table.Rows)
            {
                cbCategory.Text = rows["NameCategory"].ToString();
            }
            query = "SELECT NameCategory FROM dbo.FDCategory where id ='" + IDCategory + "'";
            table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow rows in table.Rows)
            {
                cbCategory.Text = rows["NameCategory"].ToString();

            }
            NameFDTextbox.Text = NameFD;
            PriceTextbox.Text = Price.ToString();
            //load image
            query = "SELECT Picture FROM dbo.FoodDrink where id ='" + ID + "'";
            table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow rows in table.Rows)
            {
                pic = (byte[])rows["Picture"];

            }
            pictureBox1.BackgroundImage = FoodDrinkDAO.byteArrayToImage(pic);
            IDTextbox.ForeColor = Color.White;
            PriceTextbox.ForeColor = Color.White;
            NameFDTextbox.ForeColor = Color.White;
            EditButton.BringToFront();
        }
        void LoadCategoryIntoComboBox(ComboBox cbb)
        {
            DataTable tb = DataProvider.Instance.ExecuteQuery("Select * from dbo.FDCategory");
            cbb.DataSource = tb;
            cbb.DisplayMember = "NameCategory";
        }
        private int GetID(string name)
        {
            int idc = 0;
            string query = "SELECT ID FROM dbo.FDCategory where NameCategory = N'" + name + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow rows in table.Rows)
            {
                idc = (int)rows["ID"];
            }
            return idc;
        }
        DataGridView DataGridView1 = new DataGridView();

        public FormAddEditFD(DataGridView data)
        {
            InitializeComponent();
            LoadCategoryIntoComboBox(cbCategory);
            DataGridView1 = data;
            IDTextbox.Text = CreateID().ToString();
            IDTextbox.ForeColor = Color.FromArgb(190, 62, 66);
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
            int count = 0;

            if (cbCategory.Text == null)
            {
                errorProvider1.SetError(cbCategory, "Please enter Category ID");
                count++;
            }
            else
            {
                errorProvider1.SetError(cbCategory, null);
            }

            if (NameFDTextbox.Text == "Name" || NameFDTextbox.Text == "")
            {
                errorProvider1.SetError(NameFDTextbox, "Please enter Name");
                count++;
            }
            else
            {
                errorProvider1.SetError(NameFDTextbox, null);
            }

            if (PriceTextbox.Text == "Price" || PriceTextbox.Text == "")
            {
                errorProvider1.SetError(PriceTextbox, "Please enter Price");
                count++;
            }
            else
            {
                errorProvider1.SetError(PriceTextbox, null);
            }

            for (int i = 0; i < DataGridView1.Rows.Count; i++)
            {
                if (IDTextbox.Text == DataGridView1.Rows[i].Cells["ID"].Value.ToString())
                {
                    MessageBox.Show("This Food/Drink has already existed", "Notification", MessageBoxButtons.OK);
                    IDTextbox.Text = CreateID().ToString();
                    cbCategory.Text = "";
                    NameFDTextbox.Text = "Name";
                    PriceTextbox.Text = "Price";
                    NameFDTextbox.ForeColor = Color.FromArgb(190, 62, 66);
                    PriceTextbox.ForeColor = Color.FromArgb(190, 62, 66);
                    IDTextbox.ForeColor = Color.FromArgb(190, 62, 66);
                    IDTextbox.Focus();
                    return;
                }
            }
            
            if (count==0)
            {
                if (PicturePath == "")
                {
                    MessageBox.Show("Please upload a picture!");
                    return;
                }
                string query = "INSERT dbo.FoodDrink (id, NameFD, IDCategory, Price) VALUES(N'"+IDTextbox.Text+"', N'" + NameFDTextbox.Text + "', '" +GetID(cbCategory.Text) + "', '" + PriceTextbox.Text + "')";
                DataProvider.Instance.ExecuteQuery(query);
                FoodDrinkDAO.Instance.imageToByteArray(PicturePath, GetID(cbCategory.Text), NameFDTextbox.Text, Convert.ToInt32(PriceTextbox.Text));
                IDTextbox.Text = CreateID().ToString();
                cbCategory.Text = "";
                NameFDTextbox.Text = "Name";
                PriceTextbox.Text = "Price";
                NameFDTextbox.ForeColor = Color.FromArgb(190, 62, 66);
                PriceTextbox.ForeColor = Color.FromArgb(190, 62, 66);
                pictureBox1.BackgroundImage = null;
                MessageBox.Show("Added!");
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (cbCategory.Text == null)
            {
                errorProvider1.SetError(cbCategory, "Please enter Category ID");
                count++;
            }
            else
            {
                errorProvider1.SetError(cbCategory, null);
            }

            if (NameFDTextbox.Text == "Name" || NameFDTextbox.Text == "")
            {
                errorProvider1.SetError(NameFDTextbox, "Please enter Name");
                count++;
            }
            else
            {
                errorProvider1.SetError(NameFDTextbox, null);
            }

            if (PriceTextbox.Text == "Price" || PriceTextbox.Text == "")
            {
                errorProvider1.SetError(PriceTextbox, "Please enter Price");
                count++;
            }
            else
            {
                errorProvider1.SetError(PriceTextbox, null);
            }

            if (count==0)
            {
                if (PicturePath == "")
                {
                    MessageBox.Show("Please upload a picture!");
                    return;
                }
                //PicturePath = pictureBox1.Image.ToString();
                if (MessageBox.Show("Do you really want to change this information?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string query = "UPDATE dbo.FoodDrink SET ID=N'" + IDTextbox.Text + "', IDCategory='" + GetID(cbCategory.Text) + "', NameFD='" + NameFDTextbox.Text + "', Price='" + PriceTextbox.Text  + "' WHERE ID='" + IDTextbox.Text + "'";
                    DataProvider.Instance.ExecuteQuery(query);
                    FoodDrinkDAO.Instance.imageToByteArray(PicturePath,GetID(cbCategory.Text), NameFDTextbox.Text, Convert.ToInt32(PriceTextbox.Text));
                    this.Close();
                    MessageBox.Show("Food/Drink Added!", "Notification", MessageBoxButtons.OK);
                }
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
    }
}
