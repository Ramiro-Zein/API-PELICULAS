using API_PELICULAS.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddProjectServices(builder.Configuration);

builder.WebHost.ConfigureCustomKestrel();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();


using var cts = new CancellationTokenSource();
Console.CancelKeyPress += (_, eventArgs) =>
{
    eventArgs.Cancel = true;
    cts.Cancel();
};

try
{
    await app.RunAsync(cts.Token);
}
catch (OperationCanceledException)
{
    Console.WriteLine("La aplicación se está cerrando...");
}
finally
{
    Console.WriteLine("El servidor ha sido detenido y el puerto liberado.");
}