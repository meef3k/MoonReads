using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoonReads.Migrations
{
    /// <inheritdoc />
    public partial class addDataVersionSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DataVersions",
                columns: new[] { "Id", "Table", "Version" },
                values: new object[,]
                {
                    { 1, "Authors", 0 },
                    { 2, "Books", 0 },
                    { 3, "Categories", 0 },
                    { 4, "Publishers", 0 },
                    { 5, "AuthorCategories", 0 },
                    { 6, "BookAuthors", 0 },
                    { 7, "BookCategories", 0 },
                    { 8, "Ratings", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DataVersions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DataVersions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DataVersions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DataVersions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DataVersions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DataVersions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DataVersions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DataVersions",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
