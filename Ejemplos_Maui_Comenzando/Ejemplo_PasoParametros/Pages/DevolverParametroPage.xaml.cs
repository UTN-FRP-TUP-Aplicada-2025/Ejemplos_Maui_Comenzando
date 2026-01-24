
namespace Ejemplo_PasoParametros.Pages;


[QueryProperty(nameof(OnProcesarCallback), "OnProcesarCallback")]
public partial class DevolverParametroPage : ContentPage
{

    public Action<string>? OnProcesarCallback { get; set; }

    public DevolverParametroPage()
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
        
        OnProcesarCallback?.Invoke(valor);
        //}
        //no lo va a tener en cuenta en la pila de navegación
        await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }
}