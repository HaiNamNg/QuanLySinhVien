using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLySinhVien.Areas.SinhViens.Controllers
{
    [Authorize(Roles = "SV")]
    public class HomeSvController : Controller
    {
        // GET: SinhViens/HomeSv
        
        public ActionResult Index()
        {
            return View();
        }
    }
}