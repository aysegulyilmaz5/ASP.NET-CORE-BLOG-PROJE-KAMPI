using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents
{
    public class CommandList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commandvalues = new List<UserCommand>
            {
                new UserCommand
                {
                    ID = 1,
                    Username = "Ayşegül"
                },
                new UserCommand
                {
                    ID = 2,
                    Username = "Emre"
                },
                new UserCommand
                {
                    ID = 3,
                    Username = "Nesrin"
                }

            };
            return View(commandvalues);
        }
    }
}
