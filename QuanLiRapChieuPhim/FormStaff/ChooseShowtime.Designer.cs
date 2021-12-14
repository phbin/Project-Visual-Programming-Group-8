
namespace QuanLiRapChieuPhim
{
    partial class ChooseShowtime
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpDay = new System.Windows.Forms.FlowLayoutPanel();
            this.pnLine = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flpTime = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(75, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1465, 57);
            this.panel1.TabIndex = 1;
            // 
            // flpDay
            // 
            this.flpDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpDay.Location = new System.Drawing.Point(75, 57);
            this.flpDay.Name = "flpDay";
            this.flpDay.Size = new System.Drawing.Size(1465, 135);
            this.flpDay.TabIndex = 2;
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.pnLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLine.Location = new System.Drawing.Point(75, 192);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(1465, 5);
            this.pnLine.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(75, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1465, 57);
            this.panel2.TabIndex = 4;
            // 
            // flpTime
            // 
            this.flpTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTime.Location = new System.Drawing.Point(75, 254);
            this.flpTime.Name = "flpTime";
            this.flpTime.Size = new System.Drawing.Size(1465, 586);
            this.flpTime.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::QuanLiRapChieuPhim.Properties.Resources.back_arrow;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 840);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ChooseShowtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1540, 840);
            this.Controls.Add(this.flpTime);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnLine);
            this.Controls.Add(this.flpDay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseShowtime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseShowtime";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpDay;
        private System.Windows.Forms.Panel pnLine;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flpTime;
    }
}