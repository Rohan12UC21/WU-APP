using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UpdateHistory.Models;
using Microsoft.AspNetCore.Http;

namespace UpdateHistory.Pages.Infos
{
    public class EditModel : PageModel
    {
        private readonly UpdateHistory.Models.UpdateHistoryContext _context;

        public EditModel(UpdateHistory.Models.UpdateHistoryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Info Info { get; set; }

        [BindProperty]
        public string DateEdit { get; set; }



        public SelectList ResultList { get; set; }

        [BindProperty(SupportsGet = true)]
        public string InfosPage { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Info tempInfo = new Info();
            foreach(Info item in _context.Info.Where(m => m.ID==id))
            {
                tempInfo = item;
                break;
            }

            DateEdit = tempInfo.TestDate.ToString("MM/dd/yyyy");

            InfosPage = HttpContext.Session.GetString("InfosPage");

            IQueryable<string> Query = from m in _context.Info
                                       select m.TestResults;

            IQueryable<string> Query2 = from m in _context.Info
                                       select m.Active;

            if (id == null)
            {
                return NotFound();
            }

            Info = await _context.Info.FirstOrDefaultAsync(m => m.ID == id);

            if (Info == null)
            {
                return NotFound();
            }

            ResultList = new SelectList(Query.Distinct().ToList());


            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Info.TestDate = DateTime.ParseExact(DateEdit, "MM/dd/yyyy", null);
            
            _context.Attach(Info).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InfoExists(Info.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            string sessionv = HttpContext.Session.GetString("InfosPage");

            return Redirect(sessionv);
        }

        private bool InfoExists(int id)
        {
            return _context.Info.Any(e => e.ID == id);
        }
    }
}
