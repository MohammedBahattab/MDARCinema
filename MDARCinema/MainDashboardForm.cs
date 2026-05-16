using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using MDARCinema.UserControls;

namespace MDARCinema
{
    public partial class MainDashboardForm : Form
    {
        private Button _activeButton = null;
        private readonly Color _sidebarColor = Color.FromArgb(30, 30, 46);
        private readonly Color _activeColor = Color.FromArgb(100, 65, 165);
        private readonly Color _hoverColor = Color.FromArgb(55, 55, 75);

        public MainDashboardForm()
        {
            InitializeComponent();
            LoadUserControl(new UC_Dashboard());
            SetActiveButton(btnDashboard);
        }

        // ═══════════ Navigation ═══════════
        private void LoadUserControl(UserControl uc)
        {
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void SetActiveButton(Button btn)
        {
            if (_activeButton != null)
            {
                _activeButton.BackColor = _sidebarColor;
                _activeButton.ForeColor = Color.FromArgb(180, 180, 200);
            }
            _activeButton = btn;
            _activeButton.BackColor = _activeColor;
            _activeButton.ForeColor = Color.White;
        }

        // ═══════════ Button Hover Effects ═══════════
        private void SidebarButton_MouseEnter(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn != _activeButton)
                btn.BackColor = _hoverColor;
        }

        private void SidebarButton_MouseLeave(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn != _activeButton)
                btn.BackColor = _sidebarColor;
        }

        // ═══════════ Navigation Click Events ═══════════
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Dashboard());
            SetActiveButton(btnDashboard);
            lblPageTitle.Text = "   📊  Dashboard";
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Movies());
            SetActiveButton(btnMovies);
            lblPageTitle.Text = "   🎬  Movies Management";
        }

        private void btnHalls_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Halls());
            SetActiveButton(btnHalls);
            lblPageTitle.Text = "   🏛️  Halls Management";
        }

        private void btnShowtimes_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Showtimes());
            SetActiveButton(btnShowtimes);
            lblPageTitle.Text = "   🎞️  Showtimes Management";
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Bookings());
            SetActiveButton(btnBookings);
            lblPageTitle.Text = "   🎫  Bookings Management";
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Users());
            SetActiveButton(btnUsers);
            lblPageTitle.Text = "   👥  Users Management";
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Categories());
            SetActiveButton(btnCategories);
            lblPageTitle.Text = "   📂  Categories Management";
        }

        private void btnStudios_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Studios());
            SetActiveButton(btnStudios);
            lblPageTitle.Text = "   🎬  Studios Management";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
