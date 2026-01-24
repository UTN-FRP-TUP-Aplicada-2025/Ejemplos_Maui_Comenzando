using Ejemplo_RutasGlobales.Models;
using System.Threading.Tasks;

namespace Ejemplo_RutasGlobales.Pages;


[QueryProperty(nameof(Detalle), "detalle")] // la propiedad, clave del parametro enviado y
public partial class DetalleAsyncPage : ContentPage
{
    TaskCompletionSource<string> detalle=default!;
    public TaskCompletionSource<string> Detalle
    {
        get => detalle;
        set
        {
            detalle = value;
            OnPropertyChanged();
        }
    }

    

    public DetalleAsyncPage()
    {
        InitializeComponent(); 
        BindingContext = this;
    }

    async private void btnVolver_Clicked(object sender, EventArgs e)
    {
        await Task.Delay(5000);

        detalle.TrySetResult("listo!");
        
        Dispatcher.Dispatch(async () =>
        {
            //vuelve
            await Shell.Current.GoToAsync("..");
        });
    }
}