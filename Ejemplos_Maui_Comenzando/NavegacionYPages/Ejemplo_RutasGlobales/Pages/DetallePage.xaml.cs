using Ejemplo_RutasGlobales.Models;

namespace Ejemplo_RutasGlobales.Pages;


[QueryProperty(nameof(Detalle), "detalle")] // la propiedad, clave del parametro enviado y
public partial class DetallePage : ContentPage
{
    Persona detalle;
    public Persona Detalle
    {
        get => detalle;
        set
        {
            detalle = value;
            OnPropertyChanged();
        }
    }

    public DetallePage()
	{
		InitializeComponent();

        //La línea BindingContext = this; establece el contexto de vinculación de datos de la página. 
        BindingContext = this;
    }

    async private void btnVolver_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}