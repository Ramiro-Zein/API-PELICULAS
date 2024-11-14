using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_PELICULAS.Migrations
{
    /// <inheritdoc />
    public partial class SeguridadV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: new Guid("56789012-5678-5678-5678-5678901234ef"),
                columns: new[] { "ClaveUsuario", "NombreUsuario" },
                values: new object[] { "$2a$11$dJ1i0naIzoq1Ayqotklije4mVOTMEf5pcKRB5OTQQBn2z026Y5ikG", "ramiro.zein" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: new Guid("67890123-6789-6789-6789-6789012345f0"),
                columns: new[] { "ClaveUsuario", "NombreUsuario" },
                values: new object[] { "$2a$11$Hsgy6TKcEHy93rfDvspzk.yOVz2QFOifZ8QNJKFmyox/y48rQHnQi", "maria.lopez" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: new Guid("56789012-5678-5678-5678-5678901234ef"),
                columns: new[] { "ClaveUsuario", "NombreUsuario" },
                values: new object[] { "clave123", "JuanPerez" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: new Guid("67890123-6789-6789-6789-6789012345f0"),
                columns: new[] { "ClaveUsuario", "NombreUsuario" },
                values: new object[] { "password", "MariaLopez" });
        }
    }
}
