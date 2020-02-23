using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace golink.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sites",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Alias = table.Column<string>(nullable: false),
                    Url = table.Column<string>(nullable: false),
                    Accessed = table.Column<int>(nullable: false),
                    LastTimeAccessed = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sites",
                columns: new[] { "Id", "Accessed", "Alias", "CreatedOn", "LastTimeAccessed", "ModifiedOn", "Url" },
                values: new object[] { 1, 0, "fb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://facebook.com" });

            migrationBuilder.InsertData(
                table: "Sites",
                columns: new[] { "Id", "Accessed", "Alias", "CreatedOn", "LastTimeAccessed", "ModifiedOn", "Url" },
                values: new object[] { 2, 0, "youtube", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://youtube.com" });

            migrationBuilder.InsertData(
                table: "Sites",
                columns: new[] { "Id", "Accessed", "Alias", "CreatedOn", "LastTimeAccessed", "ModifiedOn", "Url" },
                values: new object[] { 3, 0, "randomcat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://random.cat/" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sites");
        }
    }
}
