using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Marina_Web.Controllers
{
    public class HizmetlerController : Controller
    {
        HizmetlerManager hm = new HizmetlerManager(new EfHizmetlerDal());
        public IActionResult Index()
        {
            var values = hm.TGetList(); 
            return View(values);
        }

        [HttpGet]
        public IActionResult HizmetlerDuzenle(int id)
        {
            var values = hm.TGetByID(id);
            return View(values);    
        }

        [HttpPost]
        public IActionResult HizmetlerDuzenle(Hizmetler p)
        {
            hm.TUpdate(p);
            return RedirectToAction("Index");   
            
        }
    }
}
