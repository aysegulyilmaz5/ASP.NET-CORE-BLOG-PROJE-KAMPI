using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService :IGenericService<Blog>
    {
      

        List<Blog> GetBlogListWithCategory();

        List<Blog> GetLast3Blog();

        List<Blog> GetBlogListByWriter(int id);

        List<Blog> GetBlogByID(int id);


    }
}
