using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProgOdev.Data.Migrations
{
    public partial class dn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ad",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "adminlikAktifMi",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "dogumTarihi",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

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

            migrationBuilder.AddColumn<string>(
                name: "soyad",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "uyeID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);
        }
    }
}
