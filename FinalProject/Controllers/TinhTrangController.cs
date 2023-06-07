using FinalProject.Entities;
using FinalProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TinhTrangController : ControllerBase
    {
        private TinhTrangHocService service;
        public TinhTrangController()
        {
            service = new TinhTrangHocService();
        }
        [HttpPut] 
        public IActionResult SuaTinhTrangHoc(TinhTrangHoc tinhtranghocMoi)
        {
            var res = service.SuaTinhTrangHoc(tinhtranghocMoi);
            if (res)
                return Ok("Sua thanh cong tinh trang hoc !");
            return Ok("Tình trạng học chưa tồn tại !");
        }
        [HttpHead]
        public IActionResult Tao4TinhTrangHoc()
        {
            service.TaoTinhTrangHoc();
            return Ok("tạo tình trạng học thành công");
        }
    }
}
