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
            migrationBuilder.DropForeignKey(
                name: "FK_HesapHareketler_kullanicilar_AliciId",
                table: "HesapHareketler");

            migrationBuilder.DropForeignKey(
                name: "FK_HesapHareketler_kullanicilar_GonderenId",
                table: "HesapHareketler");

            migrationBuilder.RenameColumn(
                name: "GonderenId",
                table: "HesapHareketler",
                newName: "BorcluID");

            migrationBuilder.RenameColumn(
                name: "AliciId",
                table: "HesapHareketler",
                newName: "AlacakId");

            migrationBuilder.RenameIndex(
                name: "IX_HesapHareketler_GonderenId",
                table: "HesapHareketler",
                newName: "IX_HesapHareketler_BorcluID");

            migrationBuilder.RenameIndex(
                name: "IX_HesapHareketler_AliciId",
                table: "HesapHareketler",
                newName: "IX_HesapHareketler_AlacakId");

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 11, 16, 15, 18, 397, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 11, 16, 15, 18, 397, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 11, 16, 15, 18, 397, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 11, 16, 15, 18, 397, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 11, 16, 15, 18, 397, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 11, 16, 15, 18, 397, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 11, 16, 15, 18, 397, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 11, 16, 15, 18, 397, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Dosyalar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcilisTarihi", "DogumTarihi", "EklenmeTarihi", "KapanisTarihi", "KazaTarihi" },
                values: new object[] { new DateTime(2025, 4, 11, 16, 15, 18, 397, DateTimeKind.Local).AddTicks(5418), new DateTime(2025, 4, 11, 16, 15, 18, 397, DateTimeKind.Local).AddTicks(5416), new DateTime(2025, 4, 11, 16, 15, 18, 397, DateTimeKind.Local).AddTicks(5421), new DateTime(2025, 4, 11, 16, 15, 18, 397, DateTimeKind.Local).AddTicks(5420), new DateTime(2025, 4, 11, 16, 15, 18, 397, DateTimeKind.Local).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "EvrakTurler",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 11, 16, 15, 18, 397, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "EvrakTurler",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 11, 16, 15, 18, 397, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 11, 16, 15, 18, 397, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.AddForeignKey(
                name: "FK_HesapHareketler_kullanicilar_AlacakId",
                table: "HesapHareketler",
                column: "AlacakId",
                principalTable: "kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HesapHareketler_kullanicilar_BorcluID",
                table: "HesapHareketler",
                column: "BorcluID",
                principalTable: "kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HesapHareketler_kullanicilar_AlacakId",
                table: "HesapHareketler");

            migrationBuilder.DropForeignKey(
                name: "FK_HesapHareketler_kullanicilar_BorcluID",
                table: "HesapHareketler");

            migrationBuilder.RenameColumn(
                name: "BorcluID",
                table: "HesapHareketler",
                newName: "GonderenId");

            migrationBuilder.RenameColumn(
                name: "AlacakId",
                table: "HesapHareketler",
                newName: "AliciId");

            migrationBuilder.RenameIndex(
                name: "IX_HesapHareketler_BorcluID",
                table: "HesapHareketler",
                newName: "IX_HesapHareketler_GonderenId");

            migrationBuilder.RenameIndex(
                name: "IX_HesapHareketler_AlacakId",
                table: "HesapHareketler",
                newName: "IX_HesapHareketler_AliciId");

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 9, 14, 52, 55, 882, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 9, 14, 52, 55, 882, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 9, 14, 52, 55, 882, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 9, 14, 52, 55, 882, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 9, 14, 52, 55, 882, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 9, 14, 52, 55, 882, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 9, 14, 52, 55, 882, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 9, 14, 52, 55, 882, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Dosyalar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcilisTarihi", "DogumTarihi", "EklenmeTarihi", "KapanisTarihi", "KazaTarihi" },
                values: new object[] { new DateTime(2025, 4, 9, 14, 52, 55, 882, DateTimeKind.Local).AddTicks(5575), new DateTime(2025, 4, 9, 14, 52, 55, 882, DateTimeKind.Local).AddTicks(5573), new DateTime(2025, 4, 9, 14, 52, 55, 882, DateTimeKind.Local).AddTicks(5576), new DateTime(2025, 4, 9, 14, 52, 55, 882, DateTimeKind.Local).AddTicks(5576), new DateTime(2025, 4, 9, 14, 52, 55, 882, DateTimeKind.Local).AddTicks(5575) });

            migrationBuilder.UpdateData(
                table: "EvrakTurler",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 9, 14, 52, 55, 882, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "EvrakTurler",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 9, 14, 52, 55, 882, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2025, 4, 9, 14, 52, 55, 882, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.AddForeignKey(
                name: "FK_HesapHareketler_kullanicilar_AliciId",
                table: "HesapHareketler",
                column: "AliciId",
                principalTable: "kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HesapHareketler_kullanicilar_GonderenId",
                table: "HesapHareketler",
                column: "GonderenId",
                principalTable: "kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
