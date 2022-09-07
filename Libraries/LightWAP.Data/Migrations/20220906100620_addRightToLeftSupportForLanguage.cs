using Microsoft.EntityFrameworkCore.Migrations;

namespace LightWAP.Data.Migrations
{
    public partial class addRightToLeftSupportForLanguage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Rtl",
                table: "Languages",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rtl",
                table: "Languages");
        }
    }
}
