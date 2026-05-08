using System.Windows.Input;

namespace Ejemplo_Flyout;

public partial class AppShell : Shell
{
    public ICommand ContactCommand { get; private set; }

    public AppShell()
    {
        InitializeComponent();

        ContactCommand = new Command<string>(async (url) =>
        {
            if (!string.IsNullOrEmpty(url))
            {
                await Browser.Default.OpenAsync(new Uri(url), BrowserLaunchMode.SystemPreferred);
            }
        });
        BindingContext = this;
    }

    async private void MenuItem_Clicked(object sender, EventArgs e)
    {
        string url="https://www.frp.utn.edu.ar/info2/?page_id=18452";

        //SystemPreferred:  Abre la URL en el navegador predeterminado del sistema.Es la opción recomendada 
        //        porque respeta la preferencia del usuario sobre qué navegador utilizar.

        //External: Abre la URL en una aplicación externa al navegador.Es más antiguo y generalmente
        //equivalente a SystemPreferred en la mayoría de casos.
        await Browser.Default.OpenAsync(new Uri(url), BrowserLaunchMode.SystemPreferred);
    }
}
