using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend_Feature_api.Migrations
{
    /// <inheritdoc />
    public partial class QuantityModified_reverted_Quantity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5439591a-6a5e-4bbf-a110-e6124d2f9ca0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afdc4445-5078-4195-815a-902529d7cb51");

            migrationBuilder.RenameColumn(
                name: "Current_Quantity",
                table: "product",
                newName: "Quantity");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "937ae7b3-defd-4959-b045-ed13ca57637a", null, "admin", "ADMIN" },
                    { "b3b4c669-eaa4-432e-9449-dfcf24b53e3a", null, "user", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "937ae7b3-defd-4959-b045-ed13ca57637a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3b4c669-eaa4-432e-9449-dfcf24b53e3a");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "product",
                newName: "Current_Quantity");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5439591a-6a5e-4bbf-a110-e6124d2f9ca0", null, "user", "USER" },
                    { "afdc4445-5078-4195-815a-902529d7cb51", null, "admin", "ADMIN" }
                });
        }
    }
}
