using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace Ejemplo_QueryProperty.Commons;

public class MiParametro
{
    private string valor;

    public string Valor
    {
        get => valor;
        set
        {
            if (valor != value)
            {
                valor = value;
                OnPropertyChanged();
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string name = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
