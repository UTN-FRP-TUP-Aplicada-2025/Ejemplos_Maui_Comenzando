using Ejemplo_Inyeccion.Services;
using Microsoft.Extensions.Logging;

namespace Ejemplo_Inyeccion.Pages;

public partial class MainPage : ContentPage
{
    private readonly ILogger<MainPage> _logger;

    StatusService _service = default!;

    public MainPage(ILogger<MainPage> logger, StatusService service)
    {
        InitializeComponent();
        //inyección
        _logger = logger;

        _logger.LogInformation("¡La página MainPage ha sido creada!");

        //inyección
        _service = service;
    }

    private void OnConsultarFechaHoraClicked(object sender, EventArgs e)
    {
        lbFechayHora.Text = $"{ _service.GetDate():dd/MM/yyyy,HH:MM}";

        _logger.LogInformation("¡La página MainPage ha sido creada!");


    }
}
