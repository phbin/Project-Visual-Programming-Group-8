
namespace QuanLiRapChieuPhim
{
    partial class FormMovieManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovieManage));
            this.panelInfo = new System.Windows.Forms.Panel();
            this.listMovieGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePublic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelLine = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listMovieGrid)).BeginInit();
            this.panelLine.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.listMovieGrid);
            this.panelInfo.Controls.Add(this.panelLine);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(800, 450);
            this.panelInfo.TabIndex = 18;
            // 
            // listMovieGrid
            // 
            this.listMovieGrid.AllowUserToAddRows = false;
            this.listMovieGrid.AllowUserToDeleteRows = false;
            this.listMovieGrid.AllowUserToOrderColumns = true;
            this.listMovieGrid.AllowUserToResizeColumns = false;
            this.listMovieGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.listMovieGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listMovieGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listMovieGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listMovieGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listMovieGrid.ColumnHeadersHeight = 29;
            this.listMovieGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.listMovieGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameFilm,
            this.DatePublic,
            this.DateOut,
            this.TimeLimit,
            this.Director,
            this.Country,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listMovieGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.listMovieGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMovieGrid.Location = new System.Drawing.Point(0, 82);
            this.listMovieGrid.Name = "listMovieGrid";
            this.listMovieGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listMovieGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.listMovieGrid.RowHeadersVisible = false;
            this.listMovieGrid.RowHeadersWidth = 51;
            this.listMovieGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.listMovieGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.listMovieGrid.RowTemplate.Height = 24;
            this.listMovieGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listMovieGrid.Size = new System.Drawing.Size(800, 368);
            this.listMovieGrid.TabIndex = 18;
            this.listMovieGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listMovieGrid_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 40F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NameFilm
            // 
            this.NameFilm.DataPropertyName = "NameFilm";
            this.NameFilm.HeaderText = "Movie Name";
            this.NameFilm.MinimumWidth = 6;
            this.NameFilm.Name = "NameFilm";
            this.NameFilm.ReadOnly = true;
            // 
            // DatePublic
            // 
            this.DatePublic.DataPropertyName = "DatePublic";
            this.DatePublic.HeaderText = "Release Date";
            this.DatePublic.MinimumWidth = 6;
            this.DatePublic.Name = "DatePublic";
            this.DatePublic.ReadOnly = true;
            // 
            // DateOut
            // 
            this.DateOut.DataPropertyName = "DateOut";
            this.DateOut.HeaderText = "Expiry Date";
            this.DateOut.MinimumWidth = 6;
            this.DateOut.Name = "DateOut";
            this.DateOut.ReadOnly = true;
            // 
            // TimeLimit
            // 
            this.TimeLimit.DataPropertyName = "TimeLimit";
            this.TimeLimit.HeaderText = "Running Time";
            this.TimeLimit.MinimumWidth = 6;
            this.TimeLimit.Name = "TimeLimit";
            this.TimeLimit.ReadOnly = true;
            // 
            // Director
            // 
            this.Director.DataPropertyName = "Director";
            this.Director.HeaderText = "Director";
            this.Director.MinimumWidth = 6;
            this.Director.Name = "Director";
            this.Director.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Country";
            this.Country.MinimumWidth = 6;
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 60F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = global::QuanLiRapChieuPhim.Properties.Resources.EditIcon_01;
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 60F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::QuanLiRapChieuPhim.Properties.Resources.TrashIcon_01;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // panelLine
            // 
            this.panelLine.Controls.Add(this.btnAdd);
            this.panelLine.Controls.Add(this.SearchButton);
            this.panelLine.Controls.Add(this.SearchPanel);
            this.panelLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLine.Location = new System.Drawing.Point(0, 0);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(800, 82);
            this.panelLine.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(484, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 50);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add Movie";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.Location = new System.Drawing.Point(411, 21);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(36, 34);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.Transparent;
            this.SearchPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchPanel.BackgroundImage")));
            this.SearchPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchPanel.Controls.Add(this.SearchTextbox);
            this.SearchPanel.Location = new System.Drawing.Point(3, 21);
            this.SearchPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(429, 37);
            this.SearchPanel.TabIndex = 8;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.SearchTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextbox.ForeColor = System.Drawing.Color.Gray;
            this.SearchTextbox.Location = new System.Drawing.Point(19, 7);
            this.SearchTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchTextbox.Multiline = true;
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(372, 21);
            this.SearchTextbox.TabIndex = 15;
            this.SearchTextbox.Text = "Search";
            this.SearchTextbox.TextChanged += new System.EventHandler(this.SearchTextbox_TextChanged);
            this.SearchTextbox.Enter += new System.EventHandler(this.SearchTextbox_Enter);
            this.SearchTextbox.Leave += new System.EventHandler(this.SearchTextbox_Leave);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Image = global::QuanLiRapChieuPhim.Properties.Resources.EditIcon_01;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 88;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = global::QuanLiRapChieuPhim.Properties.Resources.TrashIcon_01;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 89;
            // 
            // FormMovieManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelInfo);
            this.Name = "FormMovieManage";
            this.Text = "FormMovieManage";
            this.panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listMovieGrid)).EndInit();
            this.panelLine.ResumeLayout(false);
            this.panelLine.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.DataGridView listMovieGrid;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatePublic;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}