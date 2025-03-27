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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 10, 6, 18, 26, 44, 980, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 10, 6, 18, 26, 44, 980, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 10, 6, 18, 26, 44, 980, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 10, 6, 18, 26, 44, 980, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 10, 6, 18, 26, 44, 980, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 10, 6, 18, 26, 44, 980, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 10, 6, 18, 26, 44, 980, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 10, 6, 18, 26, 44, 980, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Dosyalar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcilisTarihi", "DogumTarihi", "EklenmeTarihi", "KapanisTarihi", "KazaTarihi" },
                values: new object[] { new DateTime(2024, 10, 6, 18, 26, 44, 980, DateTimeKind.Local).AddTicks(4531), new DateTime(2024, 10, 6, 18, 26, 44, 980, DateTimeKind.Local).AddTicks(4528), new DateTime(2024, 10, 6, 18, 26, 44, 980, DateTimeKind.Local).AddTicks(4532), new DateTime(2024, 10, 6, 18, 26, 44, 980, DateTimeKind.Local).AddTicks(4531), new DateTime(2024, 10, 6, 18, 26, 44, 980, DateTimeKind.Local).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 10, 6, 18, 26, 44, 980, DateTimeKind.Local).AddTicks(5498));
        }
    }
}
