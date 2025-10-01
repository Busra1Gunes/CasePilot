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
                name: "Courts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    DistrictID = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CourtType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Courts_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Courts_Districts_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "Districts",
                        principalColumn: "ID");
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
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ResetToken = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ResetTokenExpiry = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false),
                    LockedUntil = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FailedLoginAttempts = table.Column<int>(type: "int", nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    EmailConfirmationToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "CaseFiles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationTypeID = table.Column<int>(type: "int", nullable: false),
                    CaseTypeID = table.Column<int>(type: "int", nullable: false),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    DistrictID = table.Column<int>(type: "int", nullable: false),
                    CourtID = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_CaseFiles_Courts_CourtID",
                        column: x => x.CourtID,
                        principalTable: "Courts",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CaseFiles_Districts_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "Districts",
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
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
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
                name: "CaseFileNotes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseFileID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseFileNotes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CaseFileNotes_CaseFiles_CaseFileID",
                        column: x => x.CaseFileID,
                        principalTable: "CaseFiles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseFileNotes_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Hearings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseFileID = table.Column<int>(type: "int", nullable: false),
                    CourtID = table.Column<int>(type: "int", nullable: false),
                    HearingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HearingTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    Judge = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Clerk = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Result = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    HearingStatus = table.Column<int>(type: "int", nullable: false),
                    NextHearingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hearings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Hearings_CaseFiles_CaseFileID",
                        column: x => x.CaseFileID,
                        principalTable: "CaseFiles",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Hearings_Courts_CourtID",
                        column: x => x.CourtID,
                        principalTable: "Courts",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "ApplicationTypes",
                columns: new[] { "ID", "CaseTypeID", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6216), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6216), "Araç Hasarı", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6216) },
                    { 2, 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6218), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6219), "Manevi", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6219) },
                    { 3, 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6220), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6221), "İdari Dava", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6220) },
                    { 4, 4, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6221), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6222), "Kamulaştırma", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6222) }
                });

            migrationBuilder.InsertData(
                table: "CaseTypes",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6351), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6352), "Trafik Kazası", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6351) },
                    { 2, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6353), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6354), "Arabuluculuk", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6354) },
                    { 3, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6355), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6355), "İdari Dava", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6355) },
                    { 4, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6356), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6357), "Kamulaştırma", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6356) }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6436), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6437), "Adana", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6436) },
                    { 2, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6438), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6439), "Adıyaman", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6439) },
                    { 3, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6440), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6441), "Afyonkarahisar", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6440) },
                    { 4, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6441), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6442), "Ağrı", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6442) },
                    { 5, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6443), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6444), "Amasya", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6443) },
                    { 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6444), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6445), "Ankara", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6444) },
                    { 7, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6445), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6446), "Antalya", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6446) },
                    { 8, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6447), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6447), "Artvin", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6447) },
                    { 9, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6448), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6449), "Aydın", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6448) },
                    { 10, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6449), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6450), "Balıkesir", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6450) },
                    { 11, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6450), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6451), "Bilecik", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6451) },
                    { 12, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6452), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6452), "Bingöl", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6452) },
                    { 13, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6453), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6454), "Bitlis", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6453) },
                    { 14, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6454), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6455), "Bolu", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6455) },
                    { 15, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6455), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6456), "Burdur", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6456) },
                    { 16, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6457), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6458), "Bursa", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6457) },
                    { 17, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6458), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6459), "Çanakkale", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6459) },
                    { 18, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6459), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6460), "Çankırı", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6460) },
                    { 19, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6461), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6461), "Çorum", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6461) },
                    { 20, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6462), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6463), "Denizli", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6462) },
                    { 21, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6463), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6464), "Diyarbakır", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6464) },
                    { 22, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6465), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6465), "Edirne", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6465) },
                    { 23, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6466), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6467), "Elazığ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6466) },
                    { 24, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6467), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6468), "Erzincan", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6467) },
                    { 25, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6468), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6469), "Erzurum", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6469) },
                    { 26, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6470), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6470), "Eskişehir", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6470) },
                    { 27, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6471), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6472), "Gaziantep", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6471) },
                    { 28, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6472), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6473), "Giresun", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6473) },
                    { 29, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6473), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6474), "Gümüşhane", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6474) },
                    { 30, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6475), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6476), "Hakkari", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6475) },
                    { 31, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6476), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6477), "Hatay", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6476) },
                    { 32, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6477), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6478), "Isparta", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6478) },
                    { 33, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6478), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6479), "Mersin", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6479) },
                    { 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6480), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6480), "İstanbul", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6480) },
                    { 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6482), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6482), "İzmir", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6482) },
                    { 36, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6483), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6484), "Kars", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6483) },
                    { 37, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6484), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6485), "Kastamonu", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6484) },
                    { 38, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6485), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6486), "Kayseri", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6486) },
                    { 39, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6487), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6487), "Kırklareli", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6487) },
                    { 40, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6488), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6489), "Kırşehir", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6488) },
                    { 41, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6489), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6490), "Kocaeli", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6490) },
                    { 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6490), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6491), "Konya", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6491) },
                    { 43, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6492), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6493), "Kütahya", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6492) },
                    { 44, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6493), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6494), "Malatya", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6493) },
                    { 45, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6494), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6495), "Manisa", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6495) },
                    { 46, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6496), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6496), "Kahramanmaraş", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6496) },
                    { 47, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6497), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6498), "Mardin", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6497) },
                    { 48, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6498), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6499), "Muğla", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6499) },
                    { 49, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6499), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6500), "Muş", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6500) },
                    { 50, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6501), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6502), "Nevşehir", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6501) },
                    { 51, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6502), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6503), "Niğde", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6502) },
                    { 52, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6503), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6504), "Ordu", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6504) },
                    { 53, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6505), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6505), "Rize", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6505) },
                    { 54, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6506), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6507), "Sakarya", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6506) },
                    { 55, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6507), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6508), "Samsun", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6508) },
                    { 56, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6508), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6509), "Siirt", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6509) },
                    { 57, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6510), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6511), "Sinop", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6510) },
                    { 58, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6511), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6512), "Sivas", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6511) },
                    { 59, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6512), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6513), "Tekirdağ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6513) },
                    { 60, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6514), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6514), "Tokat", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6514) },
                    { 61, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6515), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6516), "Trabzon", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6515) },
                    { 62, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6516), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6517), "Tunceli", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6517) },
                    { 63, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6517), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6518), "Şanlıurfa", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6518) },
                    { 64, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6519), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6520), "Uşak", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6519) },
                    { 65, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6520), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6521), "Van", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6520) },
                    { 66, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6521), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6522), "Yozgat", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6522) },
                    { 67, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6523), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6523), "Zonguldak", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6523) },
                    { 68, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6524), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6525), "Aksaray", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6524) },
                    { 69, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6525), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6526), "Bayburt", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6526) },
                    { 70, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6526), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6527), "Karaman", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6527) },
                    { 71, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6528), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6528), "Kırıkkale", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6528) },
                    { 72, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6529), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6530), "Batman", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6529) },
                    { 73, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6530), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6531), "Şırnak", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6531) },
                    { 74, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6531), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6532), "Bartın", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6532) },
                    { 75, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6552), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6556), "Ardahan", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6556) },
                    { 76, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6557), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6557), "Iğdır", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6557) },
                    { 77, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6558), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6559), "Yalova", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6558) },
                    { 78, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6559), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6560), "Karabük", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6559) },
                    { 79, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6560), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6561), "Kilis", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6561) },
                    { 80, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6561), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6562), "Osmaniye", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6562) },
                    { 81, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6563), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6563), "Düzce", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6563) }
                });

            migrationBuilder.InsertData(
                table: "DocumentTypes",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Name", "Status", "Type", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8411), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8412), "TcKimlik", false, "DosyaEvrak", new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8412) },
                    { 2, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8415), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8416), "Sici Kaydı", false, "KullaniciEvrak", new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8416) }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "ID", "Code", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[] { 1, "caseFile-list", new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6052), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6051), "Case File List", true, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Description", "Name", "Status", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6162), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6161), "This is a admin roles", "Admin", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6160) });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "ID", "CityID", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6666), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6668), "ALADAĞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6667) },
                    { 2, 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6669), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6670), "CEYHAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6669) },
                    { 3, 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6670), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6671), "ÇUKUROVA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6671) },
                    { 4, 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6672), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6673), "FEKE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6672) },
                    { 5, 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6673), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6674), "İMAMOĞLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6673) },
                    { 6, 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6674), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6675), "KARAİSALI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6675) },
                    { 7, 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6676), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6676), "KARATAŞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6676) },
                    { 8, 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6677), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6678), "KOZAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6677) },
                    { 9, 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6678), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6679), "POZANTI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6679) },
                    { 10, 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6679), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6680), "SAİMBEYLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6680) },
                    { 11, 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6681), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6682), "SARIÇAM", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6681) },
                    { 12, 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6682), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6683), "SEYHAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6682) },
                    { 13, 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6683), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6684), "TUFANBEYLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6684) },
                    { 14, 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6685), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6685), "YUMURTALIK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6685) },
                    { 15, 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6686), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6687), "YÜREĞİR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6686) },
                    { 16, 2, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6687), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6688), "BESNİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6687) },
                    { 17, 2, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6688), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6689), "ÇELİKHAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6689) },
                    { 18, 2, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6690), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6690), "GERGER", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6690) },
                    { 19, 2, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6691), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6692), "GÖLBAŞI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6691) },
                    { 20, 2, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6692), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6693), "KAHTA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6693) },
                    { 21, 2, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6693), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6694), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6694) },
                    { 22, 2, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6695), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6695), "SAMSAT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6695) },
                    { 23, 2, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6696), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6697), "SİNCİK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6696) },
                    { 24, 2, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6697), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6698), "TUT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6698) },
                    { 25, 3, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6699), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6699), "BAŞMAKÇI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6699) },
                    { 26, 3, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6700), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6701), "BAYAT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6700) },
                    { 27, 3, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6701), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6702), "BOLVADİN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6701) },
                    { 28, 3, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6702), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6703), "ÇAY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6703) },
                    { 29, 3, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6704), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6704), "ÇOBANLAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6704) },
                    { 30, 3, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6705), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6706), "DAZKIRI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6705) },
                    { 31, 3, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6706), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6707), "DİNAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6707) },
                    { 32, 3, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6707), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6708), "EMİRDAĞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6708) },
                    { 33, 3, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6709), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6709), "EVCİLER", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6709) },
                    { 34, 3, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6710), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6711), "HOCALAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6710) },
                    { 35, 3, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6711), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6712), "İHSANİYE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6712) },
                    { 36, 3, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6713), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6713), "İSCEHİSAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6713) },
                    { 37, 3, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6714), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6715), "KIZILÖREN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6714) },
                    { 38, 3, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6715), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6716), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6715) },
                    { 39, 3, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6716), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6717), "SANDIKLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6717) },
                    { 40, 3, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6718), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6718), "SİNANPAŞA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6718) },
                    { 41, 3, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6719), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6720), "SULTANDAĞI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6719) },
                    { 42, 3, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6742), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6745), "ŞUHUT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6745) },
                    { 43, 4, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6746), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6747), "DİYADİN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6747) },
                    { 44, 4, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6747), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6748), "DOĞUBAYAZIT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6748) },
                    { 45, 4, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6749), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6749), "ELEŞKİRT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6749) },
                    { 46, 4, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6750), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6751), "HAMUR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6750) },
                    { 47, 4, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6751), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6752), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6752) },
                    { 48, 4, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6753), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6753), "PATNOS", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6753) },
                    { 49, 4, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6754), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6755), "TAŞLIÇAY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6754) },
                    { 50, 4, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6755), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6756), "TUTAK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6755) },
                    { 51, 5, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6756), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6757), "GÖYNÜCEK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6757) },
                    { 52, 5, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6758), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6758), "GÜMÜŞHACIKÖY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6758) },
                    { 53, 5, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6759), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6760), "HAMAMÖZÜ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6759) },
                    { 54, 5, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6760), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6761), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6760) },
                    { 55, 5, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6761), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6762), "MERZİFON", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6762) },
                    { 56, 5, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6763), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6763), "SULUOVA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6763) },
                    { 57, 5, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6764), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6765), "TAŞOVA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6764) },
                    { 58, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6765), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6766), "AKYURT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6765) },
                    { 59, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6766), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6767), "ALTINDAĞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6767) },
                    { 60, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6768), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6768), "AYAŞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6768) },
                    { 61, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6769), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6770), "BALA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6769) },
                    { 62, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6770), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6771), "BEYPAZARI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6770) },
                    { 63, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6771), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6772), "ÇAMLIDERE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6772) },
                    { 64, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6773), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6773), "ÇANKAYA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6773) },
                    { 65, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6774), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6775), "ÇUBUK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6774) },
                    { 66, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6775), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6776), "ELMADAĞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6776) },
                    { 67, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6776), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6777), "ETİMESGUT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6777) },
                    { 68, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6778), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6778), "EVREN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6778) },
                    { 69, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6779), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6780), "GÖLBAŞI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6779) },
                    { 70, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6780), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6781), "GÜDÜL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6781) },
                    { 71, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6782), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6782), "HAYMANA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6782) },
                    { 72, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6783), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6784), "KAHRAMANKAZAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6783) },
                    { 73, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6784), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6785), "KALECİK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6784) },
                    { 74, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6785), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6786), "KEÇİÖREN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6786) },
                    { 75, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6787), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6787), "KIZILCAHAMAM", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6787) },
                    { 76, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6788), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6789), "MAMAK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6788) },
                    { 77, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6789), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6790), "NALLIHAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6790) },
                    { 78, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6790), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6791), "POLATLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6791) },
                    { 79, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6792), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6792), "PURSAKLAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6792) },
                    { 80, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6793), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6794), "SİNCAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6793) },
                    { 81, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6794), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6795), "ŞEREFLİKOÇHİSAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6795) },
                    { 82, 6, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6796), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6796), "YENİMAHALLE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6796) },
                    { 83, 7, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6797), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6797), "AKSEKİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6797) },
                    { 84, 7, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6798), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6799), "AKSU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6798) },
                    { 85, 7, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6799), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6800), "ALANYA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6800) },
                    { 86, 7, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6801), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6801), "DEMRE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6801) },
                    { 87, 7, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6802), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6803), "DÖŞEMEALTI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6802) },
                    { 88, 7, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6803), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6804), "ELMALI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6804) },
                    { 89, 7, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6805), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6805), "FİNİKE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6805) },
                    { 90, 7, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6806), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6807), "GAZİPAŞA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6806) },
                    { 91, 7, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6807), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6808), "GÜNDOĞMUŞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6807) },
                    { 92, 7, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6808), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6809), "İBRADI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6809) },
                    { 93, 7, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6810), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6810), "KAŞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6810) },
                    { 94, 7, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6811), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6812), "KEMER", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6811) },
                    { 95, 7, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6812), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6813), "KEPEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6813) },
                    { 96, 7, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6813), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6814), "KONYAALTI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6814) },
                    { 97, 7, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6815), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6815), "KORKUTELİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6815) },
                    { 98, 7, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6816), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6817), "KUMLUCA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6816) },
                    { 99, 7, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6817), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6818), "MANAVGAT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6818) },
                    { 100, 7, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6819), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6819), "MURATPAŞA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6819) },
                    { 101, 7, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6820), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6820), "SERİK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6820) },
                    { 102, 8, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6821), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6822), "ARDANUÇ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6821) },
                    { 103, 8, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6822), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6823), "ARHAVİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6823) },
                    { 104, 8, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6824), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6824), "BORÇKA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6824) },
                    { 105, 8, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6825), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6826), "HOPA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6825) },
                    { 106, 8, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6826), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6827), "KEMALPAŞA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6826) },
                    { 107, 8, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6827), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6828), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6828) },
                    { 108, 8, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6829), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6829), "MURGUL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6829) },
                    { 109, 8, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6830), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6831), "ŞAVŞAT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6830) },
                    { 110, 8, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6831), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6832), "YUSUFELİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6831) },
                    { 111, 9, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6832), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6833), "BOZDOĞAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6833) },
                    { 112, 9, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6834), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6834), "BUHARKENT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6834) },
                    { 113, 9, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6835), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6836), "ÇİNE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6835) },
                    { 114, 9, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6836), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6837), "DİDİM", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6836) },
                    { 115, 9, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6867), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6869), "EFELER", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6868) },
                    { 116, 9, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6870), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6870), "GERMENCİK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6870) },
                    { 117, 9, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6871), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6872), "İNCİRLİOVA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6871) },
                    { 118, 9, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6872), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6873), "KARACASU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6873) },
                    { 119, 9, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6873), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6874), "KARPUZLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6874) },
                    { 120, 9, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6875), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6875), "KOÇARLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6875) },
                    { 121, 9, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6876), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6877), "KÖŞK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6876) },
                    { 122, 9, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6877), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6878), "KUŞADASI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6878) },
                    { 123, 9, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6878), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6879), "KUYUCAK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6879) },
                    { 124, 9, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6880), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6880), "NAZİLLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6880) },
                    { 125, 9, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6881), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6882), "SÖKE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6881) },
                    { 126, 9, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6882), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6883), "SULTANHİSAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6883) },
                    { 127, 9, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6883), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6884), "YENİPAZAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6884) },
                    { 128, 10, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6885), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6885), "ALTIEYLÜL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6885) },
                    { 129, 10, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6886), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6887), "AYVALIK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6886) },
                    { 130, 10, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6887), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6888), "BALYA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6887) },
                    { 131, 10, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6888), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6889), "BANDIRMA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6889) },
                    { 132, 10, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6890), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6890), "BİGADİÇ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6890) },
                    { 133, 10, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6891), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6892), "BURHANİYE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6891) },
                    { 134, 10, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6892), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6893), "DURSUNBEY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6892) },
                    { 135, 10, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6893), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6894), "EDREMİT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6894) },
                    { 136, 10, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6895), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6895), "ERDEK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6895) },
                    { 137, 10, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6896), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6897), "GÖMEÇ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6896) },
                    { 138, 10, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6897), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6898), "GÖNEN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6897) },
                    { 139, 10, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6898), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6899), "HAVRAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6899) },
                    { 140, 10, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6900), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6900), "İVRİNDİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6900) },
                    { 141, 10, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6901), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6902), "KARESİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6901) },
                    { 142, 10, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6902), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6903), "KEPSUT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6902) },
                    { 143, 10, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6903), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6904), "MANYAS", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6904) },
                    { 144, 10, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6905), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6905), "MARMARA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6905) },
                    { 145, 10, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6906), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6906), "SAVAŞTEPE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6906) },
                    { 146, 10, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6907), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6908), "SINDIRGI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6907) },
                    { 147, 10, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6908), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6909), "SUSURLUK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6909) },
                    { 148, 11, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6909), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6910), "BOZÜYÜK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6910) },
                    { 149, 11, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6911), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6911), "GÖLPAZARI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6911) },
                    { 150, 11, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6912), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6913), "İNHİSAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6912) },
                    { 151, 11, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6913), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6914), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6913) },
                    { 152, 11, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6914), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6915), "OSMANELİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6915) },
                    { 153, 11, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6916), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6916), "PAZARYERİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6916) },
                    { 154, 11, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6917), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6918), "SÖĞÜT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6917) },
                    { 155, 11, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6918), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6919), "YENİPAZAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6918) },
                    { 156, 12, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6919), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6920), "ADAKLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6920) },
                    { 157, 12, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6921), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6921), "GENÇ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6921) },
                    { 158, 12, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6922), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6923), "KARLIOVA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6922) },
                    { 159, 12, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6923), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6924), "KİĞI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6923) },
                    { 160, 12, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6924), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6925), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6925) },
                    { 161, 12, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6925), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6926), "SOLHAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6926) },
                    { 162, 12, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6927), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6927), "YAYLADERE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6927) },
                    { 163, 12, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6928), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6929), "YEDİSU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6928) },
                    { 164, 13, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6929), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6930), "ADİLCEVAZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6930) },
                    { 165, 13, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6930), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6931), "AHLAT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6931) },
                    { 166, 13, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6932), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6932), "GÜROYMAK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6932) },
                    { 167, 13, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6933), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6934), "HİZAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6933) },
                    { 168, 13, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6934), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6935), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6935) },
                    { 169, 13, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6935), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6936), "MUTKİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6936) },
                    { 170, 13, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6937), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6937), "TATVAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6937) },
                    { 171, 14, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6938), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6939), "DÖRTDİVAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6938) },
                    { 172, 14, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6939), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6940), "GEREDE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6940) },
                    { 173, 14, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6940), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6941), "GÖYNÜK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6941) },
                    { 174, 14, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6942), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6942), "KIBRISCIK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6942) },
                    { 175, 14, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6943), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6944), "MENGEN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6943) },
                    { 176, 14, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6944), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6945), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6945) },
                    { 177, 14, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6945), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6946), "MUDURNU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6946) },
                    { 178, 14, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6947), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6947), "SEBEN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6947) },
                    { 179, 14, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6948), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6949), "YENİÇAĞA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6948) },
                    { 180, 15, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6949), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6950), "AĞLASUN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6950) },
                    { 181, 15, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6950), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6951), "ALTINYAYLA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6951) },
                    { 182, 15, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6952), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6952), "BUCAK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6952) },
                    { 183, 15, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6953), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6954), "ÇAVDIR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6953) },
                    { 184, 15, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6954), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6955), "ÇELTİKÇİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6954) },
                    { 185, 15, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6955), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6956), "GÖLHİSAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6956) },
                    { 186, 15, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6957), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6957), "KARAMANLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6957) },
                    { 187, 15, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6958), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6958), "KEMER", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6958) },
                    { 188, 15, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6979), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6982), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6981) },
                    { 189, 15, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6982), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6983), "TEFENNİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6983) },
                    { 190, 15, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6984), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6984), "YEŞİLOVA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6984) },
                    { 191, 16, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6985), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6986), "BÜYÜKORHAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6985) },
                    { 192, 16, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6986), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6987), "GEMLİK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6987) },
                    { 193, 16, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6987), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6988), "GÜRSU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6988) },
                    { 194, 16, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6989), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6989), "HARMANCIK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6989) },
                    { 195, 16, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6990), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6991), "İNEGÖL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6990) },
                    { 196, 16, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6991), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6992), "İZNİK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6992) },
                    { 197, 16, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6993), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6993), "KARACABEY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6993) },
                    { 198, 16, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6994), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6995), "KELES", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6994) },
                    { 199, 16, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6995), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6996), "KESTEL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6995) },
                    { 200, 16, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6996), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6997), "MUDANYA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6997) },
                    { 201, 16, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6998), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6998), "MUSTAFAKEMALPAŞA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6998) },
                    { 202, 16, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6999), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7000), "NİLÜFER", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(6999) },
                    { 203, 16, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7000), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7001), "ORHANELİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7000) },
                    { 204, 16, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7001), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7002), "ORHANGAZİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7002) },
                    { 205, 16, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7003), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7003), "OSMANGAZİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7003) },
                    { 206, 16, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7004), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7005), "YENİŞEHİR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7004) },
                    { 207, 16, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7005), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7006), "YILDIRIM", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7005) },
                    { 208, 17, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7006), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7007), "AYVACIK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7007) },
                    { 209, 17, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7008), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7008), "BAYRAMİÇ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7008) },
                    { 210, 17, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7009), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7010), "BİGA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7009) },
                    { 211, 17, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7010), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7011), "BOZCAADA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7011) },
                    { 212, 17, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7011), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7012), "ÇAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7012) },
                    { 213, 17, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7013), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7013), "ECEABAT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7013) },
                    { 214, 17, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7014), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7015), "EZİNE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7014) },
                    { 215, 17, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7015), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7016), "GELİBOLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7016) },
                    { 216, 17, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7017), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7017), "GÖKÇEADA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7017) },
                    { 217, 17, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7018), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7018), "LAPSEKİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7018) },
                    { 218, 17, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7019), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7020), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7019) },
                    { 219, 17, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7020), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7021), "YENİCE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7021) },
                    { 220, 18, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7022), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7022), "ATKARACALAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7022) },
                    { 221, 18, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7023), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7024), "BAYRAMÖREN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7023) },
                    { 222, 18, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7024), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7025), "ÇERKEŞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7025) },
                    { 223, 18, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7026), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7026), "ELDİVAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7026) },
                    { 224, 18, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7027), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7028), "ILGAZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7027) },
                    { 225, 18, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7028), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7029), "KIZILIRMAK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7029) },
                    { 226, 18, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7029), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7030), "KORGUN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7030) },
                    { 227, 18, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7031), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7031), "KURŞUNLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7031) },
                    { 228, 18, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7032), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7033), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7032) },
                    { 229, 18, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7033), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7034), "ORTA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7034) },
                    { 230, 18, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7034), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7035), "ŞABANÖZÜ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7035) },
                    { 231, 18, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7036), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7036), "YAPRAKLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7036) },
                    { 232, 19, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7037), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7038), "ALACA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7037) },
                    { 233, 19, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7038), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7039), "BAYAT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7038) },
                    { 234, 19, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7039), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7040), "BOĞAZKALE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7040) },
                    { 235, 19, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7041), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7041), "DODURGA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7041) },
                    { 236, 19, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7042), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7043), "İSKİLİP", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7042) },
                    { 237, 19, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7043), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7044), "KARGI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7043) },
                    { 238, 19, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7044), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7045), "LAÇİN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7045) },
                    { 239, 19, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7045), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7046), "MECİTÖZÜ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7046) },
                    { 240, 19, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7047), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7047), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7047) },
                    { 241, 19, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7048), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7049), "OĞUZLAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7048) },
                    { 242, 19, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7049), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7050), "ORTAKÖY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7050) },
                    { 243, 19, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7050), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7051), "OSMANCIK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7051) },
                    { 244, 19, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7052), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7052), "SUNGURLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7052) },
                    { 245, 19, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7053), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7054), "UĞURLUDAĞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7053) },
                    { 246, 20, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7054), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7055), "ACIPAYAM", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7055) },
                    { 247, 20, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7055), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7056), "BABADAĞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7056) },
                    { 248, 20, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7057), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7057), "BAKLAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7057) },
                    { 249, 20, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7058), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7059), "BEKİLLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7058) },
                    { 250, 20, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7059), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7060), "BEYAĞAÇ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7060) },
                    { 251, 20, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7061), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7061), "BOZKURT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7061) },
                    { 252, 20, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7062), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7062), "BULDAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7062) },
                    { 253, 20, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7063), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7064), "ÇAL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7063) },
                    { 254, 20, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7064), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7065), "ÇAMELİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7065) },
                    { 255, 20, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7065), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7066), "ÇARDAK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7066) },
                    { 256, 20, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7067), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7067), "ÇİVRİL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7067) },
                    { 257, 20, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7068), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7069), "GÜNEY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7068) },
                    { 258, 20, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7069), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7070), "HONAZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7070) },
                    { 259, 20, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7071), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7071), "KALE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7071) },
                    { 260, 20, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7072), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7073), "MERKEZEFENDİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7072) },
                    { 261, 20, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7093), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7096), "PAMUKKALE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7096) },
                    { 262, 20, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7097), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7097), "SARAYKÖY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7097) },
                    { 263, 20, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7098), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7099), "SERİNHİSAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7098) },
                    { 264, 20, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7099), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7100), "TAVAS", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7100) },
                    { 265, 21, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7100), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7101), "BAĞLAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7101) },
                    { 266, 21, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7102), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7103), "BİSMİL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7102) },
                    { 267, 21, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7103), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7104), "ÇERMİK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7103) },
                    { 268, 21, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7104), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7105), "ÇINAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7105) },
                    { 269, 21, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7106), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7106), "ÇÜNGÜŞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7106) },
                    { 270, 21, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7107), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7108), "DİCLE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7107) },
                    { 271, 21, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7108), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7109), "EĞİL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7109) },
                    { 272, 21, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7109), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7110), "ERGANİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7110) },
                    { 273, 21, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7111), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7111), "HANİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7111) },
                    { 274, 21, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7112), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7113), "HAZRO", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7112) },
                    { 275, 21, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7113), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7114), "KAYAPINAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7114) },
                    { 276, 21, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7114), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7115), "KOCAKÖY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7115) },
                    { 277, 21, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7116), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7116), "KULP", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7116) },
                    { 278, 21, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7117), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7118), "LİCE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7117) },
                    { 279, 21, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7118), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7119), "SİLVAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7119) },
                    { 280, 21, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7119), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7120), "SUR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7120) },
                    { 281, 21, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7121), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7122), "YENİŞEHİR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7121) },
                    { 282, 22, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7122), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7123), "ENEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7122) },
                    { 283, 22, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7123), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7124), "HAVSA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7124) },
                    { 284, 22, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7125), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7125), "İPSALA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7125) },
                    { 285, 22, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7126), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7127), "KEŞAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7126) },
                    { 286, 22, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7127), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7128), "LALAPAŞA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7128) },
                    { 287, 22, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7128), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7129), "MERİÇ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7129) },
                    { 288, 22, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7130), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7130), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7130) },
                    { 289, 22, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7131), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7132), "SÜLOĞLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7131) },
                    { 290, 22, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7132), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7133), "UZUNKÖPRÜ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7133) },
                    { 291, 23, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7133), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7134), "AĞIN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7134) },
                    { 292, 23, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7135), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7135), "ALACAKAYA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7135) },
                    { 293, 23, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7136), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7137), "ARICAK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7136) },
                    { 294, 23, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7137), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7138), "BASKİL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7138) },
                    { 295, 23, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7138), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7139), "KARAKOÇAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7139) },
                    { 296, 23, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7140), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7140), "KEBAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7140) },
                    { 297, 23, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7141), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7142), "KOVANCILAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7141) },
                    { 298, 23, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7142), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7143), "MADEN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7143) },
                    { 299, 23, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7144), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7144), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7144) },
                    { 300, 23, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7145), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7146), "PALU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7145) },
                    { 301, 23, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7146), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7147), "SİVRİCE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7146) },
                    { 302, 24, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7147), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7148), "ÇAYIRLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7148) },
                    { 303, 24, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7149), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7150), "İLİÇ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7149) },
                    { 304, 24, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7150), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7151), "KEMAH", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7150) },
                    { 305, 24, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7151), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7152), "KEMALİYE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7152) },
                    { 306, 24, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7153), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7153), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7153) },
                    { 307, 24, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7154), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7155), "OTLUKBELİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7154) },
                    { 308, 24, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7155), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7156), "REFAHİYE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7156) },
                    { 309, 24, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7156), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7157), "TERCAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7157) },
                    { 310, 24, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7158), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7158), "ÜZÜMLÜ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7158) },
                    { 311, 25, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7159), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7160), "AŞKALE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7159) },
                    { 312, 25, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7160), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7161), "AZİZİYE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7161) },
                    { 313, 25, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7161), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7162), "ÇAT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7162) },
                    { 314, 25, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7163), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7163), "HINIS", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7163) },
                    { 315, 25, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7164), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7165), "HORASAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7164) },
                    { 316, 25, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7165), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7166), "İSPİR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7166) },
                    { 317, 25, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7167), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7167), "KARAÇOBAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7167) },
                    { 318, 25, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7168), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7169), "KARAYAZI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7169) },
                    { 319, 25, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7170), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7170), "KÖPRÜKÖY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7170) },
                    { 320, 25, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7171), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7172), "NARMAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7171) },
                    { 321, 25, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7172), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7173), "OLTU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7173) },
                    { 322, 25, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7173), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7174), "OLUR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7174) },
                    { 323, 25, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7175), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7175), "PALANDÖKEN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7175) },
                    { 324, 25, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7176), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7177), "PASİNLER", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7176) },
                    { 325, 25, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7177), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7178), "PAZARYOLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7178) },
                    { 326, 25, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7179), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7179), "ŞENKAYA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7179) },
                    { 327, 25, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7180), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7181), "TEKMAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7180) },
                    { 328, 25, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7181), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7182), "TORTUM", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7181) },
                    { 329, 25, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7182), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7183), "UZUNDERE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7183) },
                    { 330, 25, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7184), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7184), "YAKUTİYE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7184) },
                    { 331, 26, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7185), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7186), "ALPU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7185) },
                    { 332, 26, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7186), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7187), "BEYLİKOVA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7187) },
                    { 333, 26, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7188), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7188), "ÇİFTELER", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7188) },
                    { 334, 26, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7208), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7211), "GÜNYÜZÜ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7210) },
                    { 335, 26, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7211), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7212), "HAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7212) },
                    { 336, 26, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7213), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7213), "İNÖNÜ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7213) },
                    { 337, 26, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7214), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7215), "MAHMUDİYE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7214) },
                    { 338, 26, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7215), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7216), "MİHALGAZİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7216) },
                    { 339, 26, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7217), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7217), "MİHALIÇÇIK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7217) },
                    { 340, 26, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7218), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7219), "ODUNPAZARI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7218) },
                    { 341, 26, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7219), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7220), "SARICAKAYA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7219) },
                    { 342, 26, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7220), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7221), "SEYİTGAZİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7221) },
                    { 343, 26, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7222), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7222), "SİVRİHİSAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7222) },
                    { 344, 26, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7223), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7224), "TEPEBAŞI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7223) },
                    { 345, 27, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7224), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7225), "ARABAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7225) },
                    { 346, 27, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7225), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7226), "İSLAHİYE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7226) },
                    { 347, 27, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7227), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7228), "KARKAMIŞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7227) },
                    { 348, 27, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7228), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7229), "NİZİP", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7228) },
                    { 349, 27, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7229), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7230), "NURDAĞI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7230) },
                    { 350, 27, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7231), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7231), "OĞUZELİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7231) },
                    { 351, 27, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7232), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7233), "ŞAHİNBEY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7232) },
                    { 352, 27, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7233), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7234), "ŞEHİTKAMİL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7234) },
                    { 353, 27, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7235), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7235), "YAVUZELİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7235) },
                    { 354, 28, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7236), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7237), "ALUCRA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7236) },
                    { 355, 28, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7237), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7238), "BULANCAK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7238) },
                    { 356, 28, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7238), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7239), "ÇAMOLUK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7239) },
                    { 357, 28, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7240), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7241), "ÇANAKÇI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7240) },
                    { 358, 28, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7242), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7243), "DERELİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7242) },
                    { 359, 28, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7243), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7244), "DOĞANKENT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7244) },
                    { 360, 28, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7245), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7245), "ESPİYE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7245) },
                    { 361, 28, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7246), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7247), "EYNESİL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7246) },
                    { 362, 28, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7247), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7248), "GÖRELE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7247) },
                    { 363, 28, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7248), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7249), "GÜCE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7249) },
                    { 364, 28, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7250), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7250), "KEŞAP", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7250) },
                    { 365, 28, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7251), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7252), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7251) },
                    { 366, 28, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7252), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7253), "PİRAZİZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7253) },
                    { 367, 28, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7253), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7254), "ŞEBİNKARAHİSAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7254) },
                    { 368, 28, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7255), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7256), "TİREBOLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7255) },
                    { 369, 28, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7256), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7257), "YAĞLIDERE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7256) },
                    { 370, 29, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7257), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7258), "KELKİT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7258) },
                    { 371, 29, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7259), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7259), "KÖSE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7259) },
                    { 372, 29, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7260), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7261), "KÜRTÜN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7260) },
                    { 373, 29, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7261), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7262), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7262) },
                    { 374, 29, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7262), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7263), "ŞİRAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7263) },
                    { 375, 29, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7264), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7265), "TORUL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7264) },
                    { 376, 30, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7265), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7266), "ÇUKURCA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7265) },
                    { 377, 30, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7266), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7267), "DERECİK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7267) },
                    { 378, 30, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7268), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7268), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7268) },
                    { 379, 30, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7269), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7270), "ŞEMDİNLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7269) },
                    { 380, 30, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7270), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7271), "YÜKSEKOVA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7271) },
                    { 381, 31, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7272), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7272), "ALTINÖZÜ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7272) },
                    { 382, 31, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7273), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7274), "ANTAKYA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7273) },
                    { 383, 31, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7274), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7275), "ARSUZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7275) },
                    { 384, 31, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7275), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7276), "BELEN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7276) },
                    { 385, 31, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7277), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7278), "DEFNE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7277) },
                    { 386, 31, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7278), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7279), "DÖRTYOL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7278) },
                    { 387, 31, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7279), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7280), "ERZİN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7280) },
                    { 388, 31, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7281), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7281), "HASSA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7281) },
                    { 389, 31, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7282), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7283), "İSKENDERUN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7282) },
                    { 390, 31, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7283), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7284), "KIRIKHAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7284) },
                    { 391, 31, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7285), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7285), "KUMLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7285) },
                    { 392, 31, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7286), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7287), "PAYAS", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7286) },
                    { 393, 31, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7287), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7288), "REYHANLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7288) },
                    { 394, 31, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7288), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7289), "SAMANDAĞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7289) },
                    { 395, 31, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7290), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7290), "YAYLADAĞI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7290) },
                    { 396, 32, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7291), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7292), "AKSU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7291) },
                    { 397, 32, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7292), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7293), "ATABEY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7293) },
                    { 398, 32, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7294), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7294), "EĞİRDİR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7294) },
                    { 399, 32, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7295), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7296), "GELENDOST", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7295) },
                    { 400, 32, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7296), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7297), "GÖNEN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7297) },
                    { 401, 32, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7298), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7298), "KEÇİBORLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7298) },
                    { 402, 32, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7299), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7300), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7299) },
                    { 403, 32, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7300), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7301), "SENİRKENT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7300) },
                    { 404, 32, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7301), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7302), "SÜTÇÜLER", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7302) },
                    { 405, 32, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7303), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7303), "ŞARKİKARAAĞAÇ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7303) },
                    { 406, 32, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7304), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7305), "ULUBORLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7304) },
                    { 407, 32, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7326), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7330), "YALVAÇ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7330) },
                    { 408, 32, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7331), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7332), "YENİŞARBADEMLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7331) },
                    { 409, 33, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7332), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7333), "AKDENİZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7333) },
                    { 410, 33, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7334), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7334), "ANAMUR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7334) },
                    { 411, 33, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7335), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7336), "AYDINCIK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7335) },
                    { 412, 33, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7336), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7337), "BOZYAZI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7336) },
                    { 413, 33, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7337), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7338), "ÇAMLIYAYLA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7338) },
                    { 414, 33, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7339), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7339), "ERDEMLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7339) },
                    { 415, 33, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7340), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7341), "GÜLNAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7340) },
                    { 416, 33, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7341), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7342), "MEZİTLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7341) },
                    { 417, 33, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7342), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7343), "MUT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7343) },
                    { 418, 33, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7344), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7344), "SİLİFKE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7344) },
                    { 419, 33, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7345), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7346), "TARSUS", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7345) },
                    { 420, 33, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7346), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7347), "TOROSLAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7347) },
                    { 421, 33, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7347), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7348), "YENİŞEHİR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7348) },
                    { 422, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7349), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7349), "ADALAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7349) },
                    { 423, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7350), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7351), "ARNAVUTKÖY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7350) },
                    { 424, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7351), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7352), "ATAŞEHİR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7352) },
                    { 425, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7352), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7353), "AVCILAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7353) },
                    { 426, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7354), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7354), "BAĞCILAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7354) },
                    { 427, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7355), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7356), "BAHÇELİEVLER", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7355) },
                    { 428, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7356), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7357), "BAKIRKÖY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7357) },
                    { 429, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7358), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7358), "BAŞAKŞEHİR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7358) },
                    { 430, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7359), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7360), "BAYRAMPAŞA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7359) },
                    { 431, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7360), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7361), "BEŞİKTAŞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7360) },
                    { 432, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7361), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7362), "BEYKOZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7362) },
                    { 433, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7363), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7363), "BEYLİKDÜZÜ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7363) },
                    { 434, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7364), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7365), "BEYOĞLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7364) },
                    { 435, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7365), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7366), "BÜYÜKÇEKMECE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7366) },
                    { 436, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7366), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7367), "ÇATALCA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7367) },
                    { 437, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7368), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7368), "ÇEKMEKÖY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7368) },
                    { 438, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7369), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7370), "ESENLER", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7369) },
                    { 439, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7370), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7371), "ESENYURT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7371) },
                    { 440, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7371), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7372), "EYÜPSULTAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7372) },
                    { 441, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7373), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7373), "FATİH", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7373) },
                    { 442, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7374), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7375), "GAZİOSMANPAŞA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7374) },
                    { 443, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7375), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7376), "GÜNGÖREN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7376) },
                    { 444, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7377), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7377), "KADIKÖY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7377) },
                    { 445, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7378), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7379), "KAĞITHANE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7378) },
                    { 446, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7379), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7380), "KARTAL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7380) },
                    { 447, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7380), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7381), "KÜÇÜKÇEKMECE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7381) },
                    { 448, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7382), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7383), "MALTEPE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7382) },
                    { 449, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7383), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7384), "PENDİK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7383) },
                    { 450, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7384), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7385), "SANCAKTEPE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7385) },
                    { 451, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7386), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7386), "SARIYER", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7386) },
                    { 452, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7387), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7388), "SİLİVRİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7387) },
                    { 453, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7388), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7389), "SULTANBEYLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7389) },
                    { 454, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7389), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7390), "SULTANGAZİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7390) },
                    { 455, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7391), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7391), "ŞİLE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7391) },
                    { 456, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7392), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7393), "ŞİŞLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7392) },
                    { 457, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7393), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7394), "TUZLA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7394) },
                    { 458, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7394), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7395), "ÜMRANİYE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7395) },
                    { 459, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7396), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7396), "ÜSKÜDAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7396) },
                    { 460, 34, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7397), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7398), "ZEYTİNBURNU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7397) },
                    { 461, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7398), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7399), "ALİAĞA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7399) },
                    { 462, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7400), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7400), "BALÇOVA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7400) },
                    { 463, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7401), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7402), "BAYINDIR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7401) },
                    { 464, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7402), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7403), "BAYRAKLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7403) },
                    { 465, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7403), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7404), "BERGAMA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7404) },
                    { 466, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7405), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7405), "BEYDAĞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7405) },
                    { 467, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7406), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7407), "BORNOVA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7406) },
                    { 468, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7407), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7408), "BUCA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7408) },
                    { 469, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7409), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7409), "ÇEŞME", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7409) },
                    { 470, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7410), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7410), "ÇİĞLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7410) },
                    { 471, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7411), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7412), "DİKİLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7411) },
                    { 472, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7412), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7413), "FOÇA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7413) },
                    { 473, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7414), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7414), "GAZİEMİR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7414) },
                    { 474, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7415), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7416), "GÜZELBAHÇE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7415) },
                    { 475, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7416), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7417), "KARABAĞLAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7416) },
                    { 476, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7417), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7418), "KARABURUN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7418) },
                    { 477, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7419), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7419), "KARŞIYAKA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7419) },
                    { 478, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7420), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7421), "KEMALPAŞA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7420) },
                    { 479, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7421), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7422), "KINIK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7422) },
                    { 480, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7444), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7447), "KİRAZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7447) },
                    { 481, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7448), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7449), "KONAK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7448) },
                    { 482, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7449), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7450), "MENDERES", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7450) },
                    { 483, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7451), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7451), "MENEMEN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7451) },
                    { 484, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7452), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7453), "NARLIDERE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7452) },
                    { 485, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7453), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7454), "ÖDEMİŞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7454) },
                    { 486, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7454), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7455), "SEFERİHİSAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7455) },
                    { 487, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7456), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7456), "SELÇUK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7456) },
                    { 488, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7457), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7458), "TİRE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7457) },
                    { 489, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7458), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7459), "TORBALI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7459) },
                    { 490, 35, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7459), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7460), "URLA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7460) },
                    { 491, 36, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7461), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7461), "AKYAKA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7461) },
                    { 492, 36, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7462), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7463), "ARPAÇAY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7462) },
                    { 493, 36, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7463), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7464), "DİGOR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7464) },
                    { 494, 36, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7464), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7465), "KAĞIZMAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7465) },
                    { 495, 36, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7466), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7466), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7466) },
                    { 496, 36, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7467), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7468), "SARIKAMIŞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7467) },
                    { 497, 36, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7468), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7469), "SELİM", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7469) },
                    { 498, 36, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7470), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7470), "SUSUZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7470) },
                    { 499, 37, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7471), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7471), "ABANA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7471) },
                    { 500, 37, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7472), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7473), "AĞLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7472) },
                    { 501, 37, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7473), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7474), "ARAÇ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7474) },
                    { 502, 37, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7475), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7475), "AZDAVAY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7475) },
                    { 503, 37, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7476), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7477), "BOZKURT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7476) },
                    { 504, 37, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7477), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7478), "CİDE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7477) },
                    { 505, 37, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7478), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7479), "ÇATALZEYTİN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7479) },
                    { 506, 37, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7480), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7480), "DADAY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7480) },
                    { 507, 37, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7481), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7482), "DEVREKANİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7481) },
                    { 508, 37, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7482), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7483), "DOĞANYURT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7483) },
                    { 509, 37, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7483), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7484), "HANÖNÜ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7484) },
                    { 510, 37, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7485), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7485), "İHSANGAZİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7485) },
                    { 511, 37, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7486), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7487), "İNEBOLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7486) },
                    { 512, 37, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7487), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7488), "KÜRE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7488) },
                    { 513, 37, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7488), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7489), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7489) },
                    { 514, 37, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7490), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7490), "PINARBAŞI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7490) },
                    { 515, 37, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7491), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7492), "SEYDİLER", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7491) },
                    { 516, 37, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7492), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7493), "ŞENPAZAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7493) },
                    { 517, 37, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7493), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7494), "TAŞKÖPRÜ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7494) },
                    { 518, 37, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7495), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7496), "TOSYA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7495) },
                    { 519, 38, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7496), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7497), "AKKIŞLA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7496) },
                    { 520, 38, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7497), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7498), "BÜNYAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7498) },
                    { 521, 38, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7499), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7499), "DEVELİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7499) },
                    { 522, 38, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7500), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7501), "FELAHİYE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7500) },
                    { 523, 38, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7501), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7502), "HACILAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7502) },
                    { 524, 38, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7502), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7503), "İNCESU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7503) },
                    { 525, 38, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7504), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7504), "KOCASİNAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7504) },
                    { 526, 38, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7505), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7506), "MELİKGAZİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7505) },
                    { 527, 38, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7506), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7507), "ÖZVATAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7507) },
                    { 528, 38, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7508), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7508), "PINARBAŞI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7508) },
                    { 529, 38, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7509), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7510), "SARIOĞLAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7509) },
                    { 530, 38, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7510), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7511), "SARIZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7510) },
                    { 531, 38, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7511), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7512), "TALAS", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7512) },
                    { 532, 38, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7513), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7513), "TOMARZA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7513) },
                    { 533, 38, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7514), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7515), "YAHYALI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7514) },
                    { 534, 38, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7515), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7516), "YEŞİLHİSAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7515) },
                    { 535, 39, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7516), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7517), "BABAESKİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7517) },
                    { 536, 39, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7518), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7518), "DEMİRKÖY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7518) },
                    { 537, 39, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7519), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7520), "KOFÇAZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7519) },
                    { 538, 39, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7520), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7521), "LÜLEBURGAZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7521) },
                    { 539, 39, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7521), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7522), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7522) },
                    { 540, 39, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7523), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7523), "PEHLİVANKÖY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7523) },
                    { 541, 39, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7524), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7525), "PINARHİSAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7524) },
                    { 542, 39, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7525), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7526), "VİZE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7526) },
                    { 543, 40, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7527), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7527), "AKÇAKENT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7527) },
                    { 544, 40, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7528), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7529), "AKPINAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7528) },
                    { 545, 40, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7529), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7530), "BOZTEPE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7529) },
                    { 546, 40, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7530), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7531), "ÇİÇEKDAĞI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7531) },
                    { 547, 40, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7532), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7532), "KAMAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7532) },
                    { 548, 40, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7533), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7534), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7533) },
                    { 549, 40, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7534), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7535), "MUCUR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7534) },
                    { 550, 41, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7535), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7536), "BAŞİSKELE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7536) },
                    { 551, 41, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7537), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7537), "ÇAYIROVA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7537) },
                    { 552, 41, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7538), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7539), "DARICA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7538) },
                    { 553, 41, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7559), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7562), "DERİNCE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7561) },
                    { 554, 41, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7562), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7563), "DİLOVASI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7563) },
                    { 555, 41, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7564), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7565), "GEBZE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7564) },
                    { 556, 41, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7565), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7566), "GÖLCÜK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7565) },
                    { 557, 41, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7566), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7567), "İZMİT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7567) },
                    { 558, 41, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7568), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7568), "KANDIRA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7568) },
                    { 559, 41, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7569), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7570), "KARAMÜRSEL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7569) },
                    { 560, 41, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7570), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7571), "KARTEPE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7570) },
                    { 561, 41, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7571), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7572), "KÖRFEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7572) },
                    { 562, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7573), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7573), "AHIRLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7573) },
                    { 563, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7574), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7575), "AKÖREN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7574) },
                    { 564, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7575), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7576), "AKŞEHİR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7576) },
                    { 565, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7576), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7577), "ALTINEKİN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7577) },
                    { 566, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7578), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7578), "BEYŞEHİR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7578) },
                    { 567, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7579), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7580), "BOZKIR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7579) },
                    { 568, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7580), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7581), "CİHANBEYLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7581) },
                    { 569, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7581), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7582), "ÇELTİK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7582) },
                    { 570, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7583), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7583), "ÇUMRA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7583) },
                    { 571, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7584), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7585), "DERBENT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7584) },
                    { 572, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7585), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7586), "DEREBUCAK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7586) },
                    { 573, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7587), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7587), "DOĞANHİSAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7587) },
                    { 574, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7588), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7589), "EMİRGAZİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7588) },
                    { 575, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7589), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7590), "EREĞLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7589) },
                    { 576, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7590), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7591), "GÜNEYSINIR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7591) },
                    { 577, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7592), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7592), "HADİM", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7592) },
                    { 578, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7593), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7594), "HALKAPINAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7593) },
                    { 579, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7594), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7595), "HÜYÜK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7595) },
                    { 580, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7595), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7596), "ILGIN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7596) },
                    { 581, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7597), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7597), "KADINHANI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7597) },
                    { 582, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7598), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7599), "KARAPINAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7598) },
                    { 583, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7599), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7600), "KARATAY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7600) },
                    { 584, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7600), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7601), "KULU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7601) },
                    { 585, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7602), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7602), "MERAM", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7602) },
                    { 586, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7603), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7604), "SARAYÖNÜ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7603) },
                    { 587, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7604), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7605), "SELÇUKLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7605) },
                    { 588, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7605), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7606), "SEYDİŞEHİR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7606) },
                    { 589, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7607), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7607), "TAŞKENT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7607) },
                    { 590, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7608), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7609), "TUZLUKÇU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7608) },
                    { 591, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7609), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7610), "YALIHÜYÜK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7610) },
                    { 592, 42, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7611), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7611), "YUNAK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7611) },
                    { 593, 43, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7612), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7613), "ALTINTAŞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7612) },
                    { 594, 43, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7613), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7614), "ASLANAPA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7613) },
                    { 595, 43, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7614), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7615), "ÇAVDARHİSAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7615) },
                    { 596, 43, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7616), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7616), "DOMANİÇ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7616) },
                    { 597, 43, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7617), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7618), "DUMLUPINAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7617) },
                    { 598, 43, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7618), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7619), "EMET", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7618) },
                    { 599, 43, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7619), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7620), "GEDİZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7620) },
                    { 600, 43, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7621), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7621), "HİSARCIK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7621) },
                    { 601, 43, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7622), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7623), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7622) },
                    { 602, 43, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7623), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7624), "PAZARLAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7623) },
                    { 603, 43, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7624), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7625), "SİMAV", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7625) },
                    { 604, 43, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7626), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7626), "ŞAPHANE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7626) },
                    { 605, 43, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7627), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7628), "TAVŞANLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7627) },
                    { 606, 44, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7628), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7629), "AKÇADAĞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7629) },
                    { 607, 44, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7629), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7630), "ARAPGİR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7630) },
                    { 608, 44, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7631), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7632), "ARGUVAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7631) },
                    { 609, 44, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7632), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7633), "BATTALGAZİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7633) },
                    { 610, 44, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7634), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7634), "DARENDE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7634) },
                    { 611, 44, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7635), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7636), "DOĞANŞEHİR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7635) },
                    { 612, 44, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7636), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7637), "DOĞANYOL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7636) },
                    { 613, 44, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7637), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7638), "HEKİMHAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7638) },
                    { 614, 44, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7639), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7639), "KALE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7639) },
                    { 615, 44, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7640), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7641), "KULUNCAK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7640) },
                    { 616, 44, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7641), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7642), "PÜTÜRGE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7641) },
                    { 617, 44, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7642), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7643), "YAZIHAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7643) },
                    { 618, 44, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7644), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7644), "YEŞİLYURT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7644) },
                    { 619, 45, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7645), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7645), "AHMETLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7645) },
                    { 620, 45, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7646), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7647), "AKHİSAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7646) },
                    { 621, 45, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7647), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7648), "ALAŞEHİR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7648) },
                    { 622, 45, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7649), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7649), "DEMİRCİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7649) },
                    { 623, 45, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7650), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7651), "GÖLMARMARA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7650) },
                    { 624, 45, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7651), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7652), "GÖRDES", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7651) },
                    { 625, 45, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7652), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7653), "KIRKAĞAÇ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7653) },
                    { 626, 45, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7673), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7676), "KÖPRÜBAŞI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7676) },
                    { 627, 45, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7677), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7677), "KULA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7677) },
                    { 628, 45, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7678), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7679), "SALİHLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7678) },
                    { 629, 45, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7679), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7680), "SARIGÖL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7680) },
                    { 630, 45, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7680), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7681), "SARUHANLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7681) },
                    { 631, 45, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7682), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7682), "SELENDİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7682) },
                    { 632, 45, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7683), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7684), "SOMA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7683) },
                    { 633, 45, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7684), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7685), "ŞEHZADELER", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7685) },
                    { 634, 45, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7685), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7686), "TURGUTLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7686) },
                    { 635, 45, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7687), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7687), "YUNUSEMRE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7687) },
                    { 636, 46, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7688), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7689), "AFŞİN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7688) },
                    { 637, 46, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7689), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7690), "ANDIRIN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7689) },
                    { 638, 46, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7690), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7691), "ÇAĞLAYANCERİT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7691) },
                    { 639, 46, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7692), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7692), "DULKADİROĞLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7692) },
                    { 640, 46, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7693), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7694), "EKİNÖZÜ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7693) },
                    { 641, 46, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7694), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7695), "ELBİSTAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7694) },
                    { 642, 46, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7695), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7696), "GÖKSUN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7696) },
                    { 643, 46, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7697), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7697), "NURHAK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7697) },
                    { 644, 46, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7698), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7699), "ONİKİŞUBAT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7698) },
                    { 645, 46, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7699), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7700), "PAZARCIK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7699) },
                    { 646, 46, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7700), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7701), "TÜRKOĞLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7701) },
                    { 647, 47, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7702), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7702), "ARTUKLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7702) },
                    { 648, 47, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7703), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7704), "DARGEÇİT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7703) },
                    { 649, 47, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7704), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7705), "DERİK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7704) },
                    { 650, 47, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7705), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7706), "KIZILTEPE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7706) },
                    { 651, 47, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7707), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7707), "MAZIDAĞI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7707) },
                    { 652, 47, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7708), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7708), "MİDYAT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7708) },
                    { 653, 47, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7709), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7710), "NUSAYBİN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7709) },
                    { 654, 47, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7710), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7711), "ÖMERLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7711) },
                    { 655, 47, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7712), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7712), "SAVUR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7712) },
                    { 656, 47, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7713), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7714), "YEŞİLLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7713) },
                    { 657, 48, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7714), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7715), "BODRUM", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7714) },
                    { 658, 48, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7715), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7716), "DALAMAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7716) },
                    { 659, 48, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7717), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7717), "DATÇA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7717) },
                    { 660, 48, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7718), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7718), "FETHİYE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7718) },
                    { 661, 48, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7719), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7720), "KAVAKLIDERE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7719) },
                    { 662, 48, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7720), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7721), "KÖYCEĞİZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7721) },
                    { 663, 48, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7721), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7722), "MARMARİS", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7722) },
                    { 664, 48, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7723), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7724), "MENTEŞE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7723) },
                    { 665, 48, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7724), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7725), "MİLAS", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7725) },
                    { 666, 48, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7725), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7726), "ORTACA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7726) },
                    { 667, 48, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7727), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7727), "SEYDİKEMER", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7727) },
                    { 668, 48, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7728), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7729), "ULA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7728) },
                    { 669, 48, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7729), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7730), "YATAĞAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7729) },
                    { 670, 49, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7730), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7731), "BULANIK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7731) },
                    { 671, 49, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7732), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7732), "HASKÖY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7732) },
                    { 672, 49, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7733), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7734), "KORKUT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7733) },
                    { 673, 49, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7734), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7735), "MALAZGİRT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7735) },
                    { 674, 49, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7735), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7736), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7736) },
                    { 675, 49, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7737), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7737), "VARTO", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7737) },
                    { 676, 50, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7738), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7739), "ACIGÖL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7738) },
                    { 677, 50, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7739), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7740), "AVANOS", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7740) },
                    { 678, 50, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7740), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7741), "DERİNKUYU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7741) },
                    { 679, 50, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7742), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7742), "GÜLŞEHİR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7742) },
                    { 680, 50, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7743), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7744), "HACIBEKTAŞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7743) },
                    { 681, 50, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7744), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7745), "KOZAKLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7745) },
                    { 682, 50, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7746), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7746), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7746) },
                    { 683, 50, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7747), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7747), "ÜRGÜP", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7747) },
                    { 684, 51, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7748), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7749), "ALTUNHİSAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7748) },
                    { 685, 51, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7749), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7750), "BOR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7750) },
                    { 686, 51, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7750), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7751), "ÇAMARDI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7751) },
                    { 687, 51, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7752), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7752), "ÇİFTLİK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7752) },
                    { 688, 51, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7753), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7754), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7753) },
                    { 689, 51, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7754), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7755), "ULUKIŞLA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7755) },
                    { 690, 52, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7755), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7756), "AKKUŞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7756) },
                    { 691, 52, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7757), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7757), "ALTINORDU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7757) },
                    { 692, 52, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7758), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7759), "AYBASTI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7758) },
                    { 693, 52, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7759), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7760), "ÇAMAŞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7760) },
                    { 694, 52, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7760), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7761), "ÇATALPINAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7761) },
                    { 695, 52, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7762), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7762), "ÇAYBAŞI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7762) },
                    { 696, 52, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7763), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7764), "FATSA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7763) },
                    { 697, 52, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7764), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7765), "GÖLKÖY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7764) },
                    { 698, 52, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7791), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7793), "GÜLYALI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7793) },
                    { 699, 52, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7794), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7795), "GÜRGENTEPE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7795) },
                    { 700, 52, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7795), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7796), "İKİZCE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7796) },
                    { 701, 52, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7797), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7797), "KABADÜZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7797) },
                    { 702, 52, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7798), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7799), "KABATAŞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7798) },
                    { 703, 52, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7799), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7800), "KORGAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7800) },
                    { 704, 52, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7801), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7801), "KUMRU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7801) },
                    { 705, 52, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7802), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7803), "MESUDİYE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7802) },
                    { 706, 52, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7803), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7804), "PERŞEMBE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7803) },
                    { 707, 52, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7804), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7805), "ULUBEY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7805) },
                    { 708, 52, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7806), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7806), "ÜNYE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7806) },
                    { 709, 53, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7807), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7808), "ARDEŞEN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7807) },
                    { 710, 53, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7808), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7809), "ÇAMLIHEMŞİN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7808) },
                    { 711, 53, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7809), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7810), "ÇAYELİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7810) },
                    { 712, 53, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7811), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7811), "DEREPAZARI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7811) },
                    { 713, 53, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7812), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7813), "FINDIKLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7812) },
                    { 714, 53, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7813), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7814), "GÜNEYSU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7814) },
                    { 715, 53, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7814), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7815), "HEMŞİN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7815) },
                    { 716, 53, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7816), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7816), "İKİZDERE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7816) },
                    { 717, 53, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7817), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7818), "İYİDERE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7817) },
                    { 718, 53, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7818), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7819), "KALKANDERE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7819) },
                    { 719, 53, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7819), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7820), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7820) },
                    { 720, 53, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7821), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7821), "PAZAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7821) },
                    { 721, 54, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7822), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7823), "ADAPAZARI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7822) },
                    { 722, 54, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7823), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7824), "AKYAZI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7824) },
                    { 723, 54, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7824), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7825), "ARİFİYE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7825) },
                    { 724, 54, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7826), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7826), "ERENLER", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7826) },
                    { 725, 54, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7827), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7828), "FERİZLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7827) },
                    { 726, 54, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7828), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7829), "GEYVE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7829) },
                    { 727, 54, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7830), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7830), "HENDEK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7830) },
                    { 728, 54, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7831), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7832), "KARAPÜRÇEK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7831) },
                    { 729, 54, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7832), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7833), "KARASU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7833) },
                    { 730, 54, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7833), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7834), "KAYNARCA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7834) },
                    { 731, 54, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7835), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7835), "KOCAALİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7835) },
                    { 732, 54, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7836), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7837), "PAMUKOVA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7836) },
                    { 733, 54, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7837), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7838), "SAPANCA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7838) },
                    { 734, 54, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7838), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7839), "SERDİVAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7839) },
                    { 735, 54, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7840), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7840), "SÖĞÜTLÜ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7840) },
                    { 736, 54, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7841), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7842), "TARAKLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7841) },
                    { 737, 55, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7842), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7843), "ALAÇAM", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7843) },
                    { 738, 55, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7843), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7844), "ASARCIK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7844) },
                    { 739, 55, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7845), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7845), "ATAKUM", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7845) },
                    { 740, 55, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7846), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7847), "AYVACIK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7846) },
                    { 741, 55, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7847), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7848), "BAFRA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7848) },
                    { 742, 55, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7849), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7849), "CANİK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7849) },
                    { 743, 55, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7850), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7851), "ÇARŞAMBA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7850) },
                    { 744, 55, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7851), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7852), "HAVZA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7851) },
                    { 745, 55, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7852), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7853), "İLKADIM", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7853) },
                    { 746, 55, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7854), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7854), "KAVAK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7854) },
                    { 747, 55, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7855), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7856), "LADİK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7855) },
                    { 748, 55, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7856), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7857), "SALIPAZARI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7856) },
                    { 749, 55, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7857), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7858), "TEKKEKÖY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7858) },
                    { 750, 55, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7859), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7859), "TERME", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7859) },
                    { 751, 55, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7860), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7861), "VEZİRKÖPRÜ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7860) },
                    { 752, 55, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7861), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7862), "YAKAKENT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7861) },
                    { 753, 55, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7862), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7863), "19 MAYIS", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7863) },
                    { 754, 56, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7864), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7864), "BAYKAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7864) },
                    { 755, 56, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7865), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7866), "ERUH", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7865) },
                    { 756, 56, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7866), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7867), "KURTALAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7867) },
                    { 757, 56, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7867), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7868), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7868) },
                    { 758, 56, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7869), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7869), "PERVARİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7869) },
                    { 759, 56, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7870), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7871), "ŞİRVAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7870) },
                    { 760, 56, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7871), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7872), "TİLLO", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7872) },
                    { 761, 57, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7873), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7873), "AYANCIK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7873) },
                    { 762, 57, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7874), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7875), "BOYABAT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7874) },
                    { 763, 57, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7875), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7876), "DİKMEN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7875) },
                    { 764, 57, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7876), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7877), "DURAĞAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7877) },
                    { 765, 57, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7878), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7878), "ERFELEK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7878) },
                    { 766, 57, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7879), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7880), "GERZE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7879) },
                    { 767, 57, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7880), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7881), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7880) },
                    { 768, 57, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7881), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7882), "SARAYDÜZÜ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7882) },
                    { 769, 57, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7883), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7883), "TÜRKELİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7883) },
                    { 770, 58, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7884), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7885), "AKINCILAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7884) },
                    { 771, 58, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7904), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7907), "ALTINYAYLA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7906) },
                    { 772, 58, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7907), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7908), "DİVRİĞİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7908) },
                    { 773, 58, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7909), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7909), "DOĞANŞAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7909) },
                    { 774, 58, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7910), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7911), "GEMEREK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7910) },
                    { 775, 58, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7911), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7912), "GÖLOVA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7912) },
                    { 776, 58, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7913), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7913), "GÜRÜN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7913) },
                    { 777, 58, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7914), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7915), "HAFİK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7914) },
                    { 778, 58, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7915), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7916), "İMRANLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7915) },
                    { 779, 58, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7916), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7917), "KANGAL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7917) },
                    { 780, 58, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7918), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7918), "KOYULHİSAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7918) },
                    { 781, 58, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7919), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7920), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7919) },
                    { 782, 58, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7920), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7921), "SUŞEHRİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7921) },
                    { 783, 58, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7921), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7922), "ŞARKIŞLA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7922) },
                    { 784, 58, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7923), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7924), "ULAŞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7923) },
                    { 785, 58, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7924), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7925), "YILDIZELİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7924) },
                    { 786, 58, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7925), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7926), "ZARA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7926) },
                    { 787, 59, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7927), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7927), "ÇERKEZKÖY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7927) },
                    { 788, 59, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7928), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7929), "ÇORLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7928) },
                    { 789, 59, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7929), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7930), "ERGENE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7930) },
                    { 790, 59, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7930), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7931), "HAYRABOLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7931) },
                    { 791, 59, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7932), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7933), "KAPAKLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7932) },
                    { 792, 59, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7933), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7934), "MALKARA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7933) },
                    { 793, 59, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7934), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7935), "MARMARAEREĞLİSİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7935) },
                    { 794, 59, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7936), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7936), "MURATLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7936) },
                    { 795, 59, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7937), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7938), "SARAY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7937) },
                    { 796, 59, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7938), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7939), "SÜLEYMANPAŞA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7939) },
                    { 797, 59, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7940), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7940), "ŞARKÖY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7940) },
                    { 798, 60, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7941), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7942), "ALMUS", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7941) },
                    { 799, 60, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7942), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7943), "ARTOVA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7942) },
                    { 800, 60, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7943), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7944), "BAŞÇİFTLİK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7944) },
                    { 801, 60, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7945), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7945), "ERBAA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7945) },
                    { 802, 60, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7946), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7947), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7946) },
                    { 803, 60, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7947), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7948), "NİKSAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7948) },
                    { 804, 60, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7949), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7949), "PAZAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7949) },
                    { 805, 60, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7950), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7951), "REŞADİYE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7950) },
                    { 806, 60, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7951), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7952), "SULUSARAY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7952) },
                    { 807, 60, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7953), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7953), "TURHAL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7953) },
                    { 808, 60, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7954), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7955), "YEŞİLYURT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7954) },
                    { 809, 60, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7955), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7956), "ZİLE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7956) },
                    { 810, 61, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7957), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7957), "AKÇAABAT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7957) },
                    { 811, 61, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7958), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7959), "ARAKLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7958) },
                    { 812, 61, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7959), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7960), "ARSİN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7960) },
                    { 813, 61, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7960), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7961), "BEŞİKDÜZÜ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7961) },
                    { 814, 61, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7962), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7962), "ÇARŞIBAŞI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7962) },
                    { 815, 61, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7963), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7964), "ÇAYKARA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7963) },
                    { 816, 61, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7964), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7965), "DERNEKPAZARI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7965) },
                    { 817, 61, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7966), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7966), "DÜZKÖY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7966) },
                    { 818, 61, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7967), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7968), "HAYRAT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7967) },
                    { 819, 61, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7968), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7969), "KÖPRÜBAŞI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7968) },
                    { 820, 61, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7969), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7970), "MAÇKA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7970) },
                    { 821, 61, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7971), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7971), "OF", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7971) },
                    { 822, 61, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7972), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7973), "ORTAHİSAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7972) },
                    { 823, 61, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7973), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7974), "SÜRMENE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7974) },
                    { 824, 61, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7975), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7975), "ŞALPAZARI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7975) },
                    { 825, 61, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7976), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7977), "TONYA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7976) },
                    { 826, 61, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7977), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7978), "VAKFIKEBİR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7977) },
                    { 827, 61, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7978), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7979), "YOMRA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7979) },
                    { 828, 62, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7980), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7980), "ÇEMİŞGEZEK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7980) },
                    { 829, 62, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7981), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7982), "HOZAT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7981) },
                    { 830, 62, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7982), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7983), "MAZGİRT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7983) },
                    { 831, 62, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7984), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7984), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7984) },
                    { 832, 62, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7985), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7986), "NAZIMİYE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7985) },
                    { 833, 62, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7986), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7987), "OVACIK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7987) },
                    { 834, 62, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7987), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7988), "PERTEK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7988) },
                    { 835, 62, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7989), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7989), "PÜLÜMÜR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7989) },
                    { 836, 63, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7990), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7991), "AKÇAKALE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7990) },
                    { 837, 63, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7991), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7992), "BİRECİK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7992) },
                    { 838, 63, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7993), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7993), "BOZOVA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7993) },
                    { 839, 63, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7994), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7995), "CEYLANPINAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7994) },
                    { 840, 63, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7995), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7996), "EYYÜBİYE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7995) },
                    { 841, 63, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7996), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7997), "HALFETİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7997) },
                    { 842, 63, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7998), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7998), "HALİLİYE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7998) },
                    { 843, 63, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7999), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8000), "HARRAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(7999) },
                    { 844, 63, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8019), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8023), "HİLVAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8022) },
                    { 845, 63, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8023), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8024), "KARAKÖPRÜ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8024) },
                    { 846, 63, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8025), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8025), "SİVEREK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8025) },
                    { 847, 63, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8026), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8027), "SURUÇ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8026) },
                    { 848, 63, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8027), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8028), "VİRANŞEHİR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8028) },
                    { 849, 64, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8028), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8029), "BANAZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8029) },
                    { 850, 64, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8030), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8030), "EŞME", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8030) },
                    { 851, 64, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8031), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8032), "KARAHALLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8031) },
                    { 852, 64, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8032), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8033), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8033) },
                    { 853, 64, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8033), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8034), "SİVASLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8034) },
                    { 854, 64, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8035), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8035), "ULUBEY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8035) },
                    { 855, 65, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8036), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8037), "BAHÇESARAY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8036) },
                    { 856, 65, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8037), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8038), "BAŞKALE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8038) },
                    { 857, 65, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8039), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8039), "ÇALDIRAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8039) },
                    { 858, 65, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8040), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8041), "ÇATAK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8040) },
                    { 859, 65, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8041), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8042), "EDREMİT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8041) },
                    { 860, 65, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8042), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8043), "ERCİŞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8043) },
                    { 861, 65, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8044), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8044), "GEVAŞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8044) },
                    { 862, 65, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8045), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8046), "GÜRPINAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8045) },
                    { 863, 65, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8046), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8047), "İPEKYOLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8046) },
                    { 864, 65, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8047), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8048), "MURADİYE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8048) },
                    { 865, 65, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8049), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8049), "ÖZALP", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8049) },
                    { 866, 65, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8050), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8051), "SARAY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8050) },
                    { 867, 65, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8051), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8052), "TUŞBA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8052) },
                    { 868, 66, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8052), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8053), "AKDAĞMADENİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8053) },
                    { 869, 66, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8054), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8054), "AYDINCIK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8054) },
                    { 870, 66, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8055), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8056), "BOĞAZLIYAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8055) },
                    { 871, 66, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8056), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8057), "ÇANDIR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8057) },
                    { 872, 66, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8058), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8058), "ÇAYIRALAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8058) },
                    { 873, 66, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8059), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8060), "ÇEKEREK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8059) },
                    { 874, 66, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8060), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8061), "KADIŞEHRİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8060) },
                    { 875, 66, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8061), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8062), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8062) },
                    { 876, 66, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8063), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8063), "SARAYKENT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8063) },
                    { 877, 66, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8064), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8065), "SARIKAYA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8064) },
                    { 878, 66, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8065), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8066), "SORGUN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8066) },
                    { 879, 66, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8066), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8067), "ŞEFAATLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8067) },
                    { 880, 66, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8068), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8068), "YENİFAKILI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8068) },
                    { 881, 66, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8069), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8070), "YERKÖY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8069) },
                    { 882, 67, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8070), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8071), "ALAPLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8071) },
                    { 883, 67, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8071), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8072), "ÇAYCUMA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8072) },
                    { 884, 67, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8073), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8074), "DEVREK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8073) },
                    { 885, 67, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8074), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8075), "EREĞLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8074) },
                    { 886, 67, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8075), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8076), "GÖKÇEBEY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8076) },
                    { 887, 67, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8077), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8077), "KİLİMLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8077) },
                    { 888, 67, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8078), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8079), "KOZLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8078) },
                    { 889, 67, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8079), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8080), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8079) },
                    { 890, 68, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8080), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8081), "AĞAÇÖREN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8081) },
                    { 891, 68, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8082), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8082), "ESKİL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8082) },
                    { 892, 68, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8083), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8084), "GÜLAĞAÇ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8083) },
                    { 893, 68, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8084), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8085), "GÜZELYURT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8085) },
                    { 894, 68, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8085), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8086), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8086) },
                    { 895, 68, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8087), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8087), "ORTAKÖY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8087) },
                    { 896, 68, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8088), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8089), "SARIYAHŞİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8088) },
                    { 897, 68, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8089), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8090), "SULTANHANI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8090) },
                    { 898, 69, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8091), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8091), "AYDINTEPE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8091) },
                    { 899, 69, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8092), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8093), "DEMİRÖZÜ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8092) },
                    { 900, 69, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8093), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8094), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8093) },
                    { 901, 70, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8094), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8095), "AYRANCI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8095) },
                    { 902, 70, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8096), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8097), "BAŞYAYLA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8096) },
                    { 903, 70, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8097), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8098), "ERMENEK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8098) },
                    { 904, 70, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8098), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8099), "KAZIMKARABEKİR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8099) },
                    { 905, 70, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8100), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8100), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8100) },
                    { 906, 70, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8101), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8102), "SARIVELİLER", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8101) },
                    { 907, 71, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8102), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8103), "BAHŞİLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8103) },
                    { 908, 71, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8103), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8104), "BALIŞEYH", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8104) },
                    { 909, 71, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8105), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8105), "ÇELEBİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8105) },
                    { 910, 71, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8106), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8107), "DELİCE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8106) },
                    { 911, 71, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8107), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8108), "KARAKEÇİLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8108) },
                    { 912, 71, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8109), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8110), "KESKİN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8110) },
                    { 913, 71, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8111), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8111), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8111) },
                    { 914, 71, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8112), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8113), "SULAKYURT", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8112) },
                    { 915, 71, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8113), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8114), "YAHŞİHAN", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8114) },
                    { 916, 72, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8114), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8115), "BEŞİRİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8115) },
                    { 917, 72, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8134), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8137), "GERCÜŞ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8136) },
                    { 918, 72, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8138), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8138), "HASANKEYF", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8138) },
                    { 919, 72, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8139), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8140), "KOZLUK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8139) },
                    { 920, 72, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8140), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8141), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8140) },
                    { 921, 72, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8141), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8142), "SASON", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8142) },
                    { 922, 73, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8143), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8143), "BEYTÜŞŞEBAP", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8143) },
                    { 923, 73, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8144), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8145), "CİZRE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8144) },
                    { 924, 73, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8145), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8146), "GÜÇLÜKONAK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8146) },
                    { 925, 73, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8146), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8147), "İDİL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8147) },
                    { 926, 73, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8148), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8149), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8148) },
                    { 927, 73, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8149), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8150), "SİLOPİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8149) },
                    { 928, 73, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8150), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8151), "ULUDERE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8151) },
                    { 929, 74, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8152), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8152), "AMASRA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8152) },
                    { 930, 74, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8153), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8154), "KURUCAŞİLE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8153) },
                    { 931, 74, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8154), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8155), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8155) },
                    { 932, 74, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8155), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8156), "ULUS", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8156) },
                    { 933, 75, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8157), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8158), "ÇILDIR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8157) },
                    { 934, 75, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8158), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8159), "DAMAL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8158) },
                    { 935, 75, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8159), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8160), "GÖLE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8160) },
                    { 936, 75, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8161), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8161), "HANAK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8161) },
                    { 937, 75, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8162), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8163), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8162) },
                    { 938, 75, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8163), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8164), "POSOF", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8164) },
                    { 939, 76, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8165), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8165), "ARALIK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8165) },
                    { 940, 76, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8166), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8167), "KARAKOYUNLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8166) },
                    { 941, 76, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8167), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8168), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8167) },
                    { 942, 76, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8168), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8169), "TUZLUCA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8169) },
                    { 943, 77, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8170), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8170), "ALTINOVA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8170) },
                    { 944, 77, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8171), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8172), "ARMUTLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8171) },
                    { 945, 77, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8172), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8173), "ÇINARCIK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8173) },
                    { 946, 77, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8173), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8174), "ÇİFTLİKKÖY", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8174) },
                    { 947, 77, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8175), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8176), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8175) },
                    { 948, 77, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8176), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8177), "TERMAL", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8176) },
                    { 949, 78, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8177), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8178), "EFLANİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8178) },
                    { 950, 78, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8179), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8179), "ESKİPAZAR", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8179) },
                    { 951, 78, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8180), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8181), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8180) },
                    { 952, 78, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8181), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8182), "OVACIK", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8182) },
                    { 953, 78, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8182), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8183), "SAFRANBOLU", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8183) },
                    { 954, 78, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8184), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8184), "YENİCE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8184) },
                    { 955, 79, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8185), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8186), "ELBEYLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8185) },
                    { 956, 79, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8186), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8187), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8187) },
                    { 957, 79, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8188), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8188), "MUSABEYLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8188) },
                    { 958, 79, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8189), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8190), "POLATELİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8189) },
                    { 959, 80, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8190), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8191), "BAHÇE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8191) },
                    { 960, 80, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8191), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8192), "DÜZİÇİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8192) },
                    { 961, 80, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8193), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8194), "HASANBEYLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8193) },
                    { 962, 80, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8194), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8195), "KADİRLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8194) },
                    { 963, 80, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8195), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8196), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8196) },
                    { 964, 80, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8197), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8197), "SUMBAS", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8197) },
                    { 965, 80, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8198), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8199), "TOPRAKKALE", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8198) },
                    { 966, 81, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8199), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8200), "AKÇAKOCA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8200) },
                    { 967, 81, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8201), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8201), "CUMAYERİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8201) },
                    { 968, 81, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8202), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8203), "ÇİLİMLİ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8202) },
                    { 969, 81, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8203), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8204), "GÖLYAKA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8203) },
                    { 970, 81, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8204), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8205), "GÜMÜŞOVA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8205) },
                    { 971, 81, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8206), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8206), "KAYNAŞLI", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8206) },
                    { 972, 81, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8207), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8208), "MERKEZ", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8207) },
                    { 973, 81, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8208), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8209), "YIĞILCA", false, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8209) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CityID", "CreatedDate", "DeletedDate", "DistrictID", "EmailConfirmationToken", "EmailConfirmed", "FailedLoginAttempts", "IsLocked", "LastLoginDate", "LockedUntil", "Mail", "Name", "Password", "ResetToken", "ResetTokenExpiry", "RoleID", "Status", "Surname", "UpdatedDate", "UserName" },
                values: new object[] { 1, 1, new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8498), new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8495), 1, null, false, 0, false, null, null, "", "Büşra", "12345", null, null, 1, false, "Güneş", new DateTime(2025, 9, 29, 12, 13, 53, 769, DateTimeKind.Local).AddTicks(8495), "busra" });

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
                name: "IX_CaseFileNotes_CaseFileID",
                table: "CaseFileNotes",
                column: "CaseFileID");

            migrationBuilder.CreateIndex(
                name: "IX_CaseFileNotes_UserID",
                table: "CaseFileNotes",
                column: "UserID");

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
                name: "IX_CaseFiles_CourtID",
                table: "CaseFiles",
                column: "CourtID");

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
                name: "IX_Courts_CityID",
                table: "Courts",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Courts_DistrictID",
                table: "Courts",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CityID",
                table: "Districts",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Hearings_CaseFileID",
                table: "Hearings",
                column: "CaseFileID");

            migrationBuilder.CreateIndex(
                name: "IX_Hearings_CourtID",
                table: "Hearings",
                column: "CourtID");

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
                name: "CaseFileNotes");

            migrationBuilder.DropTable(
                name: "CaseFileShares");

            migrationBuilder.DropTable(
                name: "Hearings");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "Defendants");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CaseFiles");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "ApplicationTypes");

            migrationBuilder.DropTable(
                name: "CaseTypes");

            migrationBuilder.DropTable(
                name: "Courts");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
