using Ejemplo_Layout.Pages;

namespace Ejemplo_Layout;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(GridLayoutPage), typeof(GridLayoutPage));
        Routing.RegisterRoute(nameof(StackLayoutPage), typeof(StackLayoutPage));
    }
}
