namespace Ejemplo_Layout.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void OnVerGridLayoutPageClicked(object sender, EventArgs e)
    {
		AppShell.Current.GoToAsync(nameof(GridLayoutPage));
    }

	private void OnVerStackLayoutPageClicked(object sender, EventArgs e)
	{
		AppShell.Current.GoToAsync(nameof(StackLayoutPage));
    }
}