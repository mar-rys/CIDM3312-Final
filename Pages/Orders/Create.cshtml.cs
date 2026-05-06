using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ColorGoGo.Models;

namespace CIDM3312_Final.Pages.Orders
{
    public class CreateModel : PageModel
    {
        private readonly ColorGoGoContext _context;

        public CreateModel(ColorGoGoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Order Order { get; set; } = new Order();

        public IActionResult OnGet()
        {
            LoadDropdowns();
            Order.OrderDate = DateTime.Today;
            Order.Status = OrderStatus.Pending;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (Order.OrderDate > DateTime.Today)
            {
                ModelState.AddModelError("Order.OrderDate", "Order date cannot be in the future.");
            }

            if (!ModelState.IsValid)
            {
                LoadDropdowns();
                return Page();
            }

            _context.Orders.Add(Order);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }

        private void LoadDropdowns()
        {
            ViewData["CustomerID"] = new SelectList(_context.Customers, "CustomerID", "CustomerName");
            ViewData["ColoringBookID"] = new SelectList(
                _context.ColoringBooks.Where(b => b.IsActive),
                "ColoringBookID",
                "BookTitle"
            );
        }
    }
}