using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIZService.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string NameService { get; set; } // название услуги
        public string ShortDesc { get; set; } // краткое описание услуги
        public int Price { get; set; }
    }
}
