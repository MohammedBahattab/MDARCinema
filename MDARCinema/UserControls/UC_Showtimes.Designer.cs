namespace MDARCinema.UserControls
{
    partial class UC_Showtimes
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            if (disposing && db != null) db.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlForm = new System.Windows.Forms.Panel();
            this.cmbMovie = new System.Windows.Forms.ComboBox();
            this.cmbHall = new System.Windows.Forms.ComboBox();
            this.dtpShowDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblMovie = new System.Windows.Forms.Label();
            this.lblHall = new System.Windows.Forms.Label();
            this.lblShowDate = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // pnlForm
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Location = new System.Drawing.Point(15, 15);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(930, 200);
            // lblMovie
            this.lblMovie.AutoSize = true;
            this.lblMovie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMovie.ForeColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.lblMovie.Location = new System.Drawing.Point(30, 20);
            this.lblMovie.Text = "Movie:";
            // cmbMovie
            this.cmbMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMovie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMovie.Location = new System.Drawing.Point(30, 40);
            this.cmbMovie.Size = new System.Drawing.Size(250, 25);
            // lblHall
            this.lblHall.AutoSize = true;
            this.lblHall.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHall.ForeColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.lblHall.Location = new System.Drawing.Point(310, 20);
            this.lblHall.Text = "Hall:";
            // cmbHall
            this.cmbHall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHall.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbHall.Location = new System.Drawing.Point(310, 40);
            this.cmbHall.Size = new System.Drawing.Size(200, 25);
            // lblShowDate
            this.lblShowDate.AutoSize = true;
            this.lblShowDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblShowDate.ForeColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.lblShowDate.Location = new System.Drawing.Point(540, 20);
            this.lblShowDate.Text = "Show Date:";
            // dtpShowDate
            this.dtpShowDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpShowDate.Location = new System.Drawing.Point(540, 40);
            this.dtpShowDate.Size = new System.Drawing.Size(200, 25);
            // lblStartTime
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStartTime.ForeColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.lblStartTime.Location = new System.Drawing.Point(770, 20);
            this.lblStartTime.Text = "Start Time:";
            // dtpStartTime
            this.dtpStartTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Location = new System.Drawing.Point(770, 40);
            this.dtpStartTime.Size = new System.Drawing.Size(130, 25);
            // lblEndTime
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEndTime.ForeColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.lblEndTime.Location = new System.Drawing.Point(30, 80);
            this.lblEndTime.Text = "End Time:";
            // dtpEndTime
            this.dtpEndTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Location = new System.Drawing.Point(30, 100);
            this.dtpEndTime.Size = new System.Drawing.Size(130, 25);
            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.lblPrice.Location = new System.Drawing.Point(190, 80);
            this.lblPrice.Text = "Price:";
            // txtPrice
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrice.Location = new System.Drawing.Point(190, 100);
            this.txtPrice.Size = new System.Drawing.Size(130, 25);
            // Buttons
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(30, 145);
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.Text = "➕ Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(140, 145);
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.Text = "✏️ Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(250, 145);
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.Text = "🗑️ Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(360, 145);
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.Text = "🔄 Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // lblSearch
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.lblSearch.Location = new System.Drawing.Point(15, 230);
            this.lblSearch.Text = "🔍 Search:";
            // txtSearch
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(85, 227);
            this.txtSearch.Size = new System.Drawing.Size(300, 25);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // lblRecordCount
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(120, 120, 140);
            this.lblRecordCount.Location = new System.Drawing.Point(830, 230);
            this.lblRecordCount.Text = "Total: 0 records";
            // dgvData styles
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(50, 50, 70);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(60, 60, 80);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(255, 245, 200);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(50, 50, 70);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);

            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(248, 248, 252);
            // dgvData
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeight = 35;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.GridColor = System.Drawing.Color.FromArgb(235, 235, 240);
            this.dgvData.Location = new System.Drawing.Point(15, 260);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowTemplate.Height = 32;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(930, 330);
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // pnlForm controls
            this.pnlForm.Controls.Add(this.lblMovie);
            this.pnlForm.Controls.Add(this.cmbMovie);
            this.pnlForm.Controls.Add(this.lblHall);
            this.pnlForm.Controls.Add(this.cmbHall);
            this.pnlForm.Controls.Add(this.lblShowDate);
            this.pnlForm.Controls.Add(this.dtpShowDate);
            this.pnlForm.Controls.Add(this.lblStartTime);
            this.pnlForm.Controls.Add(this.dtpStartTime);
            this.pnlForm.Controls.Add(this.lblEndTime);
            this.pnlForm.Controls.Add(this.dtpEndTime);
            this.pnlForm.Controls.Add(this.lblPrice);
            this.pnlForm.Controls.Add(this.txtPrice);
            this.pnlForm.Controls.Add(this.btnAdd);
            this.pnlForm.Controls.Add(this.btnEdit);
            this.pnlForm.Controls.Add(this.btnDelete);
            this.pnlForm.Controls.Add(this.btnClear);
            // UC_Showtimes
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.dgvData);
            this.Name = "UC_Showtimes";
            this.Size = new System.Drawing.Size(960, 610);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.ComboBox cmbMovie;
        private System.Windows.Forms.ComboBox cmbHall;
        private System.Windows.Forms.DateTimePicker dtpShowDate;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Label lblHall;
        private System.Windows.Forms.Label lblShowDate;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblRecordCount;
    }
}
