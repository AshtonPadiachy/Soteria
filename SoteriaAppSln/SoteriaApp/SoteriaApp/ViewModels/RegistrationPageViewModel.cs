using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace SoteriaApp.ViewModels
{
    public class RegistrationPageViewModel : ViewModelBase
    {

        public RegistrationPageViewModel(INavigationService nav) : base(nav)
        {
            RegisterPageBtnCommand = new Command(OnRegisterPageBtn);
        }

        public ICommand RegisterPageBtnCommand { get; }

        private void OnRegisterPageBtn()
        {
            NavigationService.NavigateAsync("ThankYouPage");
        }

        public string FullName { get; set; }
            public string Surname { get; set; }
            public string CellphoneNumber { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string ConfirmPassword { get; set; }
    }
          
        
            


        


}
    

