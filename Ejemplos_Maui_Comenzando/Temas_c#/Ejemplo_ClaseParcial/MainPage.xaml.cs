namespace Ejemplo_ClaseParcial;

public partial class MainPage : ContentPage
{
    MiClase miObjecto=new MiClase();

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnSaludarPlataformaClicked(object? sender, EventArgs e)
    {
        LbSaludarPlataforma.Text = miObjecto.SaludarPlataforma();
    }

    private void OnSaludarAplicacionClicked(object? sender, EventArgs e)
    {
        LbSaludarAplicacion.Text = miObjecto.SaludarAplicacion();
    }
}
