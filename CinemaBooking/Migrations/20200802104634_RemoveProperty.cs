using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaBooking.Migrations
{
    public partial class RemoveProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DurationTime",
                table: "Times");

            migrationBuilder.DropColumn(
                name: "toTime",
                table: "Times");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DurationTime",
                table: "Times",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "toTime",
                table: "Times",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
