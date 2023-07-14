using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VotingPoll.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixTableReferencesFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Polls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsClosed = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VotesCount = table.Column<int>(type: "int", nullable: false),
                    PollId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Options_Polls_PollId",
                        column: x => x.PollId,
                        principalTable: "Polls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PollId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Polls_PollId",
                        column: x => x.PollId,
                        principalTable: "Polls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PollOption",
                columns: table => new
                {
                    PollId = table.Column<int>(type: "int", nullable: false),
                    OptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PollOption", x => new { x.PollId, x.OptionId });
                    table.ForeignKey(
                        name: "FK_PollOption_Options_OptionId",
                        column: x => x.OptionId,
                        principalTable: "Options",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PollOption_Polls_PollId",
                        column: x => x.PollId,
                        principalTable: "Polls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserOption",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OptionId = table.Column<int>(type: "int", nullable: false),
                    PollId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOption", x => new { x.UserId, x.OptionId, x.PollId });
                    table.ForeignKey(
                        name: "FK_UserOption_Options_OptionId",
                        column: x => x.OptionId,
                        principalTable: "Options",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserOption_Polls_PollId",
                        column: x => x.PollId,
                        principalTable: "Polls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserOption_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPoll",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PollId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPoll", x => new { x.UserId, x.PollId });
                    table.ForeignKey(
                        name: "FK_UserPoll_Polls_PollId",
                        column: x => x.PollId,
                        principalTable: "Polls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPoll_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Polls",
                columns: new[] { "Id", "Description", "EndDate", "IsClosed", "StartDate", "Title" },
                values: new object[,]
                {
                    { 1, "What is your favorite color?", new DateTime(2023, 7, 21, 4, 11, 40, 619, DateTimeKind.Utc).AddTicks(1464), false, new DateTime(2023, 7, 14, 4, 11, 40, 619, DateTimeKind.Utc).AddTicks(1463), "Favorite Color" },
                    { 2, "What is your favorite animal?", new DateTime(2023, 7, 21, 4, 11, 40, 619, DateTimeKind.Utc).AddTicks(1492), false, new DateTime(2023, 7, 14, 4, 11, 40, 619, DateTimeKind.Utc).AddTicks(1492), "Favorite Animal" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "PollId" },
                values: new object[,]
                {
                    { 1, "John", 0 },
                    { 2, "Jane", 0 }
                });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Id", "Name", "PollId", "VotesCount" },
                values: new object[,]
                {
                    { 1, "Red", 1, 0 },
                    { 2, "Blue", 1, 0 },
                    { 3, "Green", 1, 0 },
                    { 4, "Dog", 2, 0 },
                    { 5, "Cat", 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "UserPoll",
                columns: new[] { "PollId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "PollOption",
                columns: new[] { "OptionId", "PollId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 2 },
                    { 5, 2 }
                });

            migrationBuilder.InsertData(
                table: "UserOption",
                columns: new[] { "OptionId", "PollId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 4, 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Options_PollId",
                table: "Options",
                column: "PollId");

            migrationBuilder.CreateIndex(
                name: "IX_PollOption_OptionId",
                table: "PollOption",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOption_OptionId",
                table: "UserOption",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOption_PollId",
                table: "UserOption",
                column: "PollId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPoll_PollId",
                table: "UserPoll",
                column: "PollId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PollId",
                table: "Users",
                column: "PollId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PollOption");

            migrationBuilder.DropTable(
                name: "UserOption");

            migrationBuilder.DropTable(
                name: "UserPoll");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Polls");
        }
    }
}
