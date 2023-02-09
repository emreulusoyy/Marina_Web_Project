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
    public class MisyonumuzManager:IMisyonumuzService
    {
        IMisyonumuzDal _misyonumuzDal;

        public MisyonumuzManager(IMisyonumuzDal misyonumuzDal)
        {
            _misyonumuzDal = misyonumuzDal;
        }

        public void TAdd(Misyonumuz t)
        {
            _misyonumuzDal.Update(t);
        }

        public void TDelete(Misyonumuz t)
        {
            _misyonumuzDal.Delete(t);
        }

        public Misyonumuz TGetByID(int id)
        {
          return _misyonumuzDal.GetByID(id);
        }

        public List<Misyonumuz> TGetList()
        {
            return _misyonumuzDal.GetList();
        }

        public void TUpdate(Misyonumuz t)
        {
            _misyonumuzDal.Update(t);
        }
    }
}
