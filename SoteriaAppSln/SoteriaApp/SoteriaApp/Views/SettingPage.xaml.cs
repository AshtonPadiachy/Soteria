using Xamarin.Forms;

namespace SoteriaApp.Views
{
    public partial class SettingPage : ContentPage
    {
        public SettingPage()
        {
            InitializeComponent();
        }

        private void AccountButton_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AccountPage());
        }

        private void Support_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SupportPage());
        }

        private void PrivacyAndPolicy_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PrivacyAndPolicyPage());
        }

        private void AboutUs_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AboutUsPage());
        }

        
    }
}
