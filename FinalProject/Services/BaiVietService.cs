using FinalProject.Constant;
using FinalProject.Entities;

namespace FinalProject.Services
{
    public class BaiVietService
    {
        private readonly AppDBContext db;
        public BaiVietService()
        {
            db = new AppDBContext();    
        }
        public BaiVietState ThemBaiViet(BaiViet baivietmoi)
        {
            using(var trans = db.Database.BeginTransaction())
            {
                try
                {
                    baivietmoi.NgayTao = DateTime.Now;
                    db.Add(baivietmoi);
                    db.SaveChanges();
                    trans.Commit();
                    return BaiVietState.ThemBaiVietThanhCong;
                }
                catch (Exception ex)
                {
                    trans.Rollback();   
                }
                return BaiVietState.ThemBaiVietThatBai;
            }
        }

        public BaiVietState SuaBaiViet(BaiViet baivietmoi)
        {
            BaiViet baivietcansua = db.BaiViets.Find(baivietmoi.BaiVietId);
            if (baivietcansua != null) {
                baivietcansua.TenBaiViet = baivietmoi.TenBaiViet;
                baivietcansua.TenTacGia = baivietmoi.TenTacGia;
                baivietcansua.NgayTao = baivietmoi.NgayTao;
                if(db.ChuDes.Any(x => x.ChuDeId == baivietmoi.ChuDeId))
                {
                    baivietcansua.ChuDeId = baivietmoi.ChuDeId;
                } else
                {
                    return BaiVietState.ChuDeIdChuaTonTai;
                }
                if (db.TaiKhoans.Any(x => x.TaiKhoanId == baivietmoi.TaiKhoanId))
                {
                    baivietcansua.TaiKhoanId = baivietmoi.TaiKhoanId;
                } else
                {
                    return BaiVietState.TaiKhoanChuaTonTai;
                }
                db.Update(baivietcansua);
                db.SaveChanges();
            }
            return BaiVietState.SuaBaiVietThanhCong;
        }

        public BaiVietState XoaBaiViet(int bvId)
        {
            BaiViet baivietcanxoa = db.BaiViets.Find(bvId);
            if (baivietcanxoa != null)
            {
                db.Remove(baivietcanxoa);
                db.SaveChanges();
                return BaiVietState.XoaBaiVietThanhCong;
            }
            return BaiVietState.BaiVietIDChuaTonTai;
        }

        public List<BaiViet> TimKiemBaiVietTheoTen(string keyword, int pageSize, int pageNumber)
        {
            var query = db.BaiViets.Where(x => x.TenBaiViet.Contains(keyword)).AsQueryable();
            List<BaiViet> listBV = query.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            return listBV;
        }

    }
}
