
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
            this.Datagrid = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FDButton = new System.Windows.Forms.Button();
            this.TicketButton = new System.Windows.Forms.Button();
            this.AllButton = new System.Windows.Forms.Button();
            this.YearButton = new System.Windows.Forms.Button();
            this.MonthButton = new System.Windows.Forms.Button();
            this.gradientPanelStatistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanelStatistic
            // 
            this.gradientPanelStatistic.Angle = 90F;
            this.gradientPanelStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.gradientPanelStatistic.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.gradientPanelStatistic.Controls.Add(this.Datagrid);
            this.gradientPanelStatistic.Controls.Add(this.btnExport);
            this.gradientPanelStatistic.Controls.Add(this.panel3);
            this.gradientPanelStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelStatistic.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelStatistic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientPanelStatistic.Name = "gradientPanelStatistic";
            this.gradientPanelStatistic.Size = new System.Drawing.Size(800, 450);
            this.gradientPanelStatistic.TabIndex = 2;
            this.gradientPanelStatistic.TopColor = System.Drawing.Color.Empty;
            // 
            // Datagrid
            // 
            this.Datagrid.AllowUserToAddRows = false;
            this.Datagrid.AllowUserToDeleteRows = false;
            this.Datagrid.AllowUserToResizeRows = false;
            this.Datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.Datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(54)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(54)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Datagrid.ColumnHeadersHeight = 35;
            this.Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Datagrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Datagrid.EnableHeadersVisualStyles = false;
            this.Datagrid.GridColor = System.Drawing.SystemColors.HotTrack;
            this.Datagrid.Location = new System.Drawing.Point(0, 59);
            this.Datagrid.Margin = new System.Windows.Forms.Padding(4);
            this.Datagrid.MultiSelect = false;
            this.Datagrid.Name = "Datagrid";
            this.Datagrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Datagrid.RowHeadersVisible = false;
            this.Datagrid.RowHeadersWidth = 62;
            this.Datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Datagrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Datagrid.RowTemplate.Height = 28;
            this.Datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Datagrid.Size = new System.Drawing.Size(800, 391);
            this.Datagrid.TabIndex = 52;
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Lato", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(440, 13);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(93, 32);
            this.btnExport.TabIndex = 55;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.FDButton);
            this.panel3.Controls.Add(this.TicketButton);
            this.panel3.Controls.Add(this.AllButton);
            this.panel3.Controls.Add(this.YearButton);
            this.panel3.Controls.Add(this.MonthButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 59);
            this.panel3.TabIndex = 57;
            // 
            // FDButton
            // 
            this.FDButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FDButton.AutoSize = true;
            this.FDButton.FlatAppearance.BorderSize = 0;
            this.FDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FDButton.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FDButton.ForeColor = System.Drawing.Color.White;
            this.FDButton.Image = global::QuanLiRapChieuPhim.Properties.Resources.sort_down;
            this.FDButton.Location = new System.Drawing.Point(657, 10);
            this.FDButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FDButton.Name = "FDButton";
            this.FDButton.Size = new System.Drawing.Size(137, 36);
            this.FDButton.TabIndex = 56;
            this.FDButton.Text = "  Ticket            ";
            this.FDButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FDButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FDButton.UseVisualStyleBackColor = true;
            this.FDButton.Click += new System.EventHandler(this.FDButton_Click);
            // 
            // TicketButton
            // 
            this.TicketButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TicketButton.AutoSize = true;
            this.TicketButton.FlatAppearance.BorderSize = 0;
            this.TicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TicketButton.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketButton.ForeColor = System.Drawing.Color.White;
            this.TicketButton.Image = global::QuanLiRapChieuPhim.Properties.Resources.sort_down;
            this.TicketButton.Location = new System.Drawing.Point(661, 10);
            this.TicketButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TicketButton.Name = "TicketButton";
            this.TicketButton.Size = new System.Drawing.Size(133, 36);
            this.TicketButton.TabIndex = 55;
            this.TicketButton.Text = "  Food/Drink";
            this.TicketButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TicketButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TicketButton.UseVisualStyleBackColor = true;
            this.TicketButton.Click += new System.EventHandler(this.TicketButton_Click);
            // 
            // AllButton
            // 
            this.AllButton.AutoSize = true;
            this.AllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.AllButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AllButton.FlatAppearance.BorderSize = 0;
            this.AllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllButton.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllButton.ForeColor = System.Drawing.Color.Black;
            this.AllButton.Location = new System.Drawing.Point(288, 0);
            this.AllButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AllButton.Name = "AllButton";
            this.AllButton.Size = new System.Drawing.Size(144, 59);
            this.AllButton.TabIndex = 23;
            this.AllButton.Text = "All";
            this.AllButton.UseVisualStyleBackColor = false;
            this.AllButton.Click += new System.EventHandler(this.AllButton_Click);
            // 
            // YearButton
            // 
            this.YearButton.AutoSize = true;
            this.YearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.YearButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.YearButton.FlatAppearance.BorderSize = 0;
            this.YearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YearButton.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearButton.ForeColor = System.Drawing.Color.Black;
            this.YearButton.Location = new System.Drawing.Point(144, 0);
            this.YearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YearButton.Name = "YearButton";
            this.YearButton.Size = new System.Drawing.Size(144, 59);
            this.YearButton.TabIndex = 20;
            this.YearButton.Text = "Year";
            this.YearButton.UseVisualStyleBackColor = false;
            this.YearButton.Click += new System.EventHandler(this.YearButton_Click);
            // 
            // MonthButton
            // 
            this.MonthButton.AutoSize = true;
            this.MonthButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.MonthButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MonthButton.FlatAppearance.BorderSize = 0;
            this.MonthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthButton.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthButton.ForeColor = System.Drawing.Color.Black;
            this.MonthButton.Location = new System.Drawing.Point(0, 0);
            this.MonthButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MonthButton.Name = "MonthButton";
            this.MonthButton.Size = new System.Drawing.Size(144, 59);
            this.MonthButton.TabIndex = 21;
            this.MonthButton.Text = "Month";
            this.MonthButton.UseVisualStyleBackColor = false;
            this.MonthButton.Click += new System.EventHandler(this.MonthButton_Click);
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradientPanelStatistic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStatistic";
            this.Text = "FormStatistic";
            this.gradientPanelStatistic.ResumeLayout(false);
            this.gradientPanelStatistic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelStatistic;
        private System.Windows.Forms.Button AllButton;
        private System.Windows.Forms.Button MonthButton;
        private System.Windows.Forms.Button YearButton;
        private System.Windows.Forms.Button FDButton;
        private System.Windows.Forms.Button TicketButton;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView Datagrid;
    }
}