using BusinessLayer.Abstract;
using DataAcessLayer.Abstract;
using DataAcessLayer.EntityFramework;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddT(Category t)
        {
            _categoryDal.Add(t);
        }
        public Category TGetById(int id)
        {
            return _categoryDal.GetByID(id);
        }

       

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }


        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }

        public void IDelete(Category value)
        {
            throw new NotImplementedException();
        }
    }
}
