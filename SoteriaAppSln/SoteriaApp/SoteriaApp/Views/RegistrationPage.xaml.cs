using Xamarin.Forms;

namespace SoteriaApp.Views
{
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }
    }

    public class RegistrationTable
    {
      
      
        public string FullName { get; set; }
        public string Surname { get; set; }
        public string CellphoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }
}
