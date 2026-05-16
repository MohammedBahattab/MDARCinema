using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MDARCinema.UserControls
{
    public partial class UC_Users : UserControl
    {
        private CinemaBookingDBEntities1 db = new CinemaBookingDBEntities1();
        private long selectedId = 0;

        public UC_Users()
        {
            InitializeComponent();
            LoadData();
            LoadRoles();
        }

        private void LoadData()
        {
            try
            {
                var data = db.users.Where(u => u.deleted_at == null).Select(u => new
                {
                    u.id, u.name, u.email, u.phone_number, u.age,
                    Role = u.role != null ? u.role.name : "", u.created_at
                }).ToList();
                dgvData.DataSource = data;
                lblRecordCount.Text = "Total: " + data.Count + " records";
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void LoadRoles()
        {
            try
            {
                cmbRole.DataSource = db.roles.ToList();
                cmbRole.DisplayMember = "name";
                cmbRole.ValueMember = "id";
                cmbRole.SelectedIndex = -1;
            }
            catch { }
        }

        private void ClearFields()
        {
            txtName.Clear(); txtEmail.Clear(); txtPassword.Clear();
            txtPhone.Clear(); txtAge.Clear(); cmbRole.SelectedIndex = -1;
            selectedId = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            { MessageBox.Show("Name and Email are required!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                var u = new user
                {
                    name = txtName.Text.Trim(),
                    email = txtEmail.Text.Trim(),
                    password = txtPassword.Text.Trim(),
                    phone_number = txtPhone.Text.Trim(),
                    age = int.TryParse(txtAge.Text, out int a) ? (int?)a : null,
                    role_id = cmbRole.SelectedValue != null ? (long?)Convert.ToInt64(cmbRole.SelectedValue) : null,
                    created_at = DateTime.Now, updated_at = DateTime.Now
                };
                db.users.Add(u);
                db.SaveChanges();
                LoadData(); ClearFields();
                MessageBox.Show("User added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) { MessageBox.Show("Select a user first!"); return; }
            try
            {
                var u = db.users.Find(selectedId);
                if (u != null)
                {
                    u.name = txtName.Text.Trim();
                    u.email = txtEmail.Text.Trim();
                    if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                        u.password = txtPassword.Text.Trim();
                    u.phone_number = txtPhone.Text.Trim();
                    u.age = int.TryParse(txtAge.Text, out int a) ? (int?)a : null;
                    u.role_id = cmbRole.SelectedValue != null ? (long?)Convert.ToInt64(cmbRole.SelectedValue) : null;
                    u.updated_at = DateTime.Now;
                    db.SaveChanges();
                    LoadData(); ClearFields();
                    MessageBox.Show("User updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) { MessageBox.Show("Select a user first!"); return; }
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var u = db.users.Find(selectedId);
                    if (u != null) { u.deleted_at = DateTime.Now; db.SaveChanges(); LoadData(); ClearFields(); MessageBox.Show("User deleted!"); }
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
                var data = db.users.Where(u => u.deleted_at == null &&
                    (u.name.ToLower().Contains(s) || u.email.ToLower().Contains(s)))
                    .Select(u => new { u.id, u.name, u.email, u.phone_number, u.age,
                        Role = u.role != null ? u.role.name : "", u.created_at }).ToList();
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
                txtEmail.Text = row.Cells["email"].Value?.ToString() ?? "";
                txtPhone.Text = row.Cells["phone_number"].Value?.ToString() ?? "";
                txtAge.Text = row.Cells["age"].Value?.ToString() ?? "";
                txtPassword.Clear();
                string roleName = row.Cells["Role"].Value?.ToString() ?? "";
                for (int i = 0; i < cmbRole.Items.Count; i++)
                    if (((role)cmbRole.Items[i]).name == roleName) { cmbRole.SelectedIndex = i; break; }
            }
        }
    }
}
