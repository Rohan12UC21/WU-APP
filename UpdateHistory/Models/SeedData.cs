using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UpdateHistory.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider, List<bool> selServers)
        {
            using (var context = new UpdateHistoryContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<UpdateHistoryContext>>()))
            {

                if (context.Info.Any())
                {
                    //##### Remove coments to delete all items from Info List
                    /*foreach (Info item in context.Info)
                    {
                        context.Info.Remove(item);
                    }*/

                    //return;   // DB has been seeded
                }
                context.SaveChanges();

                IList<Info> List = new List<Info>();
                Extract extract = new Extract();

                int count = 0;
                foreach(Server server in context.Server)
                {
                    if (selServers[count] == true)
                    {
                        if(server.Initiated==false)
                        {
                            List = extract.ExtractRun(server, false);
                            server.Initiated = true;
                        }
                        else
                            List = extract.ExtractRun(server, true);

                        foreach (Info item in List)
                        {
                            bool match = false;
                            foreach(Info itemKB in context.Info)
                            {
                                if((item.LastReleased==itemKB.LastReleased) && (item.KBID == itemKB.KBID) && (item.Title == itemKB.Title) && (item.updateID == itemKB.updateID) && (item.UpdateStatus == itemKB.UpdateStatus) && (item.Server == itemKB.Server) && (item.ICW == itemKB.ICW))
                                {
                                    match = true;
                                    break;
                                    //context.Info.Remove(itemKB);
                                }
                            }
                            if(match==false)
                            {
                                context.Info.Add(
                                new Info
                                {
                                    Active = "Yes",
                                    KBID = item.KBID,
                                    Title = item.Title,
                                    ICW = item.ICW,
                                    Server = item.Server,
                                    MSRCSeverity = item.MSRCSeverity,
                                    TestDate = item.TestDate,
                                    Classification = item.Classification,
                                    Architecture = item.Architecture,
                                    SupportedProducts = item.SupportedProducts,
                                    MSRCNumber = item.MSRCNumber,
                                    updateID = item.updateID,
                                    SupportedLanguages = item.SupportedLanguages,
                                    TestResults = item.TestResults,
                                    LastReleased = item.LastReleased,
                                    UpdateStatus = item.UpdateStatus,
                                    Reason = "",
                                    ID = item.ID


                                }
                                );
                            } 
                        }
                    }
                    count++;
                }
                context.SaveChanges();
            }
        }
    }
}