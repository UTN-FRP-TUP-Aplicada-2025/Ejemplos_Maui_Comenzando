namespace Ejemplo_NavigationPage.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    async private void OnNextClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new ModalPage());
    }

    async private void OnMostrarModalClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new ModalPage());
    }

    
}
