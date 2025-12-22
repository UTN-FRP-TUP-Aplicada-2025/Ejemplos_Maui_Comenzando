namespace Ejemplo_Template.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    async private void Button_Clicked(object sender, EventArgs e)
    {
       await Shell.Current.GoToAsync("LoginPage");
    }
}
