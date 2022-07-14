using Xamarin.Forms;

namespace SoteriaApp.Views
{
    public partial class TutorialPage : ContentPage
    {
        public TutorialPage()
        {
            InitializeComponent();
        }


        private void SkipOption_Clicked(object sender, System.EventArgs e)
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
