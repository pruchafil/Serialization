using Serialization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SerializationViewer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Show : ContentPage
    {
        public Show()
        {
            InitializeComponent();

            label.Text = Serialization.SaveSystem.DataLoader.Self.Data.ToFormattedString();

            GlobalStyles.ChangeStyle(this);
        }

        protected override void OnAppearing()
        {
            GlobalStyles.ChangeStyle(this);
        }

        private async void Close_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}