using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Marina_Web.ViewComponents.AnaSayfa._VizyonList
{
    public class _VizyonList:ViewComponent
    {
        IVizyonumuzManager vm = new IVizyonumuzManager(new EfVizyonumuzDal());
        public IViewComponentResult Invoke()
        {
            var values = vm.TGetList(); 
            return View(values);
        }
    }
}
