
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
            this.SuspendLayout();
            // 
            // gradientPanelFD
            // 
            this.gradientPanelFD.Angle = 90F;
            this.gradientPanelFD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.gradientPanelFD.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.gradientPanelFD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelFD.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelFD.Name = "gradientPanelFD";
            this.gradientPanelFD.Size = new System.Drawing.Size(800, 450);
            this.gradientPanelFD.TabIndex = 2;
            this.gradientPanelFD.TopColor = System.Drawing.Color.Empty;
            // 
            // FormFD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradientPanelFD);
            this.Name = "FormFD";
            this.Text = "FormFD";
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelFD;
    }
}