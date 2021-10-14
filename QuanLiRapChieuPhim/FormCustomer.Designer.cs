
namespace QuanLiRapChieuPhim
{
    partial class FormCustomer
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
            this.gradientPanelCustomer = new QuanLiRapChieuPhim.GradientPanel();
            this.SuspendLayout();
            // 
            // gradientPanelCustomer
            // 
            this.gradientPanelCustomer.Angle = 90F;
            this.gradientPanelCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.gradientPanelCustomer.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.gradientPanelCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelCustomer.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelCustomer.Name = "gradientPanelCustomer";
            this.gradientPanelCustomer.Size = new System.Drawing.Size(800, 450);
            this.gradientPanelCustomer.TabIndex = 2;
            this.gradientPanelCustomer.TopColor = System.Drawing.Color.Empty;
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradientPanelCustomer);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelCustomer;
    }
}