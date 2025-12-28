using Ejemplo_ApiClient.Services;
using Microsoft.Extensions.Logging;

namespace Ejemplo_ApiClient;

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

        builder.Services.AddHttpClient();
        builder.Services.AddSingleton<PersonasClientService>();

        return builder.Build();
    }
}
