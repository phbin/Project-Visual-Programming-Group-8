using QuanLiRapChieuPhim.ChildForms;
using QuanLiRapChieuPhim.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim
{
    public partial class FormAddFD : Form
    {
        public FormAddFD()
        {
            InitializeComponent();
            LoadFD();
            LoadCategory();
            FDDataGridview.BringToFront();
            AddFDButton.BringToFront();
        }
      
        void LoadFD()
        {
            string query = "SELECT ID, NameFD, IDCategory, Price FROM dbo.FoodDrink";
            FDDataGridview.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void LoadCategory()
        {
            string query = "SELECT * FROM dbo.FDCategory";
            CategoryDataGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            CategoryButton.BackColor = Color.FromArgb(32, 90, 167);
            FoodDrinkButton.BackColor = Color.FromArgb(191, 202, 230);
            CategoryDataGridView.BringToFront();
            LoadCategory();
        }

        private void FoodDrinkButton_Click(object sender, EventArgs e)
        {
            FoodDrinkButton.BackColor = Color.FromArgb(32, 90, 167);
            CategoryButton.BackColor = Color.FromArgb(191, 202, 230);
            FDDataGridview.BringToFront();
            AddFDButton.BringToFront();
            LoadFD();
        }

        private byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;

            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);

            return ms.ToArray();
        }

        private void FDDataGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = FDDataGridview.Rows[e.RowIndex];

                if (FDDataGridview.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    if (MessageBox.Show("Do you really want to delete this Food/Drink?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        string query = "DELETE FROM dbo.FoodDrink WHERE ID='" + row.Cells["ID"].Value.ToString() + "'";
                        DataProvider.Instance.ExecuteNonQuery(query);
                        LoadFD();
                    }
                }

                if (FDDataGridview.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    string query = "SELECT Picture FROM dbo.FoodDrink WHERE ID='" + row.Cells["ID"].Value.ToString() + "'";
                    object Path = DataProvider.Instance.ExecuteScalar(query);
                    FormAddEditFD frm = new FormAddEditFD(row.Cells["ID"].Value.ToString(), row.Cells["IDCategory"].Value.ToString(), row.Cells["NameFD"].Value.ToString(), int.Parse(row.Cells["Price"].Value.ToString()), ObjectToByteArray(Path));
                    frm.Owner = this;
                    frm.ShowDialog();
                    LoadFD();
                }
            }
        }

        private void AddFDButton_Click(object sender, EventArgs e)
        {

            FormAddEditFD frm = new FormAddEditFD(FDDataGridview);
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
