using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ColorGoGo.Models;

public class Customer
{
    public int CustomerID { get; set; }

    [Required, StringLength(150, MinimumLength = 2)]
    [Display(Name = "Customer Name")]
    public string CustomerName { get; set; } = string.Empty;

    [Required, StringLength(300)]
    public string Address { get; set; } = string.Empty;

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}