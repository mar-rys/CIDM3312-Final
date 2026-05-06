using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ColorGoGo.Models;

namespace CIDM3312_Final.Pages.ColoringBooks
{
    public class DeleteModel : PageModel
    {
        private readonly ColorGoGo.Models.ColorGoGoContext _context;

        public DeleteModel(ColorGoGo.Models.ColorGoGoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ColoringBook ColoringBook { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coloringbook = await _context.ColoringBooks.FirstOrDefaultAsync(m => m.ColoringBookID == id);

            if (coloringbook is not null)
            {
                ColoringBook = coloringbook;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coloringbook = await _context.ColoringBooks.FindAsync(id);
            if (coloringbook != null)
            {
                ColoringBook = coloringbook;
                _context.ColoringBooks.Remove(ColoringBook);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
