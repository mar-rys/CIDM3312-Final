using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ColorGoGo.Models;

namespace CIDM3312_Final.Pages.Orders
{
    public class EditModel : PageModel
    {
        private readonly ColorGoGoContext _context;

        public EditModel(ColorGoGoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Order Order { get; set; } = default!;

        private OrderStatus OriginalStatus { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            Order = order;
            LoadDropdowns();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var existingOrder = await _context.Orders
                .AsNoTracking()
                .FirstOrDefaultAsync(o => o.OrderID == Order.OrderID);

            if (existingOrder == null)
            {
                return NotFound();
            }

            if (Order.OrderDate > DateTime.Today)
            {
                ModelState.AddModelError("Order.OrderDate", "Order date cannot be in the future.");
            }

            if (Order.Status < existingOrder.Status)
            {
                ModelState.AddModelError("Order.Status", "Order status can only move forward.");
            }

            if (!ModelState.IsValid)
            {
                LoadDropdowns();
                return Page();
            }

            _context.Attach(Order).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }

        private void LoadDropdowns()
        {
            ViewData["CustomerID"] = new SelectList(_context.Customers, "CustomerID", "CustomerName");
            ViewData["ColoringBookID"] = new SelectList(_context.ColoringBooks, "ColoringBookID", "BookTitle");
        }
    }
}