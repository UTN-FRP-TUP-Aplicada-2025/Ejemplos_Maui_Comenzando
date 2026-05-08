using System.Diagnostics;
using System.Threading.Tasks;

namespace Ejemplo_Theads.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    async private void OnCalcularClicked(object sender, EventArgs e)
    {
        BtnCalcular.IsEnabled = false;
        try
        {
            await Task.Run(() =>
            {
                MiCalculoPesado();
            });
        }
        finally
        {
            BtnCalcular.IsEnabled = true;
            BtnCalcular.Text = "Iniciar Tarea en Segundo Plano";
        }
    }

    async public void MiCalculoPesado()
    {
        for (int m = 0; m < 1000000; m++)
        {
            Debug.WriteLine($"{m}");

            Dispatcher.Dispatch(() =>
            {
                BtnCalcular.Text = $"{m}";
            });
        }
    }

    async private void OnVerActividadClicked(object sender, EventArgs e)
    {
        LbActividad.Text = $"{ DateTime.Now }";
    }
}
