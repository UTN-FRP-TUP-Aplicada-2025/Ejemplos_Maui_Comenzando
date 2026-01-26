
namespace Ejemplo_PasoParametros_Messenger.Commons;

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
