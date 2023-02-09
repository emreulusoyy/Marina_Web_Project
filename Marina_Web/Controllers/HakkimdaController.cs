using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Marina_Web.Controllers
{
   
    public class HakkimdaController : Controller
    {
        HakkindaManager hm = new HakkindaManager(new EfHakkımdaDal());

       
        public IActionResult Index()
        {
            var values = hm.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult HakkimdaDuzenle(int id)
        {
            var values = hm.TGetByID(id);   
            return View(values);    
        }

        [HttpPost]
        public IActionResult HakkimdaDuzenle(Hakkında p)
        {
            hm.TUpdate(p);
            return RedirectToAction("Index");   
        }
    }
}
