using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgOdev.Data;

namespace WebProgOdev.Models
{
    public class SeedCategory
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(
                        new Category() { kategoriAdi = "Yaşam" },
                        new Category() { kategoriAdi = "Edebiyat" }
                        );
                    context.SaveChanges();
                }
            }

        }
    }
}
