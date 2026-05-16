using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MDARCinema.UserControls
{
    public partial class UC_Showtimes : UserControl
    {
        private CinemaBookingDBEntities1 db = new CinemaBookingDBEntities1();
        private long selectedId = 0;

        public UC_Showtimes()
        {
            InitializeComponent();
            LoadData();
            LoadCombos();
        }

        private void LoadData()
        {
            try
            {
                var data = db.showtimes.Select(s => new
                {
                    s.id,
                    Movie = s.movy.title,
                    Hall = s.hall.name,
                    s.show_date,
                    s.start_time,
                    s.end_time,
                    s.price
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
                cmbMovie.DataSource = db.movies.Where(m => m.deleted_at == null).ToList();
                cmbMovie.DisplayMember = "title";
                cmbMovie.ValueMember = "id";
                cmbMovie.SelectedIndex = -1;

                cmbHall.DataSource = db.halls.ToList();
                cmbHall.DisplayMember = "name";
                cmbHall.ValueMember = "id";
                cmbHall.SelectedIndex = -1;
            }
            catch { }
        }

        private void ClearFields()
        {
            cmbMovie.SelectedIndex = -1;
            cmbHall.SelectedIndex = -1;
            dtpShowDate.Value = DateTime.Now;
            dtpStartTime.Value = DateTime.Today;
            dtpEndTime.Value = DateTime.Today;
            txtPrice.Clear();
            selectedId = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbMovie.SelectedValue == null || cmbHall.SelectedValue == null)
            { MessageBox.Show("Please select movie and hall!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                var st = new showtime
                {
                    movie_id = Convert.ToInt64(cmbMovie.SelectedValue),
                    hall_id = Convert.ToInt64(cmbHall.SelectedValue),
                    show_date = dtpShowDate.Value.Date,
                    start_time = dtpStartTime.Value.TimeOfDay,
                    end_time = dtpEndTime.Value.TimeOfDay,
                    price = decimal.TryParse(txtPrice.Text, out decimal p) ? p : 0,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                };
                db.showtimes.Add(st);
                db.SaveChanges();
                LoadData();
                ClearFields();
                MessageBox.Show("Showtime added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) { MessageBox.Show("Select a showtime first!"); return; }

            try
            {
                var st = db.showtimes.Find(selectedId);
                if (st != null)
                {
                    st.movie_id = Convert.ToInt64(cmbMovie.SelectedValue);
                    st.hall_id = Convert.ToInt64(cmbHall.SelectedValue);
                    st.show_date = dtpShowDate.Value.Date;
                    st.start_time = dtpStartTime.Value.TimeOfDay;
                    st.end_time = dtpEndTime.Value.TimeOfDay;
                    st.price = decimal.TryParse(txtPrice.Text, out decimal p) ? p : 0;
                    st.updated_at = DateTime.Now;
                    db.SaveChanges();
                    LoadData();
                    ClearFields();
                    MessageBox.Show("Showtime updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) { MessageBox.Show("Select a showtime first!"); return; }
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var st = db.showtimes.Find(selectedId);
                    if (st != null)
                    {
                        db.showtimes.Remove(st);
                        db.SaveChanges();
                        LoadData();
                        ClearFields();
                        MessageBox.Show("Showtime deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var data = db.showtimes.Where(s => s.movy.title.ToLower().Contains(search))
                    .Select(s => new
                    {
                        s.id, Movie = s.movy.title, Hall = s.hall.name,
                        s.show_date, s.start_time, s.end_time, s.price
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
                txtPrice.Text = row.Cells["price"].Value?.ToString() ?? "";
                if (row.Cells["show_date"].Value != null && row.Cells["show_date"].Value != System.DBNull.Value)
                    dtpShowDate.Value = Convert.ToDateTime(row.Cells["show_date"].Value);

                // Try to match movie and hall in combos
                string movieName = row.Cells["Movie"].Value?.ToString() ?? "";
                string hallName = row.Cells["Hall"].Value?.ToString() ?? "";
                for (int i = 0; i < cmbMovie.Items.Count; i++)
                    if (((movy)cmbMovie.Items[i]).title == movieName) { cmbMovie.SelectedIndex = i; break; }
                for (int i = 0; i < cmbHall.Items.Count; i++)
                    if (((hall)cmbHall.Items[i]).name == hallName) { cmbHall.SelectedIndex = i; break; }
            }
        }
    }
}
