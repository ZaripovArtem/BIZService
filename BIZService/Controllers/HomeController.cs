using BIZService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BIZService.Models;

namespace BIZService.Controllers
{
    public class HomeController : Controller
    {
        ServiceContext db;
        public HomeController(ServiceContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View();
            //Здесь будет страница с заказом
        }

        
    }
}
