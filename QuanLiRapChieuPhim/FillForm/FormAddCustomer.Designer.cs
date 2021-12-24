namespace QuanLiRapChieuPhim.ChildForms
{
    partial class FormAddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCustomer));
            this.CustomerInfoLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PhoneTextbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FullNameTextbox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.PointTextbox = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.AddressTextbox = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.IDPersonalTextbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IDTextbox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerInfoLabel
            // 
            this.CustomerInfoLabel.AutoSize = true;
            this.CustomerInfoLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerInfoLabel.ForeColor = System.Drawing.Color.White;
            this.CustomerInfoLabel.Location = new System.Drawing.Point(281, 22);
            this.CustomerInfoLabel.Name = "CustomerInfoLabel";
            this.CustomerInfoLabel.Size = new System.Drawing.Size(378, 46);
            this.CustomerInfoLabel.TabIndex = 62;
            this.CustomerInfoLabel.Text = "Customer Infomation";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.panel5.Controls.Add(this.PhoneTextbox);
            this.panel5.Location = new System.Drawing.Point(492, 92);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(321, 46);
            this.panel5.TabIndex = 3;
            // 
            // PhoneTextbox
            // 
            this.PhoneTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.PhoneTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneTextbox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.PhoneTextbox.Location = new System.Drawing.Point(11, 12);
            this.PhoneTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneTextbox.Name = "PhoneTextbox";
            this.PhoneTextbox.Size = new System.Drawing.Size(270, 24);
            this.PhoneTextbox.TabIndex = 3;
            this.PhoneTextbox.Text = "Phone Number";
            this.PhoneTextbox.Enter += new System.EventHandler(this.PhoneTextbox_Enter);
            this.PhoneTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTextbox_KeyPress);
            this.PhoneTextbox.Leave += new System.EventHandler(this.PhoneTextbox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.FullNameTextbox);
            this.panel1.Location = new System.Drawing.Point(84, 159);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 46);
            this.panel1.TabIndex = 0;
            // 
            // FullNameTextbox
            // 
            this.FullNameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.FullNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FullNameTextbox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.FullNameTextbox.Location = new System.Drawing.Point(11, 12);
            this.FullNameTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FullNameTextbox.Name = "FullNameTextbox";
            this.FullNameTextbox.Size = new System.Drawing.Size(270, 24);
            this.FullNameTextbox.TabIndex = 0;
            this.FullNameTextbox.Text = "Full Name";
            this.FullNameTextbox.Enter += new System.EventHandler(this.FullNameTextbox_Enter);
            this.FullNameTextbox.Leave += new System.EventHandler(this.FullNameTextbox_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.panel6.Controls.Add(this.PointTextbox);
            this.panel6.Location = new System.Drawing.Point(492, 226);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(321, 46);
            this.panel6.TabIndex = 5;
            // 
            // PointTextbox
            // 
            this.PointTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.PointTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PointTextbox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointTextbox.ForeColor = System.Drawing.Color.White;
            this.PointTextbox.Location = new System.Drawing.Point(11, 11);
            this.PointTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PointTextbox.Name = "PointTextbox";
            this.PointTextbox.Size = new System.Drawing.Size(250, 24);
            this.PointTextbox.TabIndex = 5;
            this.PointTextbox.Text = "0";
            this.PointTextbox.Enter += new System.EventHandler(this.PointTextbox_Enter);
            this.PointTextbox.Leave += new System.EventHandler(this.PointTextbox_Leave);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.panel7.Controls.Add(this.AddressTextbox);
            this.panel7.Location = new System.Drawing.Point(84, 294);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(321, 46);
            this.panel7.TabIndex = 2;
            // 
            // AddressTextbox
            // 
            this.AddressTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.AddressTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressTextbox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.AddressTextbox.Location = new System.Drawing.Point(11, 12);
            this.AddressTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddressTextbox.Name = "AddressTextbox";
            this.AddressTextbox.Size = new System.Drawing.Size(270, 24);
            this.AddressTextbox.TabIndex = 2;
            this.AddressTextbox.Text = "Address";
            this.AddressTextbox.Enter += new System.EventHandler(this.AddressTextbox_Enter);
            this.AddressTextbox.Leave += new System.EventHandler(this.AddressTextbox_Leave);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.panel8.Controls.Add(this.IDPersonalTextbox);
            this.panel8.Location = new System.Drawing.Point(492, 159);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(321, 46);
            this.panel8.TabIndex = 4;
            // 
            // IDPersonalTextbox
            // 
            this.IDPersonalTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.IDPersonalTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDPersonalTextbox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDPersonalTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.IDPersonalTextbox.Location = new System.Drawing.Point(11, 11);
            this.IDPersonalTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDPersonalTextbox.Name = "IDPersonalTextbox";
            this.IDPersonalTextbox.Size = new System.Drawing.Size(270, 24);
            this.IDPersonalTextbox.TabIndex = 4;
            this.IDPersonalTextbox.Text = "Personal ID";
            this.IDPersonalTextbox.Enter += new System.EventHandler(this.IDPersonalTextbox_Enter);
            this.IDPersonalTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDPersonalTextbox_KeyPress);
            this.IDPersonalTextbox.Leave += new System.EventHandler(this.IDPersonalTextbox_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.IDTextbox);
            this.panel2.Location = new System.Drawing.Point(84, 92);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 46);
            this.panel2.TabIndex = 53;
            // 
            // IDTextbox
            // 
            this.IDTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.IDTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDTextbox.Enabled = false;
            this.IDTextbox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.IDTextbox.Location = new System.Drawing.Point(11, 12);
            this.IDTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.ReadOnly = true;
            this.IDTextbox.Size = new System.Drawing.Size(270, 24);
            this.IDTextbox.TabIndex = 1;
            this.IDTextbox.Text = "ID";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(370, 378);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(151, 37);
            this.AddButton.TabIndex = 58;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            this.AddButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddButton_MouseMove);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(370, 378);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(151, 37);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            this.EditButton.MouseLeave += new System.EventHandler(this.EditButton_MouseLeave);
            this.EditButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EditButton_MouseMove);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.buttonClose.BackgroundImage = global::QuanLiRapChieuPhim.Properties.Resources.close;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(894, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Padding = new System.Windows.Forms.Padding(0, 0, 3, 1);
            this.buttonClose.Size = new System.Drawing.Size(44, 40);
            this.buttonClose.TabIndex = 70;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(81, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 72;
            this.label2.Text = "Birthday";
            // 
            // txtDOB
            // 
            this.txtDOB.CalendarForeColor = System.Drawing.Color.Black;
            this.txtDOB.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.txtDOB.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDOB.Location = new System.Drawing.Point(84, 241);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(321, 31);
            this.txtDOB.TabIndex = 1;
            this.txtDOB.Value = new System.DateTime(2021, 12, 5, 0, 0, 0, 0);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(943, 438);
            this.panel3.TabIndex = 73;
            // 
            // FormAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(943, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CustomerInfoLabel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddCustomer";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CustomerInfoLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox PhoneTextbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox FullNameTextbox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox PointTextbox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox AddressTextbox;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox IDPersonalTextbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox IDTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtDOB;
        private System.Windows.Forms.Panel panel3;
    }
}