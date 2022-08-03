using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace SoteriaApp.ViewModels
{
    public class EmptyLearnersClassListPageViewModel : ViewModelBase
    {
        public EmptyLearnersClassListPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            EmptyLearnersClassListPageBtnCommand = new Command(OnEmptyLearnersClassListBtn);

        }

        public Command EmptyLearnersClassListPageBtnCommand { get; }

        private void OnEmptyLearnersClassListBtn()
        {
            NavigationService.NavigateAsync("LearnerDetailPage");
        }
    }
}

