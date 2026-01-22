using Ejemplo_SDK_Versiones.Pages;

namespace Ejemplo_SDK_Versiones;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(InfoPage), typeof(InfoPage));
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
    }
}
