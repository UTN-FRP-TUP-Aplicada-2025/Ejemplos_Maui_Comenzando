

using Ejemplo_PasoParametros_Task.Commons;

namespace Ejemplo_PasoParametros_TaskCompletion.Pages;

public partial class DestinoPage : ContentPage
{
    //promesa
    public TaskCompletionSource<MiParametro> ResultadoTask { get; set; } = new();

    public DestinoPage()
    {
        InitializeComponent();
    }

    async private void OnVolverConParametrosClicked(object sender, EventArgs e)
    {
        var parametro = new MiParametro() { Valor= $"{DateTime.Now:dd/MM/yyyy HH:mm}" };

        ResultadoTask.SetResult( parametro );
        //await Shell.Current.GoToAsync("..");
        
        await Navigation.PopAsync();
    }

    async private void OnCancelarClicked(object sender, EventArgs e)
    {
        //await Shell.Current.GoToAsync("//" + nameof(MainPage));

        await Navigation.PopAsync();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        if (!ResultadoTask.Task.IsCompleted)
            ResultadoTask.SetResult(null);
    }
}