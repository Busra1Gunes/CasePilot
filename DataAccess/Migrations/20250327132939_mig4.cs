using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DosyaEvraklar_EvrakTur_EvrakId",
                table: "DosyaEvraklar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EvrakTur",
                table: "EvrakTur");

            migrationBuilder.RenameTable(
                name: "EvrakTur",
                newName: "EvrakTurler");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EvrakTurler",
                table: "EvrakTurler",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_DosyaEvraklar_EvrakTurler_EvrakId",
                table: "DosyaEvraklar",
                column: "EvrakId",
                principalTable: "EvrakTurler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DosyaEvraklar_EvrakTurler_EvrakId",
                table: "DosyaEvraklar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EvrakTurler",
                table: "EvrakTurler");

            migrationBuilder.RenameTable(
                name: "EvrakTurler",
                newName: "EvrakTur");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EvrakTur",
                table: "EvrakTur",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_DosyaEvraklar_EvrakTur_EvrakId",
                table: "DosyaEvraklar",
                column: "EvrakId",
                principalTable: "EvrakTur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
