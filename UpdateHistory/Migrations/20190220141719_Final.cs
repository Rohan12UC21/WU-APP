using Microsoft.EntityFrameworkCore.Migrations;

namespace UpdateHistory.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ICW",
                table: "Server",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ICW",
                table: "Server");
        }
    }
}
