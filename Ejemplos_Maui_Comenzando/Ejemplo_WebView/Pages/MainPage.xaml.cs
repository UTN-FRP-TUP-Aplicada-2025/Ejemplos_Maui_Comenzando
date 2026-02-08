namespace Ejemplo_WebView.Pages;

public partial class MainPage : ContentPage
{
    public string buttonText = "";
    public string ButtonText
    {
        get => buttonText;
        set
        {
            buttonText = value;
            OnPropertyChanged();
        }
    }

    public bool enableRefreshing = false;
    public bool EnableRefreshing
    { 
        get => enableRefreshing;
        set
        {
            enableRefreshing = value;
            OnPropertyChanged();

            ActualizarBoton();
        }
    }

    
    public bool isRefreshing = false;
    public bool IsRefreshing
    {
        get => isRefreshing;
        set
        {
            isRefreshing = value;
            OnPropertyChanged();
        }
    }

    public void OnRefreshingClicked(object sender, EventArgs e)
    {
        EnableRefreshing = !EnableRefreshing;
        ActualizarBoton();
    }

    private void ActualizarBoton()
    {
        if (enableRefreshing) ButtonText = "Desactivar";
        else ButtonText = "Activar";
    }

    public MainPage()
    {
        InitializeComponent();

        EnableRefreshing = true;

        BindingContext = this;

        webView.Source = "https://geometriafernando.somee.com/";
    }

    private void WebView_Navigating(object sender, WebNavigatingEventArgs e)
    {
    }

    private void WebView_Navigated(object sender, WebNavigatedEventArgs e)
    {
    }

    private void OnRefreshViewRefreshing(object sender, EventArgs e)
    {
        if (!EnableRefreshing)
        {
            IsRefreshing = false;
            return;
        }

        webView.Reload();
    }

}
