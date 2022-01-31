using CustomIdentityApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIZService.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
       
    }
}
