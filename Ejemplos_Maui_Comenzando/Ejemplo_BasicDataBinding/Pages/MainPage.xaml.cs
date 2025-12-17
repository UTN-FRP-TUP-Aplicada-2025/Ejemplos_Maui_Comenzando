namespace Ejemplo_BasicDataBinding.Pages;

public partial class MainPage : ContentPage
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public string Descripcion
    { 
        get => $"Nombre: {Nombre}, Edad: {Edad} años.";
    }

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    async private void Button_Clicked(object sender, EventArgs e)
    {
        await DisplayAlertAsync("CollectionView", $"{Descripcion}", "OK");
    }
}
