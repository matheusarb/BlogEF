using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogEF.Migrations
{
    /// <inheritdoc />
    public partial class AdicionadoCampoGithub : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Github",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Post",
                type: "SMALLDATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 29, 23, 43, 10, 642, DateTimeKind.Utc).AddTicks(1832),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldDefaultValue: new DateTime(2024, 1, 29, 23, 11, 38, 24, DateTimeKind.Utc).AddTicks(7686));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Github",
                table: "User");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Post",
                type: "SMALLDATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 29, 23, 11, 38, 24, DateTimeKind.Utc).AddTicks(7686),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldDefaultValue: new DateTime(2024, 1, 29, 23, 43, 10, 642, DateTimeKind.Utc).AddTicks(1832));
        }
    }
}
