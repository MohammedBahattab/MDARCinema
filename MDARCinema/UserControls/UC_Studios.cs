using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MDARCinema.UserControls
{
    public partial class UC_Studios : UserControl
    {
        private CinemaBookingDBEntities1 db = new CinemaBookingDBEntities1();
        private long selectedId = 0;

        public UC_Studios()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var data = db.studios.Select(s => new
                {
                    s.id, s.name, s.country, s.founded_year, s.created_at
                }).ToList();
                dgvData.DataSource = data;
                lblRecordCount.Text = "Total: " + data.Count + " records";
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtCountry.Clear();
            txtFoundedYear.Clear();
            selectedId = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Enter studio name!", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                db.studios.Add(new studio
                {
                    name = txtName.Text.Trim(),
                    country = txtCountry.Text.Trim(),
                    founded_year = int.TryParse(txtFoundedYear.Text, out int y) ? (int?)y : null,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                });
                db.SaveChanges();
                LoadData();
                ClearFields();
                MessageBox.Show("Studio added!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Select a studio first!");
                return;
            }
            try
            {
                var s = db.studios.Find(selectedId);
                if (s != null)
                {
                    s.name = txtName.Text.Trim();
                    s.country = txtCountry.Text.Trim();
                    s.founded_year = int.TryParse(txtFoundedYear.Text, out int y) ? (int?)y : null;
                    s.updated_at = DateTime.Now;
                    db.SaveChanges();
                    LoadData();
                    ClearFields();
                    MessageBox.Show("Studio updated!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Select a studio first!");
                return;
            }
            if (MessageBox.Show("Are you sure?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var s = db.studios.Find(selectedId);
                    if (s != null)
                    {
                        db.studios.Remove(s);
                        db.SaveChanges();
                        LoadData();
                        ClearFields();
                        MessageBox.Show("Studio deleted!");
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
                string sr = txtSearch.Text.Trim().ToLower();
                var data = db.studios
                    .Where(s => s.name.ToLower().Contains(sr) || s.country.ToLower().Contains(sr))
                    .Select(s => new { s.id, s.name, s.country, s.founded_year, s.created_at })
                    .ToList();
                dgvData.DataSource = data;
                lblRecordCount.Text = "Total: " + data.Count + " records";
            }
            catch { }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt64(dgvData.Rows[e.RowIndex].Cells["id"].Value);
                txtName.Text = dgvData.Rows[e.RowIndex].Cells["name"].Value?.ToString() ?? "";
                txtCountry.Text = dgvData.Rows[e.RowIndex].Cells["country"].Value?.ToString() ?? "";
                txtFoundedYear.Text = dgvData.Rows[e.RowIndex].Cells["founded_year"].Value?.ToString() ?? "";
            }
        }
    }
}
