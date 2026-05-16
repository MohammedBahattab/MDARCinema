using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MDARCinema.UserControls
{
    public partial class UC_Movies : UserControl
    {
        private CinemaBookingDBEntities1 db =
            new CinemaBookingDBEntities1();

        private long selectedId = 0;

        private string posterPath = "";

        public UC_Movies()
        {
            InitializeComponent();

            LoadData();
            LoadStudios();
            LoadCategories();
        }

        private void LoadData()
        {
            try
            {
                var data = db.movies
                    .Where(m => m.deleted_at == null)
                    .Select(m => new
                    {
                        m.id,
                        m.title,
                        m.description,
                        m.duration_minutes,
                        m.release_date,
                        m.language,
                        m.rating,
                        m.poster_image,
                        Studio = m.studio != null
                            ? m.studio.name
                            : ""
                    })
                    .ToList();

                dgvData.DataSource = data;

                lblRecordCount.Text =
                    "Total: " + data.Count + " records";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message
                );
            }
        }

        private void LoadStudios()
        {
            try
            {
                var studios = db.studios.ToList();

                cmbStudio.DataSource = studios;
                cmbStudio.DisplayMember = "name";
                cmbStudio.ValueMember = "id";
                cmbStudio.SelectedIndex = -1;
            }
            catch
            {

            }
        }

        private void LoadCategories()
        {
            try
            {
                clbCategories.Items.Clear();

                var categories =
                    db.categories.ToList();

                foreach (var cat in categories)
                {
                    clbCategories.Items.Add(
                        cat,
                        false
                    );
                }

                clbCategories.DisplayMember =
                    "name";

                clbCategories.ValueMember =
                    "id";
            }
            catch
            {

            }
        }

        private void ClearFields()
        {
            txtTitle.Clear();
            txtDescription.Clear();
            txtDuration.Clear();
            txtLanguage.Clear();
            txtRating.Clear();

            dtpReleaseDate.Value =
                DateTime.Now;

            cmbStudio.SelectedIndex = -1;

            picPoster.Image = null;

            for (
                int i = 0;
                i < clbCategories.Items.Count;
                i++
            )
            {
                clbCategories.SetItemChecked(
                    i,
                    false
                );
            }

            selectedId = 0;
            posterPath = "";
        }

        private void btnBrowseImage_Click(
            object sender,
            EventArgs e
        )
        {
            OpenFileDialog ofd =
                new OpenFileDialog();

            ofd.Filter =
                "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (
                ofd.ShowDialog() ==
                DialogResult.OK
            )
            {
                try
                {
                    string moviesFolder =
                        @"D:\my\مشاريع داؤد احمد\MDAR_CINEMA\storage\app\public\movies";

                    if (
                        !Directory.Exists(
                            moviesFolder
                        )
                    )
                    {
                        Directory.CreateDirectory(
                            moviesFolder
                        );
                    }

                    string fileName =
                        Guid.NewGuid().ToString() +
                        Path.GetExtension(
                            ofd.FileName
                        );

                    string destinationPath =
                        Path.Combine(
                            moviesFolder,
                            fileName
                        );

                    File.Copy(
                        ofd.FileName,
                        destinationPath,
                        true
                    );

                    posterPath =
                        "movies/" + fileName;

                    using (
                        var img =
                            Image.FromFile(
                                destinationPath
                            )
                    )
                    {
                        picPoster.Image =
                            new Bitmap(img);
                    }

                    picPoster.SizeMode =
                        PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error uploading image: " +
                        ex.Message
                    );
                }
            }
        }

        private void btnAdd_Click(
            object sender,
            EventArgs e
        )
        {
            if (
                string.IsNullOrWhiteSpace(
                    txtTitle.Text
                )
            )
            {
                MessageBox.Show(
                    "Please enter movie title!",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                var movie = new movy
                {
                    title =
                        txtTitle.Text.Trim(),

                    description =
                        txtDescription.Text.Trim(),

                    duration_minutes =
                        int.TryParse(
                            txtDuration.Text,
                            out int dur
                        )
                        ? dur
                        : 0,

                    release_date =
                        dtpReleaseDate.Value,

                    language =
                        txtLanguage.Text.Trim(),

                    rating =
                        txtRating.Text.Trim(),

                    studio_id =
                        cmbStudio.SelectedValue !=
                        null
                        ? (long?)Convert.ToInt64(
                            cmbStudio.SelectedValue
                        )
                        : null,

                    poster_image =
                        posterPath,

                    created_at =
                        DateTime.Now,

                    updated_at =
                        DateTime.Now
                };

                db.movies.Add(movie);

                db.SaveChanges();

                // حفظ التصنيفات
                foreach (
                    var item in
                    clbCategories.CheckedItems
                )
                {
                    category cat =
                        (category)item;

                    movie_category mc =
                        new movie_category
                        {
                            movie_id =
                                movie.id,

                            category_id =
                                cat.id
                        };

                    db.movie_category.Add(mc);
                }

                db.SaveChanges();

                LoadData();
                ClearFields();

                MessageBox.Show(
                    "Movie added successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message
                );
            }
        }

        private void btnEdit_Click(
            object sender,
            EventArgs e
        )
        {
            if (selectedId == 0)
            {
                MessageBox.Show(
                    "Please select a movie to edit!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                var movie =
                    db.movies.Find(
                        selectedId
                    );

                if (movie != null)
                {
                    movie.title =
                        txtTitle.Text.Trim();

                    movie.description =
                        txtDescription.Text.Trim();

                    movie.duration_minutes =
                        int.TryParse(
                            txtDuration.Text,
                            out int dur
                        )
                        ? dur
                        : 0;

                    movie.release_date =
                        dtpReleaseDate.Value;

                    movie.language =
                        txtLanguage.Text.Trim();

                    movie.rating =
                        txtRating.Text.Trim();

                    movie.studio_id =
                        cmbStudio.SelectedValue !=
                        null
                        ? (long?)Convert.ToInt64(
                            cmbStudio.SelectedValue
                        )
                        : null;

                    movie.poster_image =
                        posterPath;

                    movie.updated_at =
                        DateTime.Now;

                    // حذف التصنيفات القديمة
                    var oldCategories =
                        db.movie_category
                        .Where(x =>
                            x.movie_id == movie.id
                        )
                        .ToList();

                    foreach (var item in oldCategories)
                    {
                        db.movie_category.Remove(item);
                    }

                    db.SaveChanges();

                    // إضافة التصنيفات الجديدة
                    foreach (
                        var item in
                        clbCategories.CheckedItems
                    )
                    {
                        category cat =
                            (category)item;

                        movie_category mc =
                            new movie_category
                            {
                                movie_id =
                                    movie.id,

                                category_id =
                                    cat.id
                            };

                        db.movie_category.Add(
                            mc
                        );
                    }

                    db.SaveChanges();

                    LoadData();
                    ClearFields();

                    MessageBox.Show(
                        "Movie updated successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message
                );
            }
        }

        private void btnDelete_Click(
            object sender,
            EventArgs e
        )
        {
            if (selectedId == 0)
            {
                MessageBox.Show(
                    "Please select a movie to delete!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (
                MessageBox.Show(
                    "Are you sure you want to delete this movie?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                ) == DialogResult.Yes
            )
            {
                try
                {
                    var movie =
                        db.movies.Find(
                            selectedId
                        );

                    if (movie != null)
                    {
                        movie.deleted_at =
                            DateTime.Now;

                        db.SaveChanges();

                        LoadData();
                        ClearFields();

                        MessageBox.Show(
                            "Movie deleted successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error: " + ex.Message
                    );
                }
            }
        }

        private void btnClear_Click(
            object sender,
            EventArgs e
        )
        {
            ClearFields();
        }

        private void txtSearch_TextChanged(
            object sender,
            EventArgs e
        )
        {
            try
            {
                string search =
                    txtSearch.Text
                    .Trim()
                    .ToLower();

                var data = db.movies
                    .Where(m =>
                        m.deleted_at == null &&
                        (
                            m.title
                                .ToLower()
                                .Contains(
                                    search
                                )
                            ||
                            m.language
                                .ToLower()
                                .Contains(
                                    search
                                )
                        )
                    )
                    .Select(m => new
                    {
                        m.id,
                        m.title,
                        m.description,
                        m.duration_minutes,
                        m.release_date,
                        m.language,
                        m.rating,
                        m.poster_image,
                        Studio =
                            m.studio != null
                            ? m.studio.name
                            : ""
                    })
                    .ToList();

                dgvData.DataSource =
                    data;

                lblRecordCount.Text =
                    "Total: " +
                    data.Count +
                    " records";
            }
            catch
            {

            }
        }

        private void dgvData_CellClick(
            object sender,
            DataGridViewCellEventArgs e
        )
        {
            if (e.RowIndex >= 0)
            {
                var row =
                    dgvData.Rows[e.RowIndex];

                selectedId =
                    Convert.ToInt64(
                        row.Cells["id"]
                        .Value
                    );

                txtTitle.Text =
                    row.Cells["title"]
                    .Value
                    ?.ToString() ?? "";

                txtDescription.Text =
                    row.Cells["description"]
                    .Value
                    ?.ToString() ?? "";

                txtDuration.Text =
                    row.Cells["duration_minutes"]
                    .Value
                    ?.ToString() ?? "";

                txtLanguage.Text =
                    row.Cells["language"]
                    .Value
                    ?.ToString() ?? "";

                txtRating.Text =
                    row.Cells["rating"]
                    .Value
                    ?.ToString() ?? "";

                if (
                    row.Cells[
                        "release_date"
                    ].Value != null &&
                    row.Cells[
                        "release_date"
                    ].Value != DBNull.Value
                )
                {
                    dtpReleaseDate.Value =
                        Convert.ToDateTime(
                            row.Cells[
                                "release_date"
                            ].Value
                        );
                }

                // البوستر
                posterPath =
                    row.Cells[
                        "poster_image"
                    ].Value != null
                    ? row.Cells[
                        "poster_image"
                    ].Value.ToString()
                    : "";

                if (
                    !string.IsNullOrEmpty(
                        posterPath
                    )
                )
                {
                    try
                    {
                        string fileName =
                            Path.GetFileName(
                                posterPath
                            );

                        string fullPath =
                            Path.Combine(
                                @"D:\my\مشاريع داؤد احمد\MDAR_CINEMA\storage\app\public\movies",
                                fileName
                            );

                        if (
                            File.Exists(
                                fullPath
                            )
                        )
                        {
                            using (
                                var img =
                                    Image.FromFile(
                                        fullPath
                                    )
                            )
                            {
                                picPoster.Image =
                                    new Bitmap(
                                        img
                                    );
                            }

                            picPoster.SizeMode =
                                PictureBoxSizeMode.StretchImage;
                        }
                        else
                        {
                            picPoster.Image =
                                null;
                        }
                    }
                    catch
                    {
                        picPoster.Image =
                            null;
                    }
                }
                else
                {
                    picPoster.Image = null;
                }

                // الاستوديو
                string studioName =
                    row.Cells["Studio"]
                    .Value
                    ?.ToString() ?? "";

                for (
                    int i = 0;
                    i <
                    cmbStudio.Items.Count;
                    i++
                )
                {
                    if (
                        (
                            (
                                studio
                            )
                            cmbStudio.Items[i]
                        ).name ==
                        studioName
                    )
                    {
                        cmbStudio.SelectedIndex =
                            i;

                        break;
                    }
                }

                // التصنيفات
                for (
                    int i = 0;
                    i <
                    clbCategories.Items.Count;
                    i++
                )
                {
                    clbCategories
                        .SetItemChecked(
                            i,
                            false
                        );
                }

                var selectedCategories =
                    db.movie_category
                    .Where(x =>
                        x.movie_id ==
                        selectedId
                    )
                    .Select(x =>
                        x.category_id
                    )
                    .ToList();

                for (
                    int i = 0;
                    i <
                    clbCategories.Items.Count;
                    i++
                )
                {
                    category cat =
                        (category)
                        clbCategories.Items[i];

                    if (
                        selectedCategories
                        .Contains(cat.id)
                    )
                    {
                        clbCategories
                            .SetItemChecked(
                                i,
                                true
                            );
                    }
                }
            }
        }
    }
}