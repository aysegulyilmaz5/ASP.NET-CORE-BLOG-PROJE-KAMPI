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
    
    public class CommandController : Controller
    {
        CommandManager cm = new CommandManager(new EFCommandRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddCommand()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult PartialAddCommand(Command p)
        {
            p.CommandDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommandStatus = true;
            p.BlogID = 3;
            cm.AddT(p);
            return RedirectToAction("BlogReadAll","Blog",new { id = p.BlogID });
        }

        public PartialViewResult CommandListByBlog(int id)
        {
            var values = cm.GetList(id);
            return PartialView(values);
        }
    }
}
