using Xamarin.Forms;

namespace SoteriaApp.Views
{
    public partial class InsightsPage : ContentPage
    {
        public InsightsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

           //   if (!lazyView.IsLoaded)
               //  await lazyView.LoadViewAsync(); //
        }
    }
}
