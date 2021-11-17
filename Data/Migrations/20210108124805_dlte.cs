using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProgOdev.Data.Migrations
{
    public partial class dlte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "adminlikAktifMi",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "kullaniciAdi",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "mail",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "sifre",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "uyeID",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "adminlikAktifMi",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "kullaniciAdi",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mail",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sifre",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "uyeID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
