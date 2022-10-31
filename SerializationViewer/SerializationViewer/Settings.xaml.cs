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
        private readonly bool _init;

        public Settings()
        {
            InitializeComponent();

            _init = true;

            checkbox_autoupdate.IsChecked = Serialization.SaveSystem.ConfigLoader.Self.Data.AutoUpdate;
            checkbox_darkmode.IsChecked = Serialization.SaveSystem.ConfigLoader.Self.Data.DarkMode;

            _init = false;
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

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (_init)
                return;

            Serialization.JsonModels.Config c = new Serialization.JsonModels.Config
            {
                AutoUpdate = checkbox_autoupdate.IsChecked,
                DarkMode = checkbox_darkmode.IsChecked
            };

            Serialization.SaveSystem.ConfigLoader.Self.Update(c);
        }
    }
}