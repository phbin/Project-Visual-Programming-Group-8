
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
            this.flpFood = new System.Windows.Forms.FlowLayoutPanel();
            this.flpDrink = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCombo = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBill = new System.Windows.Forms.Panel();
            this.lstvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlLine4 = new System.Windows.Forms.Panel();
            this.cbbTypeSelection = new System.Windows.Forms.ComboBox();
            this.pnlLine3 = new System.Windows.Forms.Panel();
            this.pnlLine2 = new System.Windows.Forms.Panel();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.nmFDCount = new System.Windows.Forms.NumericUpDown();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gradientPanelFD.SuspendLayout();
            this.pnlBill.SuspendLayout();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFDCount)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanelFD
            // 
            this.gradientPanelFD.Angle = 90F;
            this.gradientPanelFD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.gradientPanelFD.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.gradientPanelFD.Controls.Add(this.flpFood);
            this.gradientPanelFD.Controls.Add(this.flpDrink);
            this.gradientPanelFD.Controls.Add(this.flpCombo);
            this.gradientPanelFD.Controls.Add(this.pnlBill);
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
            // flpFood
            // 
            this.flpFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpFood.AutoScroll = true;
            this.flpFood.BackColor = System.Drawing.Color.Snow;
            this.flpFood.Location = new System.Drawing.Point(0, 5);
            this.flpFood.Name = "flpFood";
            this.flpFood.Size = new System.Drawing.Size(318, 471);
            this.flpFood.TabIndex = 7;
            // 
            // flpDrink
            // 
            this.flpDrink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpDrink.AutoScroll = true;
            this.flpDrink.BackColor = System.Drawing.Color.Snow;
            this.flpDrink.Location = new System.Drawing.Point(0, 5);
            this.flpDrink.Name = "flpDrink";
            this.flpDrink.Size = new System.Drawing.Size(318, 471);
            this.flpDrink.TabIndex = 6;
            // 
            // flpCombo
            // 
            this.flpCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpCombo.AutoScroll = true;
            this.flpCombo.BackColor = System.Drawing.Color.Snow;
            this.flpCombo.Location = new System.Drawing.Point(0, 5);
            this.flpCombo.Name = "flpCombo";
            this.flpCombo.Size = new System.Drawing.Size(318, 471);
            this.flpCombo.TabIndex = 5;
            // 
            // pnlBill
            // 
            this.pnlBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(98)))), ((int)(((byte)(101)))));
            this.pnlBill.Controls.Add(this.lstvBill);
            this.pnlBill.Controls.Add(this.pnlLine4);
            this.pnlBill.Controls.Add(this.cbbTypeSelection);
            this.pnlBill.Controls.Add(this.pnlLine3);
            this.pnlBill.Controls.Add(this.pnlLine2);
            this.pnlBill.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBill.Location = new System.Drawing.Point(318, 5);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(258, 471);
            this.pnlBill.TabIndex = 4;
            // 
            // lstvBill
            // 
            this.lstvBill.BackColor = System.Drawing.Color.Snow;
            this.lstvBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader5});
            this.lstvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvBill.GridLines = true;
            this.lstvBill.HideSelection = false;
            this.lstvBill.Location = new System.Drawing.Point(5, 29);
            this.lstvBill.Name = "lstvBill";
            this.lstvBill.Size = new System.Drawing.Size(248, 442);
            this.lstvBill.TabIndex = 4;
            this.lstvBill.UseCompatibleStateImageBehavior = false;
            this.lstvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Description";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Qty";
            this.columnHeader4.Width = 32;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 52;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total";
            this.columnHeader5.Width = 74;
            // 
            // pnlLine4
            // 
            this.pnlLine4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine4.Location = new System.Drawing.Point(5, 24);
            this.pnlLine4.Name = "pnlLine4";
            this.pnlLine4.Size = new System.Drawing.Size(248, 5);
            this.pnlLine4.TabIndex = 3;
            // 
            // cbbTypeSelection
            // 
            this.cbbTypeSelection.BackColor = System.Drawing.Color.Snow;
            this.cbbTypeSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbbTypeSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbTypeSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTypeSelection.FormattingEnabled = true;
            this.cbbTypeSelection.Items.AddRange(new object[] {
            "Combo",
            "Food",
            "Drink"});
            this.cbbTypeSelection.Location = new System.Drawing.Point(5, 0);
            this.cbbTypeSelection.Name = "cbbTypeSelection";
            this.cbbTypeSelection.Size = new System.Drawing.Size(248, 24);
            this.cbbTypeSelection.TabIndex = 2;
            this.cbbTypeSelection.SelectedIndexChanged += new System.EventHandler(this.cbbTypeSelection_SelectedIndexChanged);
            // 
            // pnlLine3
            // 
            this.pnlLine3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLine3.Location = new System.Drawing.Point(253, 0);
            this.pnlLine3.Name = "pnlLine3";
            this.pnlLine3.Size = new System.Drawing.Size(5, 471);
            this.pnlLine3.TabIndex = 1;
            // 
            // pnlLine2
            // 
            this.pnlLine2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLine2.Location = new System.Drawing.Point(0, 0);
            this.pnlLine2.Name = "pnlLine2";
            this.pnlLine2.Size = new System.Drawing.Size(5, 471);
            this.pnlLine2.TabIndex = 0;
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
            this.pnlControl.Controls.Add(this.txtTotalPrice);
            this.pnlControl.Controls.Add(this.nmFDCount);
            this.pnlControl.Controls.Add(this.btnPay);
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
            this.txtTotalPrice.Location = new System.Drawing.Point(323, 27);
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
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(461, 10);
            this.btnPay.Margin = new System.Windows.Forms.Padding(10);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(100, 60);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
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
            this.pnlBill.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFDCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelFD;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlBill;
        private System.Windows.Forms.Panel pnlLine2;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.ListView lstvBill;
        private System.Windows.Forms.Panel pnlLine4;
        private System.Windows.Forms.ComboBox cbbTypeSelection;
        private System.Windows.Forms.Panel pnlLine3;
        private System.Windows.Forms.NumericUpDown nmFDCount;
        private System.Windows.Forms.FlowLayoutPanel flpCombo;
        private System.Windows.Forms.FlowLayoutPanel flpDrink;
        private System.Windows.Forms.FlowLayoutPanel flpFood;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtTotalPrice;
    }
}