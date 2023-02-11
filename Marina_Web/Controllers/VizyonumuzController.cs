using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Marina_Web.Controllers
{
    public class VizyonumuzController : Controller
    {
        IVizyonumuzManager mm = new IVizyonumuzManager(new EfVizyonumuzDal());
        public IActionResult Index()
        {
            var values = mm.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult VizyonDuzenle(int id)
        {
            var values = mm.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult VizyonDuzenle(Vizyonumuz p)
        {
            mm.TUpdate(p);
            return RedirectToAction("Index");

        }
    }
}
