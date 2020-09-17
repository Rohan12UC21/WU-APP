using Microsoft.EntityFrameworkCore.Migrations;

namespace UpdateHistory.Migrations
{
    public partial class NoAccessColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "NoAccess",
                table: "Server",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoAccess",
                table: "Server");
        }
    }
}
