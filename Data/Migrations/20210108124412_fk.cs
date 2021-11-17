using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProgOdev.Data.Migrations
{
    public partial class fk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FKkategoriID",
                table: "Texts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Texts_FKkategoriID",
                table: "Texts",
                column: "FKkategoriID");

            migrationBuilder.AddForeignKey(
                name: "FK_Texts_Categories_FKkategoriID",
                table: "Texts",
                column: "FKkategoriID",
                principalTable: "Categories",
                principalColumn: "kategoriID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Texts_Categories_FKkategoriID",
                table: "Texts");

            migrationBuilder.DropIndex(
                name: "IX_Texts_FKkategoriID",
                table: "Texts");

            migrationBuilder.DropColumn(
                name: "FKkategoriID",
                table: "Texts");
        }
    }
}
