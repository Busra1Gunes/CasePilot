using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Iller");

            migrationBuilder.DropColumn(
                name: "EklenmeTarihi",
                table: "Iller");

            migrationBuilder.DropColumn(
                name: "GuncellenmeTarihi",
                table: "Iller");

            migrationBuilder.DropColumn(
                name: "SilinmeTarihi",
                table: "Iller");

            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Ilceler");

            migrationBuilder.DropColumn(
                name: "EklenmeTarihi",
                table: "Ilceler");

            migrationBuilder.DropColumn(
                name: "GuncellenmeTarihi",
                table: "Ilceler");

            migrationBuilder.DropColumn(
                name: "SilinmeTarihi",
                table: "Ilceler");

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 12, 0, 23, 820, DateTimeKind.Local).AddTicks(9878));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Durum",
                table: "Iller",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "Iller",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "GuncellenmeTarihi",
                table: "Iller",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SilinmeTarihi",
                table: "Iller",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Durum",
                table: "Ilceler",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "Ilceler",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "GuncellenmeTarihi",
                table: "Ilceler",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SilinmeTarihi",
                table: "Ilceler",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 5,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 6,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 7,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 8,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 9,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 10,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 11,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 12,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 13,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 14,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 15,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 16,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 17,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 18,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 19,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 20,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 21,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 22,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 23,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 24,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 25,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 26,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 27,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 28,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 29,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 30,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 31,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 32,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 33,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 34,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 35,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 36,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 37,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 38,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 39,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 40,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 41,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 42,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 43,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 44,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 45,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 46,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 47,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 48,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 49,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 50,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 51,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 52,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 53,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 54,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 55,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 56,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 57,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 58,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 59,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 60,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 61,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 62,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 63,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 64,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 65,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 66,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 67,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 68,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 69,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 70,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 71,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 72,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 73,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 74,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 75,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 76,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 77,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 78,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 79,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 80,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 81,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 82,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 83,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 84,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 85,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 86,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 87,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 88,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 89,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 90,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 91,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 92,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 93,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 94,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 95,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 96,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 97,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 98,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 99,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 100,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 101,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 102,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 103,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 104,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 105,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 106,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 107,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 108,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 109,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 110,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 111,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 112,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 113,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 114,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 115,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 116,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 117,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 118,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 119,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 120,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 121,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 122,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 123,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 124,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 125,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 126,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 127,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 128,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 129,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 130,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 131,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 132,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 133,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 134,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 135,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 136,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 137,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 138,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 139,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 140,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 141,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 142,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 143,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 144,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 145,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 146,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 147,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 148,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 149,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 150,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 151,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 152,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 153,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 154,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 155,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 156,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 157,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 158,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 159,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 160,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 161,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 162,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 163,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 164,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 165,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 166,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 167,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 168,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 169,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 170,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 171,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 172,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 173,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 174,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 175,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 176,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 177,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 178,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 179,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 180,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 181,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 182,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 183,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 184,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 185,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 186,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 187,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 188,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 189,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 190,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 191,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 192,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 193,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 194,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 195,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 196,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 197,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 198,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 199,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 200,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 201,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 202,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 203,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 204,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 205,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 206,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 207,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 208,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 209,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 210,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 211,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 212,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 213,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 214,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 215,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 216,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 217,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 218,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 219,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 220,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 221,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 222,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 223,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 224,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 225,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 226,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 227,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 228,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 229,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 230,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 231,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 232,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 233,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 234,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 235,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 236,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 237,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 238,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 239,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 240,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 241,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 242,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 243,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 244,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 245,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 246,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 247,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 248,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 249,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 250,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 251,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 252,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 253,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 254,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 255,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 256,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 257,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 258,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 259,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 260,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 261,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 262,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 263,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 264,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 265,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 266,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 267,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 268,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 269,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 270,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 271,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 272,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 273,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 274,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 275,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 276,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 277,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 278,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 279,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 280,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 281,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 282,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 283,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 284,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 285,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 286,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 287,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 288,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 289,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 290,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 291,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 292,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 293,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 294,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 295,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 296,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 297,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 298,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 299,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 300,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 301,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 302,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 303,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 304,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 305,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 306,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 307,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 308,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 309,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 310,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 311,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 312,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 313,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 314,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 315,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 316,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 317,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 318,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 319,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 320,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 321,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 322,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 323,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 324,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 325,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 326,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 327,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 328,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 329,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 330,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 331,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 332,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 333,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 334,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 335,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 336,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 337,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 338,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 339,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 340,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 341,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 342,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 343,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 344,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 345,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 346,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 347,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 348,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 349,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 350,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 351,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 352,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 353,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 354,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 355,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 356,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 357,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 358,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 359,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 360,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 361,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 362,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 363,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 364,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 365,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 366,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 367,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 368,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 369,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 370,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 371,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 372,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 373,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 374,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 375,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 376,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 377,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 378,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 379,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 380,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 381,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 382,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 383,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 384,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 385,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 386,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 387,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 388,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 389,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 390,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 391,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 392,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 393,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 394,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 395,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 396,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 397,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 398,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 399,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 400,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 401,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 402,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 403,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 404,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 405,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 406,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 407,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 408,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 409,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 410,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 411,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 412,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 413,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 414,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 415,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 416,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 417,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 418,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 419,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 420,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 421,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 422,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 423,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 424,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 425,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 426,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 427,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 428,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 429,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 430,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 431,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 432,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 433,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 434,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 435,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 436,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 437,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 438,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 439,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 440,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 441,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 442,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 443,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 444,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 445,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 446,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 447,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 448,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 449,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 450,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 451,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 452,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 453,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 454,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 455,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 456,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 457,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 458,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 459,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 460,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 461,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 462,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 463,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 464,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 465,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 466,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 467,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 468,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 469,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 470,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 471,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 472,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 473,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 474,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 475,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 476,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 477,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 478,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 479,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 480,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 481,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 482,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 483,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 484,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 485,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 486,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 487,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 488,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 489,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 490,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 491,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 492,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 493,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 494,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 495,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 496,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 497,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 498,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 499,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 500,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 501,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 502,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 503,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 504,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 505,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 506,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 507,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 508,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 509,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 510,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 511,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 512,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 513,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 514,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 515,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 516,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 517,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 518,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 519,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 520,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 521,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 522,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 523,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 524,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 525,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 526,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 527,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 528,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 529,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 530,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 531,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 532,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 533,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 534,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 535,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 536,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 537,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 538,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 539,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 540,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 541,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 542,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 543,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 544,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 545,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 546,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 547,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 548,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 549,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 550,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 551,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 552,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 553,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 554,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 555,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 556,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 557,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 558,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 559,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 560,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 561,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 562,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 563,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 564,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 565,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 566,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 567,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 568,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 569,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 570,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 571,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 572,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 573,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 574,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 575,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 576,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 577,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 578,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 579,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 580,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 581,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 582,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 583,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 584,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 585,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 586,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 587,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 588,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 589,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 590,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 591,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 592,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 593,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 594,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 595,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 596,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 597,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 598,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 599,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 600,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 601,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 602,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 603,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 604,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 605,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 606,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 607,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 608,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 609,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 610,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 611,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 612,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 613,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 614,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 615,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 616,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 617,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 618,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 619,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 620,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 621,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 622,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 623,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 624,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 625,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 626,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 627,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 628,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 629,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 630,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 631,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 632,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 633,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 634,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 635,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 636,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 637,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 638,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 639,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 640,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 641,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 642,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 643,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 644,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 645,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 646,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 647,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 648,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 649,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 650,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 651,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 652,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 653,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 654,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 655,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 656,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 657,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 658,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 659,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 660,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 661,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 662,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 663,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 664,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 665,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 666,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 667,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 668,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 669,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 670,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 671,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 672,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 673,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 674,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 675,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 676,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 677,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 678,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 679,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 680,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 681,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 682,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 683,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 684,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 685,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 686,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 687,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 688,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 689,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 690,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 691,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 692,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 693,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 694,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 695,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 696,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 697,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 698,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 699,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 700,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 701,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 702,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 703,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 704,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 705,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 706,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 707,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 708,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 709,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 710,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 711,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 712,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 713,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 714,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 715,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 716,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 717,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 718,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 719,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 720,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 721,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 722,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 723,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 724,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 725,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 726,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 727,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 728,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 729,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 730,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 731,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 732,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 733,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 734,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 735,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 736,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 737,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 738,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 739,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 740,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 741,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 742,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 743,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 744,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 745,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 746,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 747,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 748,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 749,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 750,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 751,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 752,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 753,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 754,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 755,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 756,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 757,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 758,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 759,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 760,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 761,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 762,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 763,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 764,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 765,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 766,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 767,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 768,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 769,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 770,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 771,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 772,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 773,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 774,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 775,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 776,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 777,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 778,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 779,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 780,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 781,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 782,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 783,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 784,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 785,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 786,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 787,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 788,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 789,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 790,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 791,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 792,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 793,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 794,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 795,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 796,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 797,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 798,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 799,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 800,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 801,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 802,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 803,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 804,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 805,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 806,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 807,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 808,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 809,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 810,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 811,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 812,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 813,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 814,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 815,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 816,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 817,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 818,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 819,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 820,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 821,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 822,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 823,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 824,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 825,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 826,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 827,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 828,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 829,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 830,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 831,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 832,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 833,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 834,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 835,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 836,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 837,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 838,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 839,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 840,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 841,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 842,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 843,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 844,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 845,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 846,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 847,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 848,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 849,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 850,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 851,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 852,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 853,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 854,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 855,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 856,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 857,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 858,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 859,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 860,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 861,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 862,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 863,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 864,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 865,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 866,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 867,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 868,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 869,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 870,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 871,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 872,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 873,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 874,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 875,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 876,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 877,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 878,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 879,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 880,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 881,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 882,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 883,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 884,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 885,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 886,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 887,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 888,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 889,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 890,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 891,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 892,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 893,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 894,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 895,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 896,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 897,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 898,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 899,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 900,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 901,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 902,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 903,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 904,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 905,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 906,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 907,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 908,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 909,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 910,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 911,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 912,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 913,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 914,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 915,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 916,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 917,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 918,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 919,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 920,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 921,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 922,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 923,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 924,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 925,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 926,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 927,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 928,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 929,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 930,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 931,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 932,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 933,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 934,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 935,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 936,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 937,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 938,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 939,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 940,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 941,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 942,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 943,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 944,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 945,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 946,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 947,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 948,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 949,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 950,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 951,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 952,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 953,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 954,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 955,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 956,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 957,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 958,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 959,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 960,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 961,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 962,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 963,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 964,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 965,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 966,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 967,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 968,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 969,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 970,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 971,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 972,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: 973,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 2,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 3,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 4,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 5,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 6,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 7,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 8,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 9,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 10,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 11,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 12,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 13,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 14,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 15,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 16,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 17,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 18,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 19,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 20,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 21,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 22,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 23,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 24,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 25,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 26,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 27,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 28,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 29,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 30,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 31,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 32,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 33,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 34,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 35,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 36,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 37,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 38,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 39,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 40,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 41,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 42,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 43,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 44,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 45,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 46,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 47,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 48,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 49,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 50,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 51,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 52,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 53,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 54,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 55,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 56,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 57,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 58,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 59,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 60,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 61,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 62,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 63,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 64,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 65,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 66,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 67,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 68,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 69,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 70,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 71,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 72,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 73,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 74,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 75,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 76,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 77,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 78,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 79,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 80,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 81,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 9, 21, 11, 58, 31, 31, DateTimeKind.Local).AddTicks(5041));
        }
    }
}
