using Microsoft.EntityFrameworkCore.Migrations;

namespace myshop.Migrations
{
    public partial class trialfour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "  ~ \\Images\\sofa3.jpg    ", "  ~\\Images\\sofa3.jpg    " });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ShopId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsOnSale", "Name", "OnStock", "Price" },
                values: new object[] { 2, 2, "This is a Rose wood imported from India, a state in kerala", "  ~ \\Images\\sofa2.jpg    ", "  ~\\Images\\sofa2.jpg    ", true, "Rose wood", true, 250.5m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "   \\Images\\sofa3.jpg    ", "   \\Images\\sofa3.jpg    " });
        }
    }
}
