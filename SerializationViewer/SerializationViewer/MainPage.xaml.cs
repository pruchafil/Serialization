using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SerializationViewer
{
    public partial class MainPage : ContentPage
    {
        private const int range = 7000;
        private volatile CancellationTokenSource _cancellationTokenSource;
        private Task _task;

        public MainPage()
        {
            InitializeComponent();
            _cancellationTokenSource = new CancellationTokenSource();
        }

        private async void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_task == null)
                _task = Task.Run(() => GetResults());
            else
                await Reset();
        }

        private async Task Reset()
        {
            _cancellationTokenSource.Cancel();
            await _task;
            _cancellationTokenSource = new CancellationTokenSource();
            _task = Task.Run(() => GetResults());
        }

        private void GetResults()
        {
            var text = label_output.Text;

            Dispatcher.BeginInvokeOnMainThread(() => label_output.Text = string.Empty);

            Dispatcher.BeginInvokeOnMainThread(() =>
            {
                if (label_output.FormattedText == null)
                    label_output.FormattedText = new FormattedString();

                label_output.FormattedText.Spans.Clear();
            });

            string[] result = Serialization.ObjectsFiltering.FilterProvider.FilterSplit(entry_input.Text);

            if (result.Length == 1 || entry_input.Text.Trim() == "")
            {
                Dispatcher.BeginInvokeOnMainThread(() => label_output.Text = "No results were found.");
            }
            else
            {
                for (int i = 0; i < result.Length; i++)
                {
                    var before = new Span() { Text = result[i] };
                    var curr = new Span
                    {
                        TextColor = Color.Red,
                        Text = entry_input.Text.Trim()
                    };

                    Dispatcher.BeginInvokeOnMainThread(() => label_output.FormattedText.Spans.Add(before));

                    if (i + 1 != result.Length)
                        Dispatcher.BeginInvokeOnMainThread(() => label_output.FormattedText.Spans.Add(curr));

                    if (_cancellationTokenSource.Token.IsCancellationRequested)
                        break;
                }
            }
        }

        private async void ImageButton_Show_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Settings());
        }
    }
}