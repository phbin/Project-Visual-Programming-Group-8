﻿
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
            this.gradientPanelFD = new QuanLiRapChieuPhim.GradientPanel();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.nmFDCount = new System.Windows.Forms.NumericUpDown();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlLine3 = new System.Windows.Forms.Panel();
            this.cbbCategorySelection = new System.Windows.Forms.ComboBox();
            this.pnlLine4 = new System.Windows.Forms.Panel();
            this.pnlDisplayBill = new System.Windows.Forms.Panel();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.NameFD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLine2 = new System.Windows.Forms.Panel();
            this.flpFoodDrink = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.gradientPanelFD.SuspendLayout();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFDCount)).BeginInit();
            this.pnlDisplayBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanelFD
            // 
            this.gradientPanelFD.Angle = 90F;
            this.gradientPanelFD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.gradientPanelFD.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.gradientPanelFD.Controls.Add(this.flpFoodDrink);
            this.gradientPanelFD.Controls.Add(this.pnlDisplayBill);
            this.gradientPanelFD.Controls.Add(this.pnlLine4);
            this.gradientPanelFD.Controls.Add(this.cbbCategorySelection);
            this.gradientPanelFD.Controls.Add(this.pnlLine3);
            this.gradientPanelFD.Controls.Add(this.pnlLine);
            this.gradientPanelFD.Controls.Add(this.pnlControl);
            this.gradientPanelFD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelFD.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelFD.Margin = new System.Windows.Forms.Padding(2);
            this.gradientPanelFD.Name = "gradientPanelFD";
            this.gradientPanelFD.Size = new System.Drawing.Size(576, 556);
            this.gradientPanelFD.TabIndex = 2;
            this.gradientPanelFD.TopColor = System.Drawing.Color.Empty;
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(98)))), ((int)(((byte)(101)))));
            this.pnlLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine.Location = new System.Drawing.Point(0, 0);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(576, 5);
            this.pnlLine.TabIndex = 3;
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(98)))), ((int)(((byte)(101)))));
            this.pnlControl.Controls.Add(this.btnRemoveAll);
            this.pnlControl.Controls.Add(this.txtTotalPrice);
            this.pnlControl.Controls.Add(this.nmFDCount);
            this.pnlControl.Controls.Add(this.btnCheckOut);
            this.pnlControl.Controls.Add(this.btnAdd);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl.Location = new System.Drawing.Point(0, 476);
            this.pnlControl.Margin = new System.Windows.Forms.Padding(2);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(576, 80);
            this.pnlControl.TabIndex = 2;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(203, 26);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(125, 26);
            this.txtTotalPrice.TabIndex = 10;
            this.txtTotalPrice.Text = "0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nmFDCount
            // 
            this.nmFDCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmFDCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmFDCount.Location = new System.Drawing.Point(19, 30);
            this.nmFDCount.Margin = new System.Windows.Forms.Padding(10);
            this.nmFDCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFDCount.Name = "nmFDCount";
            this.nmFDCount.Size = new System.Drawing.Size(49, 23);
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
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(461, 10);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(10);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(100, 60);
            this.btnCheckOut.TabIndex = 8;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(88, 10);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 60);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlLine3
            // 
            this.pnlLine3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(98)))), ((int)(((byte)(101)))));
            this.pnlLine3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLine3.Location = new System.Drawing.Point(571, 5);
            this.pnlLine3.Name = "pnlLine3";
            this.pnlLine3.Size = new System.Drawing.Size(5, 471);
            this.pnlLine3.TabIndex = 12;
            // 
            // cbbCategorySelection
            // 
            this.cbbCategorySelection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbCategorySelection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCategorySelection.BackColor = System.Drawing.Color.Snow;
            this.cbbCategorySelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbbCategorySelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCategorySelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategorySelection.FormattingEnabled = true;
            this.cbbCategorySelection.Items.AddRange(new object[] {
            "Combo",
            "Food",
            "Drink"});
            this.cbbCategorySelection.Location = new System.Drawing.Point(0, 5);
            this.cbbCategorySelection.Name = "cbbCategorySelection";
            this.cbbCategorySelection.Size = new System.Drawing.Size(571, 28);
            this.cbbCategorySelection.TabIndex = 13;
            this.cbbCategorySelection.TabStop = false;
            this.cbbCategorySelection.SelectedIndexChanged += new System.EventHandler(this.cbbCategorySelection_SelectedIndexChanged_1);
            // 
            // pnlLine4
            // 
            this.pnlLine4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(98)))), ((int)(((byte)(101)))));
            this.pnlLine4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine4.Location = new System.Drawing.Point(0, 33);
            this.pnlLine4.Name = "pnlLine4";
            this.pnlLine4.Size = new System.Drawing.Size(571, 5);
            this.pnlLine4.TabIndex = 14;
            // 
            // pnlDisplayBill
            // 
            this.pnlDisplayBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(98)))), ((int)(((byte)(101)))));
            this.pnlDisplayBill.Controls.Add(this.dgvBill);
            this.pnlDisplayBill.Controls.Add(this.pnlLine2);
            this.pnlDisplayBill.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDisplayBill.Location = new System.Drawing.Point(313, 38);
            this.pnlDisplayBill.Name = "pnlDisplayBill";
            this.pnlDisplayBill.Size = new System.Drawing.Size(258, 438);
            this.pnlDisplayBill.TabIndex = 15;
            // 
            // dgvBill
            // 
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvBill.ColumnHeadersHeight = 25;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameFD,
            this.Quantity,
            this.Price,
            this.TotalPrice});
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBill.Location = new System.Drawing.Point(5, 0);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.RowTemplate.ReadOnly = true;
            this.dgvBill.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(253, 438);
            this.dgvBill.TabIndex = 4;
            // 
            // NameFD
            // 
            this.NameFD.HeaderText = "Name";
            this.NameFD.Name = "NameFD";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // pnlLine2
            // 
            this.pnlLine2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLine2.Location = new System.Drawing.Point(0, 0);
            this.pnlLine2.Name = "pnlLine2";
            this.pnlLine2.Size = new System.Drawing.Size(5, 438);
            this.pnlLine2.TabIndex = 0;
            // 
            // flpFoodDrink
            // 
            this.flpFoodDrink.AutoScroll = true;
            this.flpFoodDrink.BackColor = System.Drawing.Color.Snow;
            this.flpFoodDrink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpFoodDrink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFoodDrink.ForeColor = System.Drawing.Color.Black;
            this.flpFoodDrink.Location = new System.Drawing.Point(0, 38);
            this.flpFoodDrink.Name = "flpFoodDrink";
            this.flpFoodDrink.Size = new System.Drawing.Size(313, 438);
            this.flpFoodDrink.TabIndex = 16;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnRemoveAll.FlatAppearance.BorderSize = 0;
            this.btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.Location = new System.Drawing.Point(341, 11);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(10);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(100, 60);
            this.btnRemoveAll.TabIndex = 11;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = false;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // FormFD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 556);
            this.ControlBox = false;
            this.Controls.Add(this.gradientPanelFD);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFD";
            this.gradientPanelFD.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFDCount)).EndInit();
            this.pnlDisplayBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelFD;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.NumericUpDown nmFDCount;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.FlowLayoutPanel flpFoodDrink;
        private System.Windows.Forms.Panel pnlDisplayBill;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Panel pnlLine2;
        private System.Windows.Forms.Panel pnlLine4;
        private System.Windows.Forms.ComboBox cbbCategorySelection;
        private System.Windows.Forms.Panel pnlLine3;
        private System.Windows.Forms.Button btnRemoveAll;
    }
}