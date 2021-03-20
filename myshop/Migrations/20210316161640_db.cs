using Microsoft.EntityFrameworkCore.Migrations;

namespace myshop.Migrations
{
    public partial class db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\sofa2.jpg    ", "\\Images\\sofa2.jpg    " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 3,
                column: "Description",
                value: "Write here");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "  \\Images\\sofa2.jpg    ", "  \\Images\\sofa2.jpg    " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ShopId",
                keyValue: 3,
                column: "Description",
                value: "This is a Rose wood imported from India, a state in kerala");
        }
    }
}
