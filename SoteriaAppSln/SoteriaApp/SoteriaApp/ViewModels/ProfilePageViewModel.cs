using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SoteriaApp.Services.Interfaces;
using SoteriaProjectWebApi.enums;
using SoteriaProjectWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoteriaApp.ViewModels
{
    public class ProfilePageViewModel : ViewModelBase
    {
        private ISoteriaService _soteriaService;

        private DelegateCommand _createLearnerCommand;
        
        private DelegateCommand _createReportCommand;
        public DelegateCommand CreateLearnerCommand =>
            _createLearnerCommand ?? (_createLearnerCommand = new DelegateCommand(ExecuteCreateLearnerCommand));
        //public DelegateCommand DeleteLearnerCommand => _deleteLearnerCommand ?? (_deleteLearnerCommand = new DelegateCommand(ExecuteDeleteLearnerCommand));

        private void ExecuteDeleteLearnerCommand()
        {
            throw new NotImplementedException();
        }

        public DelegateCommand CreateReportCommand => _createReportCommand ?? (_createReportCommand = new DelegateCommand(ExecuteCreateReportCommand));

        void ExecuteCreateReportCommand()
        {
            var report = new Report();

            var zone = new Zone();
            zone.ZoneId = (int)ZonesEnum.Red;
            report.Zone = zone;
        }

        void ExecuteCreateLearnerCommand()
        {

            // TODO Change this to work from UI
            var learnerProfile = new LearnerProfile();

            learnerProfile.LearnerGender = (int)GenderEnum.Male;
            learnerProfile.LearnerGrade = (int)GradeEnum.GradeThree;

            _soteriaService.CreateNewLearnerProfile(learnerProfile);
        }

        public ProfilePageViewModel(INavigationService navigationService, ISoteriaService soteriaService) : base (navigationService)
        {
            _soteriaService = soteriaService;
        }
    }
}
