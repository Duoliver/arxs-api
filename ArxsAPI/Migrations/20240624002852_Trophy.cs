using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ArxsAPI.Migrations
{
    /// <inheritdoc />
    public partial class Trophy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:race_type", "main_race,sub_pre_qualify,pre_qualify,qualify_one,qualify_two,bottom_four")
                .Annotation("Npgsql:Enum:round_race_driver_status", "undefined,disqualified,classified,winner,retired,classified_retired")
                .Annotation("Npgsql:Enum:trophy_round_driver_status", "undefined,disqualified,classified,winner,did_not_qualify")
                .Annotation("Npgsql:Enum:trophy_type", "teams,drivers")
                .OldAnnotation("Npgsql:Enum:race_type", "main_race,sub_pre_qualify,pre_qualify,qualify_one,qualify_two,bottom_four")
                .OldAnnotation("Npgsql:Enum:round_race_driver_status", "undefined,disqualified,classified,winner,retired,classified_retired")
                .OldAnnotation("Npgsql:Enum:trophy_round_driver_status", "undefined,disqualified,classified,winner,did_not_qualify");

            migrationBuilder.AddColumn<int>(
                name: "trophy_id",
                table: "championship_season_trophy",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "trophy",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    type = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trophy", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_championship_season_trophy_trophy_id",
                table: "championship_season_trophy",
                column: "trophy_id");

            migrationBuilder.AddForeignKey(
                name: "FK_championship_season_trophy_trophy_trophy_id",
                table: "championship_season_trophy",
                column: "trophy_id",
                principalTable: "trophy",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_championship_season_trophy_trophy_trophy_id",
                table: "championship_season_trophy");

            migrationBuilder.DropTable(
                name: "trophy");

            migrationBuilder.DropIndex(
                name: "IX_championship_season_trophy_trophy_id",
                table: "championship_season_trophy");

            migrationBuilder.DropColumn(
                name: "trophy_id",
                table: "championship_season_trophy");

            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:race_type", "main_race,sub_pre_qualify,pre_qualify,qualify_one,qualify_two,bottom_four")
                .Annotation("Npgsql:Enum:round_race_driver_status", "undefined,disqualified,classified,winner,retired,classified_retired")
                .Annotation("Npgsql:Enum:trophy_round_driver_status", "undefined,disqualified,classified,winner,did_not_qualify")
                .OldAnnotation("Npgsql:Enum:race_type", "main_race,sub_pre_qualify,pre_qualify,qualify_one,qualify_two,bottom_four")
                .OldAnnotation("Npgsql:Enum:round_race_driver_status", "undefined,disqualified,classified,winner,retired,classified_retired")
                .OldAnnotation("Npgsql:Enum:trophy_round_driver_status", "undefined,disqualified,classified,winner,did_not_qualify")
                .OldAnnotation("Npgsql:Enum:trophy_type", "teams,drivers");
        }
    }
}
