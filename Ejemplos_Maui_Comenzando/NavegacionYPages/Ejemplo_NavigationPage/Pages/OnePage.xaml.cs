namespace Ejemplo_NavigationPage.Pages;

public partial class OnePage : ContentPage
{
	public OnePage()
	{
		InitializeComponent();
	}

    async private void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}