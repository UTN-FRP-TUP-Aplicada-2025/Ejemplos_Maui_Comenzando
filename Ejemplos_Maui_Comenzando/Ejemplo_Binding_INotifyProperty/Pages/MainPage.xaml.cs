using Ejemplo_Binding_INotifyProperty.ViewModels;

namespace Ejemplo_Binding_INotifyProperty.Pages;

//El binding escucha este evento y actualiza la UI automáticamente.
public partial class MainPage : ContentPage
{

    PersonaViewModel persona = new ();
   
    public MainPage()
    {
        InitializeComponent();

        BindingContext = persona;

        //probando la bidireccionalidad
        persona.Nombre = "Ana";
        persona.Edad = 30;
    }

    async private void OnVerDatosClicked(object sender, EventArgs e)
    {
        await DisplayAlertAsync("Ver Datos", persona?.Descripcion, "Ok");
    }
}
