namespace Ejemplo_SinBinding.Pages;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnRotarBannerValueChanged(object sender, ValueChangedEventArgs e)
    {
        LbBanner.Rotation = e.NewValue;
        // o
        //LbBanner.Rotation = SlBanner.Value
    }
}
