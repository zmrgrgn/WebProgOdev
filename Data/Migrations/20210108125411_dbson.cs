using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProgOdev.Data.Migrations
{
    public partial class dbson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FKuyeID",
                table: "Texts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FKuyeID",
                table: "Comments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Texts_FKuyeID",
                table: "Texts",
                column: "FKuyeID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_FKuyeID",
                table: "Comments",
                column: "FKuyeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_FKuyeID",
                table: "Comments",
                column: "FKuyeID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Texts_AspNetUsers_FKuyeID",
                table: "Texts",
                column: "FKuyeID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_FKuyeID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Texts_AspNetUsers_FKuyeID",
                table: "Texts");

            migrationBuilder.DropIndex(
                name: "IX_Texts_FKuyeID",
                table: "Texts");

            migrationBuilder.DropIndex(
                name: "IX_Comments_FKuyeID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "FKuyeID",
                table: "Texts");

            migrationBuilder.DropColumn(
                name: "FKuyeID",
                table: "Comments");
        }
    }
}
