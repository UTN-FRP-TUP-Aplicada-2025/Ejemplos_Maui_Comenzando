using Ejemplo_CicloDeVida.Pages;
using Ejemplo_CicloDeVida.Services;
using Microsoft.Extensions.Logging;

namespace Ejemplo_CicloDeVida;

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
#endif

        builder.Services.AddLogging();
        
        builder.Services.AddSingleton<LoggerAndroid>();

        builder.Services.AddSingleton<MainPage>();

        return builder.Build();
    }
}
