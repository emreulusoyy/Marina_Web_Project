using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Marina_Web.ViewComponents.AnaSayfa._MisyonList
{
    public class _MisyonList:ViewComponent
    {
        MisyonumuzManager mm = new MisyonumuzManager(new EfMisyonumuzDal());
        
        public IViewComponentResult Invoke()
        {
            var values = mm.TGetList();
            return View(values);
        }
    }
}
