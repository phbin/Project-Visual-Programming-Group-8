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
            this.LoginPanel.Location = new System.Drawing.Point(-4, -2);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(789, 426);
            this.LoginPanel.TabIndex = 4;
            this.LoginPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginPanel_MouseDown);
            // 
            // WrongLabel
            // 
            this.WrongLabel.AutoSize = true;
            this.WrongLabel.BackColor = System.Drawing.Color.Transparent;
            this.WrongLabel.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongLabel.ForeColor = System.Drawing.Color.White;
            this.WrongLabel.Location = new System.Drawing.Point(194, 243);
            this.WrongLabel.Name = "WrongLabel";
            this.WrongLabel.Size = new System.Drawing.Size(397, 18);
            this.WrongLabel.TabIndex = 0;
            this.WrongLabel.Text = "The username or password that you\'ve entered is incorrect.";
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(121)))), ((int)(((byte)(129)))));
            this.ShowButton.FlatAppearance.BorderSize = 0;
            this.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShowButton.Image = global::QuanLiRapChieuPhim.Properties.Resources.show;
            this.ShowButton.Location = new System.Drawing.Point(500, 186);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(35, 30);
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
            this.LoginButton.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(270, 309);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(244, 42);
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
            this.buttonClose.Location = new System.Drawing.Point(742, 6);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Padding = new System.Windows.Forms.Padding(0, 0, 3, 1);
            this.buttonClose.Size = new System.Drawing.Size(40, 40);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            this.buttonClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonClose_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(121)))), ((int)(((byte)(129)))));
            this.panel2.Controls.Add(this.PasswordTextbox);
            this.panel2.Location = new System.Drawing.Point(298, 179);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 45);
            this.panel2.TabIndex = 1;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(121)))), ((int)(((byte)(129)))));
            this.PasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextbox.Font = new System.Drawing.Font("Lato", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            this.PasswordTextbox.Location = new System.Drawing.Point(3, 10);
            this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTextbox.Multiline = true;
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '•';
            this.PasswordTextbox.Size = new System.Drawing.Size(196, 23);
            this.PasswordTextbox.TabIndex = 2;
            this.PasswordTextbox.Text = "Password";
            this.PasswordTextbox.UseSystemPasswordChar = true;
            this.PasswordTextbox.Enter += new System.EventHandler(this.PasswordTextbox_Enter);
            this.PasswordTextbox.Leave += new System.EventHandler(this.PasswordTextbox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(121)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.UsernameTextbox);
            this.panel1.Location = new System.Drawing.Point(298, 122);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 45);
            this.panel1.TabIndex = 0;
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(121)))), ((int)(((byte)(129)))));
            this.UsernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextbox.Font = new System.Drawing.Font("Lato", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            this.UsernameTextbox.Location = new System.Drawing.Point(3, 11);
            this.UsernameTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameTextbox.Multiline = true;
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(233, 23);
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
            this.HideButton.Location = new System.Drawing.Point(502, 186);
            this.HideButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(35, 30);
            this.HideButton.TabIndex = 6;
            this.HideButton.UseVisualStyleBackColor = false;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            this.HideButton.MouseLeave += new System.EventHandler(this.HideButton_MouseLeave);
            this.HideButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HideButton_MouseMove);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 422);
            this.Controls.Add(this.LoginPanel);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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