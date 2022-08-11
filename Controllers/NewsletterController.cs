using BusinessLayer.Concrete;
using DataAcessLayer.EntityFramework;
using Entity_Layer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    
    public class newsletter : Controller
    {
        NewsletterManager nm = new NewsletterManager(new EFNewsletterRepository());
        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]


        public PartialViewResult SubscribeMail(Newsletter p)
        {
            p.MailStatus = true;
            nm.AddNewsletter(p);
            return PartialView();
        }
    }
    
}
