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
              return View(db.Orders.ToList().OrderByDescending(i => i.Id));
        }

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
        public async Task<IActionResult> Edit(int id, [Bind("Id, ServiceName, Surname, Name, Patronymic, PhoneNumber, Status, MarkAndModel, Addition, NumberMaster")] Order order)
        {
            if (id != order.Id)
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
                return RedirectToAction(nameof(Index));
            }


            return View("Index");
        }
    }
}
