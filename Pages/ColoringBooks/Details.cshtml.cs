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
    public class DetailsModel : PageModel
    {
        private readonly ColorGoGo.Models.ColorGoGoContext _context;

        public DetailsModel(ColorGoGo.Models.ColorGoGoContext context)
        {
            _context = context;
        }

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
    }
}
