using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BIZService.Models;
using System.Linq;

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

     
    }
}
