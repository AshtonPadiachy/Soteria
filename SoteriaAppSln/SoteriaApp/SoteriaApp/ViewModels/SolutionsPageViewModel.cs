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
        public SolutionsPageViewModel(INavigationService navigationService): base(navigationService)
        {
            QuestionsBtnCommand = new Command(OnQuestionsBtn);
        }

        public ICommand QuestionsBtnCommand { get; }

        private void OnQuestionsBtn()
        {
            NavigationService.NavigateAsync("QuestionsToAskPage");
        }
    }
}
