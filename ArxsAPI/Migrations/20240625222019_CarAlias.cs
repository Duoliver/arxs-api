using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArxsAPI.Migrations
{
    /// <inheritdoc />
    public partial class CarAlias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "alias",
                table: "car",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_championship_alias",
                table: "championship",
                column: "alias",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_car_alias",
                table: "car",
                column: "alias",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_championship_alias",
                table: "championship");

            migrationBuilder.DropIndex(
                name: "IX_car_alias",
                table: "car");

            migrationBuilder.DropColumn(
                name: "alias",
                table: "car");
        }
    }
}
