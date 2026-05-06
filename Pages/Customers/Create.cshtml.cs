using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ColorGoGo.Models;

namespace CIDM3312_Final.Pages.Customers
{
    public class CreateModel : PageModel
    {
        private readonly ColorGoGoContext _context;

        public CreateModel(ColorGoGoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Customer Customer { get; set; } = new Customer();

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customers.Add(Customer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}