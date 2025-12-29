using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeatherLog.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MorningTemp = table.Column<decimal>(type: "TEXT", nullable: true),
                    AfternoonTemp = table.Column<decimal>(type: "TEXT", nullable: true),
                    EveningTemp = table.Column<decimal>(type: "TEXT", nullable: true),
                    MaxTemp = table.Column<string>(type: "TEXT", nullable: true),
                    MinTemp = table.Column<string>(type: "TEXT", nullable: true),
                    AverageWind = table.Column<string>(type: "TEXT", nullable: true),
                    WindGust = table.Column<string>(type: "TEXT", nullable: true),
                    WindDirection = table.Column<string>(type: "TEXT", nullable: true),
                    Humidity = table.Column<int>(type: "INTEGER", nullable: true),
                    BasicInfo = table.Column<string>(type: "TEXT", nullable: true),
                    DetailedInfo = table.Column<string>(type: "TEXT", nullable: true),
                    OtherInfo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weather");
        }
    }
}
