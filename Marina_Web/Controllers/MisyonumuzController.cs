using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Marina_Web.Areas.Admin.Controllers
{
    public class MisyonumuzController : Controller
    {
        MisyonumuzManager mm = new MisyonumuzManager(new EfMisyonumuzDal());
        public IActionResult Index()
        {
            var values = mm.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult MisyonDuzenle(int id)
        {
            var values = mm.TGetByID(id);   
            return View(values);
        }

        [HttpPost]
        public IActionResult MisyonDuzenle(Misyonumuz p)
        {
           mm.TUpdate(p);
            return RedirectToAction("Index");
            
        }
    }
}
