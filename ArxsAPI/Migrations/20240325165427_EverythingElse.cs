using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ArxsAPI.Migrations
{
    /// <inheritdoc />
    public partial class EverythingElse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "championship",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    alias = table.Column<string>(type: "text", nullable: true),
                    predecessor_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_championship", x => x.id);
                    table.ForeignKey(
                        name: "FK_championship_championship_predecessor_id",
                        column: x => x.predecessor_id,
                        principalTable: "championship",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "score_system",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    alias = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_score_system", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "season",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    year = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_season", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "team_car",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    suffix = table.Column<string>(type: "text", nullable: true),
                    year = table.Column<int>(type: "integer", nullable: true),
                    car_model_id = table.Column<int>(type: "integer", nullable: false),
                    team_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_team_car", x => x.id);
                    table.ForeignKey(
                        name: "FK_team_car_car_car_model_id",
                        column: x => x.car_model_id,
                        principalTable: "car",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_team_car_team_team_id",
                        column: x => x.team_id,
                        principalTable: "team",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "score",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    position = table.Column<int>(type: "integer", nullable: false),
                    points_amount = table.Column<int>(type: "integer", nullable: false),
                    score_system_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_score", x => x.id);
                    table.ForeignKey(
                        name: "FK_score_score_system_score_system_id",
                        column: x => x.score_system_id,
                        principalTable: "score_system",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "championship_season",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    season_id = table.Column<int>(type: "integer", nullable: false),
                    championship_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_championship_season", x => x.id);
                    table.ForeignKey(
                        name: "FK_championship_season_championship_championship_id",
                        column: x => x.championship_id,
                        principalTable: "championship",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_championship_season_season_season_id",
                        column: x => x.season_id,
                        principalTable: "season",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "championship_season_round",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    championship_season_id = table.Column<int>(type: "integer", nullable: false),
                    track_configuration_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_championship_season_round", x => x.id);
                    table.ForeignKey(
                        name: "FK_championship_season_round_championship_season_championship_~",
                        column: x => x.championship_season_id,
                        principalTable: "championship_season",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_championship_season_round_track_configuration_track_configu~",
                        column: x => x.track_configuration_id,
                        principalTable: "track_configuration",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "championship_season_trophy",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    score_system_id = table.Column<int>(type: "integer", nullable: false),
                    championship_season_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_championship_season_trophy", x => x.id);
                    table.ForeignKey(
                        name: "FK_championship_season_trophy_championship_season_championship~",
                        column: x => x.championship_season_id,
                        principalTable: "championship_season",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_championship_season_trophy_score_system_score_system_id",
                        column: x => x.score_system_id,
                        principalTable: "score_system",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "team_championship_season",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    colour = table.Column<string>(type: "text", nullable: true),
                    team_id = table.Column<int>(type: "integer", nullable: false),
                    championship_season_id = table.Column<int>(type: "integer", nullable: false),
                    country_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_team_championship_season", x => x.id);
                    table.ForeignKey(
                        name: "FK_team_championship_season_championship_season_championship_s~",
                        column: x => x.championship_season_id,
                        principalTable: "championship_season",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_team_championship_season_country_country_id",
                        column: x => x.country_id,
                        principalTable: "country",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_team_championship_season_team_team_id",
                        column: x => x.team_id,
                        principalTable: "team",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "championship_season_round_race",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    order = table.Column<int>(type: "integer", nullable: false),
                    type = table.Column<int>(type: "integer", nullable: false),
                    lap_count = table.Column<int>(type: "integer", nullable: false),
                    round_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_championship_season_round_race", x => x.id);
                    table.ForeignKey(
                        name: "FK_championship_season_round_race_championship_season_round_ro~",
                        column: x => x.round_id,
                        principalTable: "championship_season_round",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "championship_season_trophy_round",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    order = table.Column<int>(type: "integer", nullable: false),
                    trophy_id = table.Column<int>(type: "integer", nullable: false),
                    round_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_championship_season_trophy_round", x => x.id);
                    table.ForeignKey(
                        name: "FK_championship_season_trophy_round_championship_season_round_~",
                        column: x => x.round_id,
                        principalTable: "championship_season_round",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_championship_season_trophy_round_championship_season_trophy~",
                        column: x => x.trophy_id,
                        principalTable: "championship_season_trophy",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "team_championship_season_driver",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    driver_id = table.Column<int>(type: "integer", nullable: false),
                    entry_id = table.Column<int>(type: "integer", nullable: false),
                    country_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_team_championship_season_driver", x => x.id);
                    table.ForeignKey(
                        name: "FK_team_championship_season_driver_country_country_id",
                        column: x => x.country_id,
                        principalTable: "country",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_team_championship_season_driver_driver_driver_id",
                        column: x => x.driver_id,
                        principalTable: "driver",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_team_championship_season_driver_team_championship_season_en~",
                        column: x => x.entry_id,
                        principalTable: "team_championship_season",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "team_championship_season_trophy",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    entry_id = table.Column<int>(type: "integer", nullable: false),
                    trophy_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_team_championship_season_trophy", x => x.id);
                    table.ForeignKey(
                        name: "FK_team_championship_season_trophy_championship_season_trophy_~",
                        column: x => x.trophy_id,
                        principalTable: "championship_season_trophy",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_team_championship_season_trophy_team_championship_season_en~",
                        column: x => x.entry_id,
                        principalTable: "team_championship_season",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "team_championship_season_driver_car",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    team_car_id = table.Column<int>(type: "integer", nullable: false),
                    driver_entry_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_team_championship_season_driver_car", x => x.id);
                    table.ForeignKey(
                        name: "FK_team_championship_season_driver_car_team_car_team_car_id",
                        column: x => x.team_car_id,
                        principalTable: "team_car",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_team_championship_season_driver_car_team_championship_seaso~",
                        column: x => x.driver_entry_id,
                        principalTable: "team_championship_season_driver",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "team_championship_season_driver_round_race",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    position = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    driver_entry_id = table.Column<int>(type: "integer", nullable: false),
                    round_race_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_team_championship_season_driver_round_race", x => x.id);
                    table.ForeignKey(
                        name: "FK_team_championship_season_driver_round_race_championship_sea~",
                        column: x => x.round_race_id,
                        principalTable: "championship_season_round_race",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_team_championship_season_driver_round_race_team_championshi~",
                        column: x => x.driver_entry_id,
                        principalTable: "team_championship_season_driver",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "team_championship_season_driver_trophy_round",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    position = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    driver_entry_id = table.Column<int>(type: "integer", nullable: false),
                    trophy_round_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_team_championship_season_driver_trophy_round", x => x.id);
                    table.ForeignKey(
                        name: "FK_team_championship_season_driver_trophy_round_championship_s~",
                        column: x => x.trophy_round_id,
                        principalTable: "championship_season_trophy_round",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_team_championship_season_driver_trophy_round_team_champions~",
                        column: x => x.trophy_round_id,
                        principalTable: "team_championship_season_driver",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_championship_predecessor_id",
                table: "championship",
                column: "predecessor_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_championship_season_championship_id",
                table: "championship_season",
                column: "championship_id");

            migrationBuilder.CreateIndex(
                name: "IX_championship_season_season_id",
                table: "championship_season",
                column: "season_id");

            migrationBuilder.CreateIndex(
                name: "IX_championship_season_round_championship_season_id",
                table: "championship_season_round",
                column: "championship_season_id");

            migrationBuilder.CreateIndex(
                name: "IX_championship_season_round_track_configuration_id",
                table: "championship_season_round",
                column: "track_configuration_id");

            migrationBuilder.CreateIndex(
                name: "IX_championship_season_round_race_round_id",
                table: "championship_season_round_race",
                column: "round_id");

            migrationBuilder.CreateIndex(
                name: "IX_championship_season_trophy_championship_season_id",
                table: "championship_season_trophy",
                column: "championship_season_id");

            migrationBuilder.CreateIndex(
                name: "IX_championship_season_trophy_score_system_id",
                table: "championship_season_trophy",
                column: "score_system_id");

            migrationBuilder.CreateIndex(
                name: "IX_championship_season_trophy_round_round_id",
                table: "championship_season_trophy_round",
                column: "round_id");

            migrationBuilder.CreateIndex(
                name: "IX_championship_season_trophy_round_trophy_id",
                table: "championship_season_trophy_round",
                column: "trophy_id");

            migrationBuilder.CreateIndex(
                name: "IX_score_score_system_id",
                table: "score",
                column: "score_system_id");

            migrationBuilder.CreateIndex(
                name: "IX_team_car_car_model_id",
                table: "team_car",
                column: "car_model_id");

            migrationBuilder.CreateIndex(
                name: "IX_team_car_team_id",
                table: "team_car",
                column: "team_id");

            migrationBuilder.CreateIndex(
                name: "IX_team_championship_season_championship_season_id",
                table: "team_championship_season",
                column: "championship_season_id");

            migrationBuilder.CreateIndex(
                name: "IX_team_championship_season_country_id",
                table: "team_championship_season",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "IX_team_championship_season_team_id",
                table: "team_championship_season",
                column: "team_id");

            migrationBuilder.CreateIndex(
                name: "IX_team_championship_season_driver_country_id",
                table: "team_championship_season_driver",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "IX_team_championship_season_driver_driver_id",
                table: "team_championship_season_driver",
                column: "driver_id");

            migrationBuilder.CreateIndex(
                name: "IX_team_championship_season_driver_entry_id",
                table: "team_championship_season_driver",
                column: "entry_id");

            migrationBuilder.CreateIndex(
                name: "IX_team_championship_season_driver_car_driver_entry_id",
                table: "team_championship_season_driver_car",
                column: "driver_entry_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_team_championship_season_driver_car_team_car_id",
                table: "team_championship_season_driver_car",
                column: "team_car_id");

            migrationBuilder.CreateIndex(
                name: "IX_team_championship_season_driver_round_race_driver_entry_id",
                table: "team_championship_season_driver_round_race",
                column: "driver_entry_id");

            migrationBuilder.CreateIndex(
                name: "IX_team_championship_season_driver_round_race_round_race_id",
                table: "team_championship_season_driver_round_race",
                column: "round_race_id");

            migrationBuilder.CreateIndex(
                name: "IX_team_championship_season_driver_trophy_round_trophy_round_id",
                table: "team_championship_season_driver_trophy_round",
                column: "trophy_round_id");

            migrationBuilder.CreateIndex(
                name: "IX_team_championship_season_trophy_entry_id",
                table: "team_championship_season_trophy",
                column: "entry_id");

            migrationBuilder.CreateIndex(
                name: "IX_team_championship_season_trophy_trophy_id",
                table: "team_championship_season_trophy",
                column: "trophy_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "score");

            migrationBuilder.DropTable(
                name: "team_championship_season_driver_car");

            migrationBuilder.DropTable(
                name: "team_championship_season_driver_round_race");

            migrationBuilder.DropTable(
                name: "team_championship_season_driver_trophy_round");

            migrationBuilder.DropTable(
                name: "team_championship_season_trophy");

            migrationBuilder.DropTable(
                name: "team_car");

            migrationBuilder.DropTable(
                name: "championship_season_round_race");

            migrationBuilder.DropTable(
                name: "championship_season_trophy_round");

            migrationBuilder.DropTable(
                name: "team_championship_season_driver");

            migrationBuilder.DropTable(
                name: "championship_season_round");

            migrationBuilder.DropTable(
                name: "championship_season_trophy");

            migrationBuilder.DropTable(
                name: "team_championship_season");

            migrationBuilder.DropTable(
                name: "score_system");

            migrationBuilder.DropTable(
                name: "championship_season");

            migrationBuilder.DropTable(
                name: "championship");

            migrationBuilder.DropTable(
                name: "season");
        }
    }
}
