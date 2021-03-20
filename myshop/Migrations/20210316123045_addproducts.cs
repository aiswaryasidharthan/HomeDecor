using Microsoft.EntityFrameworkCore.Migrations;

namespace myshop.Migrations
{
    public partial class addproducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name" },
                values: new object[] { "  \\Images\\sofa3.jpg    ", "  \\Images\\sofa3.jpg    ", "Cozy sofa" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name" },
                values: new object[] { "  \\Images\\sofa2.jpg    ", "  \\Images\\sofa2.jpg    ", "Wood finish sofas" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ShopId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsOnSale", "Name", "OnStock", "Price" },
                values: new object[] { 3, 2, "This is a Rose wood imported from India, a state in kerala", "  \\Images\\sofa4.jpg    ", "  \\Images\\sofa4.jpg    ", true, "Recliner", true, 110.5m });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Categoryid",
                keyValue: 1,
                column: "CategoryName",
                value: "Living and BedRoom");

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Categoryid",
                keyValue: 2,
                column: "CategoryName",
                value: "Kitchen and Home");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name" },
                values: new object[] { "  ~ \\Images\\sofa3.jpg    ", "  ~\\Images\\sofa3.jpg    ", "cozy sofa" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name" },
                values: new object[] { "  ~ \\Images\\sofa2.jpg    ", "  ~\\Images\\sofa2.jpg    ", "soft sofas" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Categoryid",
                keyValue: 1,
                column: "CategoryName",
                value: "Sandal wood");

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Categoryid",
                keyValue: 2,
                column: "CategoryName",
                value: "Rose wood");
        }
    }
}
