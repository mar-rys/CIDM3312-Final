using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ColorGoGo.Models;

namespace CIDM3312_Final.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly ColorGoGoContext _context;

        public IndexModel(ColorGoGoContext context)
        {
            _context = context;
        }

        public IList<Order> Orders { get; set; } = new List<Order>();

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SortOrder { get; set; }

        [BindProperty(SupportsGet = true)]
        public OrderStatus? StatusFilter { get; set; }

        public async Task OnGetAsync()
        {
            var ordersQuery = _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.ColoringBook)
                .AsQueryable();

           if (!string.IsNullOrWhiteSpace(SearchString))
{
    string search = SearchString.Trim().ToLower();

    ordersQuery = ordersQuery.Where(o =>
        (o.Customer != null &&
         o.Customer.CustomerName != null &&
         o.Customer.CustomerName.ToLower().Contains(search)) ||

        (o.ColoringBook != null &&
         o.ColoringBook.BookTitle != null &&
         o.ColoringBook.BookTitle.ToLower().Contains(search))
    );
}

            if (StatusFilter.HasValue)
            {
                ordersQuery = ordersQuery.Where(o => o.Status == StatusFilter.Value);
            }

            ordersQuery = SortOrder switch
            {
                "date_asc" => ordersQuery.OrderBy(o => o.OrderDate),
                "date_desc" => ordersQuery.OrderByDescending(o => o.OrderDate),
                "quantity_asc" => ordersQuery.OrderBy(o => o.Quantity),
                "quantity_desc" => ordersQuery.OrderByDescending(o => o.Quantity),
                "status_asc" => ordersQuery.OrderBy(o => o.Status),
                "status_desc" => ordersQuery.OrderByDescending(o => o.Status),
                "customer_asc" => ordersQuery.OrderBy(o => o.Customer != null ? o.Customer.CustomerName : ""),
                "customer_desc" => ordersQuery.OrderByDescending(o => o.Customer != null ? o.Customer.CustomerName : ""),
                "book_asc" => ordersQuery.OrderBy(o => o.ColoringBook != null ? o.ColoringBook.BookTitle : ""),
                "book_desc" => ordersQuery.OrderByDescending(o => o.ColoringBook != null ? o.ColoringBook.BookTitle : ""),
                _ => ordersQuery.OrderByDescending(o => o.OrderDate) // Default sort
            };

            Orders = await ordersQuery.ToListAsync();
        }
    }
}