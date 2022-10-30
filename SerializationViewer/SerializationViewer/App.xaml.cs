using Xamarin.Forms;

namespace SerializationViewer
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Loader();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}