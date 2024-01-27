using System.Collections.ObjectModel;

namespace OpticaMAUI.Forms;

public partial class Inicio : ContentPage
{
    ObservableCollection<Persona> personas = new ObservableCollection<Persona>();


    public Inicio()
	{

		InitializeComponent();


        PersonasListView.ItemsSource = personas;
    }

    void OnAgregarClicked(object sender, EventArgs e)
    {
        var persona = new Persona
        {
            PrimerNombre = PrimerNombreEntry.Text,
            SegundoNombre = SegundoNombreEntry.Text,
            PrimerApellido = PrimerApellidoEntry.Text,
            SegundoApellido = SegundoApellidoEntry.Text,
            Direccion = DireccionEntry.Text,
            Cedula = CedulaEntry.Text
        };

        personas.Add(persona);
    }
}
