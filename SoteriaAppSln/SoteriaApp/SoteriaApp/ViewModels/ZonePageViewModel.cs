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
    public class ZonePageViewModel : ViewModelBase
    {
        public ZonePageViewModel(INavigationService nav) : base (nav) 
        {
            YellowZonesPageCommand = new Command (OnYellowZonesPageBtn) ;

        }

        public ICommand YellowZonesPageCommand { get; }

        private void OnYellowZonesPageBtn()
        {
            NavigationService.NavigateAsync("YellowZonesPage");
        }
    }


}
