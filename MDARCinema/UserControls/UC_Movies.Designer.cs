namespace MDARCinema.UserControls
{
    partial class UC_Movies
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            if (disposing && db != null)
                db.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlForm = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStudio = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblStudio = new System.Windows.Forms.Label();
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
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Location = new System.Drawing.Point(15, 15);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(930, 220);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.lblTitle.Location = new System.Drawing.Point(30, 30);
            this.lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTitle.Location = new System.Drawing.Point(30, 50);
            this.txtTitle.Size = new System.Drawing.Size(200, 25);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.lblDescription.Location = new System.Drawing.Point(250, 30);
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(250, 50);
            this.txtDescription.Size = new System.Drawing.Size(250, 25);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDuration.ForeColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.lblDuration.Location = new System.Drawing.Point(520, 30);
            this.lblDuration.Text = "Duration (min):";
            // 
            // txtDuration
            // 
            this.txtDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuration.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDuration.Location = new System.Drawing.Point(520, 50);
            this.txtDuration.Size = new System.Drawing.Size(120, 25);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLanguage.ForeColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.lblLanguage.Location = new System.Drawing.Point(660, 30);
            this.lblLanguage.Text = "Language:";
            // 
            // txtLanguage
            // 
            this.txtLanguage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLanguage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLanguage.Location = new System.Drawing.Point(660, 50);
            this.txtLanguage.Size = new System.Drawing.Size(130, 25);
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRating.ForeColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.lblRating.Location = new System.Drawing.Point(810, 30);
            this.lblRating.Text = "Rating:";
            // 
            // txtRating
            // 
            this.txtRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRating.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRating.Location = new System.Drawing.Point(810, 50);
            this.txtRating.Size = new System.Drawing.Size(100, 25);
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReleaseDate.ForeColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.lblReleaseDate.Location = new System.Drawing.Point(30, 90);
            this.lblReleaseDate.Text = "Release Date:";
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpReleaseDate.Location = new System.Drawing.Point(30, 110);
            this.dtpReleaseDate.Size = new System.Drawing.Size(200, 25);
            // 
            // lblStudio
            // 
            this.lblStudio.AutoSize = true;
            this.lblStudio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStudio.ForeColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.lblStudio.Location = new System.Drawing.Point(250, 90);
            this.lblStudio.Text = "Studio:";
            // 
            // cmbStudio
            // 
            this.cmbStudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStudio.Location = new System.Drawing.Point(250, 110);
            this.cmbStudio.Size = new System.Drawing.Size(200, 25);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(30, 160);
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.Text = "➕ Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(140, 160);
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.Text = "✏️ Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(250, 160);
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.Text = "🗑️ Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(360, 160);
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.Text = "🔄 Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(80, 80, 100);
            this.lblSearch.Location = new System.Drawing.Point(15, 250);
            this.lblSearch.Text = "🔍 Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(85, 247);
            this.txtSearch.Size = new System.Drawing.Size(300, 25);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(120, 120, 140);
            this.lblRecordCount.Location = new System.Drawing.Point(830, 250);
            this.lblRecordCount.Text = "Total: 0 records";
            // 
            // dgvData
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(100, 65, 165);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(60, 60, 80);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(230, 220, 245);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(50, 50, 70);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);

            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(248, 248, 252);

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
            this.dgvData.Location = new System.Drawing.Point(15, 280);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowTemplate.Height = 32;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(930, 310);
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // pnlForm - add controls
            // 
            this.pnlForm.Controls.Add(this.lblTitle);
            this.pnlForm.Controls.Add(this.txtTitle);
            this.pnlForm.Controls.Add(this.lblDescription);
            this.pnlForm.Controls.Add(this.txtDescription);
            this.pnlForm.Controls.Add(this.lblDuration);
            this.pnlForm.Controls.Add(this.txtDuration);
            this.pnlForm.Controls.Add(this.lblLanguage);
            this.pnlForm.Controls.Add(this.txtLanguage);
            this.pnlForm.Controls.Add(this.lblRating);
            this.pnlForm.Controls.Add(this.txtRating);
            this.pnlForm.Controls.Add(this.lblReleaseDate);
            this.pnlForm.Controls.Add(this.dtpReleaseDate);
            this.pnlForm.Controls.Add(this.lblStudio);
            this.pnlForm.Controls.Add(this.cmbStudio);
            this.pnlForm.Controls.Add(this.btnAdd);
            this.pnlForm.Controls.Add(this.btnEdit);
            this.pnlForm.Controls.Add(this.btnDelete);
            this.pnlForm.Controls.Add(this.btnClear);
            // 
            // UC_Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.dgvData);
            this.Name = "UC_Movies";
            this.Size = new System.Drawing.Size(960, 610);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.ComboBox cmbStudio;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblStudio;
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
