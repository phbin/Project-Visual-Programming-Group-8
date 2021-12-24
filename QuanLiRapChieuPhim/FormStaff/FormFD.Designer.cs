
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFD));
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.datagridviewBill = new System.Windows.Forms.DataGridView();
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
            this.dgvColumnNameFD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnRemove = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.flowLayoutPanel.Size = new System.Drawing.Size(875, 726);
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
            this.datagridviewBill.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.datagridviewBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridviewBill.ColumnHeadersHeight = 30;
            this.datagridviewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridviewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnNameFD,
            this.dgvColumnQuantity,
            this.dgvColumnPrice,
            this.dgvColumnTotalPrice,
            this.dgvColumnRemove});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridviewBill.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridviewBill.EnableHeadersVisualStyles = false;
            this.datagridviewBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            this.datagridviewBill.Location = new System.Drawing.Point(902, 81);
            this.datagridviewBill.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.datagridviewBill.Name = "datagridviewBill";
            this.datagridviewBill.ReadOnly = true;
            this.datagridviewBill.RowHeadersVisible = false;
            this.datagridviewBill.RowHeadersWidth = 51;
            this.datagridviewBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridviewBill.RowTemplate.ReadOnly = true;
            this.datagridviewBill.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridviewBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewBill.Size = new System.Drawing.Size(400, 521);
            this.datagridviewBill.TabIndex = 58;
            this.datagridviewBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellClick);
            // 
            // nmFDCount
            // 
            this.nmFDCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nmFDCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmFDCount.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmFDCount.Location = new System.Drawing.Point(11, 15);
            this.nmFDCount.Margin = new System.Windows.Forms.Padding(11, 12, 5, 12);
            this.nmFDCount.Name = "nmFDCount";
            this.nmFDCount.Size = new System.Drawing.Size(58, 35);
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
            this.lbTotalDetail.Location = new System.Drawing.Point(1074, 693);
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
            this.pnlLine.Location = new System.Drawing.Point(897, 674);
            this.pnlLine.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(405, 10);
            this.pnlLine.TabIndex = 54;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Lato", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbTotal.Location = new System.Drawing.Point(896, 695);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(55, 23);
            this.lbTotal.TabIndex = 55;
            this.lbTotal.Text = "Total:";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTaxDeTail
            // 
            this.lbTaxDeTail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTaxDeTail.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaxDeTail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbTaxDeTail.Location = new System.Drawing.Point(1098, 642);
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
            this.lbTax.Location = new System.Drawing.Point(898, 649);
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
            this.lbSubTotalDeTail.Location = new System.Drawing.Point(1102, 614);
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
            this.lbSubTotal.Location = new System.Drawing.Point(896, 622);
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
            this.lbIDBill.Location = new System.Drawing.Point(273, 13);
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
            this.btnCombo.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnDrink.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnFood.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pnlStatus.Location = new System.Drawing.Point(902, 12);
            this.pnlStatus.Margin = new System.Windows.Forms.Padding(4);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(400, 62);
            this.pnlStatus.TabIndex = 61;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(36)))), ((int)(((byte)(31)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(36)))), ((int)(((byte)(31)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(84, 13);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 37);
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
            this.pnlSubBelow.Location = new System.Drawing.Point(902, 746);
            this.pnlSubBelow.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSubBelow.Name = "pnlSubBelow";
            this.pnlSubBelow.Size = new System.Drawing.Size(400, 62);
            this.pnlSubBelow.TabIndex = 62;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.btnSave.BackgroundImage = global::QuanLiRapChieuPhim.Properties.Resources.icon_save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(351, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(44, 51);
            this.btnSave.TabIndex = 43;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(71)))), ((int)(((byte)(65)))));
            this.btnDeleteAll.FlatAppearance.BorderSize = 0;
            this.btnDeleteAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(36)))), ((int)(((byte)(31)))));
            this.btnDeleteAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(36)))), ((int)(((byte)(31)))));
            this.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAll.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAll.Location = new System.Drawing.Point(217, 13);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(120, 37);
            this.btnDeleteAll.TabIndex = 42;
            this.btnDeleteAll.Text = "DeleteAll";
            this.btnDeleteAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle4;
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
            // dgvColumnNameFD
            // 
            this.dgvColumnNameFD.FillWeight = 150F;
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
            this.dgvColumnPrice.FillWeight = 50F;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.dgvColumnRemove.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvColumnRemove.FillWeight = 47.87235F;
            this.dgvColumnRemove.HeaderText = "";
            this.dgvColumnRemove.Image = global::QuanLiRapChieuPhim.Properties.Resources.TrashIcon_01;
            this.dgvColumnRemove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvColumnRemove.MinimumWidth = 8;
            this.dgvColumnRemove.Name = "dgvColumnRemove";
            this.dgvColumnRemove.ReadOnly = true;
            this.dgvColumnRemove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FormFD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1298, 822);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnNameFD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnTotalPrice;
        private System.Windows.Forms.DataGridViewImageColumn dgvColumnRemove;
    }
}