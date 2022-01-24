using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BIZService.Models;
using BIZService.ViewModels;
using Microsoft.EntityFrameworkCore;


namespace BIZService.Controllers
{
    public class PersonnelController : Controller
    {
        ServiceContext db;

        public PersonnelController(ServiceContext context)
        {
            db = context;
        }

        public ActionResult Index()
        {
            return View(db.Personnels.ToList());

        }

        public ActionResult Orders(int id)
        {
            var orders = db.Orders.Include(p => p.Personnels);
            return View(orders.ToList());
        }

        //////////////////


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();
            var order = await db.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Bind("OrderID, Service, UserName, UserSurname, ContactPhone, PersonnelsID")]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID, Service, UserName, UserSurname, ContactPhone, PersonnelsID")] Order order)
        {
            if (id != order.OrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(order);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction(nameof(Orders));
            }
            return View("Order");
        }








    }
}