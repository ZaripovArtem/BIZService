using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIZService.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
            /// Здесь будет главная страница, откуда пользователи с доступом Admin смогут переходить по другим ссылкам
        }
    }
}
