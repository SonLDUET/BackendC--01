using FinalProject.Entities;
using FinalProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HocVienController : ControllerBase
    {
        private HocVienService service;
        public HocVienController()
        {
            service = new HocVienService();
        }
        [HttpDelete]
        public IActionResult XoaHocVien(int hvId)
        {
           var res = service.XoaHocVien(hvId);
            if(res == Constant.HocVienState.ThaoTacThanhCong)
            {
                return Ok("Xóa thành công");
            } 
            return Ok("Xóa thất bại");
        }

        [HttpPut]
        public IActionResult SuaHocVien(HocVien hv)
        {
            var res = service.SuaHocVien(hv);
            if(res == Constant.HocVienState.ThaoTacThanhCong)
            {
                return Ok("Sửa thành công thông tin học viên");
            }
            return Ok("Hoc viên chưa tồn tại");
        }
        [HttpPost]
        public IActionResult ThemHocVien(HocVien hv)
        {
            var res = service.ThemHocVien(hv);
            if (res == Constant.HocVienState.SoDienThoaiDaTonTai) return Ok("Số điện thoại đã tồn tại");
            if (res == Constant.HocVienState.EmailDaTonTai) return Ok("Email đã tồn tại");
            if (res == Constant.HocVienState.SDTvaEmailDaTonTai) return Ok("Cả số điện thoại và Email đã tồn tại");
            return Ok("Thêm hoc viên mới thành công");
        }
        [HttpGet]
        public IActionResult TimKiemHocVien(string keyword, int pageSize, int pageNumber)
        {
            var res = service.TimKiemHocVien(keyword, pageSize, pageNumber);
            if (res.Count() == 0) return Ok("Khồng có hoc viên nào thỏa mãn");
            return Ok(res);
        }
    }
}
