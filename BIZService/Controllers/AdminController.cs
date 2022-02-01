using BIZService.Models;
using BIZService.ViewModels;
using CustomIdentityApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIZService.Controllers
{
    public class AdminController : Controller
    {
        private ServiceContext db;
        private readonly UserManager<User> _userManager;
        public AdminController(ServiceContext context, UserManager<User> userManager)
        {
            db = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            /////////////////////////////////////////////////////////
            //IQueryable<Order> orders = from c in db.Orders
            //                           where c.NumberMaster == 1
            //                           select c;


            //return View(orders);
            // LINQ запрос на вывод всех заказов с id мастера = 1
            //////////////////////////////////////////////////////


            //var orders = db.Orders.Include(p => p.Users)

            

            return View(db.Orders.ToList());

        }

        public async Task<IActionResult> Edit(string OrderId)
        {
            Order order = await db.Orders.FindAsync(OrderId);
            if (order != null)
                return View(order);
            return NotFound();
        }
    }
}
