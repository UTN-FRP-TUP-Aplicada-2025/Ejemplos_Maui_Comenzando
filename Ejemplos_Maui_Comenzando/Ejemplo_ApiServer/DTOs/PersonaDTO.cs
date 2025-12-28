using System.Text.Json.Serialization;

namespace Ejemplo_ApiServer.DTOs;

public class PersonaDTO
{
    [JsonPropertyName("nombre")]
    public string Nombre { get; set; }
}
