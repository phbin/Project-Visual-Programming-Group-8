
namespace QuanLiRapChieuPhim
{
    partial class FormMovie
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
            this.gradientPanelMovie = new QuanLiRapChieuPhim.GradientPanel();
            this.SuspendLayout();
            // 
            // gradientPanelMovie
            // 
            this.gradientPanelMovie.Angle = 90F;
            this.gradientPanelMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.gradientPanelMovie.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.gradientPanelMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelMovie.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelMovie.Name = "gradientPanelMovie";
            this.gradientPanelMovie.Size = new System.Drawing.Size(800, 450);
            this.gradientPanelMovie.TabIndex = 2;
            this.gradientPanelMovie.TopColor = System.Drawing.Color.Empty;
            // 
            // FormMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradientPanelMovie);
            this.Name = "FormMovie";
            this.Text = "FormMovie";
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelMovie;
    }
}