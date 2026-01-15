namespace Ejemplo_BindingSimple.Pages;

public partial class MainPage : ContentPage
{

    string _contenido = "";
    public string Contenido 
    {
        get
        { 
            return _contenido;
        }
        set
        { 
            _contenido = value;
            OnPropertyChanged();
        }
    }

    public MainPage()
    {
        InitializeComponent();

        BindingContext = this;
    }

   
}
