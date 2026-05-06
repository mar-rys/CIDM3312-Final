using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ColorGoGo.Models
{
    public class ColoringBook
    {
        public int ColoringBookID { get; set; }

        [Required]
        [StringLength(150)]
        public string ? BookTitle { get; set; }

        [Required]
        [Range(1, 100)]
        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }

        [StringLength(100)]
        public string ? Theme { get; set; }

        // Business Rule: Hide instead of delete
        public bool IsActive { get; set; } = true;

        // Foreign Key
        [Required]
        public int ArtistID { get; set; }

        // Navigation Properties
        public Artist ? Artist { get; set; }
        public ICollection<Order> ? Orders { get; set; }
    }
}