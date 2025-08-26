using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseTypeID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CaseTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Defendants",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Defendants", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Districts_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    PermissionID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Permissions_PermissionID",
                        column: x => x.PermissionID,
                        principalTable: "Permissions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CaseFiles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationTypeID = table.Column<int>(type: "int", nullable: false),
                    CaseTypeID = table.Column<int>(type: "int", nullable: false),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    DistrictID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntitlementRate = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    DisabilityRate = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    AccidentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OpeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClosingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CaseStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseFiles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CaseFiles_ApplicationTypes_ApplicationTypeID",
                        column: x => x.ApplicationTypeID,
                        principalTable: "ApplicationTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseFiles_CaseTypes_CaseTypeID",
                        column: x => x.CaseTypeID,
                        principalTable: "CaseTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CaseFiles_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CaseFiles_Districts_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "Districts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityID = table.Column<int>(type: "int", nullable: true),
                    DistrictID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Users_Districts_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "Districts",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CaseFileDefendant",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    caseFileID = table.Column<int>(type: "int", nullable: false),
                    defendantID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseFileDefendant", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CaseFileDefendant_CaseFiles_caseFileID",
                        column: x => x.caseFileID,
                        principalTable: "CaseFiles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseFileDefendant_Defendants_defendantID",
                        column: x => x.defendantID,
                        principalTable: "Defendants",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CaseFileDocument",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseFileID = table.Column<int>(type: "int", nullable: false),
                    DocumentTypeID = table.Column<int>(type: "int", nullable: false),
                    DocumentUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseFileDocument", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CaseFileDocument_CaseFiles_CaseFileID",
                        column: x => x.CaseFileID,
                        principalTable: "CaseFiles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CaseFileDocument_DocumentTypes_DocumentTypeID",
                        column: x => x.DocumentTypeID,
                        principalTable: "DocumentTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccountTransactions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DebtorID = table.Column<int>(type: "int", nullable: false),
                    CreditID = table.Column<int>(type: "int", nullable: false),
                    CaseFileID = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<byte>(type: "tinyint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentReceivedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinalPaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentStatus = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTransactions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AccountTransactions_CaseFiles_CaseFileID",
                        column: x => x.CaseFileID,
                        principalTable: "CaseFiles",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_AccountTransactions_Users_CreditID",
                        column: x => x.CreditID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccountTransactions_Users_DebtorID",
                        column: x => x.DebtorID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CaseFileShares",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseFileID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ShareRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FilePermission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseFileShares", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CaseFileShares_CaseFiles_CaseFileID",
                        column: x => x.CaseFileID,
                        principalTable: "CaseFiles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseFileShares_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ApplicationTypes",
                columns: new[] { "ID", "CaseTypeID", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9538), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9539), "Araç Hasarı", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9539) },
                    { 2, 1, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9541), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9541), "Manevi", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9541) },
                    { 3, 1, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9542), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9543), "İdari Dava", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9543) },
                    { 4, 4, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9544), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9544), "Kamulaştırma", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9544) }
                });

            migrationBuilder.InsertData(
                table: "CaseTypes",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9659), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9660), "Trafik Kazası", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9660) },
                    { 2, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9661), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9662), "Arabuluculuk", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9661) },
                    { 3, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9662), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9663), "İdari Dava", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9663) },
                    { 4, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9664), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9665), "Kamulaştırma", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9664) }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9729), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9730), "Adana", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9730) },
                    { 2, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9732), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9732), "Adıyaman", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9732) },
                    { 3, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9733), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9734), "Afyonkarahisar", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9734) },
                    { 4, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9734), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9735), "Ağrı", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9735) },
                    { 5, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9736), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9736), "Amasya", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9736) },
                    { 6, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9737), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9738), "Ankara", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9737) },
                    { 7, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9738), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9739), "Antalya", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9739) },
                    { 8, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9740), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9740), "Artvin", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9740) },
                    { 9, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9741), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9742), "Aydın", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9741) },
                    { 10, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9742), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9743), "Balıkesir", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9742) },
                    { 11, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9744), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9745), "Bilecik", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9744) },
                    { 12, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9745), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9746), "Bingöl", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9746) },
                    { 13, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9747), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9747), "Bitlis", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9747) },
                    { 14, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9748), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9749), "Bolu", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9748) },
                    { 15, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9749), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9750), "Burdur", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9749) },
                    { 16, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9750), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9751), "Bursa", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9751) },
                    { 17, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9752), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9752), "Çanakkale", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9752) },
                    { 18, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9753), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9754), "Çankırı", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9753) },
                    { 19, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9754), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9755), "Çorum", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9755) },
                    { 20, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9756), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9756), "Denizli", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9756) },
                    { 21, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9757), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9758), "Diyarbakır", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9757) },
                    { 22, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9758), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9759), "Edirne", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9759) },
                    { 23, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9760), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9760), "Elazığ", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9760) },
                    { 24, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9761), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9762), "Erzincan", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9761) },
                    { 25, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9762), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9763), "Erzurum", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9763) },
                    { 26, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9763), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9764), "Eskişehir", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9764) },
                    { 27, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9765), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9765), "Gaziantep", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9765) },
                    { 28, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9766), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9767), "Giresun", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9766) },
                    { 29, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9768), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9769), "Gümüşhane", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9769) },
                    { 30, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9770), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9770), "Hakkari", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9770) },
                    { 31, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9772), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9773), "Hatay", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9773) },
                    { 32, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9774), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9774), "Isparta", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9774) },
                    { 33, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9775), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9776), "Mersin", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9775) },
                    { 34, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9776), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9777), "İstanbul", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9776) },
                    { 35, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9778), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9779), "İzmir", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9778) },
                    { 36, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9822), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9824), "Kars", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9824) },
                    { 37, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9825), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9826), "Kastamonu", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9825) },
                    { 38, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9826), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9827), "Kayseri", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9827) },
                    { 39, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9827), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9828), "Kırklareli", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9828) },
                    { 40, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9829), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9829), "Kırşehir", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9829) },
                    { 41, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9830), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9831), "Kocaeli", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9830) },
                    { 42, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9831), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9832), "Konya", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9832) },
                    { 43, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9833), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9834), "Kütahya", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9834) },
                    { 44, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9834), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9835), "Malatya", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9835) },
                    { 45, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9836), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9836), "Manisa", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9836) },
                    { 46, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9837), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9838), "Kahramanmaraş", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9837) },
                    { 47, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9838), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9839), "Mardin", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9839) },
                    { 48, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9839), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9840), "Muğla", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9840) },
                    { 49, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9841), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9841), "Muş", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9841) },
                    { 50, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9842), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9843), "Nevşehir", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9842) },
                    { 51, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9843), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9844), "Niğde", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9844) },
                    { 52, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9844), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9845), "Ordu", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9845) },
                    { 53, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9846), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9846), "Rize", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9846) },
                    { 54, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9847), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9848), "Sakarya", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9847) },
                    { 55, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9848), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9849), "Samsun", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9849) },
                    { 56, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9850), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9850), "Siirt", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9850) },
                    { 57, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9851), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9852), "Sinop", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9851) },
                    { 58, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9852), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9853), "Sivas", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9853) },
                    { 59, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9853), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9854), "Tekirdağ", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9854) },
                    { 60, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9855), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9855), "Tokat", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9855) },
                    { 61, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9856), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9857), "Trabzon", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9856) },
                    { 62, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9857), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9858), "Tunceli", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9858) },
                    { 63, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9858), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9859), "Şanlıurfa", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9859) },
                    { 64, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9860), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9860), "Uşak", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9860) },
                    { 65, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9861), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9862), "Van", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9861) },
                    { 66, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9862), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9863), "Yozgat", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9863) },
                    { 67, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9863), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9864), "Zonguldak", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9864) },
                    { 68, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9865), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9865), "Aksaray", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9865) },
                    { 69, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9866), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9867), "Bayburt", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9866) },
                    { 70, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9867), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9868), "Karaman", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9868) },
                    { 71, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9869), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9869), "Kırıkkale", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9869) },
                    { 72, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9870), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9870), "Batman", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9870) },
                    { 73, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9871), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9872), "Şırnak", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9871) },
                    { 74, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9872), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9873), "Bartın", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9873) },
                    { 75, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9874), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9874), "Ardahan", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9874) },
                    { 76, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9875), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9876), "Iğdır", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9875) },
                    { 77, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9876), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9877), "Yalova", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9876) },
                    { 78, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9877), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9878), "Karabük", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9878) },
                    { 79, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9879), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9879), "Kilis", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9879) },
                    { 80, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9880), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9881), "Osmaniye", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9880) },
                    { 81, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9881), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9882), "Düzce", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9882) }
                });

            migrationBuilder.InsertData(
                table: "DocumentTypes",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Name", "Status", "Type", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1865), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1866), "TcKimlik", false, "DosyaEvrak", new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1866) },
                    { 2, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1868), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1869), "Sici Kaydı", false, "KullaniciEvrak", new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1868) }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "ID", "Code", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[] { 1, "caseFile-list", new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9388), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9385), "Case File List", true, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "ID", "CityID", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9976), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9977), "ALADAĞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9977) },
                    { 2, 1, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9978), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9979), "CEYHAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9979) },
                    { 3, 1, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9980), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9981), "ÇUKUROVA", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9980) },
                    { 4, 1, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9981), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9982), "FEKE", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9982) },
                    { 5, 1, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9983), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9983), "İMAMOĞLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9983) },
                    { 6, 1, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9984), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9985), "KARAİSALI", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9984) },
                    { 7, 1, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9985), new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9986), "KARATAŞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 976, DateTimeKind.Local).AddTicks(9985) },
                    { 8, 1, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(25), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(27), "KOZAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(26) },
                    { 9, 1, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(27), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(28), "POZANTI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(28) },
                    { 10, 1, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(29), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(29), "SAİMBEYLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(29) },
                    { 11, 1, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(30), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(31), "SARIÇAM", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(30) },
                    { 12, 1, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(31), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(32), "SEYHAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(32) },
                    { 13, 1, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(33), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(33), "TUFANBEYLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(33) },
                    { 14, 1, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(34), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(35), "YUMURTALIK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(34) },
                    { 15, 1, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(35), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(36), "YÜREĞİR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(36) },
                    { 16, 2, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(37), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(37), "BESNİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(37) },
                    { 17, 2, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(38), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(39), "ÇELİKHAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(38) },
                    { 18, 2, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(39), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(40), "GERGER", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(40) },
                    { 19, 2, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(40), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(41), "GÖLBAŞI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(41) },
                    { 20, 2, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(42), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(42), "KAHTA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(42) },
                    { 21, 2, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(43), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(44), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(43) },
                    { 22, 2, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(44), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(45), "SAMSAT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(45) },
                    { 23, 2, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(46), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(46), "SİNCİK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(46) },
                    { 24, 2, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(47), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(48), "TUT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(47) },
                    { 25, 3, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(48), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(49), "BAŞMAKÇI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(49) },
                    { 26, 3, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(50), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(50), "BAYAT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(50) },
                    { 27, 3, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(51), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(52), "BOLVADİN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(51) },
                    { 28, 3, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(52), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(53), "ÇAY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(53) },
                    { 29, 3, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(54), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(54), "ÇOBANLAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(54) },
                    { 30, 3, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(56), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(56), "DAZKIRI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(56) },
                    { 31, 3, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(57), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(58), "DİNAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(57) },
                    { 32, 3, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(58), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(59), "EMİRDAĞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(59) },
                    { 33, 3, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(59), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(60), "EVCİLER", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(60) },
                    { 34, 3, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(62), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(62), "HOCALAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(62) },
                    { 35, 3, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(63), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(64), "İHSANİYE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(63) },
                    { 36, 3, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(64), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(65), "İSCEHİSAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(65) },
                    { 37, 3, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(65), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(66), "KIZILÖREN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(66) },
                    { 38, 3, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(67), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(68), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(67) },
                    { 39, 3, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(68), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(69), "SANDIKLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(68) },
                    { 40, 3, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(69), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(70), "SİNANPAŞA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(70) },
                    { 41, 3, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(71), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(71), "SULTANDAĞI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(71) },
                    { 42, 3, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(72), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(73), "ŞUHUT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(72) },
                    { 43, 4, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(73), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(74), "DİYADİN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(74) },
                    { 44, 4, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(75), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(75), "DOĞUBAYAZIT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(75) },
                    { 45, 4, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(76), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(77), "ELEŞKİRT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(76) },
                    { 46, 4, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(77), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(78), "HAMUR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(78) },
                    { 47, 4, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(79), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(79), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(79) },
                    { 48, 4, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(80), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(81), "PATNOS", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(80) },
                    { 49, 4, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(81), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(82), "TAŞLIÇAY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(82) },
                    { 50, 4, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(82), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(83), "TUTAK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(83) },
                    { 51, 5, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(84), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(84), "GÖYNÜCEK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(84) },
                    { 52, 5, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(85), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(86), "GÜMÜŞHACIKÖY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(85) },
                    { 53, 5, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(86), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(87), "HAMAMÖZÜ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(87) },
                    { 54, 5, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(88), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(88), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(88) },
                    { 55, 5, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(89), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(90), "MERZİFON", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(89) },
                    { 56, 5, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(90), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(91), "SULUOVA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(91) },
                    { 57, 5, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(92), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(92), "TAŞOVA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(92) },
                    { 58, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(93), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(94), "AKYURT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(93) },
                    { 59, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(94), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(95), "ALTINDAĞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(95) },
                    { 60, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(95), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(96), "AYAŞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(96) },
                    { 61, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(97), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(98), "BALA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(97) },
                    { 62, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(98), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(99), "BEYPAZARI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(98) },
                    { 63, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(99), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(100), "ÇAMLIDERE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(100) },
                    { 64, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(101), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(101), "ÇANKAYA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(101) },
                    { 65, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(102), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(103), "ÇUBUK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(102) },
                    { 66, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(103), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(104), "ELMADAĞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(104) },
                    { 67, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(105), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(106), "ETİMESGUT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(106) },
                    { 68, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(107), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(107), "EVREN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(107) },
                    { 69, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(108), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(109), "GÖLBAŞI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(108) },
                    { 70, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(109), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(110), "GÜDÜL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(110) },
                    { 71, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(111), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(111), "HAYMANA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(111) },
                    { 72, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(112), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(113), "KAHRAMANKAZAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(112) },
                    { 73, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(113), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(114), "KALECİK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(114) },
                    { 74, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(114), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(115), "KEÇİÖREN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(115) },
                    { 75, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(116), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(117), "KIZILCAHAMAM", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(116) },
                    { 76, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(117), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(118), "MAMAK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(117) },
                    { 77, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(118), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(119), "NALLIHAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(119) },
                    { 78, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(120), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(121), "POLATLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(120) },
                    { 79, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(122), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(123), "PURSAKLAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(122) },
                    { 80, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(144), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(147), "SİNCAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(147) },
                    { 81, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(148), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(148), "ŞEREFLİKOÇHİSAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(148) },
                    { 82, 6, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(149), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(150), "YENİMAHALLE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(149) },
                    { 83, 7, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(150), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(151), "AKSEKİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(151) },
                    { 84, 7, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(152), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(152), "AKSU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(152) },
                    { 85, 7, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(154), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(154), "ALANYA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(154) },
                    { 86, 7, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(157), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(158), "DEMRE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(157) },
                    { 87, 7, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(158), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(159), "DÖŞEMEALTI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(158) },
                    { 88, 7, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(160), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(161), "ELMALI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(160) },
                    { 89, 7, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(163), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(163), "FİNİKE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(163) },
                    { 90, 7, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(165), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(165), "GAZİPAŞA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(165) },
                    { 91, 7, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(168), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(169), "GÜNDOĞMUŞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(169) },
                    { 92, 7, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(169), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(170), "İBRADI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(170) },
                    { 93, 7, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(172), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(172), "KAŞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(172) },
                    { 94, 7, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(173), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(174), "KEMER", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(173) },
                    { 95, 7, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(174), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(175), "KEPEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(175) },
                    { 96, 7, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(177), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(178), "KONYAALTI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(178) },
                    { 97, 7, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(178), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(179), "KORKUTELİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(179) },
                    { 98, 7, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(180), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(181), "KUMLUCA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(180) },
                    { 99, 7, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(181), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(182), "MANAVGAT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(181) },
                    { 100, 7, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(182), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(183), "MURATPAŞA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(183) },
                    { 101, 7, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(184), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(184), "SERİK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(184) },
                    { 102, 8, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(185), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(186), "ARDANUÇ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(185) },
                    { 103, 8, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(186), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(187), "ARHAVİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(187) },
                    { 104, 8, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(188), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(188), "BORÇKA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(188) },
                    { 105, 8, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(189), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(190), "HOPA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(189) },
                    { 106, 8, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(190), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(191), "KEMALPAŞA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(191) },
                    { 107, 8, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(192), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(192), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(192) },
                    { 108, 8, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(193), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(194), "MURGUL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(193) },
                    { 109, 8, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(194), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(195), "ŞAVŞAT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(195) },
                    { 110, 8, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(196), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(196), "YUSUFELİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(196) },
                    { 111, 9, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(197), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(198), "BOZDOĞAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(197) },
                    { 112, 9, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(198), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(199), "BUHARKENT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(199) },
                    { 113, 9, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(200), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(200), "ÇİNE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(200) },
                    { 114, 9, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(201), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(202), "DİDİM", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(201) },
                    { 115, 9, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(202), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(203), "EFELER", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(202) },
                    { 116, 9, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(203), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(204), "GERMENCİK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(204) },
                    { 117, 9, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(205), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(205), "İNCİRLİOVA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(205) },
                    { 118, 9, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(206), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(207), "KARACASU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(206) },
                    { 119, 9, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(207), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(208), "KARPUZLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(208) },
                    { 120, 9, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(209), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(209), "KOÇARLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(209) },
                    { 121, 9, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(210), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(211), "KÖŞK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(210) },
                    { 122, 9, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(211), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(212), "KUŞADASI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(212) },
                    { 123, 9, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(213), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(213), "KUYUCAK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(213) },
                    { 124, 9, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(214), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(215), "NAZİLLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(214) },
                    { 125, 9, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(215), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(216), "SÖKE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(216) },
                    { 126, 9, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(217), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(217), "SULTANHİSAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(217) },
                    { 127, 9, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(218), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(219), "YENİPAZAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(218) },
                    { 128, 10, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(219), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(220), "ALTIEYLÜL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(220) },
                    { 129, 10, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(220), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(221), "AYVALIK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(221) },
                    { 130, 10, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(222), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(222), "BALYA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(222) },
                    { 131, 10, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(223), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(224), "BANDIRMA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(223) },
                    { 132, 10, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(224), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(225), "BİGADİÇ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(225) },
                    { 133, 10, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(226), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(226), "BURHANİYE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(226) },
                    { 134, 10, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(227), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(228), "DURSUNBEY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(227) },
                    { 135, 10, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(228), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(229), "EDREMİT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(229) },
                    { 136, 10, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(230), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(230), "ERDEK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(230) },
                    { 137, 10, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(232), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(232), "GÖMEÇ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(232) },
                    { 138, 10, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(233), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(234), "GÖNEN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(233) },
                    { 139, 10, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(234), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(235), "HAVRAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(235) },
                    { 140, 10, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(236), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(236), "İVRİNDİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(236) },
                    { 141, 10, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(237), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(238), "KARESİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(237) },
                    { 142, 10, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(238), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(239), "KEPSUT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(239) },
                    { 143, 10, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(239), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(240), "MANYAS", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(240) },
                    { 144, 10, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(241), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(241), "MARMARA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(241) },
                    { 145, 10, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(242), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(243), "SAVAŞTEPE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(242) },
                    { 146, 10, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(243), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(244), "SINDIRGI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(244) },
                    { 147, 10, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(245), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(245), "SUSURLUK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(245) },
                    { 148, 11, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(246), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(247), "BOZÜYÜK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(246) },
                    { 149, 11, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(247), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(248), "GÖLPAZARI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(248) },
                    { 150, 11, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(249), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(249), "İNHİSAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(249) },
                    { 151, 11, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(250), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(251), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(250) },
                    { 152, 11, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(251), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(252), "OSMANELİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(252) },
                    { 153, 11, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(274), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(277), "PAZARYERİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(276) },
                    { 154, 11, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(277), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(278), "SÖĞÜT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(278) },
                    { 155, 11, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(279), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(280), "YENİPAZAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(279) },
                    { 156, 12, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(280), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(281), "ADAKLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(281) },
                    { 157, 12, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(282), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(282), "GENÇ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(282) },
                    { 158, 12, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(283), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(284), "KARLIOVA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(283) },
                    { 159, 12, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(284), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(285), "KİĞI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(285) },
                    { 160, 12, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(285), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(286), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(286) },
                    { 161, 12, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(287), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(288), "SOLHAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(287) },
                    { 162, 12, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(288), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(289), "YAYLADERE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(289) },
                    { 163, 12, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(289), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(290), "YEDİSU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(290) },
                    { 164, 13, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(291), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(292), "ADİLCEVAZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(291) },
                    { 165, 13, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(292), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(293), "AHLAT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(293) },
                    { 166, 13, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(294), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(294), "GÜROYMAK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(294) },
                    { 167, 13, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(295), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(296), "HİZAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(295) },
                    { 168, 13, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(296), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(297), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(297) },
                    { 169, 13, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(297), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(298), "MUTKİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(298) },
                    { 170, 13, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(299), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(300), "TATVAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(299) },
                    { 171, 14, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(300), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(301), "DÖRTDİVAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(301) },
                    { 172, 14, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(301), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(302), "GEREDE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(302) },
                    { 173, 14, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(303), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(304), "GÖYNÜK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(303) },
                    { 174, 14, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(304), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(305), "KIBRISCIK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(305) },
                    { 175, 14, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(306), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(306), "MENGEN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(306) },
                    { 176, 14, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(307), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(308), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(307) },
                    { 177, 14, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(308), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(309), "MUDURNU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(309) },
                    { 178, 14, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(309), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(310), "SEBEN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(310) },
                    { 179, 14, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(311), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(312), "YENİÇAĞA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(311) },
                    { 180, 15, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(312), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(313), "AĞLASUN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(312) },
                    { 181, 15, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(313), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(314), "ALTINYAYLA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(314) },
                    { 182, 15, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(315), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(316), "BUCAK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(315) },
                    { 183, 15, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(316), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(317), "ÇAVDIR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(316) },
                    { 184, 15, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(317), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(318), "ÇELTİKÇİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(318) },
                    { 185, 15, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(320), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(320), "GÖLHİSAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(320) },
                    { 186, 15, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(321), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(322), "KARAMANLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(321) },
                    { 187, 15, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(322), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(323), "KEMER", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(323) },
                    { 188, 15, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(324), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(325), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(325) },
                    { 189, 15, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(326), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(327), "TEFENNİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(326) },
                    { 190, 15, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(327), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(328), "YEŞİLOVA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(328) },
                    { 191, 16, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(329), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(329), "BÜYÜKORHAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(329) },
                    { 192, 16, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(330), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(331), "GEMLİK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(330) },
                    { 193, 16, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(331), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(332), "GÜRSU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(332) },
                    { 194, 16, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(333), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(333), "HARMANCIK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(333) },
                    { 195, 16, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(335), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(336), "İNEGÖL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(335) },
                    { 196, 16, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(336), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(337), "İZNİK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(337) },
                    { 197, 16, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(338), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(338), "KARACABEY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(338) },
                    { 198, 16, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(339), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(340), "KELES", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(339) },
                    { 199, 16, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(340), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(341), "KESTEL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(341) },
                    { 200, 16, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(341), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(342), "MUDANYA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(342) },
                    { 201, 16, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(343), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(344), "MUSTAFAKEMALPAŞA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(343) },
                    { 202, 16, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(344), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(345), "NİLÜFER", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(345) },
                    { 203, 16, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(345), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(346), "ORHANELİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(346) },
                    { 204, 16, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(347), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(348), "ORHANGAZİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(347) },
                    { 205, 16, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(348), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(349), "OSMANGAZİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(348) },
                    { 206, 16, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(349), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(350), "YENİŞEHİR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(350) },
                    { 207, 16, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(351), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(352), "YILDIRIM", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(351) },
                    { 208, 17, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(352), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(353), "AYVACIK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(352) },
                    { 209, 17, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(353), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(354), "BAYRAMİÇ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(354) },
                    { 210, 17, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(355), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(356), "BİGA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(355) },
                    { 211, 17, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(356), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(357), "BOZCAADA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(356) },
                    { 212, 17, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(357), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(358), "ÇAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(358) },
                    { 213, 17, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(359), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(359), "ECEABAT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(359) },
                    { 214, 17, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(361), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(362), "EZİNE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(361) },
                    { 215, 17, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(363), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(363), "GELİBOLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(363) },
                    { 216, 17, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(364), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(365), "GÖKÇEADA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(364) },
                    { 217, 17, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(365), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(366), "LAPSEKİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(366) },
                    { 218, 17, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(367), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(367), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(367) },
                    { 219, 17, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(368), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(369), "YENİCE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(369) },
                    { 220, 18, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(370), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(370), "ATKARACALAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(370) },
                    { 221, 18, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(371), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(372), "BAYRAMÖREN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(371) },
                    { 222, 18, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(372), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(373), "ÇERKEŞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(373) },
                    { 223, 18, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(373), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(374), "ELDİVAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(374) },
                    { 224, 18, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(375), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(376), "ILGAZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(375) },
                    { 225, 18, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(376), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(377), "KIZILIRMAK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(376) },
                    { 226, 18, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(409), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(412), "KORGUN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(412) },
                    { 227, 18, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(414), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(414), "KURŞUNLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(414) },
                    { 228, 18, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(415), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(416), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(415) },
                    { 229, 18, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(416), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(417), "ORTA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(417) },
                    { 230, 18, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(418), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(418), "ŞABANÖZÜ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(418) },
                    { 231, 18, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(419), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(420), "YAPRAKLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(419) },
                    { 232, 19, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(420), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(421), "ALACA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(421) },
                    { 233, 19, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(422), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(422), "BAYAT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(422) },
                    { 234, 19, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(423), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(424), "BOĞAZKALE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(423) },
                    { 235, 19, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(424), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(425), "DODURGA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(425) },
                    { 236, 19, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(425), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(426), "İSKİLİP", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(426) },
                    { 237, 19, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(427), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(428), "KARGI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(427) },
                    { 238, 19, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(428), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(429), "LAÇİN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(428) },
                    { 239, 19, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(429), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(430), "MECİTÖZÜ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(430) },
                    { 240, 19, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(431), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(431), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(431) },
                    { 241, 19, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(432), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(433), "OĞUZLAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(432) },
                    { 242, 19, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(433), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(434), "ORTAKÖY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(434) },
                    { 243, 19, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(435), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(435), "OSMANCIK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(435) },
                    { 244, 19, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(436), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(437), "SUNGURLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(436) },
                    { 245, 19, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(437), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(438), "UĞURLUDAĞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(437) },
                    { 246, 20, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(438), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(439), "ACIPAYAM", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(439) },
                    { 247, 20, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(440), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(441), "BABADAĞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(440) },
                    { 248, 20, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(441), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(442), "BAKLAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(441) },
                    { 249, 20, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(442), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(443), "BEKİLLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(443) },
                    { 250, 20, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(444), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(444), "BEYAĞAÇ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(444) },
                    { 251, 20, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(445), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(446), "BOZKURT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(445) },
                    { 252, 20, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(446), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(447), "BULDAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(447) },
                    { 253, 20, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(448), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(448), "ÇAL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(448) },
                    { 254, 20, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(449), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(450), "ÇAMELİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(449) },
                    { 255, 20, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(450), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(451), "ÇARDAK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(451) },
                    { 256, 20, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(451), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(452), "ÇİVRİL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(452) },
                    { 257, 20, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(453), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(453), "GÜNEY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(453) },
                    { 258, 20, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(454), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(455), "HONAZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(454) },
                    { 259, 20, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(455), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(456), "KALE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(456) },
                    { 260, 20, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(457), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(457), "MERKEZEFENDİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(457) },
                    { 261, 20, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(458), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(459), "PAMUKKALE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(458) },
                    { 262, 20, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(459), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(460), "SARAYKÖY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(460) },
                    { 263, 20, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(461), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(461), "SERİNHİSAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(461) },
                    { 264, 20, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(462), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(463), "TAVAS", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(462) },
                    { 265, 21, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(463), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(464), "BAĞLAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(464) },
                    { 266, 21, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(464), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(465), "BİSMİL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(465) },
                    { 267, 21, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(466), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(467), "ÇERMİK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(466) },
                    { 268, 21, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(467), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(468), "ÇINAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(467) },
                    { 269, 21, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(468), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(469), "ÇÜNGÜŞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(469) },
                    { 270, 21, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(470), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(470), "DİCLE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(470) },
                    { 271, 21, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(471), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(472), "EĞİL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(471) },
                    { 272, 21, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(472), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(473), "ERGANİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(473) },
                    { 273, 21, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(474), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(474), "HANİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(474) },
                    { 274, 21, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(475), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(476), "HAZRO", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(475) },
                    { 275, 21, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(476), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(477), "KAYAPINAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(477) },
                    { 276, 21, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(477), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(478), "KOCAKÖY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(478) },
                    { 277, 21, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(479), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(479), "KULP", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(479) },
                    { 278, 21, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(480), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(481), "LİCE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(480) },
                    { 279, 21, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(481), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(482), "SİLVAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(482) },
                    { 280, 21, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(483), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(483), "SUR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(483) },
                    { 281, 21, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(484), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(485), "YENİŞEHİR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(484) },
                    { 282, 22, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(485), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(486), "ENEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(486) },
                    { 283, 22, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(487), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(487), "HAVSA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(487) },
                    { 284, 22, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(489), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(490), "İPSALA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(490) },
                    { 285, 22, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(490), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(491), "KEŞAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(491) },
                    { 286, 22, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(492), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(493), "LALAPAŞA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(492) },
                    { 287, 22, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(493), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(494), "MERİÇ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(493) },
                    { 288, 22, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(494), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(495), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(495) },
                    { 289, 22, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(496), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(497), "SÜLOĞLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(497) },
                    { 290, 22, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(498), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(499), "UZUNKÖPRÜ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(498) },
                    { 291, 23, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(499), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(500), "AĞIN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(499) },
                    { 292, 23, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(500), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(501), "ALACAKAYA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(501) },
                    { 293, 23, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(502), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(502), "ARICAK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(502) },
                    { 294, 23, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(503), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(504), "BASKİL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(503) },
                    { 295, 23, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(504), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(505), "KARAKOÇAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(505) },
                    { 296, 23, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(506), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(506), "KEBAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(506) },
                    { 297, 23, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(508), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(508), "KOVANCILAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(508) },
                    { 298, 23, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(509), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(510), "MADEN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(509) },
                    { 299, 23, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(551), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(552), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(552) },
                    { 300, 23, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(553), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(554), "PALU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(554) },
                    { 301, 23, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(555), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(555), "SİVRİCE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(555) },
                    { 302, 24, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(556), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(557), "ÇAYIRLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(556) },
                    { 303, 24, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(557), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(558), "İLİÇ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(558) },
                    { 304, 24, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(559), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(560), "KEMAH", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(560) },
                    { 305, 24, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(561), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(561), "KEMALİYE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(561) },
                    { 306, 24, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(562), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(563), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(562) },
                    { 307, 24, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(563), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(564), "OTLUKBELİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(564) },
                    { 308, 24, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(565), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(565), "REFAHİYE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(565) },
                    { 309, 24, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(566), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(567), "TERCAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(566) },
                    { 310, 24, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(568), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(569), "ÜZÜMLÜ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(569) },
                    { 311, 25, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(569), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(570), "AŞKALE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(570) },
                    { 312, 25, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(571), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(572), "AZİZİYE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(571) },
                    { 313, 25, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(572), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(573), "ÇAT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(573) },
                    { 314, 25, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(574), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(575), "HINIS", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(575) },
                    { 315, 25, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(576), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(577), "HORASAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(577) },
                    { 316, 25, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(577), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(578), "İSPİR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(578) },
                    { 317, 25, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(579), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(580), "KARAÇOBAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(579) },
                    { 318, 25, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(581), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(582), "KARAYAZI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(581) },
                    { 319, 25, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(582), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(583), "KÖPRÜKÖY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(583) },
                    { 320, 25, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(584), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(584), "NARMAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(584) },
                    { 321, 25, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(585), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(586), "OLTU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(585) },
                    { 322, 25, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(586), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(587), "OLUR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(587) },
                    { 323, 25, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(588), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(588), "PALANDÖKEN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(588) },
                    { 324, 25, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(589), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(590), "PASİNLER", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(589) },
                    { 325, 25, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(590), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(591), "PAZARYOLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(591) },
                    { 326, 25, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(591), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(592), "ŞENKAYA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(592) },
                    { 327, 25, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(594), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(595), "TEKMAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(595) },
                    { 328, 25, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(596), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(597), "TORTUM", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(597) },
                    { 329, 25, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(598), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(598), "UZUNDERE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(598) },
                    { 330, 25, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(599), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(600), "YAKUTİYE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(599) },
                    { 331, 26, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(600), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(601), "ALPU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(601) },
                    { 332, 26, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(602), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(602), "BEYLİKOVA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(602) },
                    { 333, 26, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(603), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(604), "ÇİFTELER", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(603) },
                    { 334, 26, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(604), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(605), "GÜNYÜZÜ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(605) },
                    { 335, 26, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(606), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(606), "HAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(606) },
                    { 336, 26, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(607), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(608), "İNÖNÜ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(607) },
                    { 337, 26, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(608), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(609), "MAHMUDİYE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(609) },
                    { 338, 26, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(610), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(610), "MİHALGAZİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(610) },
                    { 339, 26, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(611), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(612), "MİHALIÇÇIK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(611) },
                    { 340, 26, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(613), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(614), "ODUNPAZARI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(613) },
                    { 341, 26, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(614), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(615), "SARICAKAYA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(615) },
                    { 342, 26, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(616), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(616), "SEYİTGAZİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(616) },
                    { 343, 26, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(617), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(618), "SİVRİHİSAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(617) },
                    { 344, 26, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(618), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(619), "TEPEBAŞI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(619) },
                    { 345, 27, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(620), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(620), "ARABAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(620) },
                    { 346, 27, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(621), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(622), "İSLAHİYE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(621) },
                    { 347, 27, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(622), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(623), "KARKAMIŞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(623) },
                    { 348, 27, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(623), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(624), "NİZİP", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(624) },
                    { 349, 27, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(625), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(626), "NURDAĞI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(626) },
                    { 350, 27, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(629), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(630), "OĞUZELİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(629) },
                    { 351, 27, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(630), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(631), "ŞAHİNBEY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(631) },
                    { 352, 27, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(632), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(632), "ŞEHİTKAMİL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(632) },
                    { 353, 27, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(634), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(634), "YAVUZELİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(634) },
                    { 354, 28, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(635), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(636), "ALUCRA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(635) },
                    { 355, 28, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(636), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(637), "BULANCAK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(637) },
                    { 356, 28, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(638), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(638), "ÇAMOLUK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(638) },
                    { 357, 28, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(639), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(640), "ÇANAKÇI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(639) },
                    { 358, 28, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(640), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(641), "DERELİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(641) },
                    { 359, 28, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(642), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(642), "DOĞANKENT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(642) },
                    { 360, 28, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(643), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(644), "ESPİYE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(643) },
                    { 361, 28, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(644), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(645), "EYNESİL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(645) },
                    { 362, 28, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(645), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(646), "GÖRELE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(646) },
                    { 363, 28, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(647), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(648), "GÜCE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(647) },
                    { 364, 28, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(648), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(649), "KEŞAP", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(649) },
                    { 365, 28, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(649), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(650), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(650) },
                    { 366, 28, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(651), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(652), "PİRAZİZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(651) },
                    { 367, 28, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(652), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(653), "ŞEBİNKARAHİSAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(652) },
                    { 368, 28, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(653), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(654), "TİREBOLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(654) },
                    { 369, 28, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(655), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(655), "YAĞLIDERE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(655) },
                    { 370, 29, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(656), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(657), "KELKİT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(656) },
                    { 371, 29, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(657), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(658), "KÖSE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(658) },
                    { 372, 29, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(679), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(681), "KÜRTÜN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(680) },
                    { 373, 29, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(681), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(682), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(682) },
                    { 374, 29, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(683), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(683), "ŞİRAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(683) },
                    { 375, 29, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(684), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(685), "TORUL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(684) },
                    { 376, 30, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(685), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(686), "ÇUKURCA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(686) },
                    { 377, 30, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(687), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(687), "DERECİK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(687) },
                    { 378, 30, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(688), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(689), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(688) },
                    { 379, 30, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(689), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(690), "ŞEMDİNLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(690) },
                    { 380, 30, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(691), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(691), "YÜKSEKOVA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(691) },
                    { 381, 31, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(692), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(693), "ALTINÖZÜ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(692) },
                    { 382, 31, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(694), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(695), "ANTAKYA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(694) },
                    { 383, 31, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(695), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(696), "ARSUZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(696) },
                    { 384, 31, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(696), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(697), "BELEN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(697) },
                    { 385, 31, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(699), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(700), "DEFNE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(699) },
                    { 386, 31, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(700), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(701), "DÖRTYOL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(701) },
                    { 387, 31, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(702), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(702), "ERZİN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(702) },
                    { 388, 31, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(703), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(704), "HASSA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(703) },
                    { 389, 31, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(704), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(705), "İSKENDERUN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(705) },
                    { 390, 31, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(706), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(706), "KIRIKHAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(706) },
                    { 391, 31, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(707), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(708), "KUMLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(707) },
                    { 392, 31, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(708), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(709), "PAYAS", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(709) },
                    { 393, 31, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(710), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(711), "REYHANLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(710) },
                    { 394, 31, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(711), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(712), "SAMANDAĞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(711) },
                    { 395, 31, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(712), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(713), "YAYLADAĞI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(713) },
                    { 396, 32, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(714), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(714), "AKSU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(714) },
                    { 397, 32, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(715), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(716), "ATABEY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(715) },
                    { 398, 32, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(716), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(717), "EĞİRDİR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(717) },
                    { 399, 32, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(718), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(718), "GELENDOST", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(718) },
                    { 400, 32, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(719), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(720), "GÖNEN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(719) },
                    { 401, 32, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(720), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(721), "KEÇİBORLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(721) },
                    { 402, 32, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(722), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(722), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(722) },
                    { 403, 32, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(723), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(724), "SENİRKENT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(724) },
                    { 404, 32, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(724), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(725), "SÜTÇÜLER", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(725) },
                    { 405, 32, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(726), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(727), "ŞARKİKARAAĞAÇ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(726) },
                    { 406, 32, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(727), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(728), "ULUBORLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(727) },
                    { 407, 32, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(728), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(729), "YALVAÇ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(729) },
                    { 408, 32, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(730), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(730), "YENİŞARBADEMLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(730) },
                    { 409, 33, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(731), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(732), "AKDENİZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(731) },
                    { 410, 33, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(732), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(733), "ANAMUR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(733) },
                    { 411, 33, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(734), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(734), "AYDINCIK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(734) },
                    { 412, 33, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(735), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(736), "BOZYAZI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(735) },
                    { 413, 33, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(736), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(737), "ÇAMLIYAYLA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(737) },
                    { 414, 33, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(738), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(738), "ERDEMLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(738) },
                    { 415, 33, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(739), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(740), "GÜLNAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(739) },
                    { 416, 33, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(740), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(741), "MEZİTLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(741) },
                    { 417, 33, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(742), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(742), "MUT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(742) },
                    { 418, 33, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(743), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(744), "SİLİFKE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(743) },
                    { 419, 33, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(744), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(745), "TARSUS", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(745) },
                    { 420, 33, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(746), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(746), "TOROSLAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(746) },
                    { 421, 33, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(747), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(748), "YENİŞEHİR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(747) },
                    { 422, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(748), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(749), "ADALAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(749) },
                    { 423, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(749), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(750), "ARNAVUTKÖY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(750) },
                    { 424, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(751), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(752), "ATAŞEHİR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(751) },
                    { 425, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(752), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(753), "AVCILAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(752) },
                    { 426, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(753), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(754), "BAĞCILAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(754) },
                    { 427, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(755), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(755), "BAHÇELİEVLER", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(755) },
                    { 428, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(756), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(757), "BAKIRKÖY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(756) },
                    { 429, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(757), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(758), "BAŞAKŞEHİR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(758) },
                    { 430, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(759), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(759), "BAYRAMPAŞA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(759) },
                    { 431, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(760), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(761), "BEŞİKTAŞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(760) },
                    { 432, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(761), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(762), "BEYKOZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(762) },
                    { 433, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(763), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(763), "BEYLİKDÜZÜ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(763) },
                    { 434, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(764), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(765), "BEYOĞLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(764) },
                    { 435, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(765), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(766), "BÜYÜKÇEKMECE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(766) },
                    { 436, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(767), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(767), "ÇATALCA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(767) },
                    { 437, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(768), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(769), "ÇEKMEKÖY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(768) },
                    { 438, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(769), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(770), "ESENLER", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(770) },
                    { 439, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(771), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(771), "ESENYURT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(771) },
                    { 440, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(772), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(773), "EYÜPSULTAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(772) },
                    { 441, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(773), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(774), "FATİH", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(774) },
                    { 442, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(774), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(775), "GAZİOSMANPAŞA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(775) },
                    { 443, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(776), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(777), "GÜNGÖREN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(776) },
                    { 444, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(777), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(778), "KADIKÖY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(777) },
                    { 445, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(799), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(802), "KAĞITHANE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(802) },
                    { 446, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(803), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(803), "KARTAL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(803) },
                    { 447, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(804), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(805), "KÜÇÜKÇEKMECE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(804) },
                    { 448, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(805), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(806), "MALTEPE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(806) },
                    { 449, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(807), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(807), "PENDİK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(807) },
                    { 450, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(808), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(809), "SANCAKTEPE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(808) },
                    { 451, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(809), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(810), "SARIYER", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(810) },
                    { 452, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(811), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(811), "SİLİVRİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(811) },
                    { 453, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(812), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(813), "SULTANBEYLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(812) },
                    { 454, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(813), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(814), "SULTANGAZİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(814) },
                    { 455, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(815), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(815), "ŞİLE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(815) },
                    { 456, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(816), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(817), "ŞİŞLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(816) },
                    { 457, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(817), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(818), "TUZLA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(818) },
                    { 458, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(818), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(819), "ÜMRANİYE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(819) },
                    { 459, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(820), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(820), "ÜSKÜDAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(820) },
                    { 460, 34, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(821), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(822), "ZEYTİNBURNU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(821) },
                    { 461, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(822), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(823), "ALİAĞA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(823) },
                    { 462, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(824), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(824), "BALÇOVA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(824) },
                    { 463, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(825), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(826), "BAYINDIR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(825) },
                    { 464, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(826), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(827), "BAYRAKLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(827) },
                    { 465, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(828), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(828), "BERGAMA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(828) },
                    { 466, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(829), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(830), "BEYDAĞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(829) },
                    { 467, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(830), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(831), "BORNOVA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(831) },
                    { 468, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(832), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(832), "BUCA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(832) },
                    { 469, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(833), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(834), "ÇEŞME", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(833) },
                    { 470, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(834), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(835), "ÇİĞLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(835) },
                    { 471, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(835), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(836), "DİKİLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(836) },
                    { 472, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(837), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(837), "FOÇA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(837) },
                    { 473, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(838), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(839), "GAZİEMİR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(838) },
                    { 474, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(839), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(840), "GÜZELBAHÇE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(840) },
                    { 475, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(841), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(841), "KARABAĞLAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(841) },
                    { 476, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(842), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(843), "KARABURUN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(842) },
                    { 477, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(843), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(844), "KARŞIYAKA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(844) },
                    { 478, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(845), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(845), "KEMALPAŞA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(845) },
                    { 479, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(846), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(847), "KINIK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(846) },
                    { 480, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(848), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(849), "KİRAZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(848) },
                    { 481, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(849), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(850), "KONAK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(850) },
                    { 482, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(851), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(851), "MENDERES", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(851) },
                    { 483, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(852), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(853), "MENEMEN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(852) },
                    { 484, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(853), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(854), "NARLIDERE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(854) },
                    { 485, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(855), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(856), "ÖDEMİŞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(855) },
                    { 486, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(856), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(857), "SEFERİHİSAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(856) },
                    { 487, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(857), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(858), "SELÇUK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(858) },
                    { 488, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(859), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(859), "TİRE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(859) },
                    { 489, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(860), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(861), "TORBALI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(860) },
                    { 490, 35, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(861), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(862), "URLA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(862) },
                    { 491, 36, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(863), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(863), "AKYAKA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(863) },
                    { 492, 36, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(864), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(865), "ARPAÇAY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(864) },
                    { 493, 36, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(866), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(867), "DİGOR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(866) },
                    { 494, 36, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(867), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(868), "KAĞIZMAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(868) },
                    { 495, 36, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(869), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(869), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(869) },
                    { 496, 36, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(870), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(871), "SARIKAMIŞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(870) },
                    { 497, 36, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(871), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(872), "SELİM", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(872) },
                    { 498, 36, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(873), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(873), "SUSUZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(873) },
                    { 499, 37, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(874), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(875), "ABANA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(874) },
                    { 500, 37, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(875), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(876), "AĞLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(875) },
                    { 501, 37, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(876), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(877), "ARAÇ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(877) },
                    { 502, 37, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(878), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(879), "AZDAVAY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(878) },
                    { 503, 37, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(879), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(880), "BOZKURT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(879) },
                    { 504, 37, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(880), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(881), "CİDE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(881) },
                    { 505, 37, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(882), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(882), "ÇATALZEYTİN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(882) },
                    { 506, 37, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(883), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(884), "DADAY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(883) },
                    { 507, 37, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(884), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(885), "DEVREKANİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(885) },
                    { 508, 37, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(886), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(886), "DOĞANYURT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(886) },
                    { 509, 37, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(887), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(888), "HANÖNÜ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(887) },
                    { 510, 37, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(888), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(889), "İHSANGAZİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(889) },
                    { 511, 37, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(891), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(892), "İNEBOLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(892) },
                    { 512, 37, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(893), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(893), "KÜRE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(893) },
                    { 513, 37, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(894), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(895), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(894) },
                    { 514, 37, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(895), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(896), "PINARBAŞI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(896) },
                    { 515, 37, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(897), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(897), "SEYDİLER", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(897) },
                    { 516, 37, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(898), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(899), "ŞENPAZAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(898) },
                    { 517, 37, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(899), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(900), "TAŞKÖPRÜ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(900) },
                    { 518, 37, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(922), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(925), "TOSYA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(924) },
                    { 519, 38, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(925), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(926), "AKKIŞLA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(926) },
                    { 520, 38, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(927), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(927), "BÜNYAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(927) },
                    { 521, 38, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(928), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(929), "DEVELİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(928) },
                    { 522, 38, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(929), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(930), "FELAHİYE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(930) },
                    { 523, 38, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(930), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(931), "HACILAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(931) },
                    { 524, 38, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(932), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(933), "İNCESU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(932) },
                    { 525, 38, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(933), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(934), "KOCASİNAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(933) },
                    { 526, 38, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(934), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(935), "MELİKGAZİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(935) },
                    { 527, 38, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(936), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(936), "ÖZVATAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(936) },
                    { 528, 38, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(937), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(938), "PINARBAŞI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(937) },
                    { 529, 38, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(938), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(939), "SARIOĞLAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(939) },
                    { 530, 38, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(940), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(940), "SARIZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(940) },
                    { 531, 38, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(941), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(942), "TALAS", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(941) },
                    { 532, 38, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(942), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(943), "TOMARZA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(943) },
                    { 533, 38, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(944), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(944), "YAHYALI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(944) },
                    { 534, 38, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(945), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(946), "YEŞİLHİSAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(945) },
                    { 535, 39, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(946), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(947), "BABAESKİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(946) },
                    { 536, 39, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(947), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(948), "DEMİRKÖY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(948) },
                    { 537, 39, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(949), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(949), "KOFÇAZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(949) },
                    { 538, 39, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(950), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(951), "LÜLEBURGAZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(950) },
                    { 539, 39, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(951), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(952), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(952) },
                    { 540, 39, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(953), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(953), "PEHLİVANKÖY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(953) },
                    { 541, 39, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(954), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(955), "PINARHİSAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(954) },
                    { 542, 39, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(955), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(956), "VİZE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(956) },
                    { 543, 40, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(957), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(957), "AKÇAKENT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(957) },
                    { 544, 40, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(958), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(959), "AKPINAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(958) },
                    { 545, 40, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(959), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(960), "BOZTEPE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(960) },
                    { 546, 40, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(960), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(961), "ÇİÇEKDAĞI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(961) },
                    { 547, 40, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(962), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(962), "KAMAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(962) },
                    { 548, 40, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(963), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(964), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(963) },
                    { 549, 40, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(964), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(965), "MUCUR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(965) },
                    { 550, 41, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(966), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(966), "BAŞİSKELE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(966) },
                    { 551, 41, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(967), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(968), "ÇAYIROVA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(967) },
                    { 552, 41, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(968), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(969), "DARICA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(969) },
                    { 553, 41, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(969), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(970), "DERİNCE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(970) },
                    { 554, 41, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(971), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(972), "DİLOVASI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(971) },
                    { 555, 41, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(972), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(973), "GEBZE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(972) },
                    { 556, 41, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(973), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(974), "GÖLCÜK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(974) },
                    { 557, 41, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(975), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(975), "İZMİT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(975) },
                    { 558, 41, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(976), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(977), "KANDIRA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(976) },
                    { 559, 41, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(977), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(978), "KARAMÜRSEL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(978) },
                    { 560, 41, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(979), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(979), "KARTEPE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(979) },
                    { 561, 41, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(980), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(981), "KÖRFEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(980) },
                    { 562, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(981), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(982), "AHIRLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(982) },
                    { 563, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(982), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(983), "AKÖREN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(983) },
                    { 564, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(984), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(984), "AKŞEHİR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(984) },
                    { 565, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(985), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(986), "ALTINEKİN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(985) },
                    { 566, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(986), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(987), "BEYŞEHİR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(987) },
                    { 567, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(988), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(988), "BOZKIR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(988) },
                    { 568, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(989), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(990), "CİHANBEYLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(989) },
                    { 569, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(990), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(991), "ÇELTİK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(991) },
                    { 570, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(992), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(992), "ÇUMRA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(992) },
                    { 571, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(993), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(994), "DERBENT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(993) },
                    { 572, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(994), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(995), "DEREBUCAK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(995) },
                    { 573, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(995), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(996), "DOĞANHİSAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(996) },
                    { 574, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(997), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(998), "EMİRGAZİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(997) },
                    { 575, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(998), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(999), "EREĞLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(998) },
                    { 576, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(999), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1000), "GÜNEYSINIR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1000) },
                    { 577, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1001), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1001), "HADİM", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1001) },
                    { 578, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1002), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1003), "HALKAPINAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1002) },
                    { 579, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1003), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1004), "HÜYÜK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1004) },
                    { 580, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1005), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1005), "ILGIN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1005) },
                    { 581, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1006), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1007), "KADINHANI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1006) },
                    { 582, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1007), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1008), "KARAPINAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1008) },
                    { 583, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1009), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1009), "KARATAY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1009) },
                    { 584, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1010), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1011), "KULU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1010) },
                    { 585, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1011), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1012), "MERAM", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1011) },
                    { 586, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1012), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1013), "SARAYÖNÜ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1013) },
                    { 587, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1014), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1014), "SELÇUKLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1014) },
                    { 588, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1015), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1016), "SEYDİŞEHİR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1015) },
                    { 589, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1016), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1017), "TAŞKENT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1017) },
                    { 590, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1018), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1018), "TUZLUKÇU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1018) },
                    { 591, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1039), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1041), "YALIHÜYÜK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1041) },
                    { 592, 42, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1042), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1043), "YUNAK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1042) },
                    { 593, 43, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1043), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1044), "ALTINTAŞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1044) },
                    { 594, 43, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1045), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1045), "ASLANAPA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1045) },
                    { 595, 43, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1046), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1047), "ÇAVDARHİSAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1046) },
                    { 596, 43, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1047), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1048), "DOMANİÇ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1048) },
                    { 597, 43, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1049), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1049), "DUMLUPINAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1049) },
                    { 598, 43, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1050), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1051), "EMET", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1050) },
                    { 599, 43, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1051), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1052), "GEDİZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1052) },
                    { 600, 43, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1052), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1053), "HİSARCIK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1053) },
                    { 601, 43, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1054), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1055), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1054) },
                    { 602, 43, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1055), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1056), "PAZARLAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1055) },
                    { 603, 43, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1056), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1057), "SİMAV", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1057) },
                    { 604, 43, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1058), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1058), "ŞAPHANE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1058) },
                    { 605, 43, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1059), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1060), "TAVŞANLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1059) },
                    { 606, 44, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1060), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1061), "AKÇADAĞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1061) },
                    { 607, 44, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1062), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1062), "ARAPGİR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1062) },
                    { 608, 44, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1063), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1064), "ARGUVAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1063) },
                    { 609, 44, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1064), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1065), "BATTALGAZİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1065) },
                    { 610, 44, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1065), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1066), "DARENDE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1066) },
                    { 611, 44, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1067), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1068), "DOĞANŞEHİR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1067) },
                    { 612, 44, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1068), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1069), "DOĞANYOL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1069) },
                    { 613, 44, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1069), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1070), "HEKİMHAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1070) },
                    { 614, 44, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1071), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1072), "KALE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1071) },
                    { 615, 44, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1072), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1073), "KULUNCAK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1072) },
                    { 616, 44, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1073), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1074), "PÜTÜRGE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1074) },
                    { 617, 44, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1075), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1075), "YAZIHAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1075) },
                    { 618, 44, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1076), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1077), "YEŞİLYURT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1076) },
                    { 619, 45, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1077), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1078), "AHMETLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1078) },
                    { 620, 45, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1079), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1079), "AKHİSAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1079) },
                    { 621, 45, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1080), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1081), "ALAŞEHİR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1080) },
                    { 622, 45, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1081), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1082), "DEMİRCİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1082) },
                    { 623, 45, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1083), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1083), "GÖLMARMARA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1083) },
                    { 624, 45, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1084), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1085), "GÖRDES", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1084) },
                    { 625, 45, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1085), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1086), "KIRKAĞAÇ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1086) },
                    { 626, 45, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1086), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1087), "KÖPRÜBAŞI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1087) },
                    { 627, 45, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1088), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1088), "KULA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1088) },
                    { 628, 45, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1089), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1090), "SALİHLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1089) },
                    { 629, 45, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1090), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1091), "SARIGÖL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1091) },
                    { 630, 45, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1092), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1093), "SARUHANLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1092) },
                    { 631, 45, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1093), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1094), "SELENDİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1093) },
                    { 632, 45, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1094), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1095), "SOMA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1095) },
                    { 633, 45, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1096), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1096), "ŞEHZADELER", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1096) },
                    { 634, 45, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1097), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1098), "TURGUTLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1097) },
                    { 635, 45, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1098), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1099), "YUNUSEMRE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1099) },
                    { 636, 46, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1100), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1100), "AFŞİN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1100) },
                    { 637, 46, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1101), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1102), "ANDIRIN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1101) },
                    { 638, 46, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1102), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1103), "ÇAĞLAYANCERİT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1103) },
                    { 639, 46, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1103), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1104), "DULKADİROĞLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1104) },
                    { 640, 46, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1105), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1106), "EKİNÖZÜ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1105) },
                    { 641, 46, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1106), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1107), "ELBİSTAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1106) },
                    { 642, 46, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1107), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1108), "GÖKSUN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1108) },
                    { 643, 46, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1109), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1109), "NURHAK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1109) },
                    { 644, 46, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1110), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1111), "ONİKİŞUBAT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1110) },
                    { 645, 46, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1111), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1112), "PAZARCIK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1112) },
                    { 646, 46, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1113), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1113), "TÜRKOĞLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1113) },
                    { 647, 47, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1114), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1115), "ARTUKLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1114) },
                    { 648, 47, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1115), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1116), "DARGEÇİT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1116) },
                    { 649, 47, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1117), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1117), "DERİK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1117) },
                    { 650, 47, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1118), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1119), "KIZILTEPE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1118) },
                    { 651, 47, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1119), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1120), "MAZIDAĞI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1120) },
                    { 652, 47, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1120), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1121), "MİDYAT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1121) },
                    { 653, 47, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1122), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1122), "NUSAYBİN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1122) },
                    { 654, 47, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1123), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1124), "ÖMERLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1123) },
                    { 655, 47, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1124), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1125), "SAVUR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1125) },
                    { 656, 47, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1126), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1126), "YEŞİLLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1126) },
                    { 657, 48, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1127), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1128), "BODRUM", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1127) },
                    { 658, 48, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1128), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1129), "DALAMAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1129) },
                    { 659, 48, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1130), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1130), "DATÇA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1130) },
                    { 660, 48, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1131), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1132), "FETHİYE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1131) },
                    { 661, 48, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1132), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1133), "KAVAKLIDERE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1132) },
                    { 662, 48, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1133), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1134), "KÖYCEĞİZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1134) },
                    { 663, 48, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1135), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1135), "MARMARİS", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1135) },
                    { 664, 48, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1155), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1158), "MENTEŞE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1158) },
                    { 665, 48, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1159), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1160), "MİLAS", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1159) },
                    { 666, 48, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1160), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1161), "ORTACA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1161) },
                    { 667, 48, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1162), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1162), "SEYDİKEMER", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1162) },
                    { 668, 48, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1163), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1164), "ULA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1163) },
                    { 669, 48, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1164), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1165), "YATAĞAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1165) },
                    { 670, 49, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1166), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1166), "BULANIK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1166) },
                    { 671, 49, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1167), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1168), "HASKÖY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1167) },
                    { 672, 49, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1168), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1169), "KORKUT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1168) },
                    { 673, 49, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1169), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1170), "MALAZGİRT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1170) },
                    { 674, 49, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1171), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1171), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1171) },
                    { 675, 49, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1172), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1173), "VARTO", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1172) },
                    { 676, 50, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1173), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1174), "ACIGÖL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1174) },
                    { 677, 50, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1175), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1175), "AVANOS", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1175) },
                    { 678, 50, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1176), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1177), "DERİNKUYU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1176) },
                    { 679, 50, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1177), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1178), "GÜLŞEHİR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1178) },
                    { 680, 50, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1178), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1179), "HACIBEKTAŞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1179) },
                    { 681, 50, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1180), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1180), "KOZAKLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1180) },
                    { 682, 50, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1181), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1182), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1181) },
                    { 683, 50, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1182), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1183), "ÜRGÜP", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1183) },
                    { 684, 51, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1184), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1184), "ALTUNHİSAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1184) },
                    { 685, 51, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1185), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1186), "BOR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1185) },
                    { 686, 51, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1186), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1187), "ÇAMARDI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1187) },
                    { 687, 51, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1188), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1188), "ÇİFTLİK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1188) },
                    { 688, 51, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1189), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1190), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1189) },
                    { 689, 51, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1190), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1191), "ULUKIŞLA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1190) },
                    { 690, 52, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1191), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1192), "AKKUŞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1192) },
                    { 691, 52, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1193), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1193), "ALTINORDU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1193) },
                    { 692, 52, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1194), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1195), "AYBASTI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1194) },
                    { 693, 52, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1195), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1196), "ÇAMAŞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1196) },
                    { 694, 52, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1197), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1197), "ÇATALPINAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1197) },
                    { 695, 52, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1198), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1199), "ÇAYBAŞI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1198) },
                    { 696, 52, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1199), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1200), "FATSA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1200) },
                    { 697, 52, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1200), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1201), "GÖLKÖY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1201) },
                    { 698, 52, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1202), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1202), "GÜLYALI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1202) },
                    { 699, 52, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1203), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1204), "GÜRGENTEPE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1203) },
                    { 700, 52, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1204), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1205), "İKİZCE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1205) },
                    { 701, 52, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1206), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1206), "KABADÜZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1206) },
                    { 702, 52, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1207), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1208), "KABATAŞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1207) },
                    { 703, 52, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1208), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1209), "KORGAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1209) },
                    { 704, 52, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1210), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1210), "KUMRU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1210) },
                    { 705, 52, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1211), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1212), "MESUDİYE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1211) },
                    { 706, 52, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1212), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1213), "PERŞEMBE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1212) },
                    { 707, 52, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1213), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1214), "ULUBEY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1214) },
                    { 708, 52, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1215), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1215), "ÜNYE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1215) },
                    { 709, 53, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1216), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1217), "ARDEŞEN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1216) },
                    { 710, 53, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1217), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1218), "ÇAMLIHEMŞİN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1218) },
                    { 711, 53, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1219), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1219), "ÇAYELİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1219) },
                    { 712, 53, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1220), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1221), "DEREPAZARI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1220) },
                    { 713, 53, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1221), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1222), "FINDIKLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1222) },
                    { 714, 53, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1222), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1223), "GÜNEYSU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1223) },
                    { 715, 53, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1224), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1224), "HEMŞİN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1224) },
                    { 716, 53, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1225), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1226), "İKİZDERE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1225) },
                    { 717, 53, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1226), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1227), "İYİDERE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1227) },
                    { 718, 53, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1228), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1228), "KALKANDERE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1228) },
                    { 719, 53, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1229), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1230), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1229) },
                    { 720, 53, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1230), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1231), "PAZAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1231) },
                    { 721, 54, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1232), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1232), "ADAPAZARI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1232) },
                    { 722, 54, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1233), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1234), "AKYAZI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1233) },
                    { 723, 54, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1234), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1235), "ARİFİYE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1235) },
                    { 724, 54, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1235), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1236), "ERENLER", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1236) },
                    { 725, 54, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1237), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1237), "FERİZLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1237) },
                    { 726, 54, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1238), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1239), "GEYVE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1238) },
                    { 727, 54, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1239), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1240), "HENDEK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1240) },
                    { 728, 54, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1241), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1241), "KARAPÜRÇEK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1241) },
                    { 729, 54, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1242), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1243), "KARASU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1242) },
                    { 730, 54, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1243), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1244), "KAYNARCA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1243) },
                    { 731, 54, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1244), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1245), "KOCAALİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1245) },
                    { 732, 54, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1246), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1246), "PAMUKOVA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1246) },
                    { 733, 54, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1247), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1248), "SAPANCA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1247) },
                    { 734, 54, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1248), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1249), "SERDİVAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1249) },
                    { 735, 54, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1250), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1250), "SÖĞÜTLÜ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1250) },
                    { 736, 54, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1251), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1252), "TARAKLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1251) },
                    { 737, 55, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1272), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1275), "ALAÇAM", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1275) },
                    { 738, 55, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1276), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1277), "ASARCIK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1276) },
                    { 739, 55, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1277), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1278), "ATAKUM", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1278) },
                    { 740, 55, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1278), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1279), "AYVACIK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1279) },
                    { 741, 55, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1280), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1281), "BAFRA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1280) },
                    { 742, 55, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1281), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1282), "CANİK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1281) },
                    { 743, 55, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1282), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1283), "ÇARŞAMBA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1283) },
                    { 744, 55, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1284), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1284), "HAVZA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1284) },
                    { 745, 55, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1285), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1286), "İLKADIM", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1285) },
                    { 746, 55, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1286), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1287), "KAVAK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1287) },
                    { 747, 55, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1288), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1288), "LADİK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1288) },
                    { 748, 55, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1289), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1290), "SALIPAZARI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1289) },
                    { 749, 55, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1290), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1291), "TEKKEKÖY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1291) },
                    { 750, 55, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1292), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1292), "TERME", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1292) },
                    { 751, 55, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1293), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1294), "VEZİRKÖPRÜ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1293) },
                    { 752, 55, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1294), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1295), "YAKAKENT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1295) },
                    { 753, 55, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1296), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1296), "19 MAYIS", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1296) },
                    { 754, 56, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1297), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1298), "BAYKAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1297) },
                    { 755, 56, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1298), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1299), "ERUH", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1299) },
                    { 756, 56, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1300), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1300), "KURTALAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1300) },
                    { 757, 56, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1301), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1302), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1301) },
                    { 758, 56, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1302), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1303), "PERVARİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1303) },
                    { 759, 56, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1304), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1304), "ŞİRVAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1304) },
                    { 760, 56, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1305), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1306), "TİLLO", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1305) },
                    { 761, 57, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1306), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1307), "AYANCIK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1307) },
                    { 762, 57, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1308), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1308), "BOYABAT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1308) },
                    { 763, 57, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1309), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1310), "DİKMEN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1309) },
                    { 764, 57, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1310), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1311), "DURAĞAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1311) },
                    { 765, 57, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1311), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1312), "ERFELEK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1312) },
                    { 766, 57, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1313), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1314), "GERZE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1313) },
                    { 767, 57, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1314), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1315), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1314) },
                    { 768, 57, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1315), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1316), "SARAYDÜZÜ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1316) },
                    { 769, 57, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1317), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1317), "TÜRKELİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1317) },
                    { 770, 58, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1318), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1319), "AKINCILAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1318) },
                    { 771, 58, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1319), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1320), "ALTINYAYLA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1320) },
                    { 772, 58, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1321), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1321), "DİVRİĞİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1321) },
                    { 773, 58, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1322), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1323), "DOĞANŞAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1322) },
                    { 774, 58, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1323), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1324), "GEMEREK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1324) },
                    { 775, 58, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1325), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1325), "GÖLOVA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1325) },
                    { 776, 58, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1326), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1327), "GÜRÜN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1326) },
                    { 777, 58, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1327), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1328), "HAFİK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1328) },
                    { 778, 58, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1329), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1329), "İMRANLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1329) },
                    { 779, 58, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1330), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1331), "KANGAL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1330) },
                    { 780, 58, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1331), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1332), "KOYULHİSAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1332) },
                    { 781, 58, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1333), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1333), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1333) },
                    { 782, 58, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1334), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1335), "SUŞEHRİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1334) },
                    { 783, 58, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1335), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1336), "ŞARKIŞLA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1336) },
                    { 784, 58, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1337), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1337), "ULAŞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1337) },
                    { 785, 58, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1338), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1339), "YILDIZELİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1338) },
                    { 786, 58, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1339), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1340), "ZARA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1340) },
                    { 787, 59, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1340), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1341), "ÇERKEZKÖY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1341) },
                    { 788, 59, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1342), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1342), "ÇORLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1342) },
                    { 789, 59, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1343), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1344), "ERGENE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1343) },
                    { 790, 59, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1344), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1345), "HAYRABOLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1345) },
                    { 791, 59, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1346), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1346), "KAPAKLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1346) },
                    { 792, 59, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1347), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1348), "MALKARA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1347) },
                    { 793, 59, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1348), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1349), "MARMARAEREĞLİSİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1349) },
                    { 794, 59, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1350), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1350), "MURATLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1350) },
                    { 795, 59, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1351), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1352), "SARAY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1351) },
                    { 796, 59, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1352), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1353), "SÜLEYMANPAŞA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1353) },
                    { 797, 59, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1354), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1354), "ŞARKÖY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1354) },
                    { 798, 60, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1355), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1356), "ALMUS", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1355) },
                    { 799, 60, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1356), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1357), "ARTOVA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1357) },
                    { 800, 60, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1358), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1358), "BAŞÇİFTLİK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1358) },
                    { 801, 60, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1359), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1360), "ERBAA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1359) },
                    { 802, 60, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1360), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1361), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1361) },
                    { 803, 60, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1361), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1362), "NİKSAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1362) },
                    { 804, 60, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1363), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1364), "PAZAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1363) },
                    { 805, 60, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1364), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1365), "REŞADİYE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1364) },
                    { 806, 60, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1365), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1366), "SULUSARAY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1366) },
                    { 807, 60, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1367), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1367), "TURHAL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1367) },
                    { 808, 60, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1368), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1369), "YEŞİLYURT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1368) },
                    { 809, 60, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1369), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1370), "ZİLE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1370) },
                    { 810, 61, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1397), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1399), "AKÇAABAT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1399) },
                    { 811, 61, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1400), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1401), "ARAKLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1400) },
                    { 812, 61, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1401), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1402), "ARSİN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1402) },
                    { 813, 61, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1403), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1403), "BEŞİKDÜZÜ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1403) },
                    { 814, 61, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1404), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1405), "ÇARŞIBAŞI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1404) },
                    { 815, 61, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1405), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1406), "ÇAYKARA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1405) },
                    { 816, 61, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1406), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1407), "DERNEKPAZARI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1407) },
                    { 817, 61, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1408), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1408), "DÜZKÖY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1408) },
                    { 818, 61, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1409), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1410), "HAYRAT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1409) },
                    { 819, 61, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1410), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1411), "KÖPRÜBAŞI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1411) },
                    { 820, 61, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1412), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1412), "MAÇKA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1412) },
                    { 821, 61, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1413), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1414), "OF", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1413) },
                    { 822, 61, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1414), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1415), "ORTAHİSAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1415) },
                    { 823, 61, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1415), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1416), "SÜRMENE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1416) },
                    { 824, 61, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1417), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1418), "ŞALPAZARI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1417) },
                    { 825, 61, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1418), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1419), "TONYA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1418) },
                    { 826, 61, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1419), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1420), "VAKFIKEBİR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1420) },
                    { 827, 61, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1421), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1421), "YOMRA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1421) },
                    { 828, 62, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1422), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1423), "ÇEMİŞGEZEK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1422) },
                    { 829, 62, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1423), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1424), "HOZAT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1424) },
                    { 830, 62, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1425), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1425), "MAZGİRT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1425) },
                    { 831, 62, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1426), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1427), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1426) },
                    { 832, 62, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1427), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1428), "NAZIMİYE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1428) },
                    { 833, 62, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1428), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1429), "OVACIK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1429) },
                    { 834, 62, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1430), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1431), "PERTEK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1430) },
                    { 835, 62, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1431), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1432), "PÜLÜMÜR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1431) },
                    { 836, 63, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1432), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1433), "AKÇAKALE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1433) },
                    { 837, 63, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1434), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1434), "BİRECİK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1434) },
                    { 838, 63, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1435), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1436), "BOZOVA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1435) },
                    { 839, 63, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1436), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1437), "CEYLANPINAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1437) },
                    { 840, 63, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1438), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1438), "EYYÜBİYE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1438) },
                    { 841, 63, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1439), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1440), "HALFETİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1439) },
                    { 842, 63, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1440), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1441), "HALİLİYE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1441) },
                    { 843, 63, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1441), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1442), "HARRAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1442) },
                    { 844, 63, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1443), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1444), "HİLVAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1443) },
                    { 845, 63, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1444), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1445), "KARAKÖPRÜ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1444) },
                    { 846, 63, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1445), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1446), "SİVEREK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1446) },
                    { 847, 63, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1447), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1447), "SURUÇ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1447) },
                    { 848, 63, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1448), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1449), "VİRANŞEHİR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1448) },
                    { 849, 64, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1449), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1450), "BANAZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1450) },
                    { 850, 64, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1451), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1451), "EŞME", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1451) },
                    { 851, 64, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1452), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1453), "KARAHALLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1452) },
                    { 852, 64, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1453), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1454), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1454) },
                    { 853, 64, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1454), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1455), "SİVASLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1455) },
                    { 854, 64, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1456), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1457), "ULUBEY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1456) },
                    { 855, 65, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1457), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1458), "BAHÇESARAY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1457) },
                    { 856, 65, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1458), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1459), "BAŞKALE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1459) },
                    { 857, 65, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1460), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1460), "ÇALDIRAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1460) },
                    { 858, 65, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1461), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1462), "ÇATAK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1461) },
                    { 859, 65, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1462), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1463), "EDREMİT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1463) },
                    { 860, 65, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1464), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1464), "ERCİŞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1464) },
                    { 861, 65, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1465), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1466), "GEVAŞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1465) },
                    { 862, 65, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1466), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1467), "GÜRPINAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1467) },
                    { 863, 65, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1467), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1468), "İPEKYOLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1468) },
                    { 864, 65, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1469), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1470), "MURADİYE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1469) },
                    { 865, 65, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1470), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1471), "ÖZALP", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1470) },
                    { 866, 65, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1471), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1472), "SARAY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1472) },
                    { 867, 65, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1473), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1473), "TUŞBA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1473) },
                    { 868, 66, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1474), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1475), "AKDAĞMADENİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1474) },
                    { 869, 66, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1475), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1476), "AYDINCIK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1476) },
                    { 870, 66, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1477), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1477), "BOĞAZLIYAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1477) },
                    { 871, 66, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1478), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1479), "ÇANDIR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1478) },
                    { 872, 66, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1479), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1480), "ÇAYIRALAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1480) },
                    { 873, 66, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1481), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1481), "ÇEKEREK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1481) },
                    { 874, 66, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1482), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1483), "KADIŞEHRİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1482) },
                    { 875, 66, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1483), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1484), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1484) },
                    { 876, 66, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1484), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1485), "SARAYKENT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1485) },
                    { 877, 66, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1486), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1487), "SARIKAYA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1486) },
                    { 878, 66, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1487), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1488), "SORGUN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1487) },
                    { 879, 66, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1488), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1489), "ŞEFAATLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1489) },
                    { 880, 66, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1490), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1490), "YENİFAKILI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1490) },
                    { 881, 66, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1491), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1492), "YERKÖY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1491) },
                    { 882, 67, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1492), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1493), "ALAPLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1493) },
                    { 883, 67, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1513), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1516), "ÇAYCUMA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1516) },
                    { 884, 67, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1517), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1518), "DEVREK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1517) },
                    { 885, 67, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1518), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1519), "EREĞLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1519) },
                    { 886, 67, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1520), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1520), "GÖKÇEBEY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1520) },
                    { 887, 67, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1521), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1522), "KİLİMLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1521) },
                    { 888, 67, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1522), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1523), "KOZLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1523) },
                    { 889, 67, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1523), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1524), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1524) },
                    { 890, 68, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1525), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1526), "AĞAÇÖREN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1525) },
                    { 891, 68, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1526), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1527), "ESKİL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1526) },
                    { 892, 68, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1527), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1528), "GÜLAĞAÇ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1528) },
                    { 893, 68, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1529), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1529), "GÜZELYURT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1529) },
                    { 894, 68, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1530), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1531), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1530) },
                    { 895, 68, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1531), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1532), "ORTAKÖY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1532) },
                    { 896, 68, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1533), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1533), "SARIYAHŞİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1533) },
                    { 897, 68, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1534), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1535), "SULTANHANI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1534) },
                    { 898, 69, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1535), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1536), "AYDINTEPE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1536) },
                    { 899, 69, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1536), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1537), "DEMİRÖZÜ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1537) },
                    { 900, 69, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1538), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1539), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1538) },
                    { 901, 70, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1539), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1540), "AYRANCI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1539) },
                    { 902, 70, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1540), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1541), "BAŞYAYLA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1541) },
                    { 903, 70, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1542), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1542), "ERMENEK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1542) },
                    { 904, 70, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1543), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1544), "KAZIMKARABEKİR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1543) },
                    { 905, 70, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1544), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1545), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1545) },
                    { 906, 70, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1546), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1546), "SARIVELİLER", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1546) },
                    { 907, 71, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1547), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1548), "BAHŞİLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1547) },
                    { 908, 71, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1548), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1549), "BALIŞEYH", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1549) },
                    { 909, 71, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1550), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1550), "ÇELEBİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1550) },
                    { 910, 71, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1551), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1552), "DELİCE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1551) },
                    { 911, 71, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1552), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1553), "KARAKEÇİLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1552) },
                    { 912, 71, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1553), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1554), "KESKİN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1554) },
                    { 913, 71, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1555), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1555), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1555) },
                    { 914, 71, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1556), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1557), "SULAKYURT", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1556) },
                    { 915, 71, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1557), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1558), "YAHŞİHAN", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1558) },
                    { 916, 72, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1559), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1559), "BEŞİRİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1559) },
                    { 917, 72, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1560), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1561), "GERCÜŞ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1560) },
                    { 918, 72, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1561), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1562), "HASANKEYF", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1562) },
                    { 919, 72, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1563), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1563), "KOZLUK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1563) },
                    { 920, 72, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1564), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1565), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1564) },
                    { 921, 72, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1565), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1566), "SASON", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1566) },
                    { 922, 73, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1566), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1567), "BEYTÜŞŞEBAP", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1567) },
                    { 923, 73, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1568), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1569), "CİZRE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1568) },
                    { 924, 73, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1569), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1570), "GÜÇLÜKONAK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1569) },
                    { 925, 73, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1570), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1571), "İDİL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1571) },
                    { 926, 73, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1572), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1572), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1572) },
                    { 927, 73, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1573), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1574), "SİLOPİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1573) },
                    { 928, 73, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1574), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1575), "ULUDERE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1575) },
                    { 929, 74, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1576), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1576), "AMASRA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1576) },
                    { 930, 74, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1577), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1578), "KURUCAŞİLE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1577) },
                    { 931, 74, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1578), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1579), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1579) },
                    { 932, 74, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1580), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1580), "ULUS", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1580) },
                    { 933, 75, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1581), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1582), "ÇILDIR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1581) },
                    { 934, 75, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1582), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1583), "DAMAL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1582) },
                    { 935, 75, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1583), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1584), "GÖLE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1584) },
                    { 936, 75, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1585), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1585), "HANAK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1585) },
                    { 937, 75, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1586), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1587), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1586) },
                    { 938, 75, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1587), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1588), "POSOF", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1588) },
                    { 939, 76, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1589), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1589), "ARALIK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1589) },
                    { 940, 76, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1590), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1591), "KARAKOYUNLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1590) },
                    { 941, 76, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1591), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1592), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1592) },
                    { 942, 76, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1593), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1593), "TUZLUCA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1593) },
                    { 943, 77, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1594), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1595), "ALTINOVA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1594) },
                    { 944, 77, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1595), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1596), "ARMUTLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1596) },
                    { 945, 77, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1596), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1597), "ÇINARCIK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1597) },
                    { 946, 77, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1598), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1598), "ÇİFTLİKKÖY", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1598) },
                    { 947, 77, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1599), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1600), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1599) },
                    { 948, 77, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1600), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1601), "TERMAL", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1601) },
                    { 949, 78, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1602), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1603), "EFLANİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1602) },
                    { 950, 78, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1603), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1604), "ESKİPAZAR", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1603) },
                    { 951, 78, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1604), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1605), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1605) },
                    { 952, 78, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1606), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1606), "OVACIK", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1606) },
                    { 953, 78, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1607), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1608), "SAFRANBOLU", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1607) },
                    { 954, 78, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1608), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1609), "YENİCE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1609) },
                    { 955, 79, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1610), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1610), "ELBEYLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1610) },
                    { 956, 79, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1630), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1634), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1634) },
                    { 957, 79, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1635), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1636), "MUSABEYLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1635) },
                    { 958, 79, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1636), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1637), "POLATELİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1637) },
                    { 959, 80, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1638), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1638), "BAHÇE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1638) },
                    { 960, 80, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1639), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1640), "DÜZİÇİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1639) },
                    { 961, 80, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1640), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1641), "HASANBEYLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1641) },
                    { 962, 80, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1641), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1642), "KADİRLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1642) },
                    { 963, 80, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1643), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1643), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1643) },
                    { 964, 80, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1644), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1645), "SUMBAS", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1644) },
                    { 965, 80, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1645), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1646), "TOPRAKKALE", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1646) },
                    { 966, 81, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1647), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1647), "AKÇAKOCA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1647) },
                    { 967, 81, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1648), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1649), "CUMAYERİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1648) },
                    { 968, 81, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1649), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1650), "ÇİLİMLİ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1650) },
                    { 969, 81, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1651), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1651), "GÖLYAKA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1651) },
                    { 970, 81, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1652), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1653), "GÜMÜŞOVA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1652) },
                    { 971, 81, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1653), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1654), "KAYNAŞLI", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1654) },
                    { 972, 81, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1655), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1655), "MERKEZ", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1655) },
                    { 973, 81, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1656), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1657), "YIĞILCA", false, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1656) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CityID", "CreatedDate", "DeletedDate", "DistrictID", "Mail", "Name", "Password", "Status", "Surname", "UpdatedDate", "UserName" },
                values: new object[] { 1, 1, new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1940), new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1938), 1, "", "Büşra", "12345", false, "Güneş", new DateTime(2025, 8, 26, 20, 41, 42, 977, DateTimeKind.Local).AddTicks(1937), "busra" });

            migrationBuilder.CreateIndex(
                name: "IX_AccountTransactions_CaseFileID",
                table: "AccountTransactions",
                column: "CaseFileID");

            migrationBuilder.CreateIndex(
                name: "IX_AccountTransactions_CreditID",
                table: "AccountTransactions",
                column: "CreditID");

            migrationBuilder.CreateIndex(
                name: "IX_AccountTransactions_DebtorID",
                table: "AccountTransactions",
                column: "DebtorID");

            migrationBuilder.CreateIndex(
                name: "IX_CaseFileDefendant_caseFileID",
                table: "CaseFileDefendant",
                column: "caseFileID");

            migrationBuilder.CreateIndex(
                name: "IX_CaseFileDefendant_defendantID",
                table: "CaseFileDefendant",
                column: "defendantID");

            migrationBuilder.CreateIndex(
                name: "IX_CaseFileDocument_CaseFileID",
                table: "CaseFileDocument",
                column: "CaseFileID");

            migrationBuilder.CreateIndex(
                name: "IX_CaseFileDocument_DocumentTypeID",
                table: "CaseFileDocument",
                column: "DocumentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CaseFiles_ApplicationTypeID",
                table: "CaseFiles",
                column: "ApplicationTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CaseFiles_CaseTypeID",
                table: "CaseFiles",
                column: "CaseTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CaseFiles_CityID",
                table: "CaseFiles",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_CaseFiles_DistrictID",
                table: "CaseFiles",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_CaseFileShares_CaseFileID",
                table: "CaseFileShares",
                column: "CaseFileID");

            migrationBuilder.CreateIndex(
                name: "IX_CaseFileShares_UserID",
                table: "CaseFileShares",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CityID",
                table: "Districts",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_PermissionID",
                table: "RolePermissions",
                column: "PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_RoleID",
                table: "RolePermissions",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleID",
                table: "UserRoles",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserID",
                table: "UserRoles",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CityID",
                table: "Users",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DistrictID",
                table: "Users",
                column: "DistrictID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountTransactions");

            migrationBuilder.DropTable(
                name: "CaseFileDefendant");

            migrationBuilder.DropTable(
                name: "CaseFileDocument");

            migrationBuilder.DropTable(
                name: "CaseFileShares");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Defendants");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "CaseFiles");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ApplicationTypes");

            migrationBuilder.DropTable(
                name: "CaseTypes");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
