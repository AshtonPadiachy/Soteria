using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace SoteriaApp.ViewModels
{
    public class PupilReportPageViewModel : ViewModelBase
    {
        public PupilReportPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            PupilReportsBtnCommand = new Command(OnPupilReportsBtn);

        }

        public Command PupilReportsBtnCommand { get; }

        private void OnPupilReportsBtn()
        {
            NavigationService.NavigateAsync("ReportPage");
        }
    }

}
