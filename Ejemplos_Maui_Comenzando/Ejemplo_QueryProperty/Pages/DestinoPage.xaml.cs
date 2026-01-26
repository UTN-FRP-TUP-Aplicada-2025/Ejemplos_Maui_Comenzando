using Ejemplo_QueryProperty.Commons;

namespace Ejemplo_QueryProperty.Pages;

[QueryProperty(nameof(Parametro), "nombre_parametro")]
public partial class DestinoPage : ContentPage
{
    MiParametro parametro=new ();
    public MiParametro Parametro 
    {
        get
        {
            return parametro;
        } 
        set
        {
            if (parametro != value)
            {
                parametro = value;
                OnPropertyChanged();
            }
        }
    }

    public DestinoPage()
	{
		InitializeComponent();
        BindingContext = this;
	}

    async private void OnVolverClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}