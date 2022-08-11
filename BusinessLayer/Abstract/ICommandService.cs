using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommandService : IGenericService<Command>
    {
        

        //void CategoryDelete(Category category);
        //void CategoryUpdate(Category category);
       
        List<Command> GetCommandWithBlog();
        //Category GetById(int id);
    }
}
