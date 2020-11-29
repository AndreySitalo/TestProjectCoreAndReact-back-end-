using Orders.DB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orders.DB
{
    public static class SampleData
    {
        public static void Initdata(EFDBContext context) 
        {
            if (!context.Cities.Any())
            {
                context.Cities.Add(new City() { Name = "Томск" });
                context.Cities.Add(new City() { Name = "Новосибирск" });
                context.Cities.Add(new City() { Name = "Санкт-Петербург" });
                context.Cities.Add(new City() { Name = "Белово" });
                context.Cities.Add(new City() { Name = "Москва" });
                context.Cities.Add(new City() { Name = "Анхангельск" }); /// ЫЫЫЫЫЫЫЫ
                context.Cities.Add(new City() { Name = "Тверь" });
                context.Cities.Add(new City() { Name = "Пенза" });
                context.SaveChanges();

            }
        }
    }
}
