using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnlineStore.Migrations
{
    /// <inheritdoc />
    public partial class SmallChangeInCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "RPG");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "RGP");
        }
    }
}
