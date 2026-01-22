using System.Threading.Tasks;

namespace Ejemplo_SDK_Versiones.Pages;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    async private void OnVerInfoClicked(object? sender, EventArgs e)
    {
        //borra el historial
        //await Shell.Current.GoToAsync("//"+nameof(InfoPage));

        //avanza consevarndo el hiostiral
        await Shell.Current.GoToAsync(nameof(InfoPage));
    }
}
