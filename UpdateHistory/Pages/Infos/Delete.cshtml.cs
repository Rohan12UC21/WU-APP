using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UpdateHistory.Models;

namespace UpdateHistory.Pages.Infos
{
    public class DeleteModel : PageModel
    {
        private readonly UpdateHistory.Models.UpdateHistoryContext _context;

        [BindProperty(SupportsGet = true)]
        public string InfosPage { get; set; }

        public DeleteModel(UpdateHistory.Models.UpdateHistoryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Info Info { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            InfosPage = HttpContext.Session.GetString("InfosPage");

            if (id == null)
            {
                return NotFound();
            }

            Info = await _context.Info.FirstOrDefaultAsync(m => m.ID == id);

            if (Info == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Info = await _context.Info.FindAsync(id);

            if (Info != null)
            {
                _context.Info.Remove(Info);
                await _context.SaveChangesAsync();
            }

            string sessionv = HttpContext.Session.GetString("InfosPage");
            return Redirect(sessionv);
        }
    }
}
