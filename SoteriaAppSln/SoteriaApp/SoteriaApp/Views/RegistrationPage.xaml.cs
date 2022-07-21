using Xamarin.Forms;

namespace SoteriaApp.Views
{
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            RegistrationPage accountDetails= new RegistrationPage();
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {

        }
    }
    public class RegistrationTable
    {
      
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //public string ConfirmPassword { get; set; }

    }
}
