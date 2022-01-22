using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BIZService.Models;

namespace BIZService.ViewModels
{
    public class OrdersViewModel
    {
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Personnel> Personnels { get; set; }
    }
}
