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
            migrationBuilder.DropColumn(
                name: "TransactionStatus",
                table: "AccountTransactions");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "TransactionStatus",
                table: "AccountTransactions",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 16, 22, 35, 16, 680, DateTimeKind.Local).AddTicks(8126), null, null });

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 16, 22, 35, 16, 680, DateTimeKind.Local).AddTicks(8136), null, null });

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 16, 22, 35, 16, 680, DateTimeKind.Local).AddTicks(8137), null, null });

            migrationBuilder.UpdateData(
                table: "ApplicationTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 16, 22, 35, 16, 680, DateTimeKind.Local).AddTicks(8137), null, null });

            migrationBuilder.UpdateData(
                table: "CaseTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 16, 22, 35, 16, 680, DateTimeKind.Local).AddTicks(8288), null, null });

            migrationBuilder.UpdateData(
                table: "CaseTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 16, 22, 35, 16, 680, DateTimeKind.Local).AddTicks(8289), null, null });

            migrationBuilder.UpdateData(
                table: "CaseTypes",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 16, 22, 35, 16, 680, DateTimeKind.Local).AddTicks(8290), null, null });

            migrationBuilder.UpdateData(
                table: "CaseTypes",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 16, 22, 35, 16, 680, DateTimeKind.Local).AddTicks(8290), null, null });

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 16, 22, 35, 16, 680, DateTimeKind.Local).AddTicks(9055), null, null });

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 16, 22, 35, 16, 680, DateTimeKind.Local).AddTicks(9058), null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 16, 22, 35, 16, 680, DateTimeKind.Local).AddTicks(9117), null, null });
        }
    }
}
