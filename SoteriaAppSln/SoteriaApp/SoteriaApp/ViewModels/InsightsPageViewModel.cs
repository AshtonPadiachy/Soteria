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
    public class InsightsPageViewModel : ViewModelBase
    {
        public InsightsPageViewModel(INavigationService nav) : base(nav)
        {
            Title = "Insights";
            //button navigation for varioustypepage
            VariousTypeBtnCommand = new Command(OnVariousTypeBtn);
        }

        public ICommand VariousTypeBtnCommand { get; }

        private void OnVariousTypeBtn()
        {
            NavigationService.NavigateAsync("VariousTypePage");
        }
    }
}
