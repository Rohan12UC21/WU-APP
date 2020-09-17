using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UpdateHistory.Models;

namespace UpdateHistory.Pages.Servers
{
    public class DeleteModel : PageModel
    {
        private readonly UpdateHistory.Models.UpdateHistoryContext _context;

        public DeleteModel(UpdateHistory.Models.UpdateHistoryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Server Server { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Server = await _context.Server.FirstOrDefaultAsync(m => m.ID == id);

            if (Server == null)
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

            Server = await _context.Server.FindAsync(id);

            if (Server != null)
            {
                _context.Server.Remove(Server);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
