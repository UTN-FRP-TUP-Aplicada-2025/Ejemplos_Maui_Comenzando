using Ejemplo_QueryProperty.Parameters;

namespace Ejemplo_QueryProperty.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    async private void OnIrADestinoPageClicked(object? sender, EventArgs e)
    {
        var pageParams = new ShellNavigationQueryParameters
        {
          {"nombre_parametro" , new MiParametro{ Valor="Valor de prueba" } }
        };

        await Shell.Current.GoToAsync(nameof(DestinoPage), pageParams);
    }
}
