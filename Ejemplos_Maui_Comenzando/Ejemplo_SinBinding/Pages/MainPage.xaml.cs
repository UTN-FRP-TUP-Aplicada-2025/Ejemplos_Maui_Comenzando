namespace Ejemplo_SinBinding.Pages;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        label.Rotation = e.NewValue;
    }
}
