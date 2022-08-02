using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Essentials.Interfaces;

namespace SoteriaApp.ViewModels
{
    public class SettingPageViewModel : ViewModelBase
    {
       
        private readonly IPreferences _preferences;

        public SettingPageViewModel(INavigationService navigationService, IPreferences preferences)
            : base(navigationService)
        {
            _preferences = preferences;
        }

        public bool AlwaysShowTutorial
        {
            get => _preferences.Get("AlwaysShowTutorial", true);
            set => _preferences.Set("AlwaysShowTutorial", value);
        }
    }
}
