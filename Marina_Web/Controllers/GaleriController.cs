using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using System;
using Marina_Web.Models;

namespace Marina_Web.Controllers
{
    public class GaleriController : Controller
    {
        GaleriManager gm = new GaleriManager(new EfGaleriDal());
        public IActionResult Index()
        {
            var values = gm.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult FotoDüzenle(int id)
        {

            var values = gm.TGetByID(id);

            GaleriViewModel galeri = new GaleriViewModel()
            {
                GaleriID = values.GaleriID,
                GaleriImage = values.Image,
                Baslik = values.Baslik,
                
            };
            return View(galeri);
        }

        [HttpPost]
        public async Task<IActionResult> FotoDüzenle(GaleriViewModel p)
        {
            var imagename = "";
            if (p.ImageFile != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extention = Path.GetExtension(p.ImageFile.FileName);
                imagename = Guid.NewGuid() + extention;
                var saveLocation = resource + "/wwwroot/SliderImages/" + imagename;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.ImageFile.CopyToAsync(stream);
            }
            if (p.GaleriImage != null)
            {
                imagename = p.GaleriImage;
            }
            Galeri slider = new Galeri()
            {
                GaleriID = p.GaleriID,
                Baslik = p.Baslik,
                Image = imagename

            };

            gm.TUpdate(slider);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult FotoEkle()
        {

            return View();
        }

        [HttpPost]
        public IActionResult FotoEkle(Galeri p)
        {
            gm.TAdd(p);
            return RedirectToAction("Index");

        }

        public IActionResult FotoSil(int id)
        {
            var values = gm.TGetByID(id);
            gm.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
