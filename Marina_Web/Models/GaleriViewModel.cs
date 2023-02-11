using Microsoft.AspNetCore.Http;

namespace Marina_Web.Models
{
    public class GaleriViewModel
    {
        public int GaleriID { get; set; }

        public string GaleriImage { get; set; }
        public string Baslik { get; set; }

        public IFormFile ImageFile { get; set; }

    }
}
