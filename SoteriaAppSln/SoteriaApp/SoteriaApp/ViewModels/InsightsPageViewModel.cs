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
        //button for signs and symptoms page
        private DelegateCommand _signsAndSymptomsBtnCommand;
        public DelegateCommand SignsAndSymptomsBtnCommand =>
            _signsAndSymptomsBtnCommand ?? (_signsAndSymptomsBtnCommand = new DelegateCommand(OnSignsAndSymptomsBtn));
        private void OnSignsAndSymptomsBtn()
        {
            NavigationService.NavigateAsync("SignsAndSymptomsPage");
        }

        //button for influences page
        private DelegateCommand _influencesBtnCommand;
        public DelegateCommand InfluencesBtnCommand =>
            _influencesBtnCommand ?? (_influencesBtnCommand = new DelegateCommand(OnInfluencesBtn));

        private void OnInfluencesBtn()
        {
            NavigationService.NavigateAsync("InfluencesPage");
        }
        public InsightsPageViewModel(INavigationService nav) : base(nav)
        {
            Title = "Insights";
            //button navigation for varioustypepage
            VariousTypeBtnCommand = new Command(OnVariousTypeBtn);

            //button navigation for solutionspage
            SolutionsBtnCommand = new Command(OnSolutionsBtn);

            //button navigation for the whatismentalhealthpage
            WhatIsMentalHealthBtnCommand = new Command(OnWhatIsMentalHealthBtn);
        }

        public ICommand WhatIsMentalHealthBtnCommand { get;}
        public ICommand VariousTypeBtnCommand { get; }

        public ICommand SolutionsBtnCommand { get; }

        private void OnWhatIsMentalHealthBtn()
        {
            NavigationService.NavigateAsync("WhatIsMentalHealthPage");
        }
        private void OnSolutionsBtn()
        {
            NavigationService.NavigateAsync("SolutionsPage");
        }
        private void OnVariousTypeBtn()
        {
            NavigationService.NavigateAsync("VariousTypePage");
        }

        
    }
}
