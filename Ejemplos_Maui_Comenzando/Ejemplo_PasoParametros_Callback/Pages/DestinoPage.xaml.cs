
namespace Ejemplo_PasoParametros_Callback.Pages;


[QueryProperty(nameof(OnDevolverParametroCallback), "OnDevolverParametroCallback")]
public partial class DestinoPage : ContentPage
{

    public Action<string>? OnDevolverParametroCallback { get; set; }

    public DestinoPage()
	{
		InitializeComponent();
	}

    async private void OnVolverConParametrosClicked(object sender, EventArgs e)
    {
        //if (Camera.IsAvailable == true && e.Media != null)
        //{
        string valor = $"{DateTime.Now:dd/MM/yyyy HH:mm}";

        //simular un preprocesamiento
        await Task.Delay(5000);

        OnDevolverParametroCallback?.Invoke(valor);
        //}
        //no lo va a tener en cuenta en la pila de navegación
        await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }
}