using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProgOdev.Data.Migrations
{
    public partial class db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ad",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "adminlikAktifMi",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "dogumTarihi",
                table: "AspNetUsers",
                nullable: true);

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
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    yorumID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    yorumTarih = table.Column<DateTime>(nullable: false),
                    yorumIcerik = table.Column<string>(nullable: true),
                    yorumAktifMi = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.yorumID);
                });

            migrationBuilder.CreateTable(
                name: "HomePageViewModels",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePageViewModels", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TextImages",
                columns: table => new
                {
                    gorselID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gorselAdi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextImages", x => x.gorselID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    kategoriID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriAdi = table.Column<string>(nullable: true),
                    HomePageViewModelsid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.kategoriID);
                    table.ForeignKey(
                        name: "FK_Categories_HomePageViewModels_HomePageViewModelsid",
                        column: x => x.HomePageViewModelsid,
                        principalTable: "HomePageViewModels",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Texts",
                columns: table => new
                {
                    yaziID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    yaziBaslik = table.Column<string>(nullable: true),
                    yaziTarih = table.Column<DateTime>(nullable: false),
                    yaziIcerik = table.Column<string>(nullable: true),
                    HomePageViewModelsid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Texts", x => x.yaziID);
                    table.ForeignKey(
                        name: "FK_Texts_HomePageViewModels_HomePageViewModelsid",
                        column: x => x.HomePageViewModelsid,
                        principalTable: "HomePageViewModels",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_HomePageViewModelsid",
                table: "Categories",
                column: "HomePageViewModelsid");

            migrationBuilder.CreateIndex(
                name: "IX_Texts_HomePageViewModelsid",
                table: "Texts",
                column: "HomePageViewModelsid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "TextImages");

            migrationBuilder.DropTable(
                name: "Texts");

            migrationBuilder.DropTable(
                name: "HomePageViewModels");

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
    }
}
