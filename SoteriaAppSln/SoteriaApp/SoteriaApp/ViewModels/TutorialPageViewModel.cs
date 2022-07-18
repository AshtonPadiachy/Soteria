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
    public class TutorialPageViewModel : ViewModelBase
    {
        public TutorialPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            SkipCommand = new Command(OnSkip);
        }

        public ICommand SkipCommand { get; }

        private void OnSkip()
        {
            NavigationService.NavigateAsync("LandingTabbedPage");
        }
    }
}
