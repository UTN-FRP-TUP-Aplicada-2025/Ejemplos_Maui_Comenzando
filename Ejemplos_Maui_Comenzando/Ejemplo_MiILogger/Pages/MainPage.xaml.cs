using Ejemplo_MiILogger.Services;
using Microsoft.Extensions.Logging;

namespace Ejemplo_MiILogger.Pages;

public partial class MainPage : ContentPage
{
    private readonly ILogger<MainPage> _logger;
    private readonly ILogReaderService _logReader;

    string logcat = string.Empty;
    public string Logcat
    {
        get
        {
            return logcat;
        }
        set
        {
            logcat = value;
            OnPropertyChanged();
        }
    }

    public MainPage(ILogger<MainPage> logger, ILogReaderService logReader)
    {
        InitializeComponent();

        BindingContext= this;

        _logger = logger;
        _logReader = logReader;

        _logger.LogInformation("La aplicación se ha iniciado.");
    }

    private void OnEscribirFileLogClicked(object? sender, EventArgs e)
    {
        try
        {
            _logger.LogInformation("Este es un mensaje de log escrito en el archivo.");
            _logger.LogError("Este es un mensaje de error escrito en el archivo.");
        }
        catch (Exception ex)
        {
            Logcat = "error: {ex.Message}";
        }
    }

    private void OnVerFileLogClicked(object? sender, EventArgs e)
    {
        try
        {
            Logcat = _logReader.ReadLogs();
        }
        catch (Exception ex)
        {
            Logcat = "error: {ex.Message}";
        }
    }

    private void OnClearFileLogClicked(object? sender, EventArgs e)
    {
        try
        {
            _logReader.ClearLogs();
        }
        catch (Exception ex)
        {
        }
    }
}
