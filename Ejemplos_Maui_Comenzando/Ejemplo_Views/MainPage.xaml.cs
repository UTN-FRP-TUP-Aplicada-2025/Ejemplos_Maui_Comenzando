namespace Ejemplo_Views;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    async void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender is CheckBox chk)
        {
            await DisplayAlertAsync("CheckBox", $"IsChecked: {chk.IsChecked}", "OK");
        }
    }

    private void btnResultadoCheckBox_Clicked(object sender, EventArgs e)
    {
        if (chkOpcion1.IsChecked)
            lbResultadoCheckBox.Text = "Opción 1 seleccionada";

        if (chkOpcion2.IsChecked)
            lbResultadoCheckBox.Text = "Opción 2 seleccionada";

        if (chkOpcion1.IsChecked && chkOpcion2.IsChecked)
            lbResultadoCheckBox.Text = "Opción 1 y 2 seleccionadas";

        if (!chkOpcion1.IsChecked && !chkOpcion2.IsChecked)
            lbResultadoCheckBox.Text = "Ninguna opción seleccionada";
    }

    private void btnResultadoRadioButton_Clicked(object sender, EventArgs e)
    {
        if (rbtnOpcion1.IsChecked)
            lbResultadoRadioButton.Text = "Opción 1 seleccionada";
        else if (rbtnOpcion1.IsChecked)
            lbResultadoRadioButton.Text = "Opción 2 seleccionada";
        else
            lbResultadoRadioButton.Text = "Ninguna opción seleccionada";
    }

    private void btnVerLista_Clicked(object sender, EventArgs e)
    {
        lvLista.Header = "Listado: ";

        var lista = new List<Persona>
        {
            new Persona{ Id=1, Nombre="Rocio"},
            new Persona{ Id=2, Nombre="Eduardo"},
            new Persona{ Id=3, Nombre="Griselda"},
        };

        lvLista.ItemsSource = lista;

        lvLista.Footer = lista.Count.ToString();
    }

    async void btnVerSeleccion_Clicked(object sender, EventArgs e)
    {
        Persona seleccionado = lvLista.SelectedItem as Persona;
        if (seleccionado != null)
          await DisplayAlertAsync("CollectionView", $"selectedItem: {seleccionado.Nombre}", "OK");
    }

    private void lvLista_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var valor=e.CurrentSelection.FirstOrDefault();
    }

    Persona selectedPersona { get; set; }
}

public class Persona
{
    public int Id { get; set; }
    public string Nombre { get; set; }
}