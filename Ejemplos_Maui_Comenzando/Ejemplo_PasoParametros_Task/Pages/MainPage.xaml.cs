using Ejemplo_PasoParametros_Task.Commons;

namespace Ejemplo_PasoParametros_Task.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    async private void OnIrADestinoClicked(object? sender, EventArgs e)
    {
        // Crea la promesa
        var tcs = new TaskCompletionSource<MiParametro>();

        var pageParams = new ShellNavigationQueryParameters
        {
          {  "OnDevolverParametroCallback" , new Action<MiParametro>( val => tcs.SetResult(val) )  }
        };

        await Shell.Current.GoToAsync(nameof(DestinoPage), pageParams);

        //se queda "esperando" aquí de forma asíncrona
        var resultado = await tcs.Task;

        if (resultado != null)
        {
            LbResultado.Text = resultado.Valor;
        }
        else
        {
            await DisplayAlertAsync("Cancelado", "No se recibió ningún dato", "OK");
        }
    }
}
