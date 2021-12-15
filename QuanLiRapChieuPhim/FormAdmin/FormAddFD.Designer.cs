namespace QuanLiRapChieuPhim
{
    partial class FormAddFD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddFD));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FDDataGridview = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameFD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.FoodDrinkButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CategoryButton = new System.Windows.Forms.Button();
            this.CategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.AddFDButton = new System.Windows.Forms.Button();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FDDataGridview)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FDDataGridview
            // 
            this.FDDataGridview.AllowUserToAddRows = false;
            this.FDDataGridview.AllowUserToDeleteRows = false;
            this.FDDataGridview.AllowUserToOrderColumns = true;
            this.FDDataGridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FDDataGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FDDataGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FDDataGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FDDataGridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.FDDataGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FDDataGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FDDataGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FDDataGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FDDataGridview.ColumnHeadersHeight = 25;
            this.FDDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.FDDataGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameFD,
            this.IDCategory,
            this.Price,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FDDataGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.FDDataGridview.EnableHeadersVisualStyles = false;
            this.FDDataGridview.GridColor = System.Drawing.SystemColors.HotTrack;
            this.FDDataGridview.Location = new System.Drawing.Point(11, 62);
            this.FDDataGridview.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.FDDataGridview.MultiSelect = false;
            this.FDDataGridview.Name = "FDDataGridview";
            this.FDDataGridview.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FDDataGridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.FDDataGridview.RowHeadersVisible = false;
            this.FDDataGridview.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FDDataGridview.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.FDDataGridview.RowTemplate.Height = 28;
            this.FDDataGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FDDataGridview.Size = new System.Drawing.Size(1090, 494);
            this.FDDataGridview.TabIndex = 5;
            this.FDDataGridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FDDataGridview_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NameFD
            // 
            this.NameFD.DataPropertyName = "NameFD";
            this.NameFD.HeaderText = "Name";
            this.NameFD.MinimumWidth = 8;
            this.NameFD.Name = "NameFD";
            this.NameFD.ReadOnly = true;
            // 
            // IDCategory
            // 
            this.IDCategory.DataPropertyName = "IDCategory";
            this.IDCategory.HeaderText = "ID Category";
            this.IDCategory.MinimumWidth = 8;
            this.IDCategory.Name = "IDCategory";
            this.IDCategory.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 50F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 50F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // FoodDrinkButton
            // 
            this.FoodDrinkButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FoodDrinkButton.Location = new System.Drawing.Point(0, 0);
            this.FoodDrinkButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FoodDrinkButton.Name = "FoodDrinkButton";
            this.FoodDrinkButton.Size = new System.Drawing.Size(144, 46);
            this.FoodDrinkButton.TabIndex = 32;
            this.FoodDrinkButton.Text = "Food/Drink";
            this.FoodDrinkButton.UseVisualStyleBackColor = true;
            this.FoodDrinkButton.Click += new System.EventHandler(this.FoodDrinkButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FoodDrinkButton);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 46);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CategoryButton);
            this.panel2.Location = new System.Drawing.Point(148, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 46);
            this.panel2.TabIndex = 34;
            // 
            // CategoryButton
            // 
            this.CategoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryButton.Location = new System.Drawing.Point(0, 0);
            this.CategoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoryButton.Name = "CategoryButton";
            this.CategoryButton.Size = new System.Drawing.Size(144, 46);
            this.CategoryButton.TabIndex = 32;
            this.CategoryButton.Text = "Category";
            this.CategoryButton.UseVisualStyleBackColor = true;
            this.CategoryButton.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // CategoryDataGridView
            // 
            this.CategoryDataGridView.AllowUserToAddRows = false;
            this.CategoryDataGridView.AllowUserToDeleteRows = false;
            this.CategoryDataGridView.AllowUserToOrderColumns = true;
            this.CategoryDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CategoryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.CategoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.CategoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategoryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.CategoryDataGridView.ColumnHeadersHeight = 25;
            this.CategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CategoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryID,
            this.CategoryName,
            this.dataGridViewImageColumn1,
            this.dataGridViewImageColumn2});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.CategoryDataGridView.EnableHeadersVisualStyles = false;
            this.CategoryDataGridView.GridColor = System.Drawing.SystemColors.HotTrack;
            this.CategoryDataGridView.Location = new System.Drawing.Point(11, 62);
            this.CategoryDataGridView.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.CategoryDataGridView.MultiSelect = false;
            this.CategoryDataGridView.Name = "CategoryDataGridView";
            this.CategoryDataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.CategoryDataGridView.RowHeadersVisible = false;
            this.CategoryDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CategoryDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.CategoryDataGridView.RowTemplate.Height = 28;
            this.CategoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoryDataGridView.Size = new System.Drawing.Size(1090, 489);
            this.CategoryDataGridView.TabIndex = 35;
            this.CategoryDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryDataGridView_CellClick);
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "ID";
            this.CategoryID.FillWeight = 50F;
            this.CategoryID.HeaderText = "ID";
            this.CategoryID.MinimumWidth = 8;
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "NameCategory";
            this.CategoryName.HeaderText = "Name";
            this.CategoryName.MinimumWidth = 8;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 40F;
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 40F;
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 8;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // AddFDButton
            // 
            this.AddFDButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.AddFDButton.FlatAppearance.BorderSize = 0;
            this.AddFDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFDButton.ForeColor = System.Drawing.Color.White;
            this.AddFDButton.Location = new System.Drawing.Point(906, 12);
            this.AddFDButton.Name = "AddFDButton";
            this.AddFDButton.Size = new System.Drawing.Size(193, 44);
            this.AddFDButton.TabIndex = 36;
            this.AddFDButton.Text = "Add";
            this.AddFDButton.UseVisualStyleBackColor = false;
            this.AddFDButton.Click += new System.EventHandler(this.AddFDButton_Click);
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.AddCategoryButton.FlatAppearance.BorderSize = 0;
            this.AddCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCategoryButton.ForeColor = System.Drawing.Color.White;
            this.AddCategoryButton.Location = new System.Drawing.Point(906, 12);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(193, 44);
            this.AddCategoryButton.TabIndex = 37;
            this.AddCategoryButton.Text = "Add";
            this.AddCategoryButton.UseVisualStyleBackColor = false;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // FormAddFD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1111, 726);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.AddFDButton);
            this.Controls.Add(this.CategoryDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FDDataGridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddFD";
            this.Text = "FormAddFD";
            ((System.ComponentModel.ISupportInitialize)(this.FDDataGridview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FDDataGridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFD;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Button FoodDrinkButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CategoryButton;
        private System.Windows.Forms.DataGridView CategoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button AddFDButton;
        private System.Windows.Forms.Button AddCategoryButton;
    }
}