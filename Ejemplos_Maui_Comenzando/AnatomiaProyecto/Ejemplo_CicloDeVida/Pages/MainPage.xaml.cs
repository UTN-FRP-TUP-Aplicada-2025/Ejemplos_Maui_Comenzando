namespace Ejemplo_CicloDeVida.Pages;

public partial class MainPage : ContentPage
{
   
    public MainPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        System.Diagnostics.Debug.WriteLine("OnAppearing");
    }
}
