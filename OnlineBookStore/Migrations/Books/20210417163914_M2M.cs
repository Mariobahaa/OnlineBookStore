using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBookStore.Migrations.Books
{
    public partial class M2M : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserBooks_BookId",
                table: "UserBooks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UserBooks_BookId",
                table: "UserBooks",
                column: "BookId",
                unique: true);
        }
    }
}
