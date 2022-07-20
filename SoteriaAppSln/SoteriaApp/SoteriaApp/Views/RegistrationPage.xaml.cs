using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoteriaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            RegistrationPage accountDetails = new RegistrationPage();
            InitializeComponent();
        }

        void Button_Clicked(object sender, System.EventArgs e)
        {
            

           var item = new RegistrationPage();
            {
               // UserName = EntryUserName;
               // FullName = EntryFullName;
               // Surname = EntrySurname;
               // Email = EntryEmail;
               // Password = EntryPassword;
               // ConfirmPassword = EntryConfirmPassword;

            }
        }
    }
        
      

}