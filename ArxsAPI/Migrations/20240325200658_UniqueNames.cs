using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArxsAPI.Migrations
{
    /// <inheritdoc />
    public partial class UniqueNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_score_system_alias",
                table: "score_system",
                column: "alias",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_championship_name",
                table: "championship",
                column: "name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_score_system_alias",
                table: "score_system");

            migrationBuilder.DropIndex(
                name: "IX_championship_name",
                table: "championship");
        }
    }
}
