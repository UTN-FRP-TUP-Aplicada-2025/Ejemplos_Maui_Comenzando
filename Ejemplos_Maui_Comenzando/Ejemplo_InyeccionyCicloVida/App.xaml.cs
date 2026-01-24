using Ejemplo_InyeccionYCicloVida.Pages;
using Ejemplo_InyeccionYCicloVida.Services;
using Microsoft.Extensions.Logging;

namespace Ejemplo_InyeccionYCicloVida;

public partial class App : Application
{
    ILogger<MainPage> _logger = default!;
    StatusService _statusService=default!;
    public App(ILogger<MainPage> logger, StatusService statusService)
    {
        InitializeComponent();

        _logger = logger;
        _statusService = statusService;
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
    }

    protected override void OnStart()
    {
        base.OnStart();

        DateTime mensaje = _statusService.GetDate();
        _logger.LogDebug($"OnStart(): Fecha Registro: {mensaje:d/M/Y, HH:mm} ");
    }

    protected override void OnResume()
    {
        base.OnResume();

        DateTime mensaje = _statusService.GetDate();
        _logger.LogDebug($"OnResume(): Fecha Registro: {mensaje:d/M/Y, HH:mm} ");
    }
}