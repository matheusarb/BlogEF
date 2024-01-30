using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogEF.Migrations
{
    /// <inheritdoc />
    public partial class AlterandoCreateDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Post",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 30, 1, 57, 40, 363, DateTimeKind.Utc).AddTicks(1749),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldDefaultValue: new DateTime(2024, 1, 29, 23, 43, 10, 642, DateTimeKind.Utc).AddTicks(1832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Post",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Post",
                type: "SMALLDATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 29, 23, 43, 10, 642, DateTimeKind.Utc).AddTicks(1832),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2024, 1, 30, 1, 57, 40, 363, DateTimeKind.Utc).AddTicks(1749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Post",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME");
        }
    }
}
