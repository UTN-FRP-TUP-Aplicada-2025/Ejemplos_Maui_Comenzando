
namespace Ejemplo_DirectivaPreprocesador;

public partial class MiClase
{
    public string SaludarAplicacion()
    {
        return "Hola MiAplicación";
    }

    public string SaludarPlataforma()
    {
#if ANDROID
        return "Hola Android";
#elif windows
        return "Hola Windows";
#endif
    }
}
