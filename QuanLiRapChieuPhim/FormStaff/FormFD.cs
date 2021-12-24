using QuanLiRapChieuPhim.DAO;
using QuanLiRapChieuPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim
{
    public partial class FormFD : Form
    {
        private Button curFDBtn;
        private Button curCateBtn;
        private TimeSpan doubleClickMaxTime;
        private Timer clickTimer;
        private bool inDoubleClick;
        private DateTime lastClick;
        private int iDBill;
        public FormFD()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.LoadFoodDrinkByCategoryID(1);

            iDBill = BillDAO.Instance.GetLastIDBill();
            if (iDBill == 0)
            {
                BillDAO.Instance.InsertBill(iDBill + 1);
                iDBill += 1;
            }
            ShowBill(iDBill);
            lbIDBill.Text = "No. " + iDBill;
            if (BillDAO.Instance.GetStatusBill(iDBill) == 1)
                lbIDBill.ForeColor = Color.FromArgb(254, 71, 65);
            EnableCateButton(btnFood);

            //Prepare for Double Click Event
            doubleClickMaxTime = TimeSpan.FromMilliseconds(SystemInformation.DoubleClickTime);
            clickTimer = new Timer();
            clickTimer.Interval = SystemInformation.DoubleClickTime;
            clickTimer.Tick += ClickTimer_Tick;
        }
        #region Method
        //FoodDrink Button
        private void EnableFDButton(object sender)
        {
            if (sender != null)
            {
                DisableFDButton();

                curFDBtn = (Button)sender;
                curFDBtn.BackColor = Color.FromArgb(155, 39, 43);
                curFDBtn.ForeColor = Color.White;
            }
        }

        private void DisableFDButton()
        {
            if (curFDBtn != null)
            {
                curFDBtn.BackColor = Color.White;
                curFDBtn.ForeColor = Color.Black;
                curFDBtn = null;
                nmFDCount.Value = 1;
            }
        }
        //Category Button (Food Button, Drink Button, Combo Button)
        private void EnableCateButton(object sender)
        {
            if (sender != null)
            {
                DisableCateButton();

                curCateBtn = (Button)sender;
                curCateBtn.BackColor = Color.FromArgb(254, 71, 65);
            }
        }

        private void DisableCateButton()
        {
            if (curCateBtn != null)
            {
                curCateBtn.BackColor = Color.FromArgb(38, 37, 55);
                curCateBtn = null;
            }
        }

        private void LoadFoodDrinkByCategoryID(int iD)
        {
            flowLayoutPanel.Controls.Clear();

            List<FoodDrink> fDList = FoodDrinkDAO.Instance.GetFoodDrinkByCategoryID(iD);

            foreach (FoodDrink item in fDList)
            {
                Button btn = new Button();
                Label name = new Label();
                Label price = new Label();

                //Design button
                btn.Width = 150;
                btn.Height = 180;
                btn.Margin = new Padding(5, 5, 5, 5);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 135, 125);

                //Insert image from resources file
                btn.Image = FoodDrinkDAO.byteArrayToImage(item.Picture);
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.BackColor = Color.White;

                btn.Tag = (object)item;

                //Add events to button
                btn.Click += btn_Click;
                btn.MouseDown += btn_MouseDown;

                //Design FoodDrink Name label
                name.AutoSize = false;
                name.Height = 22;
                name.Text = item.Name;
                name.TextAlign = ContentAlignment.MiddleCenter;
                name.Font = new Font("Lato", 10F, FontStyle.Bold);
                name.BackColor = Color.Transparent;
                name.Dock = DockStyle.Top;

                //Design FoodDrink Price label
                price.Text = item.Price.ToString() + " VND";
                price.TextAlign = ContentAlignment.MiddleCenter;
                price.Font = new Font("Lato", 12F);
                price.BackColor = Color.Transparent;
                price.Dock = DockStyle.Bottom;

                //Add control to panel
                btn.Controls.Add(name);
                btn.Controls.Add(price);
                flowLayoutPanel.Controls.Add(btn);
            }
        }

        private void ShowBill(int iDBill)
        {
            datagridviewBill.Rows.Clear();
            List<FDMenu> menuList = MenuDAO.Instance.GetListMenuByBillID(iDBill);
            float total = 0;
            foreach (FDMenu item in menuList)
            {
                datagridviewBill.Rows.Add(new object[] { item.Name, item.Quantity, item.Price, item.TotalPrice });
                total += item.TotalPrice;
            }
            lbSubTotalDeTail.Text = total + " VND";
            lbTaxDeTail.Text = (total * 0.1).ToString() + " VND";
            lbTotalDetail.Text = (total + total * 0.1).ToString();
        }
        private void DoubleClickAction(object sender)
        {
            if (BillDAO.Instance.GetStatusBill(iDBill) == 1)
                MessageBox.Show("Bill checked out! Please make new bill!");
            else
            {
                int iDFD = ((sender as Button).Tag as FoodDrink).ID;
                int count = 1;

                BillInfoDAO.Instance.InserttBillInfo(iDBill, iDFD, count);
                ShowBill(iDBill);
            }
        }
        #endregion

        #region Events
        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (BillDAO.Instance.GetStatusBill(iDBill) == 1)
                    MessageBox.Show("Bill checked out! Please make new bill!");
                else
                {
                    if (e.RowIndex >= 0)
                    {
                        //Gets a collection that contains all the rows
                        DataGridViewRow row = this.datagridviewBill.Rows[e.RowIndex];

                        if (datagridviewBill.Columns[e.ColumnIndex].HeaderText == "")
                        {
                            //Populate the textbox from specific value of the coordinates of column and row.
                            string nameFD = row.Cells[0].Value.ToString();
                            int iDFD = FoodDrinkDAO.Instance.GetIDFoodDrinkByName(nameFD);
                            BillInfoDAO.Instance.RemoveFoodDrinkByIDFoodDrink(iDBill, iDFD);
                        }
                    }

                    else
                        MessageBox.Show("You have not selected the FoodDrink to Remove!");

                    ShowBill(iDBill);
                    //cbbCategorySelection.SelectedIndex = 0;
                    nmFDCount.Value = 1;
                    DisableFDButton();
                }
            }
            catch
            {
                MessageBox.Show("Bill is null!");
            }
        }
        private void ClickTimer_Tick(object sender, EventArgs e)
        {

            // Clear double click watcher and timer
            inDoubleClick = false;
            clickTimer.Stop();
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (inDoubleClick)
            {
                inDoubleClick = false;

                TimeSpan length = DateTime.Now - lastClick;

                // If double click is valid, respond
                if (length < doubleClickMaxTime)
                {
                    clickTimer.Stop();
                    DoubleClickAction(sender);
                }
                return;
            }

            // Double click was invalid, restart 
            clickTimer.Stop();
            clickTimer.Start();
            lastClick = DateTime.Now;
            inDoubleClick = true;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //If button has not selected yet, highlight it, else unhighlight 
            nmFDCount.Value = 1;
            if (curFDBtn != (Button)sender)
                EnableFDButton(sender);
            else
                DisableFDButton();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (curFDBtn == null)
            {
                MessageBox.Show("You have not selected the FoodDrink!");
                return;
            }
            if (BillDAO.Instance.GetStatusBill(iDBill) == 1)
                MessageBox.Show("Bill checked out! Please make new bill!");
            else
            {
                int iDFD = (curFDBtn.Tag as FoodDrink).ID;
                int count = Convert.ToInt32(nmFDCount.Value);

                BillInfoDAO.Instance.InserttBillInfo(iDBill, iDFD, count);

                nmFDCount.Value = 1;
                DisableFDButton();
                ShowBill(iDBill);
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (iDBill != 0 && BillDAO.Instance.GetStatusBill(iDBill) == 0)
            {
                string title = "Notification";
                string mess = "Do you want to delete all food drink in bill No. " + iDBill + "?";
                var result = MessageBox.Show(mess,title, MessageBoxButtons.YesNo);
                
                if (result == DialogResult.Yes)
                {
                    List<FDMenu> menuList = MenuDAO.Instance.GetListMenuByBillID(iDBill);
                    foreach (FDMenu item in menuList)
                        BillInfoDAO.Instance.RemoveFoodDrinkByIDFoodDrink(iDBill, FoodDrinkDAO.Instance.GetIDFoodDrinkByName(item.Name));
                }

                ShowBill(iDBill);
            }

            else
                MessageBox.Show("Bill checked out! Please make new bill!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BillInfoDAO.Instance.CountBillInfoByIDBill(iDBill) > 0 || BillDAO.Instance.GetStatusBill(iDBill) == 0)
            {
                if (iDBill != 0)
                {
                    FormPrintBill frm = new FormPrintBill(iDBill);
                    frm.Owner = this;
                    frm.ShowDialog();
                }
                BillDAO.Instance.InsertBill(iDBill + 1);
                iDBill += 1;
                ShowBill(iDBill);
                lbIDBill.Text = "No. " + iDBill;
                if (BillDAO.Instance.GetStatusBill(iDBill) == 1)
                    lbIDBill.ForeColor = Color.FromArgb(254, 71, 65);
                else
                    lbIDBill.ForeColor = Color.White;

            }
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            if (curFDBtn != (Button)sender)
            {
                EnableCateButton(sender);
                curFDBtn = null;
                LoadFoodDrinkByCategoryID(1);
            }
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            if (curFDBtn != (Button)sender)
            {
                EnableCateButton(sender);
                curFDBtn = null;
                LoadFoodDrinkByCategoryID(2);
            }
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            if (curFDBtn != (Button)sender)
            {
                EnableCateButton(sender);
                curFDBtn = null;
                LoadFoodDrinkByCategoryID(3);
            }
        }
        #endregion  
    }
}