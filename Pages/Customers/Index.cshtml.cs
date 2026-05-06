using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ColorGoGo.Models;

namespace CIDM3312_Final.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly ColorGoGoContext _context;

        public IndexModel(ColorGoGoContext context)
        {
            _context = context;
        }

        public IList<Customer> Customers { get; set; } = new List<Customer>();

        public async Task OnGetAsync()
        {
            Customers = await _context.Customers
                .Include(c => c.Orders)
                .OrderBy(c => c.CustomerName)
                .ToListAsync();
        }
    }
}