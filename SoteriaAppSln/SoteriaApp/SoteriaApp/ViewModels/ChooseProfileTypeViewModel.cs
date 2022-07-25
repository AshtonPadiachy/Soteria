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
        }

        public ICommand EducatorCommand { get; }

        private void OnEducartor()
        {
            NavigationService.NavigateAsync("LoginPage");
        }
    }
}
