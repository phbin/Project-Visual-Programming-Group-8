namespace QuanLiRapChieuPhim
{
    partial class FormHRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHRM));
            this.InfoStaffGridView = new System.Windows.Forms.DataGridView();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextbox = new System.Windows.Forms.TextBox();
            this.HRMLabel = new System.Windows.Forms.Label();
            this.DoBLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.FullNameTextbox = new System.Windows.Forms.TextBox();
            this.DoBTextbox = new System.Windows.Forms.TextBox();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.AddressTextbox = new System.Windows.Forms.TextBox();
            this.PhoneNumLabel = new System.Windows.Forms.Label();
            this.PhoneNumTextbox = new System.Windows.Forms.TextBox();
            this.IDPersonalTextbox = new System.Windows.Forms.TextBox();
            this.IDPersonalLabel = new System.Windows.Forms.Label();
            this.MaleCheckbox = new System.Windows.Forms.CheckBox();
            this.FemaleCheckbox = new System.Windows.Forms.CheckBox();
            this.SexLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.InfoStaffGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoStaffGridView
            // 
            this.InfoStaffGridView.AllowUserToAddRows = false;
            this.InfoStaffGridView.AllowUserToDeleteRows = false;
            this.InfoStaffGridView.AllowUserToOrderColumns = true;
            this.InfoStaffGridView.AllowUserToResizeRows = false;
            this.InfoStaffGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.InfoStaffGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoStaffGridView.ColumnHeadersHeight = 30;
            this.InfoStaffGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.InfoStaffGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoStaffGridView.Location = new System.Drawing.Point(0, 0);
            this.InfoStaffGridView.Name = "InfoStaffGridView";
            this.InfoStaffGridView.ReadOnly = true;
            this.InfoStaffGridView.RowHeadersVisible = false;
            this.InfoStaffGridView.RowHeadersWidth = 62;
            this.InfoStaffGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.InfoStaffGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InfoStaffGridView.Size = new System.Drawing.Size(422, 369);
            this.InfoStaffGridView.TabIndex = 0;
            this.InfoStaffGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InfoStaffGridView_CellClick);
            // 
            // IDLabel
            // 
            this.IDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IDLabel.AutoSize = true;
            this.IDLabel.BackColor = System.Drawing.Color.Transparent;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.IDLabel.Location = new System.Drawing.Point(550, 58);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(23, 16);
            this.IDLabel.TabIndex = 39;
            this.IDLabel.Text = "ID";
            // 
            // IDTextbox
            // 
            this.IDTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextbox.Location = new System.Drawing.Point(586, 58);
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.Size = new System.Drawing.Size(240, 22);
            this.IDTextbox.TabIndex = 1;
            // 
            // HRMLabel
            // 
            this.HRMLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HRMLabel.AutoSize = true;
            this.HRMLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRMLabel.ForeColor = System.Drawing.Color.White;
            this.HRMLabel.Location = new System.Drawing.Point(493, 13);
            this.HRMLabel.Name = "HRMLabel";
            this.HRMLabel.Size = new System.Drawing.Size(294, 25);
            this.HRMLabel.TabIndex = 36;
            this.HRMLabel.Text = "Human Resources Management";
            // 
            // DoBLabel
            // 
            this.DoBLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DoBLabel.AutoSize = true;
            this.DoBLabel.BackColor = System.Drawing.Color.Transparent;
            this.DoBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoBLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.DoBLabel.Location = new System.Drawing.Point(514, 116);
            this.DoBLabel.Name = "DoBLabel";
            this.DoBLabel.Size = new System.Drawing.Size(59, 15);
            this.DoBLabel.TabIndex = 34;
            this.DoBLabel.Text = "Birthday";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.FullNameLabel.Location = new System.Drawing.Point(495, 87);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(78, 16);
            this.FullNameLabel.TabIndex = 33;
            this.FullNameLabel.Text = "Full Name";
            // 
            // FullNameTextbox
            // 
            this.FullNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameTextbox.Location = new System.Drawing.Point(586, 86);
            this.FullNameTextbox.Name = "FullNameTextbox";
            this.FullNameTextbox.Size = new System.Drawing.Size(240, 22);
            this.FullNameTextbox.TabIndex = 2;
            // 
            // DoBTextbox
            // 
            this.DoBTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DoBTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoBTextbox.Location = new System.Drawing.Point(587, 113);
            this.DoBTextbox.Name = "DoBTextbox";
            this.DoBTextbox.Size = new System.Drawing.Size(240, 22);
            this.DoBTextbox.TabIndex = 3;
            // 
            // AdressLabel
            // 
            this.AdressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.AdressLabel.Location = new System.Drawing.Point(523, 145);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(50, 15);
            this.AdressLabel.TabIndex = 41;
            this.AdressLabel.Text = "Adress";
            // 
            // AddressTextbox
            // 
            this.AddressTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTextbox.Location = new System.Drawing.Point(586, 142);
            this.AddressTextbox.Name = "AddressTextbox";
            this.AddressTextbox.Size = new System.Drawing.Size(240, 22);
            this.AddressTextbox.TabIndex = 4;
            // 
            // PhoneNumLabel
            // 
            this.PhoneNumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneNumLabel.AutoSize = true;
            this.PhoneNumLabel.BackColor = System.Drawing.Color.Transparent;
            this.PhoneNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.PhoneNumLabel.Location = new System.Drawing.Point(470, 199);
            this.PhoneNumLabel.Name = "PhoneNumLabel";
            this.PhoneNumLabel.Size = new System.Drawing.Size(103, 15);
            this.PhoneNumLabel.TabIndex = 42;
            this.PhoneNumLabel.Text = "Phone Number";
            // 
            // PhoneNumTextbox
            // 
            this.PhoneNumTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneNumTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumTextbox.Location = new System.Drawing.Point(586, 196);
            this.PhoneNumTextbox.Name = "PhoneNumTextbox";
            this.PhoneNumTextbox.Size = new System.Drawing.Size(240, 22);
            this.PhoneNumTextbox.TabIndex = 7;
            // 
            // IDPersonalTextbox
            // 
            this.IDPersonalTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IDPersonalTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDPersonalTextbox.Location = new System.Drawing.Point(586, 252);
            this.IDPersonalTextbox.Name = "IDPersonalTextbox";
            this.IDPersonalTextbox.Size = new System.Drawing.Size(240, 22);
            this.IDPersonalTextbox.TabIndex = 9;
            // 
            // IDPersonalLabel
            // 
            this.IDPersonalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IDPersonalLabel.AutoSize = true;
            this.IDPersonalLabel.BackColor = System.Drawing.Color.Transparent;
            this.IDPersonalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDPersonalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.IDPersonalLabel.Location = new System.Drawing.Point(491, 255);
            this.IDPersonalLabel.Name = "IDPersonalLabel";
            this.IDPersonalLabel.Size = new System.Drawing.Size(82, 15);
            this.IDPersonalLabel.TabIndex = 45;
            this.IDPersonalLabel.Text = "ID Personal";
            // 
            // MaleCheckbox
            // 
            this.MaleCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaleCheckbox.AutoSize = true;
            this.MaleCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.MaleCheckbox.Location = new System.Drawing.Point(585, 170);
            this.MaleCheckbox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaleCheckbox.Name = "MaleCheckbox";
            this.MaleCheckbox.Size = new System.Drawing.Size(58, 19);
            this.MaleCheckbox.TabIndex = 5;
            this.MaleCheckbox.Text = "Male";
            this.MaleCheckbox.UseVisualStyleBackColor = true;
            // 
            // FemaleCheckbox
            // 
            this.FemaleCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FemaleCheckbox.AutoSize = true;
            this.FemaleCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.FemaleCheckbox.Location = new System.Drawing.Point(649, 170);
            this.FemaleCheckbox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.FemaleCheckbox.Name = "FemaleCheckbox";
            this.FemaleCheckbox.Size = new System.Drawing.Size(74, 19);
            this.FemaleCheckbox.TabIndex = 6;
            this.FemaleCheckbox.Text = "Female";
            this.FemaleCheckbox.UseVisualStyleBackColor = true;
            // 
            // SexLabel
            // 
            this.SexLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SexLabel.AutoSize = true;
            this.SexLabel.BackColor = System.Drawing.Color.Transparent;
            this.SexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.SexLabel.Location = new System.Drawing.Point(542, 171);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(31, 15);
            this.SexLabel.TabIndex = 48;
            this.SexLabel.Text = "Sex";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.EmailLabel.Location = new System.Drawing.Point(529, 227);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(44, 15);
            this.EmailLabel.TabIndex = 50;
            this.EmailLabel.Text = "Email";
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextbox.Location = new System.Drawing.Point(586, 224);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(240, 22);
            this.EmailTextbox.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.InfoStaffGridView);
            this.panel2.Location = new System.Drawing.Point(7, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 369);
            this.panel2.TabIndex = 52;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Image = global::QuanLiRapChieuPhim.Properties.Resources.Add_01;
            this.AddButton.Location = new System.Drawing.Point(600, 298);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(101, 66);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddButton_MouseMove);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Image = global::QuanLiRapChieuPhim.Properties.Resources.Delete_01;
            this.DeleteButton.Location = new System.Drawing.Point(729, 301);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(98, 61);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            this.DeleteButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeleteButton_MouseMove);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.BackColor = System.Drawing.Color.Transparent;
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Image = global::QuanLiRapChieuPhim.Properties.Resources.Edit_01;
            this.EditButton.Location = new System.Drawing.Point(473, 301);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(98, 61);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            this.EditButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EditButton_MouseMove);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.Location = new System.Drawing.Point(269, 9);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(24, 21);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.Transparent;
            this.SearchPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchPanel.BackgroundImage")));
            this.SearchPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchPanel.Controls.Add(this.SearchTextbox);
            this.SearchPanel.Location = new System.Drawing.Point(7, 9);
            this.SearchPanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(275, 24);
            this.SearchPanel.TabIndex = 8;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.SearchTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextbox.ForeColor = System.Drawing.Color.Gray;
            this.SearchTextbox.Location = new System.Drawing.Point(11, 5);
            this.SearchTextbox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SearchTextbox.Multiline = true;
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(240, 14);
            this.SearchTextbox.TabIndex = 15;
            this.SearchTextbox.Text = "Search";
            this.SearchTextbox.TextChanged += new System.EventHandler(this.SearchTextbox_TextChanged_1);
            this.SearchTextbox.Enter += new System.EventHandler(this.SearchTextbox_Enter_1);
            this.SearchTextbox.Leave += new System.EventHandler(this.SearchTextbox_Leave_1);
            // 
            // FormHRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(838, 420);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.FemaleCheckbox);
            this.Controls.Add(this.MaleCheckbox);
            this.Controls.Add(this.IDPersonalLabel);
            this.Controls.Add(this.IDPersonalTextbox);
            this.Controls.Add(this.PhoneNumTextbox);
            this.Controls.Add(this.PhoneNumLabel);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.AddressTextbox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.IDTextbox);
            this.Controls.Add(this.HRMLabel);
            this.Controls.Add(this.DoBLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.FullNameTextbox);
            this.Controls.Add(this.DoBTextbox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.panel2);
            this.Name = "FormHRM";
            this.Text = "FormHRM";
            this.Click += new System.EventHandler(this.FormHRM_Click_1);
            ((System.ComponentModel.ISupportInitialize)(this.InfoStaffGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InfoStaffGridView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDTextbox;
        private System.Windows.Forms.Label HRMLabel;
        private System.Windows.Forms.Label DoBLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox FullNameTextbox;
        private System.Windows.Forms.TextBox DoBTextbox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.TextBox AddressTextbox;
        private System.Windows.Forms.Label PhoneNumLabel;
        private System.Windows.Forms.TextBox PhoneNumTextbox;
        private System.Windows.Forms.TextBox IDPersonalTextbox;
        private System.Windows.Forms.Label IDPersonalLabel;
        private System.Windows.Forms.CheckBox MaleCheckbox;
        private System.Windows.Forms.CheckBox FemaleCheckbox;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.Panel panel2;
    }
}