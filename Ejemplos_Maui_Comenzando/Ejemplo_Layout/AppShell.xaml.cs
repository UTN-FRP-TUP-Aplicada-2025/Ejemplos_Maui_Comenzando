using Ejemplo_Layout.Pages;

namespace Ejemplo_Layout;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(HorizontalStackLayoutPage), typeof(HorizontalStackLayoutPage));
        Routing.RegisterRoute(nameof(VerticalStackLayoutPage), typeof(VerticalStackLayoutPage));
        Routing.RegisterRoute(nameof(GridPage), typeof(GridPage));
        Routing.RegisterRoute(nameof(FlexLayoutPage), typeof(FlexLayoutPage));
        Routing.RegisterRoute(nameof(AbsoluteLayoutPage), typeof(AbsoluteLayoutPage));
    }
}
