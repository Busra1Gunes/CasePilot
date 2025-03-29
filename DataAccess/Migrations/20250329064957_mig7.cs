using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Davali",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DavaliAdi = table.Column<int>(type: "int", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Davali", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DosyaDavali",
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
                    table.PrimaryKey("PK_DosyaDavali", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DosyaDavali_Davali_DavaliId",
                        column: x => x.DavaliId,
                        principalTable: "Davali",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DosyaDavali_Dosyalar_DosyaId",
                        column: x => x.DosyaId,
                        principalTable: "Dosyalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 29, 9, 49, 57, 407, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 29, 9, 49, 57, 407, DateTimeKind.Local).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 29, 9, 49, 57, 407, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 29, 9, 49, 57, 407, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 29, 9, 49, 57, 407, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 29, 9, 49, 57, 407, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 29, 9, 49, 57, 407, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 29, 9, 49, 57, 407, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Dosyalar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcilisTarihi", "DogumTarihi", "EklenmeTarihi", "KapanisTarihi", "KazaTarihi" },
                values: new object[] { new DateTime(2025, 3, 29, 9, 49, 57, 406, DateTimeKind.Local).AddTicks(9375), new DateTime(2025, 3, 29, 9, 49, 57, 406, DateTimeKind.Local).AddTicks(9372), new DateTime(2025, 3, 29, 9, 49, 57, 406, DateTimeKind.Local).AddTicks(9376), new DateTime(2025, 3, 29, 9, 49, 57, 406, DateTimeKind.Local).AddTicks(9375), new DateTime(2025, 3, 29, 9, 49, 57, 406, DateTimeKind.Local).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "EvrakTurler",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 29, 9, 49, 57, 407, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "EvrakTurler",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 29, 9, 49, 57, 407, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 29, 9, 49, 57, 407, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.CreateIndex(
                name: "IX_DosyaDavali_DavaliId",
                table: "DosyaDavali",
                column: "DavaliId");

            migrationBuilder.CreateIndex(
                name: "IX_DosyaDavali_DosyaId",
                table: "DosyaDavali",
                column: "DosyaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DosyaDavali");

            migrationBuilder.DropTable(
                name: "Davali");

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 13, 38, 47, 177, DateTimeKind.Local).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 13, 38, 47, 177, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 13, 38, 47, 177, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 13, 38, 47, 177, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 13, 38, 47, 177, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 13, 38, 47, 177, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 13, 38, 47, 177, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 13, 38, 47, 177, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Dosyalar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcilisTarihi", "DogumTarihi", "EklenmeTarihi", "KapanisTarihi", "KazaTarihi" },
                values: new object[] { new DateTime(2025, 3, 28, 13, 38, 47, 177, DateTimeKind.Local).AddTicks(6088), new DateTime(2025, 3, 28, 13, 38, 47, 177, DateTimeKind.Local).AddTicks(6086), new DateTime(2025, 3, 28, 13, 38, 47, 177, DateTimeKind.Local).AddTicks(6090), new DateTime(2025, 3, 28, 13, 38, 47, 177, DateTimeKind.Local).AddTicks(6089), new DateTime(2025, 3, 28, 13, 38, 47, 177, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "EvrakTurler",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 13, 38, 47, 177, DateTimeKind.Local).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "EvrakTurler",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 13, 38, 47, 177, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 13, 38, 47, 177, DateTimeKind.Local).AddTicks(7451));
        }
    }
}
