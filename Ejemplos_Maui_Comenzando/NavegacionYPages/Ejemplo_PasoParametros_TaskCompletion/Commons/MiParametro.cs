

namespace Ejemplo_PasoParametros_Task.Commons;

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
