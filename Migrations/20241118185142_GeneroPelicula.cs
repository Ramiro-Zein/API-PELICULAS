using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_PELICULAS.Migrations
{
    /// <inheritdoc />
    public partial class GeneroPelicula : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PeliculaGenero",
                columns: new[] { "IdGenero", "IdPelicula" },
                values: new object[,]
                {
                    { new Guid("45678901-4567-4567-4567-4567890123de"), new Guid("12345678-5678-1234-1234-5678901234de") },
                    { new Guid("56789012-5678-5678-5678-5678901234ef"), new Guid("23456789-6789-2345-2345-6789012345fe") },
                    { new Guid("67890123-6789-6789-6789-6789012345fa"), new Guid("34567890-7890-3456-3456-7890123456af") },
                    { new Guid("78901234-7890-7890-7890-7890123456ac"), new Guid("45678901-8901-4567-4567-8901234567bf") },
                    { new Guid("89012345-8901-8901-8901-8901234567bd"), new Guid("56789012-9012-5678-5678-9012345678cf") },
                    { new Guid("90123456-9012-9012-9012-9012345678ce"), new Guid("67890123-0123-6789-6789-0123456789df") },
                    { new Guid("01234567-0123-0123-0123-0123456789df"), new Guid("78901234-1234-7890-7890-1234567890ef") },
                    { new Guid("12345678-1234-1234-1234-1234567890ab"), new Guid("78901234-7890-7890-7890-7890123456a1") },
                    { new Guid("23456789-2345-2345-2345-2345678901bc"), new Guid("89012345-8901-8901-8901-8901234567b2") },
                    { new Guid("34567890-3456-3456-3456-3456789012cd"), new Guid("90123456-9012-9012-9012-9012345678c3") }
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: new Guid("56789012-5678-5678-5678-5678901234ef"),
                column: "ClaveUsuario",
                value: "$2a$11$LoTgvLFehmE39wHanK7thOOLhXBByAFlIbsCQ8JiSo40BGYCK9aru");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: new Guid("67890123-6789-6789-6789-6789012345f0"),
                column: "ClaveUsuario",
                value: "$2a$11$iwSGyOFRPz/7DK8.05EVUeYVjA4IHvxNRkyEXWZNDftBKB5A0nAE.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PeliculaGenero",
                keyColumns: new[] { "IdGenero", "IdPelicula" },
                keyValues: new object[] { new Guid("45678901-4567-4567-4567-4567890123de"), new Guid("12345678-5678-1234-1234-5678901234de") });

            migrationBuilder.DeleteData(
                table: "PeliculaGenero",
                keyColumns: new[] { "IdGenero", "IdPelicula" },
                keyValues: new object[] { new Guid("56789012-5678-5678-5678-5678901234ef"), new Guid("23456789-6789-2345-2345-6789012345fe") });

            migrationBuilder.DeleteData(
                table: "PeliculaGenero",
                keyColumns: new[] { "IdGenero", "IdPelicula" },
                keyValues: new object[] { new Guid("67890123-6789-6789-6789-6789012345fa"), new Guid("34567890-7890-3456-3456-7890123456af") });

            migrationBuilder.DeleteData(
                table: "PeliculaGenero",
                keyColumns: new[] { "IdGenero", "IdPelicula" },
                keyValues: new object[] { new Guid("78901234-7890-7890-7890-7890123456ac"), new Guid("45678901-8901-4567-4567-8901234567bf") });

            migrationBuilder.DeleteData(
                table: "PeliculaGenero",
                keyColumns: new[] { "IdGenero", "IdPelicula" },
                keyValues: new object[] { new Guid("89012345-8901-8901-8901-8901234567bd"), new Guid("56789012-9012-5678-5678-9012345678cf") });

            migrationBuilder.DeleteData(
                table: "PeliculaGenero",
                keyColumns: new[] { "IdGenero", "IdPelicula" },
                keyValues: new object[] { new Guid("90123456-9012-9012-9012-9012345678ce"), new Guid("67890123-0123-6789-6789-0123456789df") });

            migrationBuilder.DeleteData(
                table: "PeliculaGenero",
                keyColumns: new[] { "IdGenero", "IdPelicula" },
                keyValues: new object[] { new Guid("01234567-0123-0123-0123-0123456789df"), new Guid("78901234-1234-7890-7890-1234567890ef") });

            migrationBuilder.DeleteData(
                table: "PeliculaGenero",
                keyColumns: new[] { "IdGenero", "IdPelicula" },
                keyValues: new object[] { new Guid("12345678-1234-1234-1234-1234567890ab"), new Guid("78901234-7890-7890-7890-7890123456a1") });

            migrationBuilder.DeleteData(
                table: "PeliculaGenero",
                keyColumns: new[] { "IdGenero", "IdPelicula" },
                keyValues: new object[] { new Guid("23456789-2345-2345-2345-2345678901bc"), new Guid("89012345-8901-8901-8901-8901234567b2") });

            migrationBuilder.DeleteData(
                table: "PeliculaGenero",
                keyColumns: new[] { "IdGenero", "IdPelicula" },
                keyValues: new object[] { new Guid("34567890-3456-3456-3456-3456789012cd"), new Guid("90123456-9012-9012-9012-9012345678c3") });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: new Guid("56789012-5678-5678-5678-5678901234ef"),
                column: "ClaveUsuario",
                value: "$2a$11$aRU5B36JrfOiYPU8OelzAeyKdr/EHayG3iRNhYaKFDX9UcfMD8wya");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: new Guid("67890123-6789-6789-6789-6789012345f0"),
                column: "ClaveUsuario",
                value: "$2a$11$iU42n5H/5lR.7E76lj3GSOCOuoPEirbfafNDiHixCZ4ZqmB1XtWdS");
        }
    }
}
