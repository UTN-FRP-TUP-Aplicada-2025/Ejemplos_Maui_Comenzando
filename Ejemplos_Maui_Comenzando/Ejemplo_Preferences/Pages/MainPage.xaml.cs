namespace Ejemplo_Preferences.Pages;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnSetClicked(object? sender, EventArgs e)
    {
        Preferences.Default.Set("texto", etTexto.Text);
    }

    private void OnGetClicked(object? sender, EventArgs e)
    {
        etTexto.Text = Preferences.Default.Get("texto","");
    }
}
