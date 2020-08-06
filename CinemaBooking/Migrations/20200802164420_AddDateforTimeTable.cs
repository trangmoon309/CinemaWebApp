using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaBooking.Migrations
{
    public partial class AddDateforTimeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Times",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Times");
        }
    }
}
