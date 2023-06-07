using FinalProject.Entities;
using FinalProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiKhoaHocController : ControllerBase
    {
        private LoaiKhoaHocServices service;
        public LoaiKhoaHocController()
        {
            service = new LoaiKhoaHocServices();
        }
        [HttpPost]
        public IActionResult ThemLoaiKhoaHoc(LoaiKhoaHoc loai)
        {
            var res = service.ThemLoaiKhoahoc(loai);
            return Ok(res);
        }
        [HttpPut]
        public IActionResult SuaLoaiKhoaHoc (LoaiKhoaHoc loai)
        {
            var res = service.SuaLoaiKhoaHoc(loai);
            return Ok(res);
        }
        [HttpDelete]
        public IActionResult XoaLoaiKhoaHoc(int id)
        {
            var res = service.XoaLoaiKhoaHoc(id);
            return Ok(res);
        }
    }
}
