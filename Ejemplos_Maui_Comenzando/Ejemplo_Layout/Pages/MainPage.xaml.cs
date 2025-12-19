namespace Ejemplo_Layout.Pages;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnVerticalStackLayoutButtonClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(VerticalStackLayoutPage));
    }

    private void OnHorizontalStackLayoutButtonClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HorizontalStackLayoutPage));
    }

    private void OnGridButtonClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(GridPage));
    }

    private void OnFlexLayoutButtonClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(FlexLayoutPage));
    }

    private void OnAbsoluteLayoutButtonClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AbsoluteLayoutPage));
    }
    
}
