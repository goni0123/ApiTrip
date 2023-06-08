using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TripRegisterNewAPI.Migrations
{
    /// <inheritdoc />
    public partial class goni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Trailor_in",
                table: "routeIn",
                newName: "Trailor");

            migrationBuilder.RenameColumn(
                name: "City_in",
                table: "routeIn",
                newName: "City");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Trailor",
                table: "routeIn",
                newName: "Trailor_in");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "routeIn",
                newName: "City_in");
        }
    }
}
