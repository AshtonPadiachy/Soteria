﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoteriaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePageFlyout : ContentPage
    {
        public ListView ListView;

        public ProfilePageFlyout()
        {
            InitializeComponent();

            BindingContext = new ProfilePageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class ProfilePageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ProfilePageFlyoutMenuItem> MenuItems { get; set; }

            public ProfilePageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<ProfilePageFlyoutMenuItem>(new[]
                {
                    new ProfilePageFlyoutMenuItem { Id = 0, Title = "Settings" ,TargetType = typeof(SettingPage)},
                    new ProfilePageFlyoutMenuItem { Id = 1, Title = "Helpline" ,TargetType = typeof(HelplinePage)},
                    new ProfilePageFlyoutMenuItem { Id = 1, Title = "Profile" ,TargetType = typeof(ProfilePageDetail)},

                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}