using FinalProject.Entities;
using FinalProject.Services;
using FinalProject.Constant;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaiVietController : ControllerBase
    {
        private BaiVietService service;
        public BaiVietController()
        {
            service = new BaiVietService(); 
        }

        [HttpPost]
        public IActionResult ThemBaiViet(BaiViet baivietmoi)
        {
            var res = service.ThemBaiViet(baivietmoi);
            if (res == BaiVietState.ThemBaiVietThanhCong) return Ok("Thêm bài viết thành công !");
            return BadRequest("Thêm bài viết không thành công, vui lòng kiểm tra lại tài khoản ID và loại bài viết ID coi đã tồn tại chưa !");
        }

        [HttpPut]
        public IActionResult SuaBaiViet(BaiViet baivietmoi)
        {
            var res = service.SuaBaiViet(baivietmoi);
            if (res == BaiVietState.SuaBaiVietThanhCong) return Ok("Sửa bài viết thành công");
            if (res == BaiVietState.ChuDeIdChuaTonTai) return BadRequest("Chủ đề ID chưa tồn tại");
            if (res == BaiVietState.TaiKhoanChuaTonTai) return BadRequest("Tài khoản chưa tôn tại");
            return Ok("...");
        }

        [HttpDelete]
        public IActionResult XoaBaiViet(int baivietId)
        {
            var res = service.XoaBaiViet(baivietId);
            if (res == BaiVietState.XoaBaiVietThanhCong) return Ok($"Xóa thành công bài viết với ID là {baivietId}");
            return BadRequest("Bài viết với ID này chưa tồn tại trong cơ sở dữ liệu, vui lòng kiểm tra lại !");
        }

        [HttpGet]
        public IActionResult TimKiemBaiVietTheoTen(string keyword, int pageSize, int pageNum)
        {
            var res = service.TimKiemBaiVietTheoTen(keyword, pageSize, pageNum);
            if (res.Count() == 0) return Ok("Không có bài viết nào thỏa mãn !");
            return Ok(res);
        }
    }
}
