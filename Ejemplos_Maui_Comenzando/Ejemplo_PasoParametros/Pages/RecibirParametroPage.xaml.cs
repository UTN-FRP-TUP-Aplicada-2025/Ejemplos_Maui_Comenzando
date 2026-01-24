namespace Ejemplo_PasoParametros.Pages;


[QueryProperty(nameof(Valor), "valor") ]
public partial class RecibirParametroPage : ContentPage
{
	private string valor;
	public string Valor 
	{
		get { return valor; }
		set {
			valor = value;
			OnPropertyChanged(nameof(Valor));
		}
	}

	public RecibirParametroPage()
	{
		InitializeComponent();
		BindingContext = this;
	}

    private void OnVolverClicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("//" + nameof(MainPage));
    }
}