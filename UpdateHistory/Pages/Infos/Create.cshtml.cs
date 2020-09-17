using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UpdateHistory.Models;

namespace UpdateHistory.Pages.Infos
{
    public class CreateModel : PageModel
    {
        private readonly UpdateHistory.Models.UpdateHistoryContext _context;

        [BindProperty(SupportsGet = true)]
        public string InfosPage { get; set; }

        public CreateModel(UpdateHistory.Models.UpdateHistoryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            InfosPage = HttpContext.Session.GetString("InfosPage");
            return Page();
        }

        [BindProperty]
        public Info Info { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Info.Add(Info);
            await _context.SaveChangesAsync();

            string sessionv = HttpContext.Session.GetString("InfosPage");
            return Redirect(sessionv);
        }
    }
}