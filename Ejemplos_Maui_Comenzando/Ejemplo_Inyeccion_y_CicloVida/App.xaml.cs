using Microsoft.Extensions.DependencyInjection;

namespace Ejemplo_Inyeccion_y_CicloVida.Pages;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
    }
}