using Ejemplo_QueryProperty.Pages;

namespace Ejemplo_QueryProperty;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(DestinoPage), typeof(DestinoPage));
    }
}
