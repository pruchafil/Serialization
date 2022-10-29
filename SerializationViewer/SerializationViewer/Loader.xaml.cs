using MediaManager;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SerializationViewer
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Loader : ContentPage
	{
		public Loader ()
		{
			InitializeComponent();

			Task.Run(() => PlayVideo());
        }

		private async void PlayVideo()
		{
            System.IO.FileInfo info = new System.IO.FileInfo(@"video.mp4");

            CrossMediaManager.Current.Init();
            await CrossMediaManager.Current.Play(info);
        }
    }
}