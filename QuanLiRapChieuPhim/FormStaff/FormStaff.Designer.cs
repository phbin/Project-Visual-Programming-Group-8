
using System.Drawing;
using System.Windows.Forms;

namespace QuanLiRapChieuPhim
{
    partial class FormStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStaff));
            this.gradientPanelStaff = new QuanLiRapChieuPhim.GradientPanel();
            this.txtAddr = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UploadButton = new System.Windows.Forms.Button();
            this.pictureBoxAddr = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhone = new System.Windows.Forms.PictureBox();
            this.lbID = new System.Windows.Forms.Label();
            this.pictureBoxSex = new System.Windows.Forms.PictureBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxEmail = new System.Windows.Forms.PictureBox();
            this.pictureBoxDoB = new System.Windows.Forms.PictureBox();
            this.pictureBoxPID = new System.Windows.Forms.PictureBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelPID = new System.Windows.Forms.Label();
            this.gradientPanelStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPID)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanelStaff
            // 
            this.gradientPanelStaff.Angle = 90F;
            this.gradientPanelStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.gradientPanelStaff.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.gradientPanelStaff.Controls.Add(this.txtAddr);
            this.gradientPanelStaff.Controls.Add(this.txtPhone);
            this.gradientPanelStaff.Controls.Add(this.txtEmail);
            this.gradientPanelStaff.Controls.Add(this.txtSex);
            this.gradientPanelStaff.Controls.Add(this.txtDOB);
            this.gradientPanelStaff.Controls.Add(this.txtPID);
            this.gradientPanelStaff.Controls.Add(this.pictureBox1);
            this.gradientPanelStaff.Controls.Add(this.UploadButton);
            this.gradientPanelStaff.Controls.Add(this.pictureBoxAddr);
            this.gradientPanelStaff.Controls.Add(this.pictureBoxPhone);
            this.gradientPanelStaff.Controls.Add(this.lbID);
            this.gradientPanelStaff.Controls.Add(this.pictureBoxSex);
            this.gradientPanelStaff.Controls.Add(this.labelID);
            this.gradientPanelStaff.Controls.Add(this.labelAddress);
            this.gradientPanelStaff.Controls.Add(this.labelName);
            this.gradientPanelStaff.Controls.Add(this.pictureBoxEmail);
            this.gradientPanelStaff.Controls.Add(this.pictureBoxDoB);
            this.gradientPanelStaff.Controls.Add(this.pictureBoxPID);
            this.gradientPanelStaff.Controls.Add(this.labelEmail);
            this.gradientPanelStaff.Controls.Add(this.labelSex);
            this.gradientPanelStaff.Controls.Add(this.labelPhone);
            this.gradientPanelStaff.Controls.Add(this.labelBirthday);
            this.gradientPanelStaff.Controls.Add(this.labelPID);
            this.gradientPanelStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelStaff.ForeColor = System.Drawing.Color.Black;
            this.gradientPanelStaff.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientPanelStaff.Name = "gradientPanelStaff";
            this.gradientPanelStaff.Size = new System.Drawing.Size(1283, 753);
            this.gradientPanelStaff.TabIndex = 1;
            this.gradientPanelStaff.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            // 
            // txtAddr
            // 
            this.txtAddr.AutoSize = true;
            this.txtAddr.BackColor = System.Drawing.Color.Transparent;
            this.txtAddr.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddr.ForeColor = System.Drawing.Color.White;
            this.txtAddr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAddr.Location = new System.Drawing.Point(1006, 323);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(82, 24);
            this.txtAddr.TabIndex = 18;
            this.txtAddr.Text = "Address";
            this.txtAddr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhone
            // 
            this.txtPhone.AutoSize = true;
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPhone.Location = new System.Drawing.Point(1006, 222);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(81, 24);
            this.txtPhone.TabIndex = 17;
            this.txtPhone.Text = "Number";
            this.txtPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmail.Location = new System.Drawing.Point(1006, 121);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(58, 24);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.Text = "Email";
            this.txtEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSex
            // 
            this.txtSex.AutoSize = true;
            this.txtSex.BackColor = System.Drawing.Color.Transparent;
            this.txtSex.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.ForeColor = System.Drawing.Color.White;
            this.txtSex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSex.Location = new System.Drawing.Point(531, 323);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(42, 24);
            this.txtSex.TabIndex = 15;
            this.txtSex.Text = "Sex";
            this.txtSex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDOB
            // 
            this.txtDOB.AutoSize = true;
            this.txtDOB.BackColor = System.Drawing.Color.Transparent;
            this.txtDOB.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.ForeColor = System.Drawing.Color.White;
            this.txtDOB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDOB.Location = new System.Drawing.Point(531, 222);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(54, 24);
            this.txtDOB.TabIndex = 14;
            this.txtDOB.Text = "DOB";
            this.txtDOB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPID
            // 
            this.txtPID.AutoSize = true;
            this.txtPID.BackColor = System.Drawing.Color.Transparent;
            this.txtPID.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPID.ForeColor = System.Drawing.Color.White;
            this.txtPID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPID.Location = new System.Drawing.Point(531, 121);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(116, 24);
            this.txtPID.TabIndex = 13;
            this.txtPID.Text = "Personal ID:";
            this.txtPID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(87, 93);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 227);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(133, 346);
            this.UploadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(135, 31);
            this.UploadButton.TabIndex = 3;
            this.UploadButton.Text = "Upload Image";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // pictureBoxAddr
            // 
            this.pictureBoxAddr.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAddr.BackgroundImage = global::QuanLiRapChieuPhim.Properties.Resources.icon_address_30;
            this.pictureBoxAddr.InitialImage = null;
            this.pictureBoxAddr.Location = new System.Drawing.Point(852, 321);
            this.pictureBoxAddr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxAddr.Name = "pictureBoxAddr";
            this.pictureBoxAddr.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxAddr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAddr.TabIndex = 1;
            this.pictureBoxAddr.TabStop = false;
            // 
            // pictureBoxPhone
            // 
            this.pictureBoxPhone.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPhone.BackgroundImage = global::QuanLiRapChieuPhim.Properties.Resources.icon_phone_30;
            this.pictureBoxPhone.InitialImage = null;
            this.pictureBoxPhone.Location = new System.Drawing.Point(852, 219);
            this.pictureBoxPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxPhone.Name = "pictureBoxPhone";
            this.pictureBoxPhone.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPhone.TabIndex = 5;
            this.pictureBoxPhone.TabStop = false;
            // 
            // lbID
            // 
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.White;
            this.lbID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbID.Location = new System.Drawing.Point(156, 430);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(129, 23);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID";
            this.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxSex
            // 
            this.pictureBoxSex.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSex.BackgroundImage = global::QuanLiRapChieuPhim.Properties.Resources.icon_gender_30;
            this.pictureBoxSex.InitialImage = null;
            this.pictureBoxSex.Location = new System.Drawing.Point(351, 322);
            this.pictureBoxSex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSex.Name = "pictureBoxSex";
            this.pictureBoxSex.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxSex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSex.TabIndex = 5;
            this.pictureBoxSex.TabStop = false;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelID.Location = new System.Drawing.Point(110, 430);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(36, 24);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID:";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.White;
            this.labelAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAddress.Location = new System.Drawing.Point(902, 321);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(88, 24);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address:";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelName.Location = new System.Drawing.Point(109, 475);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 24);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxEmail
            // 
            this.pictureBoxEmail.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEmail.BackgroundImage = global::QuanLiRapChieuPhim.Properties.Resources.icon_mail_30;
            this.pictureBoxEmail.InitialImage = null;
            this.pictureBoxEmail.Location = new System.Drawing.Point(852, 117);
            this.pictureBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEmail.Name = "pictureBoxEmail";
            this.pictureBoxEmail.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEmail.TabIndex = 2;
            this.pictureBoxEmail.TabStop = false;
            // 
            // pictureBoxDoB
            // 
            this.pictureBoxDoB.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDoB.BackgroundImage = global::QuanLiRapChieuPhim.Properties.Resources.icon_birth_date_30;
            this.pictureBoxDoB.InitialImage = null;
            this.pictureBoxDoB.Location = new System.Drawing.Point(352, 218);
            this.pictureBoxDoB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxDoB.Name = "pictureBoxDoB";
            this.pictureBoxDoB.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxDoB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDoB.TabIndex = 4;
            this.pictureBoxDoB.TabStop = false;
            // 
            // pictureBoxPID
            // 
            this.pictureBoxPID.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPID.BackgroundImage = global::QuanLiRapChieuPhim.Properties.Resources.icon_id_30;
            this.pictureBoxPID.InitialImage = null;
            this.pictureBoxPID.Location = new System.Drawing.Point(351, 114);
            this.pictureBoxPID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxPID.Name = "pictureBoxPID";
            this.pictureBoxPID.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxPID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPID.TabIndex = 3;
            this.pictureBoxPID.TabStop = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEmail.Location = new System.Drawing.Point(902, 121);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(63, 24);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.BackColor = System.Drawing.Color.Transparent;
            this.labelSex.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSex.ForeColor = System.Drawing.Color.White;
            this.labelSex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSex.Location = new System.Drawing.Point(403, 323);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(48, 24);
            this.labelSex.TabIndex = 0;
            this.labelSex.Text = "Sex:";
            this.labelSex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.ForeColor = System.Drawing.Color.White;
            this.labelPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPhone.Location = new System.Drawing.Point(900, 221);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(73, 24);
            this.labelPhone.TabIndex = 0;
            this.labelPhone.Text = "Phone:";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.BackColor = System.Drawing.Color.Transparent;
            this.labelBirthday.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.ForeColor = System.Drawing.Color.White;
            this.labelBirthday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBirthday.Location = new System.Drawing.Point(403, 222);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(55, 24);
            this.labelBirthday.TabIndex = 0;
            this.labelBirthday.Text = "DoB:";
            this.labelBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPID
            // 
            this.labelPID.AutoSize = true;
            this.labelPID.BackColor = System.Drawing.Color.Transparent;
            this.labelPID.Font = new System.Drawing.Font("Lato Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPID.ForeColor = System.Drawing.Color.White;
            this.labelPID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPID.Location = new System.Drawing.Point(400, 121);
            this.labelPID.Name = "labelPID";
            this.labelPID.Size = new System.Drawing.Size(120, 24);
            this.labelPID.TabIndex = 0;
            this.labelPID.Text = "Personal ID:";
            this.labelPID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1283, 753);
            this.Controls.Add(this.gradientPanelStaff);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStaff";
            this.gradientPanelStaff.ResumeLayout(false);
            this.gradientPanelStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelStaff;
        private PictureBox pictureBox1;
        private Button UploadButton;
        private PictureBox pictureBoxAddr;
        private PictureBox pictureBoxPhone;
        private Label lbID;
        private PictureBox pictureBoxSex;
        private Label labelID;
        private Label labelAddress;
        private Label labelName;
        private PictureBox pictureBoxEmail;
        private PictureBox pictureBoxDoB;
        private PictureBox pictureBoxPID;
        private Label labelEmail;
        private Label labelSex;
        private Label labelPhone;
        private Label labelBirthday;
        private Label labelPID;
        private Label txtAddr;
        private Label txtPhone;
        private Label txtEmail;
        private Label txtSex;
        private Label txtDOB;
        private Label txtPID;
    }
}