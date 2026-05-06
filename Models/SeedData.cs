using ColorGoGo.Models;

namespace ColorGoGo.Models;

public static class SeedData
{
    public static readonly Artist[] Artists =
    [
        new Artist { ArtistID = 1, ArtistName = "Luna Martinez", Email = "luna@colorgogo.com", Bio = "Specializes in floral and botanical illustrations." },
        new Artist { ArtistID = 2, ArtistName = "Marcus Reed", Email = "marcus@colorgogo.com", Bio = "Creates fantasy and dragon-themed artwork." },
        new Artist { ArtistID = 3, ArtistName = "Ava Thompson", Email = "ava@colorgogo.com", Bio = "Designs minimalist and geometric patterns." },
        new Artist { ArtistID = 4, ArtistName = "Noah Bennett", Email = "noah@colorgogo.com", Bio = "Focuses on wildlife and nature scenes." },
        new Artist { ArtistID = 5, ArtistName = "Sophia Kim", Email = "sophia@colorgogo.com", Bio = "Creates mandala and meditation art." }
    ];

    public static readonly ColoringBook[] ColoringBooks =
    [
        // Artist 1
        new ColoringBook { ColoringBookID = 1, BookTitle = "Blooming Gardens", Price = 12.99m, Theme = "Floral", ArtistID = 1, IsActive = true },
        new ColoringBook { ColoringBookID = 2, BookTitle = "Wildflowers Collection", Price = 14.99m, Theme = "Floral", ArtistID = 1, IsActive = true },
        new ColoringBook { ColoringBookID = 3, BookTitle = "Botanical Bliss", Price = 11.99m, Theme = "Plants", ArtistID = 1, IsActive = true },
        new ColoringBook { ColoringBookID = 4, BookTitle = "Garden Escape", Price = 13.50m, Theme = "Nature", ArtistID = 1, IsActive = true },
        new ColoringBook { ColoringBookID = 5, BookTitle = "Petal Patterns", Price = 10.99m, Theme = "Patterns", ArtistID = 1, IsActive = true },
        new ColoringBook { ColoringBookID = 26, BookTitle = "Floral Fantasy", Price = 15.99m, Theme = "Floral", ArtistID = 1, IsActive = true },
        new ColoringBook { ColoringBookID = 27, BookTitle = "Botanical Dreams", Price = 14.50m, Theme = "Plants", ArtistID = 1, IsActive = true },
        new ColoringBook { ColoringBookID = 28, BookTitle = "Garden Serenity", Price = 13.75m, Theme = "Nature", ArtistID = 1, IsActive = true },
        new ColoringBook { ColoringBookID = 29, BookTitle = "Petal Power", Price = 12.25m, Theme = "Patterns", ArtistID = 1, IsActive = true },
        new ColoringBook { ColoringBookID = 30, BookTitle = "Floral Whimsy", Price = 11.50m, Theme = "Floral", ArtistID = 1, IsActive = true },


        // Artist 2
        new ColoringBook { ColoringBookID = 6, BookTitle = "Dragon Realms", Price = 15.99m, Theme = "Fantasy", ArtistID = 2, IsActive = true },
        new ColoringBook { ColoringBookID = 7, BookTitle = "Mystic Creatures", Price = 16.99m, Theme = "Fantasy", ArtistID = 2, IsActive = true },
        new ColoringBook { ColoringBookID = 8, BookTitle = "Knight Adventures", Price = 13.99m, Theme = "Medieval", ArtistID = 2, IsActive = true },
        new ColoringBook { ColoringBookID = 9, BookTitle = "Legends & Lore", Price = 17.50m, Theme = "Fantasy", ArtistID = 2, IsActive = true },
        new ColoringBook { ColoringBookID = 10, BookTitle = "Mythical Worlds", Price = 18.99m, Theme = "Fantasy", ArtistID = 2, IsActive = true },
        new ColoringBook { ColoringBookID = 31, BookTitle = "Dragon Dreams", Price = 16.50m, Theme = "Fantasy", ArtistID = 2, IsActive = true },
        new ColoringBook { ColoringBookID = 32, BookTitle = "Mystic Beasts", Price = 17.25m, Theme = "Fantasy", ArtistID = 2, IsActive = true },
        new ColoringBook { ColoringBookID = 33, BookTitle = "Knight's Quest", Price = 14.75m, Theme = "Medieval", ArtistID = 2, IsActive = true },
        new ColoringBook { ColoringBookID = 34, BookTitle = "Legends Unleashed", Price = 18.50m, Theme = "Fantasy", ArtistID = 2, IsActive = true },
        new ColoringBook { ColoringBookID = 35, BookTitle = "Mythical Realms", Price = 19.99m, Theme = "Fantasy", ArtistID = 2, IsActive = true },

        // Artist 3
        new ColoringBook { ColoringBookID = 11, BookTitle = "GeoShapes", Price = 9.99m, Theme = "Geometric", ArtistID = 3, IsActive = true },
        new ColoringBook { ColoringBookID = 12, BookTitle = "Modern Lines", Price = 10.50m, Theme = "Minimalist", ArtistID = 3, IsActive = true },
        new ColoringBook { ColoringBookID = 13, BookTitle = "Abstract Forms", Price = 12.00m, Theme = "Abstract", ArtistID = 3, IsActive = true },
        new ColoringBook { ColoringBookID = 14, BookTitle = "Symmetry Art", Price = 11.25m, Theme = "Patterns", ArtistID = 3, IsActive = true },
        new ColoringBook { ColoringBookID = 15, BookTitle = "Line Harmony", Price = 9.50m, Theme = "Minimalist", ArtistID = 3, IsActive = true },
        new ColoringBook { ColoringBookID = 36, BookTitle = "GeoPatterns", Price = 10.99m, Theme = "Geometric", ArtistID = 3, IsActive = true },
        new ColoringBook { ColoringBookID = 37, BookTitle = "Modern Artistry", Price = 11.75m, Theme = "Minimalist", ArtistID = 3, IsActive = true },
        new ColoringBook { ColoringBookID = 38, BookTitle = "Abstract Wonders", Price = 13.50m, Theme = "Abstract", ArtistID = 3, IsActive = true },
        new ColoringBook { ColoringBookID = 39, BookTitle = "Symmetry Magic", Price = 12.25m, Theme = "Patterns", ArtistID = 3, IsActive = true },
        new ColoringBook { ColoringBookID = 40, BookTitle = "Line Artistry", Price = 10.75m, Theme = "Minimalist", ArtistID = 3, IsActive = true },


        // Artist 4
        new ColoringBook { ColoringBookID = 16, BookTitle = "Forest Friends", Price = 14.99m, Theme = "Wildlife", ArtistID = 4, IsActive = true },
        new ColoringBook { ColoringBookID = 17, BookTitle = "Ocean Wonders", Price = 15.49m, Theme = "Sea Life", ArtistID = 4, IsActive = true },
        new ColoringBook { ColoringBookID = 18, BookTitle = "Safari Adventure", Price = 16.25m, Theme = "Animals", ArtistID = 4, IsActive = true },
        new ColoringBook { ColoringBookID = 19, BookTitle = "Mountain Majesty", Price = 13.75m, Theme = "Nature", ArtistID = 4, IsActive = true },
        new ColoringBook { ColoringBookID = 20, BookTitle = "Bird Paradise", Price = 12.49m, Theme = "Birds", ArtistID = 4, IsActive = true },
        new ColoringBook { ColoringBookID = 41, BookTitle = "Forest Magic", Price = 15.99m, Theme = "Wildlife", ArtistID = 4, IsActive = true },
        new ColoringBook { ColoringBookID = 42, BookTitle = "Ocean Mysteries", Price = 16.75m, Theme = "Sea Life", ArtistID = 4, IsActive = true },
        new ColoringBook { ColoringBookID = 43, BookTitle = "Safari Wonders", Price = 17.50m, Theme = "Animals", ArtistID = 4, IsActive = true },
        new ColoringBook { ColoringBookID = 44, BookTitle = "Mountain Magic", Price = 14.25m, Theme = "Nature", ArtistID = 4, IsActive = true },
        new ColoringBook { ColoringBookID = 45, BookTitle = "Birds of Paradise", Price = 13.99m, Theme = "Birds", ArtistID = 4, IsActive = true },

        // Artist 5
        new ColoringBook { ColoringBookID = 21, BookTitle = "Mandala Calm", Price = 11.99m, Theme = "Mandala", ArtistID = 5, IsActive = true },
        new ColoringBook { ColoringBookID = 22, BookTitle = "Zen Circles", Price = 10.99m, Theme = "Meditation", ArtistID = 5, IsActive = true },
        new ColoringBook { ColoringBookID = 23, BookTitle = "Inner Peace Patterns", Price = 12.75m, Theme = "Mandala", ArtistID = 5, IsActive = true },
        new ColoringBook { ColoringBookID = 24, BookTitle = "Sacred Geometry", Price = 14.25m, Theme = "Spiritual", ArtistID = 5, IsActive = true },
        new ColoringBook { ColoringBookID = 25, BookTitle = "Tranquil Designs", Price = 13.00m, Theme = "Meditation", ArtistID = 5, IsActive = true },
        new ColoringBook { ColoringBookID = 46, BookTitle = "Mandala Magic", Price = 12.99m, Theme = "Mandala", ArtistID = 5, IsActive = true },
        new ColoringBook { ColoringBookID = 47, BookTitle = "Zen Patterns", Price = 11.50m, Theme = "Meditation", ArtistID = 5, IsActive = true },
        new ColoringBook { ColoringBookID = 48, BookTitle = "Inner Peace Mandalas", Price = 13.75m, Theme = "Mandala", ArtistID = 5, IsActive = true },
        new ColoringBook { ColoringBookID = 49, BookTitle = "Sacred Geometry Designs", Price = 15.25m, Theme = "Spiritual", ArtistID = 5, IsActive = true },
        new ColoringBook { ColoringBookID = 50, BookTitle = "Tranquil Mandalas", Price = 14.00m, Theme = "Meditation", ArtistID = 5, IsActive = true }
    ];

