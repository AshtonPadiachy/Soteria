using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoteriaApp.ViewModels
{
    public class LearnerDetailsPageViewModel : ViewModelBase
    {
        //private DelegateCommand _learnerDetailsBtn;
        //public DelegateCommand LearnerDetailsBtn =>
         //   _learnerDetailsBtn ?? (_learnerDetailsBtn = new DelegateCommand(OnLearnerDetailsBtnCommand));
        private void OnLearnerDetailsBtnCommand()
        {
           // NavigationService.NavigateAsync("LearnerReportsList");
        }
        public LearnerDetailsPageViewModel(INavigationService nav) : base(nav)
        {
        }
        public string LearnerName { get; set; }
        public string LearnerSurname { get; set; }
        public string LearnerAge { get; set; }
        public string LearnerGrade { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdNumber { get; set; }
        public string ParentName { get; set; }
        public string ParentSurname { get; set; }
        public string Email { get; set; }
        public string ParentAge { get; set; }
        public string ParentGender { get; set; }
        public string MaritalStatus { get; set; }
        public string ParentCellNumber { get; set; }
    }



    }

