using Ejemplo_ApiServer.DTOs;
using Microsoft.AspNetCore.Mvc;


namespace Ejemplo_ApiServer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonasController : ControllerBase
{
    static List<PersonaDTO> personas = new List<PersonaDTO>
    {
        new PersonaDTO { Nombre = "fernando" },
    };


    [HttpGet("{id}")]
    async public Task<ActionResult<PersonaDTO>> Get(int id)
    {
        return Ok(new PersonaDTO
        {
            Nombre = "fernando"
        });
    }

    [HttpPost()]
    async public Task<ActionResult<PersonaDTO>> Post([FromBody] PersonaDTO nuevo)
    {
        personas.Add(nuevo);
        return nuevo;
    }
}
