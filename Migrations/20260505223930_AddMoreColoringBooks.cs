using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CIDM3312_Final.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreColoringBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ColoringBooks",
                columns: new[] { "ColoringBookID", "ArtistID", "BookTitle", "IsActive", "Price", "Theme" },
                values: new object[,]
                {
                    { 26, 1, "Floral Fantasy", true, 15.99m, "Floral" },
                    { 27, 1, "Botanical Dreams", true, 14.50m, "Plants" },
                    { 28, 1, "Garden Serenity", true, 13.75m, "Nature" },
                    { 29, 1, "Petal Power", true, 12.25m, "Patterns" },
                    { 30, 1, "Floral Whimsy", true, 11.50m, "Floral" },
                    { 31, 2, "Dragon Dreams", true, 16.50m, "Fantasy" },
                    { 32, 2, "Mystic Beasts", true, 17.25m, "Fantasy" },
                    { 33, 2, "Knight's Quest", true, 14.75m, "Medieval" },
                    { 34, 2, "Legends Unleashed", true, 18.50m, "Fantasy" },
                    { 35, 2, "Mythical Realms", true, 19.99m, "Fantasy" },
                    { 36, 3, "GeoPatterns", true, 10.99m, "Geometric" },
                    { 37, 3, "Modern Artistry", true, 11.75m, "Minimalist" },
                    { 38, 3, "Abstract Wonders", true, 13.50m, "Abstract" },
                    { 39, 3, "Symmetry Magic", true, 12.25m, "Patterns" },
                    { 40, 3, "Line Artistry", true, 10.75m, "Minimalist" },
                    { 41, 4, "Forest Magic", true, 15.99m, "Wildlife" },
                    { 42, 4, "Ocean Mysteries", true, 16.75m, "Sea Life" },
                    { 43, 4, "Safari Wonders", true, 17.50m, "Animals" },
                    { 44, 4, "Mountain Magic", true, 14.25m, "Nature" },
                    { 45, 4, "Birds of Paradise", true, 13.99m, "Birds" },
                    { 46, 5, "Mandala Magic", true, 12.99m, "Mandala" },
                    { 47, 5, "Zen Patterns", true, 11.50m, "Meditation" },
                    { 48, 5, "Inner Peace Mandalas", true, 13.75m, "Mandala" },
                    { 49, 5, "Sacred Geometry Designs", true, 15.25m, "Spiritual" },
                    { 50, 5, "Tranquil Mandalas", true, 14.00m, "Meditation" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ColoringBooks",
                keyColumn: "ColoringBookID",
                keyValue: 50);
        }
    }
}
