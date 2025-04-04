using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BasvuruTurleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DavaTurId = table.Column<int>(type: "int", nullable: false),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasvuruTurleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Davalilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DavaliAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Davalilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DavaTurleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DavaTurleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EvrakTurler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EvrakTurAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvrakTurler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Iller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ilceler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlId = table.Column<int>(type: "int", nullable: false),
                    IlceAdi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ilceler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ilceler_Iller_IlId",
                        column: x => x.IlId,
                        principalTable: "Iller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dosyalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    davaturId = table.Column<int>(type: "int", nullable: false),
                    basvuruturId = table.Column<int>(type: "int", nullable: false),
                    ilId = table.Column<int>(type: "int", nullable: false),
                    ilceId = table.Column<int>(type: "int", nullable: false),
                    Adi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HaklilikOrani = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    SakatlikOrani = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    KazaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AcilisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KapanisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DosyaDurum = table.Column<int>(type: "int", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dosyalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dosyalar_BasvuruTurleri_basvuruturId",
                        column: x => x.basvuruturId,
                        principalTable: "BasvuruTurleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dosyalar_DavaTurleri_davaturId",
                        column: x => x.davaturId,
                        principalTable: "DavaTurleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dosyalar_Iller_ilId",
                        column: x => x.ilId,
                        principalTable: "Iller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dosyalar_ilceler_ilceId",
                        column: x => x.ilceId,
                        principalTable: "ilceler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlId = table.Column<int>(type: "int", nullable: true),
                    IlceId = table.Column<int>(type: "int", nullable: true),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kullanicilar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_kullanicilar_Iller_IlId",
                        column: x => x.IlId,
                        principalTable: "Iller",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_kullanicilar_ilceler_IlceId",
                        column: x => x.IlceId,
                        principalTable: "ilceler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "dosya_evraklar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DosyaId = table.Column<int>(type: "int", nullable: false),
                    EvrakId = table.Column<int>(type: "int", nullable: false),
                    EvrakUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DosyaId1 = table.Column<int>(type: "int", nullable: true),
                    EvrakTurId = table.Column<int>(type: "int", nullable: true),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dosya_evraklar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dosya_evraklar_Dosyalar_DosyaId",
                        column: x => x.DosyaId,
                        principalTable: "Dosyalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dosya_evraklar_Dosyalar_DosyaId1",
                        column: x => x.DosyaId1,
                        principalTable: "Dosyalar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_dosya_evraklar_EvrakTurler_EvrakId",
                        column: x => x.EvrakId,
                        principalTable: "EvrakTurler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dosya_evraklar_EvrakTurler_EvrakTurId",
                        column: x => x.EvrakTurId,
                        principalTable: "EvrakTurler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DosyaDavalilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DosyaId = table.Column<int>(type: "int", nullable: false),
                    DavaliId = table.Column<int>(type: "int", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DosyaDavalilar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DosyaDavalilar_Davalilar_DavaliId",
                        column: x => x.DavaliId,
                        principalTable: "Davalilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DosyaDavalilar_Dosyalar_DosyaId",
                        column: x => x.DosyaId,
                        principalTable: "Dosyalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DosyaPaylar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DosyaId = table.Column<int>(type: "int", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    Pay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DosyaYetki = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DosyaPaylar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DosyaPaylar_Dosyalar_DosyaId",
                        column: x => x.DosyaId,
                        principalTable: "Dosyalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DosyaPaylar_kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HesapHareketler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GonderenId = table.Column<int>(type: "int", nullable: false),
                    AliciId = table.Column<int>(type: "int", nullable: false),
                    DosyaId = table.Column<int>(type: "int", nullable: true),
                    Tutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HareketDurumu = table.Column<byte>(type: "tinyint", nullable: false),
                    HareketTuru = table.Column<byte>(type: "tinyint", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HesapHareketler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HesapHareketler_Dosyalar_DosyaId",
                        column: x => x.DosyaId,
                        principalTable: "Dosyalar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HesapHareketler_kullanicilar_AliciId",
                        column: x => x.AliciId,
                        principalTable: "kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HesapHareketler_kullanicilar_GonderenId",
                        column: x => x.GonderenId,
                        principalTable: "kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dosya_evraklar_DosyaId",
                table: "dosya_evraklar",
                column: "DosyaId");

            migrationBuilder.CreateIndex(
                name: "IX_dosya_evraklar_DosyaId1",
                table: "dosya_evraklar",
                column: "DosyaId1");

            migrationBuilder.CreateIndex(
                name: "IX_dosya_evraklar_EvrakId",
                table: "dosya_evraklar",
                column: "EvrakId");

            migrationBuilder.CreateIndex(
                name: "IX_dosya_evraklar_EvrakTurId",
                table: "dosya_evraklar",
                column: "EvrakTurId");

            migrationBuilder.CreateIndex(
                name: "IX_DosyaDavalilar_DavaliId",
                table: "DosyaDavalilar",
                column: "DavaliId");

            migrationBuilder.CreateIndex(
                name: "IX_DosyaDavalilar_DosyaId",
                table: "DosyaDavalilar",
                column: "DosyaId");

            migrationBuilder.CreateIndex(
                name: "IX_Dosyalar_basvuruturId",
                table: "Dosyalar",
                column: "basvuruturId");

            migrationBuilder.CreateIndex(
                name: "IX_Dosyalar_davaturId",
                table: "Dosyalar",
                column: "davaturId");

            migrationBuilder.CreateIndex(
                name: "IX_Dosyalar_ilceId",
                table: "Dosyalar",
                column: "ilceId");

            migrationBuilder.CreateIndex(
                name: "IX_Dosyalar_ilId",
                table: "Dosyalar",
                column: "ilId");

            migrationBuilder.CreateIndex(
                name: "IX_DosyaPaylar_DosyaId",
                table: "DosyaPaylar",
                column: "DosyaId");

            migrationBuilder.CreateIndex(
                name: "IX_DosyaPaylar_KullaniciId",
                table: "DosyaPaylar",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_HesapHareketler_AliciId",
                table: "HesapHareketler",
                column: "AliciId");

            migrationBuilder.CreateIndex(
                name: "IX_HesapHareketler_DosyaId",
                table: "HesapHareketler",
                column: "DosyaId");

            migrationBuilder.CreateIndex(
                name: "IX_HesapHareketler_GonderenId",
                table: "HesapHareketler",
                column: "GonderenId");

            migrationBuilder.CreateIndex(
                name: "IX_ilceler_IlId",
                table: "ilceler",
                column: "IlId");

            migrationBuilder.CreateIndex(
                name: "IX_kullanicilar_IlceId",
                table: "kullanicilar",
                column: "IlceId");

            migrationBuilder.CreateIndex(
                name: "IX_kullanicilar_IlId",
                table: "kullanicilar",
                column: "IlId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dosya_evraklar");

            migrationBuilder.DropTable(
                name: "DosyaDavalilar");

            migrationBuilder.DropTable(
                name: "DosyaPaylar");

            migrationBuilder.DropTable(
                name: "HesapHareketler");

            migrationBuilder.DropTable(
                name: "EvrakTurler");

            migrationBuilder.DropTable(
                name: "Davalilar");

            migrationBuilder.DropTable(
                name: "Dosyalar");

            migrationBuilder.DropTable(
                name: "kullanicilar");

            migrationBuilder.DropTable(
                name: "BasvuruTurleri");

            migrationBuilder.DropTable(
                name: "DavaTurleri");

            migrationBuilder.DropTable(
                name: "ilceler");

            migrationBuilder.DropTable(
                name: "Iller");
        }
    }
}
