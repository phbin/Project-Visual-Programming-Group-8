
namespace QuanLiRapChieuPhim
{
    partial class FormBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBooking));
            this.lbName = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbInfo1 = new System.Windows.Forms.Label();
            this.lbPriceInfo = new System.Windows.Forms.Label();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.flpSeat = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUnavailable = new System.Windows.Forms.Label();
            this.lbChecked = new System.Windows.Forms.Label();
            this.lbAvailable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelDesk = new System.Windows.Forms.Panel();
            this.pnInfo.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(198, 41);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(63, 24);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.ForeColor = System.Drawing.Color.White;
            this.lbInfo.Location = new System.Drawing.Point(661, 38);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(98, 72);
            this.lbInfo.TabIndex = 4;
            this.lbInfo.Text = "Showtime\r\n\r\nCinema";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.White;
            this.lbPrice.Location = new System.Drawing.Point(1197, 38);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(87, 72);
            this.lbPrice.TabIndex = 5;
            this.lbPrice.Text = "Quantity\r\n\r\nTotal";
            // 
            // lbInfo1
            // 
            this.lbInfo1.AutoSize = true;
            this.lbInfo1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo1.ForeColor = System.Drawing.Color.White;
            this.lbInfo1.Location = new System.Drawing.Point(783, 38);
            this.lbInfo1.Name = "lbInfo1";
            this.lbInfo1.Size = new System.Drawing.Size(45, 72);
            this.lbInfo1.TabIndex = 6;
            this.lbInfo1.Text = "Info\r\n\r\nInfo";
            // 
            // lbPriceInfo
            // 
            this.lbPriceInfo.AutoSize = true;
            this.lbPriceInfo.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceInfo.ForeColor = System.Drawing.Color.White;
            this.lbPriceInfo.Location = new System.Drawing.Point(1312, 38);
            this.lbPriceInfo.Name = "lbPriceInfo";
            this.lbPriceInfo.Size = new System.Drawing.Size(70, 72);
            this.lbPriceInfo.TabIndex = 7;
            this.lbPriceInfo.Text = "0 \r\n\r\n0 VND\r\n";
            // 
            // pnInfo
            // 
            this.pnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.pnInfo.Controls.Add(this.lbPriceInfo);
            this.pnInfo.Controls.Add(this.lbInfo1);
            this.pnInfo.Controls.Add(this.lbPrice);
            this.pnInfo.Controls.Add(this.lbInfo);
            this.pnInfo.Controls.Add(this.lbName);
            this.pnInfo.Controls.Add(this.pbPoster);
            this.pnInfo.Controls.Add(this.btnNext);
            this.pnInfo.Controls.Add(this.btnBack);
            this.pnInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnInfo.Location = new System.Drawing.Point(0, 680);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(1540, 160);
            this.pnInfo.TabIndex = 3;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.pnMain.BackgroundImage = global::QuanLiRapChieuPhim.Properties.Resources.screen;
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnMain.Controls.Add(this.panelDesk);
            this.pnMain.Controls.Add(this.flpSeat);
            this.pnMain.Controls.Add(this.panel1);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1540, 680);
            this.pnMain.TabIndex = 2;
            // 
            // flpSeat
            // 
            this.flpSeat.Location = new System.Drawing.Point(397, 157);
            this.flpSeat.Name = "flpSeat";
            this.flpSeat.Size = new System.Drawing.Size(753, 452);
            this.flpSeat.TabIndex = 99;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbUnavailable);
            this.panel1.Controls.Add(this.lbChecked);
            this.panel1.Controls.Add(this.lbAvailable);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(427, 615);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 60);
            this.panel1.TabIndex = 97;
            // 
            // lbUnavailable
            // 
            this.lbUnavailable.AutoSize = true;
            this.lbUnavailable.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnavailable.ForeColor = System.Drawing.Color.White;
            this.lbUnavailable.Location = new System.Drawing.Point(526, 16);
            this.lbUnavailable.Name = "lbUnavailable";
            this.lbUnavailable.Size = new System.Drawing.Size(123, 28);
            this.lbUnavailable.TabIndex = 7;
            this.lbUnavailable.Text = "Unavailable";
            // 
            // lbChecked
            // 
            this.lbChecked.AutoSize = true;
            this.lbChecked.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChecked.ForeColor = System.Drawing.Color.White;
            this.lbChecked.Location = new System.Drawing.Point(298, 16);
            this.lbChecked.Name = "lbChecked";
            this.lbChecked.Size = new System.Drawing.Size(91, 28);
            this.lbChecked.TabIndex = 6;
            this.lbChecked.Text = "Checked";
            // 
            // lbAvailable
            // 
            this.lbAvailable.AutoSize = true;
            this.lbAvailable.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvailable.ForeColor = System.Drawing.Color.White;
            this.lbAvailable.Location = new System.Drawing.Point(70, 16);
            this.lbAvailable.Name = "lbAvailable";
            this.lbAvailable.Size = new System.Drawing.Size(100, 28);
            this.lbAvailable.TabIndex = 5;
            this.lbAvailable.Text = "Available";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.label3.Location = new System.Drawing.Point(469, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 30);
            this.label3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(154)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(245, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 30);
            this.label2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 30);
            this.label1.TabIndex = 2;
            // 
            // pbPoster
            // 
            this.pbPoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPoster.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbPoster.Location = new System.Drawing.Point(80, 0);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(112, 160);
            this.pbPoster.TabIndex = 2;
            this.pbPoster.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(1460, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 160);
            this.btnNext.TabIndex = 1;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 160);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelDesk
            // 
            this.panelDesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesk.Location = new System.Drawing.Point(0, 0);
            this.panelDesk.Name = "panelDesk";
            this.panelDesk.Size = new System.Drawing.Size(1540, 680);
            this.panelDesk.TabIndex = 101;
            // 
            // FormBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 840);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBooking";
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbUnavailable;
        private System.Windows.Forms.Label lbChecked;
        private System.Windows.Forms.Label lbAvailable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbInfo1;
        private System.Windows.Forms.Label lbPriceInfo;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.FlowLayoutPanel flpSeat;
        private System.Windows.Forms.Panel panelDesk;
    }
}