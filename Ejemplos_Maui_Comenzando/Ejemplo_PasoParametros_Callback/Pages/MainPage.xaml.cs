namespace Ejemplo_PasoParametros_Callback.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    async private void OnIrADestinoClicked(object? sender, EventArgs e)
    {
        Action<string> resultadoCallback = async (valor) =>
        {
            //simulación de procesos.
            await Task.Delay(1000);

            //imprimir en la pantalla.
            await this.Dispatcher.DispatchAsync(new Action(() =>
            {
                LbResultado.Text = valor;
            }));
        };

        var pageParams = new ShellNavigationQueryParameters
        {
            {"OnDevolverParametroCallback" , resultadoCallback}
        };

        await Shell.Current.GoToAsync(nameof(DestinoPage), pageParams);
    }
}
