using System.Linq;
using BIZService.Models;

namespace BIZService
{
    public static class SampleData
    {
        public static void Initialize(ServiceContext context)
        {
            if (!context.Personnels.Any())
            {
                context.Personnels.AddRange(
                    new Personnel
                    {
                        Name = "Аббас",
                        Surname = "Шаллаф"
                    },
                    new Personnel
                    {
                        Name = "Артур",
                        Surname = "Платонов"
                    },
                    new Personnel
                    {
                        Name = "Камал",
                        Surname = "Тимуров"
                    }
                 );
                context.SaveChanges();
            }
        }
    }
}