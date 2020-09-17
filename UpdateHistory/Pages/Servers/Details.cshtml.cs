using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UpdateHistory.Models;

namespace UpdateHistory.Pages.Servers
{
    public class DetailsModel : PageModel
    {
        private readonly UpdateHistory.Models.UpdateHistoryContext _context;

        public DetailsModel(UpdateHistory.Models.UpdateHistoryContext context)
        {
            _context = context;
        }

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
    }
}
