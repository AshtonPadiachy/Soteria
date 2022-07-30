using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoteriaApp.ViewModels
{
    public class SignsAndSymptomsPageViewModel : ViewModelBase
    {
        private DelegateCommand _anxietyType3BtnCommand;
        public DelegateCommand AnxietyType3BtnCommand =>

            _anxietyType3BtnCommand ?? (_anxietyType3BtnCommand = new DelegateCommand(OnAnxietyType3Btn));

        private void OnAnxietyType3Btn()
        {
            NavigationService.NavigateAsync("AnxietyTypePage2");
        }
        private DelegateCommand _ptsdType2BtnCommand;
        public DelegateCommand PtsdType2BtnCommand =>

            _ptsdType2BtnCommand ?? (_ptsdType2BtnCommand = new DelegateCommand(OnPtsdType2Btn));

       private void OnPtsdType2Btn()
        {
            NavigationService.NavigateAsync("PtsdPage2");
        }

        //button for dbd type 2 
        private DelegateCommand _dbdType2BtnCommand;
        public DelegateCommand DbdType2BtnCommand =>

            _dbdType2BtnCommand ?? (_dbdType2BtnCommand = new DelegateCommand(OnDbdType2Btn));

        private void OnDbdType2Btn()
        {
            NavigationService.NavigateAsync("DbdTypePage");
        }

        //button for depression type 2 
        private DelegateCommand _depTypeBtnCommand;
        public DelegateCommand DepTypeBtnCommand =>

            _depTypeBtnCommand ?? (_depTypeBtnCommand = new DelegateCommand(OnDepTypeBtn));

        private void OnDepTypeBtn()
        {
            NavigationService.NavigateAsync("DepressionTypePage");
        }
        public SignsAndSymptomsPageViewModel(INavigationService navigationService) :base(navigationService)
        {

        }
    }
}
