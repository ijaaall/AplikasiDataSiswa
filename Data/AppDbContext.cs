using AplikasiDataSiswa.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiDataSiswa.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=IJAAALL\\SQLEXPRESS;Database=AppDataSiswaDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Siswa> Siswa { get; set; }
        public DbSet<Operator> Operator { get; set; }
        public DbSet<Role> Role { get; set; }
    }
}
