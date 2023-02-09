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
    public class IVizyonumuzManager:IVizyonumuzService
    {
        IVizyonumuzDal _vizyonDal;

        public IVizyonumuzManager(IVizyonumuzDal vizyonDal)
        {
            _vizyonDal = vizyonDal;
        }

        public void TAdd(Vizyonumuz t)
        {
            _vizyonDal.Insert(t);   
        }

        public void TDelete(Vizyonumuz t)
        {
            _vizyonDal.Delete(t);
        }

        public Vizyonumuz TGetByID(int id)
        {
           return _vizyonDal.GetByID(id);   
        }

        public List<Vizyonumuz> TGetList()
        {
            return _vizyonDal.GetList();
        }

        public void TUpdate(Vizyonumuz t)
        {
            _vizyonDal.Update(t);
        }
    }
}
