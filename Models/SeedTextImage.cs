using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgOdev.Data;

namespace WebProgOdev.Models
{
    public class SeedTextImage
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                if (!context.TextImages.Any())
                {
                    context.TextImages.AddRange(
                        new TextImage() { gorselAdi = "fotograf.jpg" }
                        );
                    context.SaveChanges();
                }
            }

        }
    }
}
