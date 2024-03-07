using ForceGet.Entity.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForceGet.Context.Seed
{

    public static class SeedData
    {
        public static void Create(ForceGetContext context)
        {
            context.Database.EnsureCreated();


            if (!context.Countries.Any())
            {
                var countries = new[]
                {
                    new Country { Name = "Turkey" },
                    new Country { Name = "USA" },

                };

                context.Countries.AddRange(countries);
                context.SaveChanges();
            }

            if (!context.Cities.Any())
            {
                var cities = new[]
                {
                    new City { Name = "Bursa", CountryId = 1 },
                    new City { Name = "Miami", CountryId = 2 },

                };

                context.Cities.AddRange(cities);
                context.SaveChanges();
            }

            if (!context.Currencies.Any())
            {
                var currencies = new[]
                {
                    new Currency { Name = "USD-Dolar", Code = "Usd" },
                    new Currency { Name = "Türk Lirası", Code = "TRY" },
                };

                context.Currencies.AddRange(currencies);
                context.SaveChanges();
            }

            if (!context.Unit1.Any())
            {
                var unit1 = new[]
                {
                    new Unit1 { Name = "CM", CountryId=1 },
                    new Unit1 { Name = "IN", CountryId=2  },

                };

                context.Unit1.AddRange(unit1);
                context.SaveChanges();
            }

            if (!context.Unit1.Any())
            {
                var unit2 = new[]
                {
                    new Unit2 { Name = "KG", CountryId=1 },
                    new Unit2 { Name = "LB", CountryId=2  },
                    // Add more cities as needed
                };

                context.Unit2.AddRange(unit2);
                context.SaveChanges();
            }


        }
    }
}
