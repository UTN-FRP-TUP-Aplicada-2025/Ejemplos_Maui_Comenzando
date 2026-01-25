namespace Ejemplo_BasicDataBinding.Pages;

public partial class MainPage : ContentPage
{
    string nombre;
    public string Nombre
    {
        get => nombre;
        set
        {
            if (nombre != value) //importante! evita que entre en un bucle
            {
                nombre = value;
                OnPropertyChanged(); //para que funcione la bidireccionalidad
            }
        }
    }

    int edad;
    public int Edad
    {
        get => edad;
        set
        {
            if (edad != value)
            {
                edad = value;
                OnPropertyChanged(); //para que funcione la bidireccionalidad
            }
        }
    }

    public string Descripcion
    {
        get => $"Nombre: {Nombre}, Edad: {Edad} años.";
    }

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;

        //probando la bidireccionalidad
        Nombre = "Ana";
        Edad = 30;
    }

    async private void OnVerDatosClicked(object sender, EventArgs e)
    {
        await DisplayAlertAsync("Ver Datos", Descripcion, "Ok");
    }
}
