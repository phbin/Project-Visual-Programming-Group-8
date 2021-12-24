
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowtime));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonRoom3 = new System.Windows.Forms.Button();
            this.buttonRoom2 = new System.Windows.Forms.Button();
            this.buttonRoom1 = new System.Windows.Forms.Button();
            this.listShowtimeGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listShowtimeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.buttonAll);
            this.panel2.Controls.Add(this.buttonRoom3);
            this.panel2.Controls.Add(this.buttonRoom2);
            this.panel2.Controls.Add(this.buttonRoom1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 59);
            this.panel2.TabIndex = 34;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::QuanLiRapChieuPhim.Properties.Resources.buttonAdd;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(741, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 59);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // buttonAll
            // 
            this.buttonAll.AutoSize = true;
            this.buttonAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.buttonAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAll.FlatAppearance.BorderSize = 0;
            this.buttonAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAll.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAll.ForeColor = System.Drawing.Color.Black;
            this.buttonAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAll.Location = new System.Drawing.Point(432, 0);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(144, 59);
            this.buttonAll.TabIndex = 3;
            this.buttonAll.Text = "All Showtime";
            this.buttonAll.UseVisualStyleBackColor = false;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonRoom3
            // 
            this.buttonRoom3.AutoSize = true;
            this.buttonRoom3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.buttonRoom3.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRoom3.FlatAppearance.BorderSize = 0;
            this.buttonRoom3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoom3.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoom3.ForeColor = System.Drawing.Color.Black;
            this.buttonRoom3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRoom3.Location = new System.Drawing.Point(288, 0);
            this.buttonRoom3.Name = "buttonRoom3";
            this.buttonRoom3.Size = new System.Drawing.Size(144, 59);
            this.buttonRoom3.TabIndex = 2;
            this.buttonRoom3.Text = "Cinema 03";
            this.buttonRoom3.UseVisualStyleBackColor = false;
            this.buttonRoom3.Click += new System.EventHandler(this.buttonRoom3_Click);
            // 
            // buttonRoom2
            // 
            this.buttonRoom2.AutoSize = true;
            this.buttonRoom2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.buttonRoom2.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRoom2.FlatAppearance.BorderSize = 0;
            this.buttonRoom2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoom2.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoom2.ForeColor = System.Drawing.Color.Black;
            this.buttonRoom2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRoom2.Location = new System.Drawing.Point(144, 0);
            this.buttonRoom2.Name = "buttonRoom2";
            this.buttonRoom2.Size = new System.Drawing.Size(144, 59);
            this.buttonRoom2.TabIndex = 1;
            this.buttonRoom2.Text = "Cinema 02";
            this.buttonRoom2.UseVisualStyleBackColor = false;
            this.buttonRoom2.Click += new System.EventHandler(this.buttonRoom2_Click);
            // 
            // buttonRoom1
            // 
            this.buttonRoom1.AutoSize = true;
            this.buttonRoom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            this.buttonRoom1.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRoom1.FlatAppearance.BorderSize = 0;
            this.buttonRoom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoom1.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoom1.ForeColor = System.Drawing.Color.Black;
            this.buttonRoom1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRoom1.Location = new System.Drawing.Point(0, 0);
            this.buttonRoom1.Name = "buttonRoom1";
            this.buttonRoom1.Size = new System.Drawing.Size(144, 59);
            this.buttonRoom1.TabIndex = 0;
            this.buttonRoom1.Text = "Cinema 01";
            this.buttonRoom1.UseVisualStyleBackColor = false;
            this.buttonRoom1.Click += new System.EventHandler(this.buttonRoom1_Click);
            // 
            // listShowtimeGrid
            // 
            this.listShowtimeGrid.AllowUserToAddRows = false;
            this.listShowtimeGrid.AllowUserToDeleteRows = false;
            this.listShowtimeGrid.AllowUserToOrderColumns = true;
            this.listShowtimeGrid.AllowUserToResizeRows = false;
            this.listShowtimeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listShowtimeGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.listShowtimeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listShowtimeGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listShowtimeGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(54)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(54)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listShowtimeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listShowtimeGrid.ColumnHeadersHeight = 35;
            this.listShowtimeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.listShowtimeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameFilm,
            this.shTime,
            this.IDRoom,
            this.TicketPrice,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listShowtimeGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.listShowtimeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listShowtimeGrid.EnableHeadersVisualStyles = false;
            this.listShowtimeGrid.GridColor = System.Drawing.SystemColors.HotTrack;
            this.listShowtimeGrid.Location = new System.Drawing.Point(0, 59);
            this.listShowtimeGrid.Margin = new System.Windows.Forms.Padding(4);
            this.listShowtimeGrid.MultiSelect = false;
            this.listShowtimeGrid.Name = "listShowtimeGrid";
            this.listShowtimeGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listShowtimeGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listShowtimeGrid.RowHeadersVisible = false;
            this.listShowtimeGrid.RowHeadersWidth = 62;
            this.listShowtimeGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.listShowtimeGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.listShowtimeGrid.RowTemplate.Height = 28;
            this.listShowtimeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listShowtimeGrid.Size = new System.Drawing.Size(800, 391);
            this.listShowtimeGrid.TabIndex = 52;
            this.listShowtimeGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listShowtimeGrid_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 53.36853F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NameFilm
            // 
            this.NameFilm.DataPropertyName = "NameFilm";
            this.NameFilm.FillWeight = 150F;
            this.NameFilm.HeaderText = "Movie Name";
            this.NameFilm.MinimumWidth = 6;
            this.NameFilm.Name = "NameFilm";
            this.NameFilm.ReadOnly = true;
            // 
            // shTime
            // 
            this.shTime.DataPropertyName = "shTime";
            this.shTime.FillWeight = 150F;
            this.shTime.HeaderText = "Showtime";
            this.shTime.MinimumWidth = 6;
            this.shTime.Name = "shTime";
            this.shTime.ReadOnly = true;
            // 
            // IDRoom
            // 
            this.IDRoom.DataPropertyName = "IDRoom";
            this.IDRoom.HeaderText = "IDRoom";
            this.IDRoom.MinimumWidth = 6;
            this.IDRoom.Name = "IDRoom";
            this.IDRoom.ReadOnly = true;
            // 
            // TicketPrice
            // 
            this.TicketPrice.DataPropertyName = "TicketPrice";
            this.TicketPrice.HeaderText = "Ticket Price";
            this.TicketPrice.MinimumWidth = 6;
            this.TicketPrice.Name = "TicketPrice";
            this.TicketPrice.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 50F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = global::QuanLiRapChieuPhim.Properties.Resources.edit;
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 50F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Image = global::QuanLiRapChieuPhim.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 61;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 50F;
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 8;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 60;
            // 
            // FormShowtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listShowtimeGrid);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormShowtime";
            this.Text = "FormShowtime";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listShowtimeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Button buttonRoom3;
        private System.Windows.Forms.Button buttonRoom2;
        private System.Windows.Forms.Button buttonRoom1;
        private System.Windows.Forms.DataGridView listShowtimeGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn shTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketPrice;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btnAdd;
    }
}