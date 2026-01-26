using Ejemplo_PasoParametros_Messenger.Pages;

namespace Ejemplo_PasoParametros_Messenger;

public partial class AppShell : Shell
{    
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute( nameof(DestinoPage), typeof(DestinoPage) );
    }
}
