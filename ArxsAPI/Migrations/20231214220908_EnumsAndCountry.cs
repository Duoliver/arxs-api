using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ArxsAPI.Migrations
{
    /// <inheritdoc />
    public partial class EnumsAndCountry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:race_type", "main_race,sub_pre_qualify,pre_qualify,qualify_one,qualify_two,bottom_four")
                .Annotation("Npgsql:Enum:round_race_driver_status", "undefined,disqualified,classified,winner,retired,classified_retired")
                .Annotation("Npgsql:Enum:trophy_round_driver_status", "undefined,disqualified,classified,winner,did_not_qualify");

            migrationBuilder.CreateTable(
                name: "country",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    iso_3 = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    adjective = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_country", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "country");
        }
    }
}
