namespace Ejemplo_PasoParametros_TaskCompletion.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    async private void OnIrADestinoClicked(object? sender, EventArgs e)
    {
        var destinoPage = new DestinoPage();

        //alternativa var resultado = await this.ShowPopupAsync(new MiPopupSeleccion());
        await Navigation.PushAsync(destinoPage);

        //se bloquea hasta que consiga el resultado
        var parametro = await destinoPage.ResultadoTask.Task;

        if (parametro!=null)
        {
           LbResultado.Text = parametro.Valor;
        }
        else
        {
            await DisplayAlertAsync("Cancelado", "No se recibió ningún dato", "OK");
        }
    }
}
