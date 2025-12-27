namespace Ejemplo_StaticLog.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object? sender, EventArgs e)
    {
        //esta linea se elimina en el release
        System.Diagnostics.Debug.WriteLine("Botón presionado");
    }
}
