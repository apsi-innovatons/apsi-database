using Microsoft.EntityFrameworkCore.Migrations;

namespace Apsi.Database.Migrations
{
    public partial class userssubjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Subjects_SubjectId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SubjectId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "SubjectUser",
                columns: table => new
                {
                    CommitteeMembersId = table.Column<int>(type: "int", nullable: false),
                    SubjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectUser", x => new { x.CommitteeMembersId, x.SubjectsId });
                    table.ForeignKey(
                        name: "FK_SubjectUser_Subjects_SubjectsId",
                        column: x => x.SubjectsId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectUser_Users_CommitteeMembersId",
                        column: x => x.CommitteeMembersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubjectUser_SubjectsId",
                table: "SubjectUser",
                column: "SubjectsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubjectUser");

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_SubjectId",
                table: "Users",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Subjects_SubjectId",
                table: "Users",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
