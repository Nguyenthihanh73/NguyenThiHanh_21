using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NguyenThiHanh_21.Models
{
    public partial class LTQLDb : DbContext
    {
        public LTQLDb()
            : base("name=LTQLDb")
        {
        }

        public virtual DbSet<LopHoc> LopHocs  { get; set; }
        public virtual DbSet<sinhVIen> SinhVIens { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LopHoc>()
                   .Property(e => e.MaLop)
                   .IsUnicode(false);
            modelBuilder.Entity<LopHoc>()
                   .Property(e => e.TenLop)
                   .IsUnicode(false);

            modelBuilder.Entity<sinhVIen>()
                   .Property(e => e.HoTen)
                   .IsUnicode(false);
            modelBuilder.Entity<sinhVIen>()
                .Property(e => e.Masinhvien)
                .IsUnicode(false);


        }
    }
}
