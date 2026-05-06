using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ColorGoGo.Models;

namespace ColorGoGo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ColorGoGoContext _context;

        public IndexModel(ColorGoGoContext context)
        {
            _context = context;
        }

        public IList<Artist> Artists { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Artists = await _context.Artists
                .Include(a => a.ColoringBooks)
                .ToListAsync();
        }
    }
}