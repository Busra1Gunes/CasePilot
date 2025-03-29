using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DavaliAdi",
                table: "Davali",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 29, 9, 51, 15, 534, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 29, 9, 51, 15, 534, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 29, 9, 51, 15, 534, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 29, 9, 51, 15, 534, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 29, 9, 51, 15, 534, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 29, 9, 51, 15, 534, DateTimeKind.Local).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 29, 9, 51, 15, 534, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 29, 9, 51, 15, 534, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Dosyalar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcilisTarihi", "DogumTarihi", "EklenmeTarihi", "KapanisTarihi", "KazaTarihi" },
                values: new object[] { new DateTime(2025, 3, 29, 9, 51, 15, 534, DateTimeKind.Local).AddTicks(3757), new DateTime(2025, 3, 29, 9, 51, 15, 534, DateTimeKind.Local).AddTicks(3752), new DateTime(2025, 3, 29, 9, 51, 15, 534, DateTimeKind.Local).AddTicks(3758), new DateTime(2025, 3, 29, 9, 51, 15, 534, DateTimeKind.Local).AddTicks(3757), new DateTime(2025, 3, 29, 9, 51, 15, 534, DateTimeKind.Local).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "EvrakTurler",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 29, 9, 51, 15, 534, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "EvrakTurler",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 29, 9, 51, 15, 534, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 3, 29, 9, 51, 15, 534, DateTimeKind.Local).AddTicks(4989));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DavaliAdi",
                table: "Davali",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
        }
    }
}
