using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim
{
    public partial class FormFD : Form
    {
        private Button curBtn;
        List<FoodDrink> fdTotalList = new List<FoodDrink>();    //include combo, food, drink
        List<Bill> billList = new List<Bill>();
        List<BillInfo> billInfoList = new List<BillInfo>();
        public FormFD()
        {
            InitializeComponent();

            //Set default for combobox
            cbbTypeSelection.SelectedIndex = 0;
            flpCombo.BringToFront();

            //Display item of fooddrink list in main panel
            LoadFoodDrink();
        }

        void LoadFoodDrink()
        {
            // Create and load combo type list
            List<FoodDrink> fdComboList = new List<FoodDrink>();
            for (int i = 0; i < 5; i++)
            {
                FoodDrink fd = new FoodDrink();
                fd.NameFD = "Combo " + (i + 1).ToString();
                fd.TypeFD = "C";
                fd.IDFoodDrink = "C0" + (i + 1);
                fd.Price = 149000 * (i + 1);
                fdComboList.Add(fd);

                Button btn = new Button() { Width = 90, Height = 80 };
                btn.BackColor = Color.White;
                btn.Text = fd.NameFD + Environment.NewLine + fd.Price.ToString();
                btn.MouseClick += Btn_MouseClick;
                btn.Tag = (object)fd;

                flpCombo.Controls.Add(btn);
            }

            // Create and load food type list
            List<FoodDrink> fdFoodList = new List<FoodDrink>();
            for (int i = 0; i < 7; i++)
            {
                FoodDrink fd = new FoodDrink();
                fd.NameFD = "Food " + (i + 1).ToString();
                fd.IDFoodDrink = "F0" + (i + 1);
                fd.TypeFD = "F";
                fd.Price = 49000 * (i + 1);
                fdFoodList.Add(fd);

                Button btn = new Button() { Width = 90, Height = 80 };
                btn.BackColor = Color.White;
                btn.Text = fd.NameFD + Environment.NewLine + fd.Price.ToString();
                btn.MouseClick += Btn_MouseClick;
                btn.Tag = (object)fd;

                flpFood.Controls.Add(btn);
            }

            // Create and load drink type list
            List<FoodDrink> fdDrinkList = new List<FoodDrink>();
            for (int i = 0; i < 6; i++)
            {
                FoodDrink fd = new FoodDrink();
                fd.NameFD = "Drink " + (i + 1).ToString();
                fd.IDFoodDrink = "D0" + (i + 1);
                fd.TypeFD = "D";
                fd.Price = 39000 * (i + 1);
                fdDrinkList.Add(fd);

                Button btn = new Button() { Width = 90, Height = 80 };
                btn.BackColor = Color.White;
                btn.Text = fd.NameFD + Environment.NewLine + fd.Price.ToString();
                btn.MouseClick += Btn_MouseClick;
                btn.Tag = (object)fd;

                flpDrink.Controls.Add(btn);
            }

            fdTotalList.AddRange(fdComboList);
            fdTotalList.AddRange(fdFoodList);
            fdTotalList.AddRange(fdDrinkList);
        }

        void ShowBill(BillInfo bInfo)
        {
            var item = lstvBill.FindItemWithText(bInfo.IDFoodDrink);
            if (item != null)
                lstvBill.Items[item.Index].Remove();
            for (int i = 0; i < billInfoList.Count; i++)
            {
                if (billInfoList[i].IDFoodDrink == bInfo.IDFoodDrink)
                {
                    ListViewItem lvItem = new ListViewItem(billInfoList[i].IDFoodDrink.ToString());
                    lvItem.SubItems.Add(billInfoList[i].Quantity.ToString());
                    for (int j = 0; j < fdTotalList.Count; j++)
                        if (billInfoList[i].IDFoodDrink == fdTotalList[j].IDFoodDrink)
                        {
                            lvItem.SubItems.Add(fdTotalList[j].Price.ToString());
                            lvItem.SubItems.Add((fdTotalList[j].Price * billInfoList[i].Quantity).ToString());
                            lvItem.Tag = fdTotalList[j].Price * billInfoList[i].Quantity;
                            break;
                        }
                    lstvBill.Items.Add(lvItem);
                }
            }
            CountTotalPrice();
        }
        //If billifo has already existed fd, just add quantity and total price in billinfo
        void AddQuantityFoodDrinkInBillInfo(BillInfo bInfo)
        {
            for (int i = 0; i < billInfoList.Count; i++)
                if (IsExistedFoodDrink(bInfo))
                {
                    billInfoList[i].Quantity += bInfo.Quantity;
                    //Totalprice in bill will be changed by class Bill
                }
        }
        //Check this FT has already existed?
        bool IsExistedFoodDrink(BillInfo bInfo)
        {
            for (int i = 0; i < billInfoList.Count; i++)
                if (bInfo.IDFoodDrink == billInfoList[i].IDFoodDrink)
                    return true;
            return false;
        }

        void CountTotalPrice()
        {
            int total = 0;
            for (int i = 0; i < lstvBill.Items.Count; i++)
                total += Convert.ToInt32(lstvBill.Items[i].Tag);
            txtTotalPrice.Text = total.ToString();  
        }

        private void EnableButton(object sender)
        {
            if (sender != null)
            {
                DisableButton();

                curBtn = (Button)sender;
                curBtn.BackColor = Color.FromArgb(190, 62, 66);
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

        private void Btn_MouseClick(object sender, EventArgs e)
        {
            //If button has not selected yet, highlight it, else unhighlight 
            if (curBtn != (Button)sender)
                EnableButton(sender);
            else
                DisableButton();
        }

        //Change panel when fooddrink type change
        private void cbbTypeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbTypeSelection.SelectedIndex)
            {
                case 0:
                    flpCombo.BringToFront();
                    break;
                case 1:
                    flpFood.BringToFront();
                    break;
                case 2:
                    flpDrink.BringToFront();
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Create a new BillInfo
            string iDFD = (curBtn.Tag as FoodDrink).IDFoodDrink;
            BillInfo bInfo = new BillInfo(billList.Count + 1, iDFD, Convert.ToInt32(nmFDCount.Value));
            
            //Check Bill
            if (IsExistedFoodDrink(bInfo))
                AddQuantityFoodDrinkInBillInfo(bInfo);
            else
                billInfoList.Add(bInfo);
            
            ShowBill(bInfo);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            billList.Add(new Bill(billList.Count + 1, DateTime.Now.ToString(), int.Parse(txtTotalPrice.Text)));

            //Set default for panel
            cbbTypeSelection.SelectedIndex = 0;
            nmFDCount.Value = 1;
            lstvBill.Items.Clear();
            txtTotalPrice.Clear();
            DisableButton();
        }
    }
}
