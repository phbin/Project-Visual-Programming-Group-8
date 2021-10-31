namespace QuanLiRapChieuPhim
{
    partial class FormAdmin
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
            this.ListAccountGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListAccountGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ListAccountGrid
            // 
            this.ListAccountGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListAccountGrid.Location = new System.Drawing.Point(12, 12);
            this.ListAccountGrid.Name = "ListAccountGrid";
            this.ListAccountGrid.RowHeadersWidth = 62;
            this.ListAccountGrid.RowTemplate.Height = 28;
            this.ListAccountGrid.Size = new System.Drawing.Size(1056, 664);
            this.ListAccountGrid.TabIndex = 0;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 688);
            this.Controls.Add(this.ListAccountGrid);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.ListAccountGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListAccountGrid;
    }
}