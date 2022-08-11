using DataAcessLayer.Abstract;
using DataAcessLayer.Repositories;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.EntityFramework
{
    public class EFAdminRepository : GenericRepository<Admin>,IAdminDal
    {
    }
}
