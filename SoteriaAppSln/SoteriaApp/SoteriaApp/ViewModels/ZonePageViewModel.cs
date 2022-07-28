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
            RedZonesPageCommand = new Command(OnRedZonesPageBtn);
            BlueZonesPageCommand = new Command(OnBlueZonesPageBtn);
            GreenZonesPageCommand = new Command(OnGreenZonesPageBtn);

        }

        public ICommand YellowZonesPageCommand { get; }
        public ICommand RedZonesPageCommand { get; }
        public ICommand BlueZonesPageCommand { get; }
        public ICommand GreenZonesPageCommand { get; }

        private void OnGreenZonesPageBtn()
        {
            NavigationService.NavigateAsync("GreenZonesPage");
        }
        private void OnBlueZonesPageBtn()
        {
            NavigationService.NavigateAsync("BlueZonesPage");
        }
        private void OnRedZonesPageBtn()
        {
            NavigationService.NavigateAsync("RedZonesPage");
        }
        private void OnYellowZonesPageBtn()
        {
            NavigationService.NavigateAsync("YellowZonesPage");
        }
    }


}
