using Ejemplo_PasoParametros_TaskCompletion.Pages;

namespace Ejemplo_PasoParametros_TaskCompletion;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(DestinoPage), typeof(DestinoPage));
    }
}
