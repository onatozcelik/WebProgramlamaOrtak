using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SakariaBookstore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SakariaBookstore.Models
{
    public static class SeedProduct
    {

        public static void Seed(IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                if (!context.Products.Any())
                {
                    context.Products.AddRange(

                      new Product() {  Name = "Don Quixote", Author = "Miguel de Cervantes", Price = 17, Categories = "Paperback", isAvailable = true },
                        new Product() {  Name = "Harry Potter", Author = "J.K Rowling", Price = 20, Categories = "Paperback", isAvailable = true },
                       new Product() {  Name = "The Hunger Games", Author = "Suzanne Collins", Price = 20, Categories = "Paperback", isAvailable = false }

                        );

                    context.SaveChanges();

                }
            }

        }


    }
}
