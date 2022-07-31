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
    public class ThankYouPageViewModel : ViewModelBase
    {
        public ThankYouPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            ThankYouPageBtnCommand = new Command(OnThankYouPageBtn);
        }

        public ICommand ThankYouPageBtnCommand { get; }

        private void OnThankYouPageBtn()
        {
            NavigationService.NavigateAsync("LandingTabbedPage");
        }

        
    }


}
