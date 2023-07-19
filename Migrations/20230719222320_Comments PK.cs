using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_1001_EF_Primer.Migrations
{
    public partial class CommentsPK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostUrl",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "PostUrl",
                table: "Comments",
                newName: "BlogUrl");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_PostUrl",
                table: "Comments",
                newName: "IX_Comments_BlogUrl");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                columns: new[] { "Author", "CommentDate", "BlogUrl" });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_BlogUrl",
                table: "Comments",
                column: "BlogUrl",
                principalTable: "Posts",
                principalColumn: "Url",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_BlogUrl",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "BlogUrl",
                table: "Comments",
                newName: "PostUrl");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_BlogUrl",
                table: "Comments",
                newName: "IX_Comments_PostUrl");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Author");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostUrl",
                table: "Comments",
                column: "PostUrl",
                principalTable: "Posts",
                principalColumn: "Url",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
