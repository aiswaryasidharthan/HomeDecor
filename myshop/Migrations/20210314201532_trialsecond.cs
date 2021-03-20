using Microsoft.EntityFrameworkCore.Migrations;

namespace myshop.Migrations
{
    public partial class trialsecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Categoryid", "CategoryName", "Categorydescription" },
                values: new object[] { 1, "Sandal wood", null });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Categoryid", "CategoryName", "Categorydescription" },
                values: new object[] { 2, "Rose wood", null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ShopId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsOnSale", "Name", "OnStock", "Price" },
                values: new object[] { 1, 1, "This is a sandal wood imported from India, a state in kerala", "   \\Images\\sofa3.jpg    ", "   \\Images\\sofa3.jpg    ", true, "Sandal wood", true, 250.5m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Categoryid",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Categoryid",
                keyValue: 1);
        }
    }
}
