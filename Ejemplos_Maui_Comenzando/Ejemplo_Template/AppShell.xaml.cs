using Ejemplo_Template.Pages;

namespace Ejemplo_Template;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Registrar rutas de navegación
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(RegistroPage), typeof(RegistroPage));
    }
}
