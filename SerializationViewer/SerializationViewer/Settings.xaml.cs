using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SerializationViewer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {
        public Settings()
        {
            InitializeComponent();
        }

        private async void Button_Update_Clicked(object sender, EventArgs e)
        {
            string update = null;

            try
            {
                Serialization.SaveSystem.DataLoader.Self.Update( await Serialization.HttpResolver.Get() );
                update = "Successfully updated";
            }
            catch (Exception ex)
            {
                update = $"Update failed: {ex.Message}";
            }
            finally
            {
                await DisplayAlert("Force update", update, "OK");
            }
        }

        private async void Button_Show_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Show());
        }

        private async void Close_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}