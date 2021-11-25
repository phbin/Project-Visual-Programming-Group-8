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
            FDDataGridview.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        void LoadCategory()
        {
            string query = "SELECT * FROM dbo.FDCategory";
            CategoryDataGridView.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            CategoryDataGridView.BringToFront();
            AddCategoryButton.BringToFront();
            LoadCategory();
        }

        private void FoodDrinkButton_Click(object sender, EventArgs e)
        {
            FDDataGridview.BringToFront();
            AddFDButton.BringToFront();
            LoadFD();
        }

        private void AddFDButton_Click(object sender, EventArgs e)
        {
            FormAddEditFD frm = new FormAddEditFD(FDDataGridview);
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            FormAddEditCategory frm = new FormAddEditCategory(CategoryDataGridView);
            frm.Owner = this;
            frm.ShowDialog();
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
                        string query = "DELETE FROM dbo.FoodDrink WHERE ID='"+ row.Cells["ID"].Value.ToString() +"'";
                        DataProvider.Instance.ExcuteNonQuery(query);
                        LoadFD();
                    }
                }

                if (FDDataGridview.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    string query = "SELECT Picture FROM dbo.FoodDrink WHERE ID='"+row.Cells["ID"].Value.ToString()+"'";
                    object Path = DataProvider.Instance.ExcuteScalar(query);
                    FormAddEditFD frm = new FormAddEditFD(row.Cells["ID"].Value.ToString(), row.Cells["IDCategory"].Value.ToString(), row.Cells["NameFD"].Value.ToString(), int.Parse(row.Cells["Price"].Value.ToString()), ObjectToByteArray(Path));
                    frm.Owner = this;
                    frm.ShowDialog();
                    LoadFD();
                }
            }
        }

        private void CategoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CategoryDataGridView.Rows[e.RowIndex];

                if (FDDataGridview.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    if (MessageBox.Show("Do you really want to delete this Category?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        string query = "DELETE FROM dbo.FDCategory WHERE ID='" + row.Cells["CategoryID"].Value.ToString() + "'";
                        DataProvider.Instance.ExcuteNonQuery(query);
                        LoadCategory();
                    }
                }

                if (FDDataGridview.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    FormAddEditCategory frm = new FormAddEditCategory(row.Cells["CategoryID"].Value.ToString(), row.Cells["CategoryName"].Value.ToString());
                    frm.Owner = this;
                    frm.ShowDialog();
                    LoadCategory();
                }
            }
        }
    }
}
