using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BulkyBook.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addDataToCompanyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Riyadh", "Al Saeed Trading Co.", "0590502969", null, "Riyadh", "Ans bin Malk road, Alsahafah" },
                    { 2, "Riyadh", "Bin Abdulaziz Construction", "0591234567", null, "Riyadh", "King Fahd road, Al Olaya" },
                    { 3, "Jeddah", "Al Jazeera Electronics", "0587654321", null, "Makkah", "Prince Sultan road, Al Rawdah" },
                    { 4, "Dammam", "Eastern Star Logistics", "0570987654", null, "Eastern Province", "Khalid bin Alwaleed street, Al Khobar" },
                    { 5, "Riyadh", "Riyadh Medical Supplies", "0562345678", null, "Riyadh", "Al Tahlia street, Al Sulaymaniyah" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
