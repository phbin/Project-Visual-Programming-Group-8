
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
            this.gradientPanelStatistic = new QuanLiRapChieuPhim.GradientPanel();
            this.SuspendLayout();
            // 
            // gradientPanelStatistic
            // 
            this.gradientPanelStatistic.Angle = 90F;
            this.gradientPanelStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.gradientPanelStatistic.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.gradientPanelStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelStatistic.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelStatistic.Name = "gradientPanelStatistic";
            this.gradientPanelStatistic.Size = new System.Drawing.Size(800, 450);
            this.gradientPanelStatistic.TabIndex = 2;
            this.gradientPanelStatistic.TopColor = System.Drawing.Color.Empty;
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradientPanelStatistic);
            this.Name = "FormStatistic";
            this.Text = "FormStatistic";
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelStatistic;
    }
}