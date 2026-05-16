using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MDARCinema.UserControls
{
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            try
            {
                using (var db = new CinemaBookingDBEntities1())
                {
                    lblMoviesCount.Text = db.movies.Count().ToString();
                    lblHallsCount.Text = db.halls.Count().ToString();
                    lblBookingsCount.Text = db.bookings.Count().ToString();
                    lblUsersCount.Text = db.users.Count().ToString();
                    lblShowtimesCount.Text = db.showtimes.Count().ToString();
                    lblCategoriesCount.Text = db.categories.Count().ToString();

                    // Load recent bookings
                    var recentBookings = db.bookings
                        .OrderByDescending(b => b.created_at)
                        .Take(10)
                        .Select(b => new
                        {
                            ID = b.id,
                            User = b.user != null ? b.user.name : "Guest",
                            Movie = b.showtime.movy.title,
                            Date = b.showtime.show_date,
                            Status = b.status,
                            Created = b.created_at
                        }).ToList();
                    dgvRecentBookings.DataSource = recentBookings;

                    // Load upcoming showtimes
                    var upcomingShowtimes = db.showtimes
                        .Where(s => s.show_date >= DateTime.Today)
                        .OrderBy(s => s.show_date)
                        .ThenBy(s => s.start_time)
                        .Take(10)
                        .Select(s => new
                        {
                            ID = s.id,
                            Movie = s.movy.title,
                            Hall = s.hall.name,
                            Date = s.show_date,
                            Start = s.start_time,
                            Price = s.price
                        }).ToList();
                    dgvUpcomingShowtimes.DataSource = upcomingShowtimes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
