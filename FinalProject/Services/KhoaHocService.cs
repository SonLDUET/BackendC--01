using FinalProject.Entities;
using Microsoft.Identity.Client;

namespace FinalProject.Services
{
    public class KhoaHocService
    {
        private readonly AppDBContext db;
        // Constructor
        public KhoaHocService() { 
            db = new AppDBContext();
        }

        // Services
        public KhoaHoc ThemKhoaHoc(KhoaHoc newKH)
        {
            newKH.SoHocVien = 0;
            db.Add(newKH);
            db.SaveChanges();
            return newKH;
        }

        public KhoaHoc SuaKhoaHoc(KhoaHoc khoahocmoi)
        {
            KhoaHoc khoahocCanSua = db.KhoaHocs.Find(khoahocmoi.KhoaHocId);
            if (khoahocCanSua != null)
            {
                khoahocCanSua.LoaikhoaHocId = khoahocmoi.LoaikhoaHocId;
                khoahocCanSua.HocPhi = khoahocmoi.HocPhi;
                khoahocCanSua.TenKhoaHoc = khoahocmoi.TenKhoaHoc;
                khoahocCanSua.GioiThieu = khoahocmoi.GioiThieu;
                khoahocCanSua.HinhAnh = khoahocmoi.HinhAnh;
                khoahocCanSua.NoiDung = khoahocmoi.NoiDung;
                khoahocCanSua.SoLuongMon = khoahocmoi.SoLuongMon;
                db.Update(khoahocCanSua);
                db.SaveChanges();
                return khoahocmoi;
            }
            return null;
        }
        
        public KhoaHoc XoaKhoaHoc(int khId)
        {
            KhoaHoc khoahoccanxoa = db.KhoaHocs.Find(khId);
            if (khoahoccanxoa != null)
            {
                db.KhoaHocs.Remove(khoahoccanxoa);
                db.SaveChanges();
                return khoahoccanxoa;
            }
            return null;
        }
        public List<KhoaHoc> TimKiemKhoaHocTheoTen(string keyword, int pageSize, int pageNumber)
        {
            var query = db.KhoaHocs.Where(x => x.TenKhoaHoc.Contains(keyword)).AsQueryable();
            var list = query.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            return list;
        }

        // We use this method in case we add a new student into a course
        internal int ThemHocVien(int khId)
        {
            KhoaHoc kh = db.KhoaHocs.Find(khId);
            if (kh != null)
            {
                kh.SoHocVien++;
                db.Update(kh);
                db.SaveChanges();
                return kh.SoHocVien;
            }
            else return -1;
        }
    }

}
