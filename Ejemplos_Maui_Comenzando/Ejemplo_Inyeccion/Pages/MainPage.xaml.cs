using Ejemplo_Inyeccion.Services;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

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

        //inyección
        _service = service;

        //invocación
        _logger.LogInformation("¡La página MainPage ha sido creada!");
    }

    private void OnConsultarFechaYHoraClicked(object sender, EventArgs e)
    {
        try
        {
            DateTime fecha = _service.GetDate();//invocación
            LbFechayHora.Text = $"{fecha:dd/MM/yyyy,HH:mm}";

            _logger.LogInformation("¡La página MainPage ha sido creada!");
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
    }
}
