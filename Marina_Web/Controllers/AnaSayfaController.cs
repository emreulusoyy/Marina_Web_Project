using Microsoft.AspNetCore.Mvc;

namespace Marina_Web.Controllers
{
	public class AnaSayfaController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}


        public IActionResult Hakkimda()
        {
            return View();
        }
    }
}
