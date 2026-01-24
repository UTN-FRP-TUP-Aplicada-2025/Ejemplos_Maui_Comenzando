namespace Ejemplo_PasoParametros.Pages;

public partial class MainPage : ContentPage
{
    
    public MainPage()
    {
        InitializeComponent();
    }

    async private void OnEsperarParametroClicked(object? sender, EventArgs e)
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
            {"OnProcesarCallback" , resultadoCallback}
        };

        await Shell.Current.GoToAsync(nameof(DevolverParametroPage), pageParams);
    }

    async private void OnEnviarParametroClicked(object? sender, EventArgs e)
    {
        var pageParams = new ShellNavigationQueryParameters
        {
            {"valor", EtValor.Text}
        };
        await Shell.Current.GoToAsync(nameof(RecibirParametroPage), pageParams);
    }
}
