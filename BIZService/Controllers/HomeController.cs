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
using Microsoft.AspNetCore.Identity;
using CustomIdentityApp.Models;

namespace BIZService.Controllers
{
    public class HomeController : Controller
    {

        private ServiceContext db;
        //private UserContext udb;
        private UserManager<User> _userManager;



        public HomeController(ServiceContext context, UserManager<User> userManager)
        {
            db = context;
            _userManager = userManager;
        }


        public async Task<IActionResult> Index()
        {
            return View(await db.Orders.ToListAsync());
          
            
        }
        


        public async Task<IActionResult> Privacy()
        {
            return View(_userManager.Users.ToList());
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

            return RedirectToAction("Completed");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Competed()
        {
            return View();
        }
    }
}
