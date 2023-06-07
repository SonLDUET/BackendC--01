using Microsoft.EntityFrameworkCore;

namespace FinalProject.Entities
{
    public class AppDBContext : DbContext
    {
        public virtual DbSet<BaiViet> BaiViets { get; set; }
        public virtual DbSet<ChuDe> ChuDes { get; set; }
        public virtual DbSet<DangKiHoc> DangKiHocs { get; set; }
        public virtual DbSet<HocVien> HocViens { get; set; }
        public virtual DbSet<KhoaHoc> KhoaHocs { get; set; }
        public virtual DbSet<LoaiBaiViet> LoaiBaiViets { get; set; }
        public virtual DbSet<LoaiKhoaHoc> LoaiKhoaHocs { get; set; }
        public virtual DbSet<QuyenHan> QuyenHans { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TinhTrangHoc> TinhTrangHocs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server=ADMIN-PC; Database=FinalTest; Trusted_connection = True; TrustServerCertificate=True;"); 
        }
    }
}
