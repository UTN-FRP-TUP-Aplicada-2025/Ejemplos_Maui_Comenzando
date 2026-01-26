using Ejemplo_PasoParametros_Message.Pages;

namespace Ejemplo_PasoParametros_Message;

public partial class AppShell : Shell
{    
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute( nameof(DestinoPage), typeof(DestinoPage) );
    }
}
