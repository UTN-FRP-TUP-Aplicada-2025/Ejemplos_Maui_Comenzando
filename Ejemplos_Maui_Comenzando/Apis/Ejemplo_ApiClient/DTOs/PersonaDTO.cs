using System.Text.Json.Serialization;

namespace Ejemplo_ApiClient.DTOs;

public class PersonaDTO
{
    [JsonPropertyName("nombre")]
    public string Nombre { get; set; }
}
