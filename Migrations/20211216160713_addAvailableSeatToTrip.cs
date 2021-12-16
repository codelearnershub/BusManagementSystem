using Microsoft.EntityFrameworkCore.Migrations;

namespace BusManagementSystem.Migrations
{
    public partial class addAvailableSeatToTrip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AvailableSeat",
                table: "Trips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserType",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserType",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserType",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailableSeat",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "Admins");
        }
    }
}
