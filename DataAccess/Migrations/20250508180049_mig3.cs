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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3047), new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3056), new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3059), new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3060), new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3061), new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3062), new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3062), new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3063), new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "CaseTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3321), new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3322), new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "CaseTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3324), new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3325), new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "CaseTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3326), new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3326), new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "CaseTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3327), new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3328), new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(5621), new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(5623), new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(5627), new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(5628), new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(5737), new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(5736), new DateTime(2025, 4, 25, 10, 30, 38, 683, DateTimeKind.Local).AddTicks(5735) });
        }
    }
}
