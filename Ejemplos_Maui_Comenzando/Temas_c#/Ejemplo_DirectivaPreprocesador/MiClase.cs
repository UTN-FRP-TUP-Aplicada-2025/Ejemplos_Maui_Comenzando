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
        return "Hola Android!";
#elif WINDOWS
        return "Hola Windows!";
#else
        return "Hola Plataforma desconocida!";
#endif
    }
}
