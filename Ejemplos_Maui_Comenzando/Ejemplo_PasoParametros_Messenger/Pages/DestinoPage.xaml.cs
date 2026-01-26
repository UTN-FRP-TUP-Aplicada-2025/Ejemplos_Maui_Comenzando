
using CommunityToolkit.Mvvm.Messaging;
using Ejemplo_PasoParametros_Messenger.Commons;

namespace Ejemplo_PasoParametros_Messenger.Pages;

public partial class DestinoPage : ContentPage
{

    public Action<string>? OnDevolverParametroCallback { get; set; }

    public DestinoPage()
    {
        InitializeComponent();
    }

    async private void OnVolverConParametrosClicked(object sender, EventArgs e)
    {
        MiParametro parametro = new MiParametro() { Valor = $"{DateTime.Now:dd/MM/yyyy HH:mm}" };
        
        WeakReferenceMessenger.Default.Send( new MiMessage(parametro) );
        await Shell.Current.GoToAsync("..");
    }
}