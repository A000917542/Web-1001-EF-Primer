using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_1001_EF_Primer.Migrations
{
    public partial class Addedfkandpk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "AuthorEmail",
                table: "Posts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPost",
                table: "Posts",
                column: "Url");

            migrationBuilder.CreateTable(
                name: "PostAuthor",
                columns: table => new
                {
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Uri = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostAuthor", x => x.Email);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AuthorEmail",
                table: "Posts",
                column: "AuthorEmail");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_PostAuthor_AuthorEmail",
                table: "Posts",
                column: "AuthorEmail",
                principalTable: "PostAuthor",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_PostAuthor_AuthorEmail",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "PostAuthor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPost",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_AuthorEmail",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "AuthorEmail",
                table: "Posts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "Url");
        }
    }
}
