namespace MDARCinema
{
    partial class MainDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboardForm));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStudios = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnShowtimes = new System.Windows.Forms.Button();
            this.btnHalls = new System.Windows.Forms.Button();
            this.btnMovies = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.pnlSidebar.Controls.Add(this.btnExit);
            this.pnlSidebar.Controls.Add(this.btnStudios);
            this.pnlSidebar.Controls.Add(this.btnCategories);
            this.pnlSidebar.Controls.Add(this.btnUsers);
            this.pnlSidebar.Controls.Add(this.btnBookings);
            this.pnlSidebar.Controls.Add(this.btnShowtimes);
            this.pnlSidebar.Controls.Add(this.btnHalls);
            this.pnlSidebar.Controls.Add(this.btnMovies);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(330, 1050);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnExit.Location = new System.Drawing.Point(0, 973);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(330, 77);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "   🚪  Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // btnStudios
            // 
            this.btnStudios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudios.FlatAppearance.BorderSize = 0;
            this.btnStudios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudios.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnStudios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnStudios.Location = new System.Drawing.Point(0, 662);
            this.btnStudios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStudios.Name = "btnStudios";
            this.btnStudios.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnStudios.Size = new System.Drawing.Size(330, 77);
            this.btnStudios.TabIndex = 8;
            this.btnStudios.Text = "   🎬  Studios";
            this.btnStudios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudios.UseVisualStyleBackColor = false;
            this.btnStudios.Click += new System.EventHandler(this.btnStudios_Click);
            this.btnStudios.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnStudios.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // btnCategories
            // 
            this.btnCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnCategories.Location = new System.Drawing.Point(0, 585);
            this.btnCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnCategories.Size = new System.Drawing.Size(330, 77);
            this.btnCategories.TabIndex = 7;
            this.btnCategories.Text = "   📂  Categories";
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            this.btnCategories.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnCategories.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // btnUsers
            // 
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnUsers.Location = new System.Drawing.Point(0, 508);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(330, 77);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.Text = "   👥  Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            this.btnUsers.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnUsers.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // btnBookings
            // 
            this.btnBookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookings.FlatAppearance.BorderSize = 0;
            this.btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnBookings.Location = new System.Drawing.Point(0, 431);
            this.btnBookings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnBookings.Size = new System.Drawing.Size(330, 77);
            this.btnBookings.TabIndex = 5;
            this.btnBookings.Text = "   🎫  Bookings";
            this.btnBookings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookings.UseVisualStyleBackColor = false;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            this.btnBookings.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnBookings.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // btnShowtimes
            // 
            this.btnShowtimes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowtimes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowtimes.FlatAppearance.BorderSize = 0;
            this.btnShowtimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowtimes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnShowtimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnShowtimes.Location = new System.Drawing.Point(0, 354);
            this.btnShowtimes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowtimes.Name = "btnShowtimes";
            this.btnShowtimes.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnShowtimes.Size = new System.Drawing.Size(330, 77);
            this.btnShowtimes.TabIndex = 4;
            this.btnShowtimes.Text = "   🎞️  Showtimes";
            this.btnShowtimes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowtimes.UseVisualStyleBackColor = false;
            this.btnShowtimes.Click += new System.EventHandler(this.btnShowtimes_Click);
            this.btnShowtimes.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnShowtimes.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // btnHalls
            // 
            this.btnHalls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHalls.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHalls.FlatAppearance.BorderSize = 0;
            this.btnHalls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHalls.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHalls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnHalls.Location = new System.Drawing.Point(0, 277);
            this.btnHalls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHalls.Name = "btnHalls";
            this.btnHalls.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnHalls.Size = new System.Drawing.Size(330, 77);
            this.btnHalls.TabIndex = 3;
            this.btnHalls.Text = "   🏛️  Halls";
            this.btnHalls.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHalls.UseVisualStyleBackColor = false;
            this.btnHalls.Click += new System.EventHandler(this.btnHalls_Click);
            this.btnHalls.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnHalls.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // btnMovies
            // 
            this.btnMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovies.FlatAppearance.BorderSize = 0;
            this.btnMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovies.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMovies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnMovies.Location = new System.Drawing.Point(0, 200);
            this.btnMovies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnMovies.Size = new System.Drawing.Size(330, 77);
            this.btnMovies.TabIndex = 2;
            this.btnMovies.Text = "   🎬  Movies";
            this.btnMovies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovies.UseVisualStyleBackColor = false;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            this.btnMovies.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnMovies.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 123);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(330, 77);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "   📊  Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnDashboard.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(36)))));
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(330, 123);
            this.pnlLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MDARCinema.Properties.Resources.ic;
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.Red;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(330, 123);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "MDAR Cinema";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(330, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1470, 92);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.lblPageTitle.Location = new System.Drawing.Point(0, 0);
            this.lblPageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblPageTitle.Size = new System.Drawing.Size(1470, 92);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "   📊  Dashboard";
            this.lblPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(330, 92);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1470, 958);
            this.pnlContent.TabIndex = 2;
            // 
            // MainDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1050);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDAR Cinema - Admin Dashboard";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnMovies;
        private System.Windows.Forms.Button btnHalls;
        private System.Windows.Forms.Button btnShowtimes;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnStudios;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
