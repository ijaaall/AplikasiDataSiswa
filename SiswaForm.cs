using AplikasiDataSiswa.Data;
using AplikasiDataSiswa.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiDataSiswa
{
    public partial class SiswaForm : Form
    {
        private string imagePath;
        private int IdSiswa = 0;
        public SiswaForm()
        {
            InitializeComponent();
        }

        private async Task loadSiswa()
        {
            using (var context = new AppDbContext())
            {
                dgvSiswa.DataSource = await context.Siswa.Select(s => new
                {
                    IdSiswa = s.SiswaId,
                    NISN = s.NISN,
                    NIS = s.NIS,
                    NamaSiswa = s.NamaSiswa,
                    TempatLahir = s.TempatLahir,
                    TanggalLahir = s.TanggalLahir,
                    Agama = s.Agama,
                    Alamat = s.Alamat,
                    Jurusan = s.Jurusan,
                    Kelas = s.Kelas,
                    Picture = s.SiswaPicture,
                }).ToListAsync();
            }
        }

        private void btnPilihGambar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JPG (*.jpg)|*.jpg|All Files (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagePath = ofd.FileName;
                    pbFoto.ImageLocation = ofd.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearForm()
        {
            txtNisn.Clear();
            txtNis.Clear();
            txtNamaSiswa.Clear();
            txtTempatLahir.Clear();

            dtpTanggalLahir.Value = DateTime.Now; // Mereset tanggal ke hari ini

            cbAgama.SelectedIndex = -1;  // Mengosongkan pilihan ComboBox
            cbJurusan.SelectedIndex = -1;
            cbKelas.SelectedIndex = -1;

            rtbAlamat.Clear();

            // 1. Reset Radio Button Jenis Kelamin (dari percakapan sebelumnya)
            rbLaki.Checked = false;
            rbPerempuan.Checked = false;

            // 2. Reset PictureBox Foto (dari percakapan sebelumnya)
            pbFoto.Image = null;

            // 3. Reset variabel bantu penyimpanan path gambar jika ada
            imagePath = string.Empty;

            // (Opsional) Mengembalikan fokus kursor ke inputan pertama
            txtNisn.Focus();
        }


        private async void btnSimpan_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                try
                {
                    var siswa = new Siswa
                    {
                        NISN = Convert.ToInt32(txtNisn.Text),
                        NIS = Convert.ToInt32(txtNis.Text),
                        NamaSiswa = txtNamaSiswa.Text,
                        TempatLahir = txtTempatLahir.Text,
                        TanggalLahir = dtpTanggalLahir.Value,
                        Agama = cbAgama.Text,
                        Alamat = rtbAlamat.Text,
                        Jurusan = cbJurusan.Text,
                        Kelas = cbKelas.Text,
                        SiswaPicture = imagePath,
                    };
                    context.Siswa.Add(siswa);
                    await context.SaveChangesAsync();
                    MessageBox.Show("berhasil di simpan");
                    await loadSiswa();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void dgvSiswa_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvSiswa.CurrentRow == null)
            {
                MessageBox.Show("pilih data terlebih dahulu");
                return;
            }

            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvSiswa.Rows[e.RowIndex];

                    IdSiswa = Convert.ToInt32(row.Cells["IdSiswa"].Value.ToString());
                    txtNisn.Text = row.Cells["NISN"].Value.ToString();
                    txtNis.Text = row.Cells["NIS"].Value.ToString();
                    txtNamaSiswa.Text = row.Cells["NamaSiswa"].Value.ToString();
                    txtTempatLahir.Text = row.Cells["TempatLahir"].Value.ToString();
                    dtpTanggalLahir.Value = (DateTime)row.Cells["TanggalLahir"].Value;
                    string jk = row.Cells["JenisKelamin"].Value.ToString();

                    if (jk == "Laki-Laki" || jk == "L")
                    {
                        rbLaki.Checked = true;
                    }
                    else if (jk == "Perempuan" || jk == "P")
                    {
                        rbPerempuan.Checked = true;
                    }

                    cbAgama.Text = row.Cells["Agama"].Value.ToString();
                    rtbAlamat.Text = row.Cells["Alamat"].Value.ToString();
                    cbJurusan.Text = row.Cells["Jurusan"].Value.ToString();
                    cbKelas.Text = row.Cells["Kelas"].Value.ToString();
                    imagePath = row.Cells["SiswaPicture"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void SiswaForm_Load(object sender, EventArgs e)
        {
            await loadSiswa();
        }

    }
}
