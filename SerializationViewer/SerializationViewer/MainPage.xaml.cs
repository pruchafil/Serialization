using Xamarin.Forms;

namespace SerializationViewer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Load();
        }

        private async void Load()
        {
            Loader loader = new Loader();
            await Navigation.PushModalAsync(loader);
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            (int index, string text) = Serialization.ObjectsFiltering.FilterProvider.FilterFind(entry_input.Text);

            if (index == -1)
                editor_output.Text = "No results were found.";
            else
            {
                var str = text.Substring
                (
                    index >= 100 ? index - 100 : 0,
                    index + 100 >= text.Length ? text.Length - index : 100
                );

                editor_output.Text = str;
            }
        }
    }
}