using Xamarin.Forms;

namespace SoteriaApp.Views
{
    public partial class CommunityChat : ContentPage
    {
        public CommunityChat()
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
