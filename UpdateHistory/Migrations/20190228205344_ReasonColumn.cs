using Microsoft.EntityFrameworkCore.Migrations;

namespace UpdateHistory.Migrations
{
    public partial class ReasonColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "Info",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reason",
                table: "Info");
        }
    }
}
