using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightWorldTour.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditFlightModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Flights",
                newName: "EndTime");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EndTime",
                table: "Flights",
                newName: "Type");
        }
    }
}
