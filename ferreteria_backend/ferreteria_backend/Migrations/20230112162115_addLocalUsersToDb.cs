using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ferreteriabackend.Migrations
{
    /// <inheritdoc />
    public partial class addLocalUsersToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "LocalUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 13, 21, 15, 183, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 13, 21, 15, 183, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 13, 21, 15, 183, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 13, 21, 15, 183, DateTimeKind.Local).AddTicks(382));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "LocalUsers");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 13, 3, 42, 223, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 13, 3, 42, 223, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 13, 3, 42, 223, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 13, 3, 42, 223, DateTimeKind.Local).AddTicks(4632));
        }
    }
}
