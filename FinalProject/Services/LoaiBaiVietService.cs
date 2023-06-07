using FinalProject.Entities;

namespace FinalProject.Services
{
    public class LoaiBaiVietService
    {
        private AppDBContext db;
        public LoaiBaiVietService()
        {
            db = new AppDBContext();
        }

        public bool ThemLoaiBaiViet(LoaiBaiViet loaiMoi)
        {
            LoaiBaiViet check_existed = db.LoaiBaiViets.FirstOrDefault(x => x.TenLoai == loaiMoi.TenLoai || x.LoaiBaiVietId == loaiMoi.LoaiBaiVietId);
            if (check_existed != null)
            {
                return false;
            }
            db.Add(loaiMoi);
            db.SaveChanges();
            return true;
        }

        public bool SuaLoaiBaiViet(LoaiBaiViet loaiMoi)
        {
            bool check = db.LoaiBaiViets.Any(x => x.TenLoai == loaiMoi.TenLoai);
            if (check) return false;
            LoaiBaiViet loaiBaiViet = db.LoaiBaiViets.Find(loaiMoi.LoaiBaiVietId);
            if (loaiBaiViet == null) return false;
            loaiBaiViet.TenLoai = loaiMoi.TenLoai;
            db.LoaiBaiViets.Update(loaiBaiViet);
            db.SaveChanges();
            return true;
        }

        public bool XoaLoaiBaiViet(int id)
        {
            LoaiBaiViet loaicanxoa = db.LoaiBaiViets.Find(id);
            if (loaicanxoa != null)
            {
                db.LoaiBaiViets.Remove(loaicanxoa);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
