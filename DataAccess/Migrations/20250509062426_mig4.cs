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
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Districts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Districts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Districts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Districts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Cities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Cities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Cities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Cities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5548), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5559), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5564), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5565), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5566), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5567), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5567), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5568), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "CaseTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5826), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5827), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "CaseTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5829), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5830), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "CaseTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5831), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5832), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "CaseTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5832), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5833), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5957), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5959), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5960), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5961), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5961), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5962), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5963), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5964), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5964), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5965), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5966), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5966), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5966) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5967), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5968), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5969), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5970), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5970), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5971), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5972), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5973), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5973), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5974), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5974), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5975), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5977), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5977), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5978), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5979), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5979), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5980), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5981), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5982), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5982), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5983), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5984), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5984), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5985), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5986), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5986), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5987), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5988), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5989), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5990), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5991), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5991), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5992), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5991) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5994), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5995), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5995), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5996), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5997), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5997), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5998), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5999), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(5999), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6000), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6001), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6002), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6002), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6003), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6050), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6051), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6052), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6052), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6053), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6054), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6054), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6055), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6056), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6057), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6057), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6058), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6059), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6060), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6061), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6061), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6063), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6064), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6064), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6065), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6066), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6066), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6067), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6068), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6068), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6069), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6070), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6071), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6072), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6073), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6073), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6074), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6075), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6076), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6077), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6078), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6078), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6079), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6080), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6080), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6081), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6082), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6082), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6083), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6084), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6085), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6085), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6086), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6087), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6087), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6088), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6089), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6089), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6090), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6091), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6092), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6092), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6093), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6094), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6094), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6095), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6096), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6097), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6098), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6097) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6099), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6100), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6101), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6101), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6102), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6103), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6103), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6104), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6105), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6106), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6105) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6106), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6107), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6108), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6108), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6108) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6109), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6110), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6110), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6111), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6112), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6113), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6114), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6115), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6115), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6116), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6117), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6117), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6118), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6119), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6119), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6120), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6121), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6122), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6122), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6123), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6124), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6124), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6125), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6126), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6383), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6385), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6384) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6387), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6387), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6387) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6388), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6389), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6390), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6391), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6860), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6864), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6878), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6879), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6882), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6883), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6884), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6885), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6885), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6886), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6887), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6888), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6889), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6890), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6890), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6891), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6891) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6892), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6893), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6894), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6895), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6895), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6896), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6897), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6898), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6899), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6900), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6901), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6901), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6902), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6903), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6904), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6905), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6906), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6907), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6908), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6909), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6909), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6910), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6911), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6912), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6913), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6914), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6914), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6915), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6916), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6917), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6918), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6918), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6919), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6920), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6921), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6922), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6922), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6924), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6924), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6925), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6926), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6927), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6928), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6928), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6929), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6930), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6931), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6932), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6933), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6934), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6935), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6936), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6937), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6938), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6938), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6939), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6939) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6940), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6941), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6942), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6943), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6944), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6945), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6945), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6946), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6946) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6947), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6948), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6948) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6949), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6950), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6949) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6951), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6952), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6951) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6952), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6953), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6953) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6954), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6955), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6955) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6956), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6958), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6959), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6961), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6962), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6964), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6965), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6966), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6968), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6969), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6970), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6972), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6973), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6974), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6976), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6977), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6979), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6980), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6993), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6995), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6996), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6997), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6998), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6999), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7000), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7001), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7002), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7003), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7004), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7005), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7005) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7006), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7007), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7007), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7008), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7011), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7011), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7012), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7013), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7014), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7015), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7015), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7016), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7017), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7018), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7019), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7020), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7021), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7022), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7097), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7100), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7102), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7103), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7104), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7106), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7106), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7107), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7108), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7109), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7110), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7111), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7112), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7112), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7113), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7114), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7115), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7116), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7117), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7117), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7118), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7119), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7120), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7121), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7122), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7123), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7123), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7124), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7125), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7126), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7127), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7128), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7129), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7130), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7130), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7131), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7132), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7133), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7134), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7135), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7136), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7137), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7137), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7138), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7139), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7140), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7141), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7142), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7143), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7144), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7145), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7146), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7147), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7149), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 101,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7150), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7151), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 102,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7152), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7154), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 103,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7155), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7157), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 104,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7159), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7160), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 105,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7162), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7163), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 106,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7164), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7166), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 107,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7167), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7168), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 108,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7169), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7171), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 109,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7172), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7174), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 110,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7175), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7177), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 111,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7178), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7179), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 112,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7181), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7182), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 113,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7184), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7185), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 114,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7187), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7223), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 115,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7225), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7228), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 116,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7230), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7232), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 117,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7234), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7236), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 118,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7238), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7240), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 119,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7242), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7245), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 120,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7247), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7249), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 121,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7251), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7253), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7252) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 122,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7255), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7257), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 123,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7258), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7259), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 124,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7259), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7262), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 125,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7263), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7264), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 126,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7264), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7266), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 127,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7267), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7268), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 128,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7269), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7270), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 129,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7271), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7272), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 130,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7272), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7273), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 131,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7274), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7275), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 132,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7275), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7276), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 133,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7277), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7278), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 134,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7278), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7279), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 135,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7280), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7281), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 136,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7282), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7282), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 137,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7283), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7284), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 138,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7285), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7286), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 139,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7289), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7290), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 140,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7290), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7291), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 141,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7292), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7293), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 142,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7293), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7294), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 143,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7295), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7296), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 144,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7296), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7297), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 145,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7298), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7299), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 146,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7299), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7300), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 147,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7659), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7660), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 148,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7662), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7663), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 149,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7664), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7665), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 150,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7665), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7666), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 151,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7667), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7668), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 152,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7669), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7669), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 153,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7670), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7671), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 154,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7673), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7674), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 155,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7674), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7675), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 156,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7676), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7677), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 157,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7678), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7679), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 158,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7679), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7680), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 159,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7683), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7683), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 160,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7684), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7685), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 161,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7686), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7687), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 162,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7688), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7688), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 163,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7689), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7690), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 164,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7691), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7692), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 165,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7692), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7693), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 166,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7694), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7695), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7694) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 167,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7696), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7697), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 168,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7698), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7699), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 169,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7699), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7700), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 170,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7701), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7702), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 171,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7703), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7703), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 172,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7704), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7705), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 173,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7707), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7708), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7707) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 174,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7709), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7711), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 175,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7712), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7713), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 176,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7714), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7716), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 177,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7717), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7719), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 178,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7720), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7721), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 179,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7723), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7725), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 180,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7726), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7728), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 181,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7730), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7731), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 182,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7732), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7734), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 183,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7735), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7737), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 184,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7739), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7740), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 185,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7742), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7756), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 186,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7758), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7759), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 187,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7760), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7761), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 188,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7762), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7762), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 189,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7764), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7765), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 190,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7767), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7767), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 191,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7768), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7769), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 192,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7770), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7771), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 193,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7772), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7773), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 194,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7774), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7775), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 195,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7776), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7777), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 196,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7777), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7779), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 197,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7779), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7780), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 198,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7781), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7782), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 199,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7783), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7784), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 200,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7785), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7786), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 201,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7787), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7788), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 202,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7789), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7790), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 203,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7791), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7792), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 204,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7793), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7794), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 205,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7795), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7796), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 206,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7797), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7798), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 207,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7799), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7800), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 208,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7801), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7802), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 209,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7802), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7803), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 210,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7804), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7805), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 211,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7806), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7807), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 212,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7808), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7809), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 213,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7810), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7811), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 214,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7812), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7813), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 215,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7814), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7815), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 216,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7816), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7817), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 217,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7818), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7819), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 218,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7820), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7821), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 219,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7822), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7823), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 220,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7884), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7886), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 221,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7888), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7889), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 222,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7891), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7892), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 223,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7893), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7894), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 224,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7895), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7896), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 225,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7898), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7899), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 226,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7900), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7901), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 227,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7902), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7903), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 228,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7904), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7906), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 229,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7907), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7908), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7907) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 230,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7909), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7910), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 231,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7910), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7911), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 232,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7913), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7914), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 233,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7914), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7915), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 234,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7916), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7917), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 235,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7919), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7920), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 236,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7921), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7922), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 237,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7923), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7924), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7924) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 238,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7925), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7926), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7926) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 239,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7927), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7928), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 240,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7929), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7930), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 241,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7931), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7932), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 242,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7933), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7934), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 243,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7935), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7936), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 244,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7936), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7938), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 245,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7938), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7940), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 246,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7940), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7941), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 247,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7943), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7944), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 248,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7949), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7950), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 249,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7951), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7952), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 250,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7953), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7954), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 251,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7957), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7958), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 252,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7959), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7960), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 253,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7961), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7962), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 254,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7963), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7964), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 255,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7965), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7966), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 256,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7967), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7968), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 257,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7969), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7970), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 258,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7972), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7973), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 259,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7974), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7975), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 260,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7977), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7978), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 261,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7978), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7979), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 262,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7980), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7981), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 263,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7983), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7984), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 264,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7988), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7989), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 265,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7990), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7991), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 266,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7992), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7993), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 267,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7994), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7995), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 268,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7996), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7997), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 269,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7998), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7999), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 270,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(7999), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8000), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 271,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8001), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8002), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 272,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8003), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8004), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 273,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8005), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8006), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 274,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8007), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8008), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 275,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8009), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8010), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 276,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8011), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8013), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8012) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 277,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8016), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8018), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 278,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8018), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8020), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 279,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8021), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8021), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 280,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8027), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8028), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 281,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8030), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8031), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 282,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8032), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8033), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 283,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8035), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8036), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 284,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8037), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8038), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 285,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8039), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8040), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 286,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8041), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8042), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 287,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8043), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8044), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 288,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8045), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8046), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 289,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8047), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8048), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 290,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8049), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8050), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 291,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8050), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8051), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 292,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8053), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8054), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 293,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8528), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8529), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8528) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 294,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8531), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8532), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 295,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8533), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8534), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 296,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8535), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8536), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8536) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 297,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8537), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8538), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 298,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8539), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8541), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 299,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8541), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8543), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 300,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8543), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8544), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8544) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 301,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8545), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8546), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8546) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 302,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8547), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8548), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 303,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8549), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8550), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 304,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8552), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8553), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8552) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 305,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8555), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8556), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 306,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8558), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8559), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 307,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8561), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8562), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 308,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8565), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8565), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8565) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 309,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8566), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8568), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 310,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8568), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8569), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8569) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 311,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8571), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8572), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 312,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8575), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8576), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 313,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8577), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8578), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 314,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8578), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8580), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 315,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8581), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8582), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 316,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8584), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8585), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 317,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8586), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8588), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 318,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8589), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8590), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 319,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8591), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8592), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 320,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8594), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8595), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 321,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8596), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8597), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 322,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8597), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8598), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 323,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8599), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8600), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 324,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8601), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8602), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 325,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8603), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8604), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 326,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8605), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8606), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 327,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8607), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8608), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8607) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 328,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8609), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8610), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 329,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8611), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8612), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 330,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8613), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8614), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 331,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8616), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8617), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 332,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8618), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8619), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 333,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8620), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8621), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 334,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8622), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8623), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8622) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 335,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8624), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8625), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 336,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8626), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8627), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 337,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8627), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8629), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 338,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8629), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8631), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 339,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8632), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8633), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8632) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 340,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8634), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8635), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 341,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8635), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8636), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 342,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8639), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8641), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 343,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8642), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8643), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 344,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8644), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8645), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8645) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 345,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8647), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8648), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 346,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8649), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8650), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8649) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 347,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8651), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8652), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 348,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8653), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8654), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 349,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8655), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8656), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 350,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8657), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8658), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 351,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8659), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8660), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 352,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8661), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8662), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 353,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8663), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8664), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8664) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 354,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8665), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8666), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 355,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8668), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8669), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 356,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8670), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8671), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 357,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8672), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8673), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 358,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8674), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8675), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 359,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8676), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8677), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 360,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8678), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8679), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 361,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8681), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8682), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 362,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8683), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8684), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 363,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8685), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8686), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 364,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8687), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8688), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8687) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 365,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8689), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8690), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 366,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8760), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8761), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 367,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8762), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8763), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 368,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8764), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8766), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 369,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8766), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8768), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 370,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8769), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8770), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 371,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8771), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8772), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 372,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8773), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8774), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 373,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8776), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8777), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 374,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8778), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8779), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 375,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8780), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8781), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 376,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8782), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8783), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 377,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8784), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8785), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 378,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8786), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8787), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 379,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8788), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8789), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 380,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8790), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8792), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 381,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8792), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8793), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 382,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8794), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8796), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 383,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8796), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8798), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 384,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8799), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8800), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 385,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8801), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8802), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 386,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8803), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8804), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 387,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8805), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8806), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 388,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8807), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8808), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 389,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8810), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8812), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 390,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8813), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8814), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 391,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8815), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8816), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 392,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8817), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8818), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 393,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8819), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8820), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 394,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8821), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8822), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 395,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8823), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8824), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 396,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8825), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8826), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 397,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8827), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8828), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 398,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8829), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8830), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 399,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8831), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8832), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 400,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8833), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8834), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 401,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8835), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8836), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 402,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8837), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8838), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 403,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8839), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8840), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 404,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8841), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8842), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 405,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8843), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8844), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 406,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8845), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8846), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 407,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8847), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8848), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 408,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8848), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8849), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 409,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8850), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8852), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 410,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8853), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8854), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 411,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8855), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8856), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 412,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8857), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8858), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 413,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8859), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8860), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 414,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8860), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8861), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 415,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8862), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8863), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 416,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8864), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8865), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 417,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8866), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8867), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 418,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8868), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8869), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 419,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8870), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8871), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 420,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8872), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8873), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 421,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8874), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8875), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 422,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8876), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8877), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 423,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8878), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8879), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 424,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8880), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8881), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 425,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8882), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8883), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 426,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8884), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8885), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 427,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8886), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8887), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 428,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8890), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8891), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 429,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8892), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8892), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 430,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8893), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8894), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 431,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8895), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8896), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 432,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8896), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8897), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 433,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8898), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8899), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 434,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8900), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8901), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 435,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8902), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8902), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 436,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8903), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8904), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 437,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8905), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8905), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 438,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8906), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8907), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 439,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8942), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8943), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 440,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8944), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8945), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 441,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8946), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8947), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 442,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8948), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8948), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 443,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8950), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8951), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 444,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8951), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8952), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 445,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8953), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8954), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 446,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8954), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8955), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 447,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8956), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8956), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 448,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8957), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8958), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 449,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8958), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8959), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 450,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8960), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8961), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 451,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8961), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8962), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 452,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8963), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8964), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 453,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8964), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8965), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 454,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8966), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8967), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 455,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8967), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8968), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 456,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8969), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8970), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 457,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8970), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8971), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 458,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8972), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8973), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 459,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8973), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8974), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 460,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8975), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8976), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 461,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8976), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8977), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 462,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8978), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8978), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 463,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8979), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8980), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 464,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8981), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8981), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 465,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8983), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8984), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 466,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8984), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8985), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 467,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8986), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8986), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 468,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8987), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8988), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 469,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8989), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8989), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 470,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8990), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8991), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 471,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8991), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8992), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 472,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8993), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8994), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 473,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8994), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8995), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 474,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8996), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8997), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 475,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8997), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8998), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 476,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8999), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9000), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 477,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9000), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9001), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 478,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9002), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9003), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 479,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9003), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9004), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 480,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9005), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9006), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 481,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9006), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9007), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 482,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9008), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9009), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 483,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9009), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9010), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 484,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9011), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9012), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 485,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9012), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9013), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 486,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9014), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9014), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 487,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9015), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9016), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 488,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9017), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9017), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 489,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9018), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9019), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 490,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9019), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9020), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 491,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9021), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9022), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 492,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9022), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9023), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 493,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9024), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9025), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 494,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9025), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9026), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 495,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9028), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9029), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 496,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9029), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9030), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 497,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9031), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9032), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 498,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9032), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9033), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 499,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9034), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9034), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 500,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9035), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9036), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 501,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9037), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9037), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 502,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9038), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9039), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 503,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9040), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9040), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 504,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9041), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9042), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 505,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9042), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9043), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 506,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9044), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9045), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 507,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9045), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9046), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 508,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9047), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9048), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 509,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9048), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9049), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 510,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9050), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9051), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 511,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9051), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9052), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 512,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9089), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9090), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 513,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9091), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9092), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 514,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9093), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9094), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 515,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9094), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9095), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 516,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9096), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9097), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 517,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9097), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9098), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 518,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9099), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9100), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 519,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9100), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9101), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 520,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9102), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9103), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 521,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9103), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9104), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 522,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9105), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9106), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 523,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9106), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9107), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 524,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9108), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9109), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 525,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9109), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9110), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 526,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9112), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9113), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 527,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9114), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9114), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 528,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9115), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9116), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 529,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9116), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9117), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 530,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9118), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9119), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 531,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9119), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9120), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 532,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9121), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9122), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 533,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9122), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9123), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 534,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9124), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9125), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 535,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9125), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9126), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 536,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9127), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9128), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 537,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9128), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9129), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 538,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9130), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9131), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 539,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9131), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9132), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 540,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9133), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9133), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 541,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9134), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9135), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 542,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9135), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9136), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 543,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9137), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9138), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 544,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9138), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9139), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 545,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9140), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9141), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 546,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9141), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9142), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 547,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9143), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9144), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 548,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9144), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9145), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 549,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9146), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9147), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 550,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9147), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9148), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 551,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9149), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9150), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 552,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9150), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9151), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 553,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9152), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9152), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 554,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9153), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9154), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 555,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9154), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9155), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 556,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9160), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9161), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 557,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9162), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9163), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 558,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9163), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9164), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 559,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9165), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9166), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 560,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9166), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9167), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 561,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9168), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9169), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 562,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9169), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9170), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 563,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9171), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9171), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 564,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9172), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9173), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 565,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9174), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9174), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 566,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9175), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9176), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 567,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9176), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9177), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 568,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9178), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9179), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 569,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9179), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9180), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 570,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9181), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9182), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 571,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9182), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9183), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 572,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9184), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9185), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 573,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9185), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9186), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 574,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9187), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9187), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 575,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9188), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9189), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9189) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 576,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9190), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9190), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 577,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9191), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9192), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 578,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9192), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9193), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9193) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 579,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9194), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9195), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 580,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9195), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9196), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9196) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 581,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9197), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9198), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 582,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9198), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9199), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 583,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9200), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9201), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 584,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9201), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9202), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 585,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9232), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9233), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 586,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9234), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9235), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 587,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9239), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9240), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 588,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9241), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9242), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 589,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9242), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9243), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 590,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9244), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9245), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 591,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9245), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9246), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 592,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9247), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9248), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9247) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 593,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9248), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9249), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 594,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9250), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9251), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 595,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9251), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9253), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 596,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9254), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9254), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 597,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9255), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9256), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9256) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 598,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9257), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9258), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 599,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9259), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9259), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 600,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9260), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9261), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 601,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9262), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9263), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 602,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9264), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9265), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 603,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9265), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9266), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 604,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9267), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9268), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 605,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9269), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9270), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 606,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9271), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9272), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 607,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9273), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9274), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9273) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 608,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9274), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9275), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 609,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9276), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9277), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9277) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 610,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9278), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9279), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 611,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9280), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9280), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 612,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9281), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9282), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 613,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9283), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9284), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9283) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 614,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9284), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9285), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 615,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9286), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9287), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9286) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 616,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9288), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9289), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 617,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9291), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9292), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9291) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 618,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9292), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9293), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 619,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9294), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9295), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 620,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9296), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9297), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 621,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9298), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9299), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 622,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9300), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9301), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 623,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9301), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9302), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 624,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9303), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9304), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9304) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 625,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9305), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9306), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 626,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9306), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9307), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9307) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 627,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9308), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9309), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 628,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9310), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9311), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 629,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9312), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9313), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 630,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9313), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9314), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 631,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9315), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9316), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 632,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9317), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9318), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 633,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9319), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9320), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 634,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9320), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9321), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 635,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9322), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9323), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 636,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9324), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9324), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 637,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9325), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9326), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 638,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9327), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9341), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 639,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9342), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9344), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 640,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9345), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9346), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 641,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9346), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9349), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 642,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9350), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9351), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 643,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9352), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9352), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 644,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9353), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9354), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 645,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9355), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9356), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 646,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9356), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9357), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 647,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9360), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9361), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 648,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9365), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9366), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 649,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9367), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9367), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 650,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9368), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9369), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 651,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9370), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9371), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 652,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9371), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9372), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 653,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9373), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9374), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 654,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9374), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9375), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 655,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9376), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9377), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 656,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9378), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9379), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 657,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9379), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9380), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 658,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9600), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9604), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 659,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9607), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9609), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 660,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9611), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9614), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9613) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 661,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9616), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9619), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 662,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9620), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9623), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 663,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9624), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9625), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 664,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9627), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9628), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 665,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9630), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9632), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 666,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9633), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9635), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 667,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9636), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9651), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 668,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9652), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9653), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 669,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9654), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9655), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 670,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9656), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9657), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 671,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9658), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9659), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9658) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 672,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9660), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9661), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 673,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9662), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9663), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 674,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9664), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9665), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 675,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9666), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9667), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 676,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9668), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9669), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 677,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9670), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9671), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 678,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9672), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9673), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 679,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9674), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9675), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 680,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9676), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9678), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 681,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9679), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9680), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 682,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9680), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9681), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 683,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9682), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9683), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 684,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9683), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9684), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 685,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9685), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9685), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 686,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9686), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9687), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 687,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9688), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9688), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 688,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9689), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9690), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 689,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9690), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9691), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 690,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9692), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9693), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 691,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9693), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9694), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 692,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9695), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9696), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 693,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9696), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9697), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 694,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9698), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9699), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 695,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9699), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9700), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 696,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9701), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9702), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 697,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9702), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9703), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 698,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9704), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9704), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 699,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9705), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9706), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 700,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9706), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9707), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 701,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9708), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9709), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 702,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9709), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9710), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 703,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9711), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9712), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 704,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9712), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9713), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9713) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 705,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9714), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9714), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 706,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9715), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9716), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9715) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 707,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9716), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9717), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9717) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 708,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9718), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9719), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 709,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9720), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9721), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 710,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9721), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9722), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 711,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9723), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9724), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 712,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9724), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9725), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9725) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 713,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9726), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9727), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9726) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 714,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9727), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9728), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 715,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9729), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9730), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 716,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9730), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9731), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9731) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 717,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9732), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9732), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 718,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9733), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9734), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 719,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9734), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9735), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 720,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9736), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9737), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 721,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9737), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9738), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 722,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9739), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9740), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 723,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9740), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9741), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 724,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9742), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9742), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 725,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9743), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9744), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 726,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9744), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9745), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 727,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9746), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9747), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 728,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9747), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9748), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 729,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9749), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9750), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 730,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9750), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9751), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 731,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9789), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9790), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 732,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9791), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9792), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 733,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9793), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9794), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9793) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 734,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9794), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9795), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 735,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9796), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9796), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 736,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9797), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9798), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 737,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9798), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9799), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 738,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9800), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9801), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 739,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9801), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9802), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 740,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9803), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9804), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 741,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9805), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9806), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 742,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9806), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9807), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 743,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9808), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9809), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 744,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9809), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9810), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 745,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9811), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9811), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 746,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9812), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9813), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 747,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9813), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9814), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 748,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9815), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9816), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9815) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 749,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9816), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9817), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 750,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9818), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9819), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 751,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9819), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9820), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 752,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9821), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9821), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 753,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9822), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9823), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 754,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9823), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9824), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 755,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9825), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9826), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 756,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9826), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9827), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 757,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9828), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9829), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 758,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9829), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9830), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 759,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9830), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9831), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 760,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9832), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9833), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 761,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9833), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9834), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 762,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9835), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9836), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 763,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9836), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9837), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 764,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9838), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9839), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 765,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9839), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9840), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 766,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9841), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9842), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9841) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 767,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9842), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9843), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 768,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9844), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9844), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9844) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 769,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9845), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9846), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9846) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 770,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9847), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9847), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 771,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9849), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9849), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9849) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 772,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9850), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9851), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 773,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9852), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9853), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 774,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9853), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9854), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 775,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9855), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9856), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 776,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9856), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9857), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 777,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9858), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9858), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 778,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9859), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9860), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 779,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9860), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9861), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 780,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9862), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9863), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 781,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9863), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9864), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 782,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9865), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9866), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 783,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9866), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9867), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 784,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9867), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9868), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 785,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9869), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9870), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 786,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9870), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9871), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 787,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9872), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9873), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 788,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9873), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9874), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 789,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9875), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9876), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 790,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9876), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9877), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 791,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9878), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9878), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 792,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9879), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9880), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 793,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9880), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9881), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 794,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9882), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9883), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 795,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9883), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9884), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 796,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9885), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9885), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 797,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9886), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9887), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 798,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9888), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9889), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 799,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9889), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9890), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 800,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9891), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9892), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 801,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9892), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9893), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 802,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9894), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9895), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 803,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9938), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9939), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 804,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9940), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9941), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 805,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9942), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9943), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 806,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9943), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9944), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9944) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 807,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9945), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9946), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 808,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9946), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9947), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 809,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9948), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9948), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 810,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9949), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9950), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 811,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9950), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9951), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 812,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9952), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9953), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 813,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9953), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9954), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 814,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9955), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9955), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 815,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9956), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9957), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 816,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9957), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9958), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 817,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9959), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9960), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 818,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9960), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9961), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 819,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9962), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9963), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 820,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9963), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9964), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 821,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9965), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9965), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 822,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9966), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9967), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 823,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9968), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9968), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 824,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9969), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9970), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 825,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9970), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9971), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 826,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9972), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9973), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 827,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9973), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9974), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 828,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9975), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9975), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 829,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9976), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9977), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 830,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9977), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9978), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 831,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9979), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9980), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 832,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9981), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9982), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 833,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9983), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9984), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 834,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9985), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9985), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 835,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9986), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9987), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 836,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9987), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9988), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 837,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9989), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9990), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 838,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9990), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9991), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 839,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9992), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9993), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 840,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9993), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9994), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 841,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9995), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9995), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 842,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9996), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9997), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 843,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9997), new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9998), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 844,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9999), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local), false, new DateTime(2025, 5, 9, 9, 24, 26, 86, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 845,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(1), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 846,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(2), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(3), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 847,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(3), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(4), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 848,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(5), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(6), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 849,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(6), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(7), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 850,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(8), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(8), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 851,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(9), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(10), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 852,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(10), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(11), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 853,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(12), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(13), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 854,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(13), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(14), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 855,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(15), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(16), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 856,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(16), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(17), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 857,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(18), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(18), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(18) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 858,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(19), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(20), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 859,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(20), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(21), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 860,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(22), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(23), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 861,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(23), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(24), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 862,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(25), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(26), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 863,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(27), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(28), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 864,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(28), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(29), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 865,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(30), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(31), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 866,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(32), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(33), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(32) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 867,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(33), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(34), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 868,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(35), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(36), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 869,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(36), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(37), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 870,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(38), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(38), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 871,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(39), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(40), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 872,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(40), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(41), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 873,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(42), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(43), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 874,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(43), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(44), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 875,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(45), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(46), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 876,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(96), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(97), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 877,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(98), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(99), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 878,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(100), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(101), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 879,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(101), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(102), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 880,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(103), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(104), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 881,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(104), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(105), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 882,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(106), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(107), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(106) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 883,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(107), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(108), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 884,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(109), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(109), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 885,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(110), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(111), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 886,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(111), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(112), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 887,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(113), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(114), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 888,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(114), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(115), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 889,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(116), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(117), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 890,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(117), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(118), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 891,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(119), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(119), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 892,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(120), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(121), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 893,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(121), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(122), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 894,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(124), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(125), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(124) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 895,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(125), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(126), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 896,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(127), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(128), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(128) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 897,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(129), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(129), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 898,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(130), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(131), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 899,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(131), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(132), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 900,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(133), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(134), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 901,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(134), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(135), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 902,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(136), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(137), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 903,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(137), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(138), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 904,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(139), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(139), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(139) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 905,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(140), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(141), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 906,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(141), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(142), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 907,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(143), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(144), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(143) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 908,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(144), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(145), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(145) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 909,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(146), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(147), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 910,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(147), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(148), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 911,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(149), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(149), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 912,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(150), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(151), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 913,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(151), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(152), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 914,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(153), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(154), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 915,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(154), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(155), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(155) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 916,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(156), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(157), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 917,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(157), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(158), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 918,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(159), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(159), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 919,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(160), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(161), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 920,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(161), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(162), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 921,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(163), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(164), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 922,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(164), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(165), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(165) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 923,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(166), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(167), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 924,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(167), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(168), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(168) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 925,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(169), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(170), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 926,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(171), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(172), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(171) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 927,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(172), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(173), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 928,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(174), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(175), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(174) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 929,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(175), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(176), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(176) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 930,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(177), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(177), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 931,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(178), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(179), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 932,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(179), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(180), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(180) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 933,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(181), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(182), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 934,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(182), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(183), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(183) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 935,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(184), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(185), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 936,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(185), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(186), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(186) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 937,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(187), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(187), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(187) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 938,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(188), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(189), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 939,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(190), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(190), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 940,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(191), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(192), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 941,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(192), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(193), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 942,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(194), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(195), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(194) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 943,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(195), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(196), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 944,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(197), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(198), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 945,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(198), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(199), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 946,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(200), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(200), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 947,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(201), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(202), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(201) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 948,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(202), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(203), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 949,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(233), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(234), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 950,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(235), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(235), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 951,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(236), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(237), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 952,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(238), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(238), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 953,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(239), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(240), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 954,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(240), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(241), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 955,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(242), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(243), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(242) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 956,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(243), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(244), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 957,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(245), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(246), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 958,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(246), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(247), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 959,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(248), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(248), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 960,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(249), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(250), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 961,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(250), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(251), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 962,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(252), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(253), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 963,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(253), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(254), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 964,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(255), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(256), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 965,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(256), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(257), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 966,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(258), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(258), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 967,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(259), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(260), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(259) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 968,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(260), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(261), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 969,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(262), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(263), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 970,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(263), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(264), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 971,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(265), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(266), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 972,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(266), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(267), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "ID",
                keyValue: 973,
                columns: new[] { "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(268), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(269), false, new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(663), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(665), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(667), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(668), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(776), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(775), new DateTime(2025, 5, 9, 9, 24, 26, 87, DateTimeKind.Local).AddTicks(774) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Cities");

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(539), new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(548), new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(550), new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(551), new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(552), new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(553), new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(553), new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(554), new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "CaseTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(765), new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(766), new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "CaseTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(767), new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(767), new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(767) });

            migrationBuilder.UpdateData(
                table: "CaseTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(768), new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(769), new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "CaseTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(770), new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(770), new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(1684), new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(1685), new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(1685) });

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(1687), new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(1688), new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(1740), new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(1738), new DateTime(2025, 5, 8, 21, 0, 49, 552, DateTimeKind.Local).AddTicks(1738) });
        }
    }
}
