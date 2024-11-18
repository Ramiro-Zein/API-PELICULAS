using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_PELICULAS.Migrations
{
    /// <inheritdoc />
    public partial class NewData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "IdGenero",
                keyValue: new Guid("34567890-3456-3456-3456-3456789012ab"));

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "IdGenero", "NombreGenero" },
                values: new object[,]
                {
                    { new Guid("01234567-0123-0123-0123-0123456789df"), 9 },
                    { new Guid("11234567-1123-1123-1123-1123456789ea"), 10 },
                    { new Guid("21234567-2123-2123-2123-2123456789fb"), 11 },
                    { new Guid("31234567-3123-3123-3123-3123456789bc"), 12 },
                    { new Guid("41234567-4123-4123-4123-4123456789cd"), 13 },
                    { new Guid("56789012-5678-5678-5678-5678901234ef"), 4 },
                    { new Guid("67890123-6789-6789-6789-6789012345fa"), 5 },
                    { new Guid("78901234-7890-7890-7890-7890123456ac"), 6 },
                    { new Guid("89012345-8901-8901-8901-8901234567bd"), 7 },
                    { new Guid("90123456-9012-9012-9012-9012345678ce"), 8 }
                });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "IdPelicula",
                keyValue: new Guid("78901234-7890-7890-7890-7890123456a1"),
                columns: new[] { "ClasificacionPelicula", "DescripcionPelicula", "DuracionPelicula", "TituloPelicula" },
                values: new object[] { 18, "Una persecución al límite en un mundo postapocalíptico.", new TimeOnly(2, 0, 0), "Mad Max: Fury Road" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "IdPelicula",
                keyValue: new Guid("89012345-8901-8901-8901-8901234567b2"),
                columns: new[] { "ClasificacionPelicula", "DescripcionPelicula", "DuracionPelicula", "TituloPelicula" },
                values: new object[] { 16, "Dos adolescentes planean una fiesta inolvidable.", new TimeOnly(1, 53, 0), "Superbad" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "IdPelicula",
                keyValue: new Guid("90123456-9012-9012-9012-9012345678c3"),
                columns: new[] { "ClasificacionPelicula", "DescripcionPelicula", "DuracionPelicula", "TituloPelicula" },
                values: new object[] { 18, "Un hombre injustamente encarcelado encuentra la redención.", new TimeOnly(2, 22, 0), "The Shawshank Redemption" });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "IdPelicula", "ClasificacionPelicula", "DescripcionPelicula", "DuracionPelicula", "GeneroPeliculaIdGenero", "IdGenero", "TituloPelicula" },
                values: new object[,]
                {
                    { new Guid("12345678-5678-1234-1234-5678901234de"), 12, "Una historia de amor y tragedia en el océano.", new TimeOnly(3, 14, 0), null, new Guid("45678901-4567-4567-4567-4567890123de"), "Titanic" },
                    { new Guid("23456789-6789-2345-2345-6789012345fe"), 18, "Investigadores paranormales enfrentan un caso aterrador.", new TimeOnly(1, 52, 0), null, new Guid("56789012-5678-5678-5678-5678901234ef"), "The Conjuring" },
                    { new Guid("34567890-7890-3456-3456-7890123456af"), 13, "Un hobbit comienza una misión para destruir un anillo poderoso.", new TimeOnly(2, 58, 0), null, new Guid("67890123-6789-6789-6789-6789012345fa"), "The Lord of the Rings: The Fellowship of the Ring" },
                    { new Guid("45678901-8901-4567-4567-8901234567bf"), 8, "Un cautivador documental sobre la vida de los pingüinos emperador.", new TimeOnly(1, 20, 0), null, new Guid("78901234-7890-7890-7890-7890123456ac"), "March of the Penguins" },
                    { new Guid("56789012-9012-5678-5678-9012345678cf"), 14, "Un músico y una actriz persiguen sus sueños en Los Ángeles.", new TimeOnly(2, 8, 0), null, new Guid("89012345-8901-8901-8901-8901234567bd"), "La La Land" },
                    { new Guid("67890123-0123-6789-6789-0123456789df"), 13, "Un arqueólogo busca el Arca de la Alianza.", new TimeOnly(1, 55, 0), null, new Guid("90123456-9012-9012-9012-9012345678ce"), "Indiana Jones: Raiders of the Lost Ark" },
                    { new Guid("78901234-1234-7890-7890-1234567890ef"), 18, "Dos detectives investigan crímenes inspirados en los siete pecados capitales.", new TimeOnly(2, 7, 0), null, new Guid("01234567-0123-0123-0123-0123456789df"), "Se7en" }
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: new Guid("56789012-5678-5678-5678-5678901234ef"),
                column: "ClaveUsuario",
                value: "$2a$11$7zWsIQRQwsEdIFZ5SC8EwuB2FCjmWB59wWpm5bY.2tBIrB4csqtga");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: new Guid("67890123-6789-6789-6789-6789012345f0"),
                column: "ClaveUsuario",
                value: "$2a$11$5cOyYheOe6KnO1MXR4NVG.aj8SSY6VNO.KtdTgi9./e4scFCApLd.");

            migrationBuilder.InsertData(
                table: "Historiales",
                columns: new[] { "IdHistorial", "FechaVista", "IdPelicula", "IdUsuario" },
                values: new object[] { new Guid("9ab2c456-9012-9012-9012-9012345678c3"), new DateOnly(2020, 9, 4), new Guid("12345678-5678-1234-1234-5678901234de"), new Guid("56789012-5678-5678-5678-5678901234ef") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "IdGenero",
                keyValue: new Guid("01234567-0123-0123-0123-0123456789df"));

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "IdGenero",
                keyValue: new Guid("11234567-1123-1123-1123-1123456789ea"));

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "IdGenero",
                keyValue: new Guid("21234567-2123-2123-2123-2123456789fb"));

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "IdGenero",
                keyValue: new Guid("31234567-3123-3123-3123-3123456789bc"));

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "IdGenero",
                keyValue: new Guid("41234567-4123-4123-4123-4123456789cd"));

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "IdGenero",
                keyValue: new Guid("56789012-5678-5678-5678-5678901234ef"));

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "IdGenero",
                keyValue: new Guid("67890123-6789-6789-6789-6789012345fa"));

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "IdGenero",
                keyValue: new Guid("78901234-7890-7890-7890-7890123456ac"));

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "IdGenero",
                keyValue: new Guid("89012345-8901-8901-8901-8901234567bd"));

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "IdGenero",
                keyValue: new Guid("90123456-9012-9012-9012-9012345678ce"));

            migrationBuilder.DeleteData(
                table: "Historiales",
                keyColumn: "IdHistorial",
                keyValue: new Guid("9ab2c456-9012-9012-9012-9012345678c3"));

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "IdPelicula",
                keyValue: new Guid("23456789-6789-2345-2345-6789012345fe"));

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "IdPelicula",
                keyValue: new Guid("34567890-7890-3456-3456-7890123456af"));

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "IdPelicula",
                keyValue: new Guid("45678901-8901-4567-4567-8901234567bf"));

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "IdPelicula",
                keyValue: new Guid("56789012-9012-5678-5678-9012345678cf"));

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "IdPelicula",
                keyValue: new Guid("67890123-0123-6789-6789-0123456789df"));

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "IdPelicula",
                keyValue: new Guid("78901234-1234-7890-7890-1234567890ef"));

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "IdPelicula",
                keyValue: new Guid("12345678-5678-1234-1234-5678901234de"));

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "IdGenero", "NombreGenero" },
                values: new object[] { new Guid("34567890-3456-3456-3456-3456789012ab"), 4 });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "IdPelicula",
                keyValue: new Guid("78901234-7890-7890-7890-7890123456a1"),
                columns: new[] { "ClasificacionPelicula", "DescripcionPelicula", "DuracionPelicula", "TituloPelicula" },
                values: new object[] { 5, "Una emocionante aventura de acción.", new TimeOnly(2, 30, 0), "Accion Épica" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "IdPelicula",
                keyValue: new Guid("89012345-8901-8901-8901-8901234567b2"),
                columns: new[] { "ClasificacionPelicula", "DescripcionPelicula", "DuracionPelicula", "TituloPelicula" },
                values: new object[] { 3, "Una comedia divertida para toda la familia.", new TimeOnly(1, 45, 0), "Comedia Ligera" });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "IdPelicula",
                keyValue: new Guid("90123456-9012-9012-9012-9012345678c3"),
                columns: new[] { "ClasificacionPelicula", "DescripcionPelicula", "DuracionPelicula", "TituloPelicula" },
                values: new object[] { 4, "Un drama que te dejará sin aliento.", new TimeOnly(2, 0, 0), "Drama Intenso" });

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
    }
}
