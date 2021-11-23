
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovie));
            this.lbName = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.picBoxPoster = new System.Windows.Forms.PictureBox();
            this.lbDesc = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelMovie = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panelLine = new System.Windows.Forms.Panel();
            this.buttonStt1 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.labelSTT = new System.Windows.Forms.Label();
            this.flpMovie = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPoster)).BeginInit();
            this.panelMovie.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(94, 53);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(130, 49);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // lbInfo
            // 
            this.lbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.ForeColor = System.Drawing.Color.White;
            this.lbInfo.Location = new System.Drawing.Point(590, 152);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(180, 297);
            this.lbInfo.TabIndex = 1;
            this.lbInfo.Text = "Genre: \r\n\r\nDirector: \r\n\r\nCountry:\r\n\r\nRelease Date: \r\n\r\nRunning Time:";
            // 
            // picBoxPoster
            // 
            this.picBoxPoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxPoster.Location = new System.Drawing.Point(103, 152);
            this.picBoxPoster.Name = "picBoxPoster";
            this.picBoxPoster.Size = new System.Drawing.Size(450, 475);
            this.picBoxPoster.TabIndex = 2;
            this.picBoxPoster.TabStop = false;
            // 
            // lbDesc
            // 
            this.lbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDesc.AutoSize = true;
            this.lbDesc.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesc.ForeColor = System.Drawing.Color.White;
            this.lbDesc.Location = new System.Drawing.Point(97, 654);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(153, 33);
            this.lbDesc.TabIndex = 3;
            this.lbDesc.Text = "Description:\r\n";
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 753);
            this.btnBack.TabIndex = 12;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelMovie
            // 
            this.panelMovie.Controls.Add(this.lbName);
            this.panelMovie.Controls.Add(this.button2);
            this.panelMovie.Controls.Add(this.btnBack);
            this.panelMovie.Controls.Add(this.lbDesc);
            this.panelMovie.Controls.Add(this.picBoxPoster);
            this.panelMovie.Controls.Add(this.lbInfo);
            this.panelMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMovie.Location = new System.Drawing.Point(0, 0);
            this.panelMovie.Name = "panelMovie";
            this.panelMovie.Size = new System.Drawing.Size(832, 753);
            this.panelMovie.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(596, 529);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 60);
            this.button2.TabIndex = 13;
            this.button2.Text = "Booking";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLine.Location = new System.Drawing.Point(0, 76);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(832, 3);
            this.panelLine.TabIndex = 39;
            // 
            // buttonStt1
            // 
            this.buttonStt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStt1.AutoSize = true;
            this.buttonStt1.FlatAppearance.BorderSize = 0;
            this.buttonStt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStt1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStt1.ForeColor = System.Drawing.Color.White;
            this.buttonStt1.Location = new System.Drawing.Point(600, 31);
            this.buttonStt1.Name = "buttonStt1";
            this.buttonStt1.Size = new System.Drawing.Size(232, 48);
            this.buttonStt1.TabIndex = 1;
            this.buttonStt1.Text = "COMING SOON";
            this.buttonStt1.UseVisualStyleBackColor = true;
            this.buttonStt1.Click += new System.EventHandler(this.buttonStt1_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labelSTT);
            this.panel.Controls.Add(this.buttonStt1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(832, 76);
            this.panel.TabIndex = 38;
            // 
            // labelSTT
            // 
            this.labelSTT.AutoSize = true;
            this.labelSTT.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSTT.ForeColor = System.Drawing.Color.White;
            this.labelSTT.Location = new System.Drawing.Point(3, 4);
            this.labelSTT.Name = "labelSTT";
            this.labelSTT.Size = new System.Drawing.Size(269, 54);
            this.labelSTT.TabIndex = 2;
            this.labelSTT.Text = "Now Showing";
            // 
            // flpMovie
            // 
            this.flpMovie.AutoScroll = true;
            this.flpMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.flpMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMovie.Location = new System.Drawing.Point(0, 79);
            this.flpMovie.Name = "flpMovie";
            this.flpMovie.Size = new System.Drawing.Size(832, 674);
            this.flpMovie.TabIndex = 43;
            // 
            // FormMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(832, 753);
            this.Controls.Add(this.flpMovie);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelMovie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMovie";
            this.Text = "FormMovie";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPoster)).EndInit();
            this.panelMovie.ResumeLayout(false);
            this.panelMovie.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.PictureBox picBoxPoster;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelMovie;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Button buttonStt1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelSTT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flpMovie;
    }
}