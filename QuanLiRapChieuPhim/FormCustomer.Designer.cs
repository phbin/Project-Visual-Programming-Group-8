
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.ListCustomerGrid = new System.Windows.Forms.DataGridView();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PhoneNumTextbox = new System.Windows.Forms.TextBox();
            this.PointLabel = new System.Windows.Forms.Label();
            this.PointTextbox = new System.Windows.Forms.TextBox();
            this.IDPersonalLabel = new System.Windows.Forms.Label();
            this.IDPersonalTextbox = new System.Windows.Forms.TextBox();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.AddressTextbox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextbox = new System.Windows.Forms.TextBox();
            this.DoBLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.FullNameTextbox = new System.Windows.Forms.TextBox();
            this.DoBTextbox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.CustomerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListCustomerGrid)).BeginInit();
            this.SearchPanel.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListCustomerGrid
            // 
            this.ListCustomerGrid.AllowUserToAddRows = false;
            this.ListCustomerGrid.AllowUserToDeleteRows = false;
            this.ListCustomerGrid.AllowUserToOrderColumns = true;
            this.ListCustomerGrid.AllowUserToResizeRows = false;
            this.ListCustomerGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListCustomerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListCustomerGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.ListCustomerGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListCustomerGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListCustomerGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListCustomerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListCustomerGrid.ColumnHeadersHeight = 25;
            this.ListCustomerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListCustomerGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ListCustomerGrid.EnableHeadersVisualStyles = false;
            this.ListCustomerGrid.GridColor = System.Drawing.SystemColors.HotTrack;
            this.ListCustomerGrid.Location = new System.Drawing.Point(11, 54);
            this.ListCustomerGrid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ListCustomerGrid.Name = "ListCustomerGrid";
            this.ListCustomerGrid.ReadOnly = true;
            this.ListCustomerGrid.RowHeadersVisible = false;
            this.ListCustomerGrid.RowHeadersWidth = 62;
            this.ListCustomerGrid.RowTemplate.Height = 28;
            this.ListCustomerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListCustomerGrid.Size = new System.Drawing.Size(442, 666);
            this.ListCustomerGrid.TabIndex = 28;
            this.ListCustomerGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListCustomerGrid_CellClick);
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.Transparent;
            this.SearchPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchPanel.BackgroundImage")));
            this.SearchPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchPanel.Controls.Add(this.SearchTextbox);
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.Location = new System.Drawing.Point(4, 15);
            this.SearchPanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(451, 30);
            this.SearchPanel.TabIndex = 33;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.SearchTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextbox.ForeColor = System.Drawing.Color.Gray;
            this.SearchTextbox.Location = new System.Drawing.Point(14, 6);
            this.SearchTextbox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SearchTextbox.Multiline = true;
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(400, 17);
            this.SearchTextbox.TabIndex = 33;
            this.SearchTextbox.Text = "Search";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.Location = new System.Drawing.Point(424, 0);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(27, 30);
            this.SearchButton.TabIndex = 32;
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.PhoneNumTextbox);
            this.pnlInfo.Controls.Add(this.PointLabel);
            this.pnlInfo.Controls.Add(this.PointTextbox);
            this.pnlInfo.Controls.Add(this.IDPersonalLabel);
            this.pnlInfo.Controls.Add(this.IDPersonalTextbox);
            this.pnlInfo.Controls.Add(this.AdressLabel);
            this.pnlInfo.Controls.Add(this.AddressTextbox);
            this.pnlInfo.Controls.Add(this.AddButton);
            this.pnlInfo.Controls.Add(this.IDLabel);
            this.pnlInfo.Controls.Add(this.IDTextbox);
            this.pnlInfo.Controls.Add(this.DoBLabel);
            this.pnlInfo.Controls.Add(this.FullNameLabel);
            this.pnlInfo.Controls.Add(this.FullNameTextbox);
            this.pnlInfo.Controls.Add(this.DoBTextbox);
            this.pnlInfo.Controls.Add(this.DeleteButton);
            this.pnlInfo.Controls.Add(this.EditButton);
            this.pnlInfo.Controls.Add(this.CustomerLabel);
            this.pnlInfo.Location = new System.Drawing.Point(462, 14);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(360, 564);
            this.pnlInfo.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(20, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 85;
            this.label2.Text = "Phone Number";
            // 
            // PhoneNumTextbox
            // 
            this.PhoneNumTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneNumTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumTextbox.Location = new System.Drawing.Point(129, 205);
            this.PhoneNumTextbox.Name = "PhoneNumTextbox";
            this.PhoneNumTextbox.Size = new System.Drawing.Size(190, 22);
            this.PhoneNumTextbox.TabIndex = 84;
            // 
            // PointLabel
            // 
            this.PointLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PointLabel.AutoSize = true;
            this.PointLabel.BackColor = System.Drawing.Color.Transparent;
            this.PointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.PointLabel.Location = new System.Drawing.Point(83, 274);
            this.PointLabel.Name = "PointLabel";
            this.PointLabel.Size = new System.Drawing.Size(40, 15);
            this.PointLabel.TabIndex = 83;
            this.PointLabel.Text = "Point";
            // 
            // PointTextbox
            // 
            this.PointTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PointTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointTextbox.Location = new System.Drawing.Point(129, 271);
            this.PointTextbox.Name = "PointTextbox";
            this.PointTextbox.Size = new System.Drawing.Size(190, 22);
            this.PointTextbox.TabIndex = 82;
            // 
            // IDPersonalLabel
            // 
            this.IDPersonalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IDPersonalLabel.AutoSize = true;
            this.IDPersonalLabel.BackColor = System.Drawing.Color.Transparent;
            this.IDPersonalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDPersonalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.IDPersonalLabel.Location = new System.Drawing.Point(47, 241);
            this.IDPersonalLabel.Name = "IDPersonalLabel";
            this.IDPersonalLabel.Size = new System.Drawing.Size(76, 15);
            this.IDPersonalLabel.TabIndex = 81;
            this.IDPersonalLabel.Text = "ID Number";
            // 
            // IDPersonalTextbox
            // 
            this.IDPersonalTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IDPersonalTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDPersonalTextbox.Location = new System.Drawing.Point(129, 238);
            this.IDPersonalTextbox.Name = "IDPersonalTextbox";
            this.IDPersonalTextbox.Size = new System.Drawing.Size(190, 22);
            this.IDPersonalTextbox.TabIndex = 73;
            // 
            // AdressLabel
            // 
            this.AdressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.AdressLabel.Location = new System.Drawing.Point(65, 175);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(58, 15);
            this.AdressLabel.TabIndex = 80;
            this.AdressLabel.Text = "Address";
            // 
            // AddressTextbox
            // 
            this.AddressTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTextbox.Location = new System.Drawing.Point(129, 172);
            this.AddressTextbox.Name = "AddressTextbox";
            this.AddressTextbox.Size = new System.Drawing.Size(190, 22);
            this.AddressTextbox.TabIndex = 72;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(86)))));
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Image = global::QuanLiRapChieuPhim.Properties.Resources.Add_01;
            this.AddButton.Location = new System.Drawing.Point(130, 314);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(101, 66);
            this.AddButton.TabIndex = 74;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IDLabel.AutoSize = true;
            this.IDLabel.BackColor = System.Drawing.Color.Transparent;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.IDLabel.Location = new System.Drawing.Point(100, 75);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(23, 16);
            this.IDLabel.TabIndex = 79;
            this.IDLabel.Text = "ID";
            // 
            // IDTextbox
            // 
            this.IDTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextbox.Location = new System.Drawing.Point(129, 72);
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.Size = new System.Drawing.Size(190, 22);
            this.IDTextbox.TabIndex = 69;
            // 
            // DoBLabel
            // 
            this.DoBLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DoBLabel.AutoSize = true;
            this.DoBLabel.BackColor = System.Drawing.Color.Transparent;
            this.DoBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoBLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.DoBLabel.Location = new System.Drawing.Point(64, 141);
            this.DoBLabel.Name = "DoBLabel";
            this.DoBLabel.Size = new System.Drawing.Size(59, 15);
            this.DoBLabel.TabIndex = 78;
            this.DoBLabel.Text = "Birthday";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.FullNameLabel.Location = new System.Drawing.Point(45, 108);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(78, 16);
            this.FullNameLabel.TabIndex = 77;
            this.FullNameLabel.Text = "Full Name";
            // 
            // FullNameTextbox
            // 
            this.FullNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameTextbox.Location = new System.Drawing.Point(129, 105);
            this.FullNameTextbox.Name = "FullNameTextbox";
            this.FullNameTextbox.Size = new System.Drawing.Size(190, 22);
            this.FullNameTextbox.TabIndex = 70;
            // 
            // DoBTextbox
            // 
            this.DoBTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DoBTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoBTextbox.Location = new System.Drawing.Point(129, 138);
            this.DoBTextbox.Name = "DoBTextbox";
            this.DoBTextbox.Size = new System.Drawing.Size(190, 22);
            this.DoBTextbox.TabIndex = 71;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(86)))));
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Image = global::QuanLiRapChieuPhim.Properties.Resources.Delete_01;
            this.DeleteButton.Location = new System.Drawing.Point(254, 317);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(98, 61);
            this.DeleteButton.TabIndex = 76;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.BackColor = System.Drawing.Color.Transparent;
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(86)))));
            this.EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Image = global::QuanLiRapChieuPhim.Properties.Resources.Edit_01;
            this.EditButton.Location = new System.Drawing.Point(8, 319);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.EditButton.Name = "EditButton";
            this.EditButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.EditButton.Size = new System.Drawing.Size(98, 61);
            this.EditButton.TabIndex = 75;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Nirmala UI", 19.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLabel.ForeColor = System.Drawing.Color.White;
            this.CustomerLabel.Location = new System.Drawing.Point(9, 7);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(342, 37);
            this.CustomerLabel.TabIndex = 68;
            this.CustomerLabel.Text = "CUSTOMER INFOMATION";
            this.CustomerLabel.Click += new System.EventHandler(this.CustomerLabel_Click);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(833, 590);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.ListCustomerGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.ListCustomerGrid)).EndInit();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.DataGridView ListCustomerGrid;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PhoneNumTextbox;
        private System.Windows.Forms.Label PointLabel;
        private System.Windows.Forms.TextBox PointTextbox;
        private System.Windows.Forms.Label IDPersonalLabel;
        private System.Windows.Forms.TextBox IDPersonalTextbox;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.TextBox AddressTextbox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDTextbox;
        private System.Windows.Forms.Label DoBLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox FullNameTextbox;
        private System.Windows.Forms.TextBox DoBTextbox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label CustomerLabel;
    }
}