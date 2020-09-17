using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UpdateHistory.Models;

namespace UpdateHistory.Pages.Servers
{
    public class EditModel : PageModel
    {
        private readonly UpdateHistory.Models.UpdateHistoryContext _context;

        public EditModel(UpdateHistory.Models.UpdateHistoryContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Server).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServerExists(Server.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ServerExists(int id)
        {
            return _context.Server.Any(e => e.ID == id);
        }
    }
}
