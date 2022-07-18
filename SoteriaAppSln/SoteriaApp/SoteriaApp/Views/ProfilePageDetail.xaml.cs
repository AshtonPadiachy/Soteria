using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoteriaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePageDetail : ContentPage
    {
        public ProfilePageDetail()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (!lazyView.IsLoaded)
                await lazyView.LoadViewAsync();
        }
    }
}