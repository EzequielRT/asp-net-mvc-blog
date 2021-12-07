using AspNetMvcBlog.Application;
using System.Web.Mvc;

namespace AspNetMvcBlog.Areas.Admin.Controllers
{
    public class DashboardController : AdminController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}