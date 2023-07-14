using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VotingPoll.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNavigationProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PollOption_Options_OptionId",
                table: "PollOption");

            migrationBuilder.DropIndex(
                name: "IX_PollOption_OptionId",
                table: "PollOption");

            migrationBuilder.UpdateData(
                table: "Polls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 21, 4, 22, 35, 337, DateTimeKind.Utc).AddTicks(6203), new DateTime(2023, 7, 14, 4, 22, 35, 337, DateTimeKind.Utc).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "Polls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 21, 4, 22, 35, 337, DateTimeKind.Utc).AddTicks(6208), new DateTime(2023, 7, 14, 4, 22, 35, 337, DateTimeKind.Utc).AddTicks(6208) });

            migrationBuilder.AddForeignKey(
                name: "FK_PollOption_Options_PollId",
                table: "PollOption",
                column: "PollId",
                principalTable: "Options",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PollOption_Options_PollId",
                table: "PollOption");

            migrationBuilder.UpdateData(
                table: "Polls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 21, 4, 16, 10, 454, DateTimeKind.Utc).AddTicks(1071), new DateTime(2023, 7, 14, 4, 16, 10, 454, DateTimeKind.Utc).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "Polls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 21, 4, 16, 10, 454, DateTimeKind.Utc).AddTicks(1075), new DateTime(2023, 7, 14, 4, 16, 10, 454, DateTimeKind.Utc).AddTicks(1075) });

            migrationBuilder.CreateIndex(
                name: "IX_PollOption_OptionId",
                table: "PollOption",
                column: "OptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_PollOption_Options_OptionId",
                table: "PollOption",
                column: "OptionId",
                principalTable: "Options",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
