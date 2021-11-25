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

namespace QuanLiRapChieuPhim.ChildForms
{
    public partial class FormAddEditCategory : Form
    {
        public FormAddEditCategory()
        {
            InitializeComponent();
        }

        public FormAddEditCategory(string ID, string Name)
        {
            InitializeComponent();
            IDTextbox.Text = ID;
            CategoryNameTextbox.Text = Name;
            EditButton.BringToFront();
        }

        DataGridView DataGridView1 = new DataGridView();

        public FormAddEditCategory(DataGridView data)
        {
            InitializeComponent();
            DataGridView1 = data;
            AddButton.BringToFront();
            IDTextbox.ForeColor = Color.White;
            CategoryNameTextbox.ForeColor = Color.White;
            IDTextbox.Text = "" + (int.Parse(DataGridView1.Rows[DataGridView1.Rows.Count - 1].Cells["CategoryID"].Value.ToString()) + 1);
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

        private void CategoryNameTextbox_Enter(object sender, EventArgs e)
        {
            if (CategoryNameTextbox.Text == "Category Name")
            {
                CategoryNameTextbox.Text = "";
                CategoryNameTextbox.ForeColor = Color.White;
            }
        }

        private void CategoryNameTextbox_Leave(object sender, EventArgs e)
        {
            if (CategoryNameTextbox.Text == "")
            {
                CategoryNameTextbox.Text = "Category Name";
                CategoryNameTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGridView1.Rows.Count; i++)
            {
                if (IDTextbox.Text == DataGridView1.Rows[i].Cells["CategoryID"].Value.ToString())
                {
                    MessageBox.Show("This Category already exist", "Notification", MessageBoxButtons.OK);
                    IDTextbox.Text = "";
                    CategoryNameTextbox.Text = "";
                    IDTextbox.Focus();
                    return;
                }
            }

            if (IDTextbox.Text != "" && CategoryNameTextbox.Text != "")
            {
                string query = "INSERT dbo.FDCategory (NameCategory) VALUES(N'" + CategoryNameTextbox.Text + "')";
                DataProvider.Instance.ExcuteQuery(query);
                IDTextbox.Text = "";
                CategoryNameTextbox.Text = "";
                MessageBox.Show("Category Added!");
                FormAddFD.ActiveForm.Activate();
            }
            else
                MessageBox.Show("Please enter full of infomation!", "Notification", MessageBoxButtons.OK);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (IDTextbox.Text != "" && CategoryNameTextbox.Text != "")
            {
                if (MessageBox.Show("Do you really want to change this information?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string query = "UPDATE dbo.FDCategory SET ID=N'" + IDTextbox.Text + "', NameCategory='" + CategoryNameTextbox.Text + "' WHERE ID='" + IDTextbox.Text + "'";
                    DataProvider.Instance.ExcuteQuery(query);
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
    }
}
