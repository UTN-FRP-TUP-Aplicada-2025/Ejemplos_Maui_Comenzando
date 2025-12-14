namespace Ejemplo_HolaMundo;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnBtnMensajeClicked(object? sender, EventArgs e)
    {
        lbMensaje.Text = "¡Hola, Mundo!";

        SemanticScreenReader.Announce(lbMensaje.Text);
    }
}
