using FinalProject.Services;
using FinalProject.Constant;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Entities;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChuDeController : ControllerBase
    {
        private ChuDeService service;
        public ChuDeController()
        {
            service = new ChuDeService();
        }
        [HttpGet] 

        public IActionResult TimChuDeTheoTen(string keyword, int pageSize, int pageNumber)
        {
            var res = service.TimChuDeTheoTen(keyword, pageSize, pageNumber);
            if (res.Count() == 0)
            {
                return Ok("Không có bản ghi nào thỏa mãn");
            }
            return Ok(res);
        }

        [HttpDelete]
        public IActionResult XoaChuDe(int chudeid)
        {
            var res = service.XoaChuDe(chudeid); 
            if (res == ChuDeState.ChuDeIDChuaTonTai)
            {
                return Ok("Chủ đề Id Chưa tồn tại");
            }
            return Ok("Xóa chủ đề thành công"); 
        }
        
        [HttpPut]
        public IActionResult SuaChuDe(ChuDe chudemoi)
        {
            var res = service.SuaChuDe(chudemoi);
            if (res == ChuDeState.SuaThanhCong) return Ok("Sửa thành công");
            return Ok("Sửa thất bại");
        }

        [HttpPost]
        public IActionResult ThemChuDe(ChuDe chudemoi)
        {
            var res = service.ThemChuDe(chudemoi);
            if (res == ChuDeState.LoaiBaiVietChuaTonTai) return Ok("Loại bài viết chưa tồn tại, vui lòng chọn một loại bài viết hợp lí");
            if (res == ChuDeState.TenChuDeDaTonTai) return BadRequest("Tên chủ đề này đã tồn tại, vui lòng chọn một tên khác hợp lý hơn !");
            return Ok("Thêm chủ đề thành công");
        }

    }
}
