using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_PELICULAS.Migrations
{
    /// <inheritdoc />
    public partial class Datos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    IdGenero = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreGenero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.IdGenero);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClaveUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstatusUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    IdPelicula = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TituloPelicula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DuracionPelicula = table.Column<TimeOnly>(type: "time", nullable: false),
                    DescripcionPelicula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClasificacionPelicula = table.Column<int>(type: "int", nullable: false),
                    GeneroPeliculaIdGenero = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdGenero = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.IdPelicula);
                    table.ForeignKey(
                        name: "FK_Peliculas_Generos_GeneroPeliculaIdGenero",
                        column: x => x.GeneroPeliculaIdGenero,
                        principalTable: "Generos",
                        principalColumn: "IdGenero");
                });

            migrationBuilder.CreateTable(
                name: "Historiales",
                columns: table => new
                {
                    IdHistorial = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPelicula = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaVista = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historiales", x => x.IdHistorial);
                    table.ForeignKey(
                        name: "FK_Historiales_Peliculas_IdPelicula",
                        column: x => x.IdPelicula,
                        principalTable: "Peliculas",
                        principalColumn: "IdPelicula",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historiales_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PeliculaGenero",
                columns: table => new
                {
                    IdPelicula = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGenero = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeliculaGenero", x => new { x.IdPelicula, x.IdGenero });
                    table.ForeignKey(
                        name: "FK_PeliculaGenero_Generos_IdGenero",
                        column: x => x.IdGenero,
                        principalTable: "Generos",
                        principalColumn: "IdGenero",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeliculaGenero_Peliculas_IdPelicula",
                        column: x => x.IdPelicula,
                        principalTable: "Peliculas",
                        principalColumn: "IdPelicula",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "IdGenero", "NombreGenero" },
                values: new object[,]
                {
                    { new Guid("12345678-1234-1234-1234-1234567890ab"), 0 },
                    { new Guid("23456789-2345-2345-2345-2345678901bc"), 2 },
                    { new Guid("34567890-3456-3456-3456-3456789012cd"), 3 },
                    { new Guid("45678901-4567-4567-4567-4567890123de"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "IdPelicula", "ClasificacionPelicula", "DescripcionPelicula", "DuracionPelicula", "GeneroPeliculaIdGenero", "IdGenero", "TituloPelicula" },
                values: new object[,]
                {
                    { new Guid("78901234-7890-7890-7890-7890123456a1"), 5, "Una emocionante aventura de acción.", new TimeOnly(2, 30, 0), null, new Guid("12345678-1234-1234-1234-1234567890ab"), "Accion Épica" },
                    { new Guid("89012345-8901-8901-8901-8901234567b2"), 3, "Una comedia divertida para toda la familia.", new TimeOnly(1, 45, 0), null, new Guid("23456789-2345-2345-2345-2345678901bc"), "Comedia Ligera" },
                    { new Guid("90123456-9012-9012-9012-9012345678c3"), 4, "Un drama que te dejará sin aliento.", new TimeOnly(2, 0, 0), null, new Guid("34567890-3456-3456-3456-3456789012cd"), "Drama Intenso" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "ClaveUsuario", "EstatusUsuario", "NombreUsuario" },
                values: new object[,]
                {
                    { new Guid("56789012-5678-5678-5678-5678901234ef"), "clave123", 1, "JuanPerez" },
                    { new Guid("67890123-6789-6789-6789-6789012345f0"), "password", 0, "MariaLopez" }
                });

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

            migrationBuilder.InsertData(
                table: "PeliculaGenero",
                columns: new[] { "IdGenero", "IdPelicula" },
                values: new object[,]
                {
                    { new Guid("12345678-1234-1234-1234-1234567890ab"), new Guid("78901234-7890-7890-7890-7890123456a1") },
                    { new Guid("23456789-2345-2345-2345-2345678901bc"), new Guid("78901234-7890-7890-7890-7890123456a1") },
                    { new Guid("23456789-2345-2345-2345-2345678901bc"), new Guid("89012345-8901-8901-8901-8901234567b2") },
                    { new Guid("34567890-3456-3456-3456-3456789012cd"), new Guid("90123456-9012-9012-9012-9012345678c3") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Historiales_IdPelicula",
                table: "Historiales",
                column: "IdPelicula");

            migrationBuilder.CreateIndex(
                name: "IX_Historiales_IdUsuario",
                table: "Historiales",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_PeliculaGenero_IdGenero",
                table: "PeliculaGenero",
                column: "IdGenero");

            migrationBuilder.CreateIndex(
                name: "IX_Peliculas_GeneroPeliculaIdGenero",
                table: "Peliculas",
                column: "GeneroPeliculaIdGenero");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Historiales");

            migrationBuilder.DropTable(
                name: "PeliculaGenero");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.DropTable(
                name: "Generos");
        }
    }
}
