
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.panelLine = new System.Windows.Forms.Panel();
            this.labelHome = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonRestoreDown = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            this.gradientPanelDesktop = new QuanLiRapChieuPhim.GradientPanel();
            this.gradientPanelMenu = new QuanLiRapChieuPhim.GradientPanel();
            this.ButtonFD = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.buttonShowtime = new System.Windows.Forms.Button();
            this.Movie = new System.Windows.Forms.Button();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonHRM = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            this.gradientPanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.panelLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLine.Location = new System.Drawing.Point(260, 58);
            this.panelLine.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(1298, 7);
            this.panelLine.TabIndex = 4;
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.BackColor = System.Drawing.Color.Transparent;
            this.labelHome.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.Color.White;
            this.labelHome.Location = new System.Drawing.Point(68, 20);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(63, 24);
            this.labelHome.TabIndex = 1;
            this.labelHome.Text = "Home";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.panelMenu.Controls.Add(this.buttonMaximize);
            this.panelMenu.Controls.Add(this.buttonRestoreDown);
            this.panelMenu.Controls.Add(this.buttonMinimize);
            this.panelMenu.Controls.Add(this.buttonClose);
            this.panelMenu.Controls.Add(this.labelHome);
            this.panelMenu.Controls.Add(this.pictureHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(260, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1298, 58);
            this.panelMenu.TabIndex = 3;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaximize.Image")));
            this.buttonMaximize.Location = new System.Drawing.Point(1207, 7);
            this.buttonMaximize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.buttonMaximize.Size = new System.Drawing.Size(40, 39);
            this.buttonMaximize.TabIndex = 4;
            this.buttonMaximize.UseVisualStyleBackColor = false;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonRestoreDown
            // 
            this.buttonRestoreDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestoreDown.BackColor = System.Drawing.Color.Transparent;
            this.buttonRestoreDown.FlatAppearance.BorderSize = 0;
            this.buttonRestoreDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestoreDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonRestoreDown.Image")));
            this.buttonRestoreDown.Location = new System.Drawing.Point(1207, 7);
            this.buttonRestoreDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRestoreDown.Name = "buttonRestoreDown";
            this.buttonRestoreDown.Padding = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.buttonRestoreDown.Size = new System.Drawing.Size(40, 39);
            this.buttonRestoreDown.TabIndex = 6;
            this.buttonRestoreDown.UseVisualStyleBackColor = false;
            this.buttonRestoreDown.Click += new System.EventHandler(this.buttonRestoreDown_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = global::QuanLiRapChieuPhim.Properties.Resources.minimize;
            this.buttonMinimize.Location = new System.Drawing.Point(1169, 9);
            this.buttonMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.buttonMinimize.Size = new System.Drawing.Size(40, 39);
            this.buttonMinimize.TabIndex = 5;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::QuanLiRapChieuPhim.Properties.Resources.close;
            this.buttonClose.Location = new System.Drawing.Point(1249, 7);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Padding = new System.Windows.Forms.Padding(0, 0, 3, 1);
            this.buttonClose.Size = new System.Drawing.Size(40, 39);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // pictureHome
            // 
            this.pictureHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureHome.Image")));
            this.pictureHome.Location = new System.Drawing.Point(7, 9);
            this.pictureHome.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(57, 63);
            this.pictureHome.TabIndex = 0;
            this.pictureHome.TabStop = false;
            // 
            // gradientPanelDesktop
            // 
            this.gradientPanelDesktop.Angle = 0F;
            this.gradientPanelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.gradientPanelDesktop.BackgroundImage = global::QuanLiRapChieuPhim.Properties.Resources.CinemaPic;
            this.gradientPanelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gradientPanelDesktop.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelDesktop.Location = new System.Drawing.Point(260, 65);
            this.gradientPanelDesktop.Name = "gradientPanelDesktop";
            this.gradientPanelDesktop.Size = new System.Drawing.Size(1298, 822);
            this.gradientPanelDesktop.TabIndex = 6;
            this.gradientPanelDesktop.TopColor = System.Drawing.Color.Empty;
            // 
            // gradientPanelMenu
            // 
            this.gradientPanelMenu.Angle = 60F;
            this.gradientPanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.gradientPanelMenu.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.gradientPanelMenu.Controls.Add(this.ButtonFD);
            this.gradientPanelMenu.Controls.Add(this.buttonStatistics);
            this.gradientPanelMenu.Controls.Add(this.buttonShowtime);
            this.gradientPanelMenu.Controls.Add(this.Movie);
            this.gradientPanelMenu.Controls.Add(this.buttonAccount);
            this.gradientPanelMenu.Controls.Add(this.buttonHRM);
            this.gradientPanelMenu.Controls.Add(this.panelHome);
            this.gradientPanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelMenu.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gradientPanelMenu.Name = "gradientPanelMenu";
            this.gradientPanelMenu.Size = new System.Drawing.Size(260, 887);
            this.gradientPanelMenu.TabIndex = 2;
            this.gradientPanelMenu.TopColor = System.Drawing.Color.Empty;
            // 
            // ButtonFD
            // 
            this.ButtonFD.BackColor = System.Drawing.Color.Transparent;
            this.ButtonFD.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonFD.FlatAppearance.BorderSize = 0;
            this.ButtonFD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.ButtonFD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ButtonFD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFD.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFD.ForeColor = System.Drawing.Color.White;
            this.ButtonFD.Image = global::QuanLiRapChieuPhim.Properties.Resources.fd;
            this.ButtonFD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonFD.Location = new System.Drawing.Point(0, 629);
            this.ButtonFD.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.ButtonFD.Name = "ButtonFD";
            this.ButtonFD.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.ButtonFD.Size = new System.Drawing.Size(260, 100);
            this.ButtonFD.TabIndex = 11;
            this.ButtonFD.Text = "  FoodDrink";
            this.ButtonFD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonFD.UseVisualStyleBackColor = true;
            this.ButtonFD.Click += new System.EventHandler(this.ButtonFD_Click);
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.BackColor = System.Drawing.Color.Transparent;
            this.buttonStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStatistics.FlatAppearance.BorderSize = 0;
            this.buttonStatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.buttonStatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistics.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatistics.ForeColor = System.Drawing.Color.White;
            this.buttonStatistics.Image = ((System.Drawing.Image)(resources.GetObject("buttonStatistics.Image")));
            this.buttonStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStatistics.Location = new System.Drawing.Point(0, 529);
            this.buttonStatistics.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonStatistics.Size = new System.Drawing.Size(260, 100);
            this.buttonStatistics.TabIndex = 9;
            this.buttonStatistics.Text = "  Statistics";
            this.buttonStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // buttonShowtime
            // 
            this.buttonShowtime.BackColor = System.Drawing.Color.Transparent;
            this.buttonShowtime.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShowtime.FlatAppearance.BorderSize = 0;
            this.buttonShowtime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.buttonShowtime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonShowtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowtime.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowtime.ForeColor = System.Drawing.Color.White;
            this.buttonShowtime.Image = global::QuanLiRapChieuPhim.Properties.Resources.deadline;
            this.buttonShowtime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShowtime.Location = new System.Drawing.Point(0, 429);
            this.buttonShowtime.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonShowtime.Name = "buttonShowtime";
            this.buttonShowtime.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonShowtime.Size = new System.Drawing.Size(260, 100);
            this.buttonShowtime.TabIndex = 8;
            this.buttonShowtime.Text = "  Showtime";
            this.buttonShowtime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonShowtime.UseVisualStyleBackColor = true;
            this.buttonShowtime.Click += new System.EventHandler(this.buttonShowtime_Click);
            // 
            // Movie
            // 
            this.Movie.BackColor = System.Drawing.Color.Transparent;
            this.Movie.Dock = System.Windows.Forms.DockStyle.Top;
            this.Movie.FlatAppearance.BorderSize = 0;
            this.Movie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.Movie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Movie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Movie.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movie.ForeColor = System.Drawing.Color.White;
            this.Movie.Image = global::QuanLiRapChieuPhim.Properties.Resources.movie;
            this.Movie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Movie.Location = new System.Drawing.Point(0, 329);
            this.Movie.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Movie.Name = "Movie";
            this.Movie.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.Movie.Size = new System.Drawing.Size(260, 100);
            this.Movie.TabIndex = 6;
            this.Movie.Text = "  Movie";
            this.Movie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Movie.UseVisualStyleBackColor = true;
            this.Movie.Click += new System.EventHandler(this.Movie_Click);
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackColor = System.Drawing.Color.Transparent;
            this.buttonAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAccount.FlatAppearance.BorderSize = 0;
            this.buttonAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.buttonAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccount.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccount.ForeColor = System.Drawing.Color.White;
            this.buttonAccount.Image = global::QuanLiRapChieuPhim.Properties.Resources.customer;
            this.buttonAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccount.Location = new System.Drawing.Point(0, 229);
            this.buttonAccount.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonAccount.Size = new System.Drawing.Size(260, 100);
            this.buttonAccount.TabIndex = 5;
            this.buttonAccount.Text = "  Account";
            this.buttonAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAccount.UseVisualStyleBackColor = true;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
            // 
            // buttonHRM
            // 
            this.buttonHRM.BackColor = System.Drawing.Color.Transparent;
            this.buttonHRM.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHRM.FlatAppearance.BorderSize = 0;
            this.buttonHRM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.buttonHRM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonHRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHRM.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHRM.ForeColor = System.Drawing.Color.White;
            this.buttonHRM.Image = global::QuanLiRapChieuPhim.Properties.Resources.hr;
            this.buttonHRM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHRM.Location = new System.Drawing.Point(0, 129);
            this.buttonHRM.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonHRM.Name = "buttonHRM";
            this.buttonHRM.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.buttonHRM.Size = new System.Drawing.Size(260, 100);
            this.buttonHRM.TabIndex = 3;
            this.buttonHRM.Text = "  HR Manager";
            this.buttonHRM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHRM.UseVisualStyleBackColor = false;
            this.buttonHRM.Click += new System.EventHandler(this.buttonHRM_Click);
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.Transparent;
            this.panelHome.BackgroundImage = global::QuanLiRapChieuPhim.Properties.Resources.group11;
            this.panelHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(260, 129);
            this.panelHome.TabIndex = 0;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 887);
            this.Controls.Add(this.gradientPanelDesktop);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.gradientPanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            this.gradientPanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GradientPanel gradientPanelMenu;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Button buttonHRM;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.PictureBox pictureHome;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Panel panelMenu;
        private GradientPanel gradientPanelDesktop;
        private System.Windows.Forms.Button Movie;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.Button buttonShowtime;
        private System.Windows.Forms.Button ButtonFD;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonRestoreDown;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonClose;
    }
}