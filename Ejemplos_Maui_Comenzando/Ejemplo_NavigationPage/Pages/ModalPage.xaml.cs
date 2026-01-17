namespace Ejemplo_NavigationPage.Pages;

public partial class ModalPage : ContentPage
{
	public ModalPage()
	{
		InitializeComponent();
	}

    async private void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync(true);
    }
}