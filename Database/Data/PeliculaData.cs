using API_PELICULAS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_PELICULAS.Database.Data;

public class PeliculaData : IEntityTypeConfiguration<Pelicula>
{
    public void Configure(EntityTypeBuilder<Pelicula> builder)
    {
        var accionGuid = Guid.Parse("12345678-1234-1234-1234-1234567890ab");
        var comediaGuid = Guid.Parse("23456789-2345-2345-2345-2345678901bc");
        var dramaGuid = Guid.Parse("34567890-3456-3456-3456-3456789012cd");
        var romanceGuid = Guid.Parse("45678901-4567-4567-4567-4567890123de");
        var terrorGuid = Guid.Parse("56789012-5678-5678-5678-5678901234ef");
        var fantasiaGuid = Guid.Parse("67890123-6789-6789-6789-6789012345fa");
        var documentalGuid = Guid.Parse("78901234-7890-7890-7890-7890123456ac");
        var musicalGuid = Guid.Parse("89012345-8901-8901-8901-8901234567bd");
        var aventuraGuid = Guid.Parse("90123456-9012-9012-9012-9012345678ce");
        var thrillerGuid = Guid.Parse("01234567-0123-0123-0123-0123456789df");

        var animacionGuid = Guid.Parse("11234567-1123-1123-1123-1123456789ea");
        var biografiaGuid = Guid.Parse("21234567-2123-2123-2123-2123456789fb");
        var deportesGuid = Guid.Parse("31234567-3123-3123-3123-3123456789bc");
        var misterioGuid = Guid.Parse("41234567-4123-4123-4123-4123456789cd");


        builder.HasData(
            new Pelicula
            {
                IdPelicula = Guid.Parse("78901234-7890-7890-7890-7890123456a1"),
                TituloPelicula = "Mad Max: Fury Road",
                DuracionPelicula = new TimeOnly(2, 0),
                DescripcionPelicula = "Una persecución al límite en un mundo postapocalíptico.",
                ClasificacionPelicula = 18,
                IdGenero = accionGuid
            },
            new Pelicula
            {
                IdPelicula = Guid.Parse("89012345-8901-8901-8901-8901234567b2"),
                TituloPelicula = "Superbad",
                DuracionPelicula = new TimeOnly(1, 53),
                DescripcionPelicula = "Dos adolescentes planean una fiesta inolvidable.",
                ClasificacionPelicula = 16,
                IdGenero = comediaGuid
            },
            new Pelicula
            {
                IdPelicula = Guid.Parse("90123456-9012-9012-9012-9012345678c3"),
                TituloPelicula = "The Shawshank Redemption",
                DuracionPelicula = new TimeOnly(2, 22),
                DescripcionPelicula = "Un hombre injustamente encarcelado encuentra la redención.",
                ClasificacionPelicula = 18,
                IdGenero = dramaGuid
            },
            new Pelicula
            {
                IdPelicula = Guid.Parse("12345678-5678-1234-1234-5678901234de"),
                TituloPelicula = "Titanic",
                DuracionPelicula = new TimeOnly(3, 14),
                DescripcionPelicula = "Una historia de amor y tragedia en el océano.",
                ClasificacionPelicula = 12,
                IdGenero = romanceGuid
            },
            new Pelicula
            {
                IdPelicula = Guid.Parse("23456789-6789-2345-2345-6789012345fe"),
                TituloPelicula = "The Conjuring",
                DuracionPelicula = new TimeOnly(1, 52),
                DescripcionPelicula = "Investigadores paranormales enfrentan un caso aterrador.",
                ClasificacionPelicula = 18,
                IdGenero = terrorGuid
            },
            new Pelicula
            {
                IdPelicula = Guid.Parse("34567890-7890-3456-3456-7890123456af"),
                TituloPelicula = "The Lord of the Rings: The Fellowship of the Ring",
                DuracionPelicula = new TimeOnly(2, 58),
                DescripcionPelicula = "Un hobbit comienza una misión para destruir un anillo poderoso.",
                ClasificacionPelicula = 13,
                IdGenero = fantasiaGuid
            },
            new Pelicula
            {
                IdPelicula = Guid.Parse("45678901-8901-4567-4567-8901234567bf"),
                TituloPelicula = "March of the Penguins",
                DuracionPelicula = new TimeOnly(1, 20),
                DescripcionPelicula = "Un cautivador documental sobre la vida de los pingüinos emperador.",
                ClasificacionPelicula = 8,
                IdGenero = documentalGuid
            },
            new Pelicula
            {
                IdPelicula = Guid.Parse("56789012-9012-5678-5678-9012345678cf"),
                TituloPelicula = "La La Land",
                DuracionPelicula = new TimeOnly(2, 8),
                DescripcionPelicula = "Un músico y una actriz persiguen sus sueños en Los Ángeles.",
                ClasificacionPelicula = 14,
                IdGenero = musicalGuid
            },
            new Pelicula
            {
                IdPelicula = Guid.Parse("67890123-0123-6789-6789-0123456789df"),
                TituloPelicula = "Indiana Jones: Raiders of the Lost Ark",
                DuracionPelicula = new TimeOnly(1, 55),
                DescripcionPelicula = "Un arqueólogo busca el Arca de la Alianza.",
                ClasificacionPelicula = 13,
                IdGenero = aventuraGuid
            },
            new Pelicula
            {
                IdPelicula = Guid.Parse("78901234-1234-7890-7890-1234567890ef"),
                TituloPelicula = "Se7en",
                DuracionPelicula = new TimeOnly(2, 7),
                DescripcionPelicula = "Dos detectives investigan crímenes inspirados en los siete pecados capitales.",
                ClasificacionPelicula = 18,
                IdGenero = thrillerGuid
            }
        );
    }
}