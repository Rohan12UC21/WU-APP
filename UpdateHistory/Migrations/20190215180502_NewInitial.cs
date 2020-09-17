using Microsoft.EntityFrameworkCore.Migrations;

namespace UpdateHistory.Migrations
{
    public partial class NewInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastModified",
                table: "Info",
                newName: "LastReleased");

            migrationBuilder.AddColumn<bool>(
                name: "isIt",
                table: "Server",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Index",
                table: "Server",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "WindowsVersion",
                table: "Server",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RealtimeVersion",
                table: "Server",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Server",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Active",
                table: "Info",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isIt",
                table: "Server");

            migrationBuilder.DropColumn(
                name: "WindowsVersion",
                table: "Server");

            migrationBuilder.DropColumn(
                name: "RealtimeVersion",
                table: "Server");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Server");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Info");

            migrationBuilder.RenameColumn(
                name: "LastReleased",
                table: "Info",
                newName: "LastModified");
        }
    }
}
