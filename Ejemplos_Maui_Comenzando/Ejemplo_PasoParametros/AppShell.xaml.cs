using Ejemplo_PasoParametros_Callback;

namespace Ejemplo_PasoParametros_Callback;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(DevolverParametroPage),typeof(DevolverParametroPage));
        Routing.RegisterRoute(nameof(RecibirParametroPage), typeof(RecibirParametroPage));
    }
}
