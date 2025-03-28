using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EvrakDosyasi",
                table: "DosyaEvraklar");

            migrationBuilder.AddColumn<string>(
                name: "EvrakUrl",
                table: "DosyaEvraklar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.InsertData(
                table: "EvrakTurler",
                columns: new[] { "Id", "Durum", "EklenmeTarihi", "EvrakTurAdi", "GuncellenmeTarihi", "SilinmeTarihi", "Tur" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2025, 3, 28, 10, 45, 2, 745, DateTimeKind.Local).AddTicks(7521), "TcKimlik", null, null, "DosyaEvrak" },
                    { 2, false, new DateTime(2025, 3, 28, 10, 45, 2, 745, DateTimeKind.Local).AddTicks(7523), "Sici Kaydı", null, null, "KullaniciEvrak" }
                });

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 28, 10, 45, 2, 745, DateTimeKind.Local).AddTicks(7382));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EvrakTurler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EvrakTurler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "EvrakUrl",
                table: "DosyaEvraklar");

            migrationBuilder.AddColumn<byte[]>(
                name: "EvrakDosyasi",
                table: "DosyaEvraklar",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 16, 29, 38, 895, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 16, 29, 38, 895, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 16, 29, 38, 895, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 16, 29, 38, 895, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 16, 29, 38, 895, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 16, 29, 38, 895, DateTimeKind.Local).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 16, 29, 38, 895, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 16, 29, 38, 895, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "Dosyalar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcilisTarihi", "DogumTarihi", "EklenmeTarihi", "KapanisTarihi", "KazaTarihi" },
                values: new object[] { new DateTime(2025, 3, 27, 16, 29, 38, 895, DateTimeKind.Local).AddTicks(3810), new DateTime(2025, 3, 27, 16, 29, 38, 895, DateTimeKind.Local).AddTicks(3807), new DateTime(2025, 3, 27, 16, 29, 38, 895, DateTimeKind.Local).AddTicks(3811), new DateTime(2025, 3, 27, 16, 29, 38, 895, DateTimeKind.Local).AddTicks(3810), new DateTime(2025, 3, 27, 16, 29, 38, 895, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 27, 16, 29, 38, 895, DateTimeKind.Local).AddTicks(5097));
        }
    }
}
