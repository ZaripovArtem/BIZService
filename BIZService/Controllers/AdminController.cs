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
        public AdminController(ServiceContext context)
        {
            db = context;
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


            return View(db.Orders.ToList());
            
        }

    }
}
