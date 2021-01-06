using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DenizKabugu.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DenizKabugu.Models
{
    public class SeedProduct
    {
        public static void Seed (IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                if (!context.Products.Any())
                {
                    context.Products.AddRange(
                        new Product() { Name = "Gül", CategoryID = 1, Price = 50 },
                        new Product() { Name = "Papatya", CategoryID = 2, Price = 40 },
                        new Product() { Name = "Karanfil", CategoryID = 3, Price = 30 },
                        new Product() { Name = "Lale", CategoryID = 4, Price = 35 },
                        new Product() { Name = "Sütlü Çikolata", CategoryID = 1, Price = 20 },
                        new Product() { Name = "Bitter Çikolata", CategoryID = 2, Price = 20 },
                        new Product() { Name = "Beyaz Çikolata", CategoryID = 3, Price = 20 },
                        new Product() { Name = "Puzzle", CategoryID = 1, Price = 100 },
                        new Product() { Name = "Oyuncak Ayı", CategoryID = 2, Price = 120 },
                        new Product() { Name = "Oyun Seti", CategoryID = 3, Price = 150 },
                        new Product() { Name = "Simyacı", CategoryID = 1, Price = 30 },
                        new Product() { Name = "Fareler ve İnsanlar", CategoryID = 2, Price = 30 }

                        );
                    context.SaveChanges();
                }
            }
        }
    }
}
