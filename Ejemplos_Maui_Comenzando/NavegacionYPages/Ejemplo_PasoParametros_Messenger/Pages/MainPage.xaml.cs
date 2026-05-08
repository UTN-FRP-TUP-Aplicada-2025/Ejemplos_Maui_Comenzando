using CommunityToolkit.Mvvm.Messaging;
using Ejemplo_PasoParametros_Messenger.Commons;

namespace Ejemplo_PasoParametros_Messenger.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        WeakReferenceMessenger.Default.Register<MiMessage>(this, (r, m) =>
        {
            OnMensajeRecibido(m.Value);
        });
    }

    private void OnMensajeRecibido(MiParametro datos)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            LbResultado.Text = datos.Valor;
        });
    }

    async private void OnIrADestinoClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(DestinoPage));
    }
}
