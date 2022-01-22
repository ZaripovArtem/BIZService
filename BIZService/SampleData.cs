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
                        Name = "Не",
                        Surname = "выбрано"
                    },
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
            if (!context.Orders.Any())
            {
                context.Orders.AddRange(
                new Order
                {
                    Service = "Замена бампера",
                    UserName = "Ибрагим",
                    UserSurname = "Шатунов",
                    ContactPhone = "88005553535",
                    PersonnelsID = 1
                },
                new Order
                {
                    Service = "Замена масла",
                    UserName = "Абдула",
                    UserSurname = "Рахимов",
                    ContactPhone = "89835123177",
                    PersonnelsID = 1
                },
                new Order
                {
                    Service = "Замена бампера",
                    UserName = "Иван",
                    UserSurname = "Иванов",
                    ContactPhone = "89873246532",
                    PersonnelsID = 1
                }
                );
                context.SaveChanges();
            }
        }
    }
}