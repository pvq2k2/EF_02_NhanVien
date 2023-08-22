using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02_NhanVien.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<DuAn> DuAn { get; set; }
        public DbSet<PhanCong> PhanCong { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-O1GKQUN; Database = EF_02_NhanVien; Trusted_Connection = True; TrustServerCertificate = True");
        }
    }
}
