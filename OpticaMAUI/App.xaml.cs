using OpticaMAUI.Forms;

namespace OpticaMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Inicio();
        }
    }
}
