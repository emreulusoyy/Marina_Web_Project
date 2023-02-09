//using BusinessLayer.Concrete;
//using DataAccessLayer.EntityFramework;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Diagnostics;
//using System.IO;
//using System.Threading.Tasks;

//namespace Marina_Web.Areas.Admin.Controllers
//{
//    public class GaleriController : Controller
//    {
//        GaleriManager gm = new GaleriManager(new EfGaleriDal());
//        [Route("")]
//        [Route("Index")]
//        public IActionResult Index()
//        {
//            var values = gm.TGetList();
//            return View(values);
//        }

//        [HttpGet]
//        [Route("BelgelerDüzenle/{id}")]
//        public IActionResult GaleriDuzenle(int id)
//        {
//            var values = bm.TGetByID(id);
//            BelgelerDüzenle belge = new BelgelerDüzenle()
//            {
//                BelgeID = values.BelgeID,
//                BelgeImage = values.BelgeImage,
//                BelgeAcilirImage = values.BelgeAcilirImage,
//                BelgeBaslik = values.BelgeBaslik


//            };

//            return View(belge);

//        }

//        [HttpPost]
//        [Route("BelgelerDüzenle/{id}")]
//        public async Task<IActionResult> BelgelerDüzenle(BelgelerDüzenle p)
//        {
//            var imagename = "";
//            if (p.ImageFile != null)
//            {
//                var resource = Directory.GetCurrentDirectory();
//                var extention = Path.GetExtension(p.ImageFile.FileName);
//                imagename = Guid.NewGuid() + extention;
//                var saveLocation = resource + "/wwwroot/BelgeResimleri/" + imagename;
//                var stream = new FileStream(saveLocation, FileMode.Create);
//                await p.ImageFile.CopyToAsync(stream);
//            }
//            if (p.BelgeImage != null)
//            {
//                imagename = p.BelgeImage;
//            }
//            Belgeler belge = new Belgeler()
//            {
//                BelgeID = p.BelgeID,
//                BelgeImage = imagename,
//                BelgeAcilirImage = p.BelgeAcilirImage,
//                BelgeBaslik = p.BelgeBaslik
//            };
//            bm.TUpdate(belge);
//            return RedirectToAction("Index");
//        }

//        [Route("BelgeSil/{id}")]
//        public IActionResult BelgeSil(int id)
//        {
//            var values = bm.TGetByID(id);
//            bm.TDelete(values);
//            return RedirectToAction("Index");
//        }

//        [HttpGet]
//        [Route("BelgeEkle")]
//        public IActionResult BelgeEkle()
//        {

//            return View();
//        }

//        [HttpPost]
//        [Route("BelgeEkle")]
//        public async Task<IActionResult> BelgeEkle(BelgelerDüzenle p)
//        {
//            var imagename = "";
//            Belgeler b = new Belgeler();
//            if (p.BelgeImage != null)
//            {
//                var resource = Directory.GetCurrentDirectory();
//                var extention = Path.GetExtension(p.ImageFile.FileName);
//                imagename = Guid.NewGuid() + extention;
//                var saveLocation = resource + "/wwwroot/BelgeResimleri/" + imagename;
//                var stream = new FileStream(saveLocation, FileMode.Create);
//                await p.ImageFile.CopyToAsync(stream);
//            }
//            if (p.BelgeImage != null)
//            {
//                imagename = p.BelgeImage;
//            }
//            b.BelgeBaslik = p.BelgeBaslik;
//            b.BelgeID = p.BelgeID;
//            b.BelgeAcilirImage = p.BelgeAcilirImage;
//            b.BelgeImage = p.BelgeImage;
//            bm.TAdd(b);
//            return RedirectToAction("Index");

//        }
//    }
//}
