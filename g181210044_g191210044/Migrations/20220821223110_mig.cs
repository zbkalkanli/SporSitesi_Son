using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace g181210044_g191210044.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sepet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UrunId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sepet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Urun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UrunAdi = table.Column<string>(type: "TEXT", nullable: false),
                    Fiyat = table.Column<int>(type: "INTEGER", maxLength: 250, nullable: false),
                    StokSayisi = table.Column<int>(type: "INTEGER", nullable: false),
                    Aciklama = table.Column<string>(type: "TEXT", nullable: false),
                    ResimUrl = table.Column<string>(type: "TEXT", maxLength: 3000, nullable: false),
                    BegeniSayisi = table.Column<int>(type: "INTEGER", nullable: false),
                    SepetId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urun", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Urun_Sepet_SepetId",
                        column: x => x.SepetId,
                        principalTable: "Sepet",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Uye",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KatilimTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MailAdresi = table.Column<string>(type: "TEXT", nullable: false),
                    Ad = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Sifre = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    BegenilenUrunId = table.Column<int>(type: "INTEGER", nullable: true),
                    Adres = table.Column<string>(type: "TEXT", nullable: true),
                    Il = table.Column<string>(type: "TEXT", maxLength: 150, nullable: true),
                    Ilce = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    HesapNumarasi = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    SepetId = table.Column<int>(type: "INTEGER", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uye", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uye_Sepet_SepetId",
                        column: x => x.SepetId,
                        principalTable: "Sepet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogYazisi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BegeniSayisi = table.Column<int>(type: "INTEGER", nullable: false),
                    YayinTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Icerik = table.Column<string>(type: "TEXT", nullable: false),
                    Baslik = table.Column<string>(type: "TEXT", maxLength: 7500, nullable: false),
                    YazarId = table.Column<int>(type: "INTEGER", maxLength: 500, nullable: false),
                    BlogYazariId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogYazisi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogYazisi_Uye_BlogYazariId",
                        column: x => x.BlogYazariId,
                        principalTable: "Uye",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UrunUye",
                columns: table => new
                {
                    BegenenUyelerId = table.Column<int>(type: "INTEGER", nullable: false),
                    BegenilenUrunlerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunUye", x => new { x.BegenenUyelerId, x.BegenilenUrunlerId });
                    table.ForeignKey(
                        name: "FK_UrunUye_Urun_BegenilenUrunlerId",
                        column: x => x.BegenilenUrunlerId,
                        principalTable: "Urun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UrunUye_Uye_BegenenUyelerId",
                        column: x => x.BegenenUyelerId,
                        principalTable: "Uye",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yorum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Icerik = table.Column<string>(type: "TEXT", nullable: false),
                    UyeId = table.Column<int>(type: "INTEGER", maxLength: 3000, nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: true),
                    BlogYazisiId = table.Column<int>(type: "INTEGER", nullable: false),
                    UrunId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yorum_BlogYazisi_BlogYazisiId",
                        column: x => x.BlogYazisiId,
                        principalTable: "BlogYazisi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yorum_Urun_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Urun",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Yorum_Uye_UyeId",
                        column: x => x.UyeId,
                        principalTable: "Uye",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogYazisi_BlogYazariId",
                table: "BlogYazisi",
                column: "BlogYazariId");

            migrationBuilder.CreateIndex(
                name: "IX_Urun_SepetId",
                table: "Urun",
                column: "SepetId");

            migrationBuilder.CreateIndex(
                name: "IX_UrunUye_BegenilenUrunlerId",
                table: "UrunUye",
                column: "BegenilenUrunlerId");

            migrationBuilder.CreateIndex(
                name: "IX_Uye_SepetId",
                table: "Uye",
                column: "SepetId");

            migrationBuilder.CreateIndex(
                name: "IX_Yorum_BlogYazisiId",
                table: "Yorum",
                column: "BlogYazisiId");

            migrationBuilder.CreateIndex(
                name: "IX_Yorum_UrunId",
                table: "Yorum",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_Yorum_UyeId",
                table: "Yorum",
                column: "UyeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UrunUye");

            migrationBuilder.DropTable(
                name: "Yorum");

            migrationBuilder.DropTable(
                name: "BlogYazisi");

            migrationBuilder.DropTable(
                name: "Urun");

            migrationBuilder.DropTable(
                name: "Uye");

            migrationBuilder.DropTable(
                name: "Sepet");
        }
    }
}
