using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIZService.ViewModels
{
    public class CreateUserViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Number { get; set; } //
    }
}
