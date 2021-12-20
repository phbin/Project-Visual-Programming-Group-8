
using System;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.datagridviewBill = new System.Windows.Forms.DataGridView();
            this.dgvColumnNameFD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnRemove = new System.Windows.Forms.DataGridViewImageColumn();
            this.nmFDCount = new System.Windows.Forms.NumericUpDown();
            this.lbTotalDetail = new System.Windows.Forms.Label();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTaxDeTail = new System.Windows.Forms.Label();
            this.lbTax = new System.Windows.Forms.Label();
            this.lbSubTotalDeTail = new System.Windows.Forms.Label();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.lbIDBill = new System.Windows.Forms.Label();
            this.labelOrderList = new System.Windows.Forms.Label();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.btnCombo = new System.Windows.Forms.Button();
            this.btnDrink = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlSubBelow = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFDCount)).BeginInit();
            this.pnlCategory.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlSubBelow.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(13, 81);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(453, 626);
            this.flowLayoutPanel.TabIndex = 29;
            // 
            // datagridviewBill
            // 
            this.datagridviewBill.AllowUserToAddRows = false;
            this.datagridviewBill.AllowUserToDeleteRows = false;
            this.datagridviewBill.AllowUserToResizeColumns = false;
            this.datagridviewBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridviewBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.datagridviewBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridviewBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridviewBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lato", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridviewBill.ColumnHeadersHeight = 20;
            this.datagridviewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridviewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnNameFD,
            this.dgvColumnQuantity,
            this.dgvColumnPrice,
            this.dgvColumnTotalPrice,
            this.dgvColumnRemove});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridviewBill.DefaultCellStyle = dataGridViewCellStyle7;
            this.datagridviewBill.EnableHeadersVisualStyles = false;
            this.datagridviewBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            this.datagridviewBill.Location = new System.Drawing.Point(475, 81);
            this.datagridviewBill.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.datagridviewBill.Name = "datagridviewBill";
            this.datagridviewBill.ReadOnly = true;
            this.datagridviewBill.RowHeadersVisible = false;
            this.datagridviewBill.RowHeadersWidth = 51;
            this.datagridviewBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridviewBill.RowTemplate.ReadOnly = true;
            this.datagridviewBill.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridviewBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewBill.Size = new System.Drawing.Size(313, 421);
            this.datagridviewBill.TabIndex = 58;
            this.datagridviewBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellClick);
            // 
            // dgvColumnNameFD
            // 
            this.dgvColumnNameFD.FillWeight = 182.3187F;
            this.dgvColumnNameFD.HeaderText = "Name";
            this.dgvColumnNameFD.MinimumWidth = 6;
            this.dgvColumnNameFD.Name = "dgvColumnNameFD";
            this.dgvColumnNameFD.ReadOnly = true;
            // 
            // dgvColumnQuantity
            // 
            this.dgvColumnQuantity.FillWeight = 44.56829F;
            this.dgvColumnQuantity.HeaderText = "Qty";
            this.dgvColumnQuantity.MinimumWidth = 6;
            this.dgvColumnQuantity.Name = "dgvColumnQuantity";
            this.dgvColumnQuantity.ReadOnly = true;
            // 
            // dgvColumnPrice
            // 
            this.dgvColumnPrice.FillWeight = 86.32681F;
            this.dgvColumnPrice.HeaderText = "Price";
            this.dgvColumnPrice.MinimumWidth = 6;
            this.dgvColumnPrice.Name = "dgvColumnPrice";
            this.dgvColumnPrice.ReadOnly = true;
            // 
            // dgvColumnTotalPrice
            // 
            this.dgvColumnTotalPrice.FillWeight = 88.91396F;
            this.dgvColumnTotalPrice.HeaderText = "Total ";
            this.dgvColumnTotalPrice.MinimumWidth = 6;
            this.dgvColumnTotalPrice.Name = "dgvColumnTotalPrice";
            this.dgvColumnTotalPrice.ReadOnly = true;
            // 
            // dgvColumnRemove
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.dgvColumnRemove.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvColumnRemove.FillWeight = 47.87235F;
            this.dgvColumnRemove.HeaderText = "";
            this.dgvColumnRemove.Image = global::QuanLiRapChieuPhim.Properties.Resources.TrashIcon_01;
            this.dgvColumnRemove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dgvColumnRemove.MinimumWidth = 8;
            this.dgvColumnRemove.Name = "dgvColumnRemove";
            this.dgvColumnRemove.ReadOnly = true;
            this.dgvColumnRemove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nmFDCount
            // 
            this.nmFDCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nmFDCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmFDCount.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmFDCount.Location = new System.Drawing.Point(11, 12);
            this.nmFDCount.Margin = new System.Windows.Forms.Padding(11, 12, 5, 12);
            this.nmFDCount.Name = "nmFDCount";
            this.nmFDCount.Size = new System.Drawing.Size(48, 35);
            this.nmFDCount.TabIndex = 41;
            this.nmFDCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbTotalDetail
            // 
            this.lbTotalDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalDetail.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(36)))), ((int)(((byte)(31)))));
            this.lbTotalDetail.Location = new System.Drawing.Point(560, 593);
            this.lbTotalDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalDetail.Name = "lbTotalDetail";
            this.lbTotalDetail.Size = new System.Drawing.Size(213, 37);
            this.lbTotalDetail.TabIndex = 56;
            this.lbTotalDetail.Text = "0 VND";
            this.lbTotalDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlLine
            // 
            this.pnlLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.pnlLine.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLine.Location = new System.Drawing.Point(475, 577);
            this.pnlLine.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(317, 5);
            this.pnlLine.TabIndex = 54;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Lato", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbTotal.Location = new System.Drawing.Point(481, 604);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(53, 22);
            this.lbTotal.TabIndex = 55;
            this.lbTotal.Text = "Total:";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTaxDeTail
            // 
            this.lbTaxDeTail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTaxDeTail.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaxDeTail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbTaxDeTail.Location = new System.Drawing.Point(584, 542);
            this.lbTaxDeTail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTaxDeTail.Name = "lbTaxDeTail";
            this.lbTaxDeTail.Size = new System.Drawing.Size(184, 37);
            this.lbTaxDeTail.TabIndex = 53;
            this.lbTaxDeTail.Text = "0 VND";
            this.lbTaxDeTail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTax
            // 
            this.lbTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTax.AutoSize = true;
            this.lbTax.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTax.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbTax.Location = new System.Drawing.Point(483, 551);
            this.lbTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTax.Name = "lbTax";
            this.lbTax.Size = new System.Drawing.Size(38, 21);
            this.lbTax.TabIndex = 52;
            this.lbTax.Text = "Tax:";
            this.lbTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSubTotalDeTail
            // 
            this.lbSubTotalDeTail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSubTotalDeTail.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTotalDeTail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbSubTotalDeTail.Location = new System.Drawing.Point(588, 514);
            this.lbSubTotalDeTail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSubTotalDeTail.Name = "lbSubTotalDeTail";
            this.lbSubTotalDeTail.Size = new System.Drawing.Size(180, 37);
            this.lbSubTotalDeTail.TabIndex = 51;
            this.lbSubTotalDeTail.Text = "0 VND";
            this.lbSubTotalDeTail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTotal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbSubTotal.Location = new System.Drawing.Point(481, 524);
            this.lbSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(81, 21);
            this.lbSubTotal.TabIndex = 50;
            this.lbSubTotal.Text = "Sub Total:";
            this.lbSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbIDBill
            // 
            this.lbIDBill.Font = new System.Drawing.Font("Lato", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDBill.ForeColor = System.Drawing.Color.White;
            this.lbIDBill.Location = new System.Drawing.Point(201, 14);
            this.lbIDBill.Name = "lbIDBill";
            this.lbIDBill.Size = new System.Drawing.Size(97, 37);
            this.lbIDBill.TabIndex = 3;
            this.lbIDBill.Text = "No.";
            this.lbIDBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOrderList
            // 
            this.labelOrderList.Font = new System.Drawing.Font("Lato", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderList.ForeColor = System.Drawing.Color.White;
            this.labelOrderList.Location = new System.Drawing.Point(7, 14);
            this.labelOrderList.Name = "labelOrderList";
            this.labelOrderList.Size = new System.Drawing.Size(97, 37);
            this.labelOrderList.TabIndex = 2;
            this.labelOrderList.Text = "Order List";
            this.labelOrderList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCategory
            // 
            this.pnlCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.pnlCategory.Controls.Add(this.btnCombo);
            this.pnlCategory.Controls.Add(this.btnDrink);
            this.pnlCategory.Controls.Add(this.btnFood);
            this.pnlCategory.Location = new System.Drawing.Point(13, 12);
            this.pnlCategory.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(453, 62);
            this.pnlCategory.TabIndex = 60;
            // 
            // btnCombo
            // 
            this.btnCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnCombo.FlatAppearance.BorderSize = 0;
            this.btnCombo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            this.btnCombo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            this.btnCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCombo.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombo.ForeColor = System.Drawing.Color.White;
            this.btnCombo.Location = new System.Drawing.Point(313, 12);
            this.btnCombo.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(120, 37);
            this.btnCombo.TabIndex = 4;
            this.btnCombo.Text = "Combo";
            this.btnCombo.UseVisualStyleBackColor = false;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // btnDrink
            // 
            this.btnDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnDrink.FlatAppearance.BorderSize = 0;
            this.btnDrink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            this.btnDrink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            this.btnDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrink.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrink.ForeColor = System.Drawing.Color.White;
            this.btnDrink.Location = new System.Drawing.Point(167, 12);
            this.btnDrink.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(120, 37);
            this.btnDrink.TabIndex = 3;
            this.btnDrink.Text = "Drink";
            this.btnDrink.UseVisualStyleBackColor = false;
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
            // 
            // btnFood
            // 
            this.btnFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnFood.FlatAppearance.BorderSize = 0;
            this.btnFood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            this.btnFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.ForeColor = System.Drawing.Color.White;
            this.btnFood.Location = new System.Drawing.Point(20, 12);
            this.btnFood.Margin = new System.Windows.Forms.Padding(20, 12, 13, 12);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(120, 37);
            this.btnFood.TabIndex = 0;
            this.btnFood.Text = "Fast Food";
            this.btnFood.UseVisualStyleBackColor = false;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // pnlStatus
            // 
            this.pnlStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.pnlStatus.Controls.Add(this.lbIDBill);
            this.pnlStatus.Controls.Add(this.labelOrderList);
            this.pnlStatus.Location = new System.Drawing.Point(475, 12);
            this.pnlStatus.Margin = new System.Windows.Forms.Padding(4);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(313, 62);
            this.pnlStatus.TabIndex = 61;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(36)))), ((int)(((byte)(31)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(36)))), ((int)(((byte)(31)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Lato Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(69, 12);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 37);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlSubBelow
            // 
            this.pnlSubBelow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSubBelow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.pnlSubBelow.Controls.Add(this.btnSave);
            this.pnlSubBelow.Controls.Add(this.nmFDCount);
            this.pnlSubBelow.Controls.Add(this.btnDeleteAll);
            this.pnlSubBelow.Controls.Add(this.btnAdd);
            this.pnlSubBelow.Location = new System.Drawing.Point(475, 646);
            this.pnlSubBelow.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSubBelow.Name = "pnlSubBelow";
            this.pnlSubBelow.Size = new System.Drawing.Size(313, 62);
            this.pnlSubBelow.TabIndex = 62;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnSave.BackgroundImage = global::QuanLiRapChieuPhim.Properties.Resources.icon_save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(251, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(53, 62);
            this.btnSave.TabIndex = 43;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSave_MouseMove);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            this.btnDeleteAll.FlatAppearance.BorderSize = 0;
            this.btnDeleteAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(36)))), ((int)(((byte)(31)))));
            this.btnDeleteAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(36)))), ((int)(((byte)(31)))));
            this.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAll.Font = new System.Drawing.Font("Lato Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAll.Location = new System.Drawing.Point(160, 12);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(80, 37);
            this.btnDeleteAll.TabIndex = 42;
            this.btnDeleteAll.Text = "DeleteAll";
            this.btnDeleteAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewImageColumn1.FillWeight = 47.87235F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::QuanLiRapChieuPhim.Properties.Resources.TrashIcon_01;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 25;
            // 
            // FormFD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(784, 722);
            this.ControlBox = false;
            this.Controls.Add(this.pnlSubBelow);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlCategory);
            this.Controls.Add(this.datagridviewBill);
            this.Controls.Add(this.lbTotalDetail);
            this.Controls.Add(this.pnlLine);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbTax);
            this.Controls.Add(this.lbSubTotalDeTail);
            this.Controls.Add(this.lbSubTotal);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.lbTaxDeTail);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFD";
            this.Text = "FormFD";
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFDCount)).EndInit();
            this.pnlCategory.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlSubBelow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.DataGridView datagridviewBill;
        private System.Windows.Forms.NumericUpDown nmFDCount;
        private System.Windows.Forms.Label lbTotalDetail;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTaxDeTail;
        private System.Windows.Forms.Label lbTax;
        private System.Windows.Forms.Label lbSubTotalDeTail;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnNameFD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnTotalPrice;
        private System.Windows.Forms.DataGridViewImageColumn dgvColumnRemove;
        private System.Windows.Forms.Label labelOrderList;
        private System.Windows.Forms.Label lbIDBill;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlSubBelow;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnSave;
    }
}