using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SoteriaApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace SoteriaApp.ViewModels
{
    public class ReportPageViewModel : ViewModelBase
    {
        private DelegateCommand _cancelBtn;
        public DelegateCommand CancelBtn =>
            _cancelBtn ?? (_cancelBtn = new DelegateCommand(OnCancelBtn));

       private void OnCancelBtn()
        {
            NavigationService.NavigateAsync("PupilReportPage");
        }
        private DelegateCommand _deleteBtn;
        public DelegateCommand DeleteBtn =>
            _deleteBtn ?? (_deleteBtn = new DelegateCommand(OnDeleteBtn));

        private void OnDeleteBtn()
        {
            NavigationService.NavigateAsync("PupilReportPage");
        }
        private DelegateCommand _saveBtn;
        public DelegateCommand SaveBtn =>
            _saveBtn ?? (_saveBtn = new DelegateCommand(OnSaveBtn));

        private void OnSaveBtn()
        {
            NavigationService.NavigateAsync("LearnerReportsList");
        }



        public ReportPageViewModel(INavigationService navigationService) : base(navigationService)
        {

        }


        public IList<string> ZonesOfRegulation
        {
            get
            {
                return new List<string> { " Green ", " Yellow ", " Blue ", " Red " };
            }
           
        }

       


    }
}


