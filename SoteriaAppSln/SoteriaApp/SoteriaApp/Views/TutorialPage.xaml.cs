using Xamarin.Forms;

namespace SoteriaApp.Views
{
    public partial class TutorialPage : ContentPage
    {
        public TutorialPage()
        {
            InitializeComponent();
        }

        private void SkipButton_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LandingTabbedPage());
        }

        private void Skip_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LandingTabbedPage());
        }
    }
    class CarouselItem
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public string Pictures { get; set; }
    }
}
