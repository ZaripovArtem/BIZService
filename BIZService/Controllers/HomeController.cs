using BIZService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BIZService.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BIZService.Controllers
{
    public class HomeController : Controller
    {

        private ServiceContext db;

        public HomeController(ServiceContext context)
        {
            db = context;
        }


        public async Task<IActionResult> Index()
        {
            return View(await db.Orders.ToListAsync());
            //return View(db.Services.ToList());
        }
        


        public IActionResult Privacy()
        {
            return View();
        }
        
        
        public IActionResult Order()
        {
            return View();
        }

        [HttpPost]
        //public async Task<IActionResult> Order(Order order)
        //{
        //    db.Orders.Add(order);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}
        public ActionResult Order(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();

            return RedirectToAction("Index");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
