using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BIZService.Models;
using CustomIdentityApp.Models;

namespace BIZService.Models
{
    public class ServiceContext : DbContext
    {
        public DbSet<Service> Services { get; set; }
        public DbSet<Order> Orders { get; set; }
        
        public ServiceContext(DbContextOptions<ServiceContext> options)
           : base(options)
        {
            Database.EnsureCreated(); // Если БД отсутствует - автоматически создает ее
        }

    }
}
