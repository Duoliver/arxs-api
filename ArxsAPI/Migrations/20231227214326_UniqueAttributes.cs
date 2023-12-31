using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArxsAPI.Migrations
{
    /// <inheritdoc />
    public partial class UniqueAttributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_team_name",
                table: "team",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_country_iso_3",
                table: "country",
                column: "iso_3",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_country_name",
                table: "country",
                column: "name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_team_name",
                table: "team");

            migrationBuilder.DropIndex(
                name: "IX_country_iso_3",
                table: "country");

            migrationBuilder.DropIndex(
                name: "IX_country_name",
                table: "country");
        }
    }
}
