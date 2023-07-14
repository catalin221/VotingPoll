using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VotingPoll.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PollNullableDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Polls",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Polls",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Polls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 21, 4, 11, 40, 619, DateTimeKind.Utc).AddTicks(1464), new DateTime(2023, 7, 14, 4, 11, 40, 619, DateTimeKind.Utc).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "Polls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 21, 4, 11, 40, 619, DateTimeKind.Utc).AddTicks(1492), new DateTime(2023, 7, 14, 4, 11, 40, 619, DateTimeKind.Utc).AddTicks(1492) });
        }
    }
}
