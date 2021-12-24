using QuanLiRapChieuPhim.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim.AddForms
{
    public partial class FormAddInfoStaff : Form
    {
        public FormAddInfoStaff()
        {
            InitializeComponent();
        }
        string CreateID()
        {
            string idc = "";
            string query = "select * from InfoStaff where id like 'NV%' ";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            int j = 0;
            for (int i = 0; i <= table.Rows.Count ; i++)
            {
                if (i < 10) idc = "NV0" + i;
                else idc = "NV" + i;
                while (j < table.Rows.Count)
                {
                    DataRow rows = table.Rows[j];
                    if (rows["ID"].ToString() != idc) return idc;
                    else
                    {
                        j++;
                        break;
                    }
                }

            }
            IDTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            return idc;
        }
        public FormAddInfoStaff(DataGridView Grid)
        {
            InitializeComponent();
            InfoStaffGridView = Grid;
            AddButton.BringToFront();
            IDTextbox.Text = CreateID();
            IDTextbox.ReadOnly = true;
        }
        byte[] pic;

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
        public FormAddInfoStaff(string ID, string FullName, DateTime DoB, string Sex, string Address, string PhoneNum, string Email, string IDPersonal)
        {
            InitializeComponent();

            IDTextbox.Text = ID;
            FullNameTextbox.Text = FullName;
            txtDOB.Value = DoB;
            AddressTextbox.Text = Address;
            PhoneTextbox.Text = PhoneNum;
            EmailTextbox.Text = Email;
            IDPersonalTextbox.Text = IDPersonal;
            string query = "SELECT Avatar FROM dbo.InfoStaff where id ='" + ID + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            string gethead = ID.Substring(0,2);
            if(gethead!="AD")
            {
                foreach (DataRow rows in table.Rows)
                {
                    pic = (byte[])rows["Avatar"];
                }
                pictureBox1.BackgroundImage = byteArrayToImage(pic);
            }
            IDTextbox.ForeColor = Color.White;
            FullNameTextbox.ForeColor = Color.White;
            AddressTextbox.ForeColor = Color.White;
            PhoneTextbox.ForeColor = Color.White;
            EmailTextbox.ForeColor = Color.White;
            IDPersonalTextbox.ForeColor = Color.White;

            if (Sex == "Nam")
            {
                MaleCheckbox.Checked = true;
            }
            else if((Sex == "Nữ"))
            {
                FemaleCheckbox.Checked = true;
            }
            IDTextbox.ReadOnly = true;
            EditButton.BringToFront();
        }

        string Sex;
        DataGridView InfoStaffGridView = new DataGridView();


        private void FullNameTextbox_Enter(object sender, EventArgs e)
        {
            if (FullNameTextbox.Text == "Full Name")
            {
                FullNameTextbox.Text = "";
                FullNameTextbox.ForeColor = Color.White;
            }
        }


        private void AddressTextbox_Enter(object sender, EventArgs e)
        {
            if (AddressTextbox.Text == "Address")
            {
                AddressTextbox.Text = "";
                AddressTextbox.ForeColor = Color.White;
            }
        }

        private void PhoneTextbox_Enter(object sender, EventArgs e)
        {
            if (PhoneTextbox.Text == "Phone Number")
            {
                PhoneTextbox.Text = "";
                PhoneTextbox.ForeColor = Color.White;
            }
        }

        private void EmailTextbox_Enter(object sender, EventArgs e)
        {
            if (EmailTextbox.Text == "Email")
            {
                EmailTextbox.Text = "";
                EmailTextbox.ForeColor = Color.White;
            }
        }

        private void IDPersonalTextbox_Enter(object sender, EventArgs e)
        {
            if (IDPersonalTextbox.Text == "Personal ID")
            {
                IDPersonalTextbox.Text = "";
                IDPersonalTextbox.ForeColor = Color.White;
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

        private void FullNameTextbox_Leave(object sender, EventArgs e)
        {
            if (FullNameTextbox.Text == "")
            {
                FullNameTextbox.Text = "Full Name";
                FullNameTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void DoBTextbox_Leave(object sender, EventArgs e)
        {
            if (txtDOB.Text == "")
            {
                txtDOB.Text = "Birthday";
                txtDOB.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void AddressTextbox_Leave(object sender, EventArgs e)
        {
            if (AddressTextbox.Text == "")
            {
                AddressTextbox.Text = "Address";
                AddressTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void PhoneTextbox_Leave(object sender, EventArgs e)
        {
            if (PhoneTextbox.Text == "")
            {
                PhoneTextbox.Text = "Phone Number";
                PhoneTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void EmailTextbox_Leave(object sender, EventArgs e)
        {
            if (EmailTextbox.Text == "")
            {
                EmailTextbox.Text = "Email";
                EmailTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void IDPersonalTextbox_Leave(object sender, EventArgs e)
        {
            if (IDPersonalTextbox.Text == "")
            {
                IDPersonalTextbox.Text = "Personal ID";
                IDPersonalTextbox.ForeColor = Color.FromArgb(190, 62, 66);
            }
        }

        private void AddButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddButton.BackColor = Color.FromArgb(199, 80, 87);
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.BackColor = Color.FromArgb(190, 62, 66);
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (FullNameTextbox.Text == "Full Name" || FullNameTextbox.Text == "")
            {
                errorProvider1.SetError(FullNameTextbox, "Please enter Full Name!");
                count++;
            }
            else
            {
                errorProvider1.SetError(FullNameTextbox, null);
            }

            if (txtDOB.Text == "Birthday" || txtDOB.Text == "")
            {
                errorProvider1.SetError(txtDOB, "Please enter Birthday!");
                count++;
            }
            else
            {
                errorProvider1.SetError(txtDOB, null);
            }

            if (AddressTextbox.Text == "Address" || AddressTextbox.Text == "")
            {
                errorProvider1.SetError(AddressTextbox, "Please enter Address!");
                count++;
            }
            else
            {
                errorProvider1.SetError(AddressTextbox, null);
            }


            if (IDPersonalTextbox.Text == "Personal ID" || IDPersonalTextbox.Text == "")
            {
                errorProvider1.SetError(IDPersonalTextbox, "Please enter Personal ID!");
                count++;
            }
            else
            {
                errorProvider1.SetError(IDPersonalTextbox, null);
            }

            if (PhoneTextbox.Text.Length != 10 )
            {
                errorProvider1.SetError(PhoneTextbox, "Please enter phone number in the correct format!");
                count++;
            }
            else if (PhoneTextbox.Text == "Phone Number")
            {
                errorProvider1.SetError(PhoneTextbox, "Please enter phone number!");
                count++;
            }
            else
            {
                errorProvider1.SetError(PhoneTextbox, null);
            }

            if ((MaleCheckbox.Checked == false && FemaleCheckbox.Checked == false) || (MaleCheckbox.Checked == true && FemaleCheckbox.Checked == true))
            {
                errorProvider1.SetError(FemaleCheckbox, "Please enter only one!");
                count++;
            }
            else
            {
                errorProvider1.SetError(FemaleCheckbox, null);
            }

            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (Regex.IsMatch(EmailTextbox.Text, pattern))
            {
                errorProvider1.SetError(EmailTextbox, null);
            }
            else
            {
                errorProvider1.SetError(EmailTextbox, "Please enter email format!");
                count++;
            }

            for (int i = 0; i < InfoStaffGridView.Rows.Count; i++)
            {
                if (IDTextbox.Text == InfoStaffGridView.Rows[i].Cells["ID"].Value.ToString())
                {
                    MessageBox.Show("This staff has already existed", "Notification", MessageBoxButtons.OK);
                    IDTextbox.Text = "";
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
                if ((MaleCheckbox.Checked == true && FemaleCheckbox.Checked == true) || (MaleCheckbox.Checked == false && FemaleCheckbox.Checked == false))
                {
                    MessageBox.Show("Wrong sex!", "Notification", MessageBoxButtons.OK);
                    return;
                }
                else if (MaleCheckbox.Checked)
                    Sex = "Nam";
                else
                    Sex = "Nữ";

                DateTime DayofBirth = txtDOB.Value;
                string sqlFormattedDate = DayofBirth.ToString("yyyy-MM-dd HH:mm:ss.fff");
                AccountDAO.Instance.AddInfoStaff(IDTextbox.Text, FullNameTextbox.Text, sqlFormattedDate, AddressTextbox.Text, PhoneTextbox.Text, IDPersonalTextbox.Text, EmailTextbox.Text, Sex);
                imageToByteArray(PicturePath, IDTextbox.Text);
                pictureBox1.BackgroundImage = null;
                IDTextbox.Text = CreateID();
                FullNameTextbox.Text = "FullName";
                AddressTextbox.Text = "Address";
                PhoneTextbox.Text = "Phone Number";
                IDPersonalTextbox.Text = "Personal ID";
                EmailTextbox.Text = "Email";
                FullNameTextbox.ForeColor = Color.FromArgb(190, 62, 66);
                AddressTextbox.ForeColor = Color.FromArgb(190, 62, 66);
                PhoneTextbox.ForeColor = Color.FromArgb(190, 62, 66);
                IDPersonalTextbox.ForeColor = Color.FromArgb(190, 62, 66);
                EmailTextbox.ForeColor = Color.FromArgb(190, 62, 66);
                MaleCheckbox.Checked = false;
                FemaleCheckbox.Checked = false;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (FullNameTextbox.Text == "Full Name" || FullNameTextbox.Text == "")
            {
                errorProvider1.SetError(FullNameTextbox, "Please enter Full Name!");
                count++;
            }
            else
            {
                errorProvider1.SetError(FullNameTextbox, null);
            }

            if (AddressTextbox.Text == "Address" || AddressTextbox.Text == "")
            {
                errorProvider1.SetError(AddressTextbox, "Please enter Address!");
                count++;
            }
            else
            {
                errorProvider1.SetError(AddressTextbox, null);
            }

            if (IDPersonalTextbox.Text == "ID Personal" || IDPersonalTextbox.Text == "")
            {
                errorProvider1.SetError(IDPersonalTextbox, "Please enter ID Personal!");
                count++;
            }
            else
            {
                errorProvider1.SetError(IDPersonalTextbox, null);
            }


            if (PhoneTextbox.Text.Length != 10)
            {
                errorProvider1.SetError(PhoneTextbox, "Please enter phone number in the correct format!");
                count++;
            }
            else if (PhoneTextbox.Text == "Phone Number")
            {
                errorProvider1.SetError(PhoneTextbox, "Please enter phone number!");
                count++;
            }
            else
            {
                errorProvider1.SetError(PhoneTextbox, null);
            }

            if ((MaleCheckbox.Checked ==false && FemaleCheckbox.Checked==false) || (MaleCheckbox.Checked == true && FemaleCheckbox.Checked == true))
            {
                errorProvider1.SetError(FemaleCheckbox, "Please enter only one!");
                count++;
            }    
            else
            {
                errorProvider1.SetError(FemaleCheckbox, null);
            }


            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if(Regex.IsMatch(EmailTextbox.Text,pattern))
            {
                errorProvider1.SetError(EmailTextbox, null);
            }    
            else
            {
                errorProvider1.SetError(EmailTextbox, "Please enter email format!");
                count++;
            }

            if (count==0)
            {
                if (MessageBox.Show("Do you really want to change this account?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string Sex;

                    DateTime DayofBirth = txtDOB.Value;
                    string sqlFormattedDate = DayofBirth.ToString("yyyy-MM-dd HH:mm:ss.fff");

                    if (MaleCheckbox.Checked == FemaleCheckbox.Checked)
                    {
                        MessageBox.Show("Wrong Sex", "Notificaiton", MessageBoxButtons.OK);
                        return;
                    }

                    if (MaleCheckbox.Checked == true)
                    {
                        Sex = "Nam";
                    }
                    else
                    {
                        Sex = "Nữ";
                    }

                    AccountDAO.Instance.EditInfoStaff(IDTextbox.Text, FullNameTextbox.Text, sqlFormattedDate, AddressTextbox.Text, PhoneTextbox.Text, IDPersonalTextbox.Text, EmailTextbox.Text, Sex);
                    if (PicturePath != "")
                    {
                        imageToByteArray(PicturePath, IDTextbox.Text);
                    }
                    this.Close();
                }
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
        }

        private void PhoneTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void IDPersonalTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
