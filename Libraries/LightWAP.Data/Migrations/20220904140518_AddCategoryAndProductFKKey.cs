using Microsoft.EntityFrameworkCore.Migrations;

namespace LightWAP.Data.Migrations
{
    public partial class AddCategoryAndProductFKKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_FK_ProductHasCategory",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_FK_ProductHasCategory",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "FK_ProductHasCategory",
                table: "Products");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "FK_ProductHasCategory",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_FK_ProductHasCategory",
                table: "Products",
                column: "FK_ProductHasCategory");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_FK_ProductHasCategory",
                table: "Products",
                column: "FK_ProductHasCategory",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
