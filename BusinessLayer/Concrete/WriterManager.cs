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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerdal;


        public WriterManager(IWriterDal writerDal)
        {
            _writerdal = writerDal;
        }

        public void AddT(Writer t)
        {
            _writerdal.Add(t);
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriterById(int id)
        {
            return _writerdal.GetListAll(x => x.WriterID == id);
        }

        public void TDelete(Writer t)
        {
            throw new NotImplementedException();
        }

        public Writer TGetById(int id)
        {
           return _writerdal.GetByID(id);
        }

        public void TUpdate(Writer t)
        {
            _writerdal.Update(t);
        }

       

    }
}
