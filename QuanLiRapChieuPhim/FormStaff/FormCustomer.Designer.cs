
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.ListCustomerGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListCustomerGrid)).BeginInit();
            this.SearchPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListCustomerGrid
            // 
            this.ListCustomerGrid.AllowUserToAddRows = false;
            this.ListCustomerGrid.AllowUserToDeleteRows = false;
            this.ListCustomerGrid.AllowUserToOrderColumns = true;
            this.ListCustomerGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ListCustomerGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListCustomerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListCustomerGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ListCustomerGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListCustomerGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListCustomerGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(54)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(54)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListCustomerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListCustomerGrid.ColumnHeadersHeight = 35;
            this.ListCustomerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ListCustomerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FullName,
            this.DoB,
            this.Address,
            this.Phone,
            this.IDPersonal,
            this.Points,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListCustomerGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ListCustomerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListCustomerGrid.EnableHeadersVisualStyles = false;
            this.ListCustomerGrid.GridColor = System.Drawing.SystemColors.HotTrack;
            this.ListCustomerGrid.Location = new System.Drawing.Point(0, 59);
            this.ListCustomerGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListCustomerGrid.MultiSelect = false;
            this.ListCustomerGrid.Name = "ListCustomerGrid";
            this.ListCustomerGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListCustomerGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ListCustomerGrid.RowHeadersVisible = false;
            this.ListCustomerGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ListCustomerGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ListCustomerGrid.RowTemplate.Height = 28;
            this.ListCustomerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListCustomerGrid.Size = new System.Drawing.Size(1111, 667);
            this.ListCustomerGrid.TabIndex = 28;
            this.ListCustomerGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListCustomerGrid_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 44.29718F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.FillWeight = 120.8553F;
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 8;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // DoB
            // 
            this.DoB.DataPropertyName = "DoB";
            this.DoB.FillWeight = 120.8553F;
            this.DoB.HeaderText = "Birthday";
            this.DoB.MinimumWidth = 8;
            this.DoB.Name = "DoB";
            this.DoB.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Addr";
            this.Address.FillWeight = 120.8553F;
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.FillWeight = 120.8553F;
            this.Phone.HeaderText = "Phone Number";
            this.Phone.MinimumWidth = 8;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // IDPersonal
            // 
            this.IDPersonal.DataPropertyName = "IDPersonal";
            this.IDPersonal.FillWeight = 120.8553F;
            this.IDPersonal.HeaderText = "ID Personal";
            this.IDPersonal.MinimumWidth = 8;
            this.IDPersonal.Name = "IDPersonal";
            this.IDPersonal.ReadOnly = true;
            // 
            // Points
            // 
            this.Points.DataPropertyName = "Points";
            this.Points.FillWeight = 60.42613F;
            this.Points.HeaderText = "Points";
            this.Points.MinimumWidth = 8;
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 135;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 8;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 135;
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.Transparent;
            this.SearchPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchPanel.BackgroundImage")));
            this.SearchPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchPanel.Controls.Add(this.SearchTextbox);
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.Location = new System.Drawing.Point(11, 9);
            this.SearchPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(601, 37);
            this.SearchPanel.TabIndex = 33;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.SearchTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTextbox.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextbox.ForeColor = System.Drawing.Color.Gray;
            this.SearchTextbox.Location = new System.Drawing.Point(19, 7);
            this.SearchTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchTextbox.Multiline = true;
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(533, 21);
            this.SearchTextbox.TabIndex = 33;
            this.SearchTextbox.Text = "Search";
            this.SearchTextbox.TextChanged += new System.EventHandler(this.SearchTextbox_TextChanged);
            this.SearchTextbox.Enter += new System.EventHandler(this.SearchTextbox_Enter);
            this.SearchTextbox.Leave += new System.EventHandler(this.SearchTextbox_Leave);
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
            this.SearchButton.Location = new System.Drawing.Point(565, 0);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(36, 37);
            this.SearchButton.TabIndex = 32;
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AddButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1111, 59);
            this.panel3.TabIndex = 39;
            // 
            // AddButton
            // 
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(1052, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(59, 59);
            this.AddButton.TabIndex = 33;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1111, 726);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.ListCustomerGrid);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.ListCustomerGrid)).EndInit();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.DataGridView ListCustomerGrid;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AddButton;
    }
}