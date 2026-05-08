using Ejemplo_ApiClient.DTOs;
using Ejemplo_ApiClient.Services;
using System.Net.Http.Json;

namespace Ejemplo_ApiClient.Pages;

public partial class MainPage : ContentPage
{
    HttpClient _httpClient;

    private string _nombre = "";
    public string Nombre
    {
        get => _nombre;
        set
        {
            _nombre = value;
            OnPropertyChanged();
        }
    }
    PersonasClientService _personasClientService;
    public MainPage(HttpClient httpClient, PersonasClientService personasClientService)
    {

        InitializeComponent();
        BindingContext = this;

        _httpClient = httpClient;
        _personasClientService = personasClientService;
    }

    async private void OnConsultaAPIClicked(object? sender, EventArgs e)
    {
        try
        {
            await _personasClientService.GetPersona(1).ContinueWith(t =>
            {
                if (t.Result != null)
                {
                    Nombre = t.Result.Nombre;
                }
                else
                {
                    Nombre = "no hay resultados";
                }
            });
        }
        catch (Exception ex)
        {

        }
    }


    async private void OnAgregarAPIClicked(object? sender, EventArgs e)
    {

        string url = "https://hxbt1xfz-7257.brs.devtunnels.ms/api/Personas";

        var personaNueva = new PersonaDTO()
        {
            Nombre = "rafael",
        };

        try
        {
            await _personasClientService.AddPersona(personaNueva).ContinueWith(t =>
            {
                if (t.Result != null)
                {
                    Nombre = t.Result.Nombre;
                }
                else
                {
                    Nombre = "no hay resultados";
                }
            });
        }
        catch (Exception ex)
        {

        }
    }
}
