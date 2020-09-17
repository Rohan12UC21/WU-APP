using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UpdateHistory.Models;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;

namespace UpdateHistory.Pages.Infos
{
    public class IndexModel : PageModel
    {
        private readonly UpdateHistory.Models.UpdateHistoryContext _context;


        public IndexModel(UpdateHistory.Models.UpdateHistoryContext context)
        {
            _context = context;
        }

        public IList<Info> Info { get; set; }


        [BindProperty(SupportsGet = true)]
        public string SearchKBID { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchICW { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchServer { get; set; }

        [BindProperty(SupportsGet = true)]
        public string datefilter { get; set; }

        public SelectList ResultList { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SelectedResult { get; set; }


        public SelectList ServerList { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SelectedServer { get; set; }

        [BindProperty(SupportsGet = true)]
        public string FilteredPage { get; set; }
        



        public async Task OnGetAsync()
        {
            IUrlHelper MyUrl = Url;
            string My = HttpContext.Request.Scheme + "://" + HttpContext.Request.Host.ToString() + HttpContext.Request.Path + HttpContext.Request.QueryString;

            HttpContext.Session.SetString("InfosPage", My);
            SelectLists();
            Check();
            FilteredPage = HttpContext.Session.GetString("InfosPage");

            var infos = from m in _context.Info
                        select m;


            if (!string.IsNullOrEmpty(SearchKBID))
            {
                infos = infos.Where(s => s.KBID.Contains(SearchKBID));
            }

            if (!string.IsNullOrEmpty(SearchICW))
            {
                infos = infos.Where(s => s.ICW.Contains(SearchICW));
            }

            if (!string.IsNullOrEmpty(SelectedResult))
            {
                infos = infos.Where(x => x.TestResults == SelectedResult);
            }

            if (!string.IsNullOrEmpty(SelectedServer))
            {
                infos = infos.Where(x => x.Server == SelectedServer);
            }


            if (!string.IsNullOrEmpty(datefilter))
            {
                string start = datefilter.Split(" - ")[0];
                string end = datefilter.Split(" - ")[1];

                DateTime startDate = DateTime.ParseExact(start, "MM/dd/yyyy", null);
                DateTime endDate = DateTime.ParseExact(end, "MM/dd/yyyy", null);

                infos = infos.Where(d => d.TestDate >= startDate && d.TestDate <= endDate);
            }


            foreach (Info temp in _context.Info)
            {
                DateTime current = DateTime.Now;
                if (temp.TestDate <= current.AddMonths(-2))
                {
                    temp.Active = "No";
                    _context.Info.Update(temp);
                }
            }


            Info = await infos.ToListAsync();

            await _context.SaveChangesAsync();

        }

        public IActionResult OnPost() //Saves the update report as an Html page
        {
            IUrlHelper MyUrl = Url;
            string My = HttpContext.Request.Scheme + "://" + HttpContext.Request.Host.ToString() + HttpContext.Request.Path + HttpContext.Request.QueryString;

            string htmlCode;
            using (WebClient client = new WebClient())
            {
                htmlCode = client.DownloadString(My);
            }

            DateTime currentDate = DateTime.Now;
            string current = currentDate.ToString("MM-dd-yyyy");
            string currentServer = this.SelectedServer;
            if (currentServer == null)
            {
                currentServer = "All";
                htmlCode = NewHtmlCode(htmlCode, true);
            }
            else
                htmlCode = NewHtmlCode(htmlCode, false);



            string filename = "Update History Report for " + currentServer + " server (" + current + ").html";

            // Prompts user to save file
            HttpResponse response = HttpContext.Response;
            response.Clear();
            response.Headers[HeaderNames.ContentDisposition] = "attachment; filename=" + filename;//filename;
            response.WriteAsync(htmlCode.ToString()).Wait();

            return Redirect(My);
        }
        
        

        /*public IActionResult GetClear() //Saves the update report as an Html page
        {
            return Redirect("./Infos");
        }*/




        public void SelectLists()  //Generate the list of Servers, Test Results, and Active Status for filtering
        {
            IQueryable<string> ResultQuery = from m in _context.Info
                                             orderby m.TestResults
                                             select m.TestResults;

            IQueryable<string> ActiveQuery = from m in _context.Info
                                             orderby m.Active
                                             select m.Active;

            IQueryable<string> Query = from m in _context.Server
                                       orderby m.Index
                                       select m.ServerName;
            
            ResultList = new SelectList(ResultQuery.Distinct().ToList());

            ServerList = new SelectList(Query.Distinct().ToList());
        }

        public string NewHtmlCode(string code, bool serverNull)
        {
            string section = "<section id=\"All\" class=\"tab-panel\">"; //<section id="All" class="tab-panel">
            int start = code.IndexOf(section);
            start = start + section.Count();

            string stop = "`3`";
            int end = code.IndexOf(stop);
            int length = end - start;

            code = code.Substring(start, length);

            string servernameFull="All"; string ICW = "All"; string servername = "All"; string winver = ""; string realver = "";
            foreach(Server item in _context.Server)
            {
                if(item.ServerName == this.SelectedServer)
                {
                    servername = item.ServerName;
                    servernameFull = item.ServerName + " with " + item.RealtimeVersion;
                    ICW = item.ICW;
                    winver = item.WindowsVersion;
                    realver = item.RealtimeVersion;
                }
            }

            if (serverNull == false)
            {
                code = code.Replace("Server", "");
                code = code.Replace("ICW", "");
                while(code.Contains(servername))
                { code = code.Replace(servername, ""); }
                while(code.Contains(ICW))
                { code = code.Replace(ICW, ""); }
            }

            //string newcode = "<!DOCTYPE html>\n<html>\n<head>\n\t<meta charset=\"utf - 8\"/>\n\t<meta name=\"viewport\" content=\"width = device - width, initial - scale = 1.0\" />\n\t<title>Index - WuApp</title>\n\n\t<script src=\"https://code.jquery.com/jquery-3.1.1.min.js\" crossorigin=\"anonymous\"></script>\n\t<link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/semantic-ui@2.4.2/dist/semantic.min.css\">\n\t<script src=\"https://cdn.jsdelivr.net/npm/semantic-ui@2.4.2/dist/semantic.min.js\"></script>\n\n<style>\ntable, td, th{font-size: 105%;}\ntable {border-collapse: collapse; width: 100%;}\nth{text-align: left; padding: 8px; border-bottom: solid 1px; border-top: solid 1px;} \n td {text-align: left; padding: 8px;} \ntr:nth-child(even) {background-color: #f2f2f2;}\ndiv {padding-left:50px;padding-bottom:10px;}\n</style>\n\n</head>\n<body>\n\t<br><div class=\"filter\">\n<h2><u>Active Filters</u></h2><p><b>Test Results:</b>&nbsp;&nbsp;&nbsp;&nbsp;" + this.SelectedResult+ "</p>\n<p><b>Active:</b>&nbsp;&nbsp;&nbsp;&nbsp;" + this.SelectedActive + "</p>\n<p><b>KBID:</b>&nbsp;&nbsp;&nbsp;&nbsp;" + this.SearchKBID + "</p>\n<p><b>ICW:</b>&nbsp;&nbsp;&nbsp;&nbsp;" + this.SearchICW + "</p>\n<p><b>Server:</b>&nbsp;&nbsp;&nbsp;&nbsp;" + this.SelectedServer + "</p>\n<p><b>Date:</b>&nbsp;&nbsp;&nbsp;&nbsp;" + this.datefilter + "</p>\n</div><br><br>\n";
            string newcode = "<link href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css\" rel=\"stylesheet\">\n<style>\ntr>td:nth-child(5){\n\tmax-width: 350px;\n}\n.table td{\n\tmin-width:30px;\n}\n.table td:nth-child(4){word-wrap: break-word;max-width: 250px;}\n\n.table>tbody>tr.custom>td,.table>tbody>tr.custom>th,.table>tbody>tr>td.custom,.table>tbody>tr>th.custom,.table>tfoot>tr.custom>td,.table>tfoot>tr.custom>th,.table>tfoot>tr>td.custom,.table>tfoot>tr>th.custom,.table>thead>tr.custom>td,.table>thead>tr.custom>th,.table>thead>tr>td.custom,.table>thead>tr>th.custom{\n\tbackground-color:#F7F7F7;\n}\n\n.table-hover>tbody>tr.custom:hover>td,.table-hover>tbody>tr.custom:hover>th,.table-hover>tbody>tr:hover>.custom,.table-hover>tbody>tr>td.custom:hover,.table-hover>tbody>tr>th.custom:hover{\n\tbackground-color:#E2E2E2;\n}\n\ntr:hover {background-color: #e8e8e8;}\n</style>\n<h1>Windows Update Report</h1>\n<h3>Server: " + servername + "</h3>\n<h3>Windows Version: " + winver + "</h3>\n<h3>RealTime Version: " + realver + "</h3>\n<h3>ICW: " + ICW + "</h3><br>";
            newcode = newcode + code + "\n</body></html>";

            while(newcode.IndexOf("<a href=\"/Infos/") > 0)
            {
                int s = newcode.IndexOf("<a href=\"/Infos/");
                int e = newcode.IndexOf("</a>");
                e = e + 4;
                int l = e - s;
                string temp = newcode.Substring(s,l);
                newcode = newcode.Replace(temp, "");
            }
            
            return newcode;
        }

        public void Check()
        {

        }
    }
}
