using Xamarin.Forms;

namespace SoteriaApp.Views
{
    public partial class HelplinePage : ContentPage
    {
        public HelplinePage()
        {
            InitializeComponent();
        }

        private void EmergencyLineButton_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EmergencyLinesPage());
        }

        private void SupportGroupsButton_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SupportGroupsPage());
        }
    }
}
