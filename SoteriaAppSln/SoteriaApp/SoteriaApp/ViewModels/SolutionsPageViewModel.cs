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

        

        public SolutionsPageViewModel(INavigationService navigationService): base(navigationService)
        {
           

            ColourZonesBtnCommand = new Command(OnColourZonesBtn);

            CopingWithBtnCommand = new Command(OnCopingWithBtn);
        }

        public ICommand CopingWithBtnCommand { get; }
        public ICommand ColourZonesBtnCommand { get; }
       

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
