using Microsoft.EntityFrameworkCore.Migrations;

namespace Apsi.Database.Migrations
{
    public partial class rejectssum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RejectsSum",
                table: "Ideas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RejectsSum",
                table: "Ideas");
        }
    }
}
