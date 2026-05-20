
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

        //webView.Source = "https://geometriafernando.somee.com/";
        webView.Source = "https://www.google.com/";
    }

    private void WebView_Navigating(object sender, WebNavigatingEventArgs e)
    {
        //invisibiliza al dialer
        IsRefreshing = false;
    }

    private void WebView_Navigated(object sender, WebNavigatedEventArgs e)
    {
    }

    //protected override void OnAppearing()
    //{

    //    // muestra el dialer
    //    // activa el refreshing
        
    //}

    protected override async void OnAppearing()
    {
        IsRefreshing = true;

        base.OnAppearing();
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

    private void OnPrueba(object sender, EventArgs e)
    {
        IsRefreshing = true;
    }

    private void OnPruebaURL(object sender, EventArgs e)
    {
        webView.Source = "https://geolocate.somee.com/geolocate?Latitud=-31.7496689&Longitud=-60.5213019&";
    }
    
}
