using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ferreteriabackend.Migrations
{
    /// <inheritdoc />
    public partial class AddItemsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 12, 5, 53, 186, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 12, 5, 53, 186, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 12, 5, 53, 186, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 12, 12, 5, 53, 186, DateTimeKind.Local).AddTicks(4630));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 11, 17, 3, 0, 219, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 11, 17, 3, 0, 219, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 11, 17, 3, 0, 219, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 11, 17, 3, 0, 219, DateTimeKind.Local).AddTicks(2467));
        }
    }
}