    public static readonly Customer[] Customers =
    [
        new() { CustomerID = 1, CustomerName = "Alice Monroe",   Address = "123 Maple St, Austin, TX" },
        new() { CustomerID = 2, CustomerName = "Ben Carter",     Address = "456 Oak Ave, Denver, CO" },
        new() { CustomerID = 3, CustomerName = "Clara Nguyen",   Address = "789 Pine Rd, Seattle, WA" },
        new() { CustomerID = 4, CustomerName = "David Kim",      Address = "321 Birch Blvd, Chicago, IL" },
        new() { CustomerID = 5, CustomerName = "Eva Rossi",      Address = "654 Cedar Ln, Miami, FL" },
    ];

    public static readonly Order[] Orders =
[
        new Order { OrderID = 1, OrderDate = new DateTime(2026, 3, 1), Quantity = 2, Status = OrderStatus.Pending, ColoringBookID = 1, CustomerID = 1 },
        new Order { OrderID = 2, OrderDate = new DateTime(2026, 3, 5), Quantity = 1, Status = OrderStatus.Printing, ColoringBookID = 6, CustomerID = 2 },
        new Order { OrderID = 3, OrderDate = new DateTime(2026, 3, 10), Quantity = 5, Status = OrderStatus.Shipped, ColoringBookID = 11, CustomerID = 3 },
        new Order { OrderID = 4, OrderDate = new DateTime(2026, 3, 15), Quantity = 3, Status = OrderStatus.Delivered, ColoringBookID = 16, CustomerID = 4 },
        new Order { OrderID = 5, OrderDate = new DateTime(2026, 3, 20), Quantity = 4, Status = OrderStatus.Pending, ColoringBookID = 21, CustomerID = 5 },
        new Order { OrderID = 6, OrderDate = new DateTime(2026, 3, 22), Quantity = 2, Status = OrderStatus.Printing, ColoringBookID = 2, CustomerID = 1 },
        new Order { OrderID = 7, OrderDate = new DateTime(2026, 3, 25), Quantity = 1, Status = OrderStatus.Shipped, ColoringBookID = 7, CustomerID = 2 },
        new Order { OrderID = 8, OrderDate = new DateTime(2026, 3, 28), Quantity = 6, Status = OrderStatus.Pending, ColoringBookID = 12, CustomerID = 3 }
];
}