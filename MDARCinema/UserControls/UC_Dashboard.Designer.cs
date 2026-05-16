namespace MDARCinema.UserControls
{
    partial class UC_Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();

            this.dgvRecentBookings = new System.Windows.Forms.DataGridView();
            this.dgvUpcomingShowtimes = new System.Windows.Forms.DataGridView();
            this.lblRecentBookings = new System.Windows.Forms.Label();
            this.lblUpcomingShowtimes = new System.Windows.Forms.Label();

            this.lblMoviesCount = new System.Windows.Forms.Label();
            this.lblHallsCount = new System.Windows.Forms.Label();
            this.lblBookingsCount = new System.Windows.Forms.Label();
            this.lblUsersCount = new System.Windows.Forms.Label();
            this.lblShowtimesCount = new System.Windows.Forms.Label();
            this.lblCategoriesCount = new System.Windows.Forms.Label();

            // ── Stat Card Panels ──
            this.pnlCardMovies = new System.Windows.Forms.Panel();
            this.lblCardMoviesTitle = new System.Windows.Forms.Label();
            this.pnlCardMoviesBar = new System.Windows.Forms.Panel();

            this.pnlCardHalls = new System.Windows.Forms.Panel();
            this.lblCardHallsTitle = new System.Windows.Forms.Label();
            this.pnlCardHallsBar = new System.Windows.Forms.Panel();

            this.pnlCardBookings = new System.Windows.Forms.Panel();
            this.lblCardBookingsTitle = new System.Windows.Forms.Label();
            this.pnlCardBookingsBar = new System.Windows.Forms.Panel();

            this.pnlCardUsers = new System.Windows.Forms.Panel();
            this.lblCardUsersTitle = new System.Windows.Forms.Label();
            this.pnlCardUsersBar = new System.Windows.Forms.Panel();

            this.pnlCardShowtimes = new System.Windows.Forms.Panel();
            this.lblCardShowtimesTitle = new System.Windows.Forms.Label();
            this.pnlCardShowtimesBar = new System.Windows.Forms.Panel();

            this.pnlCardCategories = new System.Windows.Forms.Panel();
            this.lblCardCategoriesTitle = new System.Windows.Forms.Label();
            this.pnlCardCategoriesBar = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingShowtimes)).BeginInit();
            this.SuspendLayout();

            // ═══════════ Card: Movies ═══════════
            this.pnlCardMovies.BackColor = System.Drawing.Color.White;
            this.pnlCardMovies.Location = new System.Drawing.Point(20, 20);
            this.pnlCardMovies.Name = "pnlCardMovies";
            this.pnlCardMovies.Size = new System.Drawing.Size(200, 110);

            this.lblCardMoviesTitle.AutoSize = true;
            this.lblCardMoviesTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCardMoviesTitle.ForeColor = System.Drawing.Color.FromArgb(120, 120, 140);
            this.lblCardMoviesTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCardMoviesTitle.Text = "🎬 Movies";

            this.lblMoviesCount.AutoSize = true;
            this.lblMoviesCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblMoviesCount.ForeColor = System.Drawing.Color.FromArgb(100, 65, 165);
            this.lblMoviesCount.Location = new System.Drawing.Point(15, 45);
            this.lblMoviesCount.Text = "0";

            this.pnlCardMoviesBar.BackColor = System.Drawing.Color.FromArgb(100, 65, 165);
            this.pnlCardMoviesBar.Location = new System.Drawing.Point(0, 106);
            this.pnlCardMoviesBar.Size = new System.Drawing.Size(200, 4);

            this.pnlCardMovies.Controls.Add(this.lblCardMoviesTitle);
            this.pnlCardMovies.Controls.Add(this.lblMoviesCount);
            this.pnlCardMovies.Controls.Add(this.pnlCardMoviesBar);

            // ═══════════ Card: Halls ═══════════
            this.pnlCardHalls.BackColor = System.Drawing.Color.White;
            this.pnlCardHalls.Location = new System.Drawing.Point(240, 20);
            this.pnlCardHalls.Name = "pnlCardHalls";
            this.pnlCardHalls.Size = new System.Drawing.Size(200, 110);

            this.lblCardHallsTitle.AutoSize = true;
            this.lblCardHallsTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCardHallsTitle.ForeColor = System.Drawing.Color.FromArgb(120, 120, 140);
            this.lblCardHallsTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCardHallsTitle.Text = "🏛️ Halls";

            this.lblHallsCount.AutoSize = true;
            this.lblHallsCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblHallsCount.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.lblHallsCount.Location = new System.Drawing.Point(15, 45);
            this.lblHallsCount.Text = "0";

            this.pnlCardHallsBar.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.pnlCardHallsBar.Location = new System.Drawing.Point(0, 106);
            this.pnlCardHallsBar.Size = new System.Drawing.Size(200, 4);

            this.pnlCardHalls.Controls.Add(this.lblCardHallsTitle);
            this.pnlCardHalls.Controls.Add(this.lblHallsCount);
            this.pnlCardHalls.Controls.Add(this.pnlCardHallsBar);

            // ═══════════ Card: Bookings ═══════════
            this.pnlCardBookings.BackColor = System.Drawing.Color.White;
            this.pnlCardBookings.Location = new System.Drawing.Point(460, 20);
            this.pnlCardBookings.Name = "pnlCardBookings";
            this.pnlCardBookings.Size = new System.Drawing.Size(200, 110);

            this.lblCardBookingsTitle.AutoSize = true;
            this.lblCardBookingsTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCardBookingsTitle.ForeColor = System.Drawing.Color.FromArgb(120, 120, 140);
            this.lblCardBookingsTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCardBookingsTitle.Text = "🎫 Bookings";

            this.lblBookingsCount.AutoSize = true;
            this.lblBookingsCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblBookingsCount.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.lblBookingsCount.Location = new System.Drawing.Point(15, 45);
            this.lblBookingsCount.Text = "0";

            this.pnlCardBookingsBar.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.pnlCardBookingsBar.Location = new System.Drawing.Point(0, 106);
            this.pnlCardBookingsBar.Size = new System.Drawing.Size(200, 4);

            this.pnlCardBookings.Controls.Add(this.lblCardBookingsTitle);
            this.pnlCardBookings.Controls.Add(this.lblBookingsCount);
            this.pnlCardBookings.Controls.Add(this.pnlCardBookingsBar);

            // ═══════════ Card: Users ═══════════
            this.pnlCardUsers.BackColor = System.Drawing.Color.White;
            this.pnlCardUsers.Location = new System.Drawing.Point(680, 20);
            this.pnlCardUsers.Name = "pnlCardUsers";
            this.pnlCardUsers.Size = new System.Drawing.Size(200, 110);

            this.lblCardUsersTitle.AutoSize = true;
            this.lblCardUsersTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCardUsersTitle.ForeColor = System.Drawing.Color.FromArgb(120, 120, 140);
            this.lblCardUsersTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCardUsersTitle.Text = "👥 Users";

            this.lblUsersCount.AutoSize = true;
            this.lblUsersCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblUsersCount.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.lblUsersCount.Location = new System.Drawing.Point(15, 45);
            this.lblUsersCount.Text = "0";

            this.pnlCardUsersBar.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.pnlCardUsersBar.Location = new System.Drawing.Point(0, 106);
            this.pnlCardUsersBar.Size = new System.Drawing.Size(200, 4);

            this.pnlCardUsers.Controls.Add(this.lblCardUsersTitle);
            this.pnlCardUsers.Controls.Add(this.lblUsersCount);
            this.pnlCardUsers.Controls.Add(this.pnlCardUsersBar);

            // ═══════════ Card: Showtimes ═══════════
            this.pnlCardShowtimes.BackColor = System.Drawing.Color.White;
            this.pnlCardShowtimes.Location = new System.Drawing.Point(20, 150);
            this.pnlCardShowtimes.Name = "pnlCardShowtimes";
            this.pnlCardShowtimes.Size = new System.Drawing.Size(200, 110);

            this.lblCardShowtimesTitle.AutoSize = true;
            this.lblCardShowtimesTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCardShowtimesTitle.ForeColor = System.Drawing.Color.FromArgb(120, 120, 140);
            this.lblCardShowtimesTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCardShowtimesTitle.Text = "🎞️ Showtimes";

            this.lblShowtimesCount.AutoSize = true;
            this.lblShowtimesCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblShowtimesCount.ForeColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.lblShowtimesCount.Location = new System.Drawing.Point(15, 45);
            this.lblShowtimesCount.Text = "0";

            this.pnlCardShowtimesBar.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.pnlCardShowtimesBar.Location = new System.Drawing.Point(0, 106);
            this.pnlCardShowtimesBar.Size = new System.Drawing.Size(200, 4);

            this.pnlCardShowtimes.Controls.Add(this.lblCardShowtimesTitle);
            this.pnlCardShowtimes.Controls.Add(this.lblShowtimesCount);
            this.pnlCardShowtimes.Controls.Add(this.pnlCardShowtimesBar);

            // ═══════════ Card: Categories ═══════════
            this.pnlCardCategories.BackColor = System.Drawing.Color.White;
            this.pnlCardCategories.Location = new System.Drawing.Point(240, 150);
            this.pnlCardCategories.Name = "pnlCardCategories";
            this.pnlCardCategories.Size = new System.Drawing.Size(200, 110);

            this.lblCardCategoriesTitle.AutoSize = true;
            this.lblCardCategoriesTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCardCategoriesTitle.ForeColor = System.Drawing.Color.FromArgb(120, 120, 140);
            this.lblCardCategoriesTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCardCategoriesTitle.Text = "📂 Categories";

            this.lblCategoriesCount.AutoSize = true;
            this.lblCategoriesCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblCategoriesCount.ForeColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.lblCategoriesCount.Location = new System.Drawing.Point(15, 45);
            this.lblCategoriesCount.Text = "0";

            this.pnlCardCategoriesBar.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.pnlCardCategoriesBar.Location = new System.Drawing.Point(0, 106);
            this.pnlCardCategoriesBar.Size = new System.Drawing.Size(200, 4);

            this.pnlCardCategories.Controls.Add(this.lblCardCategoriesTitle);
            this.pnlCardCategories.Controls.Add(this.lblCategoriesCount);
            this.pnlCardCategories.Controls.Add(this.pnlCardCategoriesBar);

            // ═══════════ lblRecentBookings ═══════════
            this.lblRecentBookings.AutoSize = true;
            this.lblRecentBookings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRecentBookings.ForeColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.lblRecentBookings.Location = new System.Drawing.Point(20, 285);
            this.lblRecentBookings.Name = "lblRecentBookings";
            this.lblRecentBookings.Size = new System.Drawing.Size(200, 20);
            this.lblRecentBookings.Text = "📋 Recent Bookings";

            // ═══════════ dgvRecentBookings ═══════════
            dgvHeaderStyle1.BackColor = System.Drawing.Color.FromArgb(100, 65, 165);
            dgvHeaderStyle1.ForeColor = System.Drawing.Color.White;
            dgvHeaderStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvHeaderStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);

            dgvCellStyle1.BackColor = System.Drawing.Color.White;
            dgvCellStyle1.ForeColor = System.Drawing.Color.FromArgb(60, 60, 80);
            dgvCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(230, 220, 245);
            dgvCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(50, 50, 70);
            dgvCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);

            this.dgvRecentBookings.AllowUserToAddRows = false;
            this.dgvRecentBookings.AllowUserToDeleteRows = false;
            this.dgvRecentBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentBookings.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentBookings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecentBookings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecentBookings.ColumnHeadersDefaultCellStyle = dgvHeaderStyle1;
            this.dgvRecentBookings.ColumnHeadersHeight = 35;
            this.dgvRecentBookings.DefaultCellStyle = dgvCellStyle1;
            this.dgvRecentBookings.EnableHeadersVisualStyles = false;
            this.dgvRecentBookings.GridColor = System.Drawing.Color.FromArgb(235, 235, 240);
            this.dgvRecentBookings.Location = new System.Drawing.Point(20, 310);
            this.dgvRecentBookings.Name = "dgvRecentBookings";
            this.dgvRecentBookings.ReadOnly = true;
            this.dgvRecentBookings.RowHeadersVisible = false;
            this.dgvRecentBookings.RowTemplate.Height = 30;
            this.dgvRecentBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentBookings.Size = new System.Drawing.Size(450, 280);

            // ═══════════ lblUpcomingShowtimes ═══════════
            this.lblUpcomingShowtimes.AutoSize = true;
            this.lblUpcomingShowtimes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUpcomingShowtimes.ForeColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.lblUpcomingShowtimes.Location = new System.Drawing.Point(490, 285);
            this.lblUpcomingShowtimes.Name = "lblUpcomingShowtimes";
            this.lblUpcomingShowtimes.Size = new System.Drawing.Size(200, 20);
            this.lblUpcomingShowtimes.Text = "🎞️ Upcoming Showtimes";

            // ═══════════ dgvUpcomingShowtimes ═══════════
            dgvHeaderStyle2.BackColor = System.Drawing.Color.FromArgb(100, 65, 165);
            dgvHeaderStyle2.ForeColor = System.Drawing.Color.White;
            dgvHeaderStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvHeaderStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);

            dgvCellStyle2.BackColor = System.Drawing.Color.White;
            dgvCellStyle2.ForeColor = System.Drawing.Color.FromArgb(60, 60, 80);
            dgvCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(230, 220, 245);
            dgvCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(50, 50, 70);
            dgvCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);

            this.dgvUpcomingShowtimes.AllowUserToAddRows = false;
            this.dgvUpcomingShowtimes.AllowUserToDeleteRows = false;
            this.dgvUpcomingShowtimes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUpcomingShowtimes.BackgroundColor = System.Drawing.Color.White;
            this.dgvUpcomingShowtimes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUpcomingShowtimes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUpcomingShowtimes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUpcomingShowtimes.ColumnHeadersDefaultCellStyle = dgvHeaderStyle2;
            this.dgvUpcomingShowtimes.ColumnHeadersHeight = 35;
            this.dgvUpcomingShowtimes.DefaultCellStyle = dgvCellStyle2;
            this.dgvUpcomingShowtimes.EnableHeadersVisualStyles = false;
            this.dgvUpcomingShowtimes.GridColor = System.Drawing.Color.FromArgb(235, 235, 240);
            this.dgvUpcomingShowtimes.Location = new System.Drawing.Point(490, 310);
            this.dgvUpcomingShowtimes.Name = "dgvUpcomingShowtimes";
            this.dgvUpcomingShowtimes.ReadOnly = true;
            this.dgvUpcomingShowtimes.RowHeadersVisible = false;
            this.dgvUpcomingShowtimes.RowTemplate.Height = 30;
            this.dgvUpcomingShowtimes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUpcomingShowtimes.Size = new System.Drawing.Size(450, 280);

            // ═══════════ UC_Dashboard ═══════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            this.Controls.Add(this.pnlCardMovies);
            this.Controls.Add(this.pnlCardHalls);
            this.Controls.Add(this.pnlCardBookings);
            this.Controls.Add(this.pnlCardUsers);
            this.Controls.Add(this.pnlCardShowtimes);
            this.Controls.Add(this.pnlCardCategories);
            this.Controls.Add(this.lblRecentBookings);
            this.Controls.Add(this.dgvRecentBookings);
            this.Controls.Add(this.lblUpcomingShowtimes);
            this.Controls.Add(this.dgvUpcomingShowtimes);
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(960, 610);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingShowtimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMoviesCount;
        private System.Windows.Forms.Label lblHallsCount;
        private System.Windows.Forms.Label lblBookingsCount;
        private System.Windows.Forms.Label lblUsersCount;
        private System.Windows.Forms.Label lblShowtimesCount;
        private System.Windows.Forms.Label lblCategoriesCount;
        private System.Windows.Forms.DataGridView dgvRecentBookings;
        private System.Windows.Forms.DataGridView dgvUpcomingShowtimes;
        private System.Windows.Forms.Label lblRecentBookings;
        private System.Windows.Forms.Label lblUpcomingShowtimes;

        private System.Windows.Forms.Panel pnlCardMovies;
        private System.Windows.Forms.Label lblCardMoviesTitle;
        private System.Windows.Forms.Panel pnlCardMoviesBar;

        private System.Windows.Forms.Panel pnlCardHalls;
        private System.Windows.Forms.Label lblCardHallsTitle;
        private System.Windows.Forms.Panel pnlCardHallsBar;

        private System.Windows.Forms.Panel pnlCardBookings;
        private System.Windows.Forms.Label lblCardBookingsTitle;
        private System.Windows.Forms.Panel pnlCardBookingsBar;

        private System.Windows.Forms.Panel pnlCardUsers;
        private System.Windows.Forms.Label lblCardUsersTitle;
        private System.Windows.Forms.Panel pnlCardUsersBar;

        private System.Windows.Forms.Panel pnlCardShowtimes;
        private System.Windows.Forms.Label lblCardShowtimesTitle;
        private System.Windows.Forms.Panel pnlCardShowtimesBar;

        private System.Windows.Forms.Panel pnlCardCategories;
        private System.Windows.Forms.Label lblCardCategoriesTitle;
        private System.Windows.Forms.Panel pnlCardCategoriesBar;
    }
}
