using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UpdateHistory.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Info",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    updateID = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    KBID = table.Column<string>(nullable: true),
                    MSRCSeverity = table.Column<string>(nullable: true),
                    MSRCNumber = table.Column<string>(nullable: true),
                    Classification = table.Column<string>(nullable: true),
                    Architecture = table.Column<string>(nullable: true),
                    SupportedProducts = table.Column<string>(nullable: true),
                    SupportedLanguages = table.Column<string>(nullable: true),
                    LastModified = table.Column<string>(nullable: true),
                    UpdateStatus = table.Column<string>(nullable: true),
                    TestResults = table.Column<string>(nullable: true),
                    ICW = table.Column<string>(nullable: true),
                    Server = table.Column<string>(nullable: true),
                    TestDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Info", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Info");
        }
    }
}
