using Microsoft.Extensions.Logging;

namespace Ejemplo_ILogger
{
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
            //limpia log android logcat - c
            //sin este no imprime en pantalla el ilogger inyectado
            //aporta el proveedor de log (donde imprime)
            builder.Logging.AddDebug();
#endif
            //este se supone que ya lo regista el createbuilder.
            builder.Services.AddLogging();

            return builder.Build();
        }
    }
}
