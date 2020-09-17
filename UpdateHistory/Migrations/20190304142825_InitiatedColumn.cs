using Microsoft.EntityFrameworkCore.Migrations;

namespace UpdateHistory.Migrations
{
    public partial class InitiatedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Initiated",
                table: "Server",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Initiated",
                table: "Server");
        }
    }
}
