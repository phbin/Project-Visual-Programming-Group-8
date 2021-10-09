
namespace QuanLiRapChieuPhim
{
    partial class FormGeneral
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
            this.gradientPanelGeneral = new QuanLiRapChieuPhim.GradientPanel();
            this.SuspendLayout();
            // 
            // gradientPanelGeneral
            // 
            this.gradientPanelGeneral.Angle = 90F;
            this.gradientPanelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.gradientPanelGeneral.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.gradientPanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelGeneral.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelGeneral.Name = "gradientPanelGeneral";
            this.gradientPanelGeneral.Size = new System.Drawing.Size(800, 450);
            this.gradientPanelGeneral.TabIndex = 2;
            this.gradientPanelGeneral.TopColor = System.Drawing.Color.Empty;
            // 
            // FormGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradientPanelGeneral);
            this.Name = "FormGeneral";
            this.Text = "FormGeneral";
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelGeneral;
    }
}