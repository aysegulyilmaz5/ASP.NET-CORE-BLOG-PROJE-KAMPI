using DataAcessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistics
{
    public class Statistic2 :ViewComponent
    {
        
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
           
            ViewBag.v1 = c.Blogs.OrderByDescending(x =>x.BlogID).Select(x => x.BlogtTitle).Take(1).FirstOrDefault();
            ViewBag.v3 = c.Commands.Count();
            return View();
        }
    }
}
