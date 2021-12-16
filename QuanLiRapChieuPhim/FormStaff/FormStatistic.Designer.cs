
namespace QuanLiRapChieuPhim
{
    partial class FormStatistic
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
            this.gradientPanelStatistic = new QuanLiRapChieuPhim.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtg = new System.Windows.Forms.DataGridView();
            this.AllButton = new System.Windows.Forms.Button();
            this.MonthButton = new System.Windows.Forms.Button();
            this.YearButton = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.gradientPanelStatistic.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanelStatistic
            // 
            this.gradientPanelStatistic.Angle = 90F;
            this.gradientPanelStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.gradientPanelStatistic.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.gradientPanelStatistic.Controls.Add(this.btnExport);
            this.gradientPanelStatistic.Controls.Add(this.panel1);
            this.gradientPanelStatistic.Controls.Add(this.AllButton);
            this.gradientPanelStatistic.Controls.Add(this.MonthButton);
            this.gradientPanelStatistic.Controls.Add(this.YearButton);
            this.gradientPanelStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelStatistic.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelStatistic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gradientPanelStatistic.Name = "gradientPanelStatistic";
            this.gradientPanelStatistic.Size = new System.Drawing.Size(600, 365);
            this.gradientPanelStatistic.TabIndex = 2;
            this.gradientPanelStatistic.TopColor = System.Drawing.Color.Empty;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dtg);
            this.panel1.Location = new System.Drawing.Point(8, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 327);
            this.panel1.TabIndex = 53;
            // 
            // dtg
            // 
            this.dtg.AllowUserToAddRows = false;
            this.dtg.AllowUserToDeleteRows = false;
            this.dtg.AllowUserToResizeRows = false;
            this.dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.dtg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg.ColumnHeadersHeight = 25;
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg.EnableHeadersVisualStyles = false;
            this.dtg.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dtg.Location = new System.Drawing.Point(0, 0);
            this.dtg.MultiSelect = false;
            this.dtg.Name = "dtg";
            this.dtg.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg.RowHeadersVisible = false;
            this.dtg.RowHeadersWidth = 62;
            this.dtg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtg.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg.Size = new System.Drawing.Size(584, 327);
            this.dtg.TabIndex = 52;
            // 
            // AllButton
            // 
            this.AllButton.AutoSize = true;
            this.AllButton.BackColor = System.Drawing.Color.Gray;
            this.AllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllButton.ForeColor = System.Drawing.Color.White;
            this.AllButton.Location = new System.Drawing.Point(201, 0);
            this.AllButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AllButton.Name = "AllButton";
            this.AllButton.Size = new System.Drawing.Size(118, 34);
            this.AllButton.TabIndex = 23;
            this.AllButton.Text = "All";
            this.AllButton.UseVisualStyleBackColor = false;
            this.AllButton.Click += new System.EventHandler(this.AllButton_Click);
            // 
            // MonthButton
            // 
            this.MonthButton.AutoSize = true;
            this.MonthButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MonthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthButton.ForeColor = System.Drawing.Color.White;
            this.MonthButton.Location = new System.Drawing.Point(101, 0);
            this.MonthButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MonthButton.Name = "MonthButton";
            this.MonthButton.Size = new System.Drawing.Size(101, 34);
            this.MonthButton.TabIndex = 21;
            this.MonthButton.Text = "Month";
            this.MonthButton.UseVisualStyleBackColor = false;
            this.MonthButton.Click += new System.EventHandler(this.MonthButton_Click);
            // 
            // YearButton
            // 
            this.YearButton.AutoSize = true;
            this.YearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.YearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YearButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearButton.ForeColor = System.Drawing.Color.White;
            this.YearButton.Location = new System.Drawing.Point(0, 0);
            this.YearButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.YearButton.Name = "YearButton";
            this.YearButton.Size = new System.Drawing.Size(101, 34);
            this.YearButton.TabIndex = 20;
            this.YearButton.Text = "Year";
            this.YearButton.UseVisualStyleBackColor = false;
            this.YearButton.Click += new System.EventHandler(this.YearButton_Click);
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.BackColor = System.Drawing.Color.Gray;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(480, 3);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(118, 34);
            this.btnExport.TabIndex = 54;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 365);
            this.Controls.Add(this.gradientPanelStatistic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormStatistic";
            this.Text = "FormStatistic";
            this.gradientPanelStatistic.ResumeLayout(false);
            this.gradientPanelStatistic.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelStatistic;
        private System.Windows.Forms.Button AllButton;
        private System.Windows.Forms.Button MonthButton;
        private System.Windows.Forms.Button YearButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.Button btnExport;
    }
}