using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GaleriManager:IGaleriService
    {
        IGaleriDal _galeriDal;

        public GaleriManager(IGaleriDal galeriDal)
        {
            _galeriDal = galeriDal;
        }

        public void TAdd(Galeri t)
        {
            _galeriDal.Insert(t);
        }

        public void TDelete(Galeri t)
        {
           _galeriDal.Delete(t);
        }

        public Galeri TGetByID(int id)
        {
            return _galeriDal.GetByID(id);
        }

        public List<Galeri> TGetList()
        {
            return _galeriDal.GetList();
        }

        public void TUpdate(Galeri t)
        {
            _galeriDal.Update(t);
        }
    }
}
