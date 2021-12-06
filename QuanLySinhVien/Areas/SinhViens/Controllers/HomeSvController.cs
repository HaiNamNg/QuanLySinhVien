using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLySinhVien.Areas.SinhViens.Controllers
{
    [Authorize(Roles = "Sv")]
    public class HomeSVController : Controller
    {
        
        // GET: SinhViens/HomeSV
        public ActionResult Index()
        {
            return View();
        }
    }
}