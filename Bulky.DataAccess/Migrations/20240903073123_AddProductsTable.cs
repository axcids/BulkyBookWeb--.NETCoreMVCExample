using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BulkyBook.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProductsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Billy Spark", "Praesent vita sodales libro some text here", "SWD99999001", 99.0, 90.0, 80.0, 85.0, "Fortune of Time" },
                    { 2, "Liu Cixin", "A gripping sci-fi novel that explores the complexity of space and time.", "SWD99999002", 120.0, 110.0, 100.0, 105.0, "The Dark Forest" },
                    { 3, "John Doe", "A thrilling adventure set in the depths of the ocean.", "SWD99999003", 95.0, 85.0, 75.0, 80.0, "The Silent Sea" },
                    { 4, "Wu Cheng'en", "An ancient Chinese tale of bravery, wisdom, and perseverance.", "SWD99999004", 150.0, 140.0, 130.0, 135.0, "Journey to the West" },
                    { 5, "Jane Smith", "A deep dive into the science of the human mind and potential.", "SWD99999005", 85.0, 80.0, 70.0, 75.0, "Mind Over Matter" },
                    { 6, "Carl Sagan", "An exploration of the universe and its profound mysteries.", "SWD99999006", 110.0, 100.0, 90.0, 95.0, "Secrets of the Cosmos" },
                    { 7, "Sun Tzu", "An ancient Chinese military treatise on strategy and tactics.", "SWD99999007", 75.0, 70.0, 60.0, 65.0, "The Art of War" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
