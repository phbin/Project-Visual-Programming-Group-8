namespace QuanLiRapChieuPhim.ChildForms
{
    partial class FormAddEditFD
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
            this.UploadButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IDTextbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IDCategoryTextbox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NameFDTextbox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PriceTextbox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(91, 417);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(152, 39);
            this.UploadButton.TabIndex = 1;
            this.UploadButton.Text = "Upload Image";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.IDTextbox);
            this.panel2.Location = new System.Drawing.Point(392, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 58);
            this.panel2.TabIndex = 2;
            // 
            // IDTextbox
            // 
            this.IDTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.IDTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.IDTextbox.Location = new System.Drawing.Point(12, 15);
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.ReadOnly = true;
            this.IDTextbox.Size = new System.Drawing.Size(346, 28);
            this.IDTextbox.TabIndex = 1;
            this.IDTextbox.Text = "ID";
            this.IDTextbox.Enter += new System.EventHandler(this.IDTextbox_Enter);
            this.IDTextbox.Leave += new System.EventHandler(this.IDTextbox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.IDCategoryTextbox);
            this.panel1.Location = new System.Drawing.Point(392, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 58);
            this.panel1.TabIndex = 3;
            // 
            // IDCategoryTextbox
            // 
            this.IDCategoryTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.IDCategoryTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDCategoryTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDCategoryTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.IDCategoryTextbox.Location = new System.Drawing.Point(12, 15);
            this.IDCategoryTextbox.Name = "IDCategoryTextbox";
            this.IDCategoryTextbox.Size = new System.Drawing.Size(346, 28);
            this.IDCategoryTextbox.TabIndex = 1;
            this.IDCategoryTextbox.Text = "Category ID";
            this.IDCategoryTextbox.Enter += new System.EventHandler(this.IDCategoryTextbox_Enter);
            this.IDCategoryTextbox.Leave += new System.EventHandler(this.IDCategoryTextbox_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.NameFDTextbox);
            this.panel3.Location = new System.Drawing.Point(392, 296);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 58);
            this.panel3.TabIndex = 4;
            // 
            // NameFDTextbox
            // 
            this.NameFDTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.NameFDTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameFDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameFDTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.NameFDTextbox.Location = new System.Drawing.Point(12, 15);
            this.NameFDTextbox.Name = "NameFDTextbox";
            this.NameFDTextbox.Size = new System.Drawing.Size(346, 28);
            this.NameFDTextbox.TabIndex = 1;
            this.NameFDTextbox.Text = "Name";
            this.NameFDTextbox.Enter += new System.EventHandler(this.NameFDTextbox_Enter);
            this.NameFDTextbox.Leave += new System.EventHandler(this.NameFDTextbox_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.panel4.Controls.Add(this.PriceTextbox);
            this.panel4.Location = new System.Drawing.Point(392, 382);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(361, 58);
            this.panel4.TabIndex = 5;
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.PriceTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.PriceTextbox.Location = new System.Drawing.Point(12, 15);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.Size = new System.Drawing.Size(346, 28);
            this.PriceTextbox.TabIndex = 1;
            this.PriceTextbox.Text = "Price";
            this.PriceTextbox.Enter += new System.EventHandler(this.PriceTextbox_Enter);
            this.PriceTextbox.Leave += new System.EventHandler(this.PriceTextbox_Leave);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(259, 512);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(279, 46);
            this.AddButton.TabIndex = 59;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::QuanLiRapChieuPhim.Properties.Resources.close;
            this.buttonClose.Location = new System.Drawing.Point(779, 5);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Padding = new System.Windows.Forms.Padding(0, 0, 3, 1);
            this.buttonClose.Size = new System.Drawing.Size(50, 50);
            this.buttonClose.TabIndex = 61;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(42, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 284);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(259, 512);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(279, 46);
            this.EditButton.TabIndex = 62;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // FormAddEditFD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(835, 588);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddEditFD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddEditFD";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox IDTextbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox IDCategoryTextbox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox NameFDTextbox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox PriceTextbox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button EditButton;
    }
}