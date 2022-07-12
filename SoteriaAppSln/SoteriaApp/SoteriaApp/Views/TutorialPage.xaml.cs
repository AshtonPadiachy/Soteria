using Xamarin.Forms;

namespace SoteriaApp.Views
{
    public partial class TutorialPage : ContentPage
    {
        public TutorialPage()
        {
            InitializeComponent();
        }
    }
    class CarouselItem
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public string Pictures { get; set; }
    }
}
