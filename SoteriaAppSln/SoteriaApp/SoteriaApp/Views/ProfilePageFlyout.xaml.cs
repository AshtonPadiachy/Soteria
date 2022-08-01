using Prism.Navigation;
using SoteriaApp.ViewModels;
using System;
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
       // public ListView ListView;

        public ProfilePageFlyout()
        {
            InitializeComponent();

//            BindingContext = new ProfilePageFlyoutViewModel();
//            ListView = MenuItemsListView;


        }

    }
}