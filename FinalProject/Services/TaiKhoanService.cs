using FinalProject.Constant;
using FinalProject.Entities;

namespace FinalProject.Services
{
    public class TaiKhoanService
    {
        private readonly AppDBContext db;
        public TaiKhoanService()
        {
            db = new AppDBContext();
        }
        public TaiKhoanState ThemTaiKhoan(TaiKhoan newTk)
        {
            TaiKhoan tk = db.TaiKhoans.FirstOrDefault(x => x.TenTaiKhoan == newTk.TenTaiKhoan);
            if (tk != null) return TaiKhoanState.TenTaiKhoanDaTonTai;
            if (check_password(newTk.MatKhau))
            {
                db.Add(newTk);
                db.SaveChanges();
                return TaiKhoanState.ThemThanhCong;
            }
            return TaiKhoanState.MatKhauKhongHopLe;
        }

        public TaiKhoanState SuaTaiKhoan(TaiKhoan updatedTk)
        {
            TaiKhoan taikhoanCanSua = db.TaiKhoans.Find(updatedTk.TaiKhoanId);
            if (taikhoanCanSua == null)
            {
                return TaiKhoanState.TaiKhoanChuaTonTai;
            }
            if (check_password(updatedTk.MatKhau))
            {
                taikhoanCanSua.MatKhau = updatedTk.MatKhau;
            }
            else
            {
                return TaiKhoanState.MatKhauKhongHopLe;
            }
            if (!db.QuyenHans.Any(x => x.QuyenHanId == updatedTk.QuyenHanId)) {
                return TaiKhoanState.QuyenHanChuaTonTai;
            } 
            else
            {
                taikhoanCanSua.QuyenHanId = updatedTk.QuyenHanId;   
            }
            taikhoanCanSua.TenNguoiDung = updatedTk.TenNguoiDung;
            db.TaiKhoans.Update(taikhoanCanSua);
            db.SaveChanges();
            return TaiKhoanState.SuaThanhCong;
        }

        public TaiKhoanState XoaTaiKhoan(int TaiKhoanId)
        {
            TaiKhoan tk = db.TaiKhoans.Find(TaiKhoanId);
            if (tk == null) return TaiKhoanState.TaiKhoanChuaTonTai;
            db.Remove(tk);
            db.SaveChanges();
            return TaiKhoanState.XoaThanhCong;
        }

        public List<TaiKhoan> TimKiemTaiKhoan (string tenNguoiDung, int pageSize, int pageNumber)
        {
            var query = db.TaiKhoans.Where(x => x.TenNguoiDung.Contains(tenNguoiDung)).AsQueryable();
            List<TaiKhoan> listTk = query.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            return listTk;
        }

        private bool check_password(string pass)
        {
            bool check_digit = false, check_special_character = false;
            foreach(char c in pass)
            {
                if (Char.IsDigit(c)) check_digit = true;
                if (!Char.IsDigit(c) && !Char.IsLetter(c)) check_special_character = true;
                if (check_digit && check_special_character)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

