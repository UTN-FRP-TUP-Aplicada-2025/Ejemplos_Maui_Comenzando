using Ejemplo_ApiClient.DTOs;
using Ejemplo_ApiClient.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Ejemplo_ApiClient;

public partial class App : Application
{
    PersonasClientService _personasClientService;
    public App(PersonasClientService personasClientService)
    {
        InitializeComponent();
        _personasClientService = personasClientService;
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
    }

    async protected override void OnStart()
    {
        base.OnStart();

        string Nombre="";
        try
        {
            //await _personasClientService.GetPersona(1).ContinueWith(t =>
            //{
            //    if (t.Result != null)
            //    {
            //        Nombre = t.Result.Nombre;
            //    }
            //    else
            //    {
            //        Nombre = "no hay resultados";
            //    }
            //});

            await Task.Run(async () =>
            {
                await _personasClientService.AddPersona(new PersonaDTO { Nombre = "raafael" }).ContinueWith(t =>
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
            });
           
        }
        catch (Exception ex)
        {

        }
    }
}