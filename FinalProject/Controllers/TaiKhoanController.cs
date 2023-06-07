using FinalProject.Entities;
using FinalProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaiKhoanController : ControllerBase
    {
        private TaiKhoanService service;
        public TaiKhoanController()
        {
            service = new TaiKhoanService();    
        }
        [HttpPost]
        public IActionResult ThemTaiKhoan(TaiKhoan tk)
        {
            var res = service.ThemTaiKhoan(tk);
            if (res == Constant.TaiKhoanState.TenTaiKhoanDaTonTai)
            {
                return Ok("Tên tài khoản đã tồn tại");
            }
            if (res == Constant.TaiKhoanState.MatKhauKhongHopLe) 
                return Ok("Mất khẩu khồng hợp lệ");
            return Ok("Thêm tài khoản thành công");
        }
        [HttpPut]
        public IActionResult SuaTaiKhoan(TaiKhoan tk)
        {
            var res = service.SuaTaiKhoan(tk);
            if (res == Constant.TaiKhoanState.TaiKhoanChuaTonTai) return Ok("Tài khoản này chưa tồn tại trong cơ sở dữ liệu để sửa !");
            if (res == Constant.TaiKhoanState.MatKhauKhongHopLe)
                return Ok("Mât khẩu không hợp lệ, vui lòng kiểm tra lại !");
            return Ok("Sửa thông tin tài khoản thành công !");
        }
        [HttpDelete]
        public IActionResult XoaTaiKhoan(int tkId)
        {
            var res = service.XoaTaiKhoan(tkId);
            if (res == Constant.TaiKhoanState.TaiKhoanChuaTonTai)
                return Ok("Tài khoản với ID như vậy chưa tồn tại !");
            return Ok("Xóa tài khoản thành công !");
        }
        [HttpGet]
        public IActionResult TimKiemtaiKhoan(string keyword, int pageSize, int pageNumber)
        {
            var res = service.TimKiemTaiKhoan(keyword, pageSize, pageNumber); 
            return Ok(res);
        }
    }
}
