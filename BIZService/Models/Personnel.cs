using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIZService.Models
{
    public class Personnel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        //public List<Order> Orders { get; set; } = new List<Order>(); // заказы для персонала
        public ICollection<Order> Orders { get; set; }
        public Personnel()
        {
            Orders = new List<Order>();
        }
    }
}
