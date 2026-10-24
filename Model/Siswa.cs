using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiDataSiswa.Model
{
    public enum JenisKelamin
    { 
        LakiLaki = 1,
        Perempuan = 2
    }
    public class Siswa
    {
        [Key]
        public int SiswaId { get; set; }

        [Required]
        [StringLength(10)]
        public int NISN { get; set; }

        [Required]
        [StringLength(4)]
        public int NIS { get; set; }

        [Required]
        [StringLength(255)]
        public string NamaSiswa { get; set; }

        [Required]
        [StringLength(25)]
        public string TempatLahir { get; set; }

        [Required]
        public DateTime TanggalLahir { get; set; }

        [Required]
        public JenisKelamin JenisKelamin { get; set; }

        [Required]
        [StringLength(10)]
        public string Agama { get; set; }

        [Required]
        [StringLength(255)]
        public string Alamat { get; set; }

        [Required]
        public string Jurusan { get; set; }

        [Required]
        public string Kelas { get; set; }

        [Required]
        public string SiswaPicture { get; set; }

    }
}
