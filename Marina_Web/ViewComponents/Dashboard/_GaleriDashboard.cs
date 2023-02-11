using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Marina_Web.ViewComponents.Dashboard
{
    public class _GaleriDashboard:ViewComponent
    {
        GaleriManager gm = new GaleriManager(new EfGaleriDal());
        public IViewComponentResult Invoke()
        {
            var values = gm.TGetList(); 
            return View(values);
        }
    }
}
