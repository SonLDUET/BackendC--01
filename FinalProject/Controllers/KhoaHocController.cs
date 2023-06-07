using FinalProject.Entities;
using FinalProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhoaHocController : ControllerBase
    {
        private KhoaHocService service;
        public KhoaHocController()
        {
            service = new KhoaHocService(); 
        }

        [HttpPost]
        public IActionResult ThemKhoaHoc(KhoaHoc kh)
        {
            var res = service.ThemKhoaHoc(kh);
            return Ok(res);
        }
        [HttpPut]
        public IActionResult SuaKhoaHoc(KhoaHoc kh)
        {
            var res = service.SuaKhoaHoc(kh);
            return Ok(res);
        }

        [HttpGet]
        public IActionResult TimKiemKhoaHoc(string keyword, int pageSize, int pageNumber)
        {
            var res =  service.TimKiemKhoaHocTheoTen(keyword, pageSize, pageNumber);
            return Ok(res);
        }
        [HttpDelete]
        public IActionResult XoaKhoaHoc(int khId)
        {
            var res = service.XoaKhoaHoc(khId);
            return Ok(res);
        }
    }
}
