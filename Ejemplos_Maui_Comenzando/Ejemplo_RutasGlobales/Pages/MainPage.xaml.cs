using Ejemplo_RutasGlobales.Models;

namespace Ejemplo_RutasGlobales.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;

        Personas = new List<Persona>()
        {
            new Persona{ Id=1, Nombre="Griseld", Edad=24},
            new Persona{ Id=2, Nombre="Eduardo", Edad=25},
            new Persona{ Id=3, Nombre="Ana", Edad=30},
            new Persona{ Id=4, Nombre="Luis", Edad=28},
            new Persona{ Id=5, Nombre="Mariana", Edad=22},
        };
    }

    List<Persona> personas=new();
    public List<Persona> Personas
    {
        get => personas;
        set
        {
            personas = value;
            OnPropertyChanged();
        }
    }

    Persona selectedPersona;
    public Persona SelectedPersona
    {
        get => selectedPersona;
        set
        {
            selectedPersona = value;
            OnPropertyChanged();
        }
    }


    async void btnVerDetalleSeleccion_Clicked(object sender, EventArgs e)
    {

        if (selectedPersona == null)
        {
            await DisplayAlertAsync("Error", "Selecciona una persona", "OK");
            return;
        }

        var navigationParameter = new ShellNavigationQueryParameters
        {
            { "detalle", selectedPersona }
        };
        await Shell.Current.GoToAsync(nameof(DetallePage), navigationParameter);

    }
}
