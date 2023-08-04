using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_1001_EF_Primer.Migrations
{
    public partial class AddingCommentDateIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Comment_CommentDate",
                table: "Comments",
                column: "CommentDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Comment_CommentDate",
                table: "Comments");
        }
    }
}
