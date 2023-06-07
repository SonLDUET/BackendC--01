using FinalProject.Constant;
using FinalProject.Entities;

namespace FinalProject.Services
{
    public class ChuDeService
    {
        private readonly AppDBContext db;

        public ChuDeService()
        {
            db = new AppDBContext();    
        }

        public ChuDeState ThemChuDe(ChuDe ChuDeMoi)
        {
            ChuDe chude = db.ChuDes.FirstOrDefault(x => x.TenChuDe.Contains(ChuDeMoi.TenChuDe));
            if (chude != null) { return ChuDeState.TenChuDeDaTonTai; }
            LoaiBaiViet loai = db.LoaiBaiViets.Find(ChuDeMoi.LoaiBaiVietId);
            if (loai == null)
            {
                return ChuDeState.LoaiBaiVietChuaTonTai;
            }
            db.Add(ChuDeMoi);
            db.SaveChanges();
            return ChuDeState.ThemThanhCong;
        }

        public ChuDeState SuaChuDe(ChuDe chuDeMoi)
        {
            using(var trans = db.Database.BeginTransaction())
            {
                try
                {
                    ChuDe chuDeCanSua = db.ChuDes.Find(chuDeMoi.ChuDeId);
                    if (chuDeCanSua == null) return ChuDeState.ChuDeIDChuaTonTai;
                    chuDeCanSua.TenChuDe = chuDeMoi.TenChuDe;
                    chuDeCanSua.NoiDung = chuDeMoi.NoiDung;
                    chuDeCanSua.LoaiBaiVietId = chuDeMoi.LoaiBaiVietId;
                    db.Update(chuDeCanSua);
                    db.SaveChanges();
                    trans.Commit();
                    return ChuDeState.SuaThanhCong;
                } catch (Exception ex)
                {
                    trans.Rollback();
                }
                return ChuDeState.SuaThatBai;
            }
        }

        public ChuDeState XoaChuDe(int chuDeId)
        {
            ChuDe chudecanxoa = db.ChuDes.Find(chuDeId);
            if (chudecanxoa == null) {
                return ChuDeState.ChuDeIDChuaTonTai;
            }
            db.Remove(chudecanxoa);
            db.SaveChanges();
            return ChuDeState.XoaThanhCong;
        }

        public List<ChuDe> TimChuDeTheoTen(string tencantim, int pageSize, int pageNumber)
        {
            var query = db.ChuDes.AsQueryable();
            query = query.Where(x => x.TenChuDe.Contains(tencantim)).AsQueryable();
            List<ChuDe> listCd = query.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            return listCd;
        }
    }
}
