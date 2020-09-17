using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UpdateHistory.Models
{
    public static class SeedServer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UpdateHistoryContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<UpdateHistoryContext>>()))
            {
                if (context.Server.Any())
                {
                    //##### Remove coments to delete all items from Server List
                    /*foreach (Server item in context.Server)
                    {
                        context.Server.Remove(item);
                    }*/

                    return;   // DB has been seeded
                }
                
                context.SaveChanges();
            }
        }
    }
}