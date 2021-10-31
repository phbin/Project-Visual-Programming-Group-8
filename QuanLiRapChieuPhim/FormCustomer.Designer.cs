
namespace QuanLiRapChieuPhim
{
    partial class FormCustomer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SearchTextbox = new QuanLiRapChieuPhim.GradientPanel();
            this.CustomerGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.TradingButton = new System.Windows.Forms.Button();
            this.PointTextbox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.PhoneNumTextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.IDTextbox = new System.Windows.Forms.TextBox();
            this.PointLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.UserPicbox = new System.Windows.Forms.PictureBox();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.SearchTextbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "customer.png");
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextbox.Angle = 90F;
            this.SearchTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.SearchTextbox.BottomColor = System.Drawing.Color.Transparent;
            this.SearchTextbox.Controls.Add(this.CustomerGridView);
            this.SearchTextbox.Controls.Add(this.panel1);
            this.SearchTextbox.Controls.Add(this.Searchtxt);
            this.SearchTextbox.Location = new System.Drawing.Point(0, 0);
            this.SearchTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(900, 562);
            this.SearchTextbox.TabIndex = 2;
            this.SearchTextbox.TopColor = System.Drawing.Color.Empty;
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridView.Location = new System.Drawing.Point(30, 101);
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.RowHeadersWidth = 62;
            this.CustomerGridView.RowTemplate.Height = 28;
            this.CustomerGridView.Size = new System.Drawing.Size(512, 449);
            this.CustomerGridView.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.TradingButton);
            this.panel1.Controls.Add(this.PointTextbox);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.PhoneNumTextbox);
            this.panel1.Controls.Add(this.NameTextbox);
            this.panel1.Controls.Add(this.IDTextbox);
            this.panel1.Controls.Add(this.PointLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.IDLabel);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.UserPicbox);
            this.panel1.Location = new System.Drawing.Point(458, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 449);
            this.panel1.TabIndex = 3;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.Silver;
            this.DeleteButton.Location = new System.Drawing.Point(341, 323);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(62, 35);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // TradingButton
            // 
            this.TradingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TradingButton.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TradingButton.ForeColor = System.Drawing.Color.Silver;
            this.TradingButton.Location = new System.Drawing.Point(168, 323);
            this.TradingButton.Name = "TradingButton";
            this.TradingButton.Size = new System.Drawing.Size(67, 35);
            this.TradingButton.TabIndex = 9;
            this.TradingButton.Text = "Đổi Điểm";
            this.TradingButton.UseVisualStyleBackColor = true;
            // 
            // PointTextbox
            // 
            this.PointTextbox.Location = new System.Drawing.Point(227, 274);
            this.PointTextbox.Name = "PointTextbox";
            this.PointTextbox.Size = new System.Drawing.Size(176, 26);
            this.PointTextbox.TabIndex = 8;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.Silver;
            this.AddButton.Location = new System.Drawing.Point(251, 323);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(72, 35);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Thêm/Sửa";
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // PhoneNumTextbox
            // 
            this.PhoneNumTextbox.Location = new System.Drawing.Point(227, 223);
            this.PhoneNumTextbox.Name = "PhoneNumTextbox";
            this.PhoneNumTextbox.Size = new System.Drawing.Size(176, 26);
            this.PhoneNumTextbox.TabIndex = 7;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(227, 170);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(176, 26);
            this.NameTextbox.TabIndex = 6;
            // 
            // IDTextbox
            // 
            this.IDTextbox.Location = new System.Drawing.Point(227, 119);
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.Size = new System.Drawing.Size(176, 26);
            this.IDTextbox.TabIndex = 5;
            // 
            // PointLabel
            // 
            this.PointLabel.AutoSize = true;
            this.PointLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointLabel.ForeColor = System.Drawing.Color.White;
            this.PointLabel.Location = new System.Drawing.Point(163, 276);
            this.PointLabel.Name = "PointLabel";
            this.PointLabel.Size = new System.Drawing.Size(58, 25);
            this.PointLabel.TabIndex = 4;
            this.PointLabel.Text = "Điểm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số điện thoại:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.ForeColor = System.Drawing.Color.White;
            this.IDLabel.Location = new System.Drawing.Point(185, 121);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(36, 25);
            this.IDLabel.TabIndex = 2;
            this.IDLabel.Text = "ID:";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(144, 169);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(77, 25);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Họ Tên:";
            // 
            // UserPicbox
            // 
            this.UserPicbox.ErrorImage = null;
            this.UserPicbox.Image = global::QuanLiRapChieuPhim.Properties.Resources.customer;
            this.UserPicbox.InitialImage = global::QuanLiRapChieuPhim.Properties.Resources.customer;
            this.UserPicbox.Location = new System.Drawing.Point(283, 66);
            this.UserPicbox.Name = "UserPicbox";
            this.UserPicbox.Size = new System.Drawing.Size(40, 47);
            this.UserPicbox.TabIndex = 0;
            this.UserPicbox.TabStop = false;
            // 
            // Searchtxt
            // 
            this.Searchtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.Searchtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Searchtxt.ForeColor = System.Drawing.Color.Silver;
            this.Searchtxt.Location = new System.Drawing.Point(30, 27);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(201, 26);
            this.Searchtxt.TabIndex = 0;
            this.Searchtxt.Text = "Search";
            this.Searchtxt.Enter += new System.EventHandler(this.Searchtxt_Enter);
            this.Searchtxt.Leave += new System.EventHandler(this.Searchtxt_Leave);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.SearchTextbox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.SearchTextbox.ResumeLayout(false);
            this.SearchTextbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel SearchTextbox;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TradingButton;
        private System.Windows.Forms.TextBox PointTextbox;
        private System.Windows.Forms.TextBox PhoneNumTextbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox IDTextbox;
        private System.Windows.Forms.Label PointLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox UserPicbox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridView CustomerGridView;
    }
}