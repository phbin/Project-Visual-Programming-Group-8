
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGeneral));
            this.imageListPoster = new System.Windows.Forms.ImageList(this.components);
            this.timerImage = new System.Windows.Forms.Timer(this.components);
            this.gradientPanelGeneral = new QuanLiRapChieuPhim.GradientPanel();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.pictureBoxPoster = new System.Windows.Forms.PictureBox();
            this.gradientPanelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListPoster
            // 
            this.imageListPoster.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPoster.ImageStream")));
            this.imageListPoster.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPoster.Images.SetKeyName(0, "Poster1.jpg");
            this.imageListPoster.Images.SetKeyName(1, "Poster2.jpg");
            this.imageListPoster.Images.SetKeyName(2, "Poster3.jpg");
            this.imageListPoster.Images.SetKeyName(3, "Poster4.jpg");
            this.imageListPoster.Images.SetKeyName(4, "Poster5.jpg");
            // 
            // timerImage
            // 
            this.timerImage.Enabled = true;
            this.timerImage.Interval = 1500;
            this.timerImage.Tick += new System.EventHandler(this.timerImage_Tick);
            // 
            // gradientPanelGeneral
            // 
            this.gradientPanelGeneral.Angle = 90F;
            this.gradientPanelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.gradientPanelGeneral.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.gradientPanelGeneral.Controls.Add(this.btn5);
            this.gradientPanelGeneral.Controls.Add(this.btn4);
            this.gradientPanelGeneral.Controls.Add(this.btn3);
            this.gradientPanelGeneral.Controls.Add(this.btn2);
            this.gradientPanelGeneral.Controls.Add(this.btn1);
            this.gradientPanelGeneral.Controls.Add(this.pictureBoxPoster);
            this.gradientPanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelGeneral.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelGeneral.Name = "gradientPanelGeneral";
            this.gradientPanelGeneral.Size = new System.Drawing.Size(1262, 734);
            this.gradientPanelGeneral.TabIndex = 2;
            this.gradientPanelGeneral.TopColor = System.Drawing.Color.Empty;
            // 
            // btn5
            // 
            this.btn5.AutoSize = true;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Image = ((System.Drawing.Image)(resources.GetObject("btn5.Image")));
            this.btn5.Location = new System.Drawing.Point(693, 678);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(30, 30);
            this.btn5.TabIndex = 5;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.AutoSize = true;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Image = ((System.Drawing.Image)(resources.GetObject("btn4.Image")));
            this.btn4.Location = new System.Drawing.Point(651, 678);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(30, 30);
            this.btn4.TabIndex = 4;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Image = ((System.Drawing.Image)(resources.GetObject("btn3.Image")));
            this.btn3.Location = new System.Drawing.Point(608, 678);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(30, 30);
            this.btn3.TabIndex = 3;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Image = ((System.Drawing.Image)(resources.GetObject("btn2.Image")));
            this.btn2.Location = new System.Drawing.Point(566, 678);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(30, 30);
            this.btn2.TabIndex = 2;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Image = global::QuanLiRapChieuPhim.Properties.Resources.new_moon;
            this.btn1.Location = new System.Drawing.Point(523, 678);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(30, 30);
            this.btn1.TabIndex = 1;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // pictureBoxPoster
            // 
            this.pictureBoxPoster.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxPoster.Image = global::QuanLiRapChieuPhim.Properties.Resources.Poster1;
            this.pictureBoxPoster.Location = new System.Drawing.Point(405, 23);
            this.pictureBoxPoster.Name = "pictureBoxPoster";
            this.pictureBoxPoster.Size = new System.Drawing.Size(450, 630);
            this.pictureBoxPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPoster.TabIndex = 0;
            this.pictureBoxPoster.TabStop = false;
            // 
            // FormGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 734);
            this.Controls.Add(this.gradientPanelGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGeneral";
            this.Text = "FormGeneral";
            this.gradientPanelGeneral.ResumeLayout(false);
            this.gradientPanelGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageListPoster;
        private System.Windows.Forms.Timer timerImage;
        private GradientPanel gradientPanelGeneral;
        private System.Windows.Forms.PictureBox pictureBoxPoster;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
    }
}