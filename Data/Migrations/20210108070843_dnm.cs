using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProgOdev.Data.Migrations
{
    public partial class dnm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ad",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "adminlikAktifMi",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "dogumTarihi",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "kullaniciAdi",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mail",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sifre",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "soyad",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "uyeID",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ad",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "adminlikAktifMi",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "dogumTarihi",
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
                name: "soyad",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "uyeID",
                table: "AspNetUsers");
        }
    }
}
