
namespace QuanLiRapChieuPhim
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonRestoreDown = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelHome = new System.Windows.Forms.Label();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            this.panelLine = new System.Windows.Forms.Panel();
            this.gradientPanelDesktop = new QuanLiRapChieuPhim.GradientPanel();
            this.gradientPanelMenu = new QuanLiRapChieuPhim.GradientPanel();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonStatistic = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.buttonFD = new System.Windows.Forms.Button();
            this.buttonMovie = new System.Windows.Forms.Button();
            this.buttonGeneral = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            this.gradientPanelMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.panelMenu.Location = new System.Drawing.Point(292, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1440, 72);
            this.panelMenu.TabIndex = 2;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaximize.Image")));
            this.buttonMaximize.Location = new System.Drawing.Point(1339, 10);
            this.buttonMaximize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Padding = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.buttonMaximize.Size = new System.Drawing.Size(45, 50);
            this.buttonMaximize.TabIndex = 4;
            this.buttonMaximize.UseVisualStyleBackColor = false;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            this.buttonMaximize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonMaximize_MouseMove);
            // 
            // buttonRestoreDown
            // 
            this.buttonRestoreDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestoreDown.BackColor = System.Drawing.Color.Transparent;
            this.buttonRestoreDown.FlatAppearance.BorderSize = 0;
            this.buttonRestoreDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestoreDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonRestoreDown.Image")));
            this.buttonRestoreDown.Location = new System.Drawing.Point(1339, 10);
            this.buttonRestoreDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRestoreDown.Name = "buttonRestoreDown";
            this.buttonRestoreDown.Padding = new System.Windows.Forms.Padding(0, 0, 4, 5);
            this.buttonRestoreDown.Size = new System.Drawing.Size(45, 50);
            this.buttonRestoreDown.TabIndex = 6;
            this.buttonRestoreDown.UseVisualStyleBackColor = false;
            this.buttonRestoreDown.Click += new System.EventHandler(this.buttonRestoreDown_Click);
            this.buttonRestoreDown.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonRestoreDown_MouseMove);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = global::QuanLiRapChieuPhim.Properties.Resources.minimize;
            this.buttonMinimize.Location = new System.Drawing.Point(1294, 11);
            this.buttonMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.buttonMinimize.Size = new System.Drawing.Size(45, 50);
            this.buttonMinimize.TabIndex = 5;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            this.buttonMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonMinimize_MouseMove);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::QuanLiRapChieuPhim.Properties.Resources.close;
            this.buttonClose.Location = new System.Drawing.Point(1384, 10);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Padding = new System.Windows.Forms.Padding(0, 0, 3, 1);
            this.buttonClose.Size = new System.Drawing.Size(45, 50);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonClose_MouseMove);
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.BackColor = System.Drawing.Color.Transparent;
            this.labelHome.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.Color.White;
            this.labelHome.Location = new System.Drawing.Point(68, 19);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(80, 32);
            this.labelHome.TabIndex = 1;
            this.labelHome.Text = "Home";
            this.labelHome.Click += new System.EventHandler(this.labelHome_Click);
            // 
            // pictureHome
            // 
            this.pictureHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureHome.Image")));
            this.pictureHome.Location = new System.Drawing.Point(6, 9);
            this.pictureHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(57, 62);
            this.pictureHome.TabIndex = 0;
            this.pictureHome.TabStop = false;
            this.pictureHome.Click += new System.EventHandler(this.pictureHome_Click);
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.panelLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLine.Location = new System.Drawing.Point(292, 72);
            this.panelLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(1440, 9);
            this.panelLine.TabIndex = 3;
            this.panelLine.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLine_Paint);
            // 
            // gradientPanelDesktop
            // 
            this.gradientPanelDesktop.Angle = 90F;
            this.gradientPanelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.gradientPanelDesktop.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(214)))));
            this.gradientPanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelDesktop.Location = new System.Drawing.Point(292, 81);
            this.gradientPanelDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientPanelDesktop.Name = "gradientPanelDesktop";
            this.gradientPanelDesktop.Size = new System.Drawing.Size(1440, 969);
            this.gradientPanelDesktop.TabIndex = 0;
            this.gradientPanelDesktop.TopColor = System.Drawing.Color.Empty;
            this.gradientPanelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanelDesktop_Paint);
            // 
            // gradientPanelMenu
            // 
            this.gradientPanelMenu.Angle = 60F;
            this.gradientPanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.gradientPanelMenu.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(98)))), ((int)(((byte)(101)))));
            this.gradientPanelMenu.Controls.Add(this.buttonAdmin);
            this.gradientPanelMenu.Controls.Add(this.buttonStatistic);
            this.gradientPanelMenu.Controls.Add(this.buttonCustomer);
            this.gradientPanelMenu.Controls.Add(this.buttonFD);
            this.gradientPanelMenu.Controls.Add(this.buttonMovie);
            this.gradientPanelMenu.Controls.Add(this.buttonGeneral);
            this.gradientPanelMenu.Controls.Add(this.panelHome);
            this.gradientPanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientPanelMenu.Name = "gradientPanelMenu";
            this.gradientPanelMenu.Size = new System.Drawing.Size(292, 1050);
            this.gradientPanelMenu.TabIndex = 1;
            this.gradientPanelMenu.TopColor = System.Drawing.Color.Empty;
            this.gradientPanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanelMenu_Paint);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdmin.FlatAppearance.BorderSize = 0;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.ForeColor = System.Drawing.Color.White;
            this.buttonAdmin.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdmin.Image")));
            this.buttonAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdmin.Location = new System.Drawing.Point(0, 648);
            this.buttonAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonAdmin.Size = new System.Drawing.Size(292, 106);
            this.buttonAdmin.TabIndex = 5;
            this.buttonAdmin.Text = "  Staff";
            this.buttonAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonStatistic
            // 
            this.buttonStatistic.BackColor = System.Drawing.Color.Transparent;
            this.buttonStatistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStatistic.FlatAppearance.BorderSize = 0;
            this.buttonStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistic.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatistic.ForeColor = System.Drawing.Color.White;
            this.buttonStatistic.Image = ((System.Drawing.Image)(resources.GetObject("buttonStatistic.Image")));
            this.buttonStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStatistic.Location = new System.Drawing.Point(0, 542);
            this.buttonStatistic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStatistic.Name = "buttonStatistic";
            this.buttonStatistic.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonStatistic.Size = new System.Drawing.Size(292, 106);
            this.buttonStatistic.TabIndex = 4;
            this.buttonStatistic.Text = "  Statistic";
            this.buttonStatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStatistic.UseVisualStyleBackColor = true;
            this.buttonStatistic.Click += new System.EventHandler(this.buttonStatistic_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.BackColor = System.Drawing.Color.Transparent;
            this.buttonCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCustomer.FlatAppearance.BorderSize = 0;
            this.buttonCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomer.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomer.ForeColor = System.Drawing.Color.White;
            this.buttonCustomer.Image = ((System.Drawing.Image)(resources.GetObject("buttonCustomer.Image")));
            this.buttonCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomer.Location = new System.Drawing.Point(0, 436);
            this.buttonCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonCustomer.Size = new System.Drawing.Size(292, 106);
            this.buttonCustomer.TabIndex = 3;
            this.buttonCustomer.Text = "  Customer";
            this.buttonCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // buttonFD
            // 
            this.buttonFD.BackColor = System.Drawing.Color.Transparent;
            this.buttonFD.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFD.FlatAppearance.BorderSize = 0;
            this.buttonFD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFD.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFD.ForeColor = System.Drawing.Color.White;
            this.buttonFD.Image = ((System.Drawing.Image)(resources.GetObject("buttonFD.Image")));
            this.buttonFD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFD.Location = new System.Drawing.Point(0, 330);
            this.buttonFD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFD.Name = "buttonFD";
            this.buttonFD.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonFD.Size = new System.Drawing.Size(292, 106);
            this.buttonFD.TabIndex = 2;
            this.buttonFD.Text = "  Food and Drink";
            this.buttonFD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFD.UseVisualStyleBackColor = true;
            this.buttonFD.Click += new System.EventHandler(this.buttonFD_Click);
            // 
            // buttonMovie
            // 
            this.buttonMovie.BackColor = System.Drawing.Color.Transparent;
            this.buttonMovie.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMovie.FlatAppearance.BorderSize = 0;
            this.buttonMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMovie.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMovie.ForeColor = System.Drawing.Color.White;
            this.buttonMovie.Image = ((System.Drawing.Image)(resources.GetObject("buttonMovie.Image")));
            this.buttonMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMovie.Location = new System.Drawing.Point(0, 224);
            this.buttonMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMovie.Name = "buttonMovie";
            this.buttonMovie.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonMovie.Size = new System.Drawing.Size(292, 106);
            this.buttonMovie.TabIndex = 1;
            this.buttonMovie.Text = "  Movie";
            this.buttonMovie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMovie.UseVisualStyleBackColor = true;
            this.buttonMovie.Click += new System.EventHandler(this.buttonMovie_Click);
            // 
            // buttonGeneral
            // 
            this.buttonGeneral.BackColor = System.Drawing.Color.Transparent;
            this.buttonGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGeneral.FlatAppearance.BorderSize = 0;
            this.buttonGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeneral.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGeneral.ForeColor = System.Drawing.Color.White;
            this.buttonGeneral.Image = global::QuanLiRapChieuPhim.Properties.Resources.general;
            this.buttonGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGeneral.Location = new System.Drawing.Point(0, 158);
            this.buttonGeneral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGeneral.Name = "buttonGeneral";
            this.buttonGeneral.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonGeneral.Size = new System.Drawing.Size(292, 66);
            this.buttonGeneral.TabIndex = 0;
            this.buttonGeneral.Text = "  General";
            this.buttonGeneral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGeneral.UseVisualStyleBackColor = true;
            this.buttonGeneral.Click += new System.EventHandler(this.buttonGeneral_Click);
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.Transparent;
            this.panelHome.BackgroundImage = global::QuanLiRapChieuPhim.Properties.Resources.group11;
            this.panelHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(292, 158);
            this.panelHome.TabIndex = 0;
            this.panelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHome_Paint);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1732, 1050);
            this.Controls.Add(this.gradientPanelDesktop);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.gradientPanelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            this.gradientPanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GradientPanel gradientPanelMenu;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonStatistic;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Button buttonFD;
        private System.Windows.Forms.Button buttonMovie;
        private System.Windows.Forms.Button buttonGeneral;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.PictureBox pictureHome;
        private System.Windows.Forms.Panel panelLine;
        private GradientPanel gradientPanelDesktop;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonRestoreDown;
    }
}

