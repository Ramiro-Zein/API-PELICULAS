namespace API_PELICULAS.Extensions;

public static class KestrelConfigurationExtensions
{
    public static void ConfigureCustomKestrel(this IWebHostBuilder webHostBuilder)
    {
        webHostBuilder.ConfigureKestrel(options =>
        {
            /*
            options.ListenAnyIP(7025, listenOptions =>
            {
                listenOptions.UseHttps();
            });
            */
            
            options.ListenAnyIP(7024);
        });
    }
}