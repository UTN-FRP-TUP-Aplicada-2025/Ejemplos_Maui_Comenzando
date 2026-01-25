using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ejemplo_QueryProperty.Pages;

[QueryProperty(nameof(Parametro), "nombre_parametro")]
public partial class DestinoPage : ContentPage
{
    MiClase parametro;
    public MiClase Parametro 
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

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string name = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
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