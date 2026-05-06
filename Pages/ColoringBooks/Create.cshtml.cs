using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ColorGoGo.Models;

namespace CIDM3312_Final.Pages.ColoringBooks
{
    public class CreateModel : PageModel
    {
        private readonly ColorGoGo.Models.ColorGoGoContext _context;

        public CreateModel(ColorGoGoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["ArtistID"] = new SelectList(_context.Artists, "ArtistID", "ArtistName");
            return Page();
        }

        [BindProperty]
        public ColoringBook ColoringBook { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["ArtistID"] = new SelectList(_context.Artists, "ArtistID", "ArtistName");
                return Page();
            }

            _context.ColoringBooks.Add(ColoringBook);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}