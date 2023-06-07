using FinalProject.Constant;
using FinalProject.Entities;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.Identity.Client;

namespace FinalProject.Services
{
    public class HocVienService
    {
        private readonly AppDBContext db;

        public HocVienService()
        {
            db = new AppDBContext();
        }

        private HocVienState CheckSDTvaEmail(string sdt, string Email)
        {
            bool checkSDT = db.HocViens.Any(x => x.SDT == sdt);
            bool checkEmail = db.HocViens.Any(x => x.Email == Email);
            if (!checkSDT && !checkEmail)
            {
                return HocVienState.ThaoTacThanhCong;
            }
            if (checkSDT && !checkEmail)
            {
                return HocVienState.SoDienThoaiDaTonTai;
            }
            if (!checkSDT && checkEmail)
            {
                return HocVienState.EmailDaTonTai;
            }
            return HocVienState.SDTvaEmailDaTonTai;
        }

        public HocVienState ThemHocVien(HocVien hocvienmoi)
        {
            HocVienState state = CheckSDTvaEmail(hocvienmoi.SDT, hocvienmoi.Email);
            if(state == HocVienState.ThaoTacThanhCong)
            {
                db.HocViens.Add(hocvienmoi);
                db.SaveChanges();
                return HocVienState.ThaoTacThanhCong;
            }
            return state;
          
        }
        public HocVienState SuaHocVien(HocVien hv) {
            HocVien hocviencansua = db.HocViens.Find(hv.HocVienId);
            if (hocviencansua != null)
            {
                hocviencansua.Hoten = hv.Hoten;
                hocviencansua.HinhAnh = hv.HinhAnh;
                hocviencansua.NgaySinh = hv.NgaySinh;
                hocviencansua.SDT = hv.SDT;
                hocviencansua.Email = hv.Email;
                hocviencansua.TinhThanh = hv.TinhThanh;
                hocviencansua.QuanHuyen = hv.QuanHuyen;
                hocviencansua.PhuongXa= hv.PhuongXa;
                hocviencansua.SoNha = hv.SoNha;
                db.Update(hocviencansua);
                db.SaveChanges();
                return HocVienState.ThaoTacThanhCong;
            }
            return HocVienState.HocVienChuaTonTai;
        }
        public HocVienState XoaHocVien(int hvId)
        {
            HocVien hocviencanxoa = db.HocViens.Find(hvId);
            if (hocviencanxoa != null)
            {
                db.HocViens.Remove(hocviencanxoa);
                db.SaveChanges();
                return HocVienState.ThaoTacThanhCong;
            }
            return HocVienState.HocVienChuaTonTai;
        }

        public List<HocVien> TimKiemHocVien(string keyword ,int pageSize, int pageNumber)
        {
            var query = db.HocViens.AsQueryable();
            query = query.Where(x => x.Hoten.Contains(keyword)).AsQueryable();
            var list = query.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            return list;
        }

    }
}
