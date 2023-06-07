using FinalProject.Entities;

namespace FinalProject.Services
{
    public class QuyenHanService
    {
        private readonly AppDBContext db;
        public QuyenHanService()
        {
            db = new AppDBContext();
        }
        public bool ThemQuyenHan(QuyenHan quyenhan) 
        {
            QuyenHan qh = db.QuyenHans.FirstOrDefault(x => x.TenQuyenhan == quyenhan.TenQuyenhan);
            if (qh == null)
            {
                db.QuyenHans.Add(quyenhan);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool SuaQuyenHan(QuyenHan quyenHan)
        {
            QuyenHan qh = db.QuyenHans.FirstOrDefault(x => x.QuyenHanId == quyenHan.QuyenHanId);
            QuyenHan Check_exist = db.QuyenHans.FirstOrDefault(x => x.TenQuyenhan == quyenHan.TenQuyenhan);
            if (Check_exist != null || qh == null) return false;
            if (qh != null)
            {
                qh.TenQuyenhan = quyenHan.TenQuyenhan;
                db.QuyenHans.Update(qh);
                db.SaveChanges();
            }
            return true;
        }

        public bool XoaQuyenHan(int qhId)
        {
            QuyenHan qh = db.QuyenHans.Find(qhId);
            if (qh != null)
            {
                db.QuyenHans.Remove(qh);
                db.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
