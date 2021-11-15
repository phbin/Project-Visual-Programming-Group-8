
namespace QuanLiRapChieuPhim
{
    partial class FormFD
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
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.nmFDCount = new System.Windows.Forms.NumericUpDown();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbbCategorySelection = new System.Windows.Forms.ComboBox();
            this.flpFoodDrink = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.dgvColumnNameFD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFDCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pnlControl.Controls.Add(this.btnRemoveAll);
            this.pnlControl.Controls.Add(this.txtTotalPrice);
            this.pnlControl.Controls.Add(this.nmFDCount);
            this.pnlControl.Controls.Add(this.btnCheckOut);
            this.pnlControl.Controls.Add(this.btnAdd);
            this.pnlControl.Location = new System.Drawing.Point(5, 549);
            this.pnlControl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(839, 79);
            this.pnlControl.TabIndex = 5;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnRemoveAll.FlatAppearance.BorderSize = 0;
            this.btnRemoveAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.btnRemoveAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAll.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.ForeColor = System.Drawing.Color.White;
            this.btnRemoveAll.Location = new System.Drawing.Point(581, 14);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(120, 42);
            this.btnRemoveAll.TabIndex = 11;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = false;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTotalPrice.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(264, 26);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(191, 29);
            this.txtTotalPrice.TabIndex = 10;
            this.txtTotalPrice.Text = "Total: 0 VND";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nmFDCount
            // 
            this.nmFDCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nmFDCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmFDCount.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.nmFDCount.Location = new System.Drawing.Point(19, 27);
            this.nmFDCount.Margin = new System.Windows.Forms.Padding(10);
            this.nmFDCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFDCount.Name = "nmFDCount";
            this.nmFDCount.Size = new System.Drawing.Size(49, 29);
            this.nmFDCount.TabIndex = 9;
            this.nmFDCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.btnCheckOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(719, 14);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(120, 42);
            this.btnCheckOut.TabIndex = 8;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(87, 18);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 42);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbbCategorySelection
            // 
            this.cbbCategorySelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCategorySelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cbbCategorySelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategorySelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCategorySelection.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategorySelection.ForeColor = System.Drawing.Color.White;
            this.cbbCategorySelection.FormattingEnabled = true;
            this.cbbCategorySelection.Location = new System.Drawing.Point(5, 5);
            this.cbbCategorySelection.Margin = new System.Windows.Forms.Padding(5);
            this.cbbCategorySelection.Name = "cbbCategorySelection";
            this.cbbCategorySelection.Size = new System.Drawing.Size(839, 29);
            this.cbbCategorySelection.TabIndex = 21;
            this.cbbCategorySelection.TabStop = false;
            this.cbbCategorySelection.SelectedIndexChanged += new System.EventHandler(this.cbbCategorySelection_SelectedIndexChanged_1);
            // 
            // flpFoodDrink
            // 
            this.flpFoodDrink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpFoodDrink.AutoScroll = true;
            this.flpFoodDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.flpFoodDrink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpFoodDrink.ForeColor = System.Drawing.Color.Black;
            this.flpFoodDrink.Location = new System.Drawing.Point(5, 39);
            this.flpFoodDrink.Name = "flpFoodDrink";
            this.flpFoodDrink.Size = new System.Drawing.Size(542, 506);
            this.flpFoodDrink.TabIndex = 24;
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.dgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBill.ColumnHeadersHeight = 25;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnNameFD,
            this.dgvColumnQuantity,
            this.dgvColumnPrice,
            this.dgvColumnTotalPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBill.EnableHeadersVisualStyles = false;
            this.dgvBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            this.dgvBill.Location = new System.Drawing.Point(571, 39);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.ReadOnly = true;
            this.dgvBill.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(273, 506);
            this.dgvBill.TabIndex = 26;
            // 
            // dgvColumnNameFD
            // 
            this.dgvColumnNameFD.FillWeight = 102.8765F;
            this.dgvColumnNameFD.HeaderText = "Name";
            this.dgvColumnNameFD.MinimumWidth = 6;
            this.dgvColumnNameFD.Name = "dgvColumnNameFD";
            this.dgvColumnNameFD.ReadOnly = true;
            // 
            // dgvColumnQuantity
            // 
            this.dgvColumnQuantity.FillWeight = 91.37056F;
            this.dgvColumnQuantity.HeaderText = "Quantity";
            this.dgvColumnQuantity.MinimumWidth = 6;
            this.dgvColumnQuantity.Name = "dgvColumnQuantity";
            this.dgvColumnQuantity.ReadOnly = true;
            // 
            // dgvColumnPrice
            // 
            this.dgvColumnPrice.FillWeight = 102.8765F;
            this.dgvColumnPrice.HeaderText = "Price";
            this.dgvColumnPrice.MinimumWidth = 6;
            this.dgvColumnPrice.Name = "dgvColumnPrice";
            this.dgvColumnPrice.ReadOnly = true;
            // 
            // dgvColumnTotalPrice
            // 
            this.dgvColumnTotalPrice.FillWeight = 102.8765F;
            this.dgvColumnTotalPrice.HeaderText = "Total Price";
            this.dgvColumnTotalPrice.MinimumWidth = 6;
            this.dgvColumnTotalPrice.Name = "dgvColumnTotalPrice";
            this.dgvColumnTotalPrice.ReadOnly = true;
            // 
            // FormFD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(849, 629);
            this.ControlBox = false;
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.flpFoodDrink);
            this.Controls.Add(this.cbbCategorySelection);
            this.Controls.Add(this.pnlControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFD";
            this.Text = "FormFD";
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFDCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.NumericUpDown nmFDCount;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbbCategorySelection;
        private System.Windows.Forms.FlowLayoutPanel flpFoodDrink;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnNameFD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnTotalPrice;
    }
}