using FinalProject.Entities;

namespace FinalProject.Services
{
    public class LoaiKhoaHocServices
    {
        private readonly AppDBContext db;
        // Constructor
        public LoaiKhoaHocServices()
        {
            db = new AppDBContext();
        }
        // Services
        public LoaiKhoaHoc ThemLoaiKhoahoc(LoaiKhoaHoc lkh)
        {
            if(db.LoaiKhoaHocs.FirstOrDefault(x => x.TenLoaiKhoahoc == lkh.TenLoaiKhoahoc) == null)
            {
                db.LoaiKhoaHocs.Add(lkh);
                db.SaveChanges();
                return lkh;
            }
            return null;
        }
        public LoaiKhoaHoc SuaLoaiKhoaHoc(LoaiKhoaHoc newLKH)
        {
            LoaiKhoaHoc loaikhoahoc = db.LoaiKhoaHocs.FirstOrDefault(x => x.LoaiKhoaHocId == newLKH.LoaiKhoaHocId);
            if (loaikhoahoc != null)
            {
                loaikhoahoc.TenLoaiKhoahoc = newLKH.TenLoaiKhoahoc;
                db.Update(loaikhoahoc);
                db.SaveChanges();
                return newLKH;
            }
            return null;
        }

        public LoaiKhoaHoc XoaLoaiKhoaHoc (int lkhId)
        {
            LoaiKhoaHoc loai = db.LoaiKhoaHocs.Find(lkhId);
            if (loai != null)
            {
                db.LoaiKhoaHocs.Remove(loai);
                db.SaveChanges();
                return loai;
            }
            return null;
        }
        

    }
}
