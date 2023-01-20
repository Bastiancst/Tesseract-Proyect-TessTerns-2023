using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ferreteriabackend.Migrations
{
    /// <inheritdoc />
    public partial class SeedItemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "Name", "Price", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 11, 17, 3, 0, 219, DateTimeKind.Local).AddTicks(2437), "pega fuerte", "https://easycl.vtexassets.com/arquivos/ids/160093/120144.jpg?v=637527403541830000", "Martillo", 5000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 1, 11, 17, 3, 0, 219, DateTimeKind.Local).AddTicks(2463), "ta chido", "https://pimdatacdn.bahco.com/media/sub624/16a0ffdce467453f.png", "Destornillador", 4000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2023, 1, 11, 17, 3, 0, 219, DateTimeKind.Local).AddTicks(2465), "ta wena", "https://png.pngtree.com/element_our/20190602/ourlarge/pngtree-construction-tool-ruler-illustration-image_1425976.jpg", "Cinta de medir", 3000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2023, 1, 11, 17, 3, 0, 219, DateTimeKind.Local).AddTicks(2467), "NUEVO TALADRO PERCUTOR SKILL 6060 13 Mm 700WATTS VEL VARIABLE + ACCESORIOS MALETIN ELECTRICO HORMIGON ACERO SKILL", "https://pbs.twimg.com/media/EJ-h_niWoAEXN3e?format=jpg&name=medium", "Taladro Percutor Electrico Bauker", 34000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
