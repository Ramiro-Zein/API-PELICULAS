using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_PELICULAS.Migrations
{
    /// <inheritdoc />
    public partial class Historial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Historiales",
                columns: new[] { "IdHistorial", "FechaVista", "IdPelicula", "IdUsuario" },
                values: new object[,]
                {
                    { new Guid("01234567-0123-0123-0123-0123456789d4"), new DateOnly(2024, 1, 15), new Guid("78901234-7890-7890-7890-7890123456a1"), new Guid("56789012-5678-5678-5678-5678901234ef") },
                    { new Guid("11234567-1123-1123-1123-1123456789e5"), new DateOnly(2024, 2, 20), new Guid("89012345-8901-8901-8901-8901234567b2"), new Guid("56789012-5678-5678-5678-5678901234ef") },
                    { new Guid("21234567-2123-2123-2123-2123456789f6"), new DateOnly(2024, 3, 10), new Guid("90123456-9012-9012-9012-9012345678c3"), new Guid("67890123-6789-6789-6789-6789012345f0") },
                    { new Guid("31234567-3123-3123-3123-3123456789a7"), new DateOnly(2024, 4, 5), new Guid("78901234-7890-7890-7890-7890123456a1"), new Guid("67890123-6789-6789-6789-6789012345f0") }
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: new Guid("56789012-5678-5678-5678-5678901234ef"),
                column: "ClaveUsuario",
                value: "$2a$11$F8DnIFDhpXslT5b3Dcv0BOFF/S.rd5zzM5MzTZVmPRRWnwJmYJRG6");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: new Guid("67890123-6789-6789-6789-6789012345f0"),
                column: "ClaveUsuario",
                value: "$2a$11$lY0t38WyOYdrAu5cKS5oCOCNaQOsVdeHIQM4Ibqre1wUvGjxDjDtS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Historiales",
                keyColumn: "IdHistorial",
                keyValue: new Guid("01234567-0123-0123-0123-0123456789d4"));

            migrationBuilder.DeleteData(
                table: "Historiales",
                keyColumn: "IdHistorial",
                keyValue: new Guid("11234567-1123-1123-1123-1123456789e5"));

            migrationBuilder.DeleteData(
                table: "Historiales",
                keyColumn: "IdHistorial",
                keyValue: new Guid("21234567-2123-2123-2123-2123456789f6"));

            migrationBuilder.DeleteData(
                table: "Historiales",
                keyColumn: "IdHistorial",
                keyValue: new Guid("31234567-3123-3123-3123-3123456789a7"));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: new Guid("56789012-5678-5678-5678-5678901234ef"),
                column: "ClaveUsuario",
                value: "$2a$11$gmzsAJOyY6C0BpL9xZ0dl.kd7ijPjYsuHsv3aKnR8z77EUPlSK1hG");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: new Guid("67890123-6789-6789-6789-6789012345f0"),
                column: "ClaveUsuario",
                value: "$2a$11$iXvXTW9Bx7M5aQyn4OwTdulqvcerzEsPnyArUxiKPYtYsKS9cSLaq");
        }
    }
}
