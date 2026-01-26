using Ejemplo_PasoParametros_Task.Commons;

namespace Ejemplo_PasoParametros_Task.Pages;

[QueryProperty(nameof(OnDevolverParametroCallback), "OnDevolverParametroCallback")]
public partial class DestinoPage : ContentPage
{
    public Action<MiParametro>? OnDevolverParametroCallback { get; set; }
    private bool _respondido = false;

    public DestinoPage()
    {
        InitializeComponent();
    }

    async private void OnVolverConParametrosClicked(object sender, EventArgs e)
    {
        var parametro = new MiParametro() { Valor= $"{DateTime.Now:dd/MM/yyyy HH:mm}" };

        _respondido = true; // Marcamos como respondido

        OnDevolverParametroCallback?.Invoke( parametro );
        await Shell.Current.GoToAsync("//" + nameof(MainPage));
    }

    async private void OnCancelarClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//" + nameof(MainPage));
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        if (!_respondido)
        {
            // Esto "despierta" al await en la página de origen con un valor nulo
            OnDevolverParametroCallback?.Invoke(null);
        }
    }
}