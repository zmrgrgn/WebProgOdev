using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProgOdev.Data.Migrations
{
    public partial class fkdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FKyaziID",
                table: "TextImages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FKyaziID",
                table: "Comments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TextImages_FKyaziID",
                table: "TextImages",
                column: "FKyaziID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_FKyaziID",
                table: "Comments",
                column: "FKyaziID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Texts_FKyaziID",
                table: "Comments",
                column: "FKyaziID",
                principalTable: "Texts",
                principalColumn: "yaziID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TextImages_Texts_FKyaziID",
                table: "TextImages",
                column: "FKyaziID",
                principalTable: "Texts",
                principalColumn: "yaziID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Texts_FKyaziID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_TextImages_Texts_FKyaziID",
                table: "TextImages");

            migrationBuilder.DropIndex(
                name: "IX_TextImages_FKyaziID",
                table: "TextImages");

            migrationBuilder.DropIndex(
                name: "IX_Comments_FKyaziID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "FKyaziID",
                table: "TextImages");

            migrationBuilder.DropColumn(
                name: "FKyaziID",
                table: "Comments");
        }
    }
}
