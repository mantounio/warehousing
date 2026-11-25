using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend_Feature_api.Migrations
{
    /// <inheritdoc />
    public partial class QuantityModified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f161384-0cbc-4509-9014-fd09afbaa165");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47b1df59-a482-4dc8-96cf-d6f46d30d2ac");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "product",
                newName: "Previous_Quantity");

            migrationBuilder.AddColumn<int>(
                name: "Current_Quantity",
                table: "product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5439591a-6a5e-4bbf-a110-e6124d2f9ca0", null, "user", "USER" },
                    { "afdc4445-5078-4195-815a-902529d7cb51", null, "admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5439591a-6a5e-4bbf-a110-e6124d2f9ca0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afdc4445-5078-4195-815a-902529d7cb51");

            migrationBuilder.DropColumn(
                name: "Current_Quantity",
                table: "product");

            migrationBuilder.RenameColumn(
                name: "Previous_Quantity",
                table: "product",
                newName: "Quantity");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f161384-0cbc-4509-9014-fd09afbaa165", null, "admin", "ADMIN" },
                    { "47b1df59-a482-4dc8-96cf-d6f46d30d2ac", null, "user", "USER" }
                });
        }
    }
}
