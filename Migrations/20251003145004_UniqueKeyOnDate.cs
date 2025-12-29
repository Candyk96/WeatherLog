using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeatherLog.Migrations
{
    /// <inheritdoc />
    public partial class UniqueKeyOnDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Weather_Date",
                table: "Weather",
                column: "Date",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Weather_Date",
                table: "Weather");
        }
    }
}
