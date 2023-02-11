using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Marina_Web.Controllers
{
    public class IletisimController : Controller
    {
        IletisimManager ım = new IletisimManager(new EfIletisimDal());
        public IActionResult Index()
        {
            var values = ım.TGetList(); 
            return View(values);
        }

        [HttpGet]
        public IActionResult IletisimDuzenle(int id)
        {
            var values = ım.TGetByID(id);
           return View(values); 
        }

        [HttpPost]
        public IActionResult IletisimDuzenle(Iletisim p)
        {
           ım.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
