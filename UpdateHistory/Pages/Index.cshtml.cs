using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UpdateHistory.Pages
{
    public class IndexModel : PageModel
    {
        public static UpdateHistory.Models.UpdateHistoryContext _context;


        public IndexModel(UpdateHistory.Models.UpdateHistoryContext context)
        {
            _context = context;
        }
        


        public ActionResult OnGet()
        {
            
            return null;
        }
        
    }
}
