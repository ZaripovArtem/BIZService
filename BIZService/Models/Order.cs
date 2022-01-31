using CustomIdentityApp.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIZService.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; } // статус услуги
        public string MarkAndModel { get; set; } // модель и марка
        public string Addition { get; set; } // Примечания к услуге
        public int? NumberMaster { get; set; } // Номер мастера
        UserManager<User> Users { get; set; }
        
    }
}
