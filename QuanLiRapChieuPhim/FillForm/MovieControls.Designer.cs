
namespace QuanLiRapChieuPhim
{
    partial class MovieControls
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
            this.labelLine = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonLoadImg = new System.Windows.Forms.Button();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.lbPoster = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.lbGenre = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpExpiry = new System.Windows.Forms.DateTimePicker();
            this.dtpRelease = new System.Windows.Forms.DateTimePicker();
            this.labelInfo = new System.Windows.Forms.Label();
            this.clGenre = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLine
            // 
            this.labelLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLine.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLine.ForeColor = System.Drawing.Color.White;
            this.labelLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLine.Location = new System.Drawing.Point(0, 0);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(1124, 68);
            this.labelLine.TabIndex = 0;
            this.labelLine.Text = "      Add Movie";
            this.labelLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Controls.Add(this.buttonLoadImg);
            this.panel1.Controls.Add(this.picPoster);
            this.panel1.Controls.Add(this.lbPoster);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.cbCountry);
            this.panel1.Controls.Add(this.lbGenre);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.txtDir);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.dtpExpiry);
            this.panel1.Controls.Add(this.dtpRelease);
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Controls.Add(this.clGenre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 783);
            this.panel1.TabIndex = 2;
            // 
            // buttonEdit
            // 
            this.buttonEdit.AutoSize = true;
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(396, 714);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(148, 40);
            this.buttonEdit.TabIndex = 20;
            this.buttonEdit.Text = "Update";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(261, 110);
            this.txtTime.MaxLength = 3;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(312, 34);
            this.txtTime.TabIndex = 19;
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(732, 43);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(312, 34);
            this.txtID.TabIndex = 18;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(595, 38);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(50, 38);
            this.lbID.TabIndex = 17;
            this.lbID.Text = "ID:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(602, 714);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(148, 40);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.AutoSize = true;
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(396, 714);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(148, 40);
            this.buttonOK.TabIndex = 15;
            this.buttonOK.Text = "Confirm";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonLoadImg
            // 
            this.buttonLoadImg.AutoSize = true;
            this.buttonLoadImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.buttonLoadImg.FlatAppearance.BorderSize = 0;
            this.buttonLoadImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadImg.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadImg.ForeColor = System.Drawing.Color.White;
            this.buttonLoadImg.Location = new System.Drawing.Point(822, 597);
            this.buttonLoadImg.Name = "buttonLoadImg";
            this.buttonLoadImg.Size = new System.Drawing.Size(150, 40);
            this.buttonLoadImg.TabIndex = 14;
            this.buttonLoadImg.Text = "Upload Image";
            this.buttonLoadImg.UseVisualStyleBackColor = false;
            this.buttonLoadImg.Click += new System.EventHandler(this.buttonLoadImg_Click);
            // 
            // picPoster
            // 
            this.picPoster.BackColor = System.Drawing.Color.White;
            this.picPoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPoster.Location = new System.Drawing.Point(737, 246);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(307, 334);
            this.picPoster.TabIndex = 13;
            this.picPoster.TabStop = false;
            // 
            // lbPoster
            // 
            this.lbPoster.AutoSize = true;
            this.lbPoster.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoster.Location = new System.Drawing.Point(596, 243);
            this.lbPoster.Name = "lbPoster";
            this.lbPoster.Size = new System.Drawing.Size(86, 32);
            this.lbPoster.TabIndex = 12;
            this.lbPoster.Text = "Poster:";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(261, 500);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(312, 179);
            this.txtDesc.TabIndex = 11;
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Items.AddRange(new object[] {
            "Ấn Độ",
            "Anh",
            "Áo",
            "Ba Lan",
            "Bồ Đào Nha",
            "Campuchia",
            "Đài Loan",
            "Đan Mạch",
            "Đức",
            "Hà Lan",
            "Hàn Quốc",
            "Indonesia",
            "Malaysia",
            "Mông Cổ",
            "Na Uy",
            "Nga",
            "Nhật Bản",
            "Pháp",
            "Pháp",
            "Philippines",
            "Singapore",
            "Tây Ban Nha",
            "Thái Lan",
            "Thuỵ Điển",
            "Thuỵ Sĩ",
            "Triều Tiên",
            "Trung Quốc",
            "Ukraine",
            "Vatican",
            "Việt Nam"});
            this.cbCountry.Location = new System.Drawing.Point(261, 368);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(312, 36);
            this.cbCountry.Sorted = true;
            this.cbCountry.TabIndex = 10;
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenre.Location = new System.Drawing.Point(595, 110);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(98, 38);
            this.lbGenre.TabIndex = 8;
            this.lbGenre.Text = "Genre:";
            // 
            // txtYear
            // 
            this.txtYear.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtYear.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(261, 435);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(312, 34);
            this.txtYear.TabIndex = 7;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            // 
            // txtDir
            // 
            this.txtDir.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDir.Location = new System.Drawing.Point(261, 303);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(312, 34);
            this.txtDir.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(261, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(312, 34);
            this.txtName.TabIndex = 4;
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiry.Location = new System.Drawing.Point(261, 238);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.Size = new System.Drawing.Size(312, 34);
            this.dtpExpiry.TabIndex = 3;
            this.dtpExpiry.Value = new System.DateTime(2021, 12, 5, 0, 0, 0, 0);
            // 
            // dtpRelease
            // 
            this.dtpRelease.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpRelease.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRelease.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRelease.Location = new System.Drawing.Point(261, 173);
            this.dtpRelease.Name = "dtpRelease";
            this.dtpRelease.Size = new System.Drawing.Size(312, 34);
            this.dtpRelease.TabIndex = 2;
            this.dtpRelease.Value = new System.DateTime(2021, 12, 5, 0, 0, 0, 0);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(87, 43);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(170, 480);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Name: \r\n\r\nRunning Time:\r\n\r\nRelease Date:\r\n\r\nExpiry Date:\r\n\r\nDirector:\r\n\r\nCountry:" +
    "\r\n\r\nYear:\r\n\r\nDescription:";
            // 
            // clGenre
            // 
            this.clGenre.CheckOnClick = true;
            this.clGenre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clGenre.FormattingEnabled = true;
            this.clGenre.Items.AddRange(new object[] {
            "Hành động",
            "Hoạt hình",
            "Hài kịch",
            "Khoa học viễn tưởng",
            "Phiêu lưu",
            "Gia đình",
            "Tình cảm",
            "Trinh thám",
            "Tâm lý",
            "Siêu nhiên"});
            this.clGenre.Location = new System.Drawing.Point(737, 110);
            this.clGenre.Name = "clGenre";
            this.clGenre.Size = new System.Drawing.Size(307, 104);
            this.clGenre.TabIndex = 0;
            this.clGenre.ThreeDCheckBoxes = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 8);
            this.panel2.TabIndex = 3;
            // 
            // MovieControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1124, 851);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovieControls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMovie";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.CheckedListBox clGenre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonLoadImg;
        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.Label lbPoster;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpExpiry;
        private System.Windows.Forms.DateTimePicker dtpRelease;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button buttonEdit;
    }
}