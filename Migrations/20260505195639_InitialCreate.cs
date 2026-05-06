using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CIDM3312_Final.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArtistName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Bio = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerName = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "ColoringBooks",
                columns: table => new
                {
                    ColoringBookID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookTitle = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Theme = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    ArtistID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColoringBooks", x => x.ColoringBookID);
                    table.ForeignKey(
                        name: "FK_ColoringBooks_Artists_ArtistID",
                        column: x => x.ArtistID,
                        principalTable: "Artists",
                        principalColumn: "ArtistID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    ColoringBookID = table.Column<int>(type: "INTEGER", nullable: false),
                    CustomerID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_ColoringBooks_ColoringBookID",
                        column: x => x.ColoringBookID,
                        principalTable: "ColoringBooks",
                        principalColumn: "ColoringBookID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistID", "ArtistName", "Bio", "Email" },
                values: new object[,]
                {
                    { 1, "Luna Martinez", "Specializes in floral and botanical illustrations.", "luna@colorgogo.com" },
                    { 2, "Marcus Reed", "Creates fantasy and dragon-themed artwork.", "marcus@colorgogo.com" },
                    { 3, "Ava Thompson", "Designs minimalist and geometric patterns.", "ava@colorgogo.com" },
                    { 4, "Noah Bennett", "Focuses on wildlife and nature scenes.", "noah@colorgogo.com" },
                    { 5, "Sophia Kim", "Creates mandala and meditation art.", "sophia@colorgogo.com" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "CustomerName" },
                values: new object[,]
                {
                    { 1, "123 Maple St, Austin, TX", "Alice Monroe" },
                    { 2, "456 Oak Ave, Denver, CO", "Ben Carter" },
                    { 3, "789 Pine Rd, Seattle, WA", "Clara Nguyen" },
                    { 4, "321 Birch Blvd, Chicago, IL", "David Kim" },
                    { 5, "654 Cedar Ln, Miami, FL", "Eva Rossi" }
                });

            migrationBuilder.InsertData(
                table: "ColoringBooks",
                columns: new[] { "ColoringBookID", "ArtistID", "BookTitle", "IsActive", "Price", "Theme" },
                values: new object[,]
                {
                    { 1, 1, "Blooming Gardens", true, 12.99m, "Floral" },
                    { 2, 1, "Wildflowers Collection", true, 14.99m, "Floral" },
                    { 3, 1, "Botanical Bliss", true, 11.99m, "Plants" },
                    { 4, 1, "Garden Escape", true, 13.50m, "Nature" },
                    { 5, 1, "Petal Patterns", true, 10.99m, "Patterns" },
                    { 6, 2, "Dragon Realms", true, 15.99m, "Fantasy" },
                    { 7, 2, "Mystic Creatures", true, 16.99m, "Fantasy" },
                    { 8, 2, "Knight Adventures", true, 13.99m, "Medieval" },
                    { 9, 2, "Legends & Lore", true, 17.50m, "Fantasy" },
                    { 10, 2, "Mythical Worlds", true, 18.99m, "Fantasy" },
                    { 11, 3, "GeoShapes", true, 9.99m, "Geometric" },
                    { 12, 3, "Modern Lines", true, 10.50m, "Minimalist" },
                    { 13, 3, "Abstract Forms", true, 12.00m, "Abstract" },
                    { 14, 3, "Symmetry Art", true, 11.25m, "Patterns" },
                    { 15, 3, "Line Harmony", true, 9.50m, "Minimalist" },
                    { 16, 4, "Forest Friends", true, 14.99m, "Wildlife" },
                    { 17, 4, "Ocean Wonders", true, 15.49m, "Sea Life" },
                    { 18, 4, "Safari Adventure", true, 16.25m, "Animals" },
                    { 19, 4, "Mountain Majesty", true, 13.75m, "Nature" },
                    { 20, 4, "Bird Paradise", true, 12.49m, "Birds" },
                    { 21, 5, "Mandala Calm", true, 11.99m, "Mandala" },
                    { 22, 5, "Zen Circles", true, 10.99m, "Meditation" },
                    { 23, 5, "Inner Peace Patterns", true, 12.75m, "Mandala" },
                    { 24, 5, "Sacred Geometry", true, 14.25m, "Spiritual" },
                    { 25, 5, "Tranquil Designs", true, 13.00m, "Meditation" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "ColoringBookID", "CustomerID", "OrderDate", "Quantity", "Status" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0 },
                    { 2, 6, 2, new DateTime(2026, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 3, 11, 3, new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 4, 16, 4, new DateTime(2026, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 5, 21, 5, new DateTime(2026, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 0 },
                    { 6, 2, 1, new DateTime(2026, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 7, 7, 2, new DateTime(2026, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 8, 12, 3, new DateTime(2026, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ColoringBooks_ArtistID",
                table: "ColoringBooks",
                column: "ArtistID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ColoringBookID",
                table: "Orders",
                column: "ColoringBookID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ColoringBooks");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
