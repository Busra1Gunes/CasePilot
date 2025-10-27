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
                name: "ExpenseCategories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseCategories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "IncomeCategories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeCategories", x => x.ID);
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
                name: "Expenses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpenseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Expenses_ExpenseCategories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "ExpenseCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Expenses_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Incomes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IncomeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incomes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Incomes_IncomeCategories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "IncomeCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incomes_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
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
                    CaseFileID = table.Column<int>(type: "int", nullable: false),
                    DefendantID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseFileDefendant", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CaseFileDefendant_CaseFiles_CaseFileID",
                        column: x => x.CaseFileID,
                        principalTable: "CaseFiles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseFileDefendant_Defendants_DefendantID",
                        column: x => x.DefendantID,
                        principalTable: "Defendants",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CaseFileDocuments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseFileID = table.Column<int>(type: "int", nullable: false),
                    DocumentTypeID = table.Column<int>(type: "int", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FileExtension = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseFileDocuments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CaseFileDocuments_CaseFiles_CaseFileID",
                        column: x => x.CaseFileID,
                        principalTable: "CaseFiles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CaseFileDocuments_DocumentTypes_DocumentTypeID",
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
                    { 1, 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(1564), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(1565), "Menfi Tespit", false, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(1565) },
                    { 2, 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(1570), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(1571), "Alacak", false, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(1571) },
                    { 3, 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(1572), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(1573), "İdari Dava", false, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(1572) },
                    { 4, 4, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(1573), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(1574), "Kamulaştırma", false, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(1574) }
                });

            migrationBuilder.InsertData(
                table: "CaseTypes",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2026), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2027), "Tüketici", false, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2027) },
                    { 2, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2029), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2029), "Asliye Hukuk", false, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2029) }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2255), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2256), "Adana", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2256) },
                    { 2, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2258), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2259), "Adıyaman", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2258) },
                    { 3, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2259), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2260), "Afyonkarahisar", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2260) },
                    { 4, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2261), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2262), "Ağrı", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2261) },
                    { 5, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2262), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2263), "Amasya", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2263) },
                    { 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2264), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2265), "Ankara", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2264) },
                    { 7, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2265), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2266), "Antalya", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2266) },
                    { 8, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2267), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2268), "Artvin", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2267) },
                    { 9, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2268), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2269), "Aydın", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2269) },
                    { 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2311), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2312), "Balıkesir", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2311) },
                    { 11, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2313), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2314), "Bilecik", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2313) },
                    { 12, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2315), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2316), "Bingöl", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2315) },
                    { 13, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2316), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2317), "Bitlis", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2317) },
                    { 14, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2318), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2319), "Bolu", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2318) },
                    { 15, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2319), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2320), "Burdur", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2320) },
                    { 16, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2321), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2322), "Bursa", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2321) },
                    { 17, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2322), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2323), "Çanakkale", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2323) },
                    { 18, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2324), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2325), "Çankırı", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2324) },
                    { 19, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2325), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2326), "Çorum", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2326) },
                    { 20, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2327), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2328), "Denizli", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2327) },
                    { 21, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2328), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2329), "Diyarbakır", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2329) },
                    { 22, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2330), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2331), "Edirne", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2330) },
                    { 23, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2331), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2332), "Elazığ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2332) },
                    { 24, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2333), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2334), "Erzincan", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2333) },
                    { 25, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2334), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2335), "Erzurum", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2335) },
                    { 26, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2336), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2336), "Eskişehir", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2336) },
                    { 27, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2337), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2338), "Gaziantep", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2337) },
                    { 28, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2339), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2339), "Giresun", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2339) },
                    { 29, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2340), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2341), "Gümüşhane", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2341) },
                    { 30, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2342), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2342), "Hakkari", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2342) },
                    { 31, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2343), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2344), "Hatay", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2343) },
                    { 32, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2345), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2345), "Isparta", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2345) },
                    { 33, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2346), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2347), "Mersin", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2346) },
                    { 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2348), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2348), "İstanbul", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2348) },
                    { 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2349), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2350), "İzmir", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2349) },
                    { 36, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2350), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2351), "Kars", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2351) },
                    { 37, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2353), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2354), "Kastamonu", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2353) },
                    { 38, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2354), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2355), "Kayseri", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2355) },
                    { 39, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2356), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2357), "Kırklareli", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2356) },
                    { 40, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2357), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2358), "Kırşehir", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2358) },
                    { 41, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2359), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2360), "Kocaeli", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2359) },
                    { 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2360), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2361), "Konya", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2361) },
                    { 43, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2362), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2363), "Kütahya", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2362) },
                    { 44, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2363), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2364), "Malatya", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2364) },
                    { 45, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2365), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2365), "Manisa", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2365) },
                    { 46, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2366), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2367), "Kahramanmaraş", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2367) },
                    { 47, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2368), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2368), "Mardin", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2368) },
                    { 48, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2369), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2370), "Muğla", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2369) },
                    { 49, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2371), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2371), "Muş", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2371) },
                    { 50, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2372), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2373), "Nevşehir", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2372) },
                    { 51, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2374), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2374), "Niğde", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2374) },
                    { 52, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2375), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2376), "Ordu", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2375) },
                    { 53, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2377), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2377), "Rize", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2377) },
                    { 54, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2378), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2379), "Sakarya", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2378) },
                    { 55, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2379), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2380), "Samsun", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2380) },
                    { 56, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2381), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2382), "Siirt", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2381) },
                    { 57, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2382), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2383), "Sinop", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2383) },
                    { 58, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2384), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2385), "Sivas", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2384) },
                    { 59, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2385), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2386), "Tekirdağ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2386) },
                    { 60, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2387), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2388), "Tokat", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2387) },
                    { 61, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2388), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2389), "Trabzon", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2389) },
                    { 62, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2390), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2391), "Tunceli", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2390) },
                    { 63, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2391), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2392), "Şanlıurfa", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2392) },
                    { 64, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2393), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2393), "Uşak", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2393) },
                    { 65, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2394), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2395), "Van", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2395) },
                    { 66, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2396), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2396), "Yozgat", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2396) },
                    { 67, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2397), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2398), "Zonguldak", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2397) },
                    { 68, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2398), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2399), "Aksaray", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2399) },
                    { 69, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2400), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2401), "Bayburt", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2400) },
                    { 70, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2402), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2402), "Karaman", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2402) },
                    { 71, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2403), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2404), "Kırıkkale", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2404) },
                    { 72, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2405), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2406), "Batman", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2405) },
                    { 73, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2406), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2407), "Şırnak", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2407) },
                    { 74, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2408), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2409), "Bartın", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2409) },
                    { 75, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2410), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2410), "Ardahan", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2410) },
                    { 76, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2411), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2412), "Iğdır", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2412) },
                    { 77, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2413), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2413), "Yalova", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2413) },
                    { 78, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2414), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2415), "Karabük", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2415) },
                    { 79, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2416), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2416), "Kilis", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2416) },
                    { 80, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2417), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2418), "Osmaniye", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2417) },
                    { 81, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2418), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2419), "Düzce", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2419) }
                });

            migrationBuilder.InsertData(
                table: "DocumentTypes",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Name", "Status", "Type", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5405), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5408), "TcKimlik", false, "DosyaEvrak", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5407) },
                    { 2, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5409), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5410), "Sici Kaydı", false, "KullaniciEvrak", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5410) }
                });

            migrationBuilder.InsertData(
                table: "ExpenseCategories",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Description", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5699), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5697), "Dava açılış, temyiz ve diğer mahkeme harçları", "Mahkeme Harçları", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5697) },
                    { 2, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5702), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5701), "Bilirkişi inceleme ve rapor ücretleri", "Bilirkişi Ücreti", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5701) },
                    { 3, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5704), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5703), "Noter onay ve tasdik masrafları", "Noter Masrafı", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5703) },
                    { 4, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5706), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5705), "Posta ve tebligat masrafları", "Tebligat Gideri", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5705) },
                    { 5, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5708), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5707), "Duruşma ve iş gezisi yol masrafları", "Yol Masrafı", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5707) },
                    { 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5710), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5709), "Evrak fotokopi ve çoğaltma giderleri", "Dosya Fotokopi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5709) },
                    { 7, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5712), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5711), "İcra dairesi masraf ve avans giderleri", "İcra Takip Masrafı", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5711) },
                    { 8, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5714), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5713), "Yeminli tercüman ve tercüme ücretleri", "Tercüme Ücreti", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5713) },
                    { 9, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5716), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5715), "Ofis kira ödemeleri", "Ofis Kira", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5715) },
                    { 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5718), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5717), "Çalışan personel maaş ödemeleri", "Personel Maaş", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5717) },
                    { 11, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5720), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5719), "Ofis elektrik, su ve doğalgaz faturaları", "Elektrik-Su-Doğalgaz", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5719) },
                    { 12, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5722), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5721), "İnternet ve telefon abonelik ücretleri", "İnternet-Telefon", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5721) },
                    { 13, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5724), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5723), "Ofis kırtasiye ve malzeme alımları", "Kırtasiye Malzeme", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5723) },
                    { 14, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5726), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5725), "Hukuk yazılım ve program lisans ücretleri", "Yazılım Lisans", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5725) },
                    { 15, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5728), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5727), "Baro üyelik aidat ödemeleri", "Baro Aidat", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5727) },
                    { 16, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5730), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5729), "Gelir vergisi ve diğer vergi ödemeleri", "Vergi Ödemesi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5729) },
                    { 17, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5732), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5731), "Mesleki sorumluluk ve diğer sigorta ödemeleri", "Sigorta Ödemesi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5731) },
                    { 18, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5734), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5733), "Mesleki eğitim ve seminer katılım ücretleri", "Eğitim-Seminer", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5733) },
                    { 19, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5736), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5735), "İş amaçlı araç yakıt giderleri", "Araç Yakıt", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5735) },
                    { 20, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5738), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5737), "Diğer ofis ve dava masrafları", "Diğer Giderler", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5737) }
                });

            migrationBuilder.InsertData(
                table: "IncomeCategories",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Description", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5989), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5986), "Müvekkil avukatlık ve danışmanlık ücretleri", "Avukatlık Ücreti", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5986) },
                    { 2, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5992), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5991), "Dava vekalet ücret gelirleri", "Vekalet Ücreti", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5991) },
                    { 3, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5994), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5993), "Hukuki danışmanlık hizmet gelirleri", "Danışmanlık Ücreti", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5993) },
                    { 4, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5996), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5995), "Arabuluculuk hizmet gelirleri", "Arabuluculuk Ücreti", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5995) },
                    { 5, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5998), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5997), "Sözleşme hazırlama ve inceleme ücretleri", "Sözleşme Hazırlama", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5997) },
                    { 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(6000), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5999), "Müvekkilden mahkeme masrafları iadesi", "Mahkeme Gideri İadesi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(5999) },
                    { 7, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(6002), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(6001), "İcra dosyalarından yapılan tahsilatlar", "İcra Tahsilat", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(6001) },
                    { 8, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(6004), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(6003), "Dosya sonuçlandırma ücretleri", "Dosya Kapatma Ücreti", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(6003) },
                    { 9, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(6006), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(6005), "Dava kazanma başarı primleri", "Başarı Primi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(6005) },
                    { 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(6008), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(6007), "Diğer hukuki hizmet gelirleri", "Diğer Gelirler", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(6007) }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "ID", "Code", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "list-user", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(835), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(832), "Kullanıcı Listeleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(831) },
                    { 2, "add-user", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(837), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(836), "Kullanıcı Ekleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(836) },
                    { 3, "update-user", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(839), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(839), "Kullanıcı Güncelleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(838) },
                    { 4, "delete-user", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(841), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(841), "Kullanıcı Silme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(840) },
                    { 5, "login-user", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(844), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(843), "Kullanıcı Giriş Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(842) },
                    { 6, "change-password", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(846), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(845), "Kullanıcı Şifre Güncelleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(844) },
                    { 7, "list-role", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(848), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(847), "Rol Listeleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(847) },
                    { 8, "add-role", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(850), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(849), "Rol Ekleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(849) },
                    { 9, "update-role", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(852), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(851), "Rol Güncelleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(851) },
                    { 10, "delete-role", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(854), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(853), "Rol Silme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(853) },
                    { 11, "list-permission", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(856), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(855), "Yetki Listeleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(855) },
                    { 12, "add-permission", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(858), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(857), "Yetki Ekleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(857) },
                    { 13, "update-permission", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(860), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(859), "Yetki Güncelleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(859) },
                    { 14, "delete-permission", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(862), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(861), "Yetki Silme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(861) },
                    { 15, "list-casefile", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(864), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(863), "Dosya Listeleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(863) },
                    { 16, "add-casefile", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(866), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(865), "Dosya Ekleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(865) },
                    { 17, "update-casefile", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(868), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(867), "Dosya Güncelleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(867) },
                    { 18, "delete-casefile", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(870), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(869), "Dosya Silme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(869) },
                    { 19, "list-casefiledefendant", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(873), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(872), "Dosya Sanık Listeleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(872) },
                    { 20, "add-casefiledefendant", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(875), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(874), "Dosya Sanık Ekleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(874) },
                    { 21, "update-casefiledefendant", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(877), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(876), "Dosya Sanık Güncelleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(876) },
                    { 22, "delete-casefiledefendant", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(879), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(878), "Dosya Sanık Silme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(878) },
                    { 23, "list-casefileshare", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(881), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(880), "Dosya Pay Listeleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(880) },
                    { 24, "add-casefileshare", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(883), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(882), "Dosya Pay Ekleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(882) },
                    { 25, "delete-casefileshare", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(885), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(884), "Dosya Pay Silme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(884) },
                    { 26, "list-transaction", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(887), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(886), "Hesap Hareketi Listeleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(886) },
                    { 27, "add-transaction", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(889), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(888), "Hesap Hareketi Ekleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(888) },
                    { 28, "update-transaction", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(891), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(890), "Hesap Hareketi Güncelleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(890) },
                    { 29, "delete-transaction", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(893), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(892), "Hesap Hareketi Silme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(892) },
                    { 30, "list-expense", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(895), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(894), "Gider Listeleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(894) },
                    { 31, "add-expense", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(897), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(896), "Gider Ekleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(896) },
                    { 32, "update-expense", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(899), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(898), "Gider Güncelleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(898) },
                    { 33, "delete-expense", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(901), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(900), "Gider Silme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(900) },
                    { 34, "list-income", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(905), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(902), "Gelir Listeleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(902) },
                    { 35, "add-income", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(907), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(906), "Gelir Ekleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(906) },
                    { 36, "update-income", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(909), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(908), "Gelir Güncelleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(908) },
                    { 37, "delete-income", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(911), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(910), "Gelir Silme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(910) },
                    { 38, "list-casetype", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(913), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(912), "Dava Türü Listeleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(912) },
                    { 39, "add-casetype", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(915), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(914), "Dava Türü Ekleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(914) },
                    { 40, "delete-casetype", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(917), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(916), "Dava Türü Silme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(916) },
                    { 41, "list-court", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(919), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(918), "Mahkeme Listeleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(918) },
                    { 42, "add-court", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(921), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(920), "Mahkeme Ekleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(920) },
                    { 43, "update-court", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(923), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(922), "Mahkeme Güncelleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(922) },
                    { 44, "delete-court", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(925), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(924), "Mahkeme Silme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(924) },
                    { 45, "list-hearing", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(927), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(926), "Duruşma Listeleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(926) },
                    { 46, "add-hearing", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(929), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(928), "Duruşma Ekleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(928) },
                    { 47, "update-hearing", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(931), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(930), "Duruşma Güncelleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(930) },
                    { 48, "delete-hearing", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(933), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(932), "Duruşma Silme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(932) },
                    { 49, "list-document", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(935), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(934), "Belge Listeleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(934) },
                    { 50, "add-document", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(937), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(936), "Belge Ekleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(936) },
                    { 51, "update-document", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(939), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(938), "Belge Güncelleme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(938) },
                    { 52, "delete-document", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(977), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(977), "Belge Silme Yetkisi", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(976) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Description", "Name", "Status", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(1330), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(1329), "This is a admin roles", "Admin", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "ID", "CityID", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2802), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2803), "ALADAĞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2803) },
                    { 2, 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2805), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2806), "CEYHAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2806) },
                    { 3, 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2807), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2808), "ÇUKUROVA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2807) },
                    { 4, 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2809), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2810), "FEKE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2809) },
                    { 5, 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2810), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2811), "İMAMOĞLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2811) },
                    { 6, 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2812), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2813), "KARAİSALI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2812) },
                    { 7, 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2813), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2814), "KARATAŞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2814) },
                    { 8, 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2815), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2816), "KOZAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2815) },
                    { 9, 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2816), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2817), "POZANTI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2817) },
                    { 10, 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2818), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2819), "SAİMBEYLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2818) },
                    { 11, 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2819), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2820), "SARIÇAM", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2820) },
                    { 12, 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2821), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2822), "SEYHAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2821) },
                    { 13, 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2822), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2823), "TUFANBEYLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2823) },
                    { 14, 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2824), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2825), "YUMURTALIK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2824) },
                    { 15, 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2825), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2826), "YÜREĞİR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2826) },
                    { 16, 2, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2827), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2828), "BESNİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2827) },
                    { 17, 2, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2828), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2829), "ÇELİKHAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2829) },
                    { 18, 2, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2830), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2831), "GERGER", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2830) },
                    { 19, 2, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2831), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2832), "GÖLBAŞI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2832) },
                    { 20, 2, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2833), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2834), "KAHTA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2833) },
                    { 21, 2, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2834), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2835), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2835) },
                    { 22, 2, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2837), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2838), "SAMSAT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2837) },
                    { 23, 2, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2838), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2839), "SİNCİK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2839) },
                    { 24, 2, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2840), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2841), "TUT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2840) },
                    { 25, 3, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2841), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2842), "BAŞMAKÇI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2842) },
                    { 26, 3, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2843), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2844), "BAYAT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2843) },
                    { 27, 3, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2844), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2845), "BOLVADİN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2845) },
                    { 28, 3, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2846), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2847), "ÇAY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2847) },
                    { 29, 3, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2848), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2848), "ÇOBANLAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2848) },
                    { 30, 3, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2849), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2850), "DAZKIRI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2850) },
                    { 31, 3, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2851), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2851), "DİNAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2851) },
                    { 32, 3, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2852), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2853), "EMİRDAĞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2853) },
                    { 33, 3, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2854), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2855), "EVCİLER", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2854) },
                    { 34, 3, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2855), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2856), "HOCALAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2856) },
                    { 35, 3, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2857), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2858), "İHSANİYE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2857) },
                    { 36, 3, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2858), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2859), "İSCEHİSAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2859) },
                    { 37, 3, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2860), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2861), "KIZILÖREN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2860) },
                    { 38, 3, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2861), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2862), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2862) },
                    { 39, 3, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2863), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2864), "SANDIKLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2863) },
                    { 40, 3, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2864), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2865), "SİNANPAŞA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2865) },
                    { 41, 3, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2866), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2867), "SULTANDAĞI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2866) },
                    { 42, 3, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2867), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2868), "ŞUHUT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2868) },
                    { 43, 4, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2869), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2870), "DİYADİN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2869) },
                    { 44, 4, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2870), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2871), "DOĞUBAYAZIT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2871) },
                    { 45, 4, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2872), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2873), "ELEŞKİRT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2872) },
                    { 46, 4, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2874), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2874), "HAMUR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2874) },
                    { 47, 4, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2875), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2876), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2875) },
                    { 48, 4, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2877), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2877), "PATNOS", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2877) },
                    { 49, 4, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2878), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2879), "TAŞLIÇAY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2879) },
                    { 50, 4, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2880), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2881), "TUTAK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2880) },
                    { 51, 5, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2881), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2882), "GÖYNÜCEK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2882) },
                    { 52, 5, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2883), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2884), "GÜMÜŞHACIKÖY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2884) },
                    { 53, 5, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2885), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2886), "HAMAMÖZÜ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2885) },
                    { 54, 5, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2886), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2887), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2887) },
                    { 55, 5, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2888), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2889), "MERZİFON", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2888) },
                    { 56, 5, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2889), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2890), "SULUOVA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2890) },
                    { 57, 5, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2923), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2924), "TAŞOVA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2923) },
                    { 58, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2925), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2926), "AKYURT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2925) },
                    { 59, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2926), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2927), "ALTINDAĞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2927) },
                    { 60, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2928), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2929), "AYAŞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2928) },
                    { 61, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2929), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2930), "BALA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2930) },
                    { 62, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2931), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2932), "BEYPAZARI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2931) },
                    { 63, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2932), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2933), "ÇAMLIDERE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2933) },
                    { 64, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2934), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2935), "ÇANKAYA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2934) },
                    { 65, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2935), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2936), "ÇUBUK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2936) },
                    { 66, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2937), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2938), "ELMADAĞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2937) },
                    { 67, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2938), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2939), "ETİMESGUT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2939) },
                    { 68, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2940), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2941), "EVREN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2940) },
                    { 69, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2941), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2942), "GÖLBAŞI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2942) },
                    { 70, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2943), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2944), "GÜDÜL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2943) },
                    { 71, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2944), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2945), "HAYMANA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2945) },
                    { 72, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2946), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2947), "KAHRAMANKAZAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2946) },
                    { 73, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2948), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2948), "KALECİK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2948) },
                    { 74, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2949), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2950), "KEÇİÖREN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2949) },
                    { 75, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2951), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2951), "KIZILCAHAMAM", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2951) },
                    { 76, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2952), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2953), "MAMAK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2952) },
                    { 77, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2954), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2955), "NALLIHAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2954) },
                    { 78, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2955), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2956), "POLATLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2956) },
                    { 79, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2957), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2958), "PURSAKLAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2957) },
                    { 80, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2958), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2959), "SİNCAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2959) },
                    { 81, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2960), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2961), "ŞEREFLİKOÇHİSAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2960) },
                    { 82, 6, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2961), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2962), "YENİMAHALLE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2962) },
                    { 83, 7, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2964), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2964), "AKSEKİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2964) },
                    { 84, 7, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2965), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2966), "AKSU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2965) },
                    { 85, 7, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2967), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2967), "ALANYA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2967) },
                    { 86, 7, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2968), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2969), "DEMRE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2969) },
                    { 87, 7, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2970), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2970), "DÖŞEMEALTI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2970) },
                    { 88, 7, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2971), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2972), "ELMALI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2972) },
                    { 89, 7, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2973), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2973), "FİNİKE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2973) },
                    { 90, 7, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2974), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2975), "GAZİPAŞA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2975) },
                    { 91, 7, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2976), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2977), "GÜNDOĞMUŞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2976) },
                    { 92, 7, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2977), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2978), "İBRADI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2978) },
                    { 93, 7, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2979), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2980), "KAŞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2979) },
                    { 94, 7, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2980), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2981), "KEMER", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2981) },
                    { 95, 7, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2982), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2983), "KEPEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2982) },
                    { 96, 7, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2983), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2984), "KONYAALTI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2984) },
                    { 97, 7, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2985), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2986), "KORKUTELİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2985) },
                    { 98, 7, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2986), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2987), "KUMLUCA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2987) },
                    { 99, 7, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2988), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2989), "MANAVGAT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2988) },
                    { 100, 7, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2989), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2990), "MURATPAŞA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2990) },
                    { 101, 7, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2991), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2992), "SERİK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2991) },
                    { 102, 8, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2993), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2993), "ARDANUÇ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2993) },
                    { 103, 8, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2994), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2995), "ARHAVİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2994) },
                    { 104, 8, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2996), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2997), "BORÇKA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2997) },
                    { 105, 8, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2998), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2999), "HOPA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2998) },
                    { 106, 8, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(2999), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3000), "KEMALPAŞA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3000) },
                    { 107, 8, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3001), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3002), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3001) },
                    { 108, 8, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3002), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3003), "MURGUL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3003) },
                    { 109, 8, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3004), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3005), "ŞAVŞAT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3004) },
                    { 110, 8, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3005), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3006), "YUSUFELİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3006) },
                    { 111, 9, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3007), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3008), "BOZDOĞAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3007) },
                    { 112, 9, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3008), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3009), "BUHARKENT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3009) },
                    { 113, 9, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3011), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3012), "ÇİNE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3011) },
                    { 114, 9, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3012), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3013), "DİDİM", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3013) },
                    { 115, 9, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3014), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3015), "EFELER", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3014) },
                    { 116, 9, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3015), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3016), "GERMENCİK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3016) },
                    { 117, 9, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3017), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3018), "İNCİRLİOVA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3017) },
                    { 118, 9, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3018), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3019), "KARACASU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3019) },
                    { 119, 9, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3020), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3021), "KARPUZLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3020) },
                    { 120, 9, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3021), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3022), "KOÇARLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3022) },
                    { 121, 9, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3023), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3024), "KÖŞK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3023) },
                    { 122, 9, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3024), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3025), "KUŞADASI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3025) },
                    { 123, 9, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3026), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3027), "KUYUCAK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3026) },
                    { 124, 9, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3027), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3028), "NAZİLLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3028) },
                    { 125, 9, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3029), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3030), "SÖKE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3029) },
                    { 126, 9, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3030), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3031), "SULTANHİSAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3031) },
                    { 127, 9, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3032), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3033), "YENİPAZAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3032) },
                    { 128, 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3034), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3034), "ALTIEYLÜL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3034) },
                    { 129, 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3036), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3036), "AYVALIK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3036) },
                    { 130, 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3067), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3068), "BALYA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3067) },
                    { 131, 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3068), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3069), "BANDIRMA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3069) },
                    { 132, 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3070), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3071), "BİGADİÇ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3070) },
                    { 133, 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3071), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3072), "BURHANİYE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3072) },
                    { 134, 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3075), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3076), "DURSUNBEY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3076) },
                    { 135, 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3077), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3077), "EDREMİT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3077) },
                    { 136, 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3078), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3079), "ERDEK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3079) },
                    { 137, 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3080), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3081), "GÖMEÇ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3080) },
                    { 138, 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3081), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3082), "GÖNEN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3082) },
                    { 139, 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3083), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3084), "HAVRAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3083) },
                    { 140, 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3084), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3085), "İVRİNDİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3085) },
                    { 141, 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3086), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3087), "KARESİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3086) },
                    { 142, 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3087), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3088), "KEPSUT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3088) },
                    { 143, 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3089), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3090), "MANYAS", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3089) },
                    { 144, 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3091), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3092), "MARMARA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3092) },
                    { 145, 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3093), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3093), "SAVAŞTEPE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3093) },
                    { 146, 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3094), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3095), "SINDIRGI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3095) },
                    { 147, 10, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3096), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3097), "SUSURLUK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3096) },
                    { 148, 11, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3097), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3098), "BOZÜYÜK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3098) },
                    { 149, 11, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3099), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3100), "GÖLPAZARI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3099) },
                    { 150, 11, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3100), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3101), "İNHİSAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3101) },
                    { 151, 11, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3102), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3103), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3102) },
                    { 152, 11, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3103), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3104), "OSMANELİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3104) },
                    { 153, 11, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3105), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3106), "PAZARYERİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3105) },
                    { 154, 11, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3107), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3107), "SÖĞÜT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3107) },
                    { 155, 11, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3108), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3109), "YENİPAZAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3108) },
                    { 156, 12, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3110), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3110), "ADAKLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3110) },
                    { 157, 12, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3111), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3112), "GENÇ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3112) },
                    { 158, 12, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3113), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3113), "KARLIOVA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3113) },
                    { 159, 12, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3114), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3115), "KİĞI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3115) },
                    { 160, 12, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3116), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3117), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3116) },
                    { 161, 12, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3117), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3118), "SOLHAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3118) },
                    { 162, 12, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3119), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3120), "YAYLADERE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3119) },
                    { 163, 12, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3120), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3121), "YEDİSU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3121) },
                    { 164, 13, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3122), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3123), "ADİLCEVAZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3122) },
                    { 165, 13, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3123), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3124), "AHLAT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3124) },
                    { 166, 13, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3125), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3126), "GÜROYMAK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3125) },
                    { 167, 13, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3126), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3127), "HİZAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3127) },
                    { 168, 13, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3128), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3129), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3128) },
                    { 169, 13, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3129), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3130), "MUTKİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3130) },
                    { 170, 13, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3131), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3132), "TATVAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3131) },
                    { 171, 14, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3132), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3133), "DÖRTDİVAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3133) },
                    { 172, 14, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3134), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3135), "GEREDE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3134) },
                    { 173, 14, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3136), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3136), "GÖYNÜK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3136) },
                    { 174, 14, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3138), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3139), "KIBRISCIK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3138) },
                    { 175, 14, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3139), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3140), "MENGEN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3140) },
                    { 176, 14, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3141), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3142), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3141) },
                    { 177, 14, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3142), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3143), "MUDURNU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3143) },
                    { 178, 14, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3144), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3145), "SEBEN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3144) },
                    { 179, 14, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3146), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3146), "YENİÇAĞA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3146) },
                    { 180, 15, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3147), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3148), "AĞLASUN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3147) },
                    { 181, 15, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3149), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3149), "ALTINYAYLA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3149) },
                    { 182, 15, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3150), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3151), "BUCAK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3150) },
                    { 183, 15, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3152), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3152), "ÇAVDIR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3152) },
                    { 184, 15, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3153), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3154), "ÇELTİKÇİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3154) },
                    { 185, 15, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3155), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3155), "GÖLHİSAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3155) },
                    { 186, 15, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3156), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3157), "KARAMANLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3157) },
                    { 187, 15, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3158), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3159), "KEMER", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3158) },
                    { 188, 15, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3159), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3160), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3160) },
                    { 189, 15, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3161), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3162), "TEFENNİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3161) },
                    { 190, 15, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3162), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3163), "YEŞİLOVA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3163) },
                    { 191, 16, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3164), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3165), "BÜYÜKORHAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3164) },
                    { 192, 16, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3165), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3166), "GEMLİK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3166) },
                    { 193, 16, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3167), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3168), "GÜRSU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3167) },
                    { 194, 16, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3168), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3169), "HARMANCIK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3169) },
                    { 195, 16, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3170), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3171), "İNEGÖL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3170) },
                    { 196, 16, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3171), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3172), "İZNİK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3172) },
                    { 197, 16, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3173), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3174), "KARACABEY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3173) },
                    { 198, 16, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3174), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3175), "KELES", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3175) },
                    { 199, 16, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3176), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3177), "KESTEL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3176) },
                    { 200, 16, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3177), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3178), "MUDANYA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3178) },
                    { 201, 16, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3179), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3180), "MUSTAFAKEMALPAŞA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3179) },
                    { 202, 16, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3180), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3181), "NİLÜFER", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3181) },
                    { 203, 16, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3210), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3214), "ORHANELİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3213) },
                    { 204, 16, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3214), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3215), "ORHANGAZİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3215) },
                    { 205, 16, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3217), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3218), "OSMANGAZİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3217) },
                    { 206, 16, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3218), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3219), "YENİŞEHİR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3219) },
                    { 207, 16, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3220), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3221), "YILDIRIM", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3220) },
                    { 208, 17, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3221), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3222), "AYVACIK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3222) },
                    { 209, 17, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3223), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3224), "BAYRAMİÇ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3223) },
                    { 210, 17, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3224), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3225), "BİGA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3225) },
                    { 211, 17, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3226), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3227), "BOZCAADA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3226) },
                    { 212, 17, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3227), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3228), "ÇAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3228) },
                    { 213, 17, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3229), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3230), "ECEABAT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3229) },
                    { 214, 17, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3230), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3231), "EZİNE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3231) },
                    { 215, 17, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3232), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3233), "GELİBOLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3232) },
                    { 216, 17, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3233), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3234), "GÖKÇEADA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3234) },
                    { 217, 17, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3235), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3236), "LAPSEKİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3235) },
                    { 218, 17, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3236), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3237), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3237) },
                    { 219, 17, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3238), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3239), "YENİCE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3238) },
                    { 220, 18, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3239), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3240), "ATKARACALAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3240) },
                    { 221, 18, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3241), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3242), "BAYRAMÖREN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3241) },
                    { 222, 18, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3242), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3243), "ÇERKEŞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3243) },
                    { 223, 18, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3244), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3245), "ELDİVAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3244) },
                    { 224, 18, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3245), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3246), "ILGAZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3246) },
                    { 225, 18, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3247), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3248), "KIZILIRMAK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3247) },
                    { 226, 18, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3248), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3249), "KORGUN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3249) },
                    { 227, 18, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3250), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3251), "KURŞUNLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3250) },
                    { 228, 18, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3251), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3252), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3252) },
                    { 229, 18, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3253), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3254), "ORTA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3253) },
                    { 230, 18, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3254), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3255), "ŞABANÖZÜ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3255) },
                    { 231, 18, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3256), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3257), "YAPRAKLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3256) },
                    { 232, 19, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3257), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3258), "ALACA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3258) },
                    { 233, 19, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3259), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3260), "BAYAT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3259) },
                    { 234, 19, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3260), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3261), "BOĞAZKALE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3261) },
                    { 235, 19, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3262), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3263), "DODURGA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3262) },
                    { 236, 19, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3264), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3265), "İSKİLİP", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3265) },
                    { 237, 19, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3266), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3266), "KARGI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3266) },
                    { 238, 19, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3267), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3268), "LAÇİN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3268) },
                    { 239, 19, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3269), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3269), "MECİTÖZÜ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3269) },
                    { 240, 19, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3270), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3271), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3271) },
                    { 241, 19, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3272), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3273), "OĞUZLAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3272) },
                    { 242, 19, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3273), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3274), "ORTAKÖY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3274) },
                    { 243, 19, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3275), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3276), "OSMANCIK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3275) },
                    { 244, 19, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3276), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3277), "SUNGURLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3277) },
                    { 245, 19, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3278), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3279), "UĞURLUDAĞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3278) },
                    { 246, 20, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3279), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3280), "ACIPAYAM", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3280) },
                    { 247, 20, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3281), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3282), "BABADAĞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3281) },
                    { 248, 20, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3282), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3283), "BAKLAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3283) },
                    { 249, 20, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3284), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3285), "BEKİLLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3284) },
                    { 250, 20, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3285), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3286), "BEYAĞAÇ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3286) },
                    { 251, 20, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3287), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3288), "BOZKURT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3287) },
                    { 252, 20, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3288), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3289), "BULDAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3289) },
                    { 253, 20, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3290), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3291), "ÇAL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3290) },
                    { 254, 20, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3291), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3292), "ÇAMELİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3292) },
                    { 255, 20, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3293), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3294), "ÇARDAK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3293) },
                    { 256, 20, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3294), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3295), "ÇİVRİL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3295) },
                    { 257, 20, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3296), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3297), "GÜNEY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3296) },
                    { 258, 20, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3297), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3298), "HONAZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3298) },
                    { 259, 20, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3299), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3300), "KALE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3299) },
                    { 260, 20, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3300), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3301), "MERKEZEFENDİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3301) },
                    { 261, 20, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3302), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3303), "PAMUKKALE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3302) },
                    { 262, 20, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3303), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3304), "SARAYKÖY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3304) },
                    { 263, 20, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3305), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3306), "SERİNHİSAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3305) },
                    { 264, 20, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3306), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3307), "TAVAS", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3307) },
                    { 265, 21, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3308), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3309), "BAĞLAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3308) },
                    { 266, 21, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3310), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3311), "BİSMİL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3311) },
                    { 267, 21, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3312), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3313), "ÇERMİK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3312) },
                    { 268, 21, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3314), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3314), "ÇINAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3314) },
                    { 269, 21, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3315), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3316), "ÇÜNGÜŞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3315) },
                    { 270, 21, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3317), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3317), "DİCLE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3317) },
                    { 271, 21, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3318), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3319), "EĞİL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3318) },
                    { 272, 21, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3320), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3320), "ERGANİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3320) },
                    { 273, 21, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3321), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3322), "HANİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3321) },
                    { 274, 21, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3323), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3323), "HAZRO", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3323) },
                    { 275, 21, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3324), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3325), "KAYAPINAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3324) },
                    { 276, 21, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3374), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3375), "KOCAKÖY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3375) },
                    { 277, 21, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3376), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3377), "KULP", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3377) },
                    { 278, 21, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3378), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3379), "LİCE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3378) },
                    { 279, 21, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3379), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3380), "SİLVAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3380) },
                    { 280, 21, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3381), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3382), "SUR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3381) },
                    { 281, 21, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3382), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3383), "YENİŞEHİR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3383) },
                    { 282, 22, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3384), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3385), "ENEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3384) },
                    { 283, 22, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3385), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3386), "HAVSA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3386) },
                    { 284, 22, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3387), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3388), "İPSALA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3387) },
                    { 285, 22, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3388), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3389), "KEŞAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3389) },
                    { 286, 22, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3390), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3391), "LALAPAŞA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3390) },
                    { 287, 22, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3391), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3392), "MERİÇ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3392) },
                    { 288, 22, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3393), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3394), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3393) },
                    { 289, 22, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3394), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3395), "SÜLOĞLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3395) },
                    { 290, 22, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3396), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3397), "UZUNKÖPRÜ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3396) },
                    { 291, 23, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3397), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3398), "AĞIN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3398) },
                    { 292, 23, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3399), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3400), "ALACAKAYA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3399) },
                    { 293, 23, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3400), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3401), "ARICAK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3401) },
                    { 294, 23, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3402), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3403), "BASKİL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3402) },
                    { 295, 23, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3403), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3404), "KARAKOÇAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3404) },
                    { 296, 23, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3405), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3406), "KEBAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3406) },
                    { 297, 23, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3408), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3409), "KOVANCILAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3408) },
                    { 298, 23, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3409), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3410), "MADEN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3410) },
                    { 299, 23, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3411), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3412), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3411) },
                    { 300, 23, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3412), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3413), "PALU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3413) },
                    { 301, 23, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3414), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3415), "SİVRİCE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3414) },
                    { 302, 24, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3415), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3416), "ÇAYIRLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3416) },
                    { 303, 24, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3417), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3418), "İLİÇ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3417) },
                    { 304, 24, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3418), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3419), "KEMAH", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3419) },
                    { 305, 24, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3420), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3421), "KEMALİYE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3420) },
                    { 306, 24, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3421), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3422), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3422) },
                    { 307, 24, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3423), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3424), "OTLUKBELİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3423) },
                    { 308, 24, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3424), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3425), "REFAHİYE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3425) },
                    { 309, 24, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3426), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3427), "TERCAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3426) },
                    { 310, 24, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3427), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3428), "ÜZÜMLÜ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3428) },
                    { 311, 25, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3429), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3430), "AŞKALE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3429) },
                    { 312, 25, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3431), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3431), "AZİZİYE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3431) },
                    { 313, 25, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3432), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3433), "ÇAT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3433) },
                    { 314, 25, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3434), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3435), "HINIS", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3434) },
                    { 315, 25, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3435), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3436), "HORASAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3436) },
                    { 316, 25, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3437), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3438), "İSPİR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3437) },
                    { 317, 25, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3438), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3439), "KARAÇOBAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3439) },
                    { 318, 25, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3440), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3441), "KARAYAZI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3440) },
                    { 319, 25, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3441), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3442), "KÖPRÜKÖY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3442) },
                    { 320, 25, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3443), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3444), "NARMAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3443) },
                    { 321, 25, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3444), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3445), "OLTU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3445) },
                    { 322, 25, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3446), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3447), "OLUR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3446) },
                    { 323, 25, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3447), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3448), "PALANDÖKEN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3448) },
                    { 324, 25, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3449), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3450), "PASİNLER", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3449) },
                    { 325, 25, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3450), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3451), "PAZARYOLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3451) },
                    { 326, 25, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3452), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3453), "ŞENKAYA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3452) },
                    { 327, 25, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3454), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3455), "TEKMAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3454) },
                    { 328, 25, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3456), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3456), "TORTUM", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3456) },
                    { 329, 25, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3457), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3458), "UZUNDERE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3457) },
                    { 330, 25, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3459), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3459), "YAKUTİYE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3459) },
                    { 331, 26, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3460), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3461), "ALPU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3460) },
                    { 332, 26, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3462), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3463), "BEYLİKOVA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3462) },
                    { 333, 26, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3463), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3464), "ÇİFTELER", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3464) },
                    { 334, 26, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3465), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3466), "GÜNYÜZÜ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3465) },
                    { 335, 26, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3466), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3467), "HAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3467) },
                    { 336, 26, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3468), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3469), "İNÖNÜ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3468) },
                    { 337, 26, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3469), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3470), "MAHMUDİYE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3470) },
                    { 338, 26, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3471), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3472), "MİHALGAZİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3471) },
                    { 339, 26, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3472), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3473), "MİHALIÇÇIK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3473) },
                    { 340, 26, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3474), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3475), "ODUNPAZARI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3474) },
                    { 341, 26, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3475), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3476), "SARICAKAYA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3476) },
                    { 342, 26, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3477), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3478), "SEYİTGAZİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3477) },
                    { 343, 26, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3478), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3479), "SİVRİHİSAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3479) },
                    { 344, 26, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3480), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3481), "TEPEBAŞI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3480) },
                    { 345, 27, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3481), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3482), "ARABAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3482) },
                    { 346, 27, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3483), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3484), "İSLAHİYE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3483) },
                    { 347, 27, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3484), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3485), "KARKAMIŞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3485) },
                    { 348, 27, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3486), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3487), "NİZİP", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3486) },
                    { 349, 27, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3516), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3517), "NURDAĞI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3517) },
                    { 350, 27, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3518), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3519), "OĞUZELİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3519) },
                    { 351, 27, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3520), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3521), "ŞAHİNBEY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3520) },
                    { 352, 27, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3521), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3522), "ŞEHİTKAMİL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3522) },
                    { 353, 27, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3523), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3524), "YAVUZELİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3523) },
                    { 354, 28, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3524), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3525), "ALUCRA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3525) },
                    { 355, 28, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3526), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3527), "BULANCAK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3526) },
                    { 356, 28, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3527), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3528), "ÇAMOLUK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3528) },
                    { 357, 28, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3529), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3530), "ÇANAKÇI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3529) },
                    { 358, 28, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3531), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3532), "DERELİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3532) },
                    { 359, 28, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3533), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3534), "DOĞANKENT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3533) },
                    { 360, 28, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3534), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3535), "ESPİYE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3535) },
                    { 361, 28, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3536), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3537), "EYNESİL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3536) },
                    { 362, 28, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3537), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3538), "GÖRELE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3538) },
                    { 363, 28, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3539), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3540), "GÜCE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3539) },
                    { 364, 28, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3540), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3541), "KEŞAP", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3541) },
                    { 365, 28, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3542), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3543), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3542) },
                    { 366, 28, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3543), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3544), "PİRAZİZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3544) },
                    { 367, 28, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3545), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3546), "ŞEBİNKARAHİSAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3545) },
                    { 368, 28, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3546), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3547), "TİREBOLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3547) },
                    { 369, 28, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3548), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3549), "YAĞLIDERE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3548) },
                    { 370, 29, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3549), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3550), "KELKİT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3550) },
                    { 371, 29, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3551), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3552), "KÖSE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3551) },
                    { 372, 29, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3552), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3553), "KÜRTÜN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3553) },
                    { 373, 29, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3554), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3555), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3554) },
                    { 374, 29, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3555), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3556), "ŞİRAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3556) },
                    { 375, 29, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3557), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3558), "TORUL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3557) },
                    { 376, 30, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3558), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3559), "ÇUKURCA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3559) },
                    { 377, 30, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3560), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3561), "DERECİK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3560) },
                    { 378, 30, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3561), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3562), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3562) },
                    { 379, 30, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3563), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3564), "ŞEMDİNLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3563) },
                    { 380, 30, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3564), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3565), "YÜKSEKOVA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3565) },
                    { 381, 31, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3566), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3567), "ALTINÖZÜ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3566) },
                    { 382, 31, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3567), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3568), "ANTAKYA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3568) },
                    { 383, 31, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3569), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3570), "ARSUZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3569) },
                    { 384, 31, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3570), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3571), "BELEN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3571) },
                    { 385, 31, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3572), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3573), "DEFNE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3572) },
                    { 386, 31, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3574), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3574), "DÖRTYOL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3574) },
                    { 387, 31, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3575), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3576), "ERZİN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3576) },
                    { 388, 31, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3578), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3578), "HASSA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3578) },
                    { 389, 31, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3579), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3580), "İSKENDERUN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3579) },
                    { 390, 31, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3581), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3581), "KIRIKHAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3581) },
                    { 391, 31, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3582), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3583), "KUMLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3582) },
                    { 392, 31, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3584), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3584), "PAYAS", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3584) },
                    { 393, 31, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3585), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3586), "REYHANLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3586) },
                    { 394, 31, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3587), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3587), "SAMANDAĞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3587) },
                    { 395, 31, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3588), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3589), "YAYLADAĞI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3589) },
                    { 396, 32, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3590), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3590), "AKSU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3590) },
                    { 397, 32, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3591), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3592), "ATABEY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3592) },
                    { 398, 32, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3593), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3593), "EĞİRDİR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3593) },
                    { 399, 32, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3594), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3595), "GELENDOST", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3595) },
                    { 400, 32, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3596), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3596), "GÖNEN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3596) },
                    { 401, 32, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3597), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3598), "KEÇİBORLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3598) },
                    { 402, 32, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3599), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3599), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3599) },
                    { 403, 32, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3600), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3601), "SENİRKENT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3601) },
                    { 404, 32, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3602), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3603), "SÜTÇÜLER", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3602) },
                    { 405, 32, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3603), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3604), "ŞARKİKARAAĞAÇ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3604) },
                    { 406, 32, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3605), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3606), "ULUBORLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3605) },
                    { 407, 32, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3606), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3607), "YALVAÇ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3607) },
                    { 408, 32, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3608), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3609), "YENİŞARBADEMLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3608) },
                    { 409, 33, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3609), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3610), "AKDENİZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3610) },
                    { 410, 33, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3611), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3612), "ANAMUR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3611) },
                    { 411, 33, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3612), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3613), "AYDINCIK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3613) },
                    { 412, 33, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3614), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3615), "BOZYAZI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3614) },
                    { 413, 33, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3615), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3616), "ÇAMLIYAYLA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3616) },
                    { 414, 33, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3618), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3618), "ERDEMLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3618) },
                    { 415, 33, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3619), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3620), "GÜLNAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3619) },
                    { 416, 33, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3621), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3621), "MEZİTLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3621) },
                    { 417, 33, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3622), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3623), "MUT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3622) },
                    { 418, 33, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3624), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3624), "SİLİFKE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3624) },
                    { 419, 33, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3625), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3626), "TARSUS", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3625) },
                    { 420, 33, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3627), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3627), "TOROSLAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3627) },
                    { 421, 33, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3659), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3660), "YENİŞEHİR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3660) },
                    { 422, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3661), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3662), "ADALAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3662) },
                    { 423, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3663), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3664), "ARNAVUTKÖY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3663) },
                    { 424, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3664), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3665), "ATAŞEHİR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3665) },
                    { 425, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3666), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3667), "AVCILAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3666) },
                    { 426, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3667), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3668), "BAĞCILAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3668) },
                    { 427, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3669), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3670), "BAHÇELİEVLER", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3669) },
                    { 428, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3670), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3671), "BAKIRKÖY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3671) },
                    { 429, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3672), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3673), "BAŞAKŞEHİR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3672) },
                    { 430, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3673), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3674), "BAYRAMPAŞA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3674) },
                    { 431, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3675), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3676), "BEŞİKTAŞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3675) },
                    { 432, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3677), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3677), "BEYKOZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3677) },
                    { 433, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3678), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3679), "BEYLİKDÜZÜ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3678) },
                    { 434, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3680), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3680), "BEYOĞLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3680) },
                    { 435, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3681), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3682), "BÜYÜKÇEKMECE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3681) },
                    { 436, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3683), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3683), "ÇATALCA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3683) },
                    { 437, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3684), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3685), "ÇEKMEKÖY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3685) },
                    { 438, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3686), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3686), "ESENLER", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3686) },
                    { 439, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3687), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3688), "ESENYURT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3688) },
                    { 440, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3689), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3689), "EYÜPSULTAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3689) },
                    { 441, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3690), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3691), "FATİH", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3691) },
                    { 442, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3692), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3693), "GAZİOSMANPAŞA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3692) },
                    { 443, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3693), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3694), "GÜNGÖREN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3694) },
                    { 444, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3695), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3696), "KADIKÖY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3695) },
                    { 445, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3696), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3697), "KAĞITHANE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3697) },
                    { 446, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3698), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3699), "KARTAL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3698) },
                    { 447, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3699), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3700), "KÜÇÜKÇEKMECE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3700) },
                    { 448, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3701), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3702), "MALTEPE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3701) },
                    { 449, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3703), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3704), "PENDİK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3704) },
                    { 450, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3705), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3705), "SANCAKTEPE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3705) },
                    { 451, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3706), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3707), "SARIYER", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3707) },
                    { 452, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3708), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3708), "SİLİVRİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3708) },
                    { 453, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3709), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3710), "SULTANBEYLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3710) },
                    { 454, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3711), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3711), "SULTANGAZİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3711) },
                    { 455, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3712), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3713), "ŞİLE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3713) },
                    { 456, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3714), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3714), "ŞİŞLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3714) },
                    { 457, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3715), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3716), "TUZLA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3716) },
                    { 458, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3717), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3718), "ÜMRANİYE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3717) },
                    { 459, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3718), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3719), "ÜSKÜDAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3719) },
                    { 460, 34, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3720), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3721), "ZEYTİNBURNU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3720) },
                    { 461, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3721), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3722), "ALİAĞA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3722) },
                    { 462, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3723), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3724), "BALÇOVA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3723) },
                    { 463, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3724), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3725), "BAYINDIR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3725) },
                    { 464, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3726), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3727), "BAYRAKLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3726) },
                    { 465, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3727), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3728), "BERGAMA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3728) },
                    { 466, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3729), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3730), "BEYDAĞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3729) },
                    { 467, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3730), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3731), "BORNOVA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3731) },
                    { 468, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3732), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3733), "BUCA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3732) },
                    { 469, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3733), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3734), "ÇEŞME", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3734) },
                    { 470, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3735), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3736), "ÇİĞLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3735) },
                    { 471, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3736), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3737), "DİKİLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3737) },
                    { 472, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3738), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3739), "FOÇA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3738) },
                    { 473, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3740), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3740), "GAZİEMİR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3740) },
                    { 474, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3741), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3742), "GÜZELBAHÇE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3741) },
                    { 475, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3743), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3743), "KARABAĞLAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3743) },
                    { 476, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3744), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3745), "KARABURUN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3744) },
                    { 477, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3746), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3746), "KARŞIYAKA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3746) },
                    { 478, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3747), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3748), "KEMALPAŞA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3748) },
                    { 479, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3749), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3750), "KINIK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3749) },
                    { 480, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3751), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3752), "KİRAZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3751) },
                    { 481, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3752), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3753), "KONAK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3753) },
                    { 482, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3754), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3755), "MENDERES", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3754) },
                    { 483, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3755), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3756), "MENEMEN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3756) },
                    { 484, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3757), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3758), "NARLIDERE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3758) },
                    { 485, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3759), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3759), "ÖDEMİŞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3759) },
                    { 486, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3760), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3761), "SEFERİHİSAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3761) },
                    { 487, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3762), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3763), "SELÇUK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3762) },
                    { 488, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3763), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3764), "TİRE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3764) },
                    { 489, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3765), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3766), "TORBALI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3765) },
                    { 490, 35, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3766), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3767), "URLA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3767) },
                    { 491, 36, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3768), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3769), "AKYAKA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3768) },
                    { 492, 36, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3769), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3770), "ARPAÇAY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3770) },
                    { 493, 36, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3771), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3772), "DİGOR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3771) },
                    { 494, 36, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3801), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3802), "KAĞIZMAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3802) },
                    { 495, 36, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3803), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3804), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3803) },
                    { 496, 36, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3804), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3805), "SARIKAMIŞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3805) },
                    { 497, 36, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3806), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3807), "SELİM", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3806) },
                    { 498, 36, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3807), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3808), "SUSUZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3808) },
                    { 499, 37, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3809), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3810), "ABANA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3809) },
                    { 500, 37, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3810), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3811), "AĞLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3811) },
                    { 501, 37, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3812), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3813), "ARAÇ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3812) },
                    { 502, 37, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3814), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3814), "AZDAVAY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3814) },
                    { 503, 37, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3815), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3816), "BOZKURT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3816) },
                    { 504, 37, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3817), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3817), "CİDE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3817) },
                    { 505, 37, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3818), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3819), "ÇATALZEYTİN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3819) },
                    { 506, 37, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3820), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3820), "DADAY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3820) },
                    { 507, 37, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3821), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3822), "DEVREKANİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3822) },
                    { 508, 37, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3823), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3824), "DOĞANYURT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3823) },
                    { 509, 37, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3824), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3825), "HANÖNÜ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3825) },
                    { 510, 37, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3826), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3827), "İHSANGAZİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3826) },
                    { 511, 37, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3828), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3829), "İNEBOLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3829) },
                    { 512, 37, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3830), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3831), "KÜRE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3830) },
                    { 513, 37, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3831), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3832), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3832) },
                    { 514, 37, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3833), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3834), "PINARBAŞI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3833) },
                    { 515, 37, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3834), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3835), "SEYDİLER", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3835) },
                    { 516, 37, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3836), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3837), "ŞENPAZAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3836) },
                    { 517, 37, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3837), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3838), "TAŞKÖPRÜ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3838) },
                    { 518, 37, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3839), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3840), "TOSYA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3839) },
                    { 519, 38, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3840), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3841), "AKKIŞLA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3841) },
                    { 520, 38, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3842), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3843), "BÜNYAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3842) },
                    { 521, 38, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3843), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3844), "DEVELİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3844) },
                    { 522, 38, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3845), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3846), "FELAHİYE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3845) },
                    { 523, 38, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3847), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3847), "HACILAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3847) },
                    { 524, 38, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3848), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3849), "İNCESU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3848) },
                    { 525, 38, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3850), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3850), "KOCASİNAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3850) },
                    { 526, 38, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3851), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3852), "MELİKGAZİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3851) },
                    { 527, 38, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3853), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3853), "ÖZVATAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3853) },
                    { 528, 38, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3854), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3855), "PINARBAŞI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3855) },
                    { 529, 38, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3856), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3856), "SARIOĞLAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3856) },
                    { 530, 38, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3857), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3858), "SARIZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3858) },
                    { 531, 38, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3859), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3860), "TALAS", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3859) },
                    { 532, 38, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3860), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3861), "TOMARZA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3861) },
                    { 533, 38, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3862), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3863), "YAHYALI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3862) },
                    { 534, 38, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3863), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3864), "YEŞİLHİSAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3864) },
                    { 535, 39, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3865), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3866), "BABAESKİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3865) },
                    { 536, 39, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3866), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3867), "DEMİRKÖY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3867) },
                    { 537, 39, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3868), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3869), "KOFÇAZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3868) },
                    { 538, 39, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3869), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3870), "LÜLEBURGAZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3870) },
                    { 539, 39, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3871), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3872), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3871) },
                    { 540, 39, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3872), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3873), "PEHLİVANKÖY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3873) },
                    { 541, 39, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3877), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3877), "PINARHİSAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3877) },
                    { 542, 39, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3878), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3879), "VİZE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3879) },
                    { 543, 40, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3880), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3880), "AKÇAKENT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3880) },
                    { 544, 40, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3881), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3882), "AKPINAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3882) },
                    { 545, 40, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3883), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3883), "BOZTEPE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3883) },
                    { 546, 40, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3884), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3885), "ÇİÇEKDAĞI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3885) },
                    { 547, 40, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3886), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3886), "KAMAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3886) },
                    { 548, 40, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3887), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3888), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3888) },
                    { 549, 40, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3889), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3889), "MUCUR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3889) },
                    { 550, 41, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3890), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3891), "BAŞİSKELE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3891) },
                    { 551, 41, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3892), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3893), "ÇAYIROVA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3892) },
                    { 552, 41, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3893), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3894), "DARICA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3894) },
                    { 553, 41, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3895), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3896), "DERİNCE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3895) },
                    { 554, 41, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3896), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3897), "DİLOVASI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3897) },
                    { 555, 41, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3898), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3899), "GEBZE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3898) },
                    { 556, 41, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3899), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3900), "GÖLCÜK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3900) },
                    { 557, 41, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3901), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3902), "İZMİT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3901) },
                    { 558, 41, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3902), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3903), "KANDIRA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3903) },
                    { 559, 41, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3904), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3905), "KARAMÜRSEL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3904) },
                    { 560, 41, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3905), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3906), "KARTEPE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3906) },
                    { 561, 41, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3907), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3908), "KÖRFEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3907) },
                    { 562, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3908), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3909), "AHIRLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3909) },
                    { 563, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3910), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3911), "AKÖREN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3910) },
                    { 564, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3911), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3912), "AKŞEHİR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3912) },
                    { 565, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3913), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3914), "ALTINEKİN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3913) },
                    { 566, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3914), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3915), "BEYŞEHİR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3915) },
                    { 567, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3945), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3946), "BOZKIR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3946) },
                    { 568, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3947), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3948), "CİHANBEYLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3947) },
                    { 569, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3948), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3949), "ÇELTİK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3949) },
                    { 570, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3950), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3951), "ÇUMRA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3950) },
                    { 571, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3951), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3952), "DERBENT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3952) },
                    { 572, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3956), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3957), "DEREBUCAK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3957) },
                    { 573, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3958), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3959), "DOĞANHİSAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3958) },
                    { 574, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3959), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3960), "EMİRGAZİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3960) },
                    { 575, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3961), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3962), "EREĞLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3961) },
                    { 576, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3963), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3963), "GÜNEYSINIR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3963) },
                    { 577, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3964), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3965), "HADİM", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3964) },
                    { 578, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3966), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3966), "HALKAPINAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3966) },
                    { 579, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3967), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3968), "HÜYÜK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3967) },
                    { 580, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3969), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3969), "ILGIN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3969) },
                    { 581, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3970), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3971), "KADINHANI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3970) },
                    { 582, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3972), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3972), "KARAPINAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3972) },
                    { 583, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3973), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3974), "KARATAY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3973) },
                    { 584, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3975), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3975), "KULU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3975) },
                    { 585, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3976), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3977), "MERAM", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3976) },
                    { 586, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3978), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3978), "SARAYÖNÜ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3978) },
                    { 587, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3979), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3980), "SELÇUKLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3980) },
                    { 588, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3981), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3982), "SEYDİŞEHİR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3981) },
                    { 589, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3982), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3983), "TAŞKENT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3983) },
                    { 590, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3984), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3985), "TUZLUKÇU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3984) },
                    { 591, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3985), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3986), "YALIHÜYÜK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3986) },
                    { 592, 42, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3987), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3988), "YUNAK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3987) },
                    { 593, 43, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3988), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3989), "ALTINTAŞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3989) },
                    { 594, 43, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3990), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3991), "ASLANAPA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3990) },
                    { 595, 43, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3991), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3992), "ÇAVDARHİSAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3992) },
                    { 596, 43, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3993), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3994), "DOMANİÇ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3993) },
                    { 597, 43, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3994), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3995), "DUMLUPINAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3995) },
                    { 598, 43, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3996), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3997), "EMET", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3996) },
                    { 599, 43, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3997), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3998), "GEDİZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3998) },
                    { 600, 43, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3999), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4000), "HİSARCIK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(3999) },
                    { 601, 43, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4000), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4001), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4001) },
                    { 602, 43, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4003), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4003), "PAZARLAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4003) },
                    { 603, 43, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4004), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4005), "SİMAV", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4005) },
                    { 604, 43, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4006), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4007), "ŞAPHANE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4006) },
                    { 605, 43, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4007), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4008), "TAVŞANLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4008) },
                    { 606, 44, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4009), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4010), "AKÇADAĞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4009) },
                    { 607, 44, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4010), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4011), "ARAPGİR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4011) },
                    { 608, 44, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4012), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4013), "ARGUVAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4012) },
                    { 609, 44, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4013), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4014), "BATTALGAZİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4014) },
                    { 610, 44, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4015), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4016), "DARENDE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4015) },
                    { 611, 44, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4016), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4017), "DOĞANŞEHİR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4017) },
                    { 612, 44, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4018), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4019), "DOĞANYOL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4018) },
                    { 613, 44, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4019), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4020), "HEKİMHAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4020) },
                    { 614, 44, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4021), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4022), "KALE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4021) },
                    { 615, 44, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4022), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4023), "KULUNCAK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4023) },
                    { 616, 44, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4024), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4025), "PÜTÜRGE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4024) },
                    { 617, 44, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4025), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4026), "YAZIHAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4026) },
                    { 618, 44, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4027), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4028), "YEŞİLYURT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4027) },
                    { 619, 45, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4029), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4029), "AHMETLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4029) },
                    { 620, 45, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4030), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4031), "AKHİSAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4030) },
                    { 621, 45, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4032), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4032), "ALAŞEHİR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4032) },
                    { 622, 45, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4033), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4034), "DEMİRCİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4034) },
                    { 623, 45, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4035), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4035), "GÖLMARMARA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4035) },
                    { 624, 45, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4036), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4037), "GÖRDES", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4037) },
                    { 625, 45, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4038), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4039), "KIRKAĞAÇ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4038) },
                    { 626, 45, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4039), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4040), "KÖPRÜBAŞI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4040) },
                    { 627, 45, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4041), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4042), "KULA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4041) },
                    { 628, 45, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4042), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4043), "SALİHLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4043) },
                    { 629, 45, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4044), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4045), "SARIGÖL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4044) },
                    { 630, 45, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4045), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4046), "SARUHANLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4046) },
                    { 631, 45, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4047), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4048), "SELENDİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4047) },
                    { 632, 45, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4048), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4049), "SOMA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4049) },
                    { 633, 45, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4051), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4051), "ŞEHZADELER", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4051) },
                    { 634, 45, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4052), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4053), "TURGUTLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4053) },
                    { 635, 45, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4054), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4054), "YUNUSEMRE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4054) },
                    { 636, 46, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4055), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4056), "AFŞİN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4056) },
                    { 637, 46, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4057), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4057), "ANDIRIN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4057) },
                    { 638, 46, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4058), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4059), "ÇAĞLAYANCERİT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4059) },
                    { 639, 46, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4060), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4061), "DULKADİROĞLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4060) },
                    { 640, 46, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4093), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4094), "EKİNÖZÜ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4094) },
                    { 641, 46, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4095), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4096), "ELBİSTAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4096) },
                    { 642, 46, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4097), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4098), "GÖKSUN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4097) },
                    { 643, 46, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4098), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4099), "NURHAK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4099) },
                    { 644, 46, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4100), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4101), "ONİKİŞUBAT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4100) },
                    { 645, 46, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4101), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4102), "PAZARCIK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4102) },
                    { 646, 46, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4103), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4104), "TÜRKOĞLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4103) },
                    { 647, 47, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4104), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4105), "ARTUKLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4105) },
                    { 648, 47, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4106), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4107), "DARGEÇİT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4106) },
                    { 649, 47, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4107), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4108), "DERİK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4108) },
                    { 650, 47, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4109), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4110), "KIZILTEPE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4109) },
                    { 651, 47, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4110), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4111), "MAZIDAĞI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4111) },
                    { 652, 47, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4112), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4113), "MİDYAT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4112) },
                    { 653, 47, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4113), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4114), "NUSAYBİN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4114) },
                    { 654, 47, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4115), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4116), "ÖMERLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4115) },
                    { 655, 47, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4116), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4117), "SAVUR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4117) },
                    { 656, 47, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4118), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4119), "YEŞİLLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4118) },
                    { 657, 48, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4120), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4120), "BODRUM", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4120) },
                    { 658, 48, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4121), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4122), "DALAMAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4122) },
                    { 659, 48, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4123), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4123), "DATÇA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4123) },
                    { 660, 48, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4124), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4125), "FETHİYE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4125) },
                    { 661, 48, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4126), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4127), "KAVAKLIDERE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4126) },
                    { 662, 48, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4127), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4128), "KÖYCEĞİZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4128) },
                    { 663, 48, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4130), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4130), "MARMARİS", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4130) },
                    { 664, 48, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4131), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4132), "MENTEŞE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4132) },
                    { 665, 48, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4133), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4133), "MİLAS", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4133) },
                    { 666, 48, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4134), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4135), "ORTACA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4135) },
                    { 667, 48, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4136), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4136), "SEYDİKEMER", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4136) },
                    { 668, 48, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4137), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4138), "ULA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4138) },
                    { 669, 48, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4139), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4140), "YATAĞAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4139) },
                    { 670, 49, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4140), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4141), "BULANIK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4141) },
                    { 671, 49, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4142), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4143), "HASKÖY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4142) },
                    { 672, 49, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4143), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4170), "KORKUT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4144) },
                    { 673, 49, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4174), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4175), "MALAZGİRT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4175) },
                    { 674, 49, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4176), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4177), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4177) },
                    { 675, 49, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4178), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4179), "VARTO", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4179) },
                    { 676, 50, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4180), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4181), "ACIGÖL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4180) },
                    { 677, 50, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4182), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4183), "AVANOS", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4182) },
                    { 678, 50, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4185), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4186), "DERİNKUYU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4186) },
                    { 679, 50, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4187), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4188), "GÜLŞEHİR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4188) },
                    { 680, 50, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4189), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4190), "HACIBEKTAŞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4189) },
                    { 681, 50, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4191), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4192), "KOZAKLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4191) },
                    { 682, 50, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4192), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4193), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4193) },
                    { 683, 50, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4194), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4196), "ÜRGÜP", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4195) },
                    { 684, 51, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4196), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4197), "ALTUNHİSAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4197) },
                    { 685, 51, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4198), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4199), "BOR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4199) },
                    { 686, 51, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4200), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4201), "ÇAMARDI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4201) },
                    { 687, 51, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4202), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4203), "ÇİFTLİK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4202) },
                    { 688, 51, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4204), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4204), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4204) },
                    { 689, 51, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4205), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4207), "ULUKIŞLA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4206) },
                    { 690, 52, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4208), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4209), "AKKUŞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4208) },
                    { 691, 52, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4209), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4210), "ALTINORDU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4210) },
                    { 692, 52, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4212), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4213), "AYBASTI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4213) },
                    { 693, 52, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4214), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4215), "ÇAMAŞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4215) },
                    { 694, 52, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4217), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4218), "ÇATALPINAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4217) },
                    { 695, 52, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4218), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4219), "ÇAYBAŞI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4219) },
                    { 696, 52, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4220), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4221), "FATSA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4220) },
                    { 697, 52, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4221), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4222), "GÖLKÖY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4222) },
                    { 698, 52, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4223), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4224), "GÜLYALI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4223) },
                    { 699, 52, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4224), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4225), "GÜRGENTEPE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4225) },
                    { 700, 52, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4226), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4227), "İKİZCE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4226) },
                    { 701, 52, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4227), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4228), "KABADÜZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4228) },
                    { 702, 52, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4229), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4230), "KABATAŞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4229) },
                    { 703, 52, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4230), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4231), "KORGAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4231) },
                    { 704, 52, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4232), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4233), "KUMRU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4232) },
                    { 705, 52, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4233), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4234), "MESUDİYE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4234) },
                    { 706, 52, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4235), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4236), "PERŞEMBE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4235) },
                    { 707, 52, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4236), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4237), "ULUBEY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4237) },
                    { 708, 52, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4238), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4239), "ÜNYE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4238) },
                    { 709, 53, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4239), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4240), "ARDEŞEN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4240) },
                    { 710, 53, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4241), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4242), "ÇAMLIHEMŞİN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4241) },
                    { 711, 53, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4243), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4243), "ÇAYELİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4243) },
                    { 712, 53, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4244), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4245), "DEREPAZARI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4244) },
                    { 713, 53, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4282), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4283), "FINDIKLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4282) },
                    { 714, 53, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4283), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4284), "GÜNEYSU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4284) },
                    { 715, 53, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4285), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4286), "HEMŞİN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4285) },
                    { 716, 53, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4286), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4287), "İKİZDERE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4287) },
                    { 717, 53, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4288), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4289), "İYİDERE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4288) },
                    { 718, 53, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4289), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4290), "KALKANDERE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4290) },
                    { 719, 53, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4291), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4292), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4291) },
                    { 720, 53, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4292), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4293), "PAZAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4293) },
                    { 721, 54, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4294), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4295), "ADAPAZARI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4294) },
                    { 722, 54, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4296), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4296), "AKYAZI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4296) },
                    { 723, 54, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4297), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4298), "ARİFİYE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4297) },
                    { 724, 54, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4299), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4299), "ERENLER", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4299) },
                    { 725, 54, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4301), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4302), "FERİZLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4301) },
                    { 726, 54, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4303), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4303), "GEYVE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4303) },
                    { 727, 54, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4304), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4305), "HENDEK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4304) },
                    { 728, 54, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4306), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4306), "KARAPÜRÇEK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4306) },
                    { 729, 54, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4307), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4308), "KARASU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4308) },
                    { 730, 54, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4309), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4309), "KAYNARCA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4309) },
                    { 731, 54, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4310), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4311), "KOCAALİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4311) },
                    { 732, 54, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4312), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4312), "PAMUKOVA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4312) },
                    { 733, 54, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4313), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4314), "SAPANCA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4314) },
                    { 734, 54, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4315), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4316), "SERDİVAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4315) },
                    { 735, 54, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4316), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4317), "SÖĞÜTLÜ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4317) },
                    { 736, 54, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4318), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4319), "TARAKLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4318) },
                    { 737, 55, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4319), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4320), "ALAÇAM", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4320) },
                    { 738, 55, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4321), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4322), "ASARCIK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4321) },
                    { 739, 55, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4322), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4323), "ATAKUM", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4323) },
                    { 740, 55, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4324), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4325), "AYVACIK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4324) },
                    { 741, 55, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4325), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4326), "BAFRA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4326) },
                    { 742, 55, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4327), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4328), "CANİK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4327) },
                    { 743, 55, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4329), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4329), "ÇARŞAMBA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4329) },
                    { 744, 55, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4330), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4331), "HAVZA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4331) },
                    { 745, 55, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4332), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4333), "İLKADIM", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4332) },
                    { 746, 55, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4333), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4334), "KAVAK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4334) },
                    { 747, 55, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4335), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4336), "LADİK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4335) },
                    { 748, 55, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4336), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4337), "SALIPAZARI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4337) },
                    { 749, 55, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4338), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4339), "TEKKEKÖY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4338) },
                    { 750, 55, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4339), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4340), "TERME", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4340) },
                    { 751, 55, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4341), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4342), "VEZİRKÖPRÜ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4341) },
                    { 752, 55, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4342), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4343), "YAKAKENT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4343) },
                    { 753, 55, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4344), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4345), "19 MAYIS", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4344) },
                    { 754, 56, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4345), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4346), "BAYKAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4346) },
                    { 755, 56, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4347), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4348), "ERUH", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4347) },
                    { 756, 56, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4349), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4350), "KURTALAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4350) },
                    { 757, 56, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4351), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4352), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4351) },
                    { 758, 56, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4352), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4353), "PERVARİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4353) },
                    { 759, 56, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4354), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4355), "ŞİRVAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4354) },
                    { 760, 56, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4355), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4356), "TİLLO", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4356) },
                    { 761, 57, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4357), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4358), "AYANCIK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4357) },
                    { 762, 57, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4358), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4359), "BOYABAT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4359) },
                    { 763, 57, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4360), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4361), "DİKMEN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4360) },
                    { 764, 57, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4362), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4362), "DURAĞAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4362) },
                    { 765, 57, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4363), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4364), "ERFELEK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4363) },
                    { 766, 57, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4365), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4365), "GERZE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4365) },
                    { 767, 57, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4366), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4367), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4366) },
                    { 768, 57, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4368), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4368), "SARAYDÜZÜ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4368) },
                    { 769, 57, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4369), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4370), "TÜRKELİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4370) },
                    { 770, 58, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4371), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4372), "AKINCILAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4371) },
                    { 771, 58, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4372), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4373), "ALTINYAYLA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4373) },
                    { 772, 58, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4374), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4375), "DİVRİĞİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4374) },
                    { 773, 58, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4375), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4376), "DOĞANŞAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4376) },
                    { 774, 58, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4377), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4378), "GEMEREK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4377) },
                    { 775, 58, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4378), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4379), "GÖLOVA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4379) },
                    { 776, 58, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4380), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4381), "GÜRÜN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4380) },
                    { 777, 58, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4381), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4382), "HAFİK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4382) },
                    { 778, 58, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4383), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4384), "İMRANLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4383) },
                    { 779, 58, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4384), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4385), "KANGAL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4385) },
                    { 780, 58, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4386), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4387), "KOYULHİSAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4386) },
                    { 781, 58, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4387), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4388), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4388) },
                    { 782, 58, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4389), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4390), "SUŞEHRİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4389) },
                    { 783, 58, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4390), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4391), "ŞARKIŞLA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4391) },
                    { 784, 58, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4392), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4393), "ULAŞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4392) },
                    { 785, 58, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4393), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4394), "YILDIZELİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4394) },
                    { 786, 58, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4425), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4426), "ZARA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4426) },
                    { 787, 59, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4427), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4428), "ÇERKEZKÖY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4427) },
                    { 788, 59, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4428), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4429), "ÇORLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4429) },
                    { 789, 59, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4430), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4431), "ERGENE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4430) },
                    { 790, 59, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4432), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4432), "HAYRABOLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4432) },
                    { 791, 59, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4433), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4434), "KAPAKLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4433) },
                    { 792, 59, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4435), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4435), "MALKARA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4435) },
                    { 793, 59, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4436), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4437), "MARMARAEREĞLİSİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4436) },
                    { 794, 59, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4438), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4438), "MURATLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4438) },
                    { 795, 59, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4439), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4440), "SARAY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4439) },
                    { 796, 59, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4441), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4442), "SÜLEYMANPAŞA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4441) },
                    { 797, 59, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4442), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4443), "ŞARKÖY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4443) },
                    { 798, 60, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4444), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4445), "ALMUS", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4444) },
                    { 799, 60, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4445), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4446), "ARTOVA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4446) },
                    { 800, 60, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4447), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4448), "BAŞÇİFTLİK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4447) },
                    { 801, 60, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4448), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4449), "ERBAA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4449) },
                    { 802, 60, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4450), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4451), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4450) },
                    { 803, 60, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4451), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4452), "NİKSAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4452) },
                    { 804, 60, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4453), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4454), "PAZAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4453) },
                    { 805, 60, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4454), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4455), "REŞADİYE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4455) },
                    { 806, 60, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4456), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4457), "SULUSARAY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4456) },
                    { 807, 60, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4457), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4458), "TURHAL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4458) },
                    { 808, 60, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4459), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4460), "YEŞİLYURT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4459) },
                    { 809, 60, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4460), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4461), "ZİLE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4461) },
                    { 810, 61, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4462), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4463), "AKÇAABAT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4462) },
                    { 811, 61, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4463), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4464), "ARAKLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4464) },
                    { 812, 61, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4465), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4466), "ARSİN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4465) },
                    { 813, 61, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4466), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4467), "BEŞİKDÜZÜ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4467) },
                    { 814, 61, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4468), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4469), "ÇARŞIBAŞI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4468) },
                    { 815, 61, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4469), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4470), "ÇAYKARA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4470) },
                    { 816, 61, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4471), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4472), "DERNEKPAZARI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4471) },
                    { 817, 61, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4473), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4474), "DÜZKÖY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4474) },
                    { 818, 61, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4475), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4476), "HAYRAT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4475) },
                    { 819, 61, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4476), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4477), "KÖPRÜBAŞI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4477) },
                    { 820, 61, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4478), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4479), "MAÇKA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4478) },
                    { 821, 61, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4479), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4480), "OF", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4480) },
                    { 822, 61, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4481), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4482), "ORTAHİSAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4481) },
                    { 823, 61, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4482), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4483), "SÜRMENE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4483) },
                    { 824, 61, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4484), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4485), "ŞALPAZARI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4484) },
                    { 825, 61, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4485), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4486), "TONYA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4486) },
                    { 826, 61, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4487), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4488), "VAKFIKEBİR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4487) },
                    { 827, 61, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4488), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4489), "YOMRA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4489) },
                    { 828, 62, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4490), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4491), "ÇEMİŞGEZEK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4490) },
                    { 829, 62, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4491), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4492), "HOZAT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4492) },
                    { 830, 62, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4493), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4494), "MAZGİRT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4493) },
                    { 831, 62, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4494), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4495), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4495) },
                    { 832, 62, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4496), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4497), "NAZIMİYE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4496) },
                    { 833, 62, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4497), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4498), "OVACIK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4498) },
                    { 834, 62, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4499), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4500), "PERTEK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4499) },
                    { 835, 62, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4500), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4501), "PÜLÜMÜR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4501) },
                    { 836, 63, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4502), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4503), "AKÇAKALE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4502) },
                    { 837, 63, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4504), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4504), "BİRECİK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4504) },
                    { 838, 63, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4505), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4506), "BOZOVA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4506) },
                    { 839, 63, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4507), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4507), "CEYLANPINAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4507) },
                    { 840, 63, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4508), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4509), "EYYÜBİYE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4508) },
                    { 841, 63, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4510), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4510), "HALFETİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4510) },
                    { 842, 63, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4511), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4512), "HALİLİYE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4511) },
                    { 843, 63, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4513), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4514), "HARRAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4513) },
                    { 844, 63, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4514), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4515), "HİLVAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4515) },
                    { 845, 63, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4516), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4516), "KARAKÖPRÜ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4516) },
                    { 846, 63, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4517), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4518), "SİVEREK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4518) },
                    { 847, 63, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4519), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4519), "SURUÇ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4519) },
                    { 848, 63, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4521), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4522), "VİRANŞEHİR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4521) },
                    { 849, 64, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4522), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4523), "BANAZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4523) },
                    { 850, 64, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4524), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4525), "EŞME", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4524) },
                    { 851, 64, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4525), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4526), "KARAHALLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4526) },
                    { 852, 64, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4527), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4528), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4527) },
                    { 853, 64, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4528), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4529), "SİVASLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4529) },
                    { 854, 64, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4530), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4531), "ULUBEY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4530) },
                    { 855, 65, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4531), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4532), "BAHÇESARAY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4532) },
                    { 856, 65, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4533), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4534), "BAŞKALE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4533) },
                    { 857, 65, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4534), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4535), "ÇALDIRAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4535) },
                    { 858, 65, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4536), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4537), "ÇATAK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4536) },
                    { 859, 65, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4589), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4590), "EDREMİT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4590) },
                    { 860, 65, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4591), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4592), "ERCİŞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4592) },
                    { 861, 65, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4593), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4594), "GEVAŞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4593) },
                    { 862, 65, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4594), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4595), "GÜRPINAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4595) },
                    { 863, 65, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4596), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4597), "İPEKYOLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4596) },
                    { 864, 65, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4598), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4598), "MURADİYE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4598) },
                    { 865, 65, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4599), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4600), "ÖZALP", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4599) },
                    { 866, 65, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4601), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4601), "SARAY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4601) },
                    { 867, 65, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4602), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4603), "TUŞBA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4602) },
                    { 868, 66, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4604), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4604), "AKDAĞMADENİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4604) },
                    { 869, 66, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4605), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4606), "AYDINCIK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4605) },
                    { 870, 66, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4607), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4607), "BOĞAZLIYAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4607) },
                    { 871, 66, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4608), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4609), "ÇANDIR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4608) },
                    { 872, 66, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4610), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4610), "ÇAYIRALAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4610) },
                    { 873, 66, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4611), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4612), "ÇEKEREK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4612) },
                    { 874, 66, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4613), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4613), "KADIŞEHRİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4613) },
                    { 875, 66, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4614), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4615), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4615) },
                    { 876, 66, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4616), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4616), "SARAYKENT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4616) },
                    { 877, 66, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4617), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4618), "SARIKAYA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4618) },
                    { 878, 66, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4619), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4619), "SORGUN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4619) },
                    { 879, 66, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4624), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4625), "ŞEFAATLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4624) },
                    { 880, 66, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4625), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4626), "YENİFAKILI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4626) },
                    { 881, 66, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4627), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4628), "YERKÖY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4627) },
                    { 882, 67, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4629), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4629), "ALAPLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4629) },
                    { 883, 67, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4630), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4631), "ÇAYCUMA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4630) },
                    { 884, 67, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4632), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4632), "DEVREK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4632) },
                    { 885, 67, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4633), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4634), "EREĞLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4633) },
                    { 886, 67, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4635), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4635), "GÖKÇEBEY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4635) },
                    { 887, 67, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4636), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4637), "KİLİMLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4636) },
                    { 888, 67, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4638), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4638), "KOZLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4638) },
                    { 889, 67, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4639), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4640), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4639) },
                    { 890, 68, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4641), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4641), "AĞAÇÖREN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4641) },
                    { 891, 68, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4642), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4643), "ESKİL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4642) },
                    { 892, 68, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4644), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4644), "GÜLAĞAÇ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4644) },
                    { 893, 68, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4645), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4646), "GÜZELYURT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4645) },
                    { 894, 68, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4647), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4647), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4647) },
                    { 895, 68, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4648), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4649), "ORTAKÖY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4648) },
                    { 896, 68, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4650), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4650), "SARIYAHŞİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4650) },
                    { 897, 68, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4651), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4652), "SULTANHANI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4652) },
                    { 898, 69, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4653), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4654), "AYDINTEPE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4653) },
                    { 899, 69, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4654), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4655), "DEMİRÖZÜ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4655) },
                    { 900, 69, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4656), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4657), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4656) },
                    { 901, 70, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4657), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4658), "AYRANCI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4658) },
                    { 902, 70, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4659), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4660), "BAŞYAYLA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4659) },
                    { 903, 70, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4660), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4661), "ERMENEK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4661) },
                    { 904, 70, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4662), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4663), "KAZIMKARABEKİR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4662) },
                    { 905, 70, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4663), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4664), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4664) },
                    { 906, 70, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4665), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4666), "SARIVELİLER", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4665) },
                    { 907, 71, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4666), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4667), "BAHŞİLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4667) },
                    { 908, 71, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4668), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4669), "BALIŞEYH", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4668) },
                    { 909, 71, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4669), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4670), "ÇELEBİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4670) },
                    { 910, 71, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4671), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4672), "DELİCE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4672) },
                    { 911, 71, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4673), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4674), "KARAKEÇİLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4673) },
                    { 912, 71, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4675), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4676), "KESKİN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4675) },
                    { 913, 71, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4676), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4677), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4677) },
                    { 914, 71, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4678), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4679), "SULAKYURT", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4678) },
                    { 915, 71, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4679), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4680), "YAHŞİHAN", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4680) },
                    { 916, 72, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4681), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4682), "BEŞİRİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4681) },
                    { 917, 72, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4682), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4683), "GERCÜŞ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4683) },
                    { 918, 72, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4684), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4685), "HASANKEYF", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4684) },
                    { 919, 72, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4685), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4686), "KOZLUK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4686) },
                    { 920, 72, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4687), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4688), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4687) },
                    { 921, 72, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4688), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4689), "SASON", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4689) },
                    { 922, 73, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4690), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4691), "BEYTÜŞŞEBAP", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4690) },
                    { 923, 73, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4691), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4692), "CİZRE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4692) },
                    { 924, 73, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4693), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4694), "GÜÇLÜKONAK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4693) },
                    { 925, 73, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4694), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4695), "İDİL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4695) },
                    { 926, 73, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4696), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4697), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4696) },
                    { 927, 73, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4697), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4698), "SİLOPİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4698) },
                    { 928, 73, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4699), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4700), "ULUDERE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4699) },
                    { 929, 74, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4700), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4701), "AMASRA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4701) },
                    { 930, 74, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4702), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4703), "KURUCAŞİLE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4702) },
                    { 931, 74, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4703), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4704), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4704) },
                    { 932, 74, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4734), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4735), "ULUS", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4735) },
                    { 933, 75, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4736), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4737), "ÇILDIR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4736) },
                    { 934, 75, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4738), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4738), "DAMAL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4738) },
                    { 935, 75, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4739), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4740), "GÖLE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4739) },
                    { 936, 75, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4741), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4741), "HANAK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4741) },
                    { 937, 75, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4742), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4743), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4743) },
                    { 938, 75, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4744), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4744), "POSOF", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4744) },
                    { 939, 76, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4745), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4746), "ARALIK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4746) },
                    { 940, 76, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4748), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4748), "KARAKOYUNLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4748) },
                    { 941, 76, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4749), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4750), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4750) },
                    { 942, 76, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4751), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4751), "TUZLUCA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4751) },
                    { 943, 77, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4752), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4753), "ALTINOVA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4753) },
                    { 944, 77, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4754), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4755), "ARMUTLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4754) },
                    { 945, 77, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4755), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4756), "ÇINARCIK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4756) },
                    { 946, 77, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4757), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4758), "ÇİFTLİKKÖY", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4757) },
                    { 947, 77, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4758), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4759), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4759) },
                    { 948, 77, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4760), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4761), "TERMAL", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4760) },
                    { 949, 78, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4761), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4762), "EFLANİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4762) },
                    { 950, 78, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4763), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4764), "ESKİPAZAR", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4763) },
                    { 951, 78, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4764), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4765), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4765) },
                    { 952, 78, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4766), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4767), "OVACIK", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4766) },
                    { 953, 78, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4767), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4768), "SAFRANBOLU", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4768) },
                    { 954, 78, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4769), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4770), "YENİCE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4769) },
                    { 955, 79, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4770), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4771), "ELBEYLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4771) },
                    { 956, 79, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4772), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4773), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4772) },
                    { 957, 79, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4773), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4774), "MUSABEYLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4774) },
                    { 958, 79, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4775), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4776), "POLATELİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4775) },
                    { 959, 80, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4776), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4777), "BAHÇE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4777) },
                    { 960, 80, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4778), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4779), "DÜZİÇİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4778) },
                    { 961, 80, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4779), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4780), "HASANBEYLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4780) },
                    { 962, 80, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4781), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4782), "KADİRLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4781) },
                    { 963, 80, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4782), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4783), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4783) },
                    { 964, 80, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4784), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4785), "SUMBAS", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4784) },
                    { 965, 80, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4785), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4786), "TOPRAKKALE", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4786) },
                    { 966, 81, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4787), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4788), "AKÇAKOCA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4787) },
                    { 967, 81, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4788), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4789), "CUMAYERİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4789) },
                    { 968, 81, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4790), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4791), "ÇİLİMLİ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4790) },
                    { 969, 81, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4791), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4792), "GÖLYAKA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4792) },
                    { 970, 81, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4793), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4794), "GÜMÜŞOVA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4793) },
                    { 971, 81, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4795), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4795), "KAYNAŞLI", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4795) },
                    { 972, 81, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4796), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4797), "MERKEZ", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4797) },
                    { 973, 81, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4798), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4798), "YIĞILCA", true, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(4798) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CityID", "CreatedDate", "DeletedDate", "DistrictID", "EmailConfirmationToken", "EmailConfirmed", "FailedLoginAttempts", "IsLocked", "LastLoginDate", "LockedUntil", "Mail", "Name", "Password", "ResetToken", "ResetTokenExpiry", "RoleID", "Status", "Surname", "UpdatedDate", "UserName" },
                values: new object[] { 1, 1, new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(6252), new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(6250), 1, null, false, 0, false, null, null, "busragunes@gmail.com", "Büşra", "$2a$12$hdNKsAO3bfSb9l7we/6Ww.rpkDzM5KjEBa09B6BfK5B/12.ZOVAt.", null, null, 1, true, "Güneş", new DateTime(2025, 10, 27, 15, 3, 38, 826, DateTimeKind.Local).AddTicks(6249), "busra" });

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
                name: "IX_CaseFileDefendant_CaseFileID",
                table: "CaseFileDefendant",
                column: "CaseFileID");

            migrationBuilder.CreateIndex(
                name: "IX_CaseFileDefendant_DefendantID",
                table: "CaseFileDefendant",
                column: "DefendantID");

            migrationBuilder.CreateIndex(
                name: "IX_CaseFileDocuments_CaseFileID",
                table: "CaseFileDocuments",
                column: "CaseFileID");

            migrationBuilder.CreateIndex(
                name: "IX_CaseFileDocuments_CaseFileID_Status",
                table: "CaseFileDocuments",
                columns: new[] { "CaseFileID", "Status" });

            migrationBuilder.CreateIndex(
                name: "IX_CaseFileDocuments_DocumentTypeID",
                table: "CaseFileDocuments",
                column: "DocumentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CaseFileDocuments_Status",
                table: "CaseFileDocuments",
                column: "Status");

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
                name: "IX_Expenses_CategoryID",
                table: "Expenses",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_UserID",
                table: "Expenses",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Hearings_CaseFileID",
                table: "Hearings",
                column: "CaseFileID");

            migrationBuilder.CreateIndex(
                name: "IX_Hearings_CourtID",
                table: "Hearings",
                column: "CourtID");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_CategoryID",
                table: "Incomes",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_UserID",
                table: "Incomes",
                column: "UserID");

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
                name: "CaseFileDocuments");

            migrationBuilder.DropTable(
                name: "CaseFileNotes");

            migrationBuilder.DropTable(
                name: "CaseFileShares");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Hearings");

            migrationBuilder.DropTable(
                name: "Incomes");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "Defendants");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "ExpenseCategories");

            migrationBuilder.DropTable(
                name: "CaseFiles");

            migrationBuilder.DropTable(
                name: "IncomeCategories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "ApplicationTypes");

            migrationBuilder.DropTable(
                name: "CaseTypes");

            migrationBuilder.DropTable(
                name: "Courts");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
