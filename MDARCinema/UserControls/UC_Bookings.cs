using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MDARCinema.UserControls
{
    public partial class UC_Bookings : UserControl
    {
        private CinemaBookingDBEntities1 db = new CinemaBookingDBEntities1();
        private long selectedId = 0;

        public UC_Bookings()
        {
            InitializeComponent();
            LoadData();
            LoadCombos();
            cmbShowtime.SelectedIndexChanged += cmbShowtime_SelectedIndexChanged;
        }

        private void LoadData()
        {
            try
            {
                var bookings = db.bookings.Where(b => b.deleted_at == null).ToList();
                var data = bookings.Select(b => new
                {
                    b.id,
                    User = b.user != null ? b.user.name : "Guest",
                    Movie = b.showtime.movy.title,
                    Hall = b.showtime.hall.name,
                    Seats = string.Join(", ", b.booking_seats.Select(bs => "R" + bs.seat.row_number + "-S" + bs.seat.seat_number)),
                    TotalAmount = b.booking_seats.Sum(bs => (decimal?)bs.price) ?? 0,
                    State = b.status,
                    b.created_at
                }).ToList();
                dgvData.DataSource = data;
                lblRecordCount.Text = "Total: " + data.Count + " records";
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void LoadCombos()
        {
            try
            {
                cmbUser.DataSource = db.users.Where(u => u.deleted_at == null).ToList();
                cmbUser.DisplayMember = "name";
                cmbUser.ValueMember = "id";
                cmbUser.SelectedIndex = -1;

                cmbShowtime.DataSource = db.showtimes.ToList().Select(s => new
                {
                    s.id,
                    Display = s.movy.title + " - " + s.hall.name + " (" + s.show_date.ToShortDateString() + ")"
                }).ToList();
                cmbShowtime.DisplayMember = "Display";
                cmbShowtime.ValueMember = "id";
                cmbShowtime.SelectedIndex = -1;

                cmbStatus.Items.Clear();
                cmbStatus.Items.AddRange(new string[] { "pending", "confirmed", "cancelled", "completed" });
                cmbStatus.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show("Error loading combos: " + ex.Message); }
        }

        private void ClearFields()
        {
            cmbUser.SelectedIndex = -1;
            cmbShowtime.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            clbSeats.Items.Clear();
            selectedId = 0;
        }

        private void cmbShowtime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedId == 0) // Only auto-load when adding new
                LoadAvailableSeats();
        }

        private void LoadAvailableSeats()
        {
            if (cmbShowtime.SelectedValue == null || !(cmbShowtime.SelectedValue is long)) { clbSeats.Items.Clear(); return; }
            try
            {
                long showtimeId = (long)cmbShowtime.SelectedValue;
                var st = db.showtimes.Find(showtimeId);
                if (st == null) return;

                var allSeats = db.seats.Where(s => s.hall_id == st.hall_id).ToList();
                var bookedSeatIds = db.booking_seats.Where(bs => bs.showtime_id == showtimeId && bs.booking.deleted_at == null && bs.booking_id != selectedId).Select(bs => bs.seat_id).ToList();

                clbSeats.Items.Clear();
                foreach (var seat in allSeats)
                {
                    if (!bookedSeatIds.Contains(seat.id))
                    {
                        clbSeats.Items.Add(new SeatItem { Id = seat.id, Display = "Row " + seat.row_number + " - Seat " + seat.seat_number }, false);
                    }
                }
                clbSeats.DisplayMember = "Display";
            }
            catch { }
        }

        public class SeatItem
        {
            public long Id { get; set; }
            public string Display { get; set; }
            public override string ToString() => Display;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbShowtime.SelectedValue == null)
            { MessageBox.Show("Please select a showtime!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (clbSeats.CheckedItems.Count == 0)
            { MessageBox.Show("Please select at least one seat!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                long showtimeId = Convert.ToInt64(cmbShowtime.SelectedValue);
                var st = db.showtimes.Find(showtimeId);
                var bk = new booking
                {
                    user_id = cmbUser.SelectedValue != null ? (long?)Convert.ToInt64(cmbUser.SelectedValue) : null,
                    showtime_id = showtimeId,
                    status = cmbStatus.SelectedItem?.ToString() ?? "pending",
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                };
                db.bookings.Add(bk);
                db.SaveChanges();

                foreach (SeatItem item in clbSeats.CheckedItems)
                {
                    db.booking_seats.Add(new booking_seats
                    {
                        booking_id = bk.id,
                        showtime_id = showtimeId,
                        seat_id = item.Id,
                        price = st.price,
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now
                    });
                }
                db.SaveChanges();

                LoadData();
                ClearFields();
                MessageBox.Show("Booking added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) { MessageBox.Show("Select a booking first!"); return; }
            if (clbSeats.CheckedItems.Count == 0)
            { MessageBox.Show("Please select at least one seat!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                var bk = db.bookings.Find(selectedId);
                if (bk != null)
                {
                    long showtimeId = Convert.ToInt64(cmbShowtime.SelectedValue);
                    var st = db.showtimes.Find(showtimeId);
                    bk.user_id = cmbUser.SelectedValue != null ? (long?)Convert.ToInt64(cmbUser.SelectedValue) : null;
                    bk.showtime_id = showtimeId;
                    bk.status = cmbStatus.SelectedItem?.ToString() ?? "pending";
                    bk.updated_at = DateTime.Now;

                    // Remove old seats
                    var oldSeats = db.booking_seats.Where(bs => bs.booking_id == bk.id).ToList();
                    foreach (var os in oldSeats) db.booking_seats.Remove(os);

                    // Add new seats
                    foreach (SeatItem item in clbSeats.CheckedItems)
                    {
                        db.booking_seats.Add(new booking_seats
                        {
                            booking_id = bk.id,
                            showtime_id = showtimeId,
                            seat_id = item.Id,
                            price = st.price,
                            created_at = DateTime.Now,
                            updated_at = DateTime.Now
                        });
                    }

                    db.SaveChanges();
                    LoadData();
                    ClearFields();
                    MessageBox.Show("Booking updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) { MessageBox.Show("Select a booking first!"); return; }
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var bk = db.bookings.Find(selectedId);
                    if (bk != null)
                    {
                        bk.deleted_at = DateTime.Now;
                        db.SaveChanges();
                        LoadData();
                        ClearFields();
                        MessageBox.Show("Booking deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) { ClearFields(); }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string search = txtSearch.Text.Trim().ToLower();
                var bookings = db.bookings.Where(b => b.deleted_at == null &&
                    (b.user.name.ToLower().Contains(search) || b.showtime.movy.title.ToLower().Contains(search) || b.status.ToLower().Contains(search)))
                    .ToList();
                var data = bookings.Select(b => new
                {
                    b.id,
                    User = b.user != null ? b.user.name : "Guest",
                    Movie = b.showtime.movy.title,
                    Hall = b.showtime.hall.name,
                    Seats = string.Join(", ", b.booking_seats.Select(bs => "R" + bs.seat.row_number + "-S" + bs.seat.seat_number)),
                    TotalAmount = b.booking_seats.Sum(bs => (decimal?)bs.price) ?? 0,
                    State = b.status,
                    b.created_at
                }).ToList();
                dgvData.DataSource = data;
                lblRecordCount.Text = "Total: " + data.Count + " records";
            }
            catch { }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvData.Rows[e.RowIndex];
                selectedId = Convert.ToInt64(row.Cells["id"].Value);
                
                var bk = db.bookings.Find(selectedId);
                if (bk != null)
                {
                    cmbUser.SelectedValue = bk.user_id;
                    cmbShowtime.SelectedValue = bk.showtime_id;
                    cmbStatus.SelectedItem = bk.status;
                    
                    LoadAvailableSeats();
                    // Mark already booked seats for this booking
                    for (int i = 0; i < clbSeats.Items.Count; i++)
                    {
                        var item = (SeatItem)clbSeats.Items[i];
                        if (bk.booking_seats.Any(bs => bs.seat_id == item.Id))
                            clbSeats.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) { MessageBox.Show("Please select a booking to print!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                var bk = db.bookings.Find(selectedId);
                if (bk == null) return;

                Graphics g = e.Graphics;
                Font titleFont = new Font("Segoe UI", 20, FontStyle.Bold);
                Font headerFont = new Font("Segoe UI", 12, FontStyle.Bold);
                Font bodyFont = new Font("Segoe UI", 10);
                Brush brush = Brushes.Black;
                float x = 50, y = 50;

                // Title
                g.DrawString("MDAR CINEMA - INVOICE", titleFont, brush, x, y);
                y += 50;
                g.DrawLine(Pens.Black, x, y, 750, y);
                y += 20;

                // Booking Info
                g.DrawString("Booking ID: " + bk.id, headerFont, brush, x, y);
                y += 25;
                g.DrawString("Date: " + DateTime.Now.ToString("g"), bodyFont, brush, x, y);
                y += 40;

                // Customer Info
                g.DrawString("Customer: " + (bk.user != null ? bk.user.name : "Guest"), bodyFont, brush, x, y);
                y += 25;

                // Movie Info
                g.DrawString("Movie: " + bk.showtime.movy.title, headerFont, brush, x, y);
                y += 25;
                g.DrawString("Hall: " + bk.showtime.hall.name, bodyFont, brush, x, y);
                y += 25;
                g.DrawString("Showtime: " + bk.showtime.show_date.ToShortDateString() + " " + bk.showtime.start_time, bodyFont, brush, x, y);
                y += 40;

                // Seats
                g.DrawString("SEATS:", headerFont, brush, x, y);
                y += 25;
                string seatsStr = string.Join(", ", bk.booking_seats.Select(bs => "Row " + bs.seat.row_number + " Seat " + bs.seat.seat_number));
                g.DrawString(seatsStr, bodyFont, brush, x, y);
                y += 50;

                // Pricing
                decimal total = bk.booking_seats.Sum(bs => (decimal?)bs.price) ?? 0;
                g.DrawLine(Pens.Gray, x, y, 750, y);
                y += 10;
                g.DrawString("TOTAL AMOUNT: " + total.ToString("C"), titleFont, Brushes.DarkRed, x, y);
                y += 60;

                // Footer
                g.DrawString("Thank you for choosing MDAR Cinema!", bodyFont, brush, x, y);
                y += 20;
                g.DrawString("Please present this invoice at the entrance.", bodyFont, Brushes.Gray, x, y);
            }
            catch (Exception ex) { MessageBox.Show("Printing error: " + ex.Message); }
        }
    }
}
