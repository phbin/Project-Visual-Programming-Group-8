
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
            this.pnlLine = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.nmFDCount = new System.Windows.Forms.NumericUpDown();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlLine5 = new System.Windows.Forms.Panel();
            this.cbbCategorySelection = new System.Windows.Forms.ComboBox();
            this.pnlLine4 = new System.Windows.Forms.Panel();
            this.pnlDisplayBill = new System.Windows.Forms.Panel();
            this.pnlLine3 = new System.Windows.Forms.Panel();
            this.pnlLine2 = new System.Windows.Forms.Panel();
            this.flpFoodDrink = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.dgvColumnNameFD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFDCount)).BeginInit();
            this.pnlDisplayBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pnlLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine.Location = new System.Drawing.Point(0, 0);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(576, 5);
            this.pnlLine.TabIndex = 4;
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pnlControl.Controls.Add(this.btnRemoveAll);
            this.pnlControl.Controls.Add(this.txtTotalPrice);
            this.pnlControl.Controls.Add(this.nmFDCount);
            this.pnlControl.Controls.Add(this.btnCheckOut);
            this.pnlControl.Controls.Add(this.btnAdd);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl.Location = new System.Drawing.Point(0, 477);
            this.pnlControl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(576, 79);
            this.pnlControl.TabIndex = 5;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnRemoveAll.FlatAppearance.BorderSize = 0;
            this.btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAll.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.ForeColor = System.Drawing.Color.White;
            this.btnRemoveAll.Location = new System.Drawing.Point(373, 18);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(89, 42);
            this.btnRemoveAll.TabIndex = 11;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = false;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            this.btnRemoveAll.MouseLeave += new System.EventHandler(this.btnRemoveAll_MouseLeave);
            this.btnRemoveAll.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRemoveAll_MouseMove);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTotalPrice.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(181, 26);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(125, 29);
            this.txtTotalPrice.TabIndex = 10;
            this.txtTotalPrice.Text = "Total: 0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nmFDCount
            // 
            this.nmFDCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmFDCount.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.nmFDCount.Location = new System.Drawing.Point(19, 27);
            this.nmFDCount.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
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
            this.btnCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(480, 18);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(89, 42);
            this.btnCheckOut.TabIndex = 8;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            this.btnCheckOut.MouseLeave += new System.EventHandler(this.btnCheckOut_MouseLeave);
            this.btnCheckOut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCheckOut_MouseMove);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(80, 18);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 42);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            this.btnAdd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAdd_MouseMove);
            // 
            // pnlLine5
            // 
            this.pnlLine5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pnlLine5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLine5.Location = new System.Drawing.Point(0, 5);
            this.pnlLine5.Name = "pnlLine5";
            this.pnlLine5.Size = new System.Drawing.Size(5, 472);
            this.pnlLine5.TabIndex = 19;
            // 
            // cbbCategorySelection
            // 
            this.cbbCategorySelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cbbCategorySelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbbCategorySelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategorySelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCategorySelection.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategorySelection.ForeColor = System.Drawing.Color.White;
            this.cbbCategorySelection.FormattingEnabled = true;
            this.cbbCategorySelection.Location = new System.Drawing.Point(5, 5);
            this.cbbCategorySelection.Name = "cbbCategorySelection";
            this.cbbCategorySelection.Size = new System.Drawing.Size(566, 29);
            this.cbbCategorySelection.TabIndex = 21;
            this.cbbCategorySelection.TabStop = false;
            this.cbbCategorySelection.SelectedIndexChanged += new System.EventHandler(this.cbbCategorySelection_SelectedIndexChanged_1);
            // 
            // pnlLine4
            // 
            this.pnlLine4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pnlLine4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine4.Location = new System.Drawing.Point(5, 34);
            this.pnlLine4.Name = "pnlLine4";
            this.pnlLine4.Size = new System.Drawing.Size(566, 5);
            this.pnlLine4.TabIndex = 22;
            // 
            // pnlDisplayBill
            // 
            this.pnlDisplayBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(98)))), ((int)(((byte)(101)))));
            this.pnlDisplayBill.Controls.Add(this.dgvBill);
            this.pnlDisplayBill.Controls.Add(this.pnlLine2);
            this.pnlDisplayBill.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDisplayBill.Location = new System.Drawing.Point(361, 39);
            this.pnlDisplayBill.Name = "pnlDisplayBill";
            this.pnlDisplayBill.Size = new System.Drawing.Size(210, 438);
            this.pnlDisplayBill.TabIndex = 23;
            // 
            // pnlLine3
            // 
            this.pnlLine3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pnlLine3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLine3.Location = new System.Drawing.Point(571, 5);
            this.pnlLine3.Name = "pnlLine3";
            this.pnlLine3.Size = new System.Drawing.Size(5, 472);
            this.pnlLine3.TabIndex = 20;
            // 
            // pnlLine2
            // 
            this.pnlLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pnlLine2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLine2.Location = new System.Drawing.Point(0, 0);
            this.pnlLine2.Name = "pnlLine2";
            this.pnlLine2.Size = new System.Drawing.Size(10, 438);
            this.pnlLine2.TabIndex = 0;
            // 
            // flpFoodDrink
            // 
            this.flpFoodDrink.AutoScroll = true;
            this.flpFoodDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.flpFoodDrink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpFoodDrink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFoodDrink.ForeColor = System.Drawing.Color.Black;
            this.flpFoodDrink.Location = new System.Drawing.Point(5, 39);
            this.flpFoodDrink.Name = "flpFoodDrink";
            this.flpFoodDrink.Size = new System.Drawing.Size(356, 438);
            this.flpFoodDrink.TabIndex = 24;
            // 
            // dgvBill
            // 
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvBill.ColumnHeadersHeight = 25;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnNameFD,
            this.dgvColumnQuantity,
            this.dgvColumnPrice,
            this.dgvColumnTotalPrice});
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBill.Location = new System.Drawing.Point(10, 0);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.ReadOnly = true;
            this.dgvBill.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(200, 438);
            this.dgvBill.TabIndex = 5;
            // 
            // dgvColumnNameFD
            // 
            this.dgvColumnNameFD.FillWeight = 102.8765F;
            this.dgvColumnNameFD.HeaderText = "Name";
            this.dgvColumnNameFD.MinimumWidth = 6;
            this.dgvColumnNameFD.Name = "dgvColumnNameFD";
            // 
            // dgvColumnQuantity
            // 
            this.dgvColumnQuantity.FillWeight = 91.37056F;
            this.dgvColumnQuantity.HeaderText = "Quantity";
            this.dgvColumnQuantity.MinimumWidth = 6;
            this.dgvColumnQuantity.Name = "dgvColumnQuantity";
            // 
            // dgvColumnPrice
            // 
            this.dgvColumnPrice.FillWeight = 102.8765F;
            this.dgvColumnPrice.HeaderText = "Price";
            this.dgvColumnPrice.MinimumWidth = 6;
            this.dgvColumnPrice.Name = "dgvColumnPrice";
            // 
            // dgvColumnTotalPrice
            // 
            this.dgvColumnTotalPrice.FillWeight = 102.8765F;
            this.dgvColumnTotalPrice.HeaderText = "TotalPrice";
            this.dgvColumnTotalPrice.MinimumWidth = 6;
            this.dgvColumnTotalPrice.Name = "dgvColumnTotalPrice";
            // 
            // FormFD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 556);
            this.ControlBox = false;
            this.Controls.Add(this.flpFoodDrink);
            this.Controls.Add(this.pnlDisplayBill);
            this.Controls.Add(this.pnlLine4);
            this.Controls.Add(this.cbbCategorySelection);
            this.Controls.Add(this.pnlLine3);
            this.Controls.Add(this.pnlLine5);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlLine);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFD";
            this.Text = "FormFD";
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFDCount)).EndInit();
            this.pnlDisplayBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.NumericUpDown nmFDCount;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlLine5;
        private System.Windows.Forms.ComboBox cbbCategorySelection;
        private System.Windows.Forms.Panel pnlLine4;
        private System.Windows.Forms.Panel pnlDisplayBill;
        private System.Windows.Forms.Panel pnlLine3;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnNameFD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnTotalPrice;
        private System.Windows.Forms.Panel pnlLine2;
        private System.Windows.Forms.FlowLayoutPanel flpFoodDrink;
    }
}