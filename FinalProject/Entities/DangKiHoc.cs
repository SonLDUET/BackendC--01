namespace FinalProject.Entities
{
    public class DangKiHoc
    {
        public int DangKiHocId { get; set; }
        public int? KhoaHocId { get; set; }
        public KhoaHoc? KhoaHoc { get; set; }    
        public int? HocVienId { get; set; }
        public HocVien? hocvien { get; set; }
        public DateTime? NgayDangKi { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime? ngayKetThuc { get; set; }
        public int? TinhTrangHocId { get; set; }
        public TinhTrangHoc? tinhtranghoc { get; set; }
        public int? TaiKhoanId { get;set; }
        public TaiKhoan? taikhoan { get; set; }

    }
}
