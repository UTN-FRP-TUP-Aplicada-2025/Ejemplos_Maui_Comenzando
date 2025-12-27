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

    LoggerAndroid _loggerAndroid;

    public MainPage(LoggerAndroid loggerAndroid)
    {
        InitializeComponent();
        BindingContext = this;
        _loggerAndroid = loggerAndroid;
    }

    private void OnVerCatlogClicked(object? sender, EventArgs e)
    {
        try
        { 
            Logcat = _loggerAndroid.GetLoggerInfo(); 
        }
        catch (Exception ex)
        {
            Logcat = "error: {ex.Message}";
        }
    }
}
