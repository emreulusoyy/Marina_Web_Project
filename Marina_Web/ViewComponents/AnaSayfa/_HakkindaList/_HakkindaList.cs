using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Marina_Web.ViewComponents.AnaSayfa._HakkindaList
{
    public class _HakkindaList:ViewComponent
    {
        HakkindaManager hm = new HakkindaManager(new EfHakkımdaDal());
        public IViewComponentResult Invoke()
        {
            var values = hm.TGetList();
            return View(values);
        }
    }
}
