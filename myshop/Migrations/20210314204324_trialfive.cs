using Microsoft.EntityFrameworkCore.Migrations;

namespace myshop.Migrations
{
    public partial class trialfive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 1,
                column: "Name",
                value: "cozy sofa");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "soft sofas", 150.5m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 1,
                column: "Name",
                value: "Sandal wood");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Rose wood", 250.5m });
        }
    }
}
