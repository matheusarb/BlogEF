using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogEF.Migrations
{
    /// <inheritdoc />
    public partial class PostLastUpdate_to_DateTimeNow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Post",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 29, 23, 9, 2, 201, DateTimeKind.Local).AddTicks(7643),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2024, 1, 30, 1, 57, 40, 363, DateTimeKind.Utc).AddTicks(1749));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Post",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 30, 1, 57, 40, 363, DateTimeKind.Utc).AddTicks(1749),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2024, 1, 29, 23, 9, 2, 201, DateTimeKind.Local).AddTicks(7643));
        }
    }
}
