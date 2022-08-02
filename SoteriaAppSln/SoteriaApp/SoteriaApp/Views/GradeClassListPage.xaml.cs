using Xamarin.Forms;

namespace SoteriaApp.Views
{
    public partial class GradeClassListPage : ContentPage
    {
        public GradeClassListPage()
        {
            InitializeComponent();
        }

        SearchBar searchBar = new SearchBar { Placeholder = "Type a search keyword ..." };
    }
}
