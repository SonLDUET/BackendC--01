namespace FinalProject.Entities
{
    public class BaiViet
    {
        public int BaiVietId { get; set; }
        public string? TenBaiViet { get; set; }
        public DateTime? NgayTao { get; set; }
        public string? TenTacGia { get; set; }
        public string? NoiDung { get; set; }
        public string?   NoiDungNgan { get; set; }
        public string? HinhAnh { get; set; }
        public int? ChuDeId { get; set; }
        public ChuDe? chude { get; set; }
        public int? TaiKhoanId { get; set; }
        public TaiKhoan? taikhoan { get; set; }

    }
}
