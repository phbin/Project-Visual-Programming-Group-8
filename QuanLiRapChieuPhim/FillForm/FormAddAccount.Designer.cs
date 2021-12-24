namespace QuanLiRapChieuPhim.AddForms
{
    partial class FormAddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.AcctypeLabel = new System.Windows.Forms.Label();
            this.AdminCheckbox = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbName);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.AddLabel);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.AcctypeLabel);
            this.panel1.Controls.Add(this.AdminCheckbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 469);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(115, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 58;
            this.label2.Text = "Name";
            // 
            // cbName
            // 
            this.cbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbName.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(114, 142);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(320, 32);
            this.cbName.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.buttonClose.BackgroundImage = global::QuanLiRapChieuPhim.Properties.Resources.close;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(499, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Padding = new System.Windows.Forms.Padding(0, 0, 3, 1);
            this.buttonClose.Size = new System.Drawing.Size(44, 40);
            this.buttonClose.TabIndex = 56;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click_1);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            this.buttonClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonClose_MouseMove);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(198, 409);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(151, 37);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(198, 409);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(151, 37);
            this.AddButton.TabIndex = 37;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click_1);
            this.AddButton.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            this.AddButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddButton_MouseMove);
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Font = new System.Drawing.Font("Lato", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLabel.ForeColor = System.Drawing.Color.White;
            this.AddLabel.Location = new System.Drawing.Point(204, 46);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(160, 46);
            this.AddLabel.TabIndex = 0;
            this.AddLabel.Text = "Account";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.panel4.Controls.Add(this.PasswordTextbox);
            this.panel4.Location = new System.Drawing.Point(114, 325);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(321, 46);
            this.panel4.TabIndex = 4;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.PasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextbox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.PasswordTextbox.Location = new System.Drawing.Point(11, 11);
            this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(266, 24);
            this.PasswordTextbox.TabIndex = 4;
            this.PasswordTextbox.Text = "Password";
            this.PasswordTextbox.Enter += new System.EventHandler(this.PasswordTextbox_Enter);
            this.PasswordTextbox.Leave += new System.EventHandler(this.PasswordTextbox_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.UsernameTextbox);
            this.panel3.Location = new System.Drawing.Point(114, 249);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 46);
            this.panel3.TabIndex = 3;
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.UsernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextbox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.UsernameTextbox.Location = new System.Drawing.Point(11, 11);
            this.UsernameTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(266, 24);
            this.UsernameTextbox.TabIndex = 3;
            this.UsernameTextbox.Text = "Username";
            this.UsernameTextbox.Enter += new System.EventHandler(this.UsernameTextbox_Enter);
            this.UsernameTextbox.Leave += new System.EventHandler(this.UsernameTextbox_Leave);
            // 
            // AcctypeLabel
            // 
            this.AcctypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AcctypeLabel.AutoSize = true;
            this.AcctypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.AcctypeLabel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcctypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.AcctypeLabel.Location = new System.Drawing.Point(108, 196);
            this.AcctypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AcctypeLabel.Name = "AcctypeLabel";
            this.AcctypeLabel.Size = new System.Drawing.Size(68, 24);
            this.AcctypeLabel.TabIndex = 35;
            this.AcctypeLabel.Text = "Admin";
            // 
            // AdminCheckbox
            // 
            this.AdminCheckbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AdminCheckbox.AutoSize = true;
            this.AdminCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.AdminCheckbox.Location = new System.Drawing.Point(211, 202);
            this.AdminCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.AdminCheckbox.Name = "AdminCheckbox";
            this.AdminCheckbox.Size = new System.Drawing.Size(18, 17);
            this.AdminCheckbox.TabIndex = 2;
            this.AdminCheckbox.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAddAccount
            // 
            this.AcceptButton = this.AddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(548, 469);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAccount";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox AdminCheckbox;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.Label AcctypeLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbName;
    }
}