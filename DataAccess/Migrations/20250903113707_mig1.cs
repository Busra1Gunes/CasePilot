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
                    RoleID = table.Column<int>(type: "int", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
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

            migrationBuilder.InsertData(
                table: "ApplicationTypes",
                columns: new[] { "ID", "CaseTypeID", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(2969), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(2971), "Araç Hasarı", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(2970) },
                    { 2, 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(2973), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(2974), "Manevi", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(2974) },
                    { 3, 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(2975), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(2976), "İdari Dava", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(2976) },
                    { 4, 4, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(2977), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(2978), "Kamulaştırma", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(2978) }
                });

            migrationBuilder.InsertData(
                table: "CaseTypes",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3390), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3392), "Trafik Kazası", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3391) },
                    { 2, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3393), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3394), "Arabuluculuk", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3394) },
                    { 3, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3395), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3396), "İdari Dava", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3396) },
                    { 4, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3397), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3398), "Kamulaştırma", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3397) }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3580), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3581), "Adana", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3581) },
                    { 2, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3582), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3583), "Adıyaman", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3583) },
                    { 3, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3584), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3585), "Afyonkarahisar", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3584) },
                    { 4, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3585), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3586), "Ağrı", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3586) },
                    { 5, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3587), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3588), "Amasya", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3587) },
                    { 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3588), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3589), "Ankara", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3589) },
                    { 7, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3590), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3591), "Antalya", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3590) },
                    { 8, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3591), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3592), "Artvin", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3592) },
                    { 9, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3593), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3594), "Aydın", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3593) },
                    { 10, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3594), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3595), "Balıkesir", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3595) },
                    { 11, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3596), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3597), "Bilecik", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3596) },
                    { 12, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3597), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3598), "Bingöl", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3598) },
                    { 13, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3599), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3600), "Bitlis", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3599) },
                    { 14, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3600), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3601), "Bolu", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3601) },
                    { 15, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3602), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3603), "Burdur", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3602) },
                    { 16, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3603), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3604), "Bursa", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3604) },
                    { 17, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3605), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3606), "Çanakkale", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3605) },
                    { 18, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3606), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3607), "Çankırı", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3607) },
                    { 19, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3608), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3609), "Çorum", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3608) },
                    { 20, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3609), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3610), "Denizli", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3610) },
                    { 21, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3611), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3612), "Diyarbakır", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3611) },
                    { 22, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3612), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3613), "Edirne", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3613) },
                    { 23, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3614), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3615), "Elazığ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3614) },
                    { 24, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3615), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3616), "Erzincan", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3616) },
                    { 25, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3617), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3618), "Erzurum", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3617) },
                    { 26, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3619), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3619), "Eskişehir", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3619) },
                    { 27, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3624), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3625), "Gaziantep", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3625) },
                    { 28, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3626), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3627), "Giresun", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3627) },
                    { 29, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3628), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3628), "Gümüşhane", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3628) },
                    { 30, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3629), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3630), "Hakkari", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3630) },
                    { 31, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3631), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3631), "Hatay", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3631) },
                    { 32, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3632), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3633), "Isparta", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3632) },
                    { 33, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3634), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3634), "Mersin", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3634) },
                    { 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3635), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3636), "İstanbul", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3635) },
                    { 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3636), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3637), "İzmir", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3637) },
                    { 36, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3638), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3639), "Kars", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3638) },
                    { 37, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3639), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3640), "Kastamonu", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3640) },
                    { 38, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3642), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3643), "Kayseri", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3642) },
                    { 39, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3643), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3644), "Kırklareli", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3644) },
                    { 40, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3645), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3646), "Kırşehir", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3645) },
                    { 41, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3646), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3647), "Kocaeli", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3647) },
                    { 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3648), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3649), "Konya", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3648) },
                    { 43, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3649), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3650), "Kütahya", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3650) },
                    { 44, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3651), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3652), "Malatya", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3651) },
                    { 45, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3652), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3653), "Manisa", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3653) },
                    { 46, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3654), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3655), "Kahramanmaraş", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3654) },
                    { 47, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3655), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3656), "Mardin", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3656) },
                    { 48, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3657), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3658), "Muğla", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3657) },
                    { 49, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3658), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3659), "Muş", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3659) },
                    { 50, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3660), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3660), "Nevşehir", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3660) },
                    { 51, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3661), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3662), "Niğde", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3662) },
                    { 52, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3663), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3663), "Ordu", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3663) },
                    { 53, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3664), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3665), "Rize", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3664) },
                    { 54, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3666), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3666), "Sakarya", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3666) },
                    { 55, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3667), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3668), "Samsun", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3667) },
                    { 56, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3669), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3669), "Siirt", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3669) },
                    { 57, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3670), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3671), "Sinop", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3670) },
                    { 58, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3672), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3672), "Sivas", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3672) },
                    { 59, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3673), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3674), "Tekirdağ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3673) },
                    { 60, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3674), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3675), "Tokat", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3675) },
                    { 61, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3676), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3677), "Trabzon", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3676) },
                    { 62, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3677), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3678), "Tunceli", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3678) },
                    { 63, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3679), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3680), "Şanlıurfa", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3679) },
                    { 64, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3680), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3681), "Uşak", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3681) },
                    { 65, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3682), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3683), "Van", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3682) },
                    { 66, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3683), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3684), "Yozgat", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3684) },
                    { 67, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3685), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3686), "Zonguldak", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3685) },
                    { 68, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3686), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3687), "Aksaray", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3687) },
                    { 69, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3688), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3689), "Bayburt", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3688) },
                    { 70, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3689), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3690), "Karaman", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3690) },
                    { 71, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3691), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3692), "Kırıkkale", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3691) },
                    { 72, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3692), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3693), "Batman", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3693) },
                    { 73, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3694), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3695), "Şırnak", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3694) },
                    { 74, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3695), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3696), "Bartın", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3696) },
                    { 75, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3697), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3698), "Ardahan", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3697) },
                    { 76, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3698), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3699), "Iğdır", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3699) },
                    { 77, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3700), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3701), "Yalova", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3700) },
                    { 78, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3701), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3702), "Karabük", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3702) },
                    { 79, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3703), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3704), "Kilis", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3703) },
                    { 80, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3704), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3705), "Osmaniye", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3705) },
                    { 81, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3706), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3707), "Düzce", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3706) }
                });

            migrationBuilder.InsertData(
                table: "DocumentTypes",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Name", "Status", "Type", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5897), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5898), "TcKimlik", false, "DosyaEvrak", new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5898) },
                    { 2, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5900), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5901), "Sici Kaydı", false, "KullaniciEvrak", new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5901) }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "ID", "Code", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[] { 1, "caseFile-list", new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(2462), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(2460), "Case File List", true, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(2459) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Description", "Name", "Status", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(2770), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(2769), "This is a admin roles", "Admin", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(2768) });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "ID", "CityID", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3933), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3935), "ALADAĞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3934) },
                    { 2, 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3936), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3937), "CEYHAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3937) },
                    { 3, 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3938), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3939), "ÇUKUROVA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3938) },
                    { 4, 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3940), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3940), "FEKE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3940) },
                    { 5, 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3941), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3942), "İMAMOĞLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3942) },
                    { 6, 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3943), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3944), "KARAİSALI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3943) },
                    { 7, 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3944), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3945), "KARATAŞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3945) },
                    { 8, 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3946), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3947), "KOZAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3946) },
                    { 9, 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3948), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3948), "POZANTI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3948) },
                    { 10, 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3949), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3950), "SAİMBEYLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3950) },
                    { 11, 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3951), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3952), "SARIÇAM", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3951) },
                    { 12, 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3952), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3953), "SEYHAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3953) },
                    { 13, 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3954), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3955), "TUFANBEYLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3954) },
                    { 14, 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3956), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3956), "YUMURTALIK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3956) },
                    { 15, 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3957), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3958), "YÜREĞİR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3958) },
                    { 16, 2, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3959), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3960), "BESNİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3959) },
                    { 17, 2, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3960), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3961), "ÇELİKHAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3961) },
                    { 18, 2, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3962), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3963), "GERGER", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3962) },
                    { 19, 2, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3964), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3964), "GÖLBAŞI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3964) },
                    { 20, 2, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3965), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3966), "KAHTA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3966) },
                    { 21, 2, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3967), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3968), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3967) },
                    { 22, 2, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3970), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3970), "SAMSAT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3970) },
                    { 23, 2, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3971), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3972), "SİNCİK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3972) },
                    { 24, 2, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3973), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3973), "TUT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3973) },
                    { 25, 3, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3974), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3975), "BAŞMAKÇI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3975) },
                    { 26, 3, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3976), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3977), "BAYAT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3976) },
                    { 27, 3, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3977), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3978), "BOLVADİN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3978) },
                    { 28, 3, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3979), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3980), "ÇAY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3979) },
                    { 29, 3, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3980), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3981), "ÇOBANLAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3981) },
                    { 30, 3, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3982), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3983), "DAZKIRI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3982) },
                    { 31, 3, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3983), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3984), "DİNAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3984) },
                    { 32, 3, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3985), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3986), "EMİRDAĞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3985) },
                    { 33, 3, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3986), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3987), "EVCİLER", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3987) },
                    { 34, 3, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3988), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3989), "HOCALAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3988) },
                    { 35, 3, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3990), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3990), "İHSANİYE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3990) },
                    { 36, 3, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3991), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3992), "İSCEHİSAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3991) },
                    { 37, 3, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3993), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3993), "KIZILÖREN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3993) },
                    { 38, 3, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3994), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3995), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3995) },
                    { 39, 3, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3996), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3997), "SANDIKLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3996) },
                    { 40, 3, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3997), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3998), "SİNANPAŞA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3998) },
                    { 41, 3, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3999), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4000), "SULTANDAĞI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(3999) },
                    { 42, 3, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4000), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4001), "ŞUHUT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4001) },
                    { 43, 4, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4002), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4003), "DİYADİN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4002) },
                    { 44, 4, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4003), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4004), "DOĞUBAYAZIT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4004) },
                    { 45, 4, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4005), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4006), "ELEŞKİRT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4005) },
                    { 46, 4, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4007), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4007), "HAMUR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4007) },
                    { 47, 4, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4008), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4009), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4008) },
                    { 48, 4, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4010), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4010), "PATNOS", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4010) },
                    { 49, 4, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4011), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4012), "TAŞLIÇAY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4012) },
                    { 50, 4, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4013), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4013), "TUTAK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4013) },
                    { 51, 5, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4014), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4015), "GÖYNÜCEK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4015) },
                    { 52, 5, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4016), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4017), "GÜMÜŞHACIKÖY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4016) },
                    { 53, 5, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4018), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4019), "HAMAMÖZÜ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4018) },
                    { 54, 5, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4019), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4020), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4020) },
                    { 55, 5, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4021), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4022), "MERZİFON", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4021) },
                    { 56, 5, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4022), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4023), "SULUOVA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4023) },
                    { 57, 5, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4024), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4025), "TAŞOVA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4024) },
                    { 58, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4026), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4026), "AKYURT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4026) },
                    { 59, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4027), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4028), "ALTINDAĞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4027) },
                    { 60, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4029), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4029), "AYAŞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4029) },
                    { 61, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4030), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4031), "BALA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4031) },
                    { 62, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4032), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4033), "BEYPAZARI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4032) },
                    { 63, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4033), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4034), "ÇAMLIDERE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4034) },
                    { 64, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4035), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4036), "ÇANKAYA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4035) },
                    { 65, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4036), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4037), "ÇUBUK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4037) },
                    { 66, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4038), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4039), "ELMADAĞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4038) },
                    { 67, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4039), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4040), "ETİMESGUT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4040) },
                    { 68, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4046), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4048), "EVREN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4047) },
                    { 69, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4048), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4049), "GÖLBAŞI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4049) },
                    { 70, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4050), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4051), "GÜDÜL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4050) },
                    { 71, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4051), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4052), "HAYMANA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4052) },
                    { 72, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4053), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4054), "KAHRAMANKAZAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4053) },
                    { 73, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4054), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4055), "KALECİK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4055) },
                    { 74, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4056), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4057), "KEÇİÖREN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4056) },
                    { 75, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4058), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4058), "KIZILCAHAMAM", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4058) },
                    { 76, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4059), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4060), "MAMAK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4060) },
                    { 77, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4061), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4061), "NALLIHAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4061) },
                    { 78, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4062), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4063), "POLATLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4063) },
                    { 79, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4064), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4065), "PURSAKLAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4064) },
                    { 80, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4065), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4066), "SİNCAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4066) },
                    { 81, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4067), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4068), "ŞEREFLİKOÇHİSAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4067) },
                    { 82, 6, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4068), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4069), "YENİMAHALLE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4069) },
                    { 83, 7, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4070), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4071), "AKSEKİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4070) },
                    { 84, 7, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4072), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4073), "AKSU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4073) },
                    { 85, 7, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4074), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4075), "ALANYA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4074) },
                    { 86, 7, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4075), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4076), "DEMRE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4076) },
                    { 87, 7, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4077), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4078), "DÖŞEMEALTI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4077) },
                    { 88, 7, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4079), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4079), "ELMALI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4079) },
                    { 89, 7, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4080), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4081), "FİNİKE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4080) },
                    { 90, 7, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4082), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4082), "GAZİPAŞA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4082) },
                    { 91, 7, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4083), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4084), "GÜNDOĞMUŞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4084) },
                    { 92, 7, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4085), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4086), "İBRADI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4085) },
                    { 93, 7, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4086), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4087), "KAŞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4087) },
                    { 94, 7, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4088), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4089), "KEMER", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4088) },
                    { 95, 7, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4089), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4090), "KEPEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4090) },
                    { 96, 7, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4091), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4092), "KONYAALTI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4091) },
                    { 97, 7, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4092), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4093), "KORKUTELİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4093) },
                    { 98, 7, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4094), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4095), "KUMLUCA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4094) },
                    { 99, 7, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4096), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4096), "MANAVGAT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4096) },
                    { 100, 7, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4097), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4098), "MURATPAŞA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4097) },
                    { 101, 7, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4099), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4099), "SERİK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4099) },
                    { 102, 8, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4100), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4101), "ARDANUÇ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4101) },
                    { 103, 8, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4102), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4102), "ARHAVİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4102) },
                    { 104, 8, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4103), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4104), "BORÇKA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4104) },
                    { 105, 8, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4105), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4106), "HOPA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4105) },
                    { 106, 8, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4106), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4107), "KEMALPAŞA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4107) },
                    { 107, 8, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4108), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4109), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4108) },
                    { 108, 8, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4109), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4110), "MURGUL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4110) },
                    { 109, 8, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4111), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4112), "ŞAVŞAT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4111) },
                    { 110, 8, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4112), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4113), "YUSUFELİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4113) },
                    { 111, 9, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4114), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4115), "BOZDOĞAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4114) },
                    { 112, 9, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4115), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4116), "BUHARKENT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4116) },
                    { 113, 9, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4117), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4118), "ÇİNE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4117) },
                    { 114, 9, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4119), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4120), "DİDİM", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4120) },
                    { 115, 9, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4121), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4122), "EFELER", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4121) },
                    { 116, 9, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4123), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4123), "GERMENCİK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4123) },
                    { 117, 9, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4124), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4125), "İNCİRLİOVA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4125) },
                    { 118, 9, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4126), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4127), "KARACASU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4126) },
                    { 119, 9, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4127), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4128), "KARPUZLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4128) },
                    { 120, 9, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4129), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4130), "KOÇARLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4129) },
                    { 121, 9, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4130), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4131), "KÖŞK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4131) },
                    { 122, 9, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4132), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4133), "KUŞADASI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4132) },
                    { 123, 9, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4133), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4134), "KUYUCAK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4134) },
                    { 124, 9, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4135), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4136), "NAZİLLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4135) },
                    { 125, 9, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4136), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4137), "SÖKE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4137) },
                    { 126, 9, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4138), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4139), "SULTANHİSAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4138) },
                    { 127, 9, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4140), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4140), "YENİPAZAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4140) },
                    { 128, 10, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4141), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4142), "ALTIEYLÜL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4141) },
                    { 129, 10, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4143), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4143), "AYVALIK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4143) },
                    { 130, 10, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4144), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4145), "BALYA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4145) },
                    { 131, 10, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4146), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4146), "BANDIRMA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4146) },
                    { 132, 10, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4147), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4148), "BİGADİÇ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4148) },
                    { 133, 10, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4149), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4150), "BURHANİYE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4149) },
                    { 134, 10, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4150), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4151), "DURSUNBEY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4151) },
                    { 135, 10, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4152), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4153), "EDREMİT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4152) },
                    { 136, 10, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4153), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4154), "ERDEK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4154) },
                    { 137, 10, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4155), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4156), "GÖMEÇ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4155) },
                    { 138, 10, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4157), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4158), "GÖNEN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4157) },
                    { 139, 10, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4159), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4160), "HAVRAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4159) },
                    { 140, 10, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4160), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4161), "İVRİNDİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4161) },
                    { 141, 10, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4166), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4168), "KARESİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4168) },
                    { 142, 10, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4169), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4170), "KEPSUT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4169) },
                    { 143, 10, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4171), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4171), "MANYAS", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4171) },
                    { 144, 10, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4172), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4173), "MARMARA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4173) },
                    { 145, 10, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4175), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4176), "SAVAŞTEPE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4176) },
                    { 146, 10, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4177), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4178), "SINDIRGI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4177) },
                    { 147, 10, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4178), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4179), "SUSURLUK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4179) },
                    { 148, 11, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4180), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4181), "BOZÜYÜK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4180) },
                    { 149, 11, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4182), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4182), "GÖLPAZARI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4182) },
                    { 150, 11, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4183), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4184), "İNHİSAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4183) },
                    { 151, 11, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4185), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4185), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4185) },
                    { 152, 11, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4186), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4187), "OSMANELİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4187) },
                    { 153, 11, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4188), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4188), "PAZARYERİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4188) },
                    { 154, 11, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4189), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4190), "SÖĞÜT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4190) },
                    { 155, 11, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4191), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4192), "YENİPAZAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4191) },
                    { 156, 12, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4192), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4193), "ADAKLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4193) },
                    { 157, 12, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4194), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4195), "GENÇ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4194) },
                    { 158, 12, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4195), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4196), "KARLIOVA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4196) },
                    { 159, 12, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4197), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4198), "KİĞI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4197) },
                    { 160, 12, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4198), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4199), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4199) },
                    { 161, 12, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4200), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4201), "SOLHAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4200) },
                    { 162, 12, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4202), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4202), "YAYLADERE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4202) },
                    { 163, 12, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4203), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4204), "YEDİSU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4204) },
                    { 164, 13, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4205), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4206), "ADİLCEVAZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4205) },
                    { 165, 13, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4206), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4207), "AHLAT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4207) },
                    { 166, 13, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4208), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4209), "GÜROYMAK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4208) },
                    { 167, 13, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4210), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4210), "HİZAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4210) },
                    { 168, 13, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4211), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4212), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4212) },
                    { 169, 13, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4213), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4213), "MUTKİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4213) },
                    { 170, 13, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4214), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4215), "TATVAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4215) },
                    { 171, 14, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4216), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4217), "DÖRTDİVAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4216) },
                    { 172, 14, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4217), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4218), "GEREDE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4218) },
                    { 173, 14, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4219), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4220), "GÖYNÜK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4219) },
                    { 174, 14, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4220), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4221), "KIBRISCIK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4221) },
                    { 175, 14, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4223), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4224), "MENGEN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4223) },
                    { 176, 14, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4224), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4225), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4225) },
                    { 177, 14, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4226), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4227), "MUDURNU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4226) },
                    { 178, 14, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4228), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4228), "SEBEN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4228) },
                    { 179, 14, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4229), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4230), "YENİÇAĞA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4230) },
                    { 180, 15, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4231), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4232), "AĞLASUN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4231) },
                    { 181, 15, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4232), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4233), "ALTINYAYLA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4233) },
                    { 182, 15, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4234), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4235), "BUCAK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4234) },
                    { 183, 15, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4236), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4236), "ÇAVDIR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4236) },
                    { 184, 15, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4237), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4238), "ÇELTİKÇİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4238) },
                    { 185, 15, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4239), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4240), "GÖLHİSAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4239) },
                    { 186, 15, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4240), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4241), "KARAMANLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4241) },
                    { 187, 15, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4242), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4243), "KEMER", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4242) },
                    { 188, 15, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4243), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4244), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4244) },
                    { 189, 15, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4245), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4246), "TEFENNİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4245) },
                    { 190, 15, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4247), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4247), "YEŞİLOVA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4247) },
                    { 191, 16, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4248), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4249), "BÜYÜKORHAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4248) },
                    { 192, 16, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4250), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4250), "GEMLİK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4250) },
                    { 193, 16, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4251), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4252), "GÜRSU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4251) },
                    { 194, 16, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4253), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4253), "HARMANCIK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4253) },
                    { 195, 16, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4254), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4255), "İNEGÖL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4255) },
                    { 196, 16, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4256), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4257), "İZNİK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4256) },
                    { 197, 16, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4257), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4258), "KARACABEY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4258) },
                    { 198, 16, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4259), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4260), "KELES", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4259) },
                    { 199, 16, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4260), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4261), "KESTEL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4261) },
                    { 200, 16, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4262), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4263), "MUDANYA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4262) },
                    { 201, 16, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4264), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4264), "MUSTAFAKEMALPAŞA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4264) },
                    { 202, 16, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4265), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4266), "NİLÜFER", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4266) },
                    { 203, 16, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4267), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4268), "ORHANELİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4267) },
                    { 204, 16, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4268), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4269), "ORHANGAZİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4269) },
                    { 205, 16, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4270), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4271), "OSMANGAZİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4270) },
                    { 206, 16, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4272), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4273), "YENİŞEHİR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4273) },
                    { 207, 16, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4274), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4275), "YILDIRIM", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4274) },
                    { 208, 17, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4275), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4276), "AYVACIK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4276) },
                    { 209, 17, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4277), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4278), "BAYRAMİÇ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4277) },
                    { 210, 17, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4278), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4279), "BİGA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4279) },
                    { 211, 17, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4280), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4281), "BOZCAADA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4280) },
                    { 212, 17, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4281), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4282), "ÇAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4282) },
                    { 213, 17, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4283), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4284), "ECEABAT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4283) },
                    { 214, 17, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4288), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4290), "EZİNE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4289) },
                    { 215, 17, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4290), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4291), "GELİBOLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4291) },
                    { 216, 17, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4292), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4293), "GÖKÇEADA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4292) },
                    { 217, 17, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4293), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4294), "LAPSEKİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4294) },
                    { 218, 17, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4295), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4296), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4295) },
                    { 219, 17, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4297), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4297), "YENİCE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4297) },
                    { 220, 18, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4298), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4299), "ATKARACALAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4299) },
                    { 221, 18, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4300), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4300), "BAYRAMÖREN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4300) },
                    { 222, 18, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4301), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4302), "ÇERKEŞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4302) },
                    { 223, 18, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4303), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4304), "ELDİVAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4303) },
                    { 224, 18, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4304), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4305), "ILGAZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4305) },
                    { 225, 18, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4306), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4307), "KIZILIRMAK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4306) },
                    { 226, 18, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4307), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4308), "KORGUN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4308) },
                    { 227, 18, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4309), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4310), "KURŞUNLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4309) },
                    { 228, 18, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4310), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4311), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4311) },
                    { 229, 18, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4312), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4313), "ORTA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4312) },
                    { 230, 18, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4314), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4314), "ŞABANÖZÜ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4314) },
                    { 231, 18, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4315), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4316), "YAPRAKLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4316) },
                    { 232, 19, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4317), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4318), "ALACA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4317) },
                    { 233, 19, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4318), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4319), "BAYAT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4319) },
                    { 234, 19, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4320), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4321), "BOĞAZKALE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4320) },
                    { 235, 19, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4321), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4322), "DODURGA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4322) },
                    { 236, 19, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4324), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4325), "İSKİLİP", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4325) },
                    { 237, 19, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4326), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4327), "KARGI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4326) },
                    { 238, 19, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4327), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4328), "LAÇİN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4328) },
                    { 239, 19, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4329), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4330), "MECİTÖZÜ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4329) },
                    { 240, 19, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4331), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4331), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4331) },
                    { 241, 19, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4332), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4333), "OĞUZLAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4333) },
                    { 242, 19, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4334), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4335), "ORTAKÖY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4334) },
                    { 243, 19, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4335), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4336), "OSMANCIK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4336) },
                    { 244, 19, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4337), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4338), "SUNGURLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4337) },
                    { 245, 19, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4339), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4340), "UĞURLUDAĞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4339) },
                    { 246, 20, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4340), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4341), "ACIPAYAM", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4341) },
                    { 247, 20, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4342), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4343), "BABADAĞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4342) },
                    { 248, 20, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4344), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4344), "BAKLAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4344) },
                    { 249, 20, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4345), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4346), "BEKİLLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4346) },
                    { 250, 20, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4347), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4347), "BEYAĞAÇ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4347) },
                    { 251, 20, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4348), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4349), "BOZKURT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4349) },
                    { 252, 20, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4350), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4350), "BULDAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4350) },
                    { 253, 20, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4351), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4352), "ÇAL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4352) },
                    { 254, 20, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4353), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4354), "ÇAMELİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4353) },
                    { 255, 20, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4354), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4355), "ÇARDAK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4355) },
                    { 256, 20, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4356), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4357), "ÇİVRİL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4356) },
                    { 257, 20, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4357), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4358), "GÜNEY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4358) },
                    { 258, 20, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4359), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4360), "HONAZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4359) },
                    { 259, 20, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4360), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4361), "KALE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4361) },
                    { 260, 20, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4362), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4363), "MERKEZEFENDİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4362) },
                    { 261, 20, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4363), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4364), "PAMUKKALE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4364) },
                    { 262, 20, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4365), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4366), "SARAYKÖY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4365) },
                    { 263, 20, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4367), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4367), "SERİNHİSAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4367) },
                    { 264, 20, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4368), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4369), "TAVAS", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4369) },
                    { 265, 21, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4370), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4370), "BAĞLAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4370) },
                    { 266, 21, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4371), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4372), "BİSMİL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4372) },
                    { 267, 21, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4374), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4375), "ÇERMİK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4374) },
                    { 268, 21, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4375), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4376), "ÇINAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4376) },
                    { 269, 21, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4377), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4378), "ÇÜNGÜŞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4377) },
                    { 270, 21, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4378), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4379), "DİCLE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4379) },
                    { 271, 21, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4380), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4381), "EĞİL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4380) },
                    { 272, 21, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4381), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4382), "ERGANİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4382) },
                    { 273, 21, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4383), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4384), "HANİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4383) },
                    { 274, 21, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4385), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4385), "HAZRO", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4385) },
                    { 275, 21, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4386), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4387), "KAYAPINAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4386) },
                    { 276, 21, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4388), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4388), "KOCAKÖY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4388) },
                    { 277, 21, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4389), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4390), "KULP", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4390) },
                    { 278, 21, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4391), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4392), "LİCE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4391) },
                    { 279, 21, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4392), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4393), "SİLVAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4393) },
                    { 280, 21, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4394), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4395), "SUR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4394) },
                    { 281, 21, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4395), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4396), "YENİŞEHİR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4396) },
                    { 282, 22, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4397), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4398), "ENEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4397) },
                    { 283, 22, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4398), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4399), "HAVSA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4399) },
                    { 284, 22, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4400), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4401), "İPSALA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4400) },
                    { 285, 22, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4403), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4403), "KEŞAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4403) },
                    { 286, 22, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4404), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4405), "LALAPAŞA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4405) },
                    { 287, 22, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4409), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4411), "MERİÇ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4410) },
                    { 288, 22, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4412), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4412), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4412) },
                    { 289, 22, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4413), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4414), "SÜLOĞLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4413) },
                    { 290, 22, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4415), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4415), "UZUNKÖPRÜ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4415) },
                    { 291, 23, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4416), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4417), "AĞIN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4417) },
                    { 292, 23, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4418), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4419), "ALACAKAYA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4418) },
                    { 293, 23, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4419), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4420), "ARICAK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4420) },
                    { 294, 23, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4421), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4422), "BASKİL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4421) },
                    { 295, 23, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4423), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4423), "KARAKOÇAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4423) },
                    { 296, 23, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4424), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4425), "KEBAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4425) },
                    { 297, 23, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4426), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4427), "KOVANCILAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4426) },
                    { 298, 23, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4428), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4429), "MADEN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4429) },
                    { 299, 23, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4430), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4431), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4430) },
                    { 300, 23, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4431), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4432), "PALU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4432) },
                    { 301, 23, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4433), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4434), "SİVRİCE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4433) },
                    { 302, 24, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4434), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4435), "ÇAYIRLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4435) },
                    { 303, 24, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4436), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4437), "İLİÇ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4436) },
                    { 304, 24, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4437), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4438), "KEMAH", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4438) },
                    { 305, 24, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4439), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4440), "KEMALİYE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4439) },
                    { 306, 24, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4440), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4441), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4441) },
                    { 307, 24, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4442), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4443), "OTLUKBELİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4442) },
                    { 308, 24, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4444), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4444), "REFAHİYE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4444) },
                    { 309, 24, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4445), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4446), "TERCAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4445) },
                    { 310, 24, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4447), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4447), "ÜZÜMLÜ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4447) },
                    { 311, 25, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4448), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4449), "AŞKALE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4449) },
                    { 312, 25, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4450), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4451), "AZİZİYE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4450) },
                    { 313, 25, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4451), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4452), "ÇAT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4452) },
                    { 314, 25, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4453), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4454), "HINIS", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4453) },
                    { 315, 25, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4454), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4455), "HORASAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4455) },
                    { 316, 25, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4456), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4457), "İSPİR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4456) },
                    { 317, 25, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4458), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4458), "KARAÇOBAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4458) },
                    { 318, 25, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4459), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4460), "KARAYAZI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4460) },
                    { 319, 25, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4461), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4461), "KÖPRÜKÖY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4461) },
                    { 320, 25, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4462), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4463), "NARMAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4463) },
                    { 321, 25, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4464), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4465), "OLTU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4464) },
                    { 322, 25, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4465), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4466), "OLUR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4466) },
                    { 323, 25, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4467), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4468), "PALANDÖKEN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4467) },
                    { 324, 25, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4468), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4469), "PASİNLER", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4469) },
                    { 325, 25, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4470), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4471), "PAZARYOLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4470) },
                    { 326, 25, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4471), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4472), "ŞENKAYA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4472) },
                    { 327, 25, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4473), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4474), "TEKMAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4473) },
                    { 328, 25, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4475), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4476), "TORTUM", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4476) },
                    { 329, 25, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4477), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4478), "UZUNDERE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4477) },
                    { 330, 25, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4478), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4479), "YAKUTİYE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4479) },
                    { 331, 26, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4480), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4481), "ALPU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4480) },
                    { 332, 26, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4481), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4482), "BEYLİKOVA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4482) },
                    { 333, 26, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4483), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4484), "ÇİFTELER", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4483) },
                    { 334, 26, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4484), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4485), "GÜNYÜZÜ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4485) },
                    { 335, 26, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4486), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4487), "HAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4486) },
                    { 336, 26, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4487), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4488), "İNÖNÜ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4488) },
                    { 337, 26, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4489), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4490), "MAHMUDİYE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4489) },
                    { 338, 26, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4490), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4491), "MİHALGAZİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4491) },
                    { 339, 26, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4492), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4493), "MİHALIÇÇIK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4492) },
                    { 340, 26, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4494), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4494), "ODUNPAZARI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4494) },
                    { 341, 26, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4495), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4496), "SARICAKAYA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4496) },
                    { 342, 26, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4497), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4498), "SEYİTGAZİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4497) },
                    { 343, 26, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4498), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4499), "SİVRİHİSAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4499) },
                    { 344, 26, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4500), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4501), "TEPEBAŞI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4500) },
                    { 345, 27, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4502), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4502), "ARABAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4502) },
                    { 346, 27, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4503), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4504), "İSLAHİYE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4503) },
                    { 347, 27, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4505), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4505), "KARKAMIŞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4505) },
                    { 348, 27, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4506), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4507), "NİZİP", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4507) },
                    { 349, 27, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4508), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4509), "NURDAĞI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4508) },
                    { 350, 27, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4509), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4510), "OĞUZELİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4510) },
                    { 351, 27, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4511), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4512), "ŞAHİNBEY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4511) },
                    { 352, 27, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4512), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4513), "ŞEHİTKAMİL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4513) },
                    { 353, 27, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4514), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4515), "YAVUZELİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4514) },
                    { 354, 28, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4515), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4516), "ALUCRA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4516) },
                    { 355, 28, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4517), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4518), "BULANCAK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4517) },
                    { 356, 28, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4518), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4519), "ÇAMOLUK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4519) },
                    { 357, 28, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4520), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4521), "ÇANAKÇI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4520) },
                    { 358, 28, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4521), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4522), "DERELİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4522) },
                    { 359, 28, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4523), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4524), "DOĞANKENT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4524) },
                    { 360, 28, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4529), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4530), "ESPİYE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4530) },
                    { 361, 28, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4531), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4532), "EYNESİL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4531) },
                    { 362, 28, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4532), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4533), "GÖRELE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4533) },
                    { 363, 28, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4534), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4535), "GÜCE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4534) },
                    { 364, 28, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4535), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4536), "KEŞAP", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4536) },
                    { 365, 28, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4537), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4538), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4537) },
                    { 366, 28, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4538), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4539), "PİRAZİZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4539) },
                    { 367, 28, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4540), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4541), "ŞEBİNKARAHİSAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4540) },
                    { 368, 28, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4542), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4542), "TİREBOLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4542) },
                    { 369, 28, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4543), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4544), "YAĞLIDERE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4543) },
                    { 370, 29, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4545), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4545), "KELKİT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4545) },
                    { 371, 29, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4546), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4547), "KÖSE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4546) },
                    { 372, 29, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4548), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4548), "KÜRTÜN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4548) },
                    { 373, 29, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4549), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4550), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4550) },
                    { 374, 29, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4551), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4551), "ŞİRAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4551) },
                    { 375, 29, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4552), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4553), "TORUL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4553) },
                    { 376, 30, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4554), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4554), "ÇUKURCA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4554) },
                    { 377, 30, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4555), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4556), "DERECİK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4556) },
                    { 378, 30, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4557), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4558), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4557) },
                    { 379, 30, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4558), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4559), "ŞEMDİNLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4559) },
                    { 380, 30, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4560), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4561), "YÜKSEKOVA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4560) },
                    { 381, 31, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4561), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4562), "ALTINÖZÜ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4562) },
                    { 382, 31, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4563), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4564), "ANTAKYA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4563) },
                    { 383, 31, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4564), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4565), "ARSUZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4565) },
                    { 384, 31, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4566), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4567), "BELEN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4566) },
                    { 385, 31, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4567), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4568), "DEFNE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4568) },
                    { 386, 31, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4569), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4570), "DÖRTYOL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4569) },
                    { 387, 31, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4570), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4571), "ERZİN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4571) },
                    { 388, 31, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4572), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4573), "HASSA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4572) },
                    { 389, 31, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4574), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4575), "İSKENDERUN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4575) },
                    { 390, 31, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4576), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4577), "KIRIKHAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4576) },
                    { 391, 31, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4577), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4578), "KUMLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4578) },
                    { 392, 31, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4579), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4580), "PAYAS", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4579) },
                    { 393, 31, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4580), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4581), "REYHANLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4581) },
                    { 394, 31, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4582), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4583), "SAMANDAĞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4582) },
                    { 395, 31, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4583), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4584), "YAYLADAĞI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4584) },
                    { 396, 32, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4585), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4586), "AKSU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4585) },
                    { 397, 32, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4586), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4587), "ATABEY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4587) },
                    { 398, 32, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4588), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4589), "EĞİRDİR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4588) },
                    { 399, 32, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4589), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4590), "GELENDOST", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4590) },
                    { 400, 32, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4591), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4592), "GÖNEN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4591) },
                    { 401, 32, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4592), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4593), "KEÇİBORLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4593) },
                    { 402, 32, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4594), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4595), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4594) },
                    { 403, 32, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4595), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4596), "SENİRKENT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4596) },
                    { 404, 32, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4597), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4598), "SÜTÇÜLER", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4597) },
                    { 405, 32, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4598), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4599), "ŞARKİKARAAĞAÇ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4599) },
                    { 406, 32, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4600), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4601), "ULUBORLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4600) },
                    { 407, 32, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4601), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4602), "YALVAÇ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4602) },
                    { 408, 32, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4603), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4604), "YENİŞARBADEMLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4603) },
                    { 409, 33, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4604), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4605), "AKDENİZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4605) },
                    { 410, 33, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4606), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4607), "ANAMUR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4606) },
                    { 411, 33, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4607), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4608), "AYDINCIK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4608) },
                    { 412, 33, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4609), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4610), "BOZYAZI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4609) },
                    { 413, 33, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4611), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4611), "ÇAMLIYAYLA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4611) },
                    { 414, 33, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4612), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4613), "ERDEMLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4613) },
                    { 415, 33, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4614), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4614), "GÜLNAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4614) },
                    { 416, 33, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4615), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4616), "MEZİTLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4616) },
                    { 417, 33, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4617), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4617), "MUT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4617) },
                    { 418, 33, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4618), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4619), "SİLİFKE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4618) },
                    { 419, 33, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4620), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4620), "TARSUS", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4620) },
                    { 420, 33, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4622), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4623), "TOROSLAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4622) },
                    { 421, 33, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4623), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4624), "YENİŞEHİR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4624) },
                    { 422, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4625), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4626), "ADALAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4625) },
                    { 423, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4626), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4627), "ARNAVUTKÖY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4627) },
                    { 424, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4628), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4629), "ATAŞEHİR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4629) },
                    { 425, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4630), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4630), "AVCILAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4630) },
                    { 426, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4631), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4632), "BAĞCILAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4631) },
                    { 427, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4633), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4633), "BAHÇELİEVLER", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4633) },
                    { 428, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4634), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4635), "BAKIRKÖY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4635) },
                    { 429, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4636), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4636), "BAŞAKŞEHİR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4636) },
                    { 430, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4637), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4638), "BAYRAMPAŞA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4638) },
                    { 431, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4639), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4640), "BEŞİKTAŞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4639) },
                    { 432, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4640), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4641), "BEYKOZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4641) },
                    { 433, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4646), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4647), "BEYLİKDÜZÜ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4647) },
                    { 434, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4648), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4649), "BEYOĞLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4648) },
                    { 435, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4650), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4650), "BÜYÜKÇEKMECE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4650) },
                    { 436, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4651), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4652), "ÇATALCA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4652) },
                    { 437, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4653), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4653), "ÇEKMEKÖY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4653) },
                    { 438, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4654), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4655), "ESENLER", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4655) },
                    { 439, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4656), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4657), "ESENYURT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4656) },
                    { 440, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4657), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4658), "EYÜPSULTAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4658) },
                    { 441, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4659), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4660), "FATİH", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4659) },
                    { 442, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4660), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4661), "GAZİOSMANPAŞA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4661) },
                    { 443, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4662), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4663), "GÜNGÖREN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4662) },
                    { 444, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4663), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4664), "KADIKÖY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4664) },
                    { 445, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4665), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4666), "KAĞITHANE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4665) },
                    { 446, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4666), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4667), "KARTAL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4667) },
                    { 447, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4668), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4669), "KÜÇÜKÇEKMECE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4668) },
                    { 448, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4669), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4670), "MALTEPE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4670) },
                    { 449, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4671), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4672), "PENDİK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4671) },
                    { 450, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4673), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4674), "SANCAKTEPE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4674) },
                    { 451, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4675), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4676), "SARIYER", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4675) },
                    { 452, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4676), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4677), "SİLİVRİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4677) },
                    { 453, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4678), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4679), "SULTANBEYLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4678) },
                    { 454, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4679), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4680), "SULTANGAZİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4680) },
                    { 455, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4681), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4682), "ŞİLE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4681) },
                    { 456, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4682), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4683), "ŞİŞLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4683) },
                    { 457, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4684), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4685), "TUZLA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4684) },
                    { 458, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4685), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4686), "ÜMRANİYE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4686) },
                    { 459, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4687), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4688), "ÜSKÜDAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4687) },
                    { 460, 34, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4688), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4689), "ZEYTİNBURNU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4689) },
                    { 461, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4690), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4691), "ALİAĞA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4690) },
                    { 462, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4691), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4692), "BALÇOVA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4692) },
                    { 463, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4693), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4694), "BAYINDIR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4693) },
                    { 464, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4695), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4695), "BAYRAKLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4695) },
                    { 465, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4696), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4697), "BERGAMA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4696) },
                    { 466, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4698), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4698), "BEYDAĞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4698) },
                    { 467, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4699), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4700), "BORNOVA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4699) },
                    { 468, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4701), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4701), "BUCA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4701) },
                    { 469, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4702), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4703), "ÇEŞME", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4703) },
                    { 470, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4704), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4704), "ÇİĞLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4704) },
                    { 471, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4705), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4706), "DİKİLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4706) },
                    { 472, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4707), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4707), "FOÇA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4707) },
                    { 473, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4708), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4709), "GAZİEMİR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4708) },
                    { 474, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4710), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4710), "GÜZELBAHÇE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4710) },
                    { 475, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4711), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4712), "KARABAĞLAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4712) },
                    { 476, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4713), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4713), "KARABURUN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4713) },
                    { 477, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4714), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4715), "KARŞIYAKA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4715) },
                    { 478, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4716), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4716), "KEMALPAŞA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4716) },
                    { 479, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4718), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4719), "KINIK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4718) },
                    { 480, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4719), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4720), "KİRAZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4720) },
                    { 481, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4721), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4722), "KONAK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4721) },
                    { 482, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4722), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4723), "MENDERES", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4723) },
                    { 483, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4724), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4725), "MENEMEN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4724) },
                    { 484, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4725), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4726), "NARLIDERE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4726) },
                    { 485, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4727), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4728), "ÖDEMİŞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4727) },
                    { 486, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4728), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4729), "SEFERİHİSAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4729) },
                    { 487, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4730), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4731), "SELÇUK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4730) },
                    { 488, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4731), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4732), "TİRE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4732) },
                    { 489, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4733), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4734), "TORBALI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4733) },
                    { 490, 35, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4734), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4735), "URLA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4735) },
                    { 491, 36, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4736), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4737), "AKYAKA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4736) },
                    { 492, 36, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4737), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4738), "ARPAÇAY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4738) },
                    { 493, 36, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4739), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4740), "DİGOR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4739) },
                    { 494, 36, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4740), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4742), "KAĞIZMAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4741) },
                    { 495, 36, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4742), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4743), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4743) },
                    { 496, 36, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4744), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4745), "SARIKAMIŞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4744) },
                    { 497, 36, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4745), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4746), "SELİM", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4746) },
                    { 498, 36, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4747), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4748), "SUSUZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4747) },
                    { 499, 37, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4748), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4749), "ABANA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4749) },
                    { 500, 37, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4750), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4751), "AĞLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4750) },
                    { 501, 37, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4751), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4752), "ARAÇ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4752) },
                    { 502, 37, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4753), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4754), "AZDAVAY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4753) },
                    { 503, 37, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4754), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4755), "BOZKURT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4755) },
                    { 504, 37, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4756), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4757), "CİDE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4756) },
                    { 505, 37, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4757), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4758), "ÇATALZEYTİN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4758) },
                    { 506, 37, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4762), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4764), "DADAY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4763) },
                    { 507, 37, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4764), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4765), "DEVREKANİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4765) },
                    { 508, 37, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4766), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4767), "DOĞANYURT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4766) },
                    { 509, 37, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4767), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4768), "HANÖNÜ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4768) },
                    { 510, 37, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4769), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4770), "İHSANGAZİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4769) },
                    { 511, 37, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4770), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4771), "İNEBOLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4771) },
                    { 512, 37, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4772), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4773), "KÜRE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4773) },
                    { 513, 37, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4774), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4775), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4774) },
                    { 514, 37, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4775), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4776), "PINARBAŞI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4776) },
                    { 515, 37, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4777), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4778), "SEYDİLER", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4777) },
                    { 516, 37, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4778), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4779), "ŞENPAZAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4779) },
                    { 517, 37, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4780), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4781), "TAŞKÖPRÜ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4780) },
                    { 518, 37, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4781), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4782), "TOSYA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4782) },
                    { 519, 38, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4783), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4784), "AKKIŞLA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4783) },
                    { 520, 38, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4784), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4785), "BÜNYAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4785) },
                    { 521, 38, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4786), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4787), "DEVELİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4786) },
                    { 522, 38, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4787), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4788), "FELAHİYE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4788) },
                    { 523, 38, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4789), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4790), "HACILAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4789) },
                    { 524, 38, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4791), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4792), "İNCESU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4792) },
                    { 525, 38, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4793), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4793), "KOCASİNAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4793) },
                    { 526, 38, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4794), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4795), "MELİKGAZİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4794) },
                    { 527, 38, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4796), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4796), "ÖZVATAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4796) },
                    { 528, 38, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4797), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4798), "PINARBAŞI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4797) },
                    { 529, 38, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4799), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4799), "SARIOĞLAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4799) },
                    { 530, 38, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4800), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4801), "SARIZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4801) },
                    { 531, 38, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4802), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4802), "TALAS", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4802) },
                    { 532, 38, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4803), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4804), "TOMARZA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4804) },
                    { 533, 38, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4805), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4806), "YAHYALI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4806) },
                    { 534, 38, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4807), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4808), "YEŞİLHİSAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4807) },
                    { 535, 39, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4808), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4809), "BABAESKİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4809) },
                    { 536, 39, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4810), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4811), "DEMİRKÖY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4810) },
                    { 537, 39, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4811), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4812), "KOFÇAZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4812) },
                    { 538, 39, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4813), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4814), "LÜLEBURGAZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4813) },
                    { 539, 39, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4814), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4815), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4815) },
                    { 540, 39, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4816), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4817), "PEHLİVANKÖY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4816) },
                    { 541, 39, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4817), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4818), "PINARHİSAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4818) },
                    { 542, 39, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4819), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4820), "VİZE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4820) },
                    { 543, 40, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4821), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4822), "AKÇAKENT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4821) },
                    { 544, 40, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4822), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4823), "AKPINAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4823) },
                    { 545, 40, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4824), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4825), "BOZTEPE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4824) },
                    { 546, 40, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4826), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4826), "ÇİÇEKDAĞI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4826) },
                    { 547, 40, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4827), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4828), "KAMAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4827) },
                    { 548, 40, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4829), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4829), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4829) },
                    { 549, 40, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4830), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4831), "MUCUR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4830) },
                    { 550, 41, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4832), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4832), "BAŞİSKELE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4832) },
                    { 551, 41, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4833), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4834), "ÇAYIROVA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4833) },
                    { 552, 41, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4835), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4835), "DARICA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4835) },
                    { 553, 41, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4836), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4837), "DERİNCE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4836) },
                    { 554, 41, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4838), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4838), "DİLOVASI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4838) },
                    { 555, 41, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4839), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4840), "GEBZE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4839) },
                    { 556, 41, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4841), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4841), "GÖLCÜK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4841) },
                    { 557, 41, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4842), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4843), "İZMİT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4842) },
                    { 558, 41, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4844), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4844), "KANDIRA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4844) },
                    { 559, 41, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4845), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4846), "KARAMÜRSEL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4845) },
                    { 560, 41, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4846), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4847), "KARTEPE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4847) },
                    { 561, 41, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4848), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4849), "KÖRFEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4848) },
                    { 562, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4849), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4850), "AHIRLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4850) },
                    { 563, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4851), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4852), "AKÖREN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4851) },
                    { 564, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4852), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4853), "AKŞEHİR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4853) },
                    { 565, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4854), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4855), "ALTINEKİN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4854) },
                    { 566, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4855), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4856), "BEYŞEHİR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4856) },
                    { 567, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4857), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4858), "BOZKIR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4857) },
                    { 568, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4858), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4859), "CİHANBEYLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4859) },
                    { 569, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4860), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4861), "ÇELTİK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4860) },
                    { 570, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4861), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4862), "ÇUMRA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4862) },
                    { 571, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4863), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4864), "DERBENT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4863) },
                    { 572, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4864), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4865), "DEREBUCAK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4865) },
                    { 573, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4867), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4868), "DOĞANHİSAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4867) },
                    { 574, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4868), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4869), "EMİRGAZİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4869) },
                    { 575, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4870), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4871), "EREĞLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4870) },
                    { 576, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4871), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4872), "GÜNEYSINIR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4872) },
                    { 577, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4873), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4874), "HADİM", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4873) },
                    { 578, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4874), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4875), "HALKAPINAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4875) },
                    { 579, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4879), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4881), "HÜYÜK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4880) },
                    { 580, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4881), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4882), "ILGIN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4882) },
                    { 581, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4883), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4884), "KADINHANI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4883) },
                    { 582, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4884), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4885), "KARAPINAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4885) },
                    { 583, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4886), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4887), "KARATAY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4886) },
                    { 584, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4888), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4888), "KULU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4888) },
                    { 585, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4889), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4890), "MERAM", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4889) },
                    { 586, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4890), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4891), "SARAYÖNÜ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4891) },
                    { 587, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4892), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4893), "SELÇUKLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4892) },
                    { 588, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4893), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4894), "SEYDİŞEHİR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4894) },
                    { 589, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4895), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4896), "TAŞKENT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4895) },
                    { 590, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4896), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4897), "TUZLUKÇU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4897) },
                    { 591, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4898), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4899), "YALIHÜYÜK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4898) },
                    { 592, 42, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4900), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4900), "YUNAK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4900) },
                    { 593, 43, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4901), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4902), "ALTINTAŞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4901) },
                    { 594, 43, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4903), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4903), "ASLANAPA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4903) },
                    { 595, 43, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4904), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4905), "ÇAVDARHİSAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4904) },
                    { 596, 43, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4906), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4906), "DOMANİÇ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4906) },
                    { 597, 43, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4907), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4908), "DUMLUPINAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4907) },
                    { 598, 43, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4909), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4909), "EMET", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4909) },
                    { 599, 43, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4910), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4911), "GEDİZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4911) },
                    { 600, 43, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4912), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4912), "HİSARCIK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4912) },
                    { 601, 43, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4913), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4914), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4914) },
                    { 602, 43, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4915), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4915), "PAZARLAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4915) },
                    { 603, 43, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4917), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4918), "SİMAV", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4917) },
                    { 604, 43, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4918), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4919), "ŞAPHANE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4919) },
                    { 605, 43, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4920), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4921), "TAVŞANLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4920) },
                    { 606, 44, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4921), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4922), "AKÇADAĞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4922) },
                    { 607, 44, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4923), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4924), "ARAPGİR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4923) },
                    { 608, 44, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4924), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4925), "ARGUVAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4925) },
                    { 609, 44, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4926), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4927), "BATTALGAZİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4926) },
                    { 610, 44, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4927), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4928), "DARENDE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4928) },
                    { 611, 44, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4929), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4930), "DOĞANŞEHİR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4929) },
                    { 612, 44, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4930), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4931), "DOĞANYOL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4931) },
                    { 613, 44, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4932), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4933), "HEKİMHAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4932) },
                    { 614, 44, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4933), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4934), "KALE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4934) },
                    { 615, 44, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4935), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4936), "KULUNCAK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4935) },
                    { 616, 44, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4936), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4937), "PÜTÜRGE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4937) },
                    { 617, 44, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4938), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4939), "YAZIHAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4938) },
                    { 618, 44, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4939), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4940), "YEŞİLYURT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4940) },
                    { 619, 45, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4941), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4942), "AHMETLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4941) },
                    { 620, 45, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4942), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4943), "AKHİSAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4943) },
                    { 621, 45, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4944), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4945), "ALAŞEHİR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4944) },
                    { 622, 45, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4946), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4946), "DEMİRCİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4946) },
                    { 623, 45, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4947), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4948), "GÖLMARMARA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4948) },
                    { 624, 45, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4949), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4949), "GÖRDES", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4949) },
                    { 625, 45, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4950), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4951), "KIRKAĞAÇ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4951) },
                    { 626, 45, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4952), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4952), "KÖPRÜBAŞI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4952) },
                    { 627, 45, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4953), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4954), "KULA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4954) },
                    { 628, 45, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4955), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4956), "SALİHLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4955) },
                    { 629, 45, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4956), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4957), "SARIGÖL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4957) },
                    { 630, 45, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4958), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4959), "SARUHANLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4958) },
                    { 631, 45, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4959), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4960), "SELENDİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4960) },
                    { 632, 45, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4961), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4962), "SOMA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4961) },
                    { 633, 45, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4962), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4963), "ŞEHZADELER", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4963) },
                    { 634, 45, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4964), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4965), "TURGUTLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4965) },
                    { 635, 45, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4966), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4967), "YUNUSEMRE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4966) },
                    { 636, 46, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4967), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4968), "AFŞİN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4968) },
                    { 637, 46, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4969), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4970), "ANDIRIN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4969) },
                    { 638, 46, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4970), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4971), "ÇAĞLAYANCERİT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4971) },
                    { 639, 46, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4972), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4973), "DULKADİROĞLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4972) },
                    { 640, 46, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4973), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4974), "EKİNÖZÜ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4974) },
                    { 641, 46, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4975), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4976), "ELBİSTAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4975) },
                    { 642, 46, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4976), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4977), "GÖKSUN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4977) },
                    { 643, 46, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4978), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4979), "NURHAK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4978) },
                    { 644, 46, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4979), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4980), "ONİKİŞUBAT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4980) },
                    { 645, 46, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4981), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4982), "PAZARCIK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4981) },
                    { 646, 46, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4982), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4983), "TÜRKOĞLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4983) },
                    { 647, 47, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4984), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4985), "ARTUKLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4984) },
                    { 648, 47, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4985), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4986), "DARGEÇİT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4986) },
                    { 649, 47, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4987), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4988), "DERİK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4987) },
                    { 650, 47, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4988), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4989), "KIZILTEPE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4989) },
                    { 651, 47, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4990), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4991), "MAZIDAĞI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4990) },
                    { 652, 47, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4996), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4997), "MİDYAT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4996) },
                    { 653, 47, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4998), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4998), "NUSAYBİN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4998) },
                    { 654, 47, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(4999), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5000), "ÖMERLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5000) },
                    { 655, 47, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5001), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5001), "SAVUR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5001) },
                    { 656, 47, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5002), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5003), "YEŞİLLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5002) },
                    { 657, 48, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5004), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5004), "BODRUM", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5004) },
                    { 658, 48, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5005), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5006), "DALAMAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5005) },
                    { 659, 48, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5007), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5007), "DATÇA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5007) },
                    { 660, 48, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5008), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5009), "FETHİYE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5009) },
                    { 661, 48, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5010), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5010), "KAVAKLIDERE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5010) },
                    { 662, 48, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5011), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5012), "KÖYCEĞİZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5012) },
                    { 663, 48, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5013), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5013), "MARMARİS", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5013) },
                    { 664, 48, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5018), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5019), "MENTEŞE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5018) },
                    { 665, 48, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5019), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5020), "MİLAS", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5020) },
                    { 666, 48, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5021), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5022), "ORTACA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5021) },
                    { 667, 48, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5022), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5023), "SEYDİKEMER", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5023) },
                    { 668, 48, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5024), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5025), "ULA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5024) },
                    { 669, 48, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5025), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5026), "YATAĞAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5026) },
                    { 670, 49, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5027), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5028), "BULANIK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5027) },
                    { 671, 49, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5028), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5029), "HASKÖY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5029) },
                    { 672, 49, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5030), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5031), "KORKUT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5030) },
                    { 673, 49, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5031), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5032), "MALAZGİRT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5032) },
                    { 674, 49, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5033), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5034), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5033) },
                    { 675, 49, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5035), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5036), "VARTO", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5035) },
                    { 676, 50, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5036), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5037), "ACIGÖL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5037) },
                    { 677, 50, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5038), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5039), "AVANOS", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5038) },
                    { 678, 50, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5039), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5040), "DERİNKUYU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5040) },
                    { 679, 50, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5041), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5042), "GÜLŞEHİR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5041) },
                    { 680, 50, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5042), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5043), "HACIBEKTAŞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5043) },
                    { 681, 50, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5044), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5045), "KOZAKLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5044) },
                    { 682, 50, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5045), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5046), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5046) },
                    { 683, 50, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5047), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5048), "ÜRGÜP", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5047) },
                    { 684, 51, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5048), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5049), "ALTUNHİSAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5049) },
                    { 685, 51, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5050), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5051), "BOR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5050) },
                    { 686, 51, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5051), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5052), "ÇAMARDI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5052) },
                    { 687, 51, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5053), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5054), "ÇİFTLİK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5053) },
                    { 688, 51, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5054), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5055), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5055) },
                    { 689, 51, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5056), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5057), "ULUKIŞLA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5056) },
                    { 690, 52, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5057), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5058), "AKKUŞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5058) },
                    { 691, 52, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5059), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5060), "ALTINORDU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5059) },
                    { 692, 52, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5060), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5061), "AYBASTI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5061) },
                    { 693, 52, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5062), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5063), "ÇAMAŞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5062) },
                    { 694, 52, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5063), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5064), "ÇATALPINAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5064) },
                    { 695, 52, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5066), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5067), "ÇAYBAŞI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5066) },
                    { 696, 52, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5067), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5068), "FATSA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5068) },
                    { 697, 52, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5069), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5070), "GÖLKÖY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5069) },
                    { 698, 52, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5070), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5071), "GÜLYALI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5071) },
                    { 699, 52, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5072), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5073), "GÜRGENTEPE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5072) },
                    { 700, 52, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5073), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5074), "İKİZCE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5074) },
                    { 701, 52, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5075), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5076), "KABADÜZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5075) },
                    { 702, 52, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5076), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5077), "KABATAŞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5077) },
                    { 703, 52, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5078), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5079), "KORGAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5078) },
                    { 704, 52, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5079), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5080), "KUMRU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5080) },
                    { 705, 52, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5081), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5082), "MESUDİYE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5081) },
                    { 706, 52, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5083), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5083), "PERŞEMBE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5083) },
                    { 707, 52, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5084), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5085), "ULUBEY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5084) },
                    { 708, 52, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5086), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5086), "ÜNYE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5086) },
                    { 709, 53, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5087), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5088), "ARDEŞEN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5088) },
                    { 710, 53, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5089), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5089), "ÇAMLIHEMŞİN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5089) },
                    { 711, 53, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5090), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5091), "ÇAYELİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5091) },
                    { 712, 53, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5092), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5093), "DEREPAZARI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5092) },
                    { 713, 53, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5093), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5094), "FINDIKLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5094) },
                    { 714, 53, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5095), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5096), "GÜNEYSU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5095) },
                    { 715, 53, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5096), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5097), "HEMŞİN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5097) },
                    { 716, 53, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5098), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5099), "İKİZDERE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5098) },
                    { 717, 53, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5099), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5100), "İYİDERE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5100) },
                    { 718, 53, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5101), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5102), "KALKANDERE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5101) },
                    { 719, 53, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5102), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5103), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5103) },
                    { 720, 53, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5104), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5105), "PAZAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5104) },
                    { 721, 54, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5105), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5106), "ADAPAZARI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5106) },
                    { 722, 54, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5107), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5108), "AKYAZI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5107) },
                    { 723, 54, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5108), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5109), "ARİFİYE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5109) },
                    { 724, 54, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5110), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5111), "ERENLER", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5110) },
                    { 725, 54, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5115), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5117), "FERİZLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5116) },
                    { 726, 54, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5118), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5119), "GEYVE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5119) },
                    { 727, 54, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5120), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5120), "HENDEK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5120) },
                    { 728, 54, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5121), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5122), "KARAPÜRÇEK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5122) },
                    { 729, 54, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5123), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5123), "KARASU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5123) },
                    { 730, 54, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5124), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5125), "KAYNARCA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5125) },
                    { 731, 54, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5126), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5126), "KOCAALİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5126) },
                    { 732, 54, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5127), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5128), "PAMUKOVA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5128) },
                    { 733, 54, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5129), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5129), "SAPANCA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5129) },
                    { 734, 54, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5130), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5131), "SERDİVAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5130) },
                    { 735, 54, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5132), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5132), "SÖĞÜTLÜ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5132) },
                    { 736, 54, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5133), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5134), "TARAKLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5134) },
                    { 737, 55, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5135), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5135), "ALAÇAM", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5135) },
                    { 738, 55, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5136), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5137), "ASARCIK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5136) },
                    { 739, 55, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5138), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5138), "ATAKUM", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5138) },
                    { 740, 55, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5139), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5140), "AYVACIK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5140) },
                    { 741, 55, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5141), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5141), "BAFRA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5141) },
                    { 742, 55, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5142), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5143), "CANİK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5143) },
                    { 743, 55, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5144), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5144), "ÇARŞAMBA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5144) },
                    { 744, 55, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5145), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5146), "HAVZA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5146) },
                    { 745, 55, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5147), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5147), "İLKADIM", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5147) },
                    { 746, 55, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5148), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5149), "KAVAK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5149) },
                    { 747, 55, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5150), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5150), "LADİK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5150) },
                    { 748, 55, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5151), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5152), "SALIPAZARI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5152) },
                    { 749, 55, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5153), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5153), "TEKKEKÖY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5153) },
                    { 750, 55, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5154), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5155), "TERME", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5155) },
                    { 751, 55, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5156), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5156), "VEZİRKÖPRÜ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5156) },
                    { 752, 55, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5157), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5158), "YAKAKENT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5157) },
                    { 753, 55, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5159), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5159), "19 MAYIS", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5159) },
                    { 754, 56, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5160), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5161), "BAYKAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5161) },
                    { 755, 56, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5162), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5162), "ERUH", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5162) },
                    { 756, 56, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5163), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5164), "KURTALAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5163) },
                    { 757, 56, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5165), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5166), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5166) },
                    { 758, 56, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5167), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5168), "PERVARİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5167) },
                    { 759, 56, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5168), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5169), "ŞİRVAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5169) },
                    { 760, 56, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5170), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5171), "TİLLO", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5170) },
                    { 761, 57, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5171), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5172), "AYANCIK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5172) },
                    { 762, 57, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5173), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5174), "BOYABAT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5173) },
                    { 763, 57, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5174), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5175), "DİKMEN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5175) },
                    { 764, 57, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5176), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5177), "DURAĞAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5176) },
                    { 765, 57, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5177), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5178), "ERFELEK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5178) },
                    { 766, 57, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5179), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5180), "GERZE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5179) },
                    { 767, 57, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5180), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5181), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5181) },
                    { 768, 57, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5182), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5182), "SARAYDÜZÜ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5182) },
                    { 769, 57, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5183), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5184), "TÜRKELİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5183) },
                    { 770, 58, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5185), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5185), "AKINCILAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5185) },
                    { 771, 58, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5186), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5187), "ALTINYAYLA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5186) },
                    { 772, 58, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5187), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5188), "DİVRİĞİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5188) },
                    { 773, 58, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5189), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5190), "DOĞANŞAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5189) },
                    { 774, 58, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5191), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5191), "GEMEREK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5191) },
                    { 775, 58, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5192), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5193), "GÖLOVA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5192) },
                    { 776, 58, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5193), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5194), "GÜRÜN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5194) },
                    { 777, 58, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5195), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5196), "HAFİK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5195) },
                    { 778, 58, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5196), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5197), "İMRANLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5197) },
                    { 779, 58, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5198), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5199), "KANGAL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5198) },
                    { 780, 58, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5199), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5200), "KOYULHİSAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5200) },
                    { 781, 58, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5201), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5202), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5201) },
                    { 782, 58, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5202), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5203), "SUŞEHRİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5203) },
                    { 783, 58, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5204), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5205), "ŞARKIŞLA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5204) },
                    { 784, 58, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5205), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5206), "ULAŞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5206) },
                    { 785, 58, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5207), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5208), "YILDIZELİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5207) },
                    { 786, 58, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5208), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5209), "ZARA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5209) },
                    { 787, 59, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5214), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5214), "ÇERKEZKÖY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5214) },
                    { 788, 59, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5215), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5216), "ÇORLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5215) },
                    { 789, 59, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5217), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5217), "ERGENE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5217) },
                    { 790, 59, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5218), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5219), "HAYRABOLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5218) },
                    { 791, 59, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5220), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5220), "KAPAKLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5220) },
                    { 792, 59, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5221), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5222), "MALKARA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5221) },
                    { 793, 59, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5222), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5223), "MARMARAEREĞLİSİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5223) },
                    { 794, 59, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5224), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5225), "MURATLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5224) },
                    { 795, 59, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5225), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5226), "SARAY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5226) },
                    { 796, 59, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5227), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5228), "SÜLEYMANPAŞA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5227) },
                    { 797, 59, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5228), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5229), "ŞARKÖY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5229) },
                    { 798, 60, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5233), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5235), "ALMUS", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5235) },
                    { 799, 60, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5236), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5236), "ARTOVA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5236) },
                    { 800, 60, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5237), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5238), "BAŞÇİFTLİK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5237) },
                    { 801, 60, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5239), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5239), "ERBAA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5239) },
                    { 802, 60, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5240), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5241), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5241) },
                    { 803, 60, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5242), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5243), "NİKSAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5242) },
                    { 804, 60, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5243), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5244), "PAZAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5244) },
                    { 805, 60, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5245), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5245), "REŞADİYE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5245) },
                    { 806, 60, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5246), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5247), "SULUSARAY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5247) },
                    { 807, 60, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5248), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5248), "TURHAL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5248) },
                    { 808, 60, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5249), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5250), "YEŞİLYURT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5250) },
                    { 809, 60, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5251), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5251), "ZİLE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5251) },
                    { 810, 61, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5252), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5253), "AKÇAABAT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5253) },
                    { 811, 61, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5254), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5254), "ARAKLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5254) },
                    { 812, 61, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5255), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5256), "ARSİN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5256) },
                    { 813, 61, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5257), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5257), "BEŞİKDÜZÜ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5257) },
                    { 814, 61, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5258), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5259), "ÇARŞIBAŞI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5258) },
                    { 815, 61, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5260), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5260), "ÇAYKARA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5260) },
                    { 816, 61, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5261), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5262), "DERNEKPAZARI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5262) },
                    { 817, 61, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5263), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5263), "DÜZKÖY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5263) },
                    { 818, 61, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5265), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5266), "HAYRAT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5265) },
                    { 819, 61, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5266), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5267), "KÖPRÜBAŞI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5267) },
                    { 820, 61, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5268), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5269), "MAÇKA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5268) },
                    { 821, 61, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5269), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5270), "OF", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5270) },
                    { 822, 61, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5271), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5272), "ORTAHİSAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5271) },
                    { 823, 61, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5272), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5273), "SÜRMENE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5273) },
                    { 824, 61, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5274), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5275), "ŞALPAZARI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5274) },
                    { 825, 61, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5275), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5276), "TONYA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5276) },
                    { 826, 61, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5277), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5278), "VAKFIKEBİR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5277) },
                    { 827, 61, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5278), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5279), "YOMRA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5279) },
                    { 828, 62, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5280), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5281), "ÇEMİŞGEZEK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5280) },
                    { 829, 62, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5281), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5282), "HOZAT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5282) },
                    { 830, 62, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5283), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5284), "MAZGİRT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5283) },
                    { 831, 62, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5284), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5285), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5285) },
                    { 832, 62, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5286), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5287), "NAZIMİYE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5286) },
                    { 833, 62, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5287), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5288), "OVACIK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5288) },
                    { 834, 62, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5289), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5290), "PERTEK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5289) },
                    { 835, 62, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5290), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5291), "PÜLÜMÜR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5291) },
                    { 836, 63, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5292), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5293), "AKÇAKALE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5292) },
                    { 837, 63, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5293), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5294), "BİRECİK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5294) },
                    { 838, 63, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5295), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5296), "BOZOVA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5295) },
                    { 839, 63, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5296), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5297), "CEYLANPINAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5297) },
                    { 840, 63, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5298), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5299), "EYYÜBİYE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5298) },
                    { 841, 63, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5299), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5300), "HALFETİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5300) },
                    { 842, 63, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5301), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5302), "HALİLİYE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5301) },
                    { 843, 63, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5302), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5303), "HARRAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5303) },
                    { 844, 63, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5304), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5305), "HİLVAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5304) },
                    { 845, 63, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5305), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5306), "KARAKÖPRÜ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5306) },
                    { 846, 63, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5307), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5308), "SİVEREK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5307) },
                    { 847, 63, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5308), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5309), "SURUÇ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5309) },
                    { 848, 63, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5310), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5311), "VİRANŞEHİR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5310) },
                    { 849, 64, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5312), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5313), "BANAZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5313) },
                    { 850, 64, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5314), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5314), "EŞME", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5314) },
                    { 851, 64, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5315), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5316), "KARAHALLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5316) },
                    { 852, 64, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5317), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5317), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5317) },
                    { 853, 64, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5318), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5319), "SİVASLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5319) },
                    { 854, 64, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5320), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5320), "ULUBEY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5320) },
                    { 855, 65, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5321), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5322), "BAHÇESARAY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5322) },
                    { 856, 65, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5323), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5323), "BAŞKALE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5323) },
                    { 857, 65, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5324), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5325), "ÇALDIRAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5325) },
                    { 858, 65, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5326), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5327), "ÇATAK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5326) },
                    { 859, 65, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5327), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5328), "EDREMİT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5328) },
                    { 860, 65, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5329), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5330), "ERCİŞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5329) },
                    { 861, 65, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5330), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5331), "GEVAŞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5331) },
                    { 862, 65, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5332), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5332), "GÜRPINAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5332) },
                    { 863, 65, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5333), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5334), "İPEKYOLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5334) },
                    { 864, 65, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5335), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5335), "MURADİYE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5335) },
                    { 865, 65, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5336), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5337), "ÖZALP", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5337) },
                    { 866, 65, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5338), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5338), "SARAY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5338) },
                    { 867, 65, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5339), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5340), "TUŞBA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5339) },
                    { 868, 66, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5341), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5341), "AKDAĞMADENİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5341) },
                    { 869, 66, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5342), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5343), "AYDINCIK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5342) },
                    { 870, 66, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5344), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5344), "BOĞAZLIYAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5344) },
                    { 871, 66, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5349), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5350), "ÇANDIR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5350) },
                    { 872, 66, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5351), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5352), "ÇAYIRALAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5351) },
                    { 873, 66, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5352), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5353), "ÇEKEREK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5353) },
                    { 874, 66, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5354), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5355), "KADIŞEHRİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5354) },
                    { 875, 66, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5355), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5356), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5356) },
                    { 876, 66, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5357), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5358), "SARAYKENT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5357) },
                    { 877, 66, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5358), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5359), "SARIKAYA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5359) },
                    { 878, 66, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5360), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5361), "SORGUN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5360) },
                    { 879, 66, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5361), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5362), "ŞEFAATLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5362) },
                    { 880, 66, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5363), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5364), "YENİFAKILI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5364) },
                    { 881, 66, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5365), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5366), "YERKÖY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5365) },
                    { 882, 67, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5366), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5367), "ALAPLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5367) },
                    { 883, 67, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5368), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5369), "ÇAYCUMA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5368) },
                    { 884, 67, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5369), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5370), "DEVREK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5370) },
                    { 885, 67, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5371), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5372), "EREĞLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5371) },
                    { 886, 67, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5372), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5373), "GÖKÇEBEY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5373) },
                    { 887, 67, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5374), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5375), "KİLİMLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5374) },
                    { 888, 67, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5375), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5376), "KOZLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5376) },
                    { 889, 67, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5377), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5378), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5377) },
                    { 890, 68, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5379), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5379), "AĞAÇÖREN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5379) },
                    { 891, 68, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5380), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5381), "ESKİL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5380) },
                    { 892, 68, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5382), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5382), "GÜLAĞAÇ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5382) },
                    { 893, 68, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5383), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5384), "GÜZELYURT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5383) },
                    { 894, 68, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5385), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5385), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5385) },
                    { 895, 68, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5386), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5387), "ORTAKÖY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5386) },
                    { 896, 68, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5387), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5388), "SARIYAHŞİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5388) },
                    { 897, 68, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5389), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5390), "SULTANHANI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5389) },
                    { 898, 69, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5391), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5391), "AYDINTEPE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5391) },
                    { 899, 69, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5392), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5393), "DEMİRÖZÜ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5392) },
                    { 900, 69, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5394), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5394), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5394) },
                    { 901, 70, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5395), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5396), "AYRANCI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5395) },
                    { 902, 70, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5397), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5397), "BAŞYAYLA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5397) },
                    { 903, 70, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5398), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5399), "ERMENEK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5398) },
                    { 904, 70, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5400), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5400), "KAZIMKARABEKİR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5400) },
                    { 905, 70, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5401), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5402), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5402) },
                    { 906, 70, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5403), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5403), "SARIVELİLER", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5403) },
                    { 907, 71, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5404), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5405), "BAHŞİLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5405) },
                    { 908, 71, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5406), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5406), "BALIŞEYH", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5406) },
                    { 909, 71, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5407), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5408), "ÇELEBİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5408) },
                    { 910, 71, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5409), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5409), "DELİCE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5409) },
                    { 911, 71, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5411), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5412), "KARAKEÇİLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5411) },
                    { 912, 71, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5412), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5413), "KESKİN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5413) },
                    { 913, 71, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5414), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5415), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5414) },
                    { 914, 71, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5415), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5416), "SULAKYURT", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5416) },
                    { 915, 71, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5417), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5418), "YAHŞİHAN", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5417) },
                    { 916, 72, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5418), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5419), "BEŞİRİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5419) },
                    { 917, 72, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5420), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5421), "GERCÜŞ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5420) },
                    { 918, 72, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5421), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5422), "HASANKEYF", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5422) },
                    { 919, 72, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5423), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5424), "KOZLUK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5423) },
                    { 920, 72, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5424), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5425), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5425) },
                    { 921, 72, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5426), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5427), "SASON", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5426) },
                    { 922, 73, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5427), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5428), "BEYTÜŞŞEBAP", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5428) },
                    { 923, 73, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5429), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5430), "CİZRE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5429) },
                    { 924, 73, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5430), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5431), "GÜÇLÜKONAK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5431) },
                    { 925, 73, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5432), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5433), "İDİL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5432) },
                    { 926, 73, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5433), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5434), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5434) },
                    { 927, 73, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5435), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5436), "SİLOPİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5435) },
                    { 928, 73, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5436), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5437), "ULUDERE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5437) },
                    { 929, 74, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5438), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5439), "AMASRA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5438) },
                    { 930, 74, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5439), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5440), "KURUCAŞİLE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5440) },
                    { 931, 74, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5441), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5442), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5441) },
                    { 932, 74, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5442), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5443), "ULUS", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5443) },
                    { 933, 75, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5444), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5445), "ÇILDIR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5444) },
                    { 934, 75, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5445), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5446), "DAMAL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5446) },
                    { 935, 75, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5447), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5448), "GÖLE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5447) },
                    { 936, 75, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5449), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5449), "HANAK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5449) },
                    { 937, 75, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5450), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5451), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5450) },
                    { 938, 75, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5451), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5452), "POSOF", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5452) },
                    { 939, 76, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5453), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5454), "ARALIK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5453) },
                    { 940, 76, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5454), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5455), "KARAKOYUNLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5455) },
                    { 941, 76, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5457), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5457), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5457) },
                    { 942, 76, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5458), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5459), "TUZLUCA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5458) },
                    { 943, 77, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5463), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5465), "ALTINOVA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5464) },
                    { 944, 77, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5465), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5466), "ARMUTLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5466) },
                    { 945, 77, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5467), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5468), "ÇINARCIK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5467) },
                    { 946, 77, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5468), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5469), "ÇİFTLİKKÖY", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5469) },
                    { 947, 77, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5470), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5471), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5470) },
                    { 948, 77, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5471), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5472), "TERMAL", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5472) },
                    { 949, 78, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5473), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5474), "EFLANİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5473) },
                    { 950, 78, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5474), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5475), "ESKİPAZAR", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5475) },
                    { 951, 78, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5476), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5476), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5476) },
                    { 952, 78, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5477), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5478), "OVACIK", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5478) },
                    { 953, 78, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5479), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5479), "SAFRANBOLU", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5479) },
                    { 954, 78, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5480), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5481), "YENİCE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5480) },
                    { 955, 79, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5482), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5482), "ELBEYLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5482) },
                    { 956, 79, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5483), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5484), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5483) },
                    { 957, 79, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5485), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5485), "MUSABEYLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5485) },
                    { 958, 79, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5486), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5487), "POLATELİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5486) },
                    { 959, 80, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5487), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5488), "BAHÇE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5488) },
                    { 960, 80, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5489), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5490), "DÜZİÇİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5489) },
                    { 961, 80, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5490), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5491), "HASANBEYLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5491) },
                    { 962, 80, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5492), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5493), "KADİRLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5492) },
                    { 963, 80, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5493), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5494), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5494) },
                    { 964, 80, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5495), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5496), "SUMBAS", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5495) },
                    { 965, 80, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5496), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5497), "TOPRAKKALE", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5497) },
                    { 966, 81, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5498), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5499), "AKÇAKOCA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5498) },
                    { 967, 81, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5499), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5500), "CUMAYERİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5500) },
                    { 968, 81, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5501), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5502), "ÇİLİMLİ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5501) },
                    { 969, 81, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5502), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5503), "GÖLYAKA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5503) },
                    { 970, 81, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5504), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5505), "GÜMÜŞOVA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5504) },
                    { 971, 81, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5505), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5506), "KAYNAŞLI", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5506) },
                    { 972, 81, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5507), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5508), "MERKEZ", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5507) },
                    { 973, 81, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5508), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5509), "YIĞILCA", false, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(5509) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CityID", "CreatedDate", "DeletedDate", "DistrictID", "Mail", "Name", "Password", "RoleID", "Status", "Surname", "UpdatedDate", "UserName" },
                values: new object[] { 1, 1, new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(6108), new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(6106), 1, "", "Büşra", "12345", 1, false, "Güneş", new DateTime(2025, 9, 3, 14, 37, 7, 349, DateTimeKind.Local).AddTicks(6105), "busra" });

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
                name: "IX_Users_CityID",
                table: "Users",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DistrictID",
                table: "Users",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleID",
                table: "Users",
                column: "RoleID");
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
                name: "Defendants");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "CaseFiles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "ApplicationTypes");

            migrationBuilder.DropTable(
                name: "CaseTypes");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
