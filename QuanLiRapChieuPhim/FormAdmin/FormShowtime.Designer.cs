
namespace QuanLiRapChieuPhim
{
    partial class FormShowtime
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRoom1 = new System.Windows.Forms.Button();
            this.buttonRoom2 = new System.Windows.Forms.Button();
            this.buttonRoom3 = new System.Windows.Forms.Button();
            this.listShowtimeGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePublic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonAll = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listShowtimeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.buttonAll);
            this.panel1.Controls.Add(this.buttonRoom3);
            this.panel1.Controls.Add(this.buttonRoom2);
            this.panel1.Controls.Add(this.buttonRoom1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 42);
            this.panel1.TabIndex = 0;
            // 
            // buttonRoom1
            // 
            this.buttonRoom1.AutoSize = true;
            this.buttonRoom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRoom1.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRoom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoom1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoom1.ForeColor = System.Drawing.Color.White;
            this.buttonRoom1.Location = new System.Drawing.Point(0, 0);
            this.buttonRoom1.Name = "buttonRoom1";
            this.buttonRoom1.Size = new System.Drawing.Size(134, 42);
            this.buttonRoom1.TabIndex = 0;
            this.buttonRoom1.Text = "Cinema 01";
            this.buttonRoom1.UseVisualStyleBackColor = false;
            this.buttonRoom1.Click += new System.EventHandler(this.buttonRoom1_Click);
            // 
            // buttonRoom2
            // 
            this.buttonRoom2.AutoSize = true;
            this.buttonRoom2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRoom2.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRoom2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoom2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoom2.ForeColor = System.Drawing.Color.White;
            this.buttonRoom2.Location = new System.Drawing.Point(134, 0);
            this.buttonRoom2.Name = "buttonRoom2";
            this.buttonRoom2.Size = new System.Drawing.Size(134, 42);
            this.buttonRoom2.TabIndex = 1;
            this.buttonRoom2.Text = "Cinema 02";
            this.buttonRoom2.UseVisualStyleBackColor = false;
            this.buttonRoom2.Click += new System.EventHandler(this.buttonRoom2_Click);
            // 
            // buttonRoom3
            // 
            this.buttonRoom3.AutoSize = true;
            this.buttonRoom3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRoom3.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRoom3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoom3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoom3.ForeColor = System.Drawing.Color.White;
            this.buttonRoom3.Location = new System.Drawing.Point(268, 0);
            this.buttonRoom3.Name = "buttonRoom3";
            this.buttonRoom3.Size = new System.Drawing.Size(134, 42);
            this.buttonRoom3.TabIndex = 2;
            this.buttonRoom3.Text = "Cinema 03";
            this.buttonRoom3.UseVisualStyleBackColor = false;
            this.buttonRoom3.Click += new System.EventHandler(this.buttonRoom3_Click);
            // 
            // listShowtimeGrid
            // 
            this.listShowtimeGrid.AllowUserToAddRows = false;
            this.listShowtimeGrid.AllowUserToDeleteRows = false;
            this.listShowtimeGrid.AllowUserToOrderColumns = true;
            this.listShowtimeGrid.AllowUserToResizeColumns = false;
            this.listShowtimeGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.listShowtimeGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listShowtimeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listShowtimeGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listShowtimeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listShowtimeGrid.ColumnHeadersHeight = 29;
            this.listShowtimeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.listShowtimeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameFilm,
            this.DatePublic,
            this.DateOut,
            this.Director,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listShowtimeGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.listShowtimeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listShowtimeGrid.Location = new System.Drawing.Point(0, 42);
            this.listShowtimeGrid.Name = "listShowtimeGrid";
            this.listShowtimeGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listShowtimeGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.listShowtimeGrid.RowHeadersVisible = false;
            this.listShowtimeGrid.RowHeadersWidth = 51;
            this.listShowtimeGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.listShowtimeGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.listShowtimeGrid.RowTemplate.Height = 24;
            this.listShowtimeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listShowtimeGrid.Size = new System.Drawing.Size(800, 408);
            this.listShowtimeGrid.TabIndex = 19;
            this.listShowtimeGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listShowtimeGrid_CellClick);
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
            this.DatePublic.DataPropertyName = "shTime";
            this.DatePublic.HeaderText = "Showtime";
            this.DatePublic.MinimumWidth = 6;
            this.DatePublic.Name = "DatePublic";
            this.DatePublic.ReadOnly = true;
            // 
            // DateOut
            // 
            this.DateOut.DataPropertyName = "IDRoom";
            this.DateOut.HeaderText = "IDRoom";
            this.DateOut.MinimumWidth = 6;
            this.DateOut.Name = "DateOut";
            this.DateOut.ReadOnly = true;
            // 
            // Director
            // 
            this.Director.DataPropertyName = "TicketPrice";
            this.Director.HeaderText = "Ticket Price";
            this.Director.MinimumWidth = 6;
            this.Director.Name = "Director";
            this.Director.ReadOnly = true;
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
            // buttonAll
            // 
            this.buttonAll.AutoSize = true;
            this.buttonAll.BackColor = System.Drawing.Color.Gray;
            this.buttonAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAll.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAll.ForeColor = System.Drawing.Color.White;
            this.buttonAll.Location = new System.Drawing.Point(402, 0);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(157, 42);
            this.buttonAll.TabIndex = 3;
            this.buttonAll.Text = "All Showtime";
            this.buttonAll.UseVisualStyleBackColor = false;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(681, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 42);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add Movie";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormShowtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listShowtimeGrid);
            this.Controls.Add(this.panel1);
            this.Name = "FormShowtime";
            this.Text = "FormShowtime";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listShowtimeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRoom3;
        private System.Windows.Forms.Button buttonRoom2;
        private System.Windows.Forms.Button buttonRoom1;
        private System.Windows.Forms.DataGridView listShowtimeGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatePublic;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Director;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Button btnAdd;
    }
}