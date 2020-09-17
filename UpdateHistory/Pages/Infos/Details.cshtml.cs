using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UpdateHistory.Models;

namespace UpdateHistory.Pages.Infos
{
    public class DetailsModel : PageModel
    {
        private readonly UpdateHistory.Models.UpdateHistoryContext _context;

        public DetailsModel(UpdateHistory.Models.UpdateHistoryContext context)
        {
            _context = context;
        }

        public Info Info { get; set; }

        [BindProperty(SupportsGet = true)]
        public string InfosPage { get; set; }

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
    }
}
