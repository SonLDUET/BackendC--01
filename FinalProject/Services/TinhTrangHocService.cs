using FinalProject.Entities;

namespace FinalProject.Services
{
    public class TinhTrangHocService
    {
        private readonly AppDBContext db;
        public TinhTrangHocService()
        {
            db= new AppDBContext();
        }
        public void TaoTinhTrangHoc()
        {
            if (db.TinhTrangHocs.Count(x => true) == 0)
            {
                List<TinhTrangHoc> listTTH = new List<TinhTrangHoc>()
                {
                    new TinhTrangHoc() {TenTinhTrang="Chờ duyệt"},
                    new TinhTrangHoc() {TenTinhTrang="Đang Học Chính"},
                    new TinhTrangHoc() {TenTinhTrang="Học xong"},
                    new TinhTrangHoc() {TenTinhTrang="Chưa hoàn thành"}
                };
                listTTH.ForEach(x => db.Add(x));
                db.SaveChanges();
            }
        }

        public bool SuaTinhTrangHoc(TinhTrangHoc tth)
        {
            /// <returns>return true if the studying status have already existed and can be modified successful, otherwise, return false </returns>
            TinhTrangHoc tthcansua = db.TinhTrangHocs.Find(tth.TinhTrangHocid);
            if(tthcansua != null)
            {
                tthcansua.TenTinhTrang = tth.TenTinhTrang;
                db.Update(tthcansua);
                db.SaveChanges();
                return true;
            } 
            return false;
        }
        
    }
}
