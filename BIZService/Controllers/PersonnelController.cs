using BIZService.Models;
using CustomIdentityApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BIZService.ViewModels;

namespace BIZService.Controllers
{
    public class PersonnelController : Controller
    {
        private UserManager<User> _userManager;
        ServiceContext db;

        public PersonnelController(UserManager<User> user, ServiceContext context)
        {
            _userManager = user;
            db = context;
        } 
        public IActionResult Index()
        {
           return View(_userManager.Users.Where(p => p.Email == User.Identity.Name));

            //IQueryable<Order> orders = from c in db.Orders
            //                              where c.NumberMaster == 1
            //                              select c;
            //var order = orders.ToList();
            //var user = _userManager.Users.Where(p => p.Email == User.Identity.Name);

            //return View();
        }

        public IActionResult Orders()
        {

            //IQueryable<User> users = from b in _userManager.Users
            //                         where b.Email == User.Identity.Name
            //                         select b;

            var p = _userManager.Users.Where(a => a.Email == User.Identity.Name).
                  Select(a => a.Number).FirstOrDefault();

            IQueryable<Order> orders = from c in db.Orders
                                       where c.NumberMaster == p
                                       select c;
            // Вместо 1 нужно подставить значение Number 


            return View(orders);
            //return View(users);

            //IQueryable<Order> orders = from c in db.Orders
            //                           where c.NumberMaster == 1
            //                           select c;


            //return View(orders);
        }
    }
}
