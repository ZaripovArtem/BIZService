using BIZService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIZService
{
    public class SampleData
    {
        public static void Initialize(ServiceContext context)
        {
            if (!context.Services.Any())
            {
                context.Services.AddRange(
                new Service
                {
                    NameService = "Замена масла",
                    ShortDesc = "Описание 1", 
                    Price = 500
                },
                new Service
                {
                    NameService = "Замена колодок",
                    ShortDesc = "Описание 2",
                    Price = 1500
                },
                new Service
                {
                    NameService = "Замена ГУР",
                    ShortDesc = "Описание 3",
                    Price = 2500
                }
                );
                context.SaveChanges();
            }
        }
    }
}
