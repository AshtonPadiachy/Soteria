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
    public class SolutionsPageViewModel : ViewModelBase
    {
        private DelegateCommand _questionsBtnCommand;
        public DelegateCommand QuestionsBtnCommand =>
            _questionsBtnCommand ?? (_questionsBtnCommand = new DelegateCommand(OnQuestionsBtn));

        private DelegateCommand _colourZonesBtnCommand;
        public DelegateCommand ColourZonesBtnCommand =>
            _colourZonesBtnCommand ?? (_colourZonesBtnCommand = new DelegateCommand(OnColourZonesBtn));

        private DelegateCommand _copingWithBtnCommand;
        public DelegateCommand CopingWithBtnCommand =>
            _copingWithBtnCommand ?? (_copingWithBtnCommand = new DelegateCommand(OnCopingWithBtn));

      

        public SolutionsPageViewModel(INavigationService navigationService): base(navigationService)
        {
           

        }
       

        private void OnCopingWithBtn()
        {
            NavigationService.NavigateAsync("CopingWithDisorders");
        }
        private void OnColourZonesBtn()
        {
            NavigationService.NavigateAsync("ZonePage");
        }

        private void OnQuestionsBtn()
        {
            NavigationService.NavigateAsync("QuestionsToAskPage");
        }

        
    }
}
