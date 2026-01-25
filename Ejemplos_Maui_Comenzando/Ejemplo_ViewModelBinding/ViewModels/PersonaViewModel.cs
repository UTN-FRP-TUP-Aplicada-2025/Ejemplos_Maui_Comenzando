using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ejemplo_ViewModelBinding.ViewModels;

public class PersonaViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string name = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    string nombre;
    public string Nombre
    {
        get => nombre;
        set
        {
            if (nombre != value) //importante! evita que entre en un bucle
            {
                nombre = value;
                OnPropertyChanged(); //para que funcione la bidireccionalidad
            }
        }
    }

    int edad;
    public int Edad
    {
        get => edad;
        set
        {
            if (edad != value)
            {
                edad = value;
                OnPropertyChanged(); //para que funcione la bidireccionalidad
            }
        }
    }

    public string Descripcion
    {
        get => $"Nombre: {Nombre}, Edad: {Edad} años.";
    }

    
}
