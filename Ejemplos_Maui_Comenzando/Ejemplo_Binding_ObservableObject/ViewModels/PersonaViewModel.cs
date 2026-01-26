using CommunityToolkit.Mvvm.ComponentModel;

namespace Ejemplo_Binding_INotifyProperty.ViewModels;

public partial class PersonaViewModel : ObservableObject
{
    [ObservableProperty]
    private string nombre;

    [ObservableProperty]
    private int edad;

    public string Descripcion
    {
        get => $"Nombre: {nombre}, Edad: {edad} años.";
    }

    
}
