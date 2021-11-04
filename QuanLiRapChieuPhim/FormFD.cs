using QuanLiRapChieuPhim.DAO;
using QuanLiRapChieuPhim.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim
{
    public partial class FormFD : Form
    {
        private Button curBtn;
        List<FoodDrink> fDList;

        public FormFD()
        {
            InitializeComponent();

            ShowBill(BillDAO.Instance.GetLastIDBill());
            LoadFDCategory();

            dgvBill.RowsDefaultCellStyle.BackColor = Color.Snow;
        }

        void LoadFDCategory()
        {
            List<FDCategory> fDCategoryList = FDCategoryDAO.Instance.GetFDCategory();
            
            cbbCategorySelection.DataSource = fDCategoryList;
            cbbCategorySelection.DisplayMember = "Name";
        }

        void LoadFoodDrinkByCategoryID(int iD)
        {
            flpFoodDrink.Controls.Clear();

            fDList = FoodDrinkDAO.Instance.GetFoodDrinkByCategoryID(iD);

            int indexImage = 1;

            foreach(FoodDrink item in fDList)
            {
                Button picture = new Button();
                Label name = new Label();
                Label price = new Label();

                //Design button
                picture.Width = 120;
                picture.Height = 140;
                picture.Margin = new Padding(5, 5, 5, 5);
                
                ////Insert image from resources file
                string runningPath = System.AppDomain.CurrentDomain.BaseDirectory;          //Get the app's running path
                string fileName = string.Format("{0}Resources\\{1}_{2}.png", Path.GetFullPath(Path.Combine(runningPath, @"..\..\")), iD, indexImage);
                picture.Image = Image.FromFile(fileName);

                picture.ImageAlign = ContentAlignment.MiddleCenter;
                picture.BackgroundImageLayout = ImageLayout.Stretch;
                picture.BackColor = Color.White;
                picture.FlatStyle = FlatStyle.Flat;
                picture.FlatAppearance.BorderSize = 0;

                picture.Tag = (object)item;

                //Add events to button
                picture.Click += picture_Click;

                //Design FoodDrink Name label
                name.Text = item.Name;               
                name.TextAlign = ContentAlignment.MiddleCenter;
                name.Font = new Font("Nirmala UI", 8F);
                name.BackColor = Color.Transparent;
                name.Dock = DockStyle.Top;

                //Design FoodDrink Price label
                price.Text = item.Price.ToString() + " VND";
                price.TextAlign = ContentAlignment.MiddleCenter;
                price.Font = new Font("Nirmala UI", 12F);
                price.BackColor = Color.Transparent;
                price.Dock = DockStyle.Bottom;

                //Add control to panel
                picture.Controls.Add(name);
                picture.Controls.Add(price);
                flpFoodDrink.Controls.Add(picture);
                indexImage++;
            }
        }

        void ShowBill(int iDBill)
        {
            dgvBill.Rows.Clear();
            List<FDMenu> menuList = MenuDAO.Instance.GetListMenuByBillID(iDBill);
            float total = 0;

            foreach (FDMenu item in menuList)
            {
              
                total += item.TotalPrice;

                dgvBill.Rows.Add(new object[] {item.Name, item.Quantity, item.Price, item.TotalPrice });
            }
            
            txtTotalPrice.Text = total.ToString() + " VND";
        }

        private void EnableButton(object sender)
        {
            if (sender != null)
            {
                DisableButton();

                curBtn = (Button)sender;
                curBtn.BackColor = Color.FromArgb(155, 39, 43);
                curBtn.ForeColor = Color.White;
            }
        }

        private void DisableButton()
        {
            if (curBtn != null)
            {
                curBtn.BackColor = Color.White;
                curBtn.ForeColor = Color.Black;
                curBtn = null;
            }
        }

        private void picture_Click(object sender, EventArgs e)
        {
            //If button has not selected yet, highlight it, else unhighlight 
            if (curBtn != (Button)sender)
                EnableButton(sender);
            else
                DisableButton();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (curBtn == null)
            {
                MessageBox.Show("You have not selected the FoodDrink!");
                return;
            }
            
            int iDFD = (curBtn.Tag as FoodDrink).ID;
            int iDBill = BillDAO.Instance.GetLastIDBill();
            int count = Convert.ToInt32(nmFDCount.Value);
            int status = BillDAO.Instance.GetStatusBill(iDBill);

            if (status == 0)
                BillInfoDAO.Instance.InserttBillInfo(iDBill, iDFD, count);
            else
            {
                BillDAO.Instance.InsertBill(iDBill);
                iDBill = BillDAO.Instance.GetLastIDBill();
                BillInfoDAO.Instance.InserttBillInfo(iDBill, iDFD, count);
            }

            nmFDCount.Value = 1;
            DisableButton();
            ShowBill(iDBill);
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            int iD = BillDAO.Instance.GetLastIDBill();
            BillInfoDAO.Instance.RemoveAllBillInfoByBillID(iD);
            ShowBill(iD);

            //Set default for panel
            cbbCategorySelection.SelectedIndex = 0;
            nmFDCount.Value = 1;
            dgvBill.Rows.Clear();
            txtTotalPrice.Clear();
            DisableButton();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            BillDAO.Instance.CheckOut(BillDAO.Instance.GetLastIDBill());

            //Set default for panel
            cbbCategorySelection.SelectedIndex = 0;
            nmFDCount.Value = 1;
            dgvBill.Rows.Clear();
            txtTotalPrice.Clear();
            DisableButton();
        }

        private void cbbCategorySelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbb = (ComboBox)sender;

            if (cbb == null)
                return;

            FDCategory selected = cbb.SelectedItem as FDCategory;

            if (selected != null)
                LoadFoodDrinkByCategoryID(selected.ID);
            else
                LoadFoodDrinkByCategoryID(1);
        }

        private void btnAdd_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(155, 39, 43);
        }

        private void btnRemoveAll_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(155, 39, 43);
        }

        private void btnCheckOut_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(155, 39, 43);
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(203, 98, 101);
        }

        private void btnRemoveAll_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(203, 98, 101);
        }

        private void btnCheckOut_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(203, 98, 101);
        }
    }
}
