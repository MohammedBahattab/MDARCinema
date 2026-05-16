namespace MDARCinema.UserControls
{
    partial class UC_Bookings
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
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.cmbShowtime = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblShowtime = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
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
            this.pnlForm.Size = new System.Drawing.Size(930, 160);
            // lblUser
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.lblUser.Location = new System.Drawing.Point(30, 20);
            this.lblUser.Text = "User:";
            // cmbUser
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbUser.Location = new System.Drawing.Point(30, 40);
            this.cmbUser.Size = new System.Drawing.Size(250, 25);
            // lblShowtime
            this.lblShowtime.AutoSize = true;
            this.lblShowtime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblShowtime.ForeColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.lblShowtime.Location = new System.Drawing.Point(310, 20);
            this.lblShowtime.Text = "Showtime:";
            // cmbShowtime
            this.cmbShowtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowtime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbShowtime.Location = new System.Drawing.Point(310, 40);
            this.cmbShowtime.Size = new System.Drawing.Size(350, 25);
            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.lblStatus.Location = new System.Drawing.Point(690, 20);
            this.lblStatus.Text = "Status:";
            // cmbStatus
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.Location = new System.Drawing.Point(690, 40);
            this.cmbStatus.Size = new System.Drawing.Size(200, 25);
            // Buttons
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(30, 90);
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.Text = "➕ Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(140, 90);
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.Text = "✏️ Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(250, 90);
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.Text = "🗑️ Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(360, 90);
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.Text = "🔄 Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // lblSearch
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.lblSearch.Location = new System.Drawing.Point(15, 190);
            this.lblSearch.Text = "🔍 Search:";
            // txtSearch
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(85, 187);
            this.txtSearch.Size = new System.Drawing.Size(300, 25);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // lblRecordCount
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(120, 120, 140);
            this.lblRecordCount.Location = new System.Drawing.Point(830, 190);
            this.lblRecordCount.Text = "Total: 0 records";
            // dgvData styles
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(60, 60, 80);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(210, 245, 225);
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
            this.dgvData.Location = new System.Drawing.Point(15, 220);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowTemplate.Height = 32;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(930, 370);
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // pnlForm controls
            this.pnlForm.Controls.Add(this.lblUser);
            this.pnlForm.Controls.Add(this.cmbUser);
            this.pnlForm.Controls.Add(this.lblShowtime);
            this.pnlForm.Controls.Add(this.cmbShowtime);
            this.pnlForm.Controls.Add(this.lblStatus);
            this.pnlForm.Controls.Add(this.cmbStatus);
            this.pnlForm.Controls.Add(this.btnAdd);
            this.pnlForm.Controls.Add(this.btnEdit);
            this.pnlForm.Controls.Add(this.btnDelete);
            this.pnlForm.Controls.Add(this.btnClear);
            // UC_Bookings
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.dgvData);
            this.Name = "UC_Bookings";
            this.Size = new System.Drawing.Size(960, 610);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.ComboBox cmbShowtime;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblShowtime;
        private System.Windows.Forms.Label lblStatus;
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
