using Ejemplo_PasoParametros_Task.Commons;

namespace Ejemplo_PasoParametros_Task.Pages;

[QueryProperty(nameof(OnDevolverParametroCallback), "OnDevolverParametroCallback")]
public partial class DestinoPage : ContentPage
{
    public Action<MiParametro>? OnDevolverParametroCallback { get; set; }

    public DestinoPage()
    {
        InitializeComponent();
    }

    async private void OnVolverConParametrosClicked(object sender, EventArgs e)
    {
        var parametro = new MiParametro() { Valor= $"{DateTime.Now:dd/MM/yyyy HH:mm}" };

        OnDevolverParametroCallback?.Invoke( parametro );
        await Shell.Current.GoToAsync("//" + nameof(MainPage));
    }
}