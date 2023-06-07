using FinalProject.Entities;
using FinalProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiBaiVietController : ControllerBase
    {
        private LoaiBaiVietService service;
        public LoaiBaiVietController()
        {
            service = new LoaiBaiVietService();
        }
        [HttpPost]
        public IActionResult ThemLoaiBaiViet(LoaiBaiViet loai)
        {
            var res = service.ThemLoaiBaiViet(loai);
            if (res) return Ok("Thêm loại bài viết thành công !");
            return Ok("Thêm loại bải viết thất bại !");
        }

        [HttpPut] 
        public IActionResult SuaLoaiBaiViet(LoaiBaiViet loai)
        {
            var res = service.SuaLoaiBaiViet(loai);
            if (res) return Ok("Sửa loại bài viết thành công");
            return BadRequest("Sửa loại bài viết không thành công");
        }

        [HttpDelete]
        public IActionResult XoaLoaiBaiViet(int loaiBaiVietId)
        {
            var res = service.XoaLoaiBaiViet(loaiBaiVietId);
            if (res) return Ok("Xóa thành công !");
            return BadRequest("Loại bài viết với Id như vậy chưa tồn tại !");
        }
    }
}
