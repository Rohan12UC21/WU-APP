using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using UpdateHistory.Models;

namespace UpdateHistory.Pages.Servers
{
    public class IndexModel : PageModel
    {
        private readonly UpdateHistory.Models.UpdateHistoryContext _context;

        public IndexModel(UpdateHistory.Models.UpdateHistoryContext context)
        {
            _context = context;
        }
        

        [BindProperty(SupportsGet = true)]
        public List<bool> isItTho { get; set; }


        public SelectList ServerList { get; set; }


        [BindProperty(SupportsGet = true)]
        public List<string> SelectedServers { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Error { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool ErrorOccured { get; set; }
        


        public IList<Server> Server { get; set; }

        public async Task OnGetAsync()
        {

            HttpContext.Session.SetString("NoAccess", "");

            int count = 1;
            foreach (Server item in _context.Server)
            {
                isItTho.Add(false);
                if(item.Index != count)
                {
                    item.Index = count;
                }
                count++;
            }
            _context.SaveChanges();

            IQueryable<string> Query = from m in _context.Server
                                       orderby m.Index
                                       select m.ServerName;

            ServerList = new SelectList(Query.Distinct().ToList());

            Server = await _context.Server.ToListAsync();

        }
        
        public IActionResult OnPost() //Extracts update history from all selected servers, populates the Info Table and redirects to the Reports page
        {
            Server = _context.Server.ToList();

            if (!ModelState.IsValid)
            {
                return Page();
            }


            int count = 0;
            foreach (bool check in isItTho)
            {
                if (check == true)
                    count++;
            }

            
            var host = CreateWebHostBuilder().Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var context = services.
                        GetRequiredService<UpdateHistoryContext>();
                    context.Database.Migrate();
                    SeedData.Initialize(services, isItTho);
                }
                catch (Exception ex)
                {
                    string error = ex.ToString();
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                    HttpContext.Session.SetString("Error", error);
                    Error = HttpContext.Session.GetString("Error");
                    ErrorOccured = true;
                    return Redirect("/Servers");
                    //return Redirect("/Error");
                }
            }

            if(count==1)
            {
                count = 0;
                string path = "";
                foreach(Server item in _context.Server)
                {
                    if(isItTho[count]==true)
                    {
                        string servername = item.ServerName;
                        servername = servername.Replace(" ","+");
                        path = "http://wuappdev.intelligrated.com/Infos?SelectedResult=&SearchKBID=&datefilter=&SearchICW=&SelectedServer=" + servername; //http://wcbuildapp02.intellig.local:44373/Infos?SelectedResult=&SearchKBID=&datefilter=&SearchICW=&SelectedServer=   https://localhost:44334/Infos?SelectedResult=&SearchKBID=&datefilter=&SearchICW=&SelectedServer=   http://wuappdev.intelligrated.com/Infos?SelectedResult=&SearchKBID=&datefilter=&SearchICW=&SelectedServer=
                        break;
                    }
                    count++;
                }
                return Redirect(path);
            }
            if(count==0)
            {
                return Redirect("/Servers");
            }
            return Redirect("/Infos");

            
        }

        public IActionResult OnPostRefresh()
        {
            var host = CreateWebHostBuilder().Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                CheckServer.Initialize(services);
            }
            return Redirect("./Servers");
        }

        public IActionResult OnPostCreate()
        {
            return Redirect("./Servers/Create");
        }

        public static IWebHostBuilder CreateWebHostBuilder() =>
            WebHost.CreateDefaultBuilder()
                .UseStartup<Startup>();

    }
}
