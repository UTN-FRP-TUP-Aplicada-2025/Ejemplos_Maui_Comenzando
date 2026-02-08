using Ejemplo_RutasGlobales.Pages;

namespace Ejemplo_RutasGlobales;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Registrar rutas de navegación
        Routing.RegisterRoute( nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute( nameof(DetallePage), typeof(DetallePage));
    }
}
