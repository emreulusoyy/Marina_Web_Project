using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Iletisim
    {
        [Key]
        public int IletisimID { get; set; }
        public string OfisNo { get; set; }
        public string GsmNo { get; set; }
        public string Email { get; set; }
        public string IlAdres { get; set; }
        public string AcıkAdres { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }

    }
}
