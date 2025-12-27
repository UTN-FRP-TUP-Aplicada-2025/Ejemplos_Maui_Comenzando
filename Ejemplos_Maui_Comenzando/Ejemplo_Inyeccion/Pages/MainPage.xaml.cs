using Microsoft.Extensions.Logging;

namespace Ejemplo_Inyeccion.Pages;

public partial class MainPage : ContentPage
{
    private readonly ILogger<MainPage> _logger;

    public MainPage(ILogger<MainPage> logger)
    {
        InitializeComponent();
        _logger = logger;

        _logger.LogInformation("¡La página MainPage ha sido creada!");
    }

}
