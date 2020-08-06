using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaBooking.Migrations
{
    public partial class AddPropertyForTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "fromTime",
                table: "Times",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "toTime",
                table: "Times",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fromTime",
                table: "Times");

            migrationBuilder.DropColumn(
                name: "toTime",
                table: "Times");
        }
    }
}
