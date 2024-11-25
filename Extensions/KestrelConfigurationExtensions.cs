namespace API_PELICULAS.Extensions;

public static class KestrelConfigurationExtensions
{
    public static void ConfigureCustomKestrel(this IWebHostBuilder webHostBuilder)
    {
        webHostBuilder.ConfigureKestrel(options =>
        {
            options.ListenAnyIP(7024, listenOptions =>
            {
                listenOptions.UseHttps();
            });
        });
    }
}