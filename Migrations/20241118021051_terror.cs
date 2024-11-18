using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_PELICULAS.Migrations
{
    /// <inheritdoc />
    public partial class terror : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "IdGenero", "NombreGenero" },
                values: new object[] { new Guid("34567890-3456-3456-3456-3456789012ab"), 4 });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: new Guid("56789012-5678-5678-5678-5678901234ef"),
                column: "ClaveUsuario",
                value: "$2a$11$eaUL39BaFn.9SgHJGveQeeoHKe1mLsjnZqAJTo6mr074ucvRCMdbC");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: new Guid("67890123-6789-6789-6789-6789012345f0"),
                column: "ClaveUsuario",
                value: "$2a$11$ubi58MKoAUjr25Co4IMtvOxXC7Zw60EFzxbY.cO5mk95VJnXLIy3e");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "IdGenero",
                keyValue: new Guid("34567890-3456-3456-3456-3456789012ab"));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: new Guid("56789012-5678-5678-5678-5678901234ef"),
                column: "ClaveUsuario",
                value: "$2a$11$dJ1i0naIzoq1Ayqotklije4mVOTMEf5pcKRB5OTQQBn2z026Y5ikG");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: new Guid("67890123-6789-6789-6789-6789012345f0"),
                column: "ClaveUsuario",
                value: "$2a$11$Hsgy6TKcEHy93rfDvspzk.yOVz2QFOifZ8QNJKFmyox/y48rQHnQi");
        }
    }
}
