using Xamarin.Forms;

namespace SerializationViewer
{
    public partial class MainPage : ContentPage
    {
        private const int range = 7000;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            (int index, string text) = Serialization.ObjectsFiltering.FilterProvider.FilterFind(entry_input.Text);

            if (index == -1)
                label_output.Text = "No results were found.";
            else
            {
                int from = index - (range / 2) < 0 ? 0 : index - (range / 2);
                int len = from + range >= text.Length ? text.Length - from : range;

                var str = text.Substring(from, len);
                label_output.Text = str;

                scroll.ScrollToAsync(scroll.ScrollX, label_output.Height / 2, true);
            }
        }
    }
}