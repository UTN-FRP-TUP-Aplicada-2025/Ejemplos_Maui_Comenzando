using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ejemplo_PasoParametros_Message.Commons;

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
            }
        }
    }
}
