namespace QuanLiRapChieuPhim
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.WrongLabel = new System.Windows.Forms.Label();
            this.ShowButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.HideButton = new System.Windows.Forms.Button();
            this.LoginPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginPanel.BackgroundImage")));
            this.LoginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginPanel.Controls.Add(this.WrongLabel);
            this.LoginPanel.Controls.Add(this.ShowButton);
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.buttonClose);
            this.LoginPanel.Controls.Add(this.panel2);
            this.LoginPanel.Controls.Add(this.panel1);
            this.LoginPanel.Controls.Add(this.HideButton);
            this.LoginPanel.Location = new System.Drawing.Point(-5, -2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(888, 532);
            this.LoginPanel.TabIndex = 4;
            // 
            // WrongLabel
            // 
            this.WrongLabel.AutoSize = true;
            this.WrongLabel.BackColor = System.Drawing.Color.Transparent;
            this.WrongLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongLabel.ForeColor = System.Drawing.Color.White;
            this.WrongLabel.Location = new System.Drawing.Point(273, 348);
            this.WrongLabel.Name = "WrongLabel";
            this.WrongLabel.Size = new System.Drawing.Size(341, 20);
            this.WrongLabel.TabIndex = 8;
            this.WrongLabel.Text = "Sai tài khoản hoặc mật khẩu, vui lòng nhập lại";
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.Transparent;
            this.ShowButton.FlatAppearance.BorderSize = 0;
            this.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShowButton.Image = global::QuanLiRapChieuPhim.Properties.Resources.show;
            this.ShowButton.Location = new System.Drawing.Point(563, 232);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(39, 38);
            this.ShowButton.TabIndex = 5;
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            this.ShowButton.MouseLeave += new System.EventHandler(this.ShowButton_MouseLeave);
            this.ShowButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShowButton_MouseMove);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(307, 386);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(274, 53);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            this.LoginButton.MouseLeave += new System.EventHandler(this.LoginButton_MouseLeave);
            this.LoginButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginButton_MouseMove);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::QuanLiRapChieuPhim.Properties.Resources.close;
            this.buttonClose.Location = new System.Drawing.Point(835, 7);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Padding = new System.Windows.Forms.Padding(0, 0, 3, 1);
            this.buttonClose.Size = new System.Drawing.Size(45, 50);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            this.buttonClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonClose_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.PasswordTextbox);
            this.panel2.Location = new System.Drawing.Point(339, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 29);
            this.panel2.TabIndex = 1;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(121)))), ((int)(((byte)(129)))));
            this.PasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            this.PasswordTextbox.Location = new System.Drawing.Point(0, 0);
            this.PasswordTextbox.Multiline = true;
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.Size = new System.Drawing.Size(220, 29);
            this.PasswordTextbox.TabIndex = 2;
            this.PasswordTextbox.Text = "Password";
            this.PasswordTextbox.UseSystemPasswordChar = true;
            this.PasswordTextbox.Enter += new System.EventHandler(this.PasswordTextbox_Enter);
            this.PasswordTextbox.Leave += new System.EventHandler(this.PasswordTextbox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.UsernameTextbox);
            this.panel1.Location = new System.Drawing.Point(339, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 29);
            this.panel1.TabIndex = 0;
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(121)))), ((int)(((byte)(129)))));
            this.UsernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            this.UsernameTextbox.Location = new System.Drawing.Point(0, 0);
            this.UsernameTextbox.Multiline = true;
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(263, 29);
            this.UsernameTextbox.TabIndex = 1;
            this.UsernameTextbox.Text = "Username";
            this.UsernameTextbox.Enter += new System.EventHandler(this.UsernameTextbox_Enter);
            this.UsernameTextbox.Leave += new System.EventHandler(this.UsernameTextbox_Leave);
            // 
            // HideButton
            // 
            this.HideButton.BackColor = System.Drawing.Color.Transparent;
            this.HideButton.FlatAppearance.BorderSize = 0;
            this.HideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideButton.ForeColor = System.Drawing.Color.Transparent;
            this.HideButton.Image = global::QuanLiRapChieuPhim.Properties.Resources.hide1;
            this.HideButton.Location = new System.Drawing.Point(565, 232);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(39, 38);
            this.HideButton.TabIndex = 6;
            this.HideButton.UseVisualStyleBackColor = false;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            this.HideButton.MouseLeave += new System.EventHandler(this.HideButton_MouseLeave);
            this.HideButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HideButton_MouseMove);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 528);
            this.Controls.Add(this.LoginPanel);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Label WrongLabel;
    }
}