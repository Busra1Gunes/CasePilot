using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dosyalar_BasvuruTurleri_basvuruturId",
                table: "Dosyalar");

            migrationBuilder.CreateTable(
                name: "EvrakTur",
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
                    table.PrimaryKey("PK_EvrakTur", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DosyaEvraklar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DosyaId = table.Column<int>(type: "int", nullable: false),
                    EvrakId = table.Column<int>(type: "int", nullable: false),
                    EvrakDosyasi = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DosyaEvraklar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DosyaEvraklar_Dosyalar_DosyaId",
                        column: x => x.DosyaId,
                        principalTable: "Dosyalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DosyaEvraklar_EvrakTur_EvrakId",
                        column: x => x.EvrakId,
                        principalTable: "EvrakTur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 16, 27, 26, 859, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 16, 27, 26, 859, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 16, 27, 26, 859, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 16, 27, 26, 859, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 16, 27, 26, 859, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 16, 27, 26, 859, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 16, 27, 26, 859, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 16, 27, 26, 859, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Dosyalar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcilisTarihi", "DogumTarihi", "EklenmeTarihi", "KapanisTarihi", "KazaTarihi" },
                values: new object[] { new DateTime(2025, 3, 27, 16, 27, 26, 859, DateTimeKind.Local).AddTicks(7405), new DateTime(2025, 3, 27, 16, 27, 26, 859, DateTimeKind.Local).AddTicks(7401), new DateTime(2025, 3, 27, 16, 27, 26, 859, DateTimeKind.Local).AddTicks(7406), new DateTime(2025, 3, 27, 16, 27, 26, 859, DateTimeKind.Local).AddTicks(7406), new DateTime(2025, 3, 27, 16, 27, 26, 859, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 16, 27, 26, 859, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.CreateIndex(
                name: "IX_DosyaEvraklar_DosyaId",
                table: "DosyaEvraklar",
                column: "DosyaId");

            migrationBuilder.CreateIndex(
                name: "IX_DosyaEvraklar_EvrakId",
                table: "DosyaEvraklar",
                column: "EvrakId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dosyalar_BasvuruTurleri_basvuruturId",
                table: "Dosyalar",
                column: "basvuruturId",
                principalTable: "BasvuruTurleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dosyalar_BasvuruTurleri_basvuruturId",
                table: "Dosyalar");

            migrationBuilder.DropTable(
                name: "DosyaEvraklar");

            migrationBuilder.DropTable(
                name: "EvrakTur");

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 15, 26, 46, 0, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 15, 26, 46, 0, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 15, 26, 46, 0, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 15, 26, 46, 0, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 15, 26, 46, 0, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 15, 26, 46, 0, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 15, 26, 46, 0, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 15, 26, 46, 0, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Dosyalar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcilisTarihi", "DogumTarihi", "EklenmeTarihi", "KapanisTarihi", "KazaTarihi" },
                values: new object[] { new DateTime(2025, 3, 27, 15, 26, 46, 0, DateTimeKind.Local).AddTicks(3064), new DateTime(2025, 3, 27, 15, 26, 46, 0, DateTimeKind.Local).AddTicks(3062), new DateTime(2025, 3, 27, 15, 26, 46, 0, DateTimeKind.Local).AddTicks(3065), new DateTime(2025, 3, 27, 15, 26, 46, 0, DateTimeKind.Local).AddTicks(3064), new DateTime(2025, 3, 27, 15, 26, 46, 0, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 15, 26, 46, 0, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.AddForeignKey(
                name: "FK_Dosyalar_BasvuruTurleri_basvuruturId",
                table: "Dosyalar",
                column: "basvuruturId",
                principalTable: "BasvuruTurleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
