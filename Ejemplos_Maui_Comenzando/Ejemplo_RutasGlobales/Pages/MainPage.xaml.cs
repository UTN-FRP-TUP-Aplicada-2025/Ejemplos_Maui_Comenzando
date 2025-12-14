using Ejemplo_RutasGlobales.Models;

namespace Ejemplo_RutasGlobales.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    async void btnVerDetalleSeleccion_Clicked(object sender, EventArgs e)
    {

        Persona selected = pkrPersonas.SelectedItem as Persona;
        if (selected == null)
        {
            await DisplayAlertAsync("Error", "Selecciona una persona", "OK");
            return;
        }

        var navigationParameter = new ShellNavigationQueryParameters
        {
            { "detalle", selected }
        };
        await Shell.Current.GoToAsync("DetallePage", navigationParameter);

    }

}
