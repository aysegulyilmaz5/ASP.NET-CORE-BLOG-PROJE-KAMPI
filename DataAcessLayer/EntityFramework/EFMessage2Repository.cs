using Microsoft.EntityFrameworkCore;


using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer.Repositories;
using DataAcessLayer.Concrete;
using DataAcessLayer.Abstract;

namespace DataAcessLayer.EntityFramework
{
    public class EFMessage2Repository : GenericRepository<Message2>, IMessage2Dal
    {

        public List<Message2> GetListWithMessageByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Messages2.Include(x => x.SenderUser).Where(x => x.ReceiverID == id).ToList();
            }
        }
    }

  

}
