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
    public class ChooseProfileTypeViewModel : ViewModelBase
    {
        public ChooseProfileTypeViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            EducatorCommand = new Command(OnEducartor);
            ParentCommand = new Command(OnParent);
            GuestCommand = new Command(OnGuest);
        }

        public ICommand EducatorCommand { get; }

        public ICommand ParentCommand { get; }

        public ICommand GuestCommand { get; }
        private void OnEducartor()
        {
            NavigationService.NavigateAsync("LoginPage");
        }

        private void OnParent()
        {
            NavigationService.NavigateAsync("LoginPage");
        }

        private void OnGuest()
        {
            NavigationService.NavigateAsync("LandingTabbedPage");
        }
    }
}
