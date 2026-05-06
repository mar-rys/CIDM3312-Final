using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ColorGoGo.Models;

namespace CIDM3312_Final.Pages.ColoringBooks
{
    public class IndexModel : PageModel
    {
        private readonly ColorGoGoContext _context;

        public IndexModel(ColorGoGoContext context)
        {
            _context = context;
        }

        public IList<ColoringBook> ColoringBook { get; set; } = new List<ColoringBook>();

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SortOrder { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? ArtistId { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool ShowInactive { get; set; }

        [BindProperty(SupportsGet = true)]
        public int PageIndex { get; set; } = 1;

        public int TotalPages { get; set; }

        public bool HasPreviousPage => PageIndex > 1;

        public bool HasNextPage => PageIndex < TotalPages;

        public async Task OnGetAsync()
        {
            int pageSize = 10;


            var booksQuery = _context.ColoringBooks
                .Include(c => c.Artist)
                .AsQueryable();

            // If ShowInactive is checked, show only inactive books. Otherwise, show only active books.
            if (ShowInactive)
            {
                booksQuery = booksQuery.Where(c => !c.IsActive);
            }
            else
            {
                booksQuery = booksQuery.Where(c => c.IsActive);
            }

            if (ArtistId.HasValue)
            {
                booksQuery = booksQuery.Where(c => c.ArtistID == ArtistId.Value);
            }

            if (!string.IsNullOrWhiteSpace(SearchString))
            {
                var search = SearchString.Trim().ToLower();

                booksQuery = booksQuery.Where(c =>
                    (c.BookTitle != null && c.BookTitle.ToLower().Contains(search)) ||
                    (c.Theme != null && c.Theme.ToLower().Contains(search)) ||
                    (c.Artist != null && c.Artist.ArtistName != null && c.Artist.ArtistName.ToLower().Contains(search))
                );
            }

            booksQuery = SortOrder switch
            {
                "title_desc" => booksQuery.OrderByDescending(c => c.BookTitle),
                "price_asc" => booksQuery.OrderBy(c => c.Price),
                "price_desc" => booksQuery.OrderByDescending(c => c.Price),
                "theme_asc" => booksQuery.OrderBy(c => c.Theme),
                "theme_desc" => booksQuery.OrderByDescending(c => c.Theme),
                "artist_asc" => booksQuery.OrderBy(c => c.Artist!.ArtistName),
                "artist_desc" => booksQuery.OrderByDescending(c => c.Artist!.ArtistName),
                _ => booksQuery.OrderBy(c => c.BookTitle)
            };

            int totalRecords = await booksQuery.CountAsync();
            TotalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);

            if (PageIndex < 1)
            {
                PageIndex = 1;
            }

            if (TotalPages > 0 && PageIndex > TotalPages)
            {
                PageIndex = TotalPages;
            }

            ColoringBook = await booksQuery
                .Skip((PageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }
    }
}