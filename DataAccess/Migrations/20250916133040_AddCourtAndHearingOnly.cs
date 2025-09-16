using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddCourtAndHearingOnly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // SADECE YENİ TABLOLARI EKLE - mevcut tabloları sildin!

            // Court tablosu oluşturma
            migrationBuilder.CreateTable(
                name: "Courts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    DistrictID = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CourtType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
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
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Courts_Districts_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "Districts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            // Hearing tablosu oluşturma
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
                    Judge = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Clerk = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Result = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
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
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Hearings_Courts_CourtID",
                        column: x => x.CourtID,
                        principalTable: "Courts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            // CaseFiles tablosuna CourtID kolonu ekleme (eğer yoksa)
            migrationBuilder.AddColumn<int>(
                name: "CourtID",
                table: "CaseFiles",
                type: "int",
                nullable: true);

            // Index'ler
            migrationBuilder.CreateIndex(
                name: "IX_Courts_CityID",
                table: "Courts",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Courts_DistrictID",
                table: "Courts",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_Hearings_CaseFileID",
                table: "Hearings",
                column: "CaseFileID");

            migrationBuilder.CreateIndex(
                name: "IX_Hearings_CourtID",
                table: "Hearings",
                column: "CourtID");

            migrationBuilder.CreateIndex(
                name: "IX_CaseFiles_CourtID",
                table: "CaseFiles",
                column: "CourtID");

            // CaseFiles için Foreign Key
            migrationBuilder.AddForeignKey(
                name: "FK_CaseFiles_Courts_CourtID",
                table: "CaseFiles",
                column: "CourtID",
                principalTable: "Courts",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaseFiles_Courts_CourtID",
                table: "CaseFiles");

            migrationBuilder.DropTable(
                name: "Hearings");

            migrationBuilder.DropTable(
                name: "Courts");

            migrationBuilder.DropIndex(
                name: "IX_CaseFiles_CourtID",
                table: "CaseFiles");

            migrationBuilder.DropColumn(
                name: "CourtID",
                table: "CaseFiles");
        }

        /// <inheritdoc />
   
    }
}
