using Prism.Navigation;
using SoteriaApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SoteriaApp.ViewModels
{
    public class ProfilePageFlyoutViewModel : ViewModelBase
    {
        public ObservableCollection<ProfilePageFlyoutMenuItem> MenuItems { get; set; }

        public ProfilePageFlyoutViewModel(INavigationService navigationService) : base(navigationService)
        {
            MenuItems = new ObservableCollection<ProfilePageFlyoutMenuItem>(new[]
            {
                    new ProfilePageFlyoutMenuItem { Id = 0, Title = "Settings" ,TargetType = typeof(SettingPage)},
                    new ProfilePageFlyoutMenuItem { Id = 1, Title = "Helpline" ,TargetType = typeof(HelplinePage)},
                    new ProfilePageFlyoutMenuItem { Id = 2, Title = "Profile" ,TargetType = typeof(ProfilePageDetail)},

                });
        }

    }

}
