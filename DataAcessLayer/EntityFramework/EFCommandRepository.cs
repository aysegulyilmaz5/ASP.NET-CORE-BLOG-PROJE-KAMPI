using DataAcessLayer.Abstract;
using DataAcessLayer.Concrete;
using DataAcessLayer.Repositories;
using Entity_Layer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.EntityFramework
{
    public class EFCommandRepository : GenericRepository<Command>, ICommandDal
    {
     

        public List<Command> GetListWithBlog()
        {
            using (var c = new Context())
            {
                return c.Commands.Include(x => x.Blog).Where(y => y.IsDelete == false).ToList();
            }
        }
    }
}
