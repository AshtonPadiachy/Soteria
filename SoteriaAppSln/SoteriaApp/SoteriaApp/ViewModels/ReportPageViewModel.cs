﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SoteriaApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoteriaApp.ViewModels
{
    public class ReportPageViewModel : ViewModelBase
    {
        private ISoteriaService _soteriaservice;


        public ReportPageViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
    }
}
