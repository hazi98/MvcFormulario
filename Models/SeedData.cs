using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcFormulario.Data;
using System;
using System.Linq;

namespace MvcFormulario.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcFormularioContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcFormularioContext>>()))
            {
                // Look for any movies.
                if (context.Formulario.Any())
                {
                    return;   // DB has been seeded
                }

                context.Formulario.AddRange(
                    new Formulario
                    {
                        Gamertag = "La chona",
                        Servername = "asdgvs",
                        Name = "Yoltic",
                        Age = 7,
                        //Gender= "hombre",
                        Email = "asfagarg@fsrg.com"
                        
                    },

                    new Formulario
                    {
                        Gamertag = "Cheve",
                        Servername = "vgd",
                        Name = "Ivan",
                        Age = 44,
                        //Gender= "hombre",
                        Email = "fafeg@fsrg.com"
                    },

                    new Formulario
                    {
                        Gamertag = "AllMight",
                        Servername = "caees",
                        Name = "Diana",
                        Age = 35,
                        //Gender= "hombre",
                        Email = "fearg@fsrg.com",
                    }

                    
                );
                context.SaveChanges();
            }
        }
    }
}