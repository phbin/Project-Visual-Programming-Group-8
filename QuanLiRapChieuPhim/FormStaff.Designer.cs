
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
            this.gradientPanelStaff = new QuanLiRapChieuPhim.GradientPanel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.gradientPanel1 = new QuanLiRapChieuPhim.GradientPanel();
            this.labelSex = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelPID = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.PID = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.pictureBoxPID = new System.Windows.Forms.PictureBox();
            this.Email = new System.Windows.Forms.Label();
            this.pictureBoxDoB = new System.Windows.Forms.PictureBox();
            this.Phone = new System.Windows.Forms.Label();
            this.pictureBoxEmail = new System.Windows.Forms.PictureBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.pictureBoxSex = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhone = new System.Windows.Forms.PictureBox();
            this.Address = new System.Windows.Forms.Label();
            this.pictureBoxAddr = new System.Windows.Forms.PictureBox();
            this.gradientPanel = new QuanLiRapChieuPhim.GradientPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.gradientPanel4 = new QuanLiRapChieuPhim.GradientPanel();
            this.gradientPanelStaff.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddr)).BeginInit();
            this.gradientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.gradientPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanelStaff
            // 
            this.gradientPanelStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanelStaff.Angle = 90F;
            this.gradientPanelStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.gradientPanelStaff.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.gradientPanelStaff.Controls.Add(this.gradientPanel1);
            this.gradientPanelStaff.Controls.Add(this.gradientPanel4);
            this.gradientPanelStaff.Controls.Add(this.labelInfo);
            this.gradientPanelStaff.ForeColor = System.Drawing.Color.Black;
            this.gradientPanelStaff.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelStaff.Name = "gradientPanelStaff";
            this.gradientPanelStaff.Size = new System.Drawing.Size(905, 568);
            this.gradientPanelStaff.TabIndex = 1;
            this.gradientPanelStaff.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(330, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(205, 45);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Personal Info";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BackColor = System.Drawing.Color.LightCoral;
            this.gradientPanel1.BottomColor = System.Drawing.Color.Firebrick;
            this.gradientPanel1.Controls.Add(this.pictureBoxAddr);
            this.gradientPanel1.Controls.Add(this.Address);
            this.gradientPanel1.Controls.Add(this.pictureBoxPhone);
            this.gradientPanel1.Controls.Add(this.pictureBoxSex);
            this.gradientPanel1.Controls.Add(this.labelAddress);
            this.gradientPanel1.Controls.Add(this.pictureBoxEmail);
            this.gradientPanel1.Controls.Add(this.Phone);
            this.gradientPanel1.Controls.Add(this.pictureBoxDoB);
            this.gradientPanel1.Controls.Add(this.Email);
            this.gradientPanel1.Controls.Add(this.pictureBoxPID);
            this.gradientPanel1.Controls.Add(this.labelEmail);
            this.gradientPanel1.Controls.Add(this.PID);
            this.gradientPanel1.Controls.Add(this.labelPhone);
            this.gradientPanel1.Controls.Add(this.labelPID);
            this.gradientPanel1.Controls.Add(this.labelBirthday);
            this.gradientPanel1.Controls.Add(this.Sex);
            this.gradientPanel1.Controls.Add(this.Birthday);
            this.gradientPanel1.Controls.Add(this.labelSex);
            this.gradientPanel1.Location = new System.Drawing.Point(338, 63);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(550, 474);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.Firebrick;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.BackColor = System.Drawing.Color.Transparent;
            this.labelSex.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSex.ForeColor = System.Drawing.Color.White;
            this.labelSex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSex.Location = new System.Drawing.Point(441, 142);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(55, 30);
            this.labelSex.TabIndex = 0;
            this.labelSex.Text = "Sex:";
            this.labelSex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Birthday
            // 
            this.Birthday.BackColor = System.Drawing.Color.Transparent;
            this.Birthday.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthday.ForeColor = System.Drawing.Color.White;
            this.Birthday.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Birthday.Location = new System.Drawing.Point(239, 145);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(164, 55);
            this.Birthday.TabIndex = 0;
            // 
            // Sex
            // 
            this.Sex.BackColor = System.Drawing.Color.Transparent;
            this.Sex.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sex.ForeColor = System.Drawing.Color.White;
            this.Sex.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Sex.Location = new System.Drawing.Point(517, 141);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(256, 58);
            this.Sex.TabIndex = 0;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.BackColor = System.Drawing.Color.Transparent;
            this.labelBirthday.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.ForeColor = System.Drawing.Color.White;
            this.labelBirthday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBirthday.Location = new System.Drawing.Point(98, 143);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(109, 30);
            this.labelBirthday.TabIndex = 0;
            this.labelBirthday.Text = "Birthday:";
            this.labelBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPID
            // 
            this.labelPID.AutoSize = true;
            this.labelPID.BackColor = System.Drawing.Color.Transparent;
            this.labelPID.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPID.ForeColor = System.Drawing.Color.White;
            this.labelPID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPID.Location = new System.Drawing.Point(96, 65);
            this.labelPID.Name = "labelPID";
            this.labelPID.Size = new System.Drawing.Size(136, 30);
            this.labelPID.TabIndex = 0;
            this.labelPID.Text = "Personal ID:";
            this.labelPID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.ForeColor = System.Drawing.Color.White;
            this.labelPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPhone.Location = new System.Drawing.Point(101, 292);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(84, 30);
            this.labelPhone.TabIndex = 0;
            this.labelPhone.Text = "Phone:";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PID
            // 
            this.PID.BackColor = System.Drawing.Color.Transparent;
            this.PID.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PID.ForeColor = System.Drawing.Color.White;
            this.PID.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PID.Location = new System.Drawing.Point(273, 68);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(558, 77);
            this.PID.TabIndex = 0;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEmail.Location = new System.Drawing.Point(104, 220);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(75, 30);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxPID
            // 
            this.pictureBoxPID.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPID.BackgroundImage = global::QuanLiRapChieuPhim.Properties.Resources.icon_id_30;
            this.pictureBoxPID.InitialImage = null;
            this.pictureBoxPID.Location = new System.Drawing.Point(40, 57);
            this.pictureBoxPID.Name = "pictureBoxPID";
            this.pictureBoxPID.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxPID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPID.TabIndex = 3;
            this.pictureBoxPID.TabStop = false;
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Email.Location = new System.Drawing.Point(210, 223);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(672, 85);
            this.Email.TabIndex = 0;
            // 
            // pictureBoxDoB
            // 
            this.pictureBoxDoB.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDoB.BackgroundImage = global::QuanLiRapChieuPhim.Properties.Resources.icon_birth_date_30;
            this.pictureBoxDoB.InitialImage = null;
            this.pictureBoxDoB.Location = new System.Drawing.Point(41, 140);
            this.pictureBoxDoB.Name = "pictureBoxDoB";
            this.pictureBoxDoB.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxDoB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDoB.TabIndex = 4;
            this.pictureBoxDoB.TabStop = false;
            // 
            // Phone
            // 
            this.Phone.BackColor = System.Drawing.Color.Transparent;
            this.Phone.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.ForeColor = System.Drawing.Color.White;
            this.Phone.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Phone.Location = new System.Drawing.Point(213, 295);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(644, 97);
            this.Phone.TabIndex = 0;
            // 
            // pictureBoxEmail
            // 
            this.pictureBoxEmail.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEmail.BackgroundImage = global::QuanLiRapChieuPhim.Properties.Resources.icon_mail_30;
            this.pictureBoxEmail.InitialImage = null;
            this.pictureBoxEmail.Location = new System.Drawing.Point(44, 215);
            this.pictureBoxEmail.Name = "pictureBoxEmail";
            this.pictureBoxEmail.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEmail.TabIndex = 2;
            this.pictureBoxEmail.TabStop = false;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.White;
            this.labelAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAddress.Location = new System.Drawing.Point(101, 375);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(103, 30);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address:";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxSex
            // 
            this.pictureBoxSex.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSex.BackgroundImage = global::QuanLiRapChieuPhim.Properties.Resources.icon_gender_30;
            this.pictureBoxSex.InitialImage = null;
            this.pictureBoxSex.Location = new System.Drawing.Point(397, 140);
            this.pictureBoxSex.Name = "pictureBoxSex";
            this.pictureBoxSex.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxSex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSex.TabIndex = 5;
            this.pictureBoxSex.TabStop = false;
            // 
            // pictureBoxPhone
            // 
            this.pictureBoxPhone.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPhone.BackgroundImage = global::QuanLiRapChieuPhim.Properties.Resources.icon_phone_30;
            this.pictureBoxPhone.InitialImage = null;
            this.pictureBoxPhone.Location = new System.Drawing.Point(43, 287);
            this.pictureBoxPhone.Name = "pictureBoxPhone";
            this.pictureBoxPhone.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPhone.TabIndex = 5;
            this.pictureBoxPhone.TabStop = false;
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.Color.Transparent;
            this.Address.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.Color.White;
            this.Address.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Address.Location = new System.Drawing.Point(239, 378);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(663, 95);
            this.Address.TabIndex = 0;
            // 
            // pictureBoxAddr
            // 
            this.pictureBoxAddr.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAddr.BackgroundImage = global::QuanLiRapChieuPhim.Properties.Resources.icon_address_30;
            this.pictureBoxAddr.InitialImage = null;
            this.pictureBoxAddr.Location = new System.Drawing.Point(45, 369);
            this.pictureBoxAddr.Name = "pictureBoxAddr";
            this.pictureBoxAddr.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxAddr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAddr.TabIndex = 1;
            this.pictureBoxAddr.TabStop = false;
            // 
            // gradientPanel
            // 
            this.gradientPanel.Angle = 0F;
            this.gradientPanel.BackColor = System.Drawing.Color.LightCoral;
            this.gradientPanel.BottomColor = System.Drawing.Color.Firebrick;
            this.gradientPanel.Controls.Add(this.pictureBoxAvatar);
            this.gradientPanel.Controls.Add(this.ID);
            this.gradientPanel.Controls.Add(this.labelID);
            this.gradientPanel.Controls.Add(this.labelName);
            this.gradientPanel.Location = new System.Drawing.Point(-13, -3);
            this.gradientPanel.Name = "gradientPanel";
            this.gradientPanel.Size = new System.Drawing.Size(305, 440);
            this.gradientPanel.TabIndex = 0;
            this.gradientPanel.TopColor = System.Drawing.Color.Firebrick;
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelName.Location = new System.Drawing.Point(3, 223);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(185, 103);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelID.Location = new System.Drawing.Point(50, 337);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(48, 32);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID:";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.Transparent;
            this.ID.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.White;
            this.ID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ID.Location = new System.Drawing.Point(93, 340);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(146, 29);
            this.ID.TabIndex = 0;
            this.ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.BackColor = System.Drawing.Color.White;
            this.pictureBoxAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAvatar.ImageLocation = "";
            this.pictureBoxAvatar.InitialImage = null;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(66, 43);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(140, 180);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar.TabIndex = 7;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.Angle = 0F;
            this.gradientPanel4.BackColor = System.Drawing.Color.White;
            this.gradientPanel4.BottomColor = System.Drawing.Color.Transparent;
            this.gradientPanel4.Controls.Add(this.gradientPanel);
            this.gradientPanel4.Location = new System.Drawing.Point(24, 63);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(274, 420);
            this.gradientPanel4.TabIndex = 1;
            this.gradientPanel4.TopColor = System.Drawing.Color.Transparent;
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.gradientPanelStaff);
            this.Name = "FormStaff";
            this.gradientPanelStaff.ResumeLayout(false);
            this.gradientPanelStaff.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddr)).EndInit();
            this.gradientPanel.ResumeLayout(false);
            this.gradientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.gradientPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelStaff;
        private GradientPanel gradientPanel1;
        private PictureBox pictureBoxAddr;
        private Label Address;
        private PictureBox pictureBoxPhone;
        private PictureBox pictureBoxSex;
        private Label labelAddress;
        private PictureBox pictureBoxEmail;
        private Label Phone;
        private PictureBox pictureBoxDoB;
        private Label Email;
        private PictureBox pictureBoxPID;
        private Label labelEmail;
        private Label PID;
        private Label labelPhone;
        private Label labelPID;
        private Label labelBirthday;
        private Label Sex;
        private Label Birthday;
        private Label labelSex;
        private Label labelInfo;
        private GradientPanel gradientPanel4;
        private GradientPanel gradientPanel;
        private PictureBox pictureBoxAvatar;
        private Label ID;
        private Label labelID;
        private Label labelName;
    }
}