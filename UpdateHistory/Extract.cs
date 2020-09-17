using System;
using System.Collections.Generic;
using System.Linq;
using WUApiLib;
using HtmlAgilityPack;
using UpdateHistory.Models;
using System.Net;
using Microsoft.EntityFrameworkCore;

namespace UpdateHistory
{
    public class Extract
    {
        public static IList<Info> InfoList = new List<Info>();

        public UpdateHistoryContext _context;

        public Extract()
        {
        }

        public IList<Info> ExtractRun(Server server, bool initiated)  //Creates the Info list to be populated in the Info Table
        {
            InfoList.Clear();
            UpdateHist(server, initiated); // Grabs the update history from the given server
            ExtractInfo();  // Connects to update catalog and grabs further information for each updates
            //Check();  // Checks for duplicate update history and changes the active status of all previous updates to inactive

            return InfoList;
        }



        public static void UpdateHist(Server server, bool initiated)
        {
            try
            {
                Type t = Type.GetTypeFromProgID("Microsoft.Update.Session", server.Location); //wcswapp01.intellig.local     OH0KLT733D7S2.global.ds.honeywell.com     labengdemctl00.labmasoh.local  wcbuildapp02.intellig.local
                UpdateSession session = (UpdateSession)Activator.CreateInstance(t);
                IUpdateSearcher updateSearcher = session.CreateUpdateSearcher();

                int count = updateSearcher.GetTotalHistoryCount();
                IUpdateHistoryEntryCollection history = updateSearcher.QueryHistory(0, count);
                
                DateTime current = DateTime.Now;

                for (int i = 0; i < count; ++i)
                {
                    if(initiated == true)
                    {
                        int hecc = current.Day * (-1);
                        if (history[i].Date >= current.AddMonths(-1).AddDays(hecc))
                        {
                            Info temp = new Info();
                            IUpdateIdentity ID = history[i].UpdateIdentity;
                            OperationResultCode operationResult = history[i].ResultCode;
                            string Result = operationResult.ToString();

                            if (Result == "orcSucceeded")
                            {
                                temp.TestResults = "Succeeded";
                                temp.UpdateStatus = "Succeeded";

                            }
                            else
                            {
                                temp.TestResults = "Failed";
                                temp.UpdateStatus = "Failed";
                            }

                            temp.TestDate = history[i].Date;
                            temp.updateID = ID.UpdateID;
                            temp.Title = history[i].Title;
                            temp.ICW = server.ICW;
                            temp.Server = server.ServerName;

                            temp.Active = "Yes";
                            
                            InfoList.Add(temp);
                        }
                    }

                    else
                    {
                        Info temp = new Info();
                        IUpdateIdentity ID = history[i].UpdateIdentity;
                        OperationResultCode operationResult = history[i].ResultCode;
                        string Result = operationResult.ToString();

                        if (Result == "orcSucceeded")
                        {
                            temp.TestResults = "Succeeded";
                            temp.UpdateStatus = "Succeeded";

                        }
                        else
                        {
                            temp.TestResults = "Failed";
                            temp.UpdateStatus = "Failed";
                        }

                        temp.TestDate = history[i].Date;
                        temp.updateID = ID.UpdateID;
                        temp.Title = history[i].Title;
                        temp.ICW = server.ICW;
                        temp.Server = server.ServerName;

                        temp.Active = "Yes";

                        //### Uncomment to ignore the updates older than 7 months
                        //if (temp.TestDate <= current.AddMonths(-7))
                        int y = current.Year;
                        DateTime year = new DateTime(y, 1, 1);
                        if (temp.TestDate <= year)
                        {
                            break;
                        }

                        InfoList.Add(temp);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /*public void Check()
        {
            using (var context = new UpdateHistoryContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<UpdateHistoryContext>>()))
            {
                foreach (Info item in InfoList)
                {
                    foreach (Info itemDB in _context.Info)
                    {
                        if (item == itemDB)
                        {
                            _context.Info.Remove(itemDB);
                        }
                    }
                }
                _context.SaveChanges();
            }
        }*/

        /*public static void Check()
        {
            List<string> kb = new List<string>();
            IEnumerable<string> yuh = from m in InfoList
                                      orderby m.KBID
                                      select m.KBID;

            kb = yuh.Distinct().ToList();

            foreach (string kbeach in kb)
            {
                if (kbeach != "N/A")
                {
                    int a = 0;
                    foreach (Info temp in InfoList.Where(x => x.KBID == kbeach))
                    {
                        if (a > 0)
                        {
                            int pos = InfoList.IndexOf(temp);
                            InfoList[pos].Active = "No";
                        }
                        a++;
                    }
                }
            }
        }*/

        public static void ExtractInfo()
        {
            foreach (Info items in InfoList.OrderBy(p => p.TestDate).ThenBy(x => x.Title))
            {
                string htmlCode;
                using (WebClient client = new WebClient())
                {
                    htmlCode = client.DownloadString("http://www.catalog.update.microsoft.com/ScopedViewInline.aspx?updateid=" + items.updateID);
                }
                HtmlDocument document = new HtmlDocument();
                document.LoadHtml(htmlCode);
                HtmlNode node = document.DocumentNode.SelectSingleNode("//span[@id='scopedViewHeaderTitleResource']");
                if (node != null)
                {

                    items.Classification = ExtractClassification(document);
                    items.Architecture = ExtractArchitecture(document);
                    items.SupportedProducts = ExtractProducts(document);
                    items.SupportedLanguages = ExtractLanguages(document);
                    items.KBID = ExtractKBID(document);
                    items.MSRCNumber = ExtractMsrcNumber(document);
                    items.MSRCSeverity = ExtractMsrcSeverity(document);
                    items.LastReleased = ExtractLastModified(document);


                }

                else
                {
                    items.Classification = "N/A";
                    items.Architecture = "N/A";
                    items.SupportedProducts = "N/A";
                    items.SupportedLanguages = "N/A";
                    items.KBID = "N/A";
                    items.MSRCNumber = "N/A";
                    items.MSRCSeverity = "N/A";
                    items.LastReleased = "N/A";
                }
            }
        }

        public static string ExtractClassification(HtmlDocument document)
        {
            HtmlNode node1 = document.DocumentNode.SelectSingleNode("//div[@id='classificationDiv']");
            string temp = node1.InnerText;
            temp = temp.Substring(45);
            temp = temp.Trim();

            return temp;
        }

        public static string ExtractArchitecture(HtmlDocument document)
        {
            HtmlNode node1 = document.DocumentNode.SelectSingleNode("//div[@id='archDiv']");
            string temp = node1.InnerText;
            temp = temp.Substring(60);
            temp = temp.Trim();
            string[] temp2 = temp.Split(',');
            string temp4 = "";
            foreach (string temp3 in temp2)
            {
                temp4 = temp4 + ", " + temp3.Trim();
            }

            temp4 = temp4.Substring(2);

            return temp4;
        }

        public static string ExtractProducts(HtmlDocument document)
        {
            HtmlNode node1 = document.DocumentNode.SelectSingleNode("//div[@id='productsDiv']");
            string temp = node1.InnerText;
            temp = temp.Substring(60);
            temp = temp.Trim();
            string[] temp2 = temp.Split(',');
            string temp4 = "";
            foreach (string temp3 in temp2)
            {
                temp4 = temp4 + ", " + temp3.Trim();
            }

            temp4 = temp4.Substring(2);


            return temp4;
        }

        public static string ExtractLanguages(HtmlDocument document)
        {
            HtmlNode node1 = document.DocumentNode.SelectSingleNode("//div[@id='languagesDiv']");
            string temp = node1.InnerText;
            temp = temp.Substring(60);
            temp = temp.Trim();
            string[] temp2 = temp.Split(',');
            string temp4 = "";
            foreach (string temp3 in temp2)
            {
                temp4 = temp4 + ", " + temp3.Trim();
            }

            temp4 = temp4.Substring(2);


            return temp4;
        }



        public static string ExtractKBID(HtmlDocument document)
        {
            HtmlNodeCollection collection = document.DocumentNode.SelectNodes("//div[@id='ScopedViewHandler_SoftwareInfo']");

            try
            {
                foreach (HtmlNode node in collection)
                {
                    string cptitle = node.SelectSingleNode(".//div[@id='kbDiv']").InnerText;
                    cptitle = cptitle.Substring(60);
                    cptitle = cptitle.Trim();


                    return cptitle;
                }
            }
            catch
            {
                return "N/A";
            }
            return "N/A";
        }

        public static string ExtractMsrcSeverity(HtmlDocument document)
        {
            HtmlNodeCollection collection = document.DocumentNode.SelectNodes("//div[@id='ScopedViewHandler_SoftwareInfo']");

            try
            {
                foreach (HtmlNode node in collection)
                {
                    string cptitle = node.SelectSingleNode(".//div[@id='msrcSeverityDiv']").InnerText;
                    cptitle = cptitle.Substring(60);
                    cptitle = cptitle.Trim();


                    return cptitle;
                }
            }
            catch
            {
                return "N/A";
            }
            return "N/A";

        }

        public static string ExtractMsrcNumber(HtmlDocument document)
        {
            HtmlNodeCollection collection = document.DocumentNode.SelectNodes("//div[@id='ScopedViewHandler_SoftwareInfo']");

            try
            {
                foreach (HtmlNode node in collection)
                {
                    string cptitle = node.SelectSingleNode(".//div[@id='securityBullitenDiv']").InnerText;
                    cptitle = cptitle.Substring(60);
                    cptitle = cptitle.Trim();


                    return cptitle;
                }
            }
            catch
            {
                return "N/A";
            }
            return "N/A";

        }


        public static string ExtractLastModified(HtmlDocument document)
        {
            HtmlNode node1 = document.DocumentNode.SelectSingleNode("//span[@id='ScopedViewHandler_date']");
            string temp = node1.InnerText;

            return temp;
        }
    }
}
