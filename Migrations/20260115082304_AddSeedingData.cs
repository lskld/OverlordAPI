using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OverlordAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Lairs",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Pacific Ocean", "Volcano Island" },
                    { 2, "Low Earth Orbit", "The Moon Base" },
                    { 3, "Mariana Trench", "Deep Sea Trench" }
                });

            migrationBuilder.InsertData(
                table: "Missions",
                columns: new[] { "Id", "Difficulty", "Title", "isCompleted" },
                values: new object[,]
                {
                    { 1, 10, "Steal the Moon", false },
                    { 2, 1, "Rig the Local Bingo", false },
                    { 3, 5, "Replace Clouds with Cotton Candy", false }
                });

            migrationBuilder.InsertData(
                table: "Minions",
                columns: new[] { "Id", "Description", "EvilLairId", "EvilLevel", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "", 1, 8, "Kevin", "Scientist" },
                    { 2, "", 1, 3, "Bob", "Soldier" },
                    { 3, "", 2, 6, "Dave", "Infiltrator" },
                    { 4, "", 3, 1, "Stuart", "Janitor" },
                    { 5, "", 2, 9, "Scarlett", "Mystic" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Minions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Minions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Minions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Minions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Minions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lairs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lairs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lairs",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
