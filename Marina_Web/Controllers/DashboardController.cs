using Microsoft.AspNetCore.Mvc;

namespace Marina_Web.Areas.Admin.Controllers
{
   
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
