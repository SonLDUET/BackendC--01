namespace FinalProject.Entities
{
    public class TaiKhoan
    {
        public int TaiKhoanId { get; set;}
        public string? TenNguoiDung { get; set;}
        public string? TenTaiKhoan { get; set; }
        public string? MatKhau { get; set; }
        public int? QuyenHanId { get; set; }
        public QuyenHan? quyenhan { get; set; }


    }
}
