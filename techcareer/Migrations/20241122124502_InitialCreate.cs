using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techcareer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bootcamps",
                columns: table => new
                {
                    BootcampId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Baslik = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bootcamps", x => x.BootcampId);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    OgrenciId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OgrenciAd = table.Column<string>(type: "TEXT", nullable: true),
                    OgrenciSoyad = table.Column<string>(type: "TEXT", nullable: true),
                    Eposta = table.Column<string>(type: "TEXT", nullable: true),
                    Telefon = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.OgrenciId);
                });

            migrationBuilder.CreateTable(
                name: "BootcampKayitlari",
                columns: table => new
                {
                    KayitId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OgrenciId = table.Column<int>(type: "INTEGER", nullable: false),
                    BootcampId = table.Column<int>(type: "INTEGER", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BootcampKayitlari", x => x.KayitId);
                    table.ForeignKey(
                        name: "FK_BootcampKayitlari_Bootcamps_BootcampId",
                        column: x => x.BootcampId,
                        principalTable: "Bootcamps",
                        principalColumn: "BootcampId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BootcampKayitlari_Ogrenciler_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrenciler",
                        principalColumn: "OgrenciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BootcampKayitlari_BootcampId",
                table: "BootcampKayitlari",
                column: "BootcampId");

            migrationBuilder.CreateIndex(
                name: "IX_BootcampKayitlari_OgrenciId",
                table: "BootcampKayitlari",
                column: "OgrenciId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BootcampKayitlari");

            migrationBuilder.DropTable(
                name: "Bootcamps");

            migrationBuilder.DropTable(
                name: "Ogrenciler");
        }
    }
}
