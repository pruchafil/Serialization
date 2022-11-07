using Serialization.JsonModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SerializationViewer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Loader : ContentPage
    {
        private const string dataLoad = "Downloading data.";
        private const string completed = "Completed.";
        private volatile bool _update = true;
        private readonly List<string> _loading = new List<string>();

        public Loader()
        {
            InitializeComponent();

            Load();
            Update();
        }

        private async void Load()
        {
            var config = Serialization.SaveSystem.ConfigLoader.Self.Data;

            _loading.Add(dataLoad);
            var task1 = InitData(config);

            await task1;
            _loading.Remove(dataLoad);

            _loading.Add(completed);
            _update = false;

            await Navigation.PushModalAsync(new MainPage());
        }

        private async void Update()
        {
            while (_update)
            {
                if (_loading.Count == 0)
                    label_state.Text = "...";
                else
                    label_state.Text = string.Join(" ", _loading);

                await Task.Delay(10);
            }
        }

        private async Task InitData(Config config)
        {
            if (config.AutoUpdate)
            {
                string jsonStr = await Serialization.HttpResolver.Get();
                Serialization.SaveSystem.DataLoader.Self.Update(jsonStr);
            }
        }
    }
}