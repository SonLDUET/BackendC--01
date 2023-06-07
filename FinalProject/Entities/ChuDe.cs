namespace FinalProject.Entities
{
    public class ChuDe
    {
        public int ChuDeId { get; set; }
        public string? TenChuDe { get; set; }
        public string? NoiDung { get; set; }
        public int? LoaiBaiVietId { get; set; }
        public LoaiBaiViet? loaiBaiViet { get; set; }
    }
}
