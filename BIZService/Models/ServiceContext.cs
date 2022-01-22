using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIZService.Models
{
    public class ServiceContext : DbContext
    {
         public DbSet<Personnel> Personnels { get; set; }
         public DbSet<Order> Orders { get; set; }
         public ServiceContext(DbContextOptions<ServiceContext> options)
            : base(options)
         {
            Database.EnsureCreated(); // Если БД отсутствует - автоматически создает ее
         }

    } 
}
