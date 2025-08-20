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
                    { 1, 1, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8550), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8552), "Araç Hasarı", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8552) },
                    { 2, 1, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8554), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8555), "Manevi", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8554) },
                    { 3, 1, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8556), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8557), "İdari Dava", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8556) },
                    { 4, 4, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8558), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8558), "Kamulaştırma", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8558) }
                });

            migrationBuilder.InsertData(
                table: "CaseTypes",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8938), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8939), "Trafik Kazası", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8939) },
                    { 2, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8941), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8942), "Arabuluculuk", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8941) },
                    { 3, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8943), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8943), "İdari Dava", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8943) },
                    { 4, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8944), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8945), "Kamulaştırma", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8944) }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9289), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9292), "Adana", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9291) },
                    { 2, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9293), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9294), "Adıyaman", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9294) },
                    { 3, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9295), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9296), "Afyonkarahisar", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9295) },
                    { 4, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9296), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9297), "Ağrı", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9297) },
                    { 5, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9298), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9299), "Amasya", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9298) },
                    { 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9299), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9300), "Ankara", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9300) },
                    { 7, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9301), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9301), "Antalya", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9301) },
                    { 8, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9302), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9303), "Artvin", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9303) },
                    { 9, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9304), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9304), "Aydın", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9304) },
                    { 10, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9305), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9306), "Balıkesir", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9305) },
                    { 11, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9306), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9307), "Bilecik", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9307) },
                    { 12, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9308), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9309), "Bingöl", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9308) },
                    { 13, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9309), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9310), "Bitlis", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9310) },
                    { 14, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9311), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9312), "Bolu", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9311) },
                    { 15, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9312), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9313), "Burdur", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9313) },
                    { 16, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9314), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9315), "Bursa", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9314) },
                    { 17, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9315), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9316), "Çanakkale", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9316) },
                    { 18, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9317), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9317), "Çankırı", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9317) },
                    { 19, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9318), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9319), "Çorum", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9318) },
                    { 20, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9319), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9320), "Denizli", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9320) },
                    { 21, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9321), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9322), "Diyarbakır", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9321) },
                    { 22, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9322), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9323), "Edirne", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9323) },
                    { 23, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9324), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9325), "Elazığ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9324) },
                    { 24, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9325), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9326), "Erzincan", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9326) },
                    { 25, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9327), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9328), "Erzurum", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9328) },
                    { 26, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9329), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9330), "Eskişehir", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9329) },
                    { 27, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9330), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9331), "Gaziantep", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9331) },
                    { 28, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9332), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9332), "Giresun", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9332) },
                    { 29, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9333), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9334), "Gümüşhane", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9333) },
                    { 30, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9334), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9335), "Hakkari", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9335) },
                    { 31, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9336), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9337), "Hatay", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9336) },
                    { 32, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9337), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9338), "Isparta", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9338) },
                    { 33, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9339), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9340), "Mersin", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9339) },
                    { 34, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9340), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9341), "İstanbul", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9341) },
                    { 35, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9342), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9342), "İzmir", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9342) },
                    { 36, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9343), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9344), "Kars", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9343) },
                    { 37, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9344), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9345), "Kastamonu", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9345) },
                    { 38, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9346), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9347), "Kayseri", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9346) },
                    { 39, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9347), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9348), "Kırklareli", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9348) },
                    { 40, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9349), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9350), "Kırşehir", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9349) },
                    { 41, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9350), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9351), "Kocaeli", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9351) },
                    { 42, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9357), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9358), "Konya", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9358) },
                    { 43, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9359), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9360), "Kütahya", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9359) },
                    { 44, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9360), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9361), "Malatya", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9361) },
                    { 45, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9362), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9363), "Manisa", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9362) },
                    { 46, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9363), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9364), "Kahramanmaraş", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9364) },
                    { 47, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9365), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9366), "Mardin", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9365) },
                    { 48, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9366), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9367), "Muğla", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9367) },
                    { 49, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9368), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9368), "Muş", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9368) },
                    { 50, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9369), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9370), "Nevşehir", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9369) },
                    { 51, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9370), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9371), "Niğde", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9371) },
                    { 52, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9372), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9373), "Ordu", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9372) },
                    { 53, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9373), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9374), "Rize", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9374) },
                    { 54, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9375), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9375), "Sakarya", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9375) },
                    { 55, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9376), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9377), "Samsun", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9376) },
                    { 56, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9377), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9378), "Siirt", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9378) },
                    { 57, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9379), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9380), "Sinop", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9379) },
                    { 58, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9380), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9381), "Sivas", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9381) },
                    { 59, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9382), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9383), "Tekirdağ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9382) },
                    { 60, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9383), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9384), "Tokat", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9384) },
                    { 61, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9385), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9386), "Trabzon", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9385) },
                    { 62, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9386), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9387), "Tunceli", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9387) },
                    { 63, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9388), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9388), "Şanlıurfa", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9388) },
                    { 64, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9389), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9390), "Uşak", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9389) },
                    { 65, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9390), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9391), "Van", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9391) },
                    { 66, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9392), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9393), "Yozgat", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9392) },
                    { 67, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9393), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9394), "Zonguldak", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9394) },
                    { 68, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9395), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9396), "Aksaray", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9395) },
                    { 69, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9396), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9397), "Bayburt", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9397) },
                    { 70, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9398), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9398), "Karaman", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9398) },
                    { 71, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9399), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9400), "Kırıkkale", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9399) },
                    { 72, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9400), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9401), "Batman", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9401) },
                    { 73, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9402), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9403), "Şırnak", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9402) },
                    { 74, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9403), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9404), "Bartın", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9404) },
                    { 75, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9405), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9406), "Ardahan", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9405) },
                    { 76, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9406), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9407), "Iğdır", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9407) },
                    { 77, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9408), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9408), "Yalova", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9408) },
                    { 78, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9409), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9410), "Karabük", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9409) },
                    { 79, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9410), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9411), "Kilis", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9411) },
                    { 80, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9412), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9413), "Osmaniye", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9412) },
                    { 81, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9413), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9414), "Düzce", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9414) }
                });

            migrationBuilder.InsertData(
                table: "DocumentTypes",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Name", "Status", "Type", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1355), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1357), "TcKimlik", false, "DosyaEvrak", new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1356) },
                    { 2, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1359), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1360), "Sici Kaydı", false, "KullaniciEvrak", new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1359) }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "ID", "Code", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[] { 1, "caseFile-list", new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8283), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8281), "Case File List", true, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(8281) });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "ID", "CityID", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9567), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9568), "ALADAĞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9568) },
                    { 2, 1, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9570), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9571), "CEYHAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9570) },
                    { 3, 1, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9571), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9572), "ÇUKUROVA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9572) },
                    { 4, 1, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9573), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9574), "FEKE", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9573) },
                    { 5, 1, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9574), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9575), "İMAMOĞLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9575) },
                    { 6, 1, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9576), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9577), "KARAİSALI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9576) },
                    { 7, 1, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9577), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9578), "KARATAŞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9578) },
                    { 8, 1, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9579), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9580), "KOZAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9579) },
                    { 9, 1, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9584), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9585), "POZANTI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9585) },
                    { 10, 1, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9586), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9587), "SAİMBEYLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9586) },
                    { 11, 1, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9588), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9589), "SARIÇAM", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9588) },
                    { 12, 1, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9589), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9590), "SEYHAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9590) },
                    { 13, 1, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9591), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9592), "TUFANBEYLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9591) },
                    { 14, 1, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9593), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9593), "YUMURTALIK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9593) },
                    { 15, 1, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9594), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9595), "YÜREĞİR", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9594) },
                    { 16, 2, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9595), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9596), "BESNİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9596) },
                    { 17, 2, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9597), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9598), "ÇELİKHAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9597) },
                    { 18, 2, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9598), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9599), "GERGER", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9599) },
                    { 19, 2, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9600), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9601), "GÖLBAŞI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9600) },
                    { 20, 2, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9601), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9602), "KAHTA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9602) },
                    { 21, 2, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9603), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9604), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9603) },
                    { 22, 2, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9604), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9605), "SAMSAT", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9605) },
                    { 23, 2, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9606), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9607), "SİNCİK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9606) },
                    { 24, 2, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9607), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9608), "TUT", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9608) },
                    { 25, 3, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9609), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9610), "BAŞMAKÇI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9609) },
                    { 26, 3, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9610), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9611), "BAYAT", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9611) },
                    { 27, 3, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9612), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9613), "BOLVADİN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9612) },
                    { 28, 3, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9613), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9614), "ÇAY", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9614) },
                    { 29, 3, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9615), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9616), "ÇOBANLAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9615) },
                    { 30, 3, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9616), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9617), "DAZKIRI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9617) },
                    { 31, 3, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9618), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9619), "DİNAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9618) },
                    { 32, 3, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9619), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9620), "EMİRDAĞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9620) },
                    { 33, 3, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9621), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9622), "EVCİLER", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9621) },
                    { 34, 3, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9622), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9623), "HOCALAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9623) },
                    { 35, 3, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9624), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9624), "İHSANİYE", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9624) },
                    { 36, 3, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9625), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9626), "İSCEHİSAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9626) },
                    { 37, 3, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9627), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9627), "KIZILÖREN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9627) },
                    { 38, 3, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9628), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9629), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9628) },
                    { 39, 3, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9630), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9631), "SANDIKLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9630) },
                    { 40, 3, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9631), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9632), "SİNANPAŞA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9632) },
                    { 41, 3, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9633), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9634), "SULTANDAĞI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9633) },
                    { 42, 3, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9635), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9636), "ŞUHUT", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9635) },
                    { 43, 4, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9636), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9637), "DİYADİN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9637) },
                    { 44, 4, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9638), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9639), "DOĞUBAYAZIT", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9638) },
                    { 45, 4, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9639), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9640), "ELEŞKİRT", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9640) },
                    { 46, 4, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9641), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9642), "HAMUR", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9641) },
                    { 47, 4, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9642), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9643), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9643) },
                    { 48, 4, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9644), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9645), "PATNOS", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9644) },
                    { 49, 4, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9645), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9646), "TAŞLIÇAY", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9646) },
                    { 50, 4, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9647), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9648), "TUTAK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9647) },
                    { 51, 5, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9648), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9649), "GÖYNÜCEK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9649) },
                    { 52, 5, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9650), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9651), "GÜMÜŞHACIKÖY", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9650) },
                    { 53, 5, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9651), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9652), "HAMAMÖZÜ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9652) },
                    { 54, 5, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9653), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9654), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9653) },
                    { 55, 5, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9654), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9655), "MERZİFON", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9655) },
                    { 56, 5, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9656), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9657), "SULUOVA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9656) },
                    { 57, 5, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9657), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9658), "TAŞOVA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9658) },
                    { 58, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9659), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9659), "AKYURT", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9659) },
                    { 59, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9660), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9661), "ALTINDAĞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9660) },
                    { 60, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9662), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9662), "AYAŞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9662) },
                    { 61, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9663), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9664), "BALA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9663) },
                    { 62, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9664), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9665), "BEYPAZARI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9665) },
                    { 63, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9666), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9667), "ÇAMLIDERE", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9666) },
                    { 64, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9667), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9668), "ÇANKAYA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9668) },
                    { 65, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9669), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9670), "ÇUBUK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9669) },
                    { 66, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9670), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9671), "ELMADAĞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9671) },
                    { 67, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9672), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9673), "ETİMESGUT", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9672) },
                    { 68, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9673), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9674), "EVREN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9674) },
                    { 69, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9675), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9676), "GÖLBAŞI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9675) },
                    { 70, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9676), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9677), "GÜDÜL", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9677) },
                    { 71, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9678), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9679), "HAYMANA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9678) },
                    { 72, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9679), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9680), "KAHRAMANKAZAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9680) },
                    { 73, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9681), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9682), "KALECİK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9682) },
                    { 74, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9683), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9684), "KEÇİÖREN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9683) },
                    { 75, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9684), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9685), "KIZILCAHAMAM", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9685) },
                    { 76, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9686), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9687), "MAMAK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9686) },
                    { 77, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9687), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9688), "NALLIHAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9688) },
                    { 78, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9689), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9690), "POLATLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9689) },
                    { 79, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9690), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9691), "PURSAKLAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9691) },
                    { 80, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9692), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9693), "SİNCAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9692) },
                    { 81, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9693), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9694), "ŞEREFLİKOÇHİSAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9694) },
                    { 82, 6, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9698), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9700), "YENİMAHALLE", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9700) },
                    { 83, 7, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9701), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9702), "AKSEKİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9701) },
                    { 84, 7, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9702), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9703), "AKSU", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9703) },
                    { 85, 7, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9704), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9705), "ALANYA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9704) },
                    { 86, 7, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9705), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9706), "DEMRE", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9706) },
                    { 87, 7, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9707), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9708), "DÖŞEMEALTI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9707) },
                    { 88, 7, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9708), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9709), "ELMALI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9709) },
                    { 89, 7, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9710), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9711), "FİNİKE", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9710) },
                    { 90, 7, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9711), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9712), "GAZİPAŞA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9712) },
                    { 91, 7, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9713), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9713), "GÜNDOĞMUŞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9713) },
                    { 92, 7, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9714), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9715), "İBRADI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9715) },
                    { 93, 7, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9716), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9716), "KAŞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9716) },
                    { 94, 7, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9717), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9718), "KEMER", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9718) },
                    { 95, 7, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9719), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9719), "KEPEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9719) },
                    { 96, 7, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9720), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9721), "KONYAALTI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9721) },
                    { 97, 7, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9722), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9722), "KORKUTELİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9722) },
                    { 98, 7, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9723), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9724), "KUMLUCA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9724) },
                    { 99, 7, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9725), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9725), "MANAVGAT", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9725) },
                    { 100, 7, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9726), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9727), "MURATPAŞA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9727) },
                    { 101, 7, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9728), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9728), "SERİK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9728) },
                    { 102, 8, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9729), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9730), "ARDANUÇ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9729) },
                    { 103, 8, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9731), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9732), "ARHAVİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9732) },
                    { 104, 8, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9733), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9734), "BORÇKA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9733) },
                    { 105, 8, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9734), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9735), "HOPA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9735) },
                    { 106, 8, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9736), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9737), "KEMALPAŞA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9736) },
                    { 107, 8, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9737), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9738), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9738) },
                    { 108, 8, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9739), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9739), "MURGUL", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9739) },
                    { 109, 8, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9740), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9741), "ŞAVŞAT", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9741) },
                    { 110, 8, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9742), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9742), "YUSUFELİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9742) },
                    { 111, 9, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9743), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9744), "BOZDOĞAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9743) },
                    { 112, 9, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9745), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9745), "BUHARKENT", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9745) },
                    { 113, 9, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9746), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9747), "ÇİNE", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9746) },
                    { 114, 9, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9748), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9748), "DİDİM", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9748) },
                    { 115, 9, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9750), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9750), "EFELER", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9750) },
                    { 116, 9, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9751), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9752), "GERMENCİK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9752) },
                    { 117, 9, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9753), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9753), "İNCİRLİOVA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9753) },
                    { 118, 9, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9754), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9755), "KARACASU", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9755) },
                    { 119, 9, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9756), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9757), "KARPUZLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9757) },
                    { 120, 9, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9758), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9759), "KOÇARLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9758) },
                    { 121, 9, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9759), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9760), "KÖŞK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9760) },
                    { 122, 9, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9761), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9762), "KUŞADASI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9761) },
                    { 123, 9, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9762), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9763), "KUYUCAK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9763) },
                    { 124, 9, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9764), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9765), "NAZİLLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9764) },
                    { 125, 9, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9765), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9766), "SÖKE", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9766) },
                    { 126, 9, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9767), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9768), "SULTANHİSAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9767) },
                    { 127, 9, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9768), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9769), "YENİPAZAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9769) },
                    { 128, 10, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9770), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9770), "ALTIEYLÜL", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9770) },
                    { 129, 10, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9771), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9772), "AYVALIK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9772) },
                    { 130, 10, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9773), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9773), "BALYA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9773) },
                    { 131, 10, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9774), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9775), "BANDIRMA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9774) },
                    { 132, 10, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9776), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9776), "BİGADİÇ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9776) },
                    { 133, 10, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9777), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9778), "BURHANİYE", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9777) },
                    { 134, 10, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9779), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9780), "DURSUNBEY", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9780) },
                    { 135, 10, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9781), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9781), "EDREMİT", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9781) },
                    { 136, 10, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9782), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9783), "ERDEK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9783) },
                    { 137, 10, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9784), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9784), "GÖMEÇ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9784) },
                    { 138, 10, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9785), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9786), "GÖNEN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9785) },
                    { 139, 10, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9787), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9787), "HAVRAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9787) },
                    { 140, 10, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9788), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9789), "İVRİNDİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9788) },
                    { 141, 10, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9789), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9790), "KARESİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9790) },
                    { 142, 10, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9791), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9792), "KEPSUT", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9791) },
                    { 143, 10, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9793), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9793), "MANYAS", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9793) },
                    { 144, 10, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9794), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9795), "MARMARA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9794) },
                    { 145, 10, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9796), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9796), "SAVAŞTEPE", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9796) },
                    { 146, 10, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9797), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9798), "SINDIRGI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9797) },
                    { 147, 10, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9798), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9799), "SUSURLUK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9799) },
                    { 148, 11, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9800), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9801), "BOZÜYÜK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9800) },
                    { 149, 11, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9801), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9802), "GÖLPAZARI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9802) },
                    { 150, 11, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9803), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9804), "İNHİSAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9803) },
                    { 151, 11, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9804), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9805), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9805) },
                    { 152, 11, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9806), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9807), "OSMANELİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9806) },
                    { 153, 11, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9807), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9808), "PAZARYERİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9808) },
                    { 154, 11, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9809), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9810), "SÖĞÜT", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9809) },
                    { 155, 11, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9813), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9815), "YENİPAZAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9814) },
                    { 156, 12, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9815), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9816), "ADAKLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9816) },
                    { 157, 12, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9817), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9818), "GENÇ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9817) },
                    { 158, 12, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9818), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9819), "KARLIOVA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9819) },
                    { 159, 12, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9820), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9821), "KİĞI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9820) },
                    { 160, 12, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9821), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9822), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9822) },
                    { 161, 12, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9823), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9824), "SOLHAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9823) },
                    { 162, 12, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9824), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9825), "YAYLADERE", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9825) },
                    { 163, 12, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9826), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9827), "YEDİSU", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9826) },
                    { 164, 13, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9828), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9829), "ADİLCEVAZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9829) },
                    { 165, 13, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9830), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9831), "AHLAT", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9830) },
                    { 166, 13, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9831), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9832), "GÜROYMAK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9832) },
                    { 167, 13, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9833), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9834), "HİZAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9833) },
                    { 168, 13, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9834), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9835), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9835) },
                    { 169, 13, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9836), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9837), "MUTKİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9836) },
                    { 170, 13, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9837), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9838), "TATVAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9838) },
                    { 171, 14, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9839), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9840), "DÖRTDİVAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9839) },
                    { 172, 14, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9840), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9841), "GEREDE", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9841) },
                    { 173, 14, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9842), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9843), "GÖYNÜK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9842) },
                    { 174, 14, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9843), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9844), "KIBRISCIK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9844) },
                    { 175, 14, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9845), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9846), "MENGEN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9845) },
                    { 176, 14, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9846), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9847), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9847) },
                    { 177, 14, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9848), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9848), "MUDURNU", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9848) },
                    { 178, 14, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9849), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9850), "SEBEN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9850) },
                    { 179, 14, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9851), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9851), "YENİÇAĞA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9851) },
                    { 180, 15, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9852), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9853), "AĞLASUN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9853) },
                    { 181, 15, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9854), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9854), "ALTINYAYLA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9854) },
                    { 182, 15, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9855), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9856), "BUCAK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9855) },
                    { 183, 15, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9856), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9857), "ÇAVDIR", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9857) },
                    { 184, 15, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9858), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9859), "ÇELTİKÇİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9858) },
                    { 185, 15, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9859), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9860), "GÖLHİSAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9860) },
                    { 186, 15, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9861), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9862), "KARAMANLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9861) },
                    { 187, 15, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9862), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9863), "KEMER", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9863) },
                    { 188, 15, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9864), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9865), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9864) },
                    { 189, 15, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9865), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9866), "TEFENNİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9866) },
                    { 190, 15, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9867), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9868), "YEŞİLOVA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9867) },
                    { 191, 16, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9868), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9869), "BÜYÜKORHAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9869) },
                    { 192, 16, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9870), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9871), "GEMLİK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9870) },
                    { 193, 16, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9871), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9872), "GÜRSU", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9872) },
                    { 194, 16, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9873), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9874), "HARMANCIK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9873) },
                    { 195, 16, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9875), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9876), "İNEGÖL", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9875) },
                    { 196, 16, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9876), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9877), "İZNİK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9877) },
                    { 197, 16, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9878), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9879), "KARACABEY", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9878) },
                    { 198, 16, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9879), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9880), "KELES", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9880) },
                    { 199, 16, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9881), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9882), "KESTEL", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9881) },
                    { 200, 16, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9882), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9883), "MUDANYA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9883) },
                    { 201, 16, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9884), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9885), "MUSTAFAKEMALPAŞA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9884) },
                    { 202, 16, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9885), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9886), "NİLÜFER", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9886) },
                    { 203, 16, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9887), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9888), "ORHANELİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9887) },
                    { 204, 16, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9888), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9889), "ORHANGAZİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9889) },
                    { 205, 16, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9890), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9891), "OSMANGAZİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9890) },
                    { 206, 16, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9891), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9892), "YENİŞEHİR", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9892) },
                    { 207, 16, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9893), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9894), "YILDIRIM", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9893) },
                    { 208, 17, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9894), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9895), "AYVACIK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9895) },
                    { 209, 17, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9896), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9897), "BAYRAMİÇ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9896) },
                    { 210, 17, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9897), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9898), "BİGA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9898) },
                    { 211, 17, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9899), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9900), "BOZCAADA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9899) },
                    { 212, 17, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9900), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9901), "ÇAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9901) },
                    { 213, 17, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9902), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9903), "ECEABAT", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9902) },
                    { 214, 17, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9903), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9904), "EZİNE", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9904) },
                    { 215, 17, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9905), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9905), "GELİBOLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9905) },
                    { 216, 17, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9906), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9907), "GÖKÇEADA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9907) },
                    { 217, 17, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9908), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9908), "LAPSEKİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9908) },
                    { 218, 17, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9909), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9910), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9909) },
                    { 219, 17, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9910), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9911), "YENİCE", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9911) },
                    { 220, 18, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9912), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9913), "ATKARACALAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9912) },
                    { 221, 18, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9913), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9914), "BAYRAMÖREN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9914) },
                    { 222, 18, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9915), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9916), "ÇERKEŞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9915) },
                    { 223, 18, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9916), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9917), "ELDİVAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9917) },
                    { 224, 18, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9918), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9919), "ILGAZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9918) },
                    { 225, 18, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9920), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9921), "KIZILIRMAK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9920) },
                    { 226, 18, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9922), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9922), "KORGUN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9922) },
                    { 227, 18, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9923), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9924), "KURŞUNLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9923) },
                    { 228, 18, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9928), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9930), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9930) },
                    { 229, 18, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9931), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9932), "ORTA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9931) },
                    { 230, 18, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9932), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9933), "ŞABANÖZÜ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9933) },
                    { 231, 18, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9934), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9935), "YAPRAKLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9934) },
                    { 232, 19, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9935), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9936), "ALACA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9936) },
                    { 233, 19, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9937), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9937), "BAYAT", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9937) },
                    { 234, 19, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9938), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9939), "BOĞAZKALE", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9939) },
                    { 235, 19, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9940), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9941), "DODURGA", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9940) },
                    { 236, 19, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9941), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9942), "İSKİLİP", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9942) },
                    { 237, 19, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9943), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9943), "KARGI", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9943) },
                    { 238, 19, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9944), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9945), "LAÇİN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9945) },
                    { 239, 19, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9946), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9946), "MECİTÖZÜ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9946) },
                    { 240, 19, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9947), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9948), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9948) },
                    { 241, 19, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9949), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9950), "OĞUZLAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9949) },
                    { 242, 19, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9950), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9951), "ORTAKÖY", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9951) },
                    { 243, 19, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9952), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9953), "OSMANCIK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9952) },
                    { 244, 19, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9953), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9954), "SUNGURLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9953) },
                    { 245, 19, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9955), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9955), "UĞURLUDAĞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9955) },
                    { 246, 20, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9956), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9957), "ACIPAYAM", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9956) },
                    { 247, 20, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9958), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9958), "BABADAĞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9958) },
                    { 248, 20, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9959), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9960), "BAKLAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9959) },
                    { 249, 20, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9961), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9961), "BEKİLLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9961) },
                    { 250, 20, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9962), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9963), "BEYAĞAÇ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9962) },
                    { 251, 20, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9963), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9964), "BOZKURT", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9964) },
                    { 252, 20, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9965), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9966), "BULDAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9965) },
                    { 253, 20, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9966), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9967), "ÇAL", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9967) },
                    { 254, 20, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9968), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9969), "ÇAMELİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9968) },
                    { 255, 20, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9969), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9970), "ÇARDAK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9970) },
                    { 256, 20, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9972), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9973), "ÇİVRİL", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9973) },
                    { 257, 20, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9974), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9975), "GÜNEY", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9974) },
                    { 258, 20, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9975), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9976), "HONAZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9976) },
                    { 259, 20, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9977), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9978), "KALE", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9977) },
                    { 260, 20, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9978), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9979), "MERKEZEFENDİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9979) },
                    { 261, 20, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9980), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9980), "PAMUKKALE", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9980) },
                    { 262, 20, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9981), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9982), "SARAYKÖY", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9982) },
                    { 263, 20, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9983), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9983), "SERİNHİSAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9983) },
                    { 264, 20, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9984), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9985), "TAVAS", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9984) },
                    { 265, 21, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9986), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9986), "BAĞLAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9986) },
                    { 266, 21, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9987), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9988), "BİSMİL", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9987) },
                    { 267, 21, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9988), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9989), "ÇERMİK", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9989) },
                    { 268, 21, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9990), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9991), "ÇINAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9990) },
                    { 269, 21, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9991), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9992), "ÇÜNGÜŞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9992) },
                    { 270, 21, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9993), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9994), "DİCLE", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9993) },
                    { 271, 21, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9994), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9995), "EĞİL", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9995) },
                    { 272, 21, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9996), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9997), "ERGANİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9996) },
                    { 273, 21, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9997), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9998), "HANİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9998) },
                    { 274, 21, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9999), new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9999), "HAZRO", false, new DateTime(2025, 8, 20, 11, 21, 46, 365, DateTimeKind.Local).AddTicks(9999) },
                    { 275, 21, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1), "KAYAPINAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1) },
                    { 276, 21, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(2), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(2), "KOCAKÖY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(2) },
                    { 277, 21, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(3), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(4), "KULP", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(3) },
                    { 278, 21, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(5), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(5), "LİCE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(5) },
                    { 279, 21, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(6), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(7), "SİLVAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(6) },
                    { 280, 21, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(7), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(8), "SUR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(8) },
                    { 281, 21, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(9), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(10), "YENİŞEHİR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(9) },
                    { 282, 22, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(10), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(11), "ENEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(11) },
                    { 283, 22, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(12), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(13), "HAVSA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(12) },
                    { 284, 22, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(13), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(14), "İPSALA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(14) },
                    { 285, 22, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(15), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(16), "KEŞAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(15) },
                    { 286, 22, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(17), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(18), "LALAPAŞA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(17) },
                    { 287, 22, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(18), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(19), "MERİÇ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(19) },
                    { 288, 22, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(20), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(21), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(20) },
                    { 289, 22, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(21), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(22), "SÜLOĞLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(22) },
                    { 290, 22, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(23), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(24), "UZUNKÖPRÜ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(23) },
                    { 291, 23, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(24), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(25), "AĞIN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(25) },
                    { 292, 23, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(26), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(27), "ALACAKAYA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(26) },
                    { 293, 23, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(27), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(28), "ARICAK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(28) },
                    { 294, 23, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(29), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(30), "BASKİL", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(29) },
                    { 295, 23, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(30), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(31), "KARAKOÇAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(31) },
                    { 296, 23, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(32), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(32), "KEBAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(32) },
                    { 297, 23, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(33), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(34), "KOVANCILAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(34) },
                    { 298, 23, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(35), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(35), "MADEN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(35) },
                    { 299, 23, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(36), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(37), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(36) },
                    { 300, 23, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(37), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(38), "PALU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(38) },
                    { 301, 23, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(42), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(43), "SİVRİCE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(43) },
                    { 302, 24, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(44), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(45), "ÇAYIRLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(44) },
                    { 303, 24, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(45), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(46), "İLİÇ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(46) },
                    { 304, 24, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(47), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(48), "KEMAH", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(47) },
                    { 305, 24, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(48), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(49), "KEMALİYE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(49) },
                    { 306, 24, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(50), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(51), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(50) },
                    { 307, 24, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(51), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(52), "OTLUKBELİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(52) },
                    { 308, 24, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(53), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(54), "REFAHİYE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(53) },
                    { 309, 24, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(54), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(55), "TERCAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(55) },
                    { 310, 24, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(56), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(57), "ÜZÜMLÜ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(56) },
                    { 311, 25, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(57), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(58), "AŞKALE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(58) },
                    { 312, 25, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(59), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(60), "AZİZİYE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(59) },
                    { 313, 25, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(60), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(61), "ÇAT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(61) },
                    { 314, 25, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(62), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(63), "HINIS", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(62) },
                    { 315, 25, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(63), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(64), "HORASAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(64) },
                    { 316, 25, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(65), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(66), "İSPİR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(65) },
                    { 317, 25, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(67), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(68), "KARAÇOBAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(67) },
                    { 318, 25, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(68), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(69), "KARAYAZI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(69) },
                    { 319, 25, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(70), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(71), "KÖPRÜKÖY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(70) },
                    { 320, 25, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(71), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(72), "NARMAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(72) },
                    { 321, 25, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(73), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(74), "OLTU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(73) },
                    { 322, 25, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(74), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(75), "OLUR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(75) },
                    { 323, 25, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(76), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(77), "PALANDÖKEN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(76) },
                    { 324, 25, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(77), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(78), "PASİNLER", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(78) },
                    { 325, 25, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(79), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(80), "PAZARYOLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(79) },
                    { 326, 25, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(80), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(81), "ŞENKAYA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(81) },
                    { 327, 25, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(82), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(83), "TEKMAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(82) },
                    { 328, 25, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(83), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(84), "TORTUM", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(84) },
                    { 329, 25, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(85), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(85), "UZUNDERE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(85) },
                    { 330, 25, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(86), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(87), "YAKUTİYE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(87) },
                    { 331, 26, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(88), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(88), "ALPU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(88) },
                    { 332, 26, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(89), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(90), "BEYLİKOVA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(89) },
                    { 333, 26, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(91), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(91), "ÇİFTELER", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(91) },
                    { 334, 26, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(92), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(93), "GÜNYÜZÜ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(93) },
                    { 335, 26, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(94), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(94), "HAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(94) },
                    { 336, 26, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(95), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(96), "İNÖNÜ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(96) },
                    { 337, 26, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(97), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(97), "MAHMUDİYE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(97) },
                    { 338, 26, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(98), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(99), "MİHALGAZİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(98) },
                    { 339, 26, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(100), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(100), "MİHALIÇÇIK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(100) },
                    { 340, 26, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(101), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(102), "ODUNPAZARI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(101) },
                    { 341, 26, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(103), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(103), "SARICAKAYA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(103) },
                    { 342, 26, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(104), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(105), "SEYİTGAZİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(104) },
                    { 343, 26, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(105), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(106), "SİVRİHİSAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(106) },
                    { 344, 26, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(107), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(108), "TEPEBAŞI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(107) },
                    { 345, 27, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(108), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(109), "ARABAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(109) },
                    { 346, 27, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(110), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(111), "İSLAHİYE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(110) },
                    { 347, 27, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(111), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(112), "KARKAMIŞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(112) },
                    { 348, 27, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(113), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(114), "NİZİP", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(114) },
                    { 349, 27, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(115), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(116), "NURDAĞI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(115) },
                    { 350, 27, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(116), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(117), "OĞUZELİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(117) },
                    { 351, 27, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(118), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(119), "ŞAHİNBEY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(118) },
                    { 352, 27, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(119), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(120), "ŞEHİTKAMİL", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(120) },
                    { 353, 27, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(121), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(122), "YAVUZELİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(121) },
                    { 354, 28, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(122), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(123), "ALUCRA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(123) },
                    { 355, 28, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(124), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(125), "BULANCAK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(124) },
                    { 356, 28, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(125), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(126), "ÇAMOLUK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(126) },
                    { 357, 28, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(127), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(127), "ÇANAKÇI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(127) },
                    { 358, 28, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(128), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(129), "DERELİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(129) },
                    { 359, 28, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(130), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(130), "DOĞANKENT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(130) },
                    { 360, 28, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(131), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(132), "ESPİYE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(131) },
                    { 361, 28, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(133), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(133), "EYNESİL", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(133) },
                    { 362, 28, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(134), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(135), "GÖRELE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(134) },
                    { 363, 28, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(135), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(136), "GÜCE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(136) },
                    { 364, 28, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(137), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(138), "KEŞAP", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(137) },
                    { 365, 28, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(138), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(139), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(139) },
                    { 366, 28, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(140), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(141), "PİRAZİZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(140) },
                    { 367, 28, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(141), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(142), "ŞEBİNKARAHİSAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(142) },
                    { 368, 28, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(143), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(144), "TİREBOLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(143) },
                    { 369, 28, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(144), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(145), "YAĞLIDERE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(145) },
                    { 370, 29, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(146), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(147), "KELKİT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(146) },
                    { 371, 29, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(147), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(148), "KÖSE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(148) },
                    { 372, 29, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(149), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(150), "KÜRTÜN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(149) },
                    { 373, 29, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(150), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(151), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(151) },
                    { 374, 29, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(155), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(156), "ŞİRAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(156) },
                    { 375, 29, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(157), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(158), "TORUL", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(157) },
                    { 376, 30, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(158), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(159), "ÇUKURCA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(159) },
                    { 377, 30, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(160), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(161), "DERECİK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(160) },
                    { 378, 30, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(162), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(163), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(162) },
                    { 379, 30, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(163), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(164), "ŞEMDİNLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(164) },
                    { 380, 30, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(165), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(166), "YÜKSEKOVA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(165) },
                    { 381, 31, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(166), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(167), "ALTINÖZÜ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(167) },
                    { 382, 31, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(168), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(169), "ANTAKYA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(168) },
                    { 383, 31, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(169), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(170), "ARSUZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(170) },
                    { 384, 31, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(171), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(172), "BELEN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(171) },
                    { 385, 31, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(172), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(173), "DEFNE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(173) },
                    { 386, 31, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(174), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(175), "DÖRTYOL", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(174) },
                    { 387, 31, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(175), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(176), "ERZİN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(176) },
                    { 388, 31, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(177), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(178), "HASSA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(177) },
                    { 389, 31, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(178), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(179), "İSKENDERUN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(179) },
                    { 390, 31, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(180), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(180), "KIRIKHAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(180) },
                    { 391, 31, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(181), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(182), "KUMLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(181) },
                    { 392, 31, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(182), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(183), "PAYAS", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(183) },
                    { 393, 31, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(184), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(185), "REYHANLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(184) },
                    { 394, 31, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(185), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(186), "SAMANDAĞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(186) },
                    { 395, 31, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(187), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(188), "YAYLADAĞI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(187) },
                    { 396, 32, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(188), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(189), "AKSU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(189) },
                    { 397, 32, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(190), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(191), "ATABEY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(190) },
                    { 398, 32, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(191), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(192), "EĞİRDİR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(192) },
                    { 399, 32, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(193), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(194), "GELENDOST", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(193) },
                    { 400, 32, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(194), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(195), "GÖNEN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(195) },
                    { 401, 32, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(196), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(197), "KEÇİBORLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(196) },
                    { 402, 32, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(197), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(198), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(198) },
                    { 403, 32, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(199), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(200), "SENİRKENT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(199) },
                    { 404, 32, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(200), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(201), "SÜTÇÜLER", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(201) },
                    { 405, 32, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(202), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(203), "ŞARKİKARAAĞAÇ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(202) },
                    { 406, 32, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(203), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(204), "ULUBORLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(204) },
                    { 407, 32, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(205), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(205), "YALVAÇ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(205) },
                    { 408, 32, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(207), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(208), "YENİŞARBADEMLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(207) },
                    { 409, 33, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(208), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(209), "AKDENİZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(209) },
                    { 410, 33, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(210), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(211), "ANAMUR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(210) },
                    { 411, 33, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(211), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(212), "AYDINCIK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(212) },
                    { 412, 33, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(213), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(214), "BOZYAZI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(213) },
                    { 413, 33, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(214), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(215), "ÇAMLIYAYLA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(215) },
                    { 414, 33, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(216), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(217), "ERDEMLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(216) },
                    { 415, 33, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(217), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(218), "GÜLNAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(218) },
                    { 416, 33, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(219), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(220), "MEZİTLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(219) },
                    { 417, 33, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(220), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(221), "MUT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(221) },
                    { 418, 33, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(222), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(223), "SİLİFKE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(222) },
                    { 419, 33, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(223), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(224), "TARSUS", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(224) },
                    { 420, 33, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(225), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(225), "TOROSLAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(225) },
                    { 421, 33, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(226), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(227), "YENİŞEHİR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(227) },
                    { 422, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(228), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(228), "ADALAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(228) },
                    { 423, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(229), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(230), "ARNAVUTKÖY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(230) },
                    { 424, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(231), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(232), "ATAŞEHİR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(231) },
                    { 425, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(232), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(233), "AVCILAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(233) },
                    { 426, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(234), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(234), "BAĞCILAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(234) },
                    { 427, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(235), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(236), "BAHÇELİEVLER", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(236) },
                    { 428, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(237), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(237), "BAKIRKÖY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(237) },
                    { 429, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(238), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(239), "BAŞAKŞEHİR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(238) },
                    { 430, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(239), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(240), "BAYRAMPAŞA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(240) },
                    { 431, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(241), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(242), "BEŞİKTAŞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(241) },
                    { 432, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(242), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(243), "BEYKOZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(243) },
                    { 433, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(244), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(245), "BEYLİKDÜZÜ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(244) },
                    { 434, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(245), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(246), "BEYOĞLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(246) },
                    { 435, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(247), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(248), "BÜYÜKÇEKMECE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(247) },
                    { 436, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(248), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(249), "ÇATALCA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(249) },
                    { 437, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(250), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(251), "ÇEKMEKÖY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(250) },
                    { 438, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(251), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(252), "ESENLER", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(252) },
                    { 439, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(254), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(255), "ESENYURT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(254) },
                    { 440, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(255), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(256), "EYÜPSULTAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(256) },
                    { 441, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(257), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(258), "FATİH", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(257) },
                    { 442, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(258), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(259), "GAZİOSMANPAŞA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(259) },
                    { 443, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(260), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(261), "GÜNGÖREN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(260) },
                    { 444, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(261), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(262), "KADIKÖY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(262) },
                    { 445, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(263), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(263), "KAĞITHANE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(263) },
                    { 446, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(267), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(269), "KARTAL", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(268) },
                    { 447, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(269), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(270), "KÜÇÜKÇEKMECE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(270) },
                    { 448, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(271), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(272), "MALTEPE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(271) },
                    { 449, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(272), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(273), "PENDİK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(273) },
                    { 450, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(274), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(274), "SANCAKTEPE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(274) },
                    { 451, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(275), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(276), "SARIYER", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(276) },
                    { 452, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(277), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(277), "SİLİVRİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(277) },
                    { 453, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(278), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(279), "SULTANBEYLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(278) },
                    { 454, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(279), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(280), "SULTANGAZİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(280) },
                    { 455, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(281), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(282), "ŞİLE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(281) },
                    { 456, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(282), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(283), "ŞİŞLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(283) },
                    { 457, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(285), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(286), "TUZLA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(285) },
                    { 458, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(286), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(287), "ÜMRANİYE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(287) },
                    { 459, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(288), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(289), "ÜSKÜDAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(289) },
                    { 460, 34, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(290), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(291), "ZEYTİNBURNU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(290) },
                    { 461, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(291), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(292), "ALİAĞA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(292) },
                    { 462, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(293), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(294), "BALÇOVA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(293) },
                    { 463, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(294), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(295), "BAYINDIR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(295) },
                    { 464, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(296), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(296), "BAYRAKLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(296) },
                    { 465, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(297), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(298), "BERGAMA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(298) },
                    { 466, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(299), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(299), "BEYDAĞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(299) },
                    { 467, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(300), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(301), "BORNOVA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(301) },
                    { 468, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(302), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(302), "BUCA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(302) },
                    { 469, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(303), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(304), "ÇEŞME", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(303) },
                    { 470, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(305), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(306), "ÇİĞLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(306) },
                    { 471, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(307), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(308), "DİKİLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(307) },
                    { 472, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(308), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(309), "FOÇA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(309) },
                    { 473, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(310), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(311), "GAZİEMİR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(311) },
                    { 474, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(312), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(312), "GÜZELBAHÇE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(312) },
                    { 475, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(314), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(315), "KARABAĞLAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(314) },
                    { 476, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(315), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(316), "KARABURUN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(316) },
                    { 477, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(317), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(318), "KARŞIYAKA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(318) },
                    { 478, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(319), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(319), "KEMALPAŞA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(319) },
                    { 479, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(320), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(321), "KINIK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(321) },
                    { 480, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(322), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(322), "KİRAZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(322) },
                    { 481, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(323), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(324), "KONAK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(324) },
                    { 482, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(325), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(325), "MENDERES", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(325) },
                    { 483, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(326), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(327), "MENEMEN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(326) },
                    { 484, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(327), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(328), "NARLIDERE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(328) },
                    { 485, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(329), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(330), "ÖDEMİŞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(329) },
                    { 486, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(330), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(331), "SEFERİHİSAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(331) },
                    { 487, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(332), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(333), "SELÇUK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(332) },
                    { 488, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(333), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(334), "TİRE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(334) },
                    { 489, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(335), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(335), "TORBALI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(335) },
                    { 490, 35, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(336), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(337), "URLA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(336) },
                    { 491, 36, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(338), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(338), "AKYAKA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(338) },
                    { 492, 36, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(339), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(340), "ARPAÇAY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(339) },
                    { 493, 36, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(340), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(341), "DİGOR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(341) },
                    { 494, 36, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(342), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(343), "KAĞIZMAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(342) },
                    { 495, 36, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(343), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(344), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(344) },
                    { 496, 36, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(345), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(346), "SARIKAMIŞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(345) },
                    { 497, 36, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(346), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(347), "SELİM", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(347) },
                    { 498, 36, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(348), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(349), "SUSUZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(348) },
                    { 499, 37, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(349), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(350), "ABANA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(350) },
                    { 500, 37, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(351), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(352), "AĞLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(352) },
                    { 501, 37, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(353), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(354), "ARAÇ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(353) },
                    { 502, 37, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(354), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(355), "AZDAVAY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(355) },
                    { 503, 37, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(356), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(356), "BOZKURT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(356) },
                    { 504, 37, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(357), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(358), "CİDE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(357) },
                    { 505, 37, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(359), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(359), "ÇATALZEYTİN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(359) },
                    { 506, 37, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(360), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(361), "DADAY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(360) },
                    { 507, 37, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(362), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(362), "DEVREKANİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(362) },
                    { 508, 37, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(363), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(364), "DOĞANYURT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(363) },
                    { 509, 37, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(365), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(366), "HANÖNÜ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(365) },
                    { 510, 37, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(366), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(367), "İHSANGAZİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(367) },
                    { 511, 37, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(368), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(368), "İNEBOLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(368) },
                    { 512, 37, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(369), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(370), "KÜRE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(370) },
                    { 513, 37, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(371), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(371), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(371) },
                    { 514, 37, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(372), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(373), "PINARBAŞI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(372) },
                    { 515, 37, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(373), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(374), "SEYDİLER", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(374) },
                    { 516, 37, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(375), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(376), "ŞENPAZAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(375) },
                    { 517, 37, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(376), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(377), "TAŞKÖPRÜ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(377) },
                    { 518, 37, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(378), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(379), "TOSYA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(378) },
                    { 519, 38, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(383), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(384), "AKKIŞLA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(384) },
                    { 520, 38, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(385), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(386), "BÜNYAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(385) },
                    { 521, 38, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(386), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(387), "DEVELİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(387) },
                    { 522, 38, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(388), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(388), "FELAHİYE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(388) },
                    { 523, 38, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(389), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(390), "HACILAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(390) },
                    { 524, 38, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(392), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(392), "İNCESU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(392) },
                    { 525, 38, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(393), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(394), "KOCASİNAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(393) },
                    { 526, 38, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(394), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(395), "MELİKGAZİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(395) },
                    { 527, 38, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(396), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(397), "ÖZVATAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(397) },
                    { 528, 38, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(398), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(399), "PINARBAŞI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(398) },
                    { 529, 38, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(399), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(400), "SARIOĞLAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(400) },
                    { 530, 38, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(401), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(402), "SARIZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(401) },
                    { 531, 38, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(403), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(404), "TALAS", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(403) },
                    { 532, 38, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(404), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(405), "TOMARZA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(405) },
                    { 533, 38, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(406), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(407), "YAHYALI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(407) },
                    { 534, 38, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(408), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(408), "YEŞİLHİSAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(408) },
                    { 535, 39, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(409), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(410), "BABAESKİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(410) },
                    { 536, 39, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(411), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(411), "DEMİRKÖY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(411) },
                    { 537, 39, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(412), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(413), "KOFÇAZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(412) },
                    { 538, 39, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(413), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(414), "LÜLEBURGAZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(414) },
                    { 539, 39, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(415), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(416), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(415) },
                    { 540, 39, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(416), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(417), "PEHLİVANKÖY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(417) },
                    { 541, 39, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(418), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(419), "PINARHİSAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(418) },
                    { 542, 39, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(419), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(420), "VİZE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(420) },
                    { 543, 40, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(421), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(422), "AKÇAKENT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(421) },
                    { 544, 40, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(422), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(423), "AKPINAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(423) },
                    { 545, 40, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(424), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(424), "BOZTEPE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(424) },
                    { 546, 40, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(425), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(426), "ÇİÇEKDAĞI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(426) },
                    { 547, 40, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(427), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(427), "KAMAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(427) },
                    { 548, 40, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(428), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(429), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(428) },
                    { 549, 40, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(429), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(430), "MUCUR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(430) },
                    { 550, 41, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(431), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(432), "BAŞİSKELE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(431) },
                    { 551, 41, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(432), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(433), "ÇAYIROVA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(433) },
                    { 552, 41, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(434), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(435), "DARICA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(434) },
                    { 553, 41, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(435), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(436), "DERİNCE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(436) },
                    { 554, 41, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(437), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(438), "DİLOVASI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(437) },
                    { 555, 41, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(438), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(439), "GEBZE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(439) },
                    { 556, 41, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(440), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(440), "GÖLCÜK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(440) },
                    { 557, 41, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(441), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(442), "İZMİT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(442) },
                    { 558, 41, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(443), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(443), "KANDIRA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(443) },
                    { 559, 41, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(444), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(445), "KARAMÜRSEL", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(444) },
                    { 560, 41, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(446), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(446), "KARTEPE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(446) },
                    { 561, 41, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(447), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(448), "KÖRFEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(447) },
                    { 562, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(449), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(450), "AHIRLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(450) },
                    { 563, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(451), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(452), "AKÖREN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(451) },
                    { 564, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(452), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(453), "AKŞEHİR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(453) },
                    { 565, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(454), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(455), "ALTINEKİN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(454) },
                    { 566, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(455), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(456), "BEYŞEHİR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(456) },
                    { 567, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(457), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(457), "BOZKIR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(457) },
                    { 568, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(458), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(459), "CİHANBEYLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(458) },
                    { 569, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(459), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(460), "ÇELTİK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(460) },
                    { 570, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(461), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(462), "ÇUMRA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(461) },
                    { 571, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(462), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(463), "DERBENT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(463) },
                    { 572, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(464), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(465), "DEREBUCAK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(464) },
                    { 573, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(465), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(466), "DOĞANHİSAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(466) },
                    { 574, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(467), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(468), "EMİRGAZİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(467) },
                    { 575, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(468), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(469), "EREĞLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(469) },
                    { 576, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(470), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(470), "GÜNEYSINIR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(470) },
                    { 577, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(471), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(472), "HADİM", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(471) },
                    { 578, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(472), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(473), "HALKAPINAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(473) },
                    { 579, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(474), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(475), "HÜYÜK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(474) },
                    { 580, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(475), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(476), "ILGIN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(476) },
                    { 581, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(477), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(478), "KADINHANI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(477) },
                    { 582, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(478), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(479), "KARAPINAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(479) },
                    { 583, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(480), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(481), "KARATAY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(480) },
                    { 584, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(481), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(482), "KULU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(482) },
                    { 585, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(483), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(483), "MERAM", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(483) },
                    { 586, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(484), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(485), "SARAYÖNÜ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(485) },
                    { 587, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(486), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(487), "SELÇUKLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(486) },
                    { 588, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(487), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(488), "SEYDİŞEHİR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(488) },
                    { 589, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(489), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(489), "TAŞKENT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(489) },
                    { 590, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(490), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(491), "TUZLUKÇU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(490) },
                    { 591, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(492), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(492), "YALIHÜYÜK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(492) },
                    { 592, 42, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(497), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(498), "YUNAK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(498) },
                    { 593, 43, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(499), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(500), "ALTINTAŞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(499) },
                    { 594, 43, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(501), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(501), "ASLANAPA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(501) },
                    { 595, 43, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(502), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(503), "ÇAVDARHİSAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(502) },
                    { 596, 43, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(503), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(504), "DOMANİÇ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(504) },
                    { 597, 43, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(505), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(506), "DUMLUPINAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(505) },
                    { 598, 43, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(506), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(507), "EMET", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(507) },
                    { 599, 43, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(508), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(509), "GEDİZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(508) },
                    { 600, 43, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(509), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(510), "HİSARCIK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(510) },
                    { 601, 43, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(511), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(512), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(511) },
                    { 602, 43, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(512), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(513), "PAZARLAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(513) },
                    { 603, 43, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(514), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(515), "SİMAV", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(514) },
                    { 604, 43, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(515), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(516), "ŞAPHANE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(516) },
                    { 605, 43, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(517), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(518), "TAVŞANLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(517) },
                    { 606, 44, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(518), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(519), "AKÇADAĞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(519) },
                    { 607, 44, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(520), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(521), "ARAPGİR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(520) },
                    { 608, 44, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(521), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(522), "ARGUVAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(522) },
                    { 609, 44, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(523), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(524), "BATTALGAZİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(523) },
                    { 610, 44, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(524), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(525), "DARENDE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(525) },
                    { 611, 44, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(526), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(526), "DOĞANŞEHİR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(526) },
                    { 612, 44, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(527), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(528), "DOĞANYOL", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(527) },
                    { 613, 44, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(528), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(529), "HEKİMHAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(529) },
                    { 614, 44, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(530), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(531), "KALE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(530) },
                    { 615, 44, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(531), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(532), "KULUNCAK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(532) },
                    { 616, 44, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(533), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(534), "PÜTÜRGE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(533) },
                    { 617, 44, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(534), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(535), "YAZIHAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(535) },
                    { 618, 44, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(536), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(537), "YEŞİLYURT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(536) },
                    { 619, 45, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(537), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(538), "AHMETLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(538) },
                    { 620, 45, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(539), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(540), "AKHİSAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(539) },
                    { 621, 45, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(540), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(541), "ALAŞEHİR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(541) },
                    { 622, 45, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(542), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(543), "DEMİRCİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(542) },
                    { 623, 45, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(544), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(545), "GÖLMARMARA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(544) },
                    { 624, 45, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(545), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(546), "GÖRDES", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(546) },
                    { 625, 45, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(547), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(548), "KIRKAĞAÇ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(547) },
                    { 626, 45, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(548), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(549), "KÖPRÜBAŞI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(549) },
                    { 627, 45, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(550), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(550), "KULA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(550) },
                    { 628, 45, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(551), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(552), "SALİHLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(551) },
                    { 629, 45, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(553), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(553), "SARIGÖL", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(553) },
                    { 630, 45, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(554), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(555), "SARUHANLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(554) },
                    { 631, 45, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(555), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(556), "SELENDİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(556) },
                    { 632, 45, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(557), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(558), "SOMA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(557) },
                    { 633, 45, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(558), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(559), "ŞEHZADELER", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(559) },
                    { 634, 45, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(560), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(561), "TURGUTLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(560) },
                    { 635, 45, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(561), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(562), "YUNUSEMRE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(562) },
                    { 636, 46, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(563), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(564), "AFŞİN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(564) },
                    { 637, 46, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(565), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(566), "ANDIRIN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(565) },
                    { 638, 46, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(567), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(568), "ÇAĞLAYANCERİT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(567) },
                    { 639, 46, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(568), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(569), "DULKADİROĞLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(569) },
                    { 640, 46, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(570), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(570), "EKİNÖZÜ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(570) },
                    { 641, 46, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(571), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(572), "ELBİSTAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(571) },
                    { 642, 46, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(572), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(573), "GÖKSUN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(573) },
                    { 643, 46, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(574), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(575), "NURHAK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(574) },
                    { 644, 46, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(575), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(576), "ONİKİŞUBAT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(576) },
                    { 645, 46, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(577), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(578), "PAZARCIK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(577) },
                    { 646, 46, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(578), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(579), "TÜRKOĞLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(579) },
                    { 647, 47, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(580), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(581), "ARTUKLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(580) },
                    { 648, 47, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(581), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(582), "DARGEÇİT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(582) },
                    { 649, 47, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(583), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(583), "DERİK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(583) },
                    { 650, 47, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(584), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(585), "KIZILTEPE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(584) },
                    { 651, 47, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(585), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(586), "MAZIDAĞI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(586) },
                    { 652, 47, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(588), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(588), "MİDYAT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(588) },
                    { 653, 47, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(589), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(590), "NUSAYBİN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(589) },
                    { 654, 47, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(590), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(591), "ÖMERLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(591) },
                    { 655, 47, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(592), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(593), "SAVUR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(592) },
                    { 656, 47, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(593), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(594), "YEŞİLLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(594) },
                    { 657, 48, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(595), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(596), "BODRUM", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(595) },
                    { 658, 48, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(596), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(597), "DALAMAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(597) },
                    { 659, 48, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(598), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(598), "DATÇA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(598) },
                    { 660, 48, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(599), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(600), "FETHİYE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(599) },
                    { 661, 48, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(601), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(601), "KAVAKLIDERE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(601) },
                    { 662, 48, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(602), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(603), "KÖYCEĞİZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(602) },
                    { 663, 48, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(603), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(604), "MARMARİS", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(604) },
                    { 664, 48, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(605), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(606), "MENTEŞE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(605) },
                    { 665, 48, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(610), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(611), "MİLAS", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(611) },
                    { 666, 48, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(612), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(612), "ORTACA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(612) },
                    { 667, 48, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(613), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(614), "SEYDİKEMER", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(613) },
                    { 668, 48, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(614), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(615), "ULA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(615) },
                    { 669, 48, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(616), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(617), "YATAĞAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(616) },
                    { 670, 49, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(617), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(618), "BULANIK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(618) },
                    { 671, 49, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(619), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(620), "HASKÖY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(619) },
                    { 672, 49, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(620), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(621), "KORKUT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(621) },
                    { 673, 49, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(622), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(623), "MALAZGİRT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(622) },
                    { 674, 49, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(623), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(624), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(624) },
                    { 675, 49, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(625), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(625), "VARTO", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(625) },
                    { 676, 50, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(626), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(627), "ACIGÖL", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(626) },
                    { 677, 50, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(627), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(628), "AVANOS", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(628) },
                    { 678, 50, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(629), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(630), "DERİNKUYU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(629) },
                    { 679, 50, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(630), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(631), "GÜLŞEHİR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(631) },
                    { 680, 50, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(632), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(632), "HACIBEKTAŞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(632) },
                    { 681, 50, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(633), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(634), "KOZAKLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(634) },
                    { 682, 50, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(635), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(635), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(635) },
                    { 683, 50, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(636), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(637), "ÜRGÜP", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(636) },
                    { 684, 51, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(638), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(639), "ALTUNHİSAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(639) },
                    { 685, 51, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(640), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(641), "BOR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(640) },
                    { 686, 51, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(641), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(642), "ÇAMARDI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(642) },
                    { 687, 51, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(643), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(644), "ÇİFTLİK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(643) },
                    { 688, 51, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(644), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(645), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(645) },
                    { 689, 51, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(646), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(646), "ULUKIŞLA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(646) },
                    { 690, 52, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(647), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(648), "AKKUŞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(647) },
                    { 691, 52, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(649), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(649), "ALTINORDU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(649) },
                    { 692, 52, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(650), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(651), "AYBASTI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(650) },
                    { 693, 52, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(651), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(652), "ÇAMAŞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(652) },
                    { 694, 52, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(653), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(654), "ÇATALPINAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(653) },
                    { 695, 52, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(654), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(655), "ÇAYBAŞI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(655) },
                    { 696, 52, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(656), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(657), "FATSA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(656) },
                    { 697, 52, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(657), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(658), "GÖLKÖY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(658) },
                    { 698, 52, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(659), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(660), "GÜLYALI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(659) },
                    { 699, 52, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(660), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(661), "GÜRGENTEPE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(661) },
                    { 700, 52, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(662), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(662), "İKİZCE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(662) },
                    { 701, 52, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(663), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(664), "KABADÜZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(664) },
                    { 702, 52, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(665), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(665), "KABATAŞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(665) },
                    { 703, 52, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(666), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(667), "KORGAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(666) },
                    { 704, 52, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(667), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(668), "KUMRU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(668) },
                    { 705, 52, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(669), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(670), "MESUDİYE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(669) },
                    { 706, 52, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(670), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(671), "PERŞEMBE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(671) },
                    { 707, 52, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(672), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(673), "ULUBEY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(672) },
                    { 708, 52, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(673), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(674), "ÜNYE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(674) },
                    { 709, 53, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(675), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(675), "ARDEŞEN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(675) },
                    { 710, 53, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(676), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(677), "ÇAMLIHEMŞİN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(676) },
                    { 711, 53, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(677), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(678), "ÇAYELİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(678) },
                    { 712, 53, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(679), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(680), "DEREPAZARI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(679) },
                    { 713, 53, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(680), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(681), "FINDIKLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(681) },
                    { 714, 53, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(682), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(683), "GÜNEYSU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(682) },
                    { 715, 53, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(684), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(685), "HEMŞİN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(684) },
                    { 716, 53, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(685), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(686), "İKİZDERE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(686) },
                    { 717, 53, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(687), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(688), "İYİDERE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(687) },
                    { 718, 53, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(688), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(689), "KALKANDERE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(689) },
                    { 719, 53, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(690), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(691), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(690) },
                    { 720, 53, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(691), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(692), "PAZAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(692) },
                    { 721, 54, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(693), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(694), "ADAPAZARI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(693) },
                    { 722, 54, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(694), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(695), "AKYAZI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(695) },
                    { 723, 54, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(696), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(696), "ARİFİYE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(696) },
                    { 724, 54, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(697), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(698), "ERENLER", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(697) },
                    { 725, 54, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(698), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(699), "FERİZLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(699) },
                    { 726, 54, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(700), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(701), "GEYVE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(700) },
                    { 727, 54, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(701), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(702), "HENDEK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(702) },
                    { 728, 54, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(703), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(704), "KARAPÜRÇEK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(703) },
                    { 729, 54, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(704), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(705), "KARASU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(705) },
                    { 730, 54, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(706), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(707), "KAYNARCA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(706) },
                    { 731, 54, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(707), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(708), "KOCAALİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(708) },
                    { 732, 54, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(709), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(710), "PAMUKOVA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(709) },
                    { 733, 54, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(710), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(711), "SAPANCA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(711) },
                    { 734, 54, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(712), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(712), "SERDİVAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(712) },
                    { 735, 54, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(713), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(714), "SÖĞÜTLÜ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(713) },
                    { 736, 54, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(714), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(715), "TARAKLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(715) },
                    { 737, 55, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(716), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(717), "ALAÇAM", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(716) },
                    { 738, 55, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(721), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(722), "ASARCIK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(722) },
                    { 739, 55, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(723), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(724), "ATAKUM", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(723) },
                    { 740, 55, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(724), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(725), "AYVACIK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(725) },
                    { 741, 55, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(726), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(727), "BAFRA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(726) },
                    { 742, 55, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(727), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(728), "CANİK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(728) },
                    { 743, 55, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(729), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(730), "ÇARŞAMBA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(729) },
                    { 744, 55, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(730), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(731), "HAVZA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(731) },
                    { 745, 55, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(733), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(733), "İLKADIM", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(733) },
                    { 746, 55, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(734), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(735), "KAVAK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(734) },
                    { 747, 55, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(735), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(736), "LADİK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(736) },
                    { 748, 55, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(737), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(738), "SALIPAZARI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(737) },
                    { 749, 55, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(738), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(739), "TEKKEKÖY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(739) },
                    { 750, 55, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(740), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(741), "TERME", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(740) },
                    { 751, 55, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(741), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(742), "VEZİRKÖPRÜ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(742) },
                    { 752, 55, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(743), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(743), "YAKAKENT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(743) },
                    { 753, 55, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(744), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(745), "19 MAYIS", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(744) },
                    { 754, 56, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(745), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(746), "BAYKAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(746) },
                    { 755, 56, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(747), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(748), "ERUH", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(747) },
                    { 756, 56, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(748), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(749), "KURTALAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(749) },
                    { 757, 56, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(750), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(751), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(750) },
                    { 758, 56, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(751), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(752), "PERVARİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(752) },
                    { 759, 56, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(753), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(754), "ŞİRVAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(753) },
                    { 760, 56, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(754), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(755), "TİLLO", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(755) },
                    { 761, 57, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(756), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(757), "AYANCIK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(756) },
                    { 762, 57, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(757), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(758), "BOYABAT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(758) },
                    { 763, 57, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(759), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(760), "DİKMEN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(759) },
                    { 764, 57, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(760), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(761), "DURAĞAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(761) },
                    { 765, 57, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(762), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(762), "ERFELEK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(762) },
                    { 766, 57, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(763), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(764), "GERZE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(763) },
                    { 767, 57, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(764), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(765), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(765) },
                    { 768, 57, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(766), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(767), "SARAYDÜZÜ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(766) },
                    { 769, 57, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(767), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(768), "TÜRKELİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(768) },
                    { 770, 58, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(769), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(770), "AKINCILAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(769) },
                    { 771, 58, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(770), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(771), "ALTINYAYLA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(771) },
                    { 772, 58, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(772), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(772), "DİVRİĞİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(772) },
                    { 773, 58, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(773), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(774), "DOĞANŞAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(774) },
                    { 774, 58, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(775), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(775), "GEMEREK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(775) },
                    { 775, 58, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(776), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(777), "GÖLOVA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(776) },
                    { 776, 58, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(778), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(779), "GÜRÜN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(779) },
                    { 777, 58, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(780), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(781), "HAFİK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(780) },
                    { 778, 58, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(781), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(782), "İMRANLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(782) },
                    { 779, 58, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(783), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(783), "KANGAL", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(783) },
                    { 780, 58, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(784), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(785), "KOYULHİSAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(784) },
                    { 781, 58, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(785), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(786), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(786) },
                    { 782, 58, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(787), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(788), "SUŞEHRİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(787) },
                    { 783, 58, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(788), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(789), "ŞARKIŞLA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(789) },
                    { 784, 58, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(790), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(791), "ULAŞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(790) },
                    { 785, 58, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(791), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(792), "YILDIZELİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(792) },
                    { 786, 58, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(793), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(794), "ZARA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(793) },
                    { 787, 59, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(794), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(795), "ÇERKEZKÖY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(795) },
                    { 788, 59, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(796), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(796), "ÇORLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(796) },
                    { 789, 59, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(797), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(798), "ERGENE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(797) },
                    { 790, 59, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(798), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(799), "HAYRABOLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(799) },
                    { 791, 59, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(800), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(801), "KAPAKLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(800) },
                    { 792, 59, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(801), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(802), "MALKARA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(802) },
                    { 793, 59, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(803), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(804), "MARMARAEREĞLİSİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(803) },
                    { 794, 59, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(804), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(805), "MURATLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(805) },
                    { 795, 59, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(806), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(806), "SARAY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(806) },
                    { 796, 59, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(807), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(808), "SÜLEYMANPAŞA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(808) },
                    { 797, 59, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(809), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(809), "ŞARKÖY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(809) },
                    { 798, 60, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(810), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(811), "ALMUS", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(810) },
                    { 799, 60, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(811), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(812), "ARTOVA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(812) },
                    { 800, 60, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(813), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(814), "BAŞÇİFTLİK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(813) },
                    { 801, 60, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(814), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(815), "ERBAA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(815) },
                    { 802, 60, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(816), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(817), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(816) },
                    { 803, 60, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(817), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(818), "NİKSAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(818) },
                    { 804, 60, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(819), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(820), "PAZAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(819) },
                    { 805, 60, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(820), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(821), "REŞADİYE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(821) },
                    { 806, 60, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(822), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(822), "SULUSARAY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(822) },
                    { 807, 60, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(824), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(825), "TURHAL", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(824) },
                    { 808, 60, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(825), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(826), "YEŞİLYURT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(826) },
                    { 809, 60, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(827), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(828), "ZİLE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(827) },
                    { 810, 61, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(828), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(829), "AKÇAABAT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(829) },
                    { 811, 61, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(834), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(836), "ARAKLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(835) },
                    { 812, 61, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(836), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(837), "ARSİN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(837) },
                    { 813, 61, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(838), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(839), "BEŞİKDÜZÜ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(838) },
                    { 814, 61, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(839), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(840), "ÇARŞIBAŞI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(840) },
                    { 815, 61, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(841), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(841), "ÇAYKARA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(841) },
                    { 816, 61, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(842), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(843), "DERNEKPAZARI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(842) },
                    { 817, 61, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(843), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(844), "DÜZKÖY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(844) },
                    { 818, 61, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(845), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(846), "HAYRAT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(845) },
                    { 819, 61, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(846), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(847), "KÖPRÜBAŞI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(847) },
                    { 820, 61, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(848), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(849), "MAÇKA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(848) },
                    { 821, 61, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(849), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(850), "OF", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(850) },
                    { 822, 61, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(851), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(852), "ORTAHİSAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(851) },
                    { 823, 61, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(852), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(853), "SÜRMENE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(853) },
                    { 824, 61, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(854), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(854), "ŞALPAZARI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(854) },
                    { 825, 61, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(855), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(856), "TONYA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(855) },
                    { 826, 61, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(856), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(857), "VAKFIKEBİR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(857) },
                    { 827, 61, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(858), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(859), "YOMRA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(858) },
                    { 828, 62, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(859), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(860), "ÇEMİŞGEZEK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(860) },
                    { 829, 62, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(861), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(862), "HOZAT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(861) },
                    { 830, 62, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(862), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(863), "MAZGİRT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(863) },
                    { 831, 62, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(864), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(865), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(864) },
                    { 832, 62, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(865), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(866), "NAZIMİYE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(866) },
                    { 833, 62, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(867), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(867), "OVACIK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(867) },
                    { 834, 62, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(868), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(869), "PERTEK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(868) },
                    { 835, 62, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(869), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(870), "PÜLÜMÜR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(870) },
                    { 836, 63, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(871), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(872), "AKÇAKALE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(871) },
                    { 837, 63, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(872), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(873), "BİRECİK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(873) },
                    { 838, 63, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(875), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(875), "BOZOVA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(875) },
                    { 839, 63, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(876), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(877), "CEYLANPINAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(876) },
                    { 840, 63, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(877), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(878), "EYYÜBİYE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(878) },
                    { 841, 63, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(879), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(880), "HALFETİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(879) },
                    { 842, 63, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(880), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(881), "HALİLİYE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(881) },
                    { 843, 63, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(882), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(883), "HARRAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(882) },
                    { 844, 63, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(883), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(884), "HİLVAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(884) },
                    { 845, 63, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(885), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(885), "KARAKÖPRÜ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(885) },
                    { 846, 63, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(886), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(887), "SİVEREK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(886) },
                    { 847, 63, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(888), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(888), "SURUÇ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(888) },
                    { 848, 63, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(889), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(890), "VİRANŞEHİR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(889) },
                    { 849, 64, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(890), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(891), "BANAZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(891) },
                    { 850, 64, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(892), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(893), "EŞME", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(892) },
                    { 851, 64, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(893), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(894), "KARAHALLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(894) },
                    { 852, 64, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(895), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(896), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(895) },
                    { 853, 64, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(896), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(897), "SİVASLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(897) },
                    { 854, 64, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(898), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(899), "ULUBEY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(898) },
                    { 855, 65, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(899), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(900), "BAHÇESARAY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(900) },
                    { 856, 65, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(901), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(901), "BAŞKALE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(901) },
                    { 857, 65, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(902), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(903), "ÇALDIRAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(903) },
                    { 858, 65, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(904), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(904), "ÇATAK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(904) },
                    { 859, 65, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(905), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(906), "EDREMİT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(905) },
                    { 860, 65, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(906), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(907), "ERCİŞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(907) },
                    { 861, 65, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(908), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(909), "GEVAŞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(908) },
                    { 862, 65, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(909), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(910), "GÜRPINAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(910) },
                    { 863, 65, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(911), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(912), "İPEKYOLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(911) },
                    { 864, 65, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(912), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(913), "MURADİYE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(913) },
                    { 865, 65, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(914), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(914), "ÖZALP", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(914) },
                    { 866, 65, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(915), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(916), "SARAY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(915) },
                    { 867, 65, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(916), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(917), "TUŞBA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(917) },
                    { 868, 66, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(918), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(919), "AKDAĞMADENİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(918) },
                    { 869, 66, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(920), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(921), "AYDINCIK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(920) },
                    { 870, 66, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(921), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(922), "BOĞAZLIYAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(922) },
                    { 871, 66, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(923), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(924), "ÇANDIR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(923) },
                    { 872, 66, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(924), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(925), "ÇAYIRALAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(925) },
                    { 873, 66, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(926), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(927), "ÇEKEREK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(926) },
                    { 874, 66, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(927), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(928), "KADIŞEHRİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(928) },
                    { 875, 66, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(929), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(929), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(929) },
                    { 876, 66, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(930), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(931), "SARAYKENT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(930) },
                    { 877, 66, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(931), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(932), "SARIKAYA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(932) },
                    { 878, 66, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(933), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(934), "SORGUN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(933) },
                    { 879, 66, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(934), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(935), "ŞEFAATLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(935) },
                    { 880, 66, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(936), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(936), "YENİFAKILI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(936) },
                    { 881, 66, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(937), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(938), "YERKÖY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(938) },
                    { 882, 67, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(939), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(939), "ALAPLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(939) },
                    { 883, 67, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(940), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(941), "ÇAYCUMA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(940) },
                    { 884, 67, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(945), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(946), "DEVREK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(946) },
                    { 885, 67, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(947), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(947), "EREĞLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(947) },
                    { 886, 67, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(948), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(949), "GÖKÇEBEY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(948) },
                    { 887, 67, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(949), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(950), "KİLİMLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(950) },
                    { 888, 67, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(951), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(952), "KOZLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(951) },
                    { 889, 67, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(952), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(953), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(953) },
                    { 890, 68, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(954), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(955), "AĞAÇÖREN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(954) },
                    { 891, 68, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(955), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(956), "ESKİL", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(956) },
                    { 892, 68, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(957), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(958), "GÜLAĞAÇ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(957) },
                    { 893, 68, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(958), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(959), "GÜZELYURT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(959) },
                    { 894, 68, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(960), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(960), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(960) },
                    { 895, 68, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(961), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(962), "ORTAKÖY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(961) },
                    { 896, 68, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(962), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(963), "SARIYAHŞİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(963) },
                    { 897, 68, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(964), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(965), "SULTANHANI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(964) },
                    { 898, 69, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(965), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(966), "AYDINTEPE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(966) },
                    { 899, 69, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(968), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(968), "DEMİRÖZÜ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(968) },
                    { 900, 69, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(969), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(970), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(969) },
                    { 901, 70, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(970), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(971), "AYRANCI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(971) },
                    { 902, 70, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(972), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(973), "BAŞYAYLA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(972) },
                    { 903, 70, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(973), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(974), "ERMENEK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(974) },
                    { 904, 70, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(975), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(976), "KAZIMKARABEKİR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(975) },
                    { 905, 70, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(976), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(977), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(977) },
                    { 906, 70, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(978), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(979), "SARIVELİLER", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(978) },
                    { 907, 71, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(979), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(980), "BAHŞİLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(980) },
                    { 908, 71, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(981), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(982), "BALIŞEYH", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(981) },
                    { 909, 71, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(983), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(983), "ÇELEBİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(983) },
                    { 910, 71, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(984), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(985), "DELİCE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(984) },
                    { 911, 71, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(985), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(986), "KARAKEÇİLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(986) },
                    { 912, 71, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(987), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(988), "KESKİN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(987) },
                    { 913, 71, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(988), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(989), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(989) },
                    { 914, 71, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(990), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(991), "SULAKYURT", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(990) },
                    { 915, 71, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(991), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(992), "YAHŞİHAN", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(992) },
                    { 916, 72, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(993), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(994), "BEŞİRİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(993) },
                    { 917, 72, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(994), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(995), "GERCÜŞ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(995) },
                    { 918, 72, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(996), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(996), "HASANKEYF", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(996) },
                    { 919, 72, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(997), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(998), "KOZLUK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(998) },
                    { 920, 72, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(999), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(999), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(999) },
                    { 921, 72, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1000), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1001), "SASON", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1000) },
                    { 922, 73, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1001), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1002), "BEYTÜŞŞEBAP", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1002) },
                    { 923, 73, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1003), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1004), "CİZRE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1003) },
                    { 924, 73, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1004), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1005), "GÜÇLÜKONAK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1005) },
                    { 925, 73, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1006), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1007), "İDİL", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1006) },
                    { 926, 73, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1007), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1008), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1008) },
                    { 927, 73, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1009), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1010), "SİLOPİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1009) },
                    { 928, 73, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1010), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1011), "ULUDERE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1011) },
                    { 929, 74, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1012), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1013), "AMASRA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1012) },
                    { 930, 74, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1014), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1015), "KURUCAŞİLE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1014) },
                    { 931, 74, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1015), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1016), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1016) },
                    { 932, 74, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1017), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1018), "ULUS", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1017) },
                    { 933, 75, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1018), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1019), "ÇILDIR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1019) },
                    { 934, 75, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1020), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1020), "DAMAL", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1020) },
                    { 935, 75, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1021), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1022), "GÖLE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1021) },
                    { 936, 75, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1022), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1023), "HANAK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1023) },
                    { 937, 75, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1024), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1025), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1024) },
                    { 938, 75, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1025), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1026), "POSOF", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1026) },
                    { 939, 76, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1027), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1028), "ARALIK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1027) },
                    { 940, 76, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1028), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1029), "KARAKOYUNLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1029) },
                    { 941, 76, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1030), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1030), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1030) },
                    { 942, 76, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1031), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1032), "TUZLUCA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1031) },
                    { 943, 77, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1033), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1033), "ALTINOVA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1033) },
                    { 944, 77, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1034), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1035), "ARMUTLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1034) },
                    { 945, 77, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1035), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1036), "ÇINARCIK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1036) },
                    { 946, 77, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1037), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1038), "ÇİFTLİKKÖY", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1037) },
                    { 947, 77, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1038), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1039), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1039) },
                    { 948, 77, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1040), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1040), "TERMAL", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1040) },
                    { 949, 78, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1041), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1042), "EFLANİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1042) },
                    { 950, 78, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1043), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1043), "ESKİPAZAR", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1043) },
                    { 951, 78, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1044), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1045), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1044) },
                    { 952, 78, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1045), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1046), "OVACIK", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1046) },
                    { 953, 78, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1047), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1048), "SAFRANBOLU", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1047) },
                    { 954, 78, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1048), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1049), "YENİCE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1049) },
                    { 955, 79, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1050), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1051), "ELBEYLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1050) },
                    { 956, 79, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1051), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1052), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1052) },
                    { 957, 79, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1056), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1057), "MUSABEYLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1057) },
                    { 958, 79, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1058), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1059), "POLATELİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1058) },
                    { 959, 80, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1059), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1060), "BAHÇE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1060) },
                    { 960, 80, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1061), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1062), "DÜZİÇİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1061) },
                    { 961, 80, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1062), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1063), "HASANBEYLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1063) },
                    { 962, 80, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1064), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1064), "KADİRLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1064) },
                    { 963, 80, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1065), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1066), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1066) },
                    { 964, 80, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1067), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1067), "SUMBAS", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1067) },
                    { 965, 80, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1068), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1069), "TOPRAKKALE", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1068) },
                    { 966, 81, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1069), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1070), "AKÇAKOCA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1070) },
                    { 967, 81, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1071), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1072), "CUMAYERİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1071) },
                    { 968, 81, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1072), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1073), "ÇİLİMLİ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1073) },
                    { 969, 81, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1074), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1074), "GÖLYAKA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1074) },
                    { 970, 81, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1075), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1076), "GÜMÜŞOVA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1075) },
                    { 971, 81, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1077), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1077), "KAYNAŞLI", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1077) },
                    { 972, 81, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1078), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1079), "MERKEZ", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1078) },
                    { 973, 81, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1079), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1080), "YIĞILCA", false, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1080) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CityID", "CreatedDate", "DeletedDate", "DistrictID", "Mail", "Name", "Password", "Status", "Surname", "UpdatedDate", "UserName" },
                values: new object[] { 1, 1, new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1464), new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1462), 1, "", "Büşra", "12345", false, "Güneş", new DateTime(2025, 8, 20, 11, 21, 46, 366, DateTimeKind.Local).AddTicks(1462), "busra" });

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
