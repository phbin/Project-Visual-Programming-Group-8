
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFD));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnNew = new System.Windows.Forms.Button();
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
            this.flowLayoutPanel.Location = new System.Drawing.Point(10, 66);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(340, 509);
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.datagridviewBill.ColumnHeadersHeight = 20;
            this.datagridviewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridviewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnNameFD,
            this.dgvColumnQuantity,
            this.dgvColumnPrice,
            this.dgvColumnTotalPrice,
            this.dgvColumnRemove});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridviewBill.DefaultCellStyle = dataGridViewCellStyle11;
            this.datagridviewBill.EnableHeadersVisualStyles = false;
            this.datagridviewBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            this.datagridviewBill.Location = new System.Drawing.Point(356, 66);
            this.datagridviewBill.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.datagridviewBill.Name = "datagridviewBill";
            this.datagridviewBill.ReadOnly = true;
            this.datagridviewBill.RowHeadersVisible = false;
            this.datagridviewBill.RowHeadersWidth = 51;
            this.datagridviewBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridviewBill.RowTemplate.ReadOnly = true;
            this.datagridviewBill.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridviewBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewBill.Size = new System.Drawing.Size(235, 342);
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.dgvColumnRemove.DefaultCellStyle = dataGridViewCellStyle10;
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
            this.nmFDCount.Location = new System.Drawing.Point(8, 10);
            this.nmFDCount.Margin = new System.Windows.Forms.Padding(8, 10, 4, 10);
            this.nmFDCount.Name = "nmFDCount";
            this.nmFDCount.Size = new System.Drawing.Size(36, 30);
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
            this.lbTotalDetail.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(36)))), ((int)(((byte)(31)))));
            this.lbTotalDetail.Location = new System.Drawing.Point(420, 482);
            this.lbTotalDetail.Name = "lbTotalDetail";
            this.lbTotalDetail.Size = new System.Drawing.Size(160, 30);
            this.lbTotalDetail.TabIndex = 56;
            this.lbTotalDetail.Text = "0 VND";
            this.lbTotalDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlLine
            // 
            this.pnlLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.pnlLine.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLine.Location = new System.Drawing.Point(356, 469);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(238, 4);
            this.pnlLine.TabIndex = 54;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbTotal.Location = new System.Drawing.Point(361, 491);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(41, 19);
            this.lbTotal.TabIndex = 55;
            this.lbTotal.Text = "Total:";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTaxDeTail
            // 
            this.lbTaxDeTail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTaxDeTail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaxDeTail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbTaxDeTail.Location = new System.Drawing.Point(438, 440);
            this.lbTaxDeTail.Name = "lbTaxDeTail";
            this.lbTaxDeTail.Size = new System.Drawing.Size(138, 30);
            this.lbTaxDeTail.TabIndex = 53;
            this.lbTaxDeTail.Text = "0 VND";
            this.lbTaxDeTail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTax
            // 
            this.lbTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTax.AutoSize = true;
            this.lbTax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTax.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbTax.Location = new System.Drawing.Point(362, 448);
            this.lbTax.Name = "lbTax";
            this.lbTax.Size = new System.Drawing.Size(27, 15);
            this.lbTax.TabIndex = 52;
            this.lbTax.Text = "Tax:";
            this.lbTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSubTotalDeTail
            // 
            this.lbSubTotalDeTail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSubTotalDeTail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTotalDeTail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbSubTotalDeTail.Location = new System.Drawing.Point(441, 418);
            this.lbSubTotalDeTail.Name = "lbSubTotalDeTail";
            this.lbSubTotalDeTail.Size = new System.Drawing.Size(135, 30);
            this.lbSubTotalDeTail.TabIndex = 51;
            this.lbSubTotalDeTail.Text = "0 VND";
            this.lbSubTotalDeTail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTotal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbSubTotal.Location = new System.Drawing.Point(361, 426);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(59, 15);
            this.lbSubTotal.TabIndex = 50;
            this.lbSubTotal.Text = "Sub Total:";
            this.lbSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbIDBill
            // 
            this.lbIDBill.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDBill.ForeColor = System.Drawing.Color.White;
            this.lbIDBill.Location = new System.Drawing.Point(151, 11);
            this.lbIDBill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIDBill.Name = "lbIDBill";
            this.lbIDBill.Size = new System.Drawing.Size(73, 30);
            this.lbIDBill.TabIndex = 3;
            this.lbIDBill.Text = "No.";
            this.lbIDBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOrderList
            // 
            this.labelOrderList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderList.ForeColor = System.Drawing.Color.White;
            this.labelOrderList.Location = new System.Drawing.Point(5, 11);
            this.labelOrderList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderList.Name = "labelOrderList";
            this.labelOrderList.Size = new System.Drawing.Size(73, 30);
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
            this.pnlCategory.Location = new System.Drawing.Point(10, 10);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(340, 50);
            this.pnlCategory.TabIndex = 60;
            // 
            // btnCombo
            // 
            this.btnCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnCombo.FlatAppearance.BorderSize = 0;
            this.btnCombo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            this.btnCombo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            this.btnCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCombo.ForeColor = System.Drawing.Color.White;
            this.btnCombo.Location = new System.Drawing.Point(235, 10);
            this.btnCombo.Margin = new System.Windows.Forms.Padding(10);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(90, 30);
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
            this.btnDrink.ForeColor = System.Drawing.Color.White;
            this.btnDrink.Location = new System.Drawing.Point(125, 10);
            this.btnDrink.Margin = new System.Windows.Forms.Padding(10);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(90, 30);
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
            this.btnFood.ForeColor = System.Drawing.Color.White;
            this.btnFood.Location = new System.Drawing.Point(15, 10);
            this.btnFood.Margin = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(90, 30);
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
            this.pnlStatus.Location = new System.Drawing.Point(356, 10);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(235, 50);
            this.pnlStatus.TabIndex = 61;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(36)))), ((int)(((byte)(31)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(36)))), ((int)(((byte)(31)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(52, 10);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
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
            this.pnlSubBelow.Controls.Add(this.btnNew);
            this.pnlSubBelow.Controls.Add(this.btnAdd);
            this.pnlSubBelow.Location = new System.Drawing.Point(356, 525);
            this.pnlSubBelow.Name = "pnlSubBelow";
            this.pnlSubBelow.Size = new System.Drawing.Size(235, 50);
            this.pnlSubBelow.TabIndex = 62;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::QuanLiRapChieuPhim.Properties.Resources.icon_save;
            this.btnSave.Location = new System.Drawing.Point(188, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 50);
            this.btnSave.TabIndex = 43;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSave_MouseMove);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(140, 0);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(40, 50);
            this.btnNew.TabIndex = 42;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            this.btnNew.MouseLeave += new System.EventHandler(this.btnNew_MouseLeave);
            this.btnNew.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnNew_MouseMove);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle12.NullValue = null;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle12;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(588, 587);
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
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnSave;
    }
}