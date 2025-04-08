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
            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 5, 16, 3, 0, 604, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 5, 16, 3, 0, 604, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 5, 16, 3, 0, 604, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 5, 16, 3, 0, 604, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 5, 16, 3, 0, 604, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 5, 16, 3, 0, 604, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 5, 16, 3, 0, 604, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 5, 16, 3, 0, 604, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "Dosyalar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcilisTarihi", "DogumTarihi", "EklenmeTarihi", "KapanisTarihi", "KazaTarihi" },
                values: new object[] { new DateTime(2025, 4, 5, 16, 3, 0, 604, DateTimeKind.Local).AddTicks(1817), new DateTime(2025, 4, 5, 16, 3, 0, 604, DateTimeKind.Local).AddTicks(1814), new DateTime(2025, 4, 5, 16, 3, 0, 604, DateTimeKind.Local).AddTicks(1818), new DateTime(2025, 4, 5, 16, 3, 0, 604, DateTimeKind.Local).AddTicks(1817), new DateTime(2025, 4, 5, 16, 3, 0, 604, DateTimeKind.Local).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "EvrakTurler",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 5, 16, 3, 0, 604, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "EvrakTurler",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 5, 16, 3, 0, 604, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 5, 16, 3, 0, 604, DateTimeKind.Local).AddTicks(3002));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "Dosyalar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcilisTarihi", "DogumTarihi", "EklenmeTarihi", "KapanisTarihi", "KazaTarihi" },
                values: new object[] { new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(3255), new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(3252), new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(3256), new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(3255), new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "EvrakTurler",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "EvrakTurler",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(4857));
        }
    }
}
