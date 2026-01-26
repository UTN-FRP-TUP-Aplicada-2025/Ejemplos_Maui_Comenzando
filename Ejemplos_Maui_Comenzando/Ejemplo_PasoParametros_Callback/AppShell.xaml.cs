using Ejemplo_PasoParametros_Callback.Pages;

namespace Ejemplo_PasoParametros_Callback;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(DestinoPage), typeof(DestinoPage));
    }
}
