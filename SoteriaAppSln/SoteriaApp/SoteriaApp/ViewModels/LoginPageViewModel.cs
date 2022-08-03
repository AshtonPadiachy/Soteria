using Prism.Commands;

using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using Prism.Services.Dialogs;
using SoteriaApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace SoteriaApp.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private IAuthentication _authentication;
        private IPageDialogService _pageDialogService;

        private string _emailAddress;
        public string EmailAddress
        {
            get { return _emailAddress; }
            set { SetProperty(ref _emailAddress, value); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }


        public LoginPageViewModel(INavigationService nav, IPageDialogService pageDialogService, IAuthentication authentication) : base(nav)
        {

            LoginPageBtnCommand = new Command(OnLoginPageBtn);
            RegistrationPageBtnCommand = new Command(OnRegistrationPageBtn);
            
            _authentication = authentication;
            _pageDialogService = pageDialogService;
        }

        public ICommand LoginPageBtnCommand { get; }

        public ICommand RegistrationPageBtnCommand { get; }

        
        private async void OnLoginPageBtn()
        {

            if (!string.IsNullOrEmpty(EmailAddress) && !string.IsNullOrEmpty(Password))
            {
                var authenticated = await _authentication.Authenticate(EmailAddress, Password);

                if (authenticated)
                {
                    await NavigationService.NavigateAsync("LandingTabbedPage");

                }
                else
                {
                    await _pageDialogService.DisplayAlertAsync("Login Error", "User does not exist.", "Ok");
                }


            }




        }


        private void OnRegistrationPageBtn()
        {

            NavigationService.NavigateAsync("RegistrationPage");
        }

    }

   

   
}
