using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 10, 45, 2, 745, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 10, 45, 2, 745, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 10, 45, 2, 745, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 10, 45, 2, 745, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 10, 45, 2, 745, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 10, 45, 2, 745, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 10, 45, 2, 745, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 10, 45, 2, 745, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Dosyalar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcilisTarihi", "DogumTarihi", "EklenmeTarihi", "KapanisTarihi", "KazaTarihi" },
                values: new object[] { new DateTime(2025, 3, 28, 10, 45, 2, 745, DateTimeKind.Local).AddTicks(5918), new DateTime(2025, 3, 28, 10, 45, 2, 745, DateTimeKind.Local).AddTicks(5915), new DateTime(2025, 3, 28, 10, 45, 2, 745, DateTimeKind.Local).AddTicks(5919), new DateTime(2025, 3, 28, 10, 45, 2, 745, DateTimeKind.Local).AddTicks(5919), new DateTime(2025, 3, 28, 10, 45, 2, 745, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "EvrakTurler",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 10, 45, 2, 745, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "EvrakTurler",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 10, 45, 2, 745, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 10, 45, 2, 745, DateTimeKind.Local).AddTicks(7382));
        }
    }
}
