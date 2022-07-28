﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SoteriaApp.Views;
using SoteriaApp.Services.Interfaces;
using SoteriaProjectWebApi.enums;
using SoteriaProjectWebApi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace SoteriaApp.ViewModels
{
    public class ProfilePageViewModel : ViewModelBase
    {

        DelegateCommand _createReportCommand;
        ISoteriaService _soteriaService;
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
        }


    }
}
