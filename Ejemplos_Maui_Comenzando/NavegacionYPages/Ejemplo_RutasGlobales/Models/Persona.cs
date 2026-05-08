
using Ejemplo_RutasGlobales.Pages;

namespace Ejemplo_RutasGlobales.Models;

public class Persona
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public bool EsActivo { get; set; }

    public string Estado
    {
        get
        {
            string estado = EsActivo ? "Activo" : "No Activo";
            return $"{Nombre}+({estado})";
        }
    }
}
