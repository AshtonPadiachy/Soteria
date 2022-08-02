using Prism.Commands;
using Prism.Navigation;
using SoteriaApp.Services.Interfaces;
using SoteriaApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SoteriaApp.ViewModels
{
    public class ProfilePageFlyoutViewModel : ViewModelBase
    {

   
       // ISoteriaService _soteriaService;
        public ObservableCollection<ProfilePageFlyoutMenuItem> MenuItems { get; set; }
        private DelegateCommand<ProfilePageFlyoutMenuItem> _menuSelectedCommand;
        public DelegateCommand<ProfilePageFlyoutMenuItem> MenuSelectedCommand =>
            _menuSelectedCommand ?? (_menuSelectedCommand = new DelegateCommand<ProfilePageFlyoutMenuItem>(ExecuteMenuSelectedCommand));

        async void ExecuteMenuSelectedCommand(ProfilePageFlyoutMenuItem item)
        {

            var pageName = item.TargetType.Name;
            await NavigationService.NavigateAsync("NavigationPage/" + pageName);

        }


        public ProfilePageFlyoutViewModel(INavigationService navigationService) : base(navigationService)
        {

            MenuItems = new ObservableCollection<ProfilePageFlyoutMenuItem>(new[]
{
                    new ProfilePageFlyoutMenuItem { Id = 0, Title = "Settings" ,TargetType = typeof(SettingPage)},
                    new ProfilePageFlyoutMenuItem { Id = 1, Title = "Helpline" ,TargetType = typeof(HelplinePage)},
                    new ProfilePageFlyoutMenuItem { Id = 2, Title = "Saved Insights" ,TargetType = typeof(ProfilePageDetail)},

                });


        }

    }

}
