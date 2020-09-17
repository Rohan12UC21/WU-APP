using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using WUApiLib;
using System.Linq;

namespace UpdateHistory.Models
{
    public class CheckServer
    {
        
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UpdateHistoryContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<UpdateHistoryContext>>()))
            {
                if (!context.Server.Any())
                {
                    return;   // DB has been seeded
                }

                foreach(Server item in context.Server)
                {
                    try
                    {
                        Type t = Type.GetTypeFromProgID("Microsoft.Update.Session", item.Location); //wcswapp01.intellig.local     OH0KLT733D7S2.global.ds.honeywell.com     labengdemctl00.labmasoh.local  wcbuildapp02.intellig.local
                        UpdateSession session = (UpdateSession)Activator.CreateInstance(t);
                        item.NoAccess = false;

                    }
                    catch
                    {
                        item.NoAccess = true;
                    }
                }

                context.SaveChanges();
            }
        }

        public static bool Check(Server server)
        {
            try
            {
                Type t = Type.GetTypeFromProgID("Microsoft.Update.Session", server.Location); //wcswapp01.intellig.local     OH0KLT733D7S2.global.ds.honeywell.com     labengdemctl00.labmasoh.local  wcbuildapp02.intellig.local
                UpdateSession session = (UpdateSession)Activator.CreateInstance(t);
                return false;

            }
            catch
            {
                return true;
            }
        }


        public static bool CheckLocation(string location)
        {
            try
            {
                Type t = Type.GetTypeFromProgID("Microsoft.Update.Session", location); //wcswapp01.intellig.local     OH0KLT733D7S2.global.ds.honeywell.com     labengdemctl00.labmasoh.local  wcbuildapp02.intellig.local
                UpdateSession session = (UpdateSession)Activator.CreateInstance(t);
                return false;

            }
            catch
            {
                return true;
            }
        }
    }
}
