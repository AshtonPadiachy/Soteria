using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoteriaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SupportGroupsPage : ContentPage
    {
        public SupportGroupsPage()
        {
            InitializeComponent();
            BrowserLink.Source = "https://www.sadag.org/";
        }
    }
}