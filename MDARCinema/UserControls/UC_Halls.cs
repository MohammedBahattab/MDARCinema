using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MDARCinema.UserControls
{
    public partial class UC_Halls : UserControl
    {
        private CinemaBookingDBEntities1 db = new CinemaBookingDBEntities1();
        private long selectedId = 0;

        public UC_Halls()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var data = db.halls.Select(h => new
                {
                    h.id,
                    h.name,
                    h.total_rows,
                    h.seats_per_row,
                    TotalSeats = h.total_rows * h.seats_per_row,
                    h.created_at
                }).ToList();
                dgvData.DataSource = data;
                lblRecordCount.Text = "Total: " + data.Count + " records";
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtTotalRows.Clear();
            txtSeatsPerRow.Clear();
            selectedId = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            { MessageBox.Show("Please enter hall name!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                var hall = new hall
                {
                    name = txtName.Text.Trim(),
                    total_rows = int.TryParse(txtTotalRows.Text, out int r) ? r : 0,
                    seats_per_row = int.TryParse(txtSeatsPerRow.Text, out int s) ? s : 0,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                };
                db.halls.Add(hall);
                db.SaveChanges();
                LoadData();
                ClearFields();
                MessageBox.Show("Hall added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            { MessageBox.Show("Please select a hall to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                var hall = db.halls.Find(selectedId);
                if (hall != null)
                {
                    hall.name = txtName.Text.Trim();
                    hall.total_rows = int.TryParse(txtTotalRows.Text, out int r) ? r : 0;
                    hall.seats_per_row = int.TryParse(txtSeatsPerRow.Text, out int s) ? s : 0;
                    hall.updated_at = DateTime.Now;
                    db.SaveChanges();
                    LoadData();
                    ClearFields();
                    MessageBox.Show("Hall updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            { MessageBox.Show("Please select a hall to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var hall = db.halls.Find(selectedId);
                    if (hall != null)
                    {
                        db.halls.Remove(hall);
                        db.SaveChanges();
                        LoadData();
                        ClearFields();
                        MessageBox.Show("Hall deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var data = db.halls.Where(h => h.name.ToLower().Contains(search))
                    .Select(h => new
                    {
                        h.id, h.name, h.total_rows, h.seats_per_row,
                        TotalSeats = h.total_rows * h.seats_per_row, h.created_at
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
                txtName.Text = row.Cells["name"].Value?.ToString() ?? "";
                txtTotalRows.Text = row.Cells["total_rows"].Value?.ToString() ?? "";
                txtSeatsPerRow.Text = row.Cells["seats_per_row"].Value?.ToString() ?? "";
            }
        }
    }
}
