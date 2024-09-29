using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 29, 21, 40, 4, 966, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 29, 21, 40, 4, 966, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 29, 21, 40, 4, 966, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 29, 21, 40, 4, 966, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 29, 21, 40, 4, 966, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 29, 21, 40, 4, 966, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 29, 21, 40, 4, 966, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 29, 21, 40, 4, 966, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 29, 21, 40, 4, 966, DateTimeKind.Local).AddTicks(3343));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 29, 21, 37, 14, 395, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 29, 21, 37, 14, 395, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 29, 21, 37, 14, 395, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 29, 21, 37, 14, 395, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 29, 21, 37, 14, 395, DateTimeKind.Local).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 29, 21, 37, 14, 395, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 29, 21, 37, 14, 395, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 29, 21, 37, 14, 395, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 29, 21, 37, 14, 395, DateTimeKind.Local).AddTicks(3769));
        }
    }
}
