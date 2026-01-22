using Ejemplo_Inyeccion.Pages;
using Ejemplo_Inyeccion.Services;
using Microsoft.Extensions.Logging;

namespace Ejemplo_Inyeccion;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
		builder.Logging.AddDebug();

        //Log "Directo" o Estático (Sin Inyección)
        //Microsoft.Extensions.Logging.Console
        //Herramientas de diagnóstico de Android -> Logcat
        builder.Logging.AddConsole();
        //System.Diagnostics.Debug.WriteLine("Mensaje")
#endif

        //El Log del Contenedor (Inyección de Dependencias)
        builder.Services.AddLogging();
        //builder.Services.AddSingleton<MainPage>();

        builder.Services.AddSingleton<StatusService>();

        //
        //builder.Services.AddTransient<MainPage>();

        return builder.Build();
    }
}
