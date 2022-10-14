using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VrundRug.Data;

namespace VrundRug.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VrundRugContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<VrundRugContext>>()))
            {
                // Look for any Rugs.
                if (context.Rug.Any())
                {
                    return;   // DB has been seeded
                }

                context.Rug.AddRange(
                    new Rug
                    {
                        MfgPlace = "Tunishia",
                        MfgDate = DateTime.Parse("2021-2-12"),
                        Designs = "Chevron Rug",
                        Material = "Wool",
                        Rating = "R",
                        Price = 1922.22M
                    },

                    new Rug
                    {
                        MfgPlace = "Afghanistan",
                        MfgDate = DateTime.Parse("2022-3-13"),
                        Designs = "Geometric Rug",
                        Material = "Wool",
                        Rating = "R",
                        Price = 5543.00M
                    },

                    new Rug
                    {
                        MfgPlace = "Iran",
                        MfgDate = DateTime.Parse("2019-2-23"),
                        Designs = "Border Rug",
                        Material = "Nylon",
                        Rating = "R",
                        Price = 3565.75M
                    },

                    new Rug
                    {
                        MfgPlace = "India",
                        MfgDate = DateTime.Parse("2020-4-15"),
                        Designs = "Distressed Rug",
                        Material = "Synthetic Jute",
                        Rating = "R",
                        Price = 7899.99M
                    },

                     new Rug
                     {
                         MfgPlace = "China",
                         MfgDate = DateTime.Parse("2017-2-23"),
                         Designs = "Chilewich",
                         Material = "Wool",
                         Rating = "R",
                         Price = 4087.54M
                     },

                      new Rug
                      {
                          MfgPlace = "Morocco",
                          MfgDate = DateTime.Parse("2022-2-23"),
                          Designs = "Animal Print Rug",
                          Material = "Wool",
                          Rating = "R",
                          Price = 9688.54M
                      },

                       new Rug
                       {
                           MfgPlace = "America",
                           MfgDate = DateTime.Parse("2019-2-23"),
                           Designs = "High-Low Rug",
                           Material = "Nylon",
                           Rating = "R",
                           Price = 7234.66M
                       },

                        new Rug
                        {
                            MfgPlace = "Afghanistan",
                            MfgDate = DateTime.Parse("2022-2-23"),
                            Designs = "Shag Rug",
                            Material = "Wool",
                            Rating = "R",
                            Price = 10566.22M
                        },

                         new Rug
                         {
                             MfgPlace = "Morocco",
                             MfgDate = DateTime.Parse("2021-2-23"),
                             Designs = "Border Rug",
                             Material = "Chilewich",
                             Rating = "R",
                             Price = 4577.23M
                         },

                          new Rug
                          {
                              MfgPlace = "India",
                              MfgDate = DateTime.Parse("2018-2-23"),
                              Designs = "Novelty Rug",
                              Material = "Wool",
                              Rating = "R", 
                              Price = 6987.47M
                          }
                );
                context.SaveChanges();
            }
        }
    }
}
