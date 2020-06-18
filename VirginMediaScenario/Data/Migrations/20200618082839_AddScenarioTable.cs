using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VirginMediaScenario.Data.Migrations
{
    public partial class AddScenarioTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "scenarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScenarioID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Forename = table.Column<string>(nullable: true),
                    UserID = table.Column<string>(nullable: true),
                    SampleDate = table.Column<DateTime>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    NumMonths = table.Column<int>(nullable: true),
                    MarketID = table.Column<int>(nullable: true),
                    NetworkLayerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scenarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "scenarios");
        }
    }
}
