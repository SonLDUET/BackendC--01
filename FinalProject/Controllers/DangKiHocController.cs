using FinalProject.Entities;
using FinalProject.Services;
using FinalProject.Constant;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DangKiHocController : ControllerBase
    {
        private DangKiHocService service;
        public DangKiHocController()
        {
            service = new DangKiHocService();   
        }

        [HttpGet]
        public IActionResult HienThiDangKiHoc(int pageSize, int pageNumber)
        {
            var res = service.HienThiDangKiHoc(pageSize, pageNumber);
            if (res.Count() == 0) return Ok("Không có bản ghi nào thỏa mãn !");
            return Ok(res);
        }

        [HttpPost]
        public IActionResult ThemDangKi(DangKiHoc dangkihoc)
        {
            var res = service.DangKiHoc(dangkihoc);
            if (res == DangKiHocState.HocVienChuaTonTai) return Ok("Học viên chưa tồn tại");
            if (res == DangKiHocState.KhoaHocChuaTonTai) return Ok("Khóa học chưa tồn tại");
            if (res == DangKiHocState.ChuaTonTaiGiCa) return Ok("Khóa học và học viên chưa tồn tại");
            return Ok("Đăng kí thành công khóa học");
        }

        [HttpPut]
        public IActionResult SuaDangKi(DangKiHoc dk)
        {
            var res =  service.SuaDangKiHoc(dk);
            if (res == DangKiHocState.SuaThanhCong) return Ok("Sửa thành công");
            if (res == DangKiHocState.SuaThatBai) return Ok("Sửa thất bại");
            return Ok("");
        }

        [HttpDelete]
        public IActionResult XoaDangKi(int dkId)
        {
            var res = service.XoaDangKiHoc(dkId);
            if (res == DangKiHocState.XoaThanhCong) return Ok("Xóa thành công");
            return Ok("Xóa thất bại");
        }
    }
}
