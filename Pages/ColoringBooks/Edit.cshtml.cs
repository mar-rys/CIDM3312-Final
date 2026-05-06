using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ColorGoGo.Models;

namespace CIDM3312_Final.Pages.ColoringBooks
{
    public class EditModel : PageModel
    {
        private readonly ColorGoGo.Models.ColorGoGoContext _context;

        public EditModel(ColorGoGo.Models.ColorGoGoContext context)
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

            var coloringbook =  await _context.ColoringBooks.FirstOrDefaultAsync(m => m.ColoringBookID == id);
            if (coloringbook == null)
            {
                return NotFound();
            }
            ColoringBook = coloringbook;
           ViewData["ArtistID"] = new SelectList(_context.Artists, "ArtistID", "ArtistName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ColoringBook).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ColoringBookExists(ColoringBook.ColoringBookID))
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

        private bool ColoringBookExists(int id)
        {
            return _context.ColoringBooks.Any(e => e.ColoringBookID == id);
        }
    }
}
