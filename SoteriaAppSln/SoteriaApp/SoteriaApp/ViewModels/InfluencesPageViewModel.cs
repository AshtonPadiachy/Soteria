using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoteriaApp.ViewModels
{
    public class InfluencesPageViewModel : ViewModelBase
    {
        private DelegateCommand _dbdPage2Btn;
        public DelegateCommand DbdPage2Btn =>
            _dbdPage2Btn ?? (_dbdPage2Btn = new DelegateCommand(OnDbdPage2Btn));

       private void OnDbdPage2Btn()
        {
            NavigationService.NavigateAsync("DbdPage2");
        }
        private DelegateCommand _anxietyType2BtnCommand;
        public DelegateCommand AnxietyType2BtnCommand =>

            _anxietyType2BtnCommand ?? (_anxietyType2BtnCommand = new DelegateCommand(OnAnxietyType2Btn));

        private void OnAnxietyType2Btn()
        {
            NavigationService.NavigateAsync("AnxietyTypePage2");
        }
        private DelegateCommand _ptsdType3BtnCommand;
        public DelegateCommand PtsdType3BtnCommand =>

            _ptsdType3BtnCommand ?? (_ptsdType3BtnCommand = new DelegateCommand(OnPtsdType3Btn));

       private void OnPtsdType3Btn()
        {
                NavigationService.NavigateAsync("PtsdPage2");
        }
        public InfluencesPageViewModel(INavigationService nav) :base(nav)
        {

        }
    }
}
