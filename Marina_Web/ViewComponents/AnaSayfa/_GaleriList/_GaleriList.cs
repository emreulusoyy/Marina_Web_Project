using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Marina_Web.ViewComponents.AnaSayfa._GaleriList
{
    public class _GaleriList:ViewComponent
    {
        GaleriManager gm = new GaleriManager(new EfGaleriDal());
        public IViewComponentResult Invoke()
        {
            var values = gm.TGetList().OrderByDescending(x => x.GaleriID).Take(3).ToList();
            return View(values);  
        }
    }
}
