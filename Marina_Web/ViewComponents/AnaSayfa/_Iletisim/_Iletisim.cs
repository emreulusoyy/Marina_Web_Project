using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Marina_Web.ViewComponents.AnaSayfa._Iletisim
{
    public class _Iletisim:ViewComponent
    {
        IletisimManager im = new IletisimManager(new EfIletisimDal());
        public IViewComponentResult Invoke()
        {
            var values = im.TGetList();
            return View(values);
        }
    }
}
