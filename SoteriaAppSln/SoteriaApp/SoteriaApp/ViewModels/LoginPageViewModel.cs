using Prism.Commands;

using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace SoteriaApp.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        public LoginPageViewModel(INavigationService nav) : base(nav)
        {
            RegistrationPageBtnCommand = new Command(OnRegistrationPageBtn);
        }
        
        public ICommand RegistrationPageBtnCommand { get; }
        private void OnRegistrationPageBtn()
        {

            NavigationService.NavigateAsync("RegistrationPage");
        }

    }

   

   
}
