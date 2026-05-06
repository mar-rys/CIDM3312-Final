using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ColorGoGo.Models;

namespace CIDM3312_Final.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly ColorGoGoContext _context;

        public DetailsModel(ColorGoGoContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var customer = await _context.Customers
                .Include(c => c.Orders)
                    .ThenInclude(o => o.ColoringBook)
                .FirstOrDefaultAsync(c => c.CustomerID == id);

            if (customer == null)
            {
                return NotFound();
            }

            Customer = customer;
            return Page();
        }
    }
}