using System.ComponentModel.DataAnnotations;

namespace ColorGoGo.Models;

public class Order
{
    public int OrderID { get; set; }

    [Required]
    [DataType(DataType.Date)]
    [Display(Name = "Order Date")]
    [NotInFuture]
    public DateTime OrderDate { get; set; } = DateTime.Today;

    [Required]
    public OrderStatus Status { get; set; } = OrderStatus.Pending;

    [Required, Range(1, 30, ErrorMessage = "Quantity must be between 1 and 30.")]
    public int Quantity { get; set; }

    [Required]
    [Display(Name = "Coloring Book")]
    public int ColoringBookID { get; set; }
    public ColoringBook? ColoringBook { get; set; }

    [Required]
    public int CustomerID { get; set; }
    public Customer? Customer { get; set; }
}
public enum OrderStatus
{
    Pending,
    Printing,
    Shipped,
    Delivered
}
public class NotInFutureAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext ctx)
    {
        if (value is DateTime date && date.Date > DateTime.Today)
            return new ValidationResult("Order date cannot be in the future.");
        return ValidationResult.Success;
    }
}