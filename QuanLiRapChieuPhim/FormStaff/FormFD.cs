using Bunifu.UI.WinForms;
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
        private BunifuImageButton curFDBtn;
        private List<FoodDrink> fDList;
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
            ShowBill(iDBill);
            lbIDBill.Text = "No. " + iDBill;
            if (BillDAO.Instance.GetStatusBill(iDBill) == 1)
                lbIDBill.ForeColor = Color.FromArgb(254, 71, 65);

            //Prepare for Double Click Event
            doubleClickMaxTime = TimeSpan.FromMilliseconds(SystemInformation.DoubleClickTime);
            clickTimer = new Timer();
            clickTimer.Interval = SystemInformation.DoubleClickTime;
            clickTimer.Tick += ClickTimer_Tick;
        }
        #region Method
        private void EnableButton(object sender)
        {
            if (sender != null)
            {
                DisableButton();

                curFDBtn = (BunifuImageButton)sender;
                curFDBtn.BackColor = Color.FromArgb(155, 39, 43);
                curFDBtn.ForeColor = Color.White;
            }
        }

        private void DisableButton()
        {
            if (curFDBtn != null)
            {
                curFDBtn.BackColor = Color.White;
                curFDBtn.ForeColor = Color.Black;
                curFDBtn = null;
                nmFDCount.Value = 1;
            }
        }

        private void LoadFoodDrinkByCategoryID(int iD)
        {
            flowLayoutPanel.Controls.Clear();

            fDList = FoodDrinkDAO.Instance.GetFoodDrinkByCategoryID(iD);

            int indexImage = 1;

            foreach (FoodDrink item in fDList)
            {
                BunifuImageButton btn = new BunifuImageButton();
                Label name = new Label();
                Label price = new Label();

                //Design button
                btn.Width = 150;
                btn.Height = 180;
                btn.Margin = new Padding(5, 5, 5, 5);

                ////Insert image from resources file
                string runningPath = System.AppDomain.CurrentDomain.BaseDirectory;
                string fileName = string.Format("{0}Resources\\{1}_{2}.png", Path.GetFullPath(Path.Combine(runningPath, @"..\..\")), iD, indexImage);
                btn.Image = Image.FromFile(fileName);

                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.BackColor = Color.White;
                //btn.AllowZooming = false;

                btn.Tag = (object)item;

                //Add events to button
                btn.Click += btn_Click;
                btn.MouseDown += btn_MouseDown;

                //Design FoodDrink Name label
                name.AutoSize = false;
                name.Height = 22;
                name.Text = item.Name;
                name.TextAlign = ContentAlignment.MiddleCenter;
                name.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                name.BackColor = Color.Transparent;
                name.Dock = DockStyle.Top;

                //Design FoodDrink Price label
                price.Text = item.Price.ToString() + " VND";
                price.TextAlign = ContentAlignment.MiddleCenter;
                price.Font = new Font("Segoe UI", 12F);
                price.BackColor = Color.Transparent;
                price.Dock = DockStyle.Bottom;

                //Add control to panel
                btn.Controls.Add(name);
                btn.Controls.Add(price);
                flowLayoutPanel.Controls.Add(btn);
                indexImage++;
            }
        }

        private void ShowBill(int iDBill)
        {
            datagridviewBill.Rows.Clear();
            List<FDMenu> menuList = MenuDAO.Instance.GetListMenuByBillID(iDBill);

            foreach (FDMenu item in menuList)
                datagridviewBill.Rows.Add(new object[] { item.Name, item.Quantity, item.Price, item.TotalPrice });

            Bill b = BillDAO.Instance.GetBillByID(iDBill);
            float total = b.Total;

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
                int iDFD = ((sender as BunifuImageButton).Tag as FoodDrink).ID;
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
                    DisableButton();
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
            if (curFDBtn != (BunifuImageButton)sender)
                EnableButton(sender);
            else
                DisableButton();
        }

        //private void btnRemove_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (BillDAO.Instance.GetStatusBill(iDBill) == 1)
        //            MessageBox.Show("Bill checked out! Please make new bill!");
        //        else
        //        {
        //            int index = datagridviewBill.CurrentRow.Index;

        //            if (index >= 0)
        //            {
        //                //Gets a collection that contains all the rows
        //                DataGridViewRow row = this.datagridviewBill.Rows[index];

        //                //Populate the textbox from specific value of the coordinates of column and row.
        //                string nameFD = row.Cells[0].Value.ToString();
        //                int iDFD = FoodDrinkDAO.Instance.GetIDFoodDrinkByName(nameFD);
        //                BillInfoDAO.Instance.RemoveFoodDrinkByIDFoodDrink(iDBill, iDFD);
        //            }

        //            else
        //                MessageBox.Show("You have not selected the FoodDrink to Remove!");

        //            ShowBill(iDBill);
        //            //cbbCategorySelection.SelectedIndex = 0;
        //            nmFDCount.Value = 1;
        //            DisableButton();
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Bill is null!");
        //    }          
        //}

        private void bunifuButtonAdd_Click(object sender, EventArgs e)
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
                DisableButton();
                ShowBill(iDBill);
            }
        }

        private void bunifuImageButtonNew_Click(object sender, EventArgs e)
        {
            //Insert a new bill when the last bill checked out
            if (iDBill != 0 && BillDAO.Instance.GetStatusBill(iDBill) == 0)
                MessageBox.Show("Please complete the old bill first");
            else
            {
                BillDAO.Instance.InsertBill(iDBill + 1);
                iDBill += 1;
                ShowBill(iDBill);
                lbIDBill.Text = "No. " + iDBill;
                lbIDBill.ForeColor = Color.White;
            }
        }

        private void bunifuImageButtonSave_Click(object sender, EventArgs e)
        {
            FormPrintBill frm = new FormPrintBill(iDBill);
            frm.ShowDialog();
            if (BillDAO.Instance.GetStatusBill(iDBill) == 1)
                lbIDBill.ForeColor = Color.FromArgb(254, 71, 65);
        }

        private void bunifuButtonFood_Click(object sender, EventArgs e)
        {
            curFDBtn = null;
            LoadFoodDrinkByCategoryID(1);
        }

        private void bunifuButtonDrink_Click(object sender, EventArgs e)
        {
            curFDBtn = null;
            LoadFoodDrinkByCategoryID(2);
        }

        private void bunifuButtonCombo_Click(object sender, EventArgs e)
        {
            curFDBtn = null;
            LoadFoodDrinkByCategoryID(3);
        }
        #endregion
    }
}