using Ejemplo_ApiClient.DTOs;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;

namespace Ejemplo_ApiClient.Services;

public class PersonasClientService
{
    HttpClient _httpClient;
    public PersonasClientService(HttpClient httpClient)
    {
        _httpClient=httpClient;
    }

    async public Task<PersonaDTO> GetPersona(int id)
    {
        string url = "https://hxbt1xfz-7257.brs.devtunnels.ms/api/Personas/1";
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        var response = await _httpClient.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadFromJsonAsync<PersonaDTO>();

            return content;
        }
        return null;
    }

    async public Task<PersonaDTO> AddPersona(PersonaDTO nueva)
    {
        string url = "https://hxbt1xfz-7257.brs.devtunnels.ms/api/Personas";

        var personaNueva = new PersonaDTO()
        {
            Nombre = "rafael",
        };

        var json = System.Text.Json.JsonSerializer.Serialize(personaNueva);

        var request = new HttpRequestMessage(HttpMethod.Post, url)
        {
            Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json")
        };


        var response = await _httpClient.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadFromJsonAsync<PersonaDTO>();
            return content;
        }
        return null;
    }
}
