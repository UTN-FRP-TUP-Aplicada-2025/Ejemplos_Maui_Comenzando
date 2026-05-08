using Ejemplo_Logcat.Services;
using Microsoft.Extensions.Logging;

namespace Ejemplo_Logcat;

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
        //     builder.Logging.AddDebug();
        //#endif

        builder.Services.AddSingleton<SOLogger>();

        return builder.Build();
    }
}
