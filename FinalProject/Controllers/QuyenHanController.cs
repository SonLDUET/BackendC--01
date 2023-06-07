using FinalProject.Entities;
using FinalProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuyenHanController : ControllerBase
    {
        private QuyenHanService service;
        public QuyenHanController()
        {
            service = new QuyenHanService();
        }
        [HttpPost]
        public IActionResult ThemQuyenHan(QuyenHan qh)
        {
            var res = service.ThemQuyenHan(qh);
            if (res) return Ok("Thêm quyền hạn thành công !");
            return Ok("Thêm thất bại");
        }
        [HttpPut] 
        public IActionResult SuaQuyenHan(QuyenHan qh)
        {
            var res = service.SuaQuyenHan(qh);
            if (res) return Ok("Sửa thành công quyền hạn");
            return BadRequest("Quyền hạn Id này chưa tồn tại để sửa");
        }
        [HttpDelete] 
        public IActionResult XoaQuyenHan(int qhId)
        {
            var res = service.XoaQuyenHan(qhId);
            if (res) return Ok("Xóa thành công quyền hạn !");
            return BadRequest("Quyền hạn ID chưa tồn tại tròn cơ sở dữ liệu !");
        }
    }
}
