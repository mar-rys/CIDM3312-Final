using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColorGoGo.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }

        [Required]
        [StringLength(100)]
        public string ? ArtistName { get; set; }

        [Required]
        [EmailAddress]
        public string ? Email { get; set; }

        [StringLength(500)]
        public string ? Bio { get; set; }

        // Navigation Property
        public ICollection<ColoringBook> ? ColoringBooks { get; set; }
    }
}