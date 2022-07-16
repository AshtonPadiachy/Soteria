using Xamarin.Forms;

namespace SoteriaApp.Views
{
    public partial class LandingTabbedPage : TabbedPage
    {
        public LandingTabbedPage()
        {
            InitializeComponent();

            CurrentPage = Children[1];
        }
    }
}