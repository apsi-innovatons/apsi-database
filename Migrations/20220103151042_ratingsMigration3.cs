using Microsoft.EntityFrameworkCore.Migrations;

namespace Apsi.Database.Migrations
{
    public partial class ratingsMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Ideas_IdeaId",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Users_AuthorId",
                table: "Rating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rating",
                table: "Rating");

            migrationBuilder.RenameTable(
                name: "Rating",
                newName: "Ratings");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_IdeaId",
                table: "Ratings",
                newName: "IX_Ratings_IdeaId");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_AuthorId",
                table: "Ratings",
                newName: "IX_Ratings_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ratings",
                table: "Ratings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Ideas_IdeaId",
                table: "Ratings",
                column: "IdeaId",
                principalTable: "Ideas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Users_AuthorId",
                table: "Ratings",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Ideas_IdeaId",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Users_AuthorId",
                table: "Ratings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ratings",
                table: "Ratings");

            migrationBuilder.RenameTable(
                name: "Ratings",
                newName: "Rating");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_IdeaId",
                table: "Rating",
                newName: "IX_Rating_IdeaId");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_AuthorId",
                table: "Rating",
                newName: "IX_Rating_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rating",
                table: "Rating",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Ideas_IdeaId",
                table: "Rating",
                column: "IdeaId",
                principalTable: "Ideas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Users_AuthorId",
                table: "Rating",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
