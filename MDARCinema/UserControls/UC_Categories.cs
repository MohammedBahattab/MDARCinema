using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MDARCinema.UserControls
{
    public partial class UC_Categories : UserControl
    {
        private CinemaBookingDBEntities1 db = new CinemaBookingDBEntities1();
        private long selectedId = 0;

        public UC_Categories()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var data = db.categories.Select(c => new
                {
                    c.id, c.name, c.created_at, c.updated_at
                }).ToList();
                dgvData.DataSource = data;
                lblRecordCount.Text = "Total: " + data.Count + " records";
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void ClearFields() { txtName.Clear(); selectedId = 0; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            { MessageBox.Show("Enter category name!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                db.categories.Add(new category { name = txtName.Text.Trim(), created_at = DateTime.Now, updated_at = DateTime.Now });
                db.SaveChanges(); LoadData(); ClearFields();
                MessageBox.Show("Category added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) { MessageBox.Show("Select a category first!"); return; }
            try
            {
                var c = db.categories.Find(selectedId);
                if (c != null) { c.name = txtName.Text.Trim(); c.updated_at = DateTime.Now; db.SaveChanges(); LoadData(); ClearFields(); MessageBox.Show("Category updated!"); }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) { MessageBox.Show("Select a category first!"); return; }
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var c = db.categories.Find(selectedId);
                    if (c != null) { db.categories.Remove(c); db.SaveChanges(); LoadData(); ClearFields(); MessageBox.Show("Category deleted!"); }
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) { ClearFields(); }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string s = txtSearch.Text.Trim().ToLower();
                var data = db.categories.Where(c => c.name.ToLower().Contains(s))
                    .Select(c => new { c.id, c.name, c.created_at, c.updated_at }).ToList();
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
            }
        }
    }
}
