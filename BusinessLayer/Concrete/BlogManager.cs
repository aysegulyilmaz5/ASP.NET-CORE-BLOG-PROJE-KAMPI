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
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }


        public Blog TGetById(int id)
        {
            return _blogDal.GetByID(id);
        }

        public List<Blog> GetBlogByID(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();

        }

        public List<Blog> GetLast3Blog()
        {
            return _blogDal.GetListAll().Take(3).ToList();
        }
        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterID == id);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetListWithCategoryByWriterBM(int id)
        {
            return _blogDal.GetListWithCategoryByWriter(id);
        }

        public void AddT(Blog t)
        {
            _blogDal.Add(t);
        }

        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }
    }
}
