using BusinessLayer.Abstract;
using DataAcessLayer.Abstract;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal  _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void AddT(About t)
        {
            throw new NotImplementedException();
        }

        public About TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        {
            return _aboutDal.GetListAll();
        }

        public void TDelete(About t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About t)
        {
            throw new NotImplementedException();
        }
    }
}
