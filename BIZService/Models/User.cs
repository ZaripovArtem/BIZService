using BIZService.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CustomIdentityApp.Models
{
    public class User : IdentityUser
    {
        public int? Number { get; set; } // Номер мастера по порядку
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Order> Orders { get; set; }
        public User()
        {
            Orders = new List<Order>();
        }
    }
}