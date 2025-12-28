using Ejemplo_MiILogger.Pages;
using Ejemplo_MiILogger.Services;
using Ejemplo_MiILogger.Utilities;
using Microsoft.Extensions.Logging;

namespace Ejemplo_MiILogger;

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

//#if DEBUG
//        builder.Logging.AddDebug();
//#endif

        // Definimos la ruta del archivo en la carpeta de datos de la App
        string nombreArchivo = "mi_aplicacion.log";
        string rutaLogs = Path.Combine(FileSystem.AppDataDirectory, nombreArchivo);

        // registro del proveedor personalizado al sistema de Logging
        builder.Logging.AddProvider(new FileLoggerProvider(rutaLogs));

        // registro del servicio de lectura para usarlo en las páginas
        builder.Services.AddSingleton<ILogReaderService>(new LogReaderService(rutaLogs));

        // registor de la página (necesario para inyectar servicios)
        //builder.Services.AddTransient<MainPage>();

        return builder.Build();
    }
}
