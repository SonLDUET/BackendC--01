using FinalProject.Constant;
using FinalProject.Entities;
using System.Reflection.Metadata.Ecma335;

namespace FinalProject.Services
{
    public class DangKiHocService
    {
        private readonly AppDBContext db;

        public DangKiHocService()
        {
            db = new AppDBContext();
        }
        public DangKiHocState DangKiHoc(DangKiHoc chitiet)
        {
            using (var trans = db.Database.BeginTransaction())
            {
                try
                { 
                    HocVien hv = db.HocViens.Find(chitiet.HocVienId);
                    KhoaHoc kh = db.KhoaHocs.Find(chitiet.KhoaHocId);
                    if (hv != null && kh != null)
                    {
                        if (chitiet.NgayBatDau != null)
                        {
                            chitiet.ngayKetThuc = chitiet.NgayBatDau.AddDays(kh.ThoiGianHoc);
                        }
                        db.Add(chitiet);
                        kh.SoHocVien++;
                        db.Update(kh);
                        db.SaveChanges();
                        trans.Commit();
                        return DangKiHocState.DangKiHocThanhCong;
                    }
                    if (hv == null && kh != null)
                    {
                        return DangKiHocState.HocVienChuaTonTai;
                    }
                    if (hv != null && kh == null)
                    {
                        return DangKiHocState.KhoaHocChuaTonTai;
                    }
                    return DangKiHocState.ChuaTonTaiGiCa; 
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                }
            }
            return DangKiHocState.ChuaTonTaiGiCa; // This's for nothing
        }
        public List<DangKiHoc> HienThiDangKiHoc(int pageSize, int pageNumber)
        {
            var query = db.DangKiHocs.AsQueryable();
            List<DangKiHoc> listDki = query.Skip(pageSize*(pageNumber - 1)).Take(pageSize).ToList();
            return listDki;
        }
        public DangKiHocState SuaDangKiHoc(DangKiHoc dangkihocmoi)
        {
            using (var trans = db.Database.BeginTransaction())
            {
                try
                {
                    DangKiHoc dkCanSua = db.DangKiHocs.Find(dangkihocmoi.DangKiHocId);
                    if (dkCanSua == null) { return DangKiHocState.DangKiChuaTonTai; }
                    KhoaHoc khoaHocCu = db.KhoaHocs.Find(dkCanSua.KhoaHocId);
                    KhoaHoc khoahocMoi = db.KhoaHocs.Find(dangkihocmoi.KhoaHocId);

                    dkCanSua.NgayDangKi = dangkihocmoi.NgayDangKi;
                    dkCanSua.NgayBatDau = dangkihocmoi.NgayBatDau;
                    dkCanSua.HocVienId = dangkihocmoi.HocVienId;
                    if (dangkihocmoi.KhoaHocId != dkCanSua.KhoaHocId)
                    {
                        khoaHocCu.SoHocVien--;
                        khoahocMoi.SoHocVien++;
                        db.Update(khoahocMoi);
                        db.Update(khoaHocCu);
                        dkCanSua.KhoaHocId = dangkihocmoi.KhoaHocId;
                        db.SaveChanges();
                    }
                    dkCanSua.TinhTrangHocId = dangkihocmoi.TinhTrangHocId;
                    dkCanSua.TaiKhoanId = dangkihocmoi.TaiKhoanId;
                    if (dkCanSua.NgayBatDau != null)
                    {
                        dkCanSua.ngayKetThuc = dkCanSua.NgayBatDau.AddDays(khoahocMoi.ThoiGianHoc);
                    }
                    db.Update(dkCanSua);
                    db.SaveChanges();
                    trans.Commit();
                    return DangKiHocState.SuaThanhCong;
                } catch (Exception ex)
                {
                    trans.Rollback();
                }
                return DangKiHocState.SuaThatBai;
            }
        }
        public DangKiHocState XoaDangKiHoc(int DangKiHocId)
        {
            using (var trans = db.Database.BeginTransaction())
            {
                try
                {
                    DangKiHoc dkcanxoa = db.DangKiHocs.Find(DangKiHocId);
                    if (dkcanxoa == null) { return DangKiHocState.XoaThatBai; }
                    KhoaHoc KhoaHocBiXoaHocVien = db.KhoaHocs.Find(dkcanxoa.KhoaHocId);
                    KhoaHocBiXoaHocVien.SoHocVien--;
                    db.DangKiHocs.Remove(dkcanxoa);
                    db.SaveChanges();
                    trans.Commit();
                    return DangKiHocState.XoaThanhCong;
                } 
                catch (Exception ex) 
                {
                    trans.Rollback();
                }
                return DangKiHocState.XoaThatBai;
            } 
        }

    }
}
