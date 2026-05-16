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
        }

        private void LoadData()
        {
            try
            {
                var data = db.bookings.Where(b => b.deleted_at == null).Select(b => new
                {
                    b.id,
                    User = b.user != null ? b.user.name : "Guest",
                    Movie = b.showtime.movy.title,
                    ShowDate = b.showtime.show_date,
                    b.status,
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

                cmbShowtime.DataSource = db.showtimes.Select(s => new
                {
                    s.id,
                    Display = s.movy.title + " - " + s.hall.name + " (" + s.show_date + ")"
                }).ToList();
                cmbShowtime.DisplayMember = "Display";
                cmbShowtime.ValueMember = "id";
                cmbShowtime.SelectedIndex = -1;

                cmbStatus.Items.Clear();
                cmbStatus.Items.AddRange(new string[] { "pending", "confirmed", "cancelled", "completed" });
                cmbStatus.SelectedIndex = -1;
            }
            catch { }
        }

        private void ClearFields()
        {
            cmbUser.SelectedIndex = -1;
            cmbShowtime.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            selectedId = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbShowtime.SelectedValue == null)
            { MessageBox.Show("Please select a showtime!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                var bk = new booking
                {
                    user_id = cmbUser.SelectedValue != null ? (long?)Convert.ToInt64(cmbUser.SelectedValue) : null,
                    showtime_id = Convert.ToInt64(cmbShowtime.SelectedValue),
                    status = cmbStatus.SelectedItem?.ToString() ?? "pending",
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                };
                db.bookings.Add(bk);
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

            try
            {
                var bk = db.bookings.Find(selectedId);
                if (bk != null)
                {
                    bk.user_id = cmbUser.SelectedValue != null ? (long?)Convert.ToInt64(cmbUser.SelectedValue) : null;
                    bk.showtime_id = Convert.ToInt64(cmbShowtime.SelectedValue);
                    bk.status = cmbStatus.SelectedItem?.ToString() ?? "pending";
                    bk.updated_at = DateTime.Now;
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
                var data = db.bookings.Where(b => b.deleted_at == null &&
                    (b.user.name.ToLower().Contains(search) || b.showtime.movy.title.ToLower().Contains(search) || b.status.ToLower().Contains(search)))
                    .Select(b => new
                    {
                        b.id,
                        User = b.user != null ? b.user.name : "Guest",
                        Movie = b.showtime.movy.title,
                        ShowDate = b.showtime.show_date,
                        b.status, b.created_at
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
                string status = row.Cells["status"].Value?.ToString() ?? "";
                cmbStatus.SelectedItem = status;
            }
        }
    }
}
