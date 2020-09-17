using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UpdateHistory.Models;

namespace UpdateHistory.Pages.Servers
{
    public class CreateModel : PageModel
    {
        private readonly UpdateHistory.Models.UpdateHistoryContext _context;

        public CreateModel(UpdateHistory.Models.UpdateHistoryContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public int count { get; set; }


        [BindProperty(SupportsGet = true)]
        public string NoAccessMsg { get; set; }

        public IActionResult OnGet()
        {
            count = _context.Server.Count()+1;
            return Page();
        }

        [BindProperty]
        public Server Server { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            HttpContext.Session.SetString("NoAccess", "");
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if(CheckServer.Check(Server))
            {
                HttpContext.Session.SetString("NoAccess", "You do not have access to this server");
                NoAccessMsg = HttpContext.Session.GetString("NoAccess");
                return null;
            }

            _context.Server.Add(Server);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}