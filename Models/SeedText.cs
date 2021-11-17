using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgOdev.Data;

namespace WebProgOdev.Models
{
    public class SeedText
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                if (!context.Texts.Any())
                {
                    context.Texts.AddRange(
                        new Text() { yaziBaslik = "Yazı Başlık", yaziIcerik = "Sunt in culpa qui officia deserunt mollit anim id est laborum consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco." }
                        );
                    context.SaveChanges();
                }
            }

        }
    }
}
