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
        private const string styleLoad = "Downloading styles.";
        private const string completed = "Downloading styles.";
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
            _loading.Add(styleLoad);
            var task2 = Task.Run(() => InitStyles(config));

            await task1;
            _loading.Remove(dataLoad);
            await task2;
            _loading.Remove(styleLoad);

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

        private void InitStyles(Config config)
        {
            Color backgroundColor, textColor;


            if (config.DarkMode)
            {
                backgroundColor = Color.Black;
                textColor = Color.White;
            }
            else
            {
                backgroundColor = Color.White;
                textColor = Color.Black;
            }

            Resources = new ResourceDictionary();

            var g_page = new Style(typeof(ContentPage))
            {
                ApplyToDerivedTypes = true,
                Setters = {
                    new Setter
                    {
                        Property = ContentPage.BackgroundColorProperty, Value = backgroundColor
                    }
                }
            };

            var g_entry = new Style(typeof(Xamarin.Forms.Entry))
            {
                ApplyToDerivedTypes = true,
                Setters = {
                    new Setter { Property = Xamarin.Forms.Entry.BackgroundColorProperty, Value = backgroundColor },
                    new Setter { Property = Xamarin.Forms.Entry.TextColorProperty, Value = textColor }
                }
            };

            var g_editor = new Style(typeof(Xamarin.Forms.Editor))
            {
                ApplyToDerivedTypes = true,
                Setters = {
                    new Setter { Property = Xamarin.Forms.Editor.BackgroundColorProperty, Value = backgroundColor },
                    new Setter { Property = Xamarin.Forms.Editor.TextColorProperty, Value = textColor }
                }
            };

            Resources.Add(nameof(g_page), g_page);
            Resources.Add(nameof(g_entry), g_entry);
            Resources.Add(nameof(g_editor), g_editor);
        }
    }
}