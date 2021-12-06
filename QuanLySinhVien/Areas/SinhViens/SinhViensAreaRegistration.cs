using System.Web.Mvc;

namespace QuanLySinhVien.Areas.SinhViens
{
    public class SinhViensAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "SinhViens";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "SinhViens_default",
                "SinhViens/{controller}/{action}/{id}",
                new { area = "SinhViens", controller = "HomeSV", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}