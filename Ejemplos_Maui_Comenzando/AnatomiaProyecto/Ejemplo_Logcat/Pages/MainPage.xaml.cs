using Ejemplo_Logcat.Services;

namespace Ejemplo_Logcat.Pages;

public partial class MainPage : ContentPage
{
    string logcat=string.Empty;
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

    SOLogger _soLogger;

    public MainPage(SOLogger SOlogger)
    {
        InitializeComponent();
        BindingContext = this;
        _soLogger = SOlogger;
    }

    private void OnVerCatlogClicked(object? sender, EventArgs e)
    {
        try
        { 
            Logcat = _soLogger.GetLoggerInfo(); 
        }
        catch (Exception ex)
        {
            Logcat = "error: {ex.Message}";
        }
    }
}
