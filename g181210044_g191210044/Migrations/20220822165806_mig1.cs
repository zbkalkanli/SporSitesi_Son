using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace g181210044_g191210044.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Uye_Sepet_SepetId",
                table: "Uye");

            migrationBuilder.DropForeignKey(
                name: "FK_Yorum_Urun_UrunId",
                table: "Yorum");

            migrationBuilder.DropTable(
                name: "UrunUye");

            migrationBuilder.DropTable(
                name: "Urun");

            migrationBuilder.DropTable(
                name: "Sepet");

            migrationBuilder.DropIndex(
                name: "IX_Yorum_UrunId",
                table: "Yorum");

            migrationBuilder.DropIndex(
                name: "IX_Uye_SepetId",
                table: "Uye");

            migrationBuilder.DropColumn(
                name: "UrunId",
                table: "Yorum");

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "Uye");

            migrationBuilder.DropColumn(
                name: "BegenilenUrunId",
                table: "Uye");

            migrationBuilder.DropColumn(
                name: "HesapNumarasi",
                table: "Uye");

            migrationBuilder.DropColumn(
                name: "Il",
                table: "Uye");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "Uye");

            migrationBuilder.DropColumn(
                name: "SepetId",
                table: "Uye");

            migrationBuilder.AlterColumn<int>(
                name: "UyeId",
                table: "Yorum",
                type: "int",
                maxLength: 3000,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldMaxLength: 3000);

            migrationBuilder.AlterColumn<string>(
                name: "Icerik",
                table: "Yorum",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "BlogYazisiId",
                table: "Yorum",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "BlogId",
                table: "Yorum",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Yorum",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Soyad",
                table: "Uye",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Sifre",
                table: "Uye",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "MailAdresi",
                table: "Uye",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "KatilimTarihi",
                table: "Uye",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Discriminator",
                table: "Uye",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "Uye",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Uye",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "YazarId",
                table: "BlogYazisi",
                type: "int",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<DateTime>(
                name: "YayinTarihi",
                table: "BlogYazisi",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Icerik",
                table: "BlogYazisi",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "BlogYazariId",
                table: "BlogYazisi",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "BegeniSayisi",
                table: "BlogYazisi",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Baslik",
                table: "BlogYazisi",
                type: "nvarchar(max)",
                maxLength: 7500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 7500);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "BlogYazisi",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UyeId",
                table: "Yorum",
                type: "INTEGER",
                maxLength: 3000,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 3000);

            migrationBuilder.AlterColumn<string>(
                name: "Icerik",
                table: "Yorum",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "BlogYazisiId",
                table: "Yorum",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BlogId",
                table: "Yorum",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Yorum",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "UrunId",
                table: "Yorum",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Soyad",
                table: "Uye",
                type: "TEXT",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Sifre",
                table: "Uye",
                type: "TEXT",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "MailAdresi",
                table: "Uye",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "KatilimTarihi",
                table: "Uye",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Discriminator",
                table: "Uye",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "Uye",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Uye",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "Uye",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BegenilenUrunId",
                table: "Uye",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HesapNumarasi",
                table: "Uye",
                type: "TEXT",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "Uye",
                type: "TEXT",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "Uye",
                type: "TEXT",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SepetId",
                table: "Uye",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "YazarId",
                table: "BlogYazisi",
                type: "INTEGER",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "YayinTarihi",
                table: "BlogYazisi",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Icerik",
                table: "BlogYazisi",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "BlogYazariId",
                table: "BlogYazisi",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BegeniSayisi",
                table: "BlogYazisi",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Baslik",
                table: "BlogYazisi",
                type: "TEXT",
                maxLength: 7500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 7500);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "BlogYazisi",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateTable(
                name: "Sepet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Aciklama = table.Column<string>(type: "TEXT", nullable: false),
                    BegeniSayisi = table.Column<int>(type: "INTEGER", nullable: false),
                    Fiyat = table.Column<int>(type: "INTEGER", maxLength: 250, nullable: false),
                    ResimUrl = table.Column<string>(type: "TEXT", maxLength: 3000, nullable: false),
                    SepetId = table.Column<int>(type: "INTEGER", nullable: true),
                    StokSayisi = table.Column<int>(type: "INTEGER", nullable: false),
                    UrunAdi = table.Column<string>(type: "TEXT", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Yorum_UrunId",
                table: "Yorum",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_Uye_SepetId",
                table: "Uye",
                column: "SepetId");

            migrationBuilder.CreateIndex(
                name: "IX_Urun_SepetId",
                table: "Urun",
                column: "SepetId");

            migrationBuilder.CreateIndex(
                name: "IX_UrunUye_BegenilenUrunlerId",
                table: "UrunUye",
                column: "BegenilenUrunlerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Uye_Sepet_SepetId",
                table: "Uye",
                column: "SepetId",
                principalTable: "Sepet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Yorum_Urun_UrunId",
                table: "Yorum",
                column: "UrunId",
                principalTable: "Urun",
                principalColumn: "Id");
        }
    }
}
