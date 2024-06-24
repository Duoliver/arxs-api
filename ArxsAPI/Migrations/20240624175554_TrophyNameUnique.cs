using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArxsAPI.Migrations
{
    /// <inheritdoc />
    public partial class TrophyNameUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_trophy_name",
                table: "trophy",
                column: "name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_trophy_name",
                table: "trophy");
        }
    }
}
