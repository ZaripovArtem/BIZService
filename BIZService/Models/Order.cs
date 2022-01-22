using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIZService.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string Service { get; set; } // название услуги
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string ContactPhone { get; set; } // Контактный номер заказчика


        public int? PersonnelsID { get; set; } // ID исполнителя
        public Personnel Personnels { get; set; } // Персонал компании
     
    }
}
